using MiniGram.Classes;
using MiniGram.LINQ;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGram.Forms
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddSupplierForm_Load(object sender, EventArgs e)
        {
            warning_lable.Visible = false;
            checkBoxAdv2.Checked = false;
            checkBoxAdv1.Checked = false;
            chkboxHasDiscount.Checked = false;
            using (var cnx = new MiniGramDBDataContext(Globals.ConnectionString))
            {
                var suppList = cnx.sp_select_suppliers("").ToList();
                foreach(var supp in suppList)
                {
                    supp_cbox.Items.Add(supp.SupplierName);
                }
            }
            //supp_cbox.SelectedIndex = 0;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            List<LINQ.TBLPRODUCT> products = new List<TBLPRODUCT>();
            using (var cnx = new MiniGramDBDataContext(Globals.ConnectionString))
            {
                products = (from aj in cnx.TBLPRODUCTs where aj.BARCODE == barcode_txt.Text select aj).ToList();
            }
            if (products.Count > 0)
            {
                MessageBox.Show("This Product is Already Exist !!", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (string.IsNullOrEmpty(productname_txt.Text) || barcode_txt.Text.Length < 3 || string.IsNullOrEmpty(sell_price_txt.Text) || string.IsNullOrEmpty(init_price_txt.Text) || string.IsNullOrEmpty(txtSecondaryPrice.Text))
            {
                warning_lable.Visible = true;
            }
            else
            {                
                if (string.IsNullOrEmpty(barcode_txt.Text))
                    barcode_txt.Text = "0";
                if (!chkboxHasDiscount.Checked)
                    txtDiscountPercentage.Text = "0";
                if (!checkBoxAdv2.Checked)
                {
                    quantity_txt.Text = "0";
                    using (var cnx = new MiniGramDBDataContext(Globals.ConnectionString))
                    {
                        try
                        {
                            int sid = cnx.sp_getSIDBySNAME(supp_cbox.SelectedItem.ToString()).ToList()[0].SID;
                            cnx.sp_addNewProduct(productname_txt.Text,barcode_txt.Text, Int32.Parse(quantity_txt.Text), Math.Round(Convert.ToDouble(sell_price_txt.Text),3), false,sid, checkBoxAdv1.Checked,chkboxHasTVA.Checked, (init_price_txt.Text == "") ? 0 : Math.Round(Convert.ToDouble(init_price_txt.Text), 3), Math.Round(Convert.ToDouble(txtSecondaryPrice.Text), 3), Int32.Parse(txtDiscountPercentage.Text.ToString()), chkboxHasDiscount.Checked);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Something Went Wrong, The New Product Not Added, Please Call The Support!!");
                            this.Close();
                        }
                        MessageBox.Show("New Product Added Successfully.");
                        this.Close();
                    }
                }
                else
                {
                    if(string.IsNullOrEmpty(quantity_txt.Text))
                        warning_lable.Visible=true;
                    else
                    {
                        using (var cnx = new MiniGramDBDataContext(Globals.ConnectionString))
                        {
                            try
                            {
                                int sid = cnx.sp_getSIDBySNAME(supp_cbox.SelectedItem.ToString()).ToList()[0].SID;
                                cnx.sp_addNewProduct(productname_txt.Text, barcode_txt.Text, Int32.Parse(quantity_txt.Text), Math.Round(Convert.ToDouble(sell_price_txt.Text),3), true,sid, checkBoxAdv1.Checked, chkboxHasTVA.Checked, (init_price_txt.Text == "") ? 0 : Math.Round(Convert.ToDouble(init_price_txt.Text), 3), Math.Round(Convert.ToDouble(txtSecondaryPrice.Text), 3), Int32.Parse(txtDiscountPercentage.Text.ToString()), chkboxHasDiscount.Checked);
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Something Went Wrong, The New Product Not Added, Please Call The Support!!");
                                this.Close();
                            }
                            MessageBox.Show("New Product Added Successfully.");
                            this.Close();
                        }
                    }
                }
            }
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

        private void barcode_txt_KeyPress(object sender, KeyPressEventArgs e)
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
            if (checkBoxAdv1.Checked)
            {
                checkBoxAdv2.Checked = false;
                btnExpiredDate.Enabled = true;
            }
            else
            {
                btnExpiredDate.Enabled = false;
            }
        }

        private void checkBoxAdv2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAdv2.Checked)
            {
                checkBoxAdv1.Checked = false;
                quantity_txt.Enabled = true;
            }
            else
            {
                quantity_txt.Enabled = false;
            }
        }

        private void btnExpiredDate_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do You Want To Save This Product??","Info",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(productname_txt.Text) || barcode_txt.Text.Length < 3 || string.IsNullOrEmpty(sell_price_txt.Text) || string.IsNullOrEmpty(init_price_txt.Text) || string.IsNullOrEmpty(txtSecondaryPrice.Text))
                {
                    warning_lable.Visible = true;
                }
                else
                {
                    if (string.IsNullOrEmpty(barcode_txt.Text))
                        barcode_txt.Text = "0";
                    if (!chkboxHasDiscount.Checked)
                        txtDiscountPercentage.Text = "0";
                    if (!checkBoxAdv2.Checked)
                    {
                        quantity_txt.Text = "0";
                        using (var cnx = new MiniGramDBDataContext(Globals.ConnectionString))
                        {
                            if (!checkBoxAdv1.Checked)
                            {
                                try
                                {
                                    int sid = cnx.sp_getSIDBySNAME(supp_cbox.SelectedItem.ToString()).ToList()[0].SID;
                                    cnx.sp_addNewProduct(productname_txt.Text, barcode_txt.Text, Int32.Parse(quantity_txt.Text), Math.Round(Convert.ToDouble(sell_price_txt.Text), 3), false, sid, checkBoxAdv1.Checked, chkboxHasTVA.Checked, (init_price_txt.Text == "") ? 0 : Math.Round(Convert.ToDouble(init_price_txt.Text), 3), Math.Round(Convert.ToDouble(txtSecondaryPrice.Text), 3), Int32.Parse(txtDiscountPercentage.Text.ToString()),chkboxHasDiscount.Checked);
                                }
                                catch (Exception)
                                {
                                    MessageBox.Show("Something Went Wrong, The New Product Not Added, Please Call The Support!!");
                                    this.Close();
                                }
                            }
                            else
                            {
                                int sid = 0;
                                try
                                {
                                    sid = cnx.sp_getSIDBySNAME(supp_cbox.SelectedItem.ToString()).ToList()[0].SID;
                                    cnx.sp_addNewProduct(productname_txt.Text, barcode_txt.Text, 0, Math.Round(Convert.ToDouble(sell_price_txt.Text), 3), false, sid, checkBoxAdv1.Checked, chkboxHasTVA.Checked, (init_price_txt.Text == "") ? 0 : Math.Round(Convert.ToDouble(init_price_txt.Text), 3), Math.Round(Convert.ToDouble(txtSecondaryPrice.Text), 3), Int32.Parse(txtDiscountPercentage.Text.ToString()), chkboxHasDiscount.Checked);
                                }
                                catch (Exception)
                                {
                                    MessageBox.Show("Something Went Wrong, The New Product Not Added, Please Call The Support!!");
                                    this.Close();
                                }
                                ExpiredDateForm frm = new ExpiredDateForm(productname_txt.Text, Int32.Parse((from aj in cnx.TBLPRODUCTs where aj.BARCODE == barcode_txt.Text select aj.PID).Single().ToString()));
                                frm.ShowDialog();
                                int productID = Int32.Parse((from aj in cnx.TBLPRODUCTs where aj.BARCODE == barcode_txt.Text select aj.PID).Single().ToString());
                                int TotalQuantity = (from aj in cnx.TBLEXPIREDDATEs where aj.PID == productID && aj.ExpiredDate > DateTime.Today  select aj.Qte).ToList().Sum(x => Convert.ToInt32(x));
                                cnx.sp_UpdateProduct(productID, productname_txt.Text, barcode_txt.Text, TotalQuantity, Math.Round(Convert.ToDouble(sell_price_txt.Text), 3), false, sid, checkBoxAdv1.Checked, chkboxHasTVA.Checked, (init_price_txt.Text == "") ? 0 : Math.Round(Convert.ToDouble(init_price_txt.Text), 3), Math.Round(Convert.ToDouble(txtSecondaryPrice.Text), 3), Int32.Parse(txtDiscountPercentage.Text.ToString()), chkboxHasDiscount.Checked);
                                this.Close();
                            }
                        }
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(quantity_txt.Text))
                            warning_lable.Visible = true;
                        else
                        {
                            using (var cnx = new MiniGramDBDataContext(Globals.ConnectionString))
                            {
                                try
                                {
                                    int sid = cnx.sp_getSIDBySNAME(supp_cbox.SelectedItem.ToString()).ToList()[0].SID;
                                    cnx.sp_addNewProduct(productname_txt.Text, barcode_txt.Text, Int32.Parse(quantity_txt.Text), Math.Round(Convert.ToDouble(sell_price_txt.Text), 3), true, sid, checkBoxAdv1.Checked, chkboxHasTVA.Checked, (init_price_txt.Text == "") ? 0 : Math.Round(Convert.ToDouble(init_price_txt.Text), 3), Math.Round(Convert.ToDouble(txtSecondaryPrice.Text), 3), Int32.Parse(txtDiscountPercentage.Text.ToString()), chkboxHasDiscount.Checked);
                                }
                                catch (Exception)
                                {
                                    MessageBox.Show("Something Went Wrong, The New Product Not Added, Please Call The Support!!");
                                    this.Close();
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                return;
            }
        }

        private void chkboxHasTVA_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxHasTVA.Checked)
            {
                txtTVADesc.Text = Properties.Settings.Default.TVAPercentage.ToString() + "% TVA * Sell Price";
            }
            else
            {
                txtTVADesc.Text = "";
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
    }
}
