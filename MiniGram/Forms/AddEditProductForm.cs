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
using MiniGram.LINQ;
using Syncfusion.Windows.Forms.ComponentBannerTextProviders;

namespace MiniGram.Forms
{
    public partial class AddEditProductForm : Form
    {
        private int productID = 0;
        private List<TBLEXPIREDDATE> productExpDateList;

        public AddEditProductForm(int ID)
        {
            this.productID = ID;
            InitializeComponent();
            lblTitle.Text = this.productID == 0 ? "Add New Product" : "Edit Product";
        }

        private void AddEditProductForm_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            FillComboBoxes();

            if (productID != 0)
                LoadExistingProductData();

            ActiveControl = productname_txt;
        }

        private void LoadExistingProductData()
        {
            TBLPRODUCT product = new TBLPRODUCT();
            try
            {
                using (var ax = new MiniGramDBDataContext(Globals.ConnectionString))
                {
                    product = (from aj in ax.TBLPRODUCTs where aj.PID == productID select aj).SingleOrDefault();
                }
                FillProductData(product);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occure when loading the product!\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private List<TBLEXPIREDDATE> getExpDateListOfProduct(TBLPRODUCT product)
        {
            List<TBLEXPIREDDATE> list = new List<TBLEXPIREDDATE>();

            using (var ax = new MiniGramDBDataContext(Globals.ConnectionString))
            {
                list = (from aj in ax.TBLEXPIREDDATEs where aj.PID == product.PID select aj).ToList();
            }

            return list;
        }

        private void FillProductData(TBLPRODUCT product)
        {
            productname_txt.Text = product.PNAME;
            barcode_txt.Text = product.BARCODE;
            supp_cbox.SelectedValue = product.SID;
            cboxCurrencies.SelectedValue = product.CurrencyID;
            txtCostPrice.Text = product.InitPrice.ToString();
            CheckBoxHasEmpProfit.Checked = product.hasEmpProfitPercentage;
            txtEmpProfitPercentage.Text = product.hasEmpProfitPercentage ? product.EmpProfitPercentage.ToString() : "0";
            txtSecondaryPrice.Text = product.SecondaryPrice.ToString();
            CheckBoxHasSellProfitPercentage.Checked = product.hasSellProfitPercentage;
            txtSellProfitPercentage.Text = product.hasSellProfitPercentage ? product.SellProfitPercentage.ToString() : "0";
            sell_price_txt.Text = product.PRICE.ToString();
            CheckBoxHasDiscount.Checked = product.HasDiscount;
            txtDiscountPercentage.Text = product.HasDiscount ? product.DiscountPercentage.ToString() : "0";
            CheckBoxHasTVA.Checked = product.HasTVA;
            CheckBoxHasQuantity.Checked = product.HasQuantity == true;
            quantity_txt.Text = CheckBoxHasQuantity.Checked ? product.QTE.ToString() : "0";
            CheckBoxHasExpiredDate.Checked = product.HasExpiredDate == 1;
            productExpDateList = getExpDateListOfProduct(product);
            CheckBoxHasWeight.Checked = product.HasUnit;
            cboxPrimaryUnit.SelectedValue = product.UnitID;
        }

        private void FillComboBoxes()
        {
            using (var ax = new MiniGramDBDataContext(Globals.ConnectionString))
            {
                tBLSUPPLIERBindingSource.DataSource = (from aj in ax.TBLSUPPLIERs select aj).ToList();
                tBLCURRENCyBindingSource.DataSource = (from aj in ax.TBLCURRENCies select aj).ToList();
                tBLUNITBindingSource.DataSource = (from aj in ax.TBLUNITs select aj).ToList();
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void keyboard_btn_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo ps = new ProcessStartInfo();
                ps.FileName = @"C:\Windows\System32\osk.exe";
                Process process = new Process();
                process.StartInfo = ps;
                process.Start();
                ActiveControl = productname_txt;
            }
            catch
            {

            }
        }

        private void CheckBoxHasDiscount_CheckedChanged(object sender, EventArgs e)
        {
            txtDiscountPercentage.Enabled = CheckBoxHasDiscount.Checked;
        }

        private void CheckBoxHasTVA_CheckedChanged(object sender, EventArgs e)
        {
            txtTVADesc.Text = CheckBoxHasTVA.Checked ? Properties.Settings.Default.TVAPercentage.ToString() + "% TVA * Sell Price" : "";
        }

        private void CheckBoxHasQuantity_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxHasExpiredDate.Checked)
                CheckBoxHasExpiredDate.Checked = false;
            if (CheckBoxHasWeight.Checked)
                CheckBoxHasWeight.Checked = false;

            quantity_txt.Enabled = CheckBoxHasQuantity.Checked;
        }

        private void CheckBoxHasExpiredDate_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxHasQuantity.Checked)
                CheckBoxHasQuantity.Checked = false;

            if (CheckBoxHasWeight.Checked)
                CheckBoxHasWeight.Checked = false;

            btnExpiredDate.Enabled = CheckBoxHasExpiredDate.Checked;
        }

        private void CheckBoxHasWeight_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxHasQuantity.Checked)
                CheckBoxHasQuantity.Checked = false;

            if (CheckBoxHasExpiredDate.Checked)
                CheckBoxHasExpiredDate.Checked = false;

            cboxPrimaryUnit.Enabled = CheckBoxHasWeight.Checked;
        }

        private void btnExpiredDate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Want To Save This Product??", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(cboxCurrencies.Text) ||
                    string.IsNullOrEmpty(supp_cbox.Text) ||
                    string.IsNullOrEmpty(productname_txt.Text) ||
                    (CheckBoxHasSellProfitPercentage.Checked && string.IsNullOrEmpty(txtSellProfitPercentage.Text)) ||
                    string.IsNullOrEmpty(sell_price_txt.Text) ||
                    string.IsNullOrEmpty(txtCostPrice.Text) ||
                    (CheckBoxHasEmpProfit.Checked && string.IsNullOrEmpty(txtEmpProfitPercentage.Text)) ||
                    string.IsNullOrEmpty(txtSecondaryPrice.Text))
                {
                    warning_lable.Visible = true;
                    return;
                }
                else
                {
                    if (string.IsNullOrEmpty(barcode_txt.Text))
                        barcode_txt.Text = "0";
                    if (!CheckBoxHasDiscount.Checked)
                        txtDiscountPercentage.Text = "0";
                    if (!CheckBoxHasQuantity.Checked)
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
                            product.QTE = CheckBoxHasQuantity.Checked ? Int32.Parse(quantity_txt.Text) : 0;
                            product.PRICE = Math.Round(Convert.ToDouble(sell_price_txt.Text), 3);
                            product.HasQuantity = CheckBoxHasQuantity.Checked;
                            product.SID = Int32.Parse(supp_cbox.SelectedValue.ToString());
                            product.HasExpiredDate = CheckBoxHasExpiredDate.Checked ? 1 : 0;
                            product.HasTVA = CheckBoxHasTVA.Checked;
                            product.InitPrice = (txtCostPrice.Text == "") ? 0 : Math.Round(Convert.ToDouble(txtCostPrice.Text), 3);
                            product.SecondaryPrice = Math.Round(Convert.ToDouble(txtSecondaryPrice.Text), 3);
                            product.DiscountPercentage = Int32.Parse(txtDiscountPercentage.Text.ToString());
                            product.HasDiscount = CheckBoxHasDiscount.Checked;
                            product.CurrencyID = Int32.Parse(cboxCurrencies.SelectedValue.ToString());
                            product.ENABLED = true;
                            product.ADD_DATE = DateTime.Now;
                            product.hasEmpProfitPercentage = CheckBoxHasEmpProfit.Checked;
                            product.EmpProfitPercentage = CheckBoxHasEmpProfit.Checked ? int.Parse(txtEmpProfitPercentage.Text) : 0;
                            product.hasSellProfitPercentage = CheckBoxHasSellProfitPercentage.Checked;
                            product.SellProfitPercentage = CheckBoxHasSellProfitPercentage.Checked ? int.Parse(txtSellProfitPercentage.Text) : 0;
                            cnx.TBLPRODUCTs.InsertOnSubmit(product);
                            cnx.SubmitChanges();

                            if (CheckBoxHasExpiredDate.Checked)
                            {
                                ExpiredDateForm frm = new ExpiredDateForm(product.PID, productExpDateList);
                                frm.ShowDialog();
                                productID = product.PID;
                                int TotalQuantity = (from aj in cnx.TBLEXPIREDDATEs where aj.PID == product.PID && aj.ExpiredDate > DateTime.Today select aj.Qte).ToList().Sum(x => Convert.ToInt32(x));
                                product.QTE = TotalQuantity;

                                cnx.SubmitChanges();
                                this.Close();
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Something Went Wrong, The New Product Not Added, Please Call The Support!!");
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

        private void CheckBoxHasEmpProfit_CheckedChanged(object sender, EventArgs e)
        {
            txtEmpProfitPercentage.Enabled = CheckBoxHasEmpProfit.Checked;
            txtSecondaryPrice.Enabled = !txtEmpProfitPercentage.Enabled;
        }

        private void CheckBoxHasSellProfitPercentage_CheckedChanged(object sender, EventArgs e)
        {
            txtSellProfitPercentage.Enabled = CheckBoxHasSellProfitPercentage.Checked;
            sell_price_txt.Enabled = !txtSellProfitPercentage.Enabled;
        }

        private void txtEmpProfitPercentage_TextChanged(object sender, EventArgs e)
        {
            Decimal EmpProfitPercentage = 0;
            bool isNumeric = Decimal.TryParse(txtEmpProfitPercentage.Text, out EmpProfitPercentage);
            if (!isNumeric || EmpProfitPercentage > 100 || EmpProfitPercentage < 0)
            {
                txtEmpProfitPercentage.Text = "";
                return;
            }

            if (string.IsNullOrEmpty(txtCostPrice.Text))
                txtCostPrice.Text = "0";

            txtSecondaryPrice.Text = (Decimal.Parse(txtCostPrice.Text) + Decimal.Parse(txtCostPrice.Text) * Decimal.Parse(txtEmpProfitPercentage.Text) / 100).ToString();
        }

        private void txtSellProfitPercentage_TextChanged(object sender, EventArgs e)
        {
            Decimal SellProfitPercentage = 0;
            bool isNumeric = Decimal.TryParse(txtSellProfitPercentage.Text, out SellProfitPercentage);
            if (!isNumeric || SellProfitPercentage > 100 || SellProfitPercentage < 0)
            {
                txtSellProfitPercentage.Text = "";
                return;
            }

            if (string.IsNullOrEmpty(txtCostPrice.Text))
                txtCostPrice.Text = "0";

            sell_price_txt.Text = (Decimal.Parse(txtCostPrice.Text) + Decimal.Parse(txtCostPrice.Text) * Decimal.Parse(txtSellProfitPercentage.Text) / 100).ToString();
        }

        private void cboxCurrencies_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void txtCostPrice_TextChanged(object sender, EventArgs e)
        {
            bool isNumeric = Decimal.TryParse(txtCostPrice.Text, out _);
            if (!isNumeric)
            {
                txtCostPrice.Text = "";
                return;
            }

            txtSecondaryPrice.Text = CheckBoxHasEmpProfit.Checked ? (Double.Parse(txtCostPrice.Text) +Double.Parse(txtCostPrice.Text) * (!string.IsNullOrEmpty(txtEmpProfitPercentage.Text) ? Double.Parse(txtEmpProfitPercentage.Text) : 100) / 100).ToString() : txtSecondaryPrice.Text;
            sell_price_txt.Text = CheckBoxHasSellProfitPercentage.Checked ? (Double.Parse(txtCostPrice.Text) + Double.Parse(txtCostPrice.Text) * (!string.IsNullOrEmpty(txtSellProfitPercentage.Text) ? Double.Parse(txtSellProfitPercentage.Text) : 100) / 100).ToString() : sell_price_txt.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(cboxCurrencies.Text) ||
                    string.IsNullOrEmpty(supp_cbox.Text) ||
                    string.IsNullOrEmpty(productname_txt.Text) ||
                    (CheckBoxHasSellProfitPercentage.Checked && string.IsNullOrEmpty(txtSellProfitPercentage.Text)) ||
                    string.IsNullOrEmpty(sell_price_txt.Text) ||
                    string.IsNullOrEmpty(txtCostPrice.Text) ||
                    (CheckBoxHasEmpProfit.Checked && string.IsNullOrEmpty(txtEmpProfitPercentage.Text)) ||
                    (CheckBoxHasWeight.Checked && string.IsNullOrEmpty(cboxPrimaryUnit.Text)) ||
                    string.IsNullOrEmpty(txtSecondaryPrice.Text))
                {
                    warning_lable.Visible = true;
                    return;
                }
                using (var cnx = new MiniGramDBDataContext(Globals.ConnectionString))
                {
                    TBLPRODUCT product = (from aj in cnx.TBLPRODUCTs where aj.PID == productID select aj).SingleOrDefault();

                    if (product == null)
                        product = new TBLPRODUCT();

                    product.PNAME = productname_txt.Text.Trim();
                    product.BARCODE = barcode_txt.Text.Trim();
                    product.QTE = CheckBoxHasQuantity.Checked ? Int32.Parse(quantity_txt.Text) : 0;
                    product.PRICE = Math.Round(Convert.ToDouble(sell_price_txt.Text), 3);
                    product.HasQuantity = CheckBoxHasQuantity.Checked;
                    product.SID = Int32.Parse(supp_cbox.SelectedValue.ToString());
                    product.HasExpiredDate = CheckBoxHasExpiredDate.Checked ? 1 : 0;
                    product.HasTVA = CheckBoxHasTVA.Checked;
                    product.InitPrice = (txtCostPrice.Text == "") ? 0 : Math.Round(Convert.ToDouble(txtCostPrice.Text), 3);
                    product.SecondaryPrice = Math.Round(Convert.ToDouble(txtSecondaryPrice.Text), 3);
                    product.HasDiscount = CheckBoxHasDiscount.Checked;
                    product.DiscountPercentage = CheckBoxHasDiscount.Checked ? Int32.Parse(txtDiscountPercentage.Text) : 0;
                    product.CurrencyID = Int32.Parse(cboxCurrencies.SelectedValue.ToString());
                    product.ENABLED = true;
                    product.ADD_DATE = DateTime.Now;
                    product.hasEmpProfitPercentage = CheckBoxHasEmpProfit.Checked;
                    product.EmpProfitPercentage = CheckBoxHasEmpProfit.Checked ? int.Parse(txtEmpProfitPercentage.Text) : 0;
                    product.hasSellProfitPercentage = CheckBoxHasSellProfitPercentage.Checked;
                    product.SellProfitPercentage = CheckBoxHasSellProfitPercentage.Checked ? int.Parse(txtSellProfitPercentage.Text) : 0;
                    product.HasUnit = CheckBoxHasWeight.Checked;
                    product.UnitID = CheckBoxHasWeight.Checked ? int.Parse(cboxPrimaryUnit.SelectedValue.ToString()) : 0;

                    if (product.PID == 0)
                        cnx.TBLPRODUCTs.InsertOnSubmit(product);

                    cnx.SubmitChanges();
                }
                Close();
            }

        }

        private void cboxCurrencies_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCost.Text = "⫸ Cost ( " + cboxCurrencies.Text + " ) :";
            lblEmpPrice.Text = "⫸ Emp. Price ( " + cboxCurrencies.Text + " ) :";
            lblSellPrice.Text = "⫸ Sell Price ( " + cboxCurrencies.Text + " ) :";

            if(int.Parse(cboxCurrencies.SelectedValue.ToString()) == 1)
            {
                txtCostPrice.Text = !string.IsNullOrEmpty(txtCostPrice.Text) ? Math.Round(double.Parse(txtCostPrice.Text) * Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()),3).ToString() : "";
                txtSecondaryPrice.Text = !string.IsNullOrEmpty(txtSecondaryPrice.Text) ? Math.Round(double.Parse(txtSecondaryPrice.Text) * Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()),3).ToString() : "";
                sell_price_txt.Text = !string.IsNullOrEmpty(sell_price_txt.Text) ? Math.Round(double.Parse(sell_price_txt.Text) * Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()),3).ToString() : "";
            }
            else if(int.Parse(cboxCurrencies.SelectedValue.ToString()) == 2)
            {
                txtCostPrice.Text = !string.IsNullOrEmpty(txtCostPrice.Text) ? Math.Round(double.Parse(txtCostPrice.Text) / Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()),3).ToString() : "";
                txtSecondaryPrice.Text = !string.IsNullOrEmpty(txtSecondaryPrice.Text) ? Math.Round(double.Parse(txtSecondaryPrice.Text) / Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()),3).ToString() : "";
                sell_price_txt.Text = !string.IsNullOrEmpty(sell_price_txt.Text) ? Math.Round(double.Parse(sell_price_txt.Text) / Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()), 3).ToString() : "";
            }
        }
    }
}
