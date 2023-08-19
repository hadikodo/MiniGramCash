using MiniGram.Classes;
using MiniGram.LINQ;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGram.Forms
{
    public partial class EditProductForm : Form
    {
        private int productID;

        public EditProductForm(int PID)
        {
            productID = PID;
            InitializeComponent();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(productname_txt.Text) || barcode_txt.Text.Length < 3 || string.IsNullOrEmpty(sell_price_txt.Text) || string.IsNullOrEmpty(init_price_txt.Text) || string.IsNullOrEmpty(txtSecondaryPrice.Text))
            {
                warning_lable.Visible = true;
            }
            else
            {
                if (!chkboxHasDiscount.Checked)
                    txtDiscountPercentage.Text = "0";
                if (!chkboxHasQte.Checked)
                {
                    quantity_txt.Text = "0";
                    using (var cnx = new MiniGramDBDataContext(Globals.ConnectionString))
                    {
                        if (!chkboxHasQte.Checked)
                        {
                            try
                            {
                                int sid = cnx.sp_getSIDBySNAME(supp_cbox.SelectedItem.ToString()).ToList()[0].SID;
                                cnx.sp_UpdateProduct(productID, productname_txt.Text, barcode_txt.Text, Int32.Parse(quantity_txt.Text), Math.Round(Convert.ToDouble(sell_price_txt.Text),3), false, sid, chkboxHasQte.Checked, chkboxHasTVA.Checked, (init_price_txt.Text=="")?0: Math.Round(Convert.ToDouble(init_price_txt.Text), 3), Math.Round(Convert.ToDouble(txtSecondaryPrice.Text), 3), Int32.Parse(txtDiscountPercentage.Text.ToString()), chkboxHasDiscount.Checked);
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Something Went Wrong, The Product Not Updated, Please Call The Support!!");
                                this.Close();
                            }
                            MessageBox.Show("Product Update Successfully.");
                            this.Close();
                        }
                        else
                        {
                            try
                            {
                                int sid = cnx.sp_getSIDBySNAME(supp_cbox.SelectedItem.ToString()).ToList()[0].SID;
                                int TotalQuantity = (from aj in cnx.TBLEXPIREDDATEs where aj.PID == productID where aj.ExpiredDate > DateTime.Today  select aj.Qte).ToList().Sum(x => Convert.ToInt32(x));
                                cnx.sp_UpdateProduct(productID, productname_txt.Text, barcode_txt.Text, TotalQuantity, Math.Round(Convert.ToDouble(sell_price_txt.Text), 3), false, sid, chkboxHasQte.Checked, chkboxHasTVA.Checked, (init_price_txt.Text == "") ? 0 : Math.Round(Convert.ToDouble(init_price_txt.Text), 3), Math.Round(Convert.ToDouble(txtSecondaryPrice.Text), 3), Int32.Parse(txtDiscountPercentage.Text.ToString()), chkboxHasDiscount.Checked);
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Something Went Wrong, The Product Not Updated, Please Call The Support!!");
                                this.Close();
                            }
                            MessageBox.Show("Product Update Successfully.");
                            this.Close();
                        }
                    }
                }
                else
                {
                    if (quantity_txt.Text == "")
                    {
                        warning_lable.Visible = true;
                    }
                    else
                    {
                        using (MiniGramDBDataContext cnx = new MiniGramDBDataContext(Globals.ConnectionString))
                        {
                            try
                            {
                                int sid = cnx.sp_getSIDBySNAME(supp_cbox.SelectedItem.ToString()).ToList()[0].SID;
                                cnx.sp_UpdateProduct(productID, productname_txt.Text, barcode_txt.Text, Int32.Parse(quantity_txt.Text), Math.Round(Convert.ToDouble(sell_price_txt.Text), 3), true, sid, chkboxHasQte.Checked, chkboxHasTVA.Checked, (init_price_txt.Text == "") ? 0 : Math.Round(Convert.ToDouble(init_price_txt.Text), 3), Math.Round(Convert.ToDouble(txtSecondaryPrice.Text), 3), Int32.Parse(txtDiscountPercentage.Text.ToString()), chkboxHasDiscount.Checked);
                                MessageBox.Show("Product Update Successfully.");
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Something Went Wrong, The Product Not Updated, Please Call The Support!!");
                            }

                            this.Close();
                        }
                    }
                }
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditProductForm_Load(object sender, EventArgs e)
        {
            warning_lable.Visible = false;
            using (var cnx = new MiniGramDBDataContext(Globals.ConnectionString))
            {
                var suppList = cnx.sp_select_suppliers("").ToList();
                foreach (var supp in suppList)
                {
                    supp_cbox.Items.Add(supp.SupplierName);
                }

                var product = (from p in cnx.TBLPRODUCTs
                               where p.PID == productID
                               select p).ToList();

                if (product != null)
                {
                    barcode_txt.Text = product[0].BARCODE;
                    productname_txt.Text = product[0].PNAME;
                    chkboxHasQte.Checked = (bool)product[0].HasQuantity;
                    chkboxHasQte.Checked = product[0].HasExpiredDate == 1;
                    quantity_txt.Text = product[0].QTE.ToString();
                    quantity_txt.Enabled = (bool)product[0].HasQuantity;
                    txtDiscountPercentage.Enabled = (bool)product[0].HasDiscount;
                    sell_price_txt.Text = product[0].PRICE.ToString();
                    chkboxHasTVA.Checked = product[0].HasTVA;
                    init_price_txt.Text = product[0].InitPrice.ToString();
                    txtSecondaryPrice.Text = product[0].SecondaryPrice.ToString();
                    chkboxHasDiscount.Checked = product[0].HasDiscount;
                    txtDiscountPercentage.Text = product[0].DiscountPercentage.ToString();
                    try
                    {
                        supp_cbox.SelectedIndex = supp_cbox.Items.IndexOf(cnx.sp_getSupplierByID(product[0].SID).ToList()[0].SNAME);
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }

            ActiveControl = productname_txt;
        }

        private void quantity_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = false;
            }
        }

        private void price_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = false;
            }
        }

        private void hasqte_combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void keyboard_btn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = @"C:\Windows\System32\osk.exe";
            Process process = new Process();
            process.StartInfo = ps;
            process.Start();
            ActiveControl = productname_txt;
        }

        private void checkBoxAdv1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHasExpDate.Checked)
            {
                chkboxHasQte.Checked = false;
                btnExpiredDate.Enabled = true;
            }
            else
            {
                btnExpiredDate.Enabled = false;
            }
        }

        private void checkBoxAdv2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxHasQte.Checked)
            {
                checkBoxHasExpDate.Checked = false;
                quantity_txt.Enabled = true;
            }
            else
            {
                quantity_txt.Enabled = false;
            }
        }

        private void btnExpiredDate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(productname_txt.Text) || barcode_txt.Text.Length < 3 || string.IsNullOrEmpty(sell_price_txt.Text) || string.IsNullOrEmpty(init_price_txt.Text) || string.IsNullOrEmpty(txtSecondaryPrice.Text))
            {
                warning_lable.Visible = true;
            }
            else
            {
                if (!chkboxHasDiscount.Checked)
                    txtDiscountPercentage.Text = "0";
                if (!chkboxHasQte.Checked)
                {
                    quantity_txt.Text = "0";
                    using (var cnx = new MiniGramDBDataContext(Globals.ConnectionString))
                    {

                        if (!chkboxHasQte.Checked)
                        {
                            try
                            {
                                int sid = cnx.sp_getSIDBySNAME(supp_cbox.SelectedItem.ToString()).ToList()[0].SID;
                                cnx.sp_UpdateProduct(productID, productname_txt.Text, barcode_txt.Text, Int32.Parse(quantity_txt.Text), Math.Round(Convert.ToDouble(sell_price_txt.Text), 3), false, sid, chkboxHasQte.Checked, chkboxHasTVA.Checked, (init_price_txt.Text == "") ? 0 : Math.Round(Convert.ToDouble(init_price_txt.Text), 3), Math.Round(Convert.ToDouble(txtSecondaryPrice.Text), 3), Int32.Parse(txtDiscountPercentage.Text.ToString()), chkboxHasDiscount.Checked);
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Something Went Wrong, The Product Not Updated, Please Call The Support!!");
                                this.Close();
                            }
                            ExpiredDateForm frm = new ExpiredDateForm(productname_txt.Text, Int32.Parse((from aj in cnx.TBLPRODUCTs where aj.BARCODE == barcode_txt.Text select aj.PID).Single().ToString()));
                            frm.ShowDialog();
                        }
                        else
                        {
                            try
                            {
                                int sid = cnx.sp_getSIDBySNAME(supp_cbox.SelectedItem.ToString()).ToList()[0].SID;
                                int TotalQuantity = (from aj in cnx.TBLEXPIREDDATEs where aj.PID == productID && aj.ExpiredDate > DateTime.Today select aj.Qte).ToList().Sum(x => Convert.ToInt32(x));
                                cnx.sp_UpdateProduct(productID, productname_txt.Text, barcode_txt.Text, TotalQuantity, Math.Round(Convert.ToDouble(sell_price_txt.Text), 3), false, sid, chkboxHasQte.Checked, chkboxHasTVA.Checked, (init_price_txt.Text == "") ? 0 : Math.Round(Convert.ToDouble(init_price_txt.Text), 3), Math.Round(Convert.ToDouble(txtSecondaryPrice.Text), 3), Int32.Parse(txtDiscountPercentage.Text.ToString()), chkboxHasDiscount.Checked);
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Something Went Wrong, The Product Not Updated, Please Call The Support!!");
                                this.Close();
                            }
                            ExpiredDateForm frm = new ExpiredDateForm(productname_txt.Text, Int32.Parse((from aj in cnx.TBLPRODUCTs where aj.BARCODE == barcode_txt.Text select aj.PID).Single().ToString()));
                            frm.ShowDialog();
                        }
                    }
                }
                else
                {
                    if (quantity_txt.Text == "")
                    {
                        warning_lable.Visible = true;
                    }
                    else
                    {
                        using (MiniGramDBDataContext cnx = new MiniGramDBDataContext(Globals.ConnectionString))
                        {
                            try
                            {
                                int sid = cnx.sp_getSIDBySNAME(supp_cbox.SelectedItem.ToString()).ToList()[0].SID;
                                cnx.sp_UpdateProduct(productID, productname_txt.Text, barcode_txt.Text, Int32.Parse(quantity_txt.Text), Math.Round(Convert.ToDouble(sell_price_txt.Text), 3), true, sid, chkboxHasQte.Checked, chkboxHasTVA.Checked, (init_price_txt.Text == "") ? 0 : Math.Round(Convert.ToDouble(init_price_txt.Text), 3), Math.Round(Convert.ToDouble(txtSecondaryPrice.Text), 3), Int32.Parse(txtDiscountPercentage.Text.ToString()), chkboxHasDiscount.Checked);
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Something Went Wrong, The Product Not Updated, Please Call The Support!!");
                            }
                        }
                    }
                }
            }
        }

        private void chkboxTVA_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxHasTVA.Checked)
            {
                textTVADesc.Text = Properties.Settings.Default.TVAPercentage.ToString() + "% TVA * Sell Price";
            }
            else
            {
                textTVADesc.Text = "";
            }
        }

        private void chkboxHasDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxHasDiscount.Checked)
            {
                txtDiscountPercentage.Enabled = true;
            }
            else
            {
                txtDiscountPercentage.Enabled = false;
            }
        }

        private void productname_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                this.ProcessTabKey(true);
            }
        }

        private void barcode_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                this.ProcessTabKey(true);
            }
        }

        private void supp_cbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                this.ProcessTabKey(true);
            }
        }

        private void sell_price_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                this.ProcessTabKey(true);
            }
        }

        private void txtSecondaryPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                this.ProcessTabKey(true);
            }
        }

        private void init_price_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                this.ProcessTabKey(true);
            }
        }
    }
}
