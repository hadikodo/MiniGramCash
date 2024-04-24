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

                tBLSUPPLIERBindingSource.DataSource = (from aj in cnx.TBLSUPPLIERs select aj).ToList();
                tBLCURRENCyBindingSource.DataSource = (from aj in cnx.TBLCURRENCies select aj).ToList();

                lblCost.Text = "⫸ Cost ( " + cboxCurrencies.Text + " ) :";
                lblEmpPrice.Text = "⫸ Emp. Price ( " + cboxCurrencies.Text + " ) :";
                lblSellPrice.Text = "⫸ Sell Price ( " + cboxCurrencies.Text + " ) :";
            }
            ActiveControl = productname_txt;
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

            if (cboxCurrencies.SelectedItem == null || supp_cbox.SelectedItem == null || string.IsNullOrEmpty(productname_txt.Text) || string.IsNullOrEmpty(sell_price_txt.Text) || string.IsNullOrEmpty(init_price_txt.Text) || string.IsNullOrEmpty(txtSecondaryPrice.Text))
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
                }
                using (var cnx = new MiniGramDBDataContext(Globals.ConnectionString))
                {
                    try
                    {
                        TBLPRODUCT product = new TBLPRODUCT();
                        product.PNAME = productname_txt.Text.Trim();
                        product.BARCODE = barcode_txt.Text.Trim();
                        product.QTE = Int32.Parse(quantity_txt.Text);
                        product.PRICE = Math.Round(Convert.ToDouble(sell_price_txt.Text), 3);
                        product.HasQuantity = checkBoxAdv2.Checked;
                        product.SID = Int32.Parse(supp_cbox.SelectedValue.ToString());
                        product.HasExpiredDate = checkBoxAdv1.Checked ? 1 : 0;
                        product.HasTVA = chkboxHasTVA.Checked;
                        product.InitPrice = (init_price_txt.Text == "") ? 0 : Math.Round(Convert.ToDouble(init_price_txt.Text), 3);
                        product.SecondaryPrice = Math.Round(Convert.ToDouble(txtSecondaryPrice.Text), 3);
                        product.DiscountPercentage = Int32.Parse(txtDiscountPercentage.Text.ToString());
                        product.HasDiscount = chkboxHasDiscount.Checked;
                        product.CurrencyID = Int32.Parse(cboxCurrencies.SelectedValue.ToString());
                        product.ENABLED = true;
                        product.ADD_DATE = DateTime.Now;

                        cnx.TBLPRODUCTs.InsertOnSubmit(product);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Something Went Wrong, The New Product Not Added, Please Call The Support!!");
                        this.Close();
                    }


                    cnx.SubmitChanges();
                    MessageBox.Show("New Product Added Successfully.");
                    this.Close();
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
        private void checkBoxAdv3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAdv3.Checked)
            {
                checkBoxAdv2.Checked = false;
                checkBoxAdv1.Checked = false;
                btnExpiredDate.Enabled = false;
                quantity_txt.Enabled = false;
                cboxPrimaryUnit.Enabled = true;
                txtWeight.Enabled = true;
            }
            else
            {
                cboxPrimaryUnit.Enabled = false;
                txtWeight.Enabled = false;
            }
        }

        private void btnExpiredDate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Want To Save This Product??", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (cboxCurrencies.SelectedItem == null || supp_cbox.SelectedItem == null ||  string.IsNullOrEmpty(productname_txt.Text)  || string.IsNullOrEmpty(sell_price_txt.Text) || string.IsNullOrEmpty(init_price_txt.Text) || string.IsNullOrEmpty(txtSecondaryPrice.Text))
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
                    }
                    using (var cnx = new MiniGramDBDataContext(Globals.ConnectionString))
                    {

                        try
                        {
                            TBLPRODUCT product = new TBLPRODUCT();
                            product.PNAME = productname_txt.Text.Trim();
                            product.BARCODE = barcode_txt.Text.Trim();
                            product.QTE = Int32.Parse(quantity_txt.Text);
                            product.PRICE = Math.Round(Convert.ToDouble(sell_price_txt.Text), 3);
                            product.HasQuantity = checkBoxAdv2.Checked;
                            product.SID = Int32.Parse(supp_cbox.SelectedValue.ToString());
                            product.HasExpiredDate = checkBoxAdv1.Checked ? 1 : 0;
                            product.HasTVA = chkboxHasTVA.Checked;
                            product.InitPrice = (init_price_txt.Text == "") ? 0 : Math.Round(Convert.ToDouble(init_price_txt.Text), 3);
                            product.SecondaryPrice = Math.Round(Convert.ToDouble(txtSecondaryPrice.Text), 3);
                            product.DiscountPercentage = Int32.Parse(txtDiscountPercentage.Text.ToString());
                            product.HasDiscount = chkboxHasDiscount.Checked;
                            product.CurrencyID = Int32.Parse(cboxCurrencies.SelectedValue.ToString());
                            product.ENABLED = true;
                            product.ADD_DATE = DateTime.Now;

                            cnx.TBLPRODUCTs.InsertOnSubmit(product);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Something Went Wrong, The New Product Not Added, Please Call The Support!!");
                            this.Close();
                        }

                        cnx.SubmitChanges();

                        if (checkBoxAdv1.Checked)
                        {
                            ExpiredDateForm frm = new ExpiredDateForm(productname_txt.Text, Int32.Parse((from aj in cnx.TBLPRODUCTs where aj.BARCODE == barcode_txt.Text select aj.PID).Single().ToString()));
                            frm.ShowDialog();
                            int productID = Int32.Parse((from aj in cnx.TBLPRODUCTs where aj.BARCODE == barcode_txt.Text select aj.PID).Single().ToString());
                            int TotalQuantity = (from aj in cnx.TBLEXPIREDDATEs where aj.PID == productID && aj.ExpiredDate > DateTime.Today select aj.Qte).ToList().Sum(x => Convert.ToInt32(x));

                            TBLPRODUCT product = (from aj in cnx.TBLPRODUCTs where aj.PID == productID select aj).SingleOrDefault();
                            product.QTE = TotalQuantity;

                            cnx.SubmitChanges();
                            this.Close();
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

        private void cboxCurrencies_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
                ProcessTabKey(true);
        }

        private void cboxCurrencies_SelectionChangeCommitted(object sender, EventArgs e)
        {
            changePricesCurrency();
        }
        private void changePricesCurrency()
        {
            if (cboxCurrencies.Text == "")
                return;

            if (Int32.Parse(cboxCurrencies.SelectedValue.ToString()) == 1 && !string.IsNullOrEmpty(txtSecondaryPrice.Text) && !string.IsNullOrEmpty(init_price_txt.Text) && !string.IsNullOrEmpty(sell_price_txt.Text))
            {
                txtSecondaryPrice.Text = Int32.Parse((Double.Parse(txtSecondaryPrice.Text) * Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString())).ToString()).ToString();
                init_price_txt.Text = Int32.Parse((Double.Parse(init_price_txt.Text) * Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString())).ToString()).ToString();
                sell_price_txt.Text = Int32.Parse((Double.Parse(sell_price_txt.Text) * Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString())).ToString()).ToString();
            }
            else if (Int32.Parse(cboxCurrencies.SelectedValue.ToString()) == 2 && !string.IsNullOrEmpty(txtSecondaryPrice.Text) && !string.IsNullOrEmpty(init_price_txt.Text) && !string.IsNullOrEmpty(sell_price_txt.Text))
            {
                txtSecondaryPrice.Text = Math.Round(Double.Parse(txtSecondaryPrice.Text) / Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()), 3).ToString();
                init_price_txt.Text = Math.Round(Double.Parse(init_price_txt.Text) / Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()), 3).ToString();
                sell_price_txt.Text = Math.Round(Double.Parse(sell_price_txt.Text) / Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()), 3).ToString();
            }
        }

    }
}
