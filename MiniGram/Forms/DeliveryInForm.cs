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

        private void InitButtonsPermissions()
        {
            switch (StatusID)
            {
                case 1:
                    TableLayoutPanelAddEdit.Visible = true;
                    btnAction.Visible = ReceiptID != 0;
                    btnSave.Visible = true;
                    btnAction.Text = "Send To Accounting";
                    txtReceiptDate.Enabled = true;
                    txtRefID.Enabled = true;
                    cboxSupplier.Enabled = true;
                    cboxCurrency.Enabled = true;
                    ColumnRemove.Visible = true;
                    break;
                case 3:
                    TableLayoutPanelAddEdit.Visible = false;
                    btnAction.Text = "Approve";
                    btnAction.Visible = true;
                    btnSave.Visible = false;
                    txtRefID.Enabled = false;
                    txtReceiptDate.Enabled = false;
                    cboxSupplier.Enabled = false;
                    cboxCurrency.Enabled = false;
                    ColumnRemove.Visible = false;
                    break;
                case 4:
                    TableLayoutPanelAddEdit.Visible = false;
                    btnAction.Text = "Print";
                    btnAction.Visible = true;
                    btnSave.Visible = false;
                    txtReceiptDate.Enabled = false;
                    txtRefID.Enabled = false;
                    cboxSupplier.Enabled = false;
                    cboxCurrency.Enabled = false;
                    ColumnRemove.Visible = false;
                    break;
            }
        }

        private void DeliveryInForm_Load(object sender, EventArgs e)
        {
            InitButtonsPermissions();
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
                    dgvProducts.Rows.Add(product.BARCODE, product.PNAME, item.Quantity,item.inStockQuantity, item.Cost, item.SellPrice, item.SecondaryPrice, item.HasExpDate ? item.ExpDate.ToString() : "", item.HasDiscount ? Int32.Parse(item.Discount.ToString()) : 0, item.HasTVA);
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

        private void chkboxHasExpDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxHasExpDate.Checked)
            {
                txtQte.Enabled = false;
                PickDateForm frm = new PickDateForm();
                frm.ShowDialog();
                if (frm.selectedDate != null && frm.qte != null)
                {
                    txtQte.Text = frm.qte.ToString();
                    txtExpDate.Text = frm.selectedDate.Value.ToShortDateString();
                }
                else
                {
                    MessageBox.Show("Some Information is Missing!!", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    chkboxHasExpDate.Checked = false;
                    return;
                }
                frm.Dispose();
            }
            else
            {
                txtQte.Enabled = true;
                txtQte.Text = "";
                txtExpDate.Text = "";
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtQte.Text) || (chkboxHasExpDate.Checked && string.IsNullOrEmpty(txtExpDate.Text)) || string.IsNullOrEmpty(txtCost.Text) || string.IsNullOrEmpty(txtEmpPrice.Text) || string.IsNullOrEmpty(txtSellPrice.Text) || (chkboxDiscount.Checked && string.IsNullOrEmpty(txtDiscount.Text)))
            {
                MessageBox.Show("Some Information is Missing!!", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                LINQ.TBLDELIVERY_RECEIPTS_DETAIL product = new LINQ.TBLDELIVERY_RECEIPTS_DETAIL();


                product.PID = Int32.Parse(cboxProductBarcode.SelectedValue.ToString());

                dgvProducts.Rows.Add(cboxProductBarcode.Text, cboxProductName.Text, txtQte.Text,0, txtCost.Text, txtSellPrice.Text, txtEmpPrice.Text, chkboxHasExpDate.Checked ? txtExpDate.Text : "", chkboxDiscount.Checked ? Int32.Parse(txtDiscount.Text) : 0, chkboxTVA.Checked);
                product.Quantity = Int32.Parse(txtQte.Text);
                product.Cost = Double.Parse(txtCost.Text);
                product.SellPrice = Double.Parse(txtSellPrice.Text);
                product.SecondaryPrice = Double.Parse(txtEmpPrice.Text);
                product.HasDiscount = chkboxDiscount.Checked;
                product.Discount = chkboxDiscount.Checked ? Int32.Parse(txtDiscount.Text) : 0;
                product.HasExpDate = chkboxHasExpDate.Checked;
                product.ExpDate = chkboxHasExpDate.Checked ? DateTime.Parse(txtExpDate.Text) : DateTime.Now;
                product.HasTVA = chkboxTVA.Checked;
                product.isInSale = false;

                refreshTotals();

                productList.Add(product);
                chkboxHasExpDate.Checked = false;
                chkboxTVA.Checked = false;
                chkboxDiscount.Checked = false;
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
                dReceipt.TotalDiscount = getTotalDiscount();
                dReceipt.TotalDollar = getTotalDollar();
                dReceipt.TotalLBP = Int32.Parse(Math.Round(getNetPriceDollar() * Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()), 0).ToString());
                dReceipt.TotalTVA = getTotalTVA();
                dReceipt.CurrencyID = Int32.Parse(cboxCurrency.SelectedValue.ToString());
                dReceipt.UserID = 0;
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
                }

                ax.TBLDELIVERY_RECEIPTS_DETAILs.InsertAllOnSubmit(productList);
                ax.SubmitChanges();
            }

            if(!isSavePressed)
                MessageBox.Show("This Receipt Has Been Saved.", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            isSavePressed = true;
            btnAction.Visible = true;
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

        private double getTotalDollar()
        {
            double totdollar = 0;
            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                totdollar += Int32.Parse(cboxCurrency.SelectedValue.ToString()) == 2 ? Math.Round(Double.Parse(row.Cells["AddedQuantity"].Value.ToString()) * Double.Parse(row.Cells["ColumnCost"].Value.ToString()), 3) : Math.Round(Double.Parse(row.Cells["AddedQuantity"].Value.ToString()) * Double.Parse(row.Cells["ColumnCost"].Value.ToString()) / Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()), 3);
            }

            return totdollar;
        }
        private double getTotalDiscount()
        {
            double totdiscount = 0;
            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                totdiscount += Int32.Parse(cboxCurrency.SelectedValue.ToString()) == 2 ? Math.Round(Double.Parse(row.Cells["AddedQuantity"].Value.ToString()) * (Double.Parse(row.Cells["ColumnCost"].Value.ToString()) * Double.Parse(row.Cells["ColumnDiscount"].Value.ToString())) / 100, 3) : Math.Round((Double.Parse(row.Cells["AddedQuantity"].Value.ToString()) * (Double.Parse(row.Cells["ColumnCost"].Value.ToString()) * Double.Parse(row.Cells["ColumnDiscount"].Value.ToString())) / 100) / Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()), 3);
            }

            return totdiscount;
        }

        private double getTotalTVA()
        {
            double tottva = 0;
            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                if (bool.Parse(row.Cells["ColumnTVA"].Value.ToString()) == true)
                {
                    tottva += Int32.Parse(cboxCurrency.SelectedValue.ToString()) == 2 ? Math.Round(Double.Parse(row.Cells["AddedQuantity"].Value.ToString()) * (Double.Parse(row.Cells["ColumnCost"].Value.ToString()) * 11) / 100, 3) : Math.Round((Double.Parse(row.Cells["AddedQuantity"].Value.ToString()) * (Double.Parse(row.Cells["ColumnCost"].Value.ToString()) * 11) / 100) / Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()), 3);
                }

            }

            return tottva;
        }

        private double getNetPriceDollar()
        {
            return (getTotalDollar() - getTotalDiscount() + getTotalTVA());
        }

        //private double getTotalPrice()
        //{
        //    double totalprice = 0;
        //    foreach(DataGridViewRow row in dgvProducts.Rows)
        //    {
        //        totalprice += cboxCurrency.SelectedValue == 2 ? Double.Parse(row.Cells["TotalPrice"].Value.ToString()) : Double.Parse(row.Cells["TotalPrice"].Value.ToString()) * 
        //    }
        //}

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
            AddProductForm apf = new AddProductForm();
            apf.ShowDialog();
            refreshCbox();
        }

        private void refreshTotals()
        {
            tot_quantity.Text = getTotalQte().ToString();
            tot_net_dollar.Text = getTotalDollar().ToString() + " $";
            tot_discount.Text = getTotalDiscount().ToString() + " $";
            tot_tva.Text = getTotalTVA().ToString() + " $";
            tot_final_price_dolar.Text = getNetPriceDollar().ToString() + " $";
            tot_final_price_lbp.Text = (Math.Round(getNetPriceDollar() * Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()), 0)).ToString("#,0;-#,0") + " LBP";
        }

        private void chkboxDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxDiscount.Checked)
            {
                txtDiscount.Enabled = true;
            }
            else
            {
                txtDiscount.Enabled = false;
            }
            txtDiscount.Text = "";
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
                            string totalDiscount = getTotalDiscount().ToString();
                            string totalTVA = getTotalTVA().ToString();
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
                                }
                            }
                            dReceipt.StatusID = 4;

                        }
                        break;
                    case 4:
                        int receiptTypeID2 = 1;
                        string totalDiscount2 = getTotalDiscount().ToString();
                        string totalTVA2 = getTotalTVA().ToString();
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
                    chkboxDiscount.Checked = product.HasDiscount;
                    chkboxTVA.Checked = product.HasTVA;
                    txtDiscount.Text = chkboxDiscount.Checked ? product.DiscountPercentage.ToString() : "";
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
                    chkboxDiscount.Checked = product.HasDiscount;
                    chkboxTVA.Checked = product.HasTVA;
                    txtDiscount.Text = chkboxDiscount.Checked ? product.DiscountPercentage.ToString() : "";
                }
            }
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
