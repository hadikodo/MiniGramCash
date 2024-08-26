using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniGram.LINQ;

namespace MiniGram.Forms
{
    public partial class DeliveryInForm : Form
    {
        private int ReceiptID = 0, StatusID = 1;
        private List<TBLDELIVERY_RECEIPTS_DETAIL> productList = new List<TBLDELIVERY_RECEIPTS_DETAIL>();
        private string newBarcode;
        private bool isSavePressed = false;

        public DeliveryInForm(int ReceiptID, int StatusID)
        {
            this.ReceiptID = ReceiptID;
            this.StatusID = StatusID;

            InitializeComponent();
        }

        private void DeliveryInForm_Load(object sender, EventArgs e)
        {
            //InitButtonsPermissions();
            refreshCbox();
            if (ReceiptID != 0)
            {
                getExistingReceipt();
            }
            else
            {
                newBarcode = generateNewBarcode();
                txtReceiptBarcode.Text = newBarcode;
                txtReceiptDate.Text = DateTime.Now.ToString();
                ActiveControl = txtRefID;
            }
        }


        private void getExistingReceipt()
        {
            TBLDELIVERY_RECEIPT receipt = new TBLDELIVERY_RECEIPT();
            using (var ax = new MiniGramDBDataContext(Globals.ConnectionString))
            {
                receipt = (from aj in ax.TBLDELIVERY_RECEIPTs where aj.ID == ReceiptID select aj).SingleOrDefault();
                productList = (from aj in ax.TBLDELIVERY_RECEIPTS_DETAILs where aj.RID == ReceiptID select aj).ToList();
                foreach (TBLDELIVERY_RECEIPTS_DETAIL item in productList)
                {
                    TBLPRODUCT product = (from aj in ax.TBLPRODUCTs where aj.PID == item.PID select aj).SingleOrDefault();
                    dgvProducts.Rows.Add(product.BARCODE,
                        product.PNAME,
                        item.inStockQuantity,
                        item.Quantity,
                        item.Cost,
                        item.hasSellProfitPercentage ? item.SellProfitPercentage.ToString() : "",
                        item.SellPrice,
                        item.hasEmpProfitPercentage ? item.EmpProfitPercentage.ToString() : "",
                        item.SecondaryPrice);
                }
                cboxCurrency.SelectedValue = receipt.CurrencyID;
                txtRefID.Text = receipt.RefID;
                txtReceiptID.Text = receipt.ID.ToString();
                txtReceiptBarcode.Text = receipt.ReceiptBarcode;
                txtReceiptDate.Text = receipt.ReceiptDate.Value.ToString();
                cboxSupplier.SelectedValue = receipt.SupplierID;
            }
            refreshTotals();
        }

        private string generateNewBarcode()
        {
            using (var ax = new LINQ.MiniGramDBDataContext(Globals.ConnectionString))
            {
                Random random = new Random();
                int newBarcode = random.Next(1000, 9999999);
                var check = (from aj in ax.TBLDELIVERY_RECEIPTs where aj.ReceiptBarcode == newBarcode.ToString() select aj).ToList();
                if (check.Count > 0)
                    return generateNewBarcode();
                else
                    return newBarcode.ToString();
            }
        }

        private void refreshCbox()
        {
            using (var ax = new LINQ.MiniGramDBDataContext(Globals.ConnectionString))
            {
                tBLSUPPLIERBindingSource.DataSource = ax.TBLSUPPLIERs.ToList().Where((aj) => aj.ENABLED == true);
                tBLCURRENCyBindingSource.DataSource = ax.TBLCURRENCies.ToList();
                tBLPRODUCTBindingSource.DataSource = ax.TBLPRODUCTs.ToList().Where((aj) => aj.ENABLED == true && aj.HasQuantity == true && aj.SID == Int32.Parse(cboxSupplier.SelectedValue.ToString()));
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            if(StatusID == 1)
                if (MessageBox.Show("Are You Sure? The Entered Information Will Be Lost!!", "Warning!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes )
                    this.Close();
            this.Close();
        }

        private void keyboard_btn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = @"C:\Windows\System32\osk.exe";
            Process process = new Process();
            process.StartInfo = ps;
            process.Start();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtQte.Text) || string.IsNullOrEmpty(txtCost.Text) || (checkBoxHasProfitPercentage.Checked && string.IsNullOrEmpty(txtSellProfitPercentage.Text)) || (checkBoxEmpProfitPercentage.Checked && string.IsNullOrEmpty(txtEmpProfitPercentage.Text)) || string.IsNullOrEmpty(txtEmpPrice.Text) || string.IsNullOrEmpty(txtSellPrice.Text))
            {
                MessageBox.Show("Some Information is Missing!!", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                LINQ.TBLDELIVERY_RECEIPTS_DETAIL product = new LINQ.TBLDELIVERY_RECEIPTS_DETAIL();
                product.PID = Int32.Parse(cboxProductBarcode.SelectedValue.ToString());
                dgvProducts.Rows.Add(cboxProductBarcode.Text, cboxProductName.Text,0, txtQte.Text, txtCost.Text, checkBoxHasProfitPercentage.Checked ? txtSellProfitPercentage.Text : "",txtSellPrice.Text,checkBoxEmpProfitPercentage.Checked ? txtEmpProfitPercentage.Text : "", txtEmpPrice.Text);
                product.Quantity = Int32.Parse(txtQte.Text);
                product.Cost = Double.Parse(txtCost.Text);
                product.SellPrice = Double.Parse(txtSellPrice.Text);
                product.SecondaryPrice = Double.Parse(txtEmpPrice.Text);
                product.HasDiscount = false;
                product.Discount = 0;
                product.HasExpDate = false;
                product.HasTVA = false;
                product.isInSale = false;
                product.hasSellProfitPercentage = checkBoxHasProfitPercentage.Checked;
                product.hasEmpProfitPercentage = checkBoxEmpProfitPercentage.Checked;
                product.EmpProfitPercentage = checkBoxEmpProfitPercentage.Checked ? int.Parse(txtEmpProfitPercentage.Text) : 0;
                product.SellProfitPercentage = checkBoxHasProfitPercentage.Checked ? int.Parse(txtSellProfitPercentage.Text) : 0;

                refreshTotals();

                productList.Add(product);
                txtQte.Text = "";
                txtCost.Text = "";
                txtSellPrice.Text = "";
                txtEmpPrice.Text = "";
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRefID.Text))
            {
                MessageBox.Show("Some Information is Missing!!", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (var ax = new LINQ.MiniGramDBDataContext(Globals.ConnectionString))
            {
                LINQ.TBLDELIVERY_RECEIPT dReceipt = new LINQ.TBLDELIVERY_RECEIPT();

                if (ReceiptID != 0)
                {
                    dReceipt = (from aj in ax.TBLDELIVERY_RECEIPTs where aj.ID == ReceiptID select aj).SingleOrDefault();
                    List<TBLDELIVERY_RECEIPTS_DETAIL> deleteNeededList = (from aj in ax.TBLDELIVERY_RECEIPTS_DETAILs where aj.RID == dReceipt.ID select aj).ToList();
                    ax.TBLDELIVERY_RECEIPTS_DETAILs.DeleteAllOnSubmit(deleteNeededList);
                }

                dReceipt.RefID = txtRefID.Text;
                dReceipt.SupplierID = (int)cboxSupplier.SelectedValue;
                dReceipt.TotalQuantity = getTotalQte();
                dReceipt.TotalDiscount = 0;
                dReceipt.TotalDollar = getNetPriceDollar();
                dReceipt.TotalLBP = Int32.Parse(Math.Round(getNetPriceDollar() * Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()), 0).ToString());
                dReceipt.TotalTVA = 0;
                dReceipt.CurrencyID = Int32.Parse(cboxCurrency.SelectedValue.ToString());
                //dReceipt.UserID = Globals.LoggedInUserID;
                dReceipt.StatusID = StatusID;
                dReceipt.ReceiptDate = DateTime.Parse(txtReceiptDate.Text).Date;
                if (ReceiptID == 0)
                {
                    dReceipt.ReceiptBarcode = newBarcode;
                    dReceipt.ReceiptTypeID = 3;
                    ax.TBLDELIVERY_RECEIPTs.InsertOnSubmit(dReceipt);
                }

                ax.SubmitChanges();
                ReceiptID = dReceipt.ID;
                foreach (LINQ.TBLDELIVERY_RECEIPTS_DETAIL product in productList)
                {
                    product.RID = dReceipt.ID;
                    product.dateCreated = dReceipt.ReceiptDate;
                    UpdateProductPriceInfo(product.PID, product, dReceipt.CurrencyID);
                }

                ax.TBLDELIVERY_RECEIPTS_DETAILs.InsertAllOnSubmit(productList);
                ax.SubmitChanges();
            }

            if(!isSavePressed)
                MessageBox.Show("This Receipt Has Been Saved.", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            isSavePressed = true;
            btnAction.Visible = true;
        }

        private void UpdateProductPriceInfo(int pid,TBLDELIVERY_RECEIPTS_DETAIL drd,int? receiptCurrencyID)
        {
            if (pid != 0)
            {
                using (var ax = new MiniGramDBDataContext(Globals.ConnectionString))
                {
                    TBLPRODUCT product = (from aj in ax.TBLPRODUCTs where aj.PID == pid select aj).SingleOrDefault();

                    if(!Globals.ComparePrices(product.InitPrice,product.CurrencyID,drd.Cost,receiptCurrencyID))
                    {
                        product.InitPrice = drd.Cost;
                        product.SecondaryPrice = drd.SecondaryPrice;
                        product.PRICE = drd.SellPrice;
                        product.hasEmpProfitPercentage = drd.hasEmpProfitPercentage;
                        product.hasSellProfitPercentage = drd.hasSellProfitPercentage;
                        product.SellProfitPercentage = drd.SellProfitPercentage;
                        product.EmpProfitPercentage = drd.EmpProfitPercentage;
                        product.CurrencyID = (int)receiptCurrencyID;
                    }
                    ax.SubmitChanges();
                }
            }
        }

        private int getTotalQte()
        {
            int totqte = 0;
            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                totqte += Int32.Parse(row.Cells["AddedQuantity"].Value.ToString());
            }

            return totqte;
        }


        private double getNetPriceDollar()
        {
            double totdollar = 0;
            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                totdollar += Int32.Parse(cboxCurrency.SelectedValue.ToString()) == 2 ? Math.Round(Double.Parse(row.Cells["AddedQuantity"].Value.ToString()) * Double.Parse(row.Cells["ColumnCost"].Value.ToString()), 3) : Math.Round(Double.Parse(row.Cells["AddedQuantity"].Value.ToString()) * Double.Parse(row.Cells["ColumnCost"].Value.ToString()) / Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()), 3);
            }

            return totdollar;
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ColumnRemove.Index == e.ColumnIndex)
            {
                if (MessageBox.Show("Are You Sure?", "Warning!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    productList.RemoveAt(dgvProducts.SelectedRows[0].Index);
                    dgvProducts.Rows.Remove(dgvProducts.SelectedRows[0]);
                }
                refreshTotals();
            }

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddEditProductForm apf = new AddEditProductForm(0);
            apf.ShowDialog();
            refreshCbox();
        }

        private void refreshTotals()
        {
            tot_quantity.Text = getTotalQte().ToString();
            tot_final_price_dolar.Text = getNetPriceDollar().ToString() + " $";
            tot_final_price_lbp.Text = (Math.Round(getNetPriceDollar() * Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()), 0)).ToString("#,0;-#,0") + " LBP";
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            using (var ax = new LINQ.MiniGramDBDataContext(Globals.ConnectionString))
            {

                TBLDELIVERY_RECEIPT dReceipt = (from aj in ax.TBLDELIVERY_RECEIPTs where aj.ID == ReceiptID select aj).SingleOrDefault();
                switch (StatusID)
                {
                    case 1:
                    case 2:
                        if (dgvProducts.Rows.Count <= 0)
                        {
                            MessageBox.Show("Add At Least One Item!!!", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (!isSavePressed)
                        {
                            isSavePressed = true;
                            StatusID = 2;
                            btnSave_Click(null, null);
                        }

                        if (MessageBox.Show("Are You Sure You Want To Send This Receipt To Accouting?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            dReceipt.StatusID = 2;
                            int receiptTypeID = 1;
                            string totalDiscount = "0";
                            string totalTVA = "0";
                            string finalPriceLBP = dReceipt.TotalLBP.ToString();
                            string finalPriceDollar = getNetPriceDollar().ToString();

                            System.Threading.Thread t1 = new System.Threading.Thread(() =>
                            {
                                DirectReceiptReportViewer drrv = new DirectReceiptReportViewer(receiptTypeID, 3, totalDiscount, totalTVA, finalPriceLBP, finalPriceDollar);
                                drrv.receiptID = dReceipt.ID;
                                drrv.Print();
                                System.Threading.Thread.CurrentThread.Abort();
                            });
                            t1.Start();
                        }
                        break;
                    case 3:
                        if (MessageBox.Show("Are You Sure You Want To Approve This Receipt?? You Can't Back After This Action, And The Primary Stock Will Be Affected!!!!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            foreach (LINQ.TBLDELIVERY_RECEIPTS_DETAIL product in productList)
                            {
                                TBLPRODUCT prod = (from aj in ax.TBLPRODUCTs where aj.PID == product.PID select aj).SingleOrDefault();
                                TBLDELIVERY_RECEIPTS_DETAIL productToBeUpdate = (from aj in ax.TBLDELIVERY_RECEIPTS_DETAILs where aj.ID == product.ID select aj).SingleOrDefault();
                                if (prod.QTE > 0 && prod.PRICE > productToBeUpdate.SellPrice)
                                {
                                    productToBeUpdate.isInSale = false;
                                    continue;
                                }

                                if (prod.HasExpiredDate == 0)
                                {
                                    productToBeUpdate.isInSale = !product.HasExpDate;
                                    if (!product.HasExpDate)
                                        prod.QTE = Int32.Parse((prod.QTE + product.Quantity).ToString());
                                    prod.HasDiscount = product.HasDiscount;
                                    prod.DiscountPercentage = product.HasDiscount ? product.Discount : 0;
                                    prod.HasTVA = product.HasTVA;
                                    prod.InitPrice = product.Cost;
                                    prod.SecondaryPrice = product.SecondaryPrice;
                                    prod.PRICE = product.SellPrice;
                                    prod.CurrencyID = Int32.Parse(cboxCurrency.SelectedValue.ToString());
                                    prod.hasSellProfitPercentage = product.hasSellProfitPercentage;
                                    prod.hasEmpProfitPercentage = product.hasEmpProfitPercentage;
                                    prod.EmpProfitPercentage = product.EmpProfitPercentage;
                                    prod.SellProfitPercentage = product.SellProfitPercentage;

                                }
                                else if (prod.HasExpiredDate == 1)
                                {
                                    productToBeUpdate.isInSale = !product.HasExpDate;
                                    if (product.HasExpDate)
                                    {
                                        LINQ.TBLEXPIREDDATE exp = new LINQ.TBLEXPIREDDATE();
                                        exp.PID = product.PID;
                                        exp.Qte = Int32.Parse(product.Quantity.ToString());
                                        exp.ExpiredDate = product.ExpDate;
                                        exp.dateCreated = DateTime.Now;
                                        ax.TBLEXPIREDDATEs.InsertOnSubmit(exp);
                                    }
                                    prod.HasDiscount = product.HasDiscount;
                                    prod.DiscountPercentage = product.HasDiscount ? product.Discount : 0;
                                    prod.HasTVA = product.HasTVA;
                                    prod.InitPrice = product.Cost;
                                    prod.SecondaryPrice = product.SecondaryPrice;
                                    prod.PRICE = product.SellPrice;
                                    prod.CurrencyID = Int32.Parse(cboxCurrency.SelectedValue.ToString());
                                    prod.hasSellProfitPercentage = product.hasSellProfitPercentage;
                                    prod.hasEmpProfitPercentage = product.hasEmpProfitPercentage;
                                    prod.EmpProfitPercentage = product.EmpProfitPercentage;
                                    prod.SellProfitPercentage = product.SellProfitPercentage;
                                }
                            }
                            dReceipt.StatusID = 4;

                        }
                        break;
                    case 4:
                        int receiptTypeID2 = 1;
                        string totalDiscount2 = "0";
                        string totalTVA2 = "0";
                        string finalPriceLBP2 = dReceipt.TotalLBP.ToString();
                        string finalPriceDollar2 = getNetPriceDollar().ToString();

                        System.Threading.Thread t2 = new System.Threading.Thread(() =>
                        {
                            DirectReceiptReportViewer drrv = new DirectReceiptReportViewer(receiptTypeID2, 3, totalDiscount2, totalTVA2, finalPriceLBP2, finalPriceDollar2);
                            drrv.receiptID = dReceipt.ID;
                            drrv.Print();
                            System.Threading.Thread.CurrentThread.Abort();
                        });
                        t2.Start();
                        return;
                }
                ax.SubmitChanges();
                this.Close();
            }
        }

        private void cboxProductBarcode_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void cboxProductName_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void cboxProductBarcode_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cboxProductBarcode.SelectedValue != null)
            {
                using (var ax = new LINQ.MiniGramDBDataContext(Globals.ConnectionString))
                {
                    TBLPRODUCT product = (from aj in ax.TBLPRODUCTs where aj.PID == int.Parse(cboxProductBarcode.SelectedValue.ToString()) select aj).SingleOrDefault();
                    txtQte.Text = product.QTE.ToString();
                    txtCost.Text = product.InitPrice.ToString();
                    txtSellPrice.Text = product.PRICE.ToString();
                    txtEmpPrice.Text = product.SecondaryPrice.ToString();
                }
            }
        }

        private void cboxProductName_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboxProductBarcode.SelectedValue != null)
            {
                using (var ax = new LINQ.MiniGramDBDataContext(Globals.ConnectionString))
                {
                    TBLPRODUCT product = (from aj in ax.TBLPRODUCTs where aj.PID == int.Parse(cboxProductBarcode.SelectedValue.ToString()) select aj).SingleOrDefault();
                    txtQte.Text = product.QTE.ToString();
                    txtCost.Text = product.InitPrice.ToString();
                    txtSellPrice.Text = product.PRICE.ToString();
                    txtEmpPrice.Text = product.SecondaryPrice.ToString();
                }
            }
        }

        private void checkBoxHasProfitPercentage_CheckedChanged(object sender, EventArgs e)
        {
            txtSellProfitPercentage.Enabled = checkBoxHasProfitPercentage.Checked;
            txtSellPrice.Enabled = !checkBoxHasProfitPercentage.Checked;
        }

        private void checkBoxEmpProfitPercentage_CheckedChanged(object sender, EventArgs e)
        {
            txtEmpProfitPercentage.Enabled = checkBoxEmpProfitPercentage.Checked;
            txtEmpPrice.Enabled = !checkBoxEmpProfitPercentage.Checked;
        }

        private void txtSellProfitPercentage_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bool isNumeric = Decimal.TryParse(txtSellProfitPercentage.Text, out _);
                if (isNumeric && (Decimal.Parse(txtSellProfitPercentage.Text) >= 0 || Decimal.Parse(txtSellProfitPercentage.Text) <= 100))
                {
                    txtSellPrice.Text = (Decimal.Parse(txtCost.Text) + Decimal.Parse(txtCost.Text) * Decimal.Parse(txtSellProfitPercentage.Text)/100).ToString();
                }
            }
            catch
            {

            }

        }

        private void txtEmpProfitPercentage_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bool isNumeric = Decimal.TryParse(txtEmpProfitPercentage.Text, out _);
                if (isNumeric && (Decimal.Parse(txtEmpProfitPercentage.Text) >= 0 || Decimal.Parse(txtEmpProfitPercentage.Text) <= 100))
                {
                    txtEmpPrice.Text = (Decimal.Parse(txtCost.Text) + Decimal.Parse(txtCost.Text) * Decimal.Parse(txtEmpProfitPercentage.Text)/100).ToString();
                }
            }
            catch
            {

            }
        }

        private void txtCost_TextChanged(object sender, EventArgs e)
        {
            bool isNumeric = Decimal.TryParse(txtCost.Text, out _);
            if (!isNumeric)
            {
                txtCost.Text = "";
                return;
            }

            txtEmpPrice.Text = checkBoxEmpProfitPercentage.Checked ? (Double.Parse(txtCost.Text) * (!string.IsNullOrEmpty(txtEmpProfitPercentage.Text) ? Double.Parse(txtEmpProfitPercentage.Text) : 100) / 100).ToString() : txtEmpPrice.Text;
            txtSellPrice.Text = checkBoxHasProfitPercentage.Checked ? (Double.Parse(txtCost.Text) * (!string.IsNullOrEmpty(txtSellProfitPercentage.Text) ? Double.Parse(txtSellProfitPercentage.Text) : 100) / 100).ToString() : txtSellPrice.Text;
        }

        private void cboxSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var ax = new LINQ.MiniGramDBDataContext(Globals.ConnectionString))
            {
                tBLPRODUCTBindingSource.DataSource = ax.TBLPRODUCTs.ToList().Where((aj) => aj.ENABLED == true && aj.SID == Int32.Parse(cboxSupplier.SelectedValue.ToString()));
            }
        }
    }
}
