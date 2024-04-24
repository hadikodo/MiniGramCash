using MiniGram.Classes;
using MiniGram.LINQ;
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
            if (cboxCurrencies.SelectedItem == null || supp_cbox.SelectedItem == null || string.IsNullOrEmpty(productname_txt.Text) || string.IsNullOrEmpty(sell_price_txt.Text) || string.IsNullOrEmpty(init_price_txt.Text) || string.IsNullOrEmpty(txtSecondaryPrice.Text))
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
                }
                using (var cnx = new MiniGramDBDataContext(Globals.ConnectionString))
                {

                    TBLPRODUCT product = (from aj in cnx.TBLPRODUCTs where aj.PID == productID select aj).SingleOrDefault();

                    if (!chkboxHasExpDate.Checked)
                    {
                        try
                        {
                            product.PNAME = productname_txt.Text.Trim();
                            product.BARCODE = barcode_txt.Text.Trim();
                            product.QTE = Int32.Parse(quantity_txt.Text);
                            product.PRICE = Math.Round(Convert.ToDouble(sell_price_txt.Text), 3);
                            product.HasQuantity = chkboxHasQte.Checked;
                            product.SID = Int32.Parse(supp_cbox.SelectedValue.ToString());
                            product.HasExpiredDate = chkboxHasExpDate.Checked ? 1 : 0;
                            product.HasTVA = chkboxHasTVA.Checked;
                            product.InitPrice = (init_price_txt.Text == "") ? 0 : Math.Round(Convert.ToDouble(init_price_txt.Text), 3);
                            product.SecondaryPrice = Math.Round(Convert.ToDouble(txtSecondaryPrice.Text), 3);
                            product.DiscountPercentage = Int32.Parse(txtDiscountPercentage.Text.ToString());
                            product.HasDiscount = chkboxHasDiscount.Checked;
                            product.CurrencyID = Int32.Parse(cboxCurrencies.SelectedValue.ToString());
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Something Went Wrong, The Product Not Updated, Please Call The Support!!");
                            this.Close();
                        }
                    }
                    else
                    {
                        try
                        {
                            int TotalQuantity = (from aj in cnx.TBLEXPIREDDATEs where aj.PID == productID where aj.ExpiredDate > DateTime.Today select aj.Qte).ToList().Sum(x => Convert.ToInt32(x));
                            product.PNAME = productname_txt.Text.Trim();
                            product.BARCODE = barcode_txt.Text.Trim();
                            product.QTE = TotalQuantity;
                            product.PRICE = Math.Round(Convert.ToDouble(sell_price_txt.Text), 3);
                            product.HasQuantity = chkboxHasQte.Checked;
                            product.SID = Int32.Parse(supp_cbox.SelectedValue.ToString());
                            product.HasExpiredDate = chkboxHasExpDate.Checked ? 1 : 0;
                            product.HasTVA = chkboxHasTVA.Checked;
                            product.InitPrice = (init_price_txt.Text == "") ? 0 : Math.Round(Convert.ToDouble(init_price_txt.Text), 3);
                            product.SecondaryPrice = Math.Round(Convert.ToDouble(txtSecondaryPrice.Text), 3);
                            product.DiscountPercentage = Int32.Parse(txtDiscountPercentage.Text.ToString());
                            product.HasDiscount = chkboxHasDiscount.Checked;
                            product.CurrencyID = Int32.Parse(cboxCurrencies.SelectedValue.ToString());
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Something Went Wrong, The Product Not Updated, Please Call The Support!!");
                            this.Close();
                        }


                    }
                    cnx.SubmitChanges();
                    MessageBox.Show("Product Update Successfully.");
                    this.Close();
                }
                //}
                //else
                //{
                //    if (quantity_txt.Text == "")
                //    {
                //        warning_lable.Visible = true;
                //    }
                //    else
                //    {
                //        using (MiniGramDBDataContext cnx = new MiniGramDBDataContext(Globals.ConnectionString))
                //        {
                //            try
                //            {
                //                int sid = int.Parse(supp_cbox.SelectedValue.ToString());
                //                cnx.sp_UpdateProduct(productID, productname_txt.Text.Trim(), barcode_txt.Text.Trim(), Int32.Parse(quantity_txt.Text.Trim()), Math.Round(Convert.ToDouble(sell_price_txt.Text.Trim()), 3), true, sid, chkboxHasExpDate.Checked, chkboxHasTVA.Checked, (init_price_txt.Text == "") ? 0 : Math.Round(Convert.ToDouble(init_price_txt.Text.Trim()), 3), Math.Round(Convert.ToDouble(txtSecondaryPrice.Text.Trim()), 3), Int32.Parse(txtDiscountPercentage.Text.Trim().ToString()), chkboxHasDiscount.Checked);
                //                MessageBox.Show("Product Update Successfully.");
                //            }
                //            catch (Exception)
                //            {
                //                MessageBox.Show("Something Went Wrong, The Product Not Updated, Please Call The Support!!");
                //            }

                //            this.Close();
                //        }
                //    }
                //}
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

                tBLSUPPLIERBindingSource.DataSource = (from aj in cnx.TBLSUPPLIERs select aj).ToList();
                tBLCURRENCyBindingSource.DataSource = (from aj in cnx.TBLCURRENCies select aj).ToList();

                lblCost.Text = "⫸ Cost ( " + cboxCurrencies.Text + " ) :";
                lblEmpPrice.Text = "⫸ Emp. Price ( " + cboxCurrencies.Text + " ) :";
                lblSellPrice.Text = "⫸ Sell Price ( " + cboxCurrencies.Text + " ) :";


                var product = (from p in cnx.TBLPRODUCTs
                               where p.PID == productID
                               select p).ToList();

                if (product != null)
                {
                    barcode_txt.Text = product[0].BARCODE;
                    productname_txt.Text = product[0].PNAME;
                    chkboxHasQte.Checked = (bool)product[0].HasQuantity;
                    chkboxHasExpDate.Checked = product[0].HasExpiredDate == 1;
                    quantity_txt.Text = product[0].QTE.ToString();
                    quantity_txt.Enabled = (bool)product[0].HasQuantity;
                    txtDiscountPercentage.Enabled = (bool)product[0].HasDiscount;
                    sell_price_txt.Text = product[0].PRICE.ToString();
                    chkboxHasTVA.Checked = product[0].HasTVA;
                    init_price_txt.Text = product[0].InitPrice.ToString();
                    txtSecondaryPrice.Text = product[0].SecondaryPrice.ToString();
                    chkboxHasDiscount.Checked = product[0].HasDiscount;
                    txtDiscountPercentage.Text = product[0].DiscountPercentage.ToString();
                    cboxCurrencies.SelectedValue = product[0].CurrencyID;
                    try
                    {
                        supp_cbox.SelectedValue = product[0].SID;
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
            if (chkboxHasExpDate.Checked)
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
                chkboxHasExpDate.Checked = false;
                quantity_txt.Enabled = true;
            }
            else
            {
                quantity_txt.Enabled = false;
            }
        }

        private void btnExpiredDate_Click(object sender, EventArgs e)
        {
            if (cboxCurrencies.SelectedItem == null || supp_cbox.SelectedItem == null || string.IsNullOrEmpty(productname_txt.Text) || string.IsNullOrEmpty(sell_price_txt.Text) || string.IsNullOrEmpty(init_price_txt.Text) || string.IsNullOrEmpty(txtSecondaryPrice.Text))
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

                        if (!chkboxHasExpDate.Checked)
                        {
                            try
                            {
                                int sid = int.Parse(supp_cbox.SelectedValue.ToString());
                                cnx.sp_UpdateProduct(productID, productname_txt.Text, barcode_txt.Text, Int32.Parse(quantity_txt.Text), Math.Round(Convert.ToDouble(sell_price_txt.Text), 3), false, sid, chkboxHasExpDate.Checked, chkboxHasTVA.Checked, (init_price_txt.Text == "") ? 0 : Math.Round(Convert.ToDouble(init_price_txt.Text), 3), Math.Round(Convert.ToDouble(txtSecondaryPrice.Text), 3), Int32.Parse(txtDiscountPercentage.Text.ToString()), chkboxHasDiscount.Checked);
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
                                int sid = int.Parse(supp_cbox.SelectedValue.ToString());
                                int TotalQuantity = (from aj in cnx.TBLEXPIREDDATEs where aj.PID == productID && aj.ExpiredDate > DateTime.Today select aj.Qte).ToList().Sum(x => Convert.ToInt32(x));
                                cnx.sp_UpdateProduct(productID, productname_txt.Text, barcode_txt.Text, TotalQuantity, Math.Round(Convert.ToDouble(sell_price_txt.Text), 3), false, sid, chkboxHasExpDate.Checked, chkboxHasTVA.Checked, (init_price_txt.Text == "") ? 0 : Math.Round(Convert.ToDouble(init_price_txt.Text), 3), Math.Round(Convert.ToDouble(txtSecondaryPrice.Text), 3), Int32.Parse(txtDiscountPercentage.Text.ToString()), chkboxHasDiscount.Checked);
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
                                int sid = int.Parse(supp_cbox.SelectedValue.ToString());
                                cnx.sp_UpdateProduct(productID, productname_txt.Text, barcode_txt.Text, Int32.Parse(quantity_txt.Text), Math.Round(Convert.ToDouble(sell_price_txt.Text), 3), true, sid, chkboxHasExpDate.Checked, chkboxHasTVA.Checked, (init_price_txt.Text == "") ? 0 : Math.Round(Convert.ToDouble(init_price_txt.Text), 3), Math.Round(Convert.ToDouble(txtSecondaryPrice.Text), 3), Int32.Parse(txtDiscountPercentage.Text.ToString()), chkboxHasDiscount.Checked);
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
                ProcessTabKey(true);
        }

        private void barcode_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
                ProcessTabKey(true);
        }

        private void supp_cbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
                ProcessTabKey(true);
        }

        private void sell_price_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
                ProcessTabKey(true);
        }

        private void txtSecondaryPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
                ProcessTabKey(true);
        }

        private void init_price_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
                ProcessTabKey(true);
        }

        private void changePricesCurrency()
        {
            if (cboxCurrencies.Text == "")
                return;
            if (Int32.Parse(cboxCurrencies.SelectedValue.ToString()) == 1 && !string.IsNullOrEmpty(txtSecondaryPrice.Text) && !string.IsNullOrEmpty(init_price_txt.Text) && !string.IsNullOrEmpty(sell_price_txt.Text))
            {
                txtSecondaryPrice.Text = Math.Round((Double.Parse(txtSecondaryPrice.Text) * Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString())), 0).ToString();
                init_price_txt.Text = Math.Round((Double.Parse(init_price_txt.Text) * Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString())), 0).ToString();
                sell_price_txt.Text = Math.Round((Double.Parse(sell_price_txt.Text) * Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString())), 0).ToString();
                //txtSecondaryPrice.Text = Math.Round((Double.Parse(txtSecondaryPrice.Text) * 95000), 0).ToString();
                //init_price_txt.Text = Math.Round((Double.Parse(init_price_txt.Text) * 95000), 0).ToString();
                //sell_price_txt.Text = Math.Round((Double.Parse(sell_price_txt.Text) * 95000), 0).ToString();
            }
            else if (Int32.Parse(cboxCurrencies.SelectedValue.ToString()) == 2 && !string.IsNullOrEmpty(txtSecondaryPrice.Text) && !string.IsNullOrEmpty(init_price_txt.Text) && !string.IsNullOrEmpty(sell_price_txt.Text))
            {
                txtSecondaryPrice.Text = Math.Round(Double.Parse(txtSecondaryPrice.Text) / Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()), 3).ToString();
                init_price_txt.Text = Math.Round(Double.Parse(init_price_txt.Text) / Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()), 3).ToString();
                sell_price_txt.Text = Math.Round(Double.Parse(sell_price_txt.Text) / Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()), 3).ToString();
                //txtSecondaryPrice.Text = Math.Round(Double.Parse(txtSecondaryPrice.Text) / 95000, 3).ToString();
                //init_price_txt.Text = Math.Round(Double.Parse(init_price_txt.Text) / 95000, 3).ToString();
                //sell_price_txt.Text = Math.Round(Double.Parse(sell_price_txt.Text) / 95000, 3).ToString();
            }
        }

        private void cboxCurrencies_SelectionChangeCommitted(object sender, EventArgs e)
        {
            changePricesCurrency();
        }
    }
}
