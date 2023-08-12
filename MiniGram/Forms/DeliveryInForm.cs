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

namespace MiniGram.Forms
{
    public partial class DeliveryInForm : Form
    {

        private List<LINQ.TBLDELIVERY_RECEIPTS_DETAIL> productList = new List<LINQ.TBLDELIVERY_RECEIPTS_DETAIL>();
        private string newBarcode;

        public DeliveryInForm()
        {
            InitializeComponent();
        }

        private void DeliveryInForm_Load(object sender, EventArgs e)
        {
            newBarcode = generateNewBarcode();
            txtReceiptBarcode.Text = newBarcode;
            txtReceiptDate.Text = DateTime.Now.ToString();
            refreshCbox();
        }

        private string generateNewBarcode()
        {
            using (var ax = new LINQ.MiniGramDBDataContext(Classes.Globals.ConnectionString))
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
            using (var ax = new LINQ.MiniGramDBDataContext(Classes.Globals.ConnectionString))
            {
                tBLSUPPLIERBindingSource.DataSource = ax.TBLSUPPLIERs.ToList().Where((aj) => aj.ENABLED == true);
                tBLPRODUCTBindingSource.DataSource = ax.TBLPRODUCTs.ToList().Where((aj) => aj.ENABLED == true && aj.SID == Int32.Parse(cboxSupplier.SelectedValue.ToString()));
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure? The Entered Information Will Be Lost!!", "Warning!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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

                
                //product.PID = Int32.Parse(cboxProductBarcode.SelectedValue.ToString());
                //using(var ax = new LINQ.MiniGramDBDataContext(Classes.Globals.ConnectionString))
                //{
                //    LINQ.TBLPRODUCT realProduct = (from aj in ax.TBLPRODUCTs where aj.PID == product.PID select aj).SingleOrDefault();
                //    if(realProduct.QTE > 0)
                //    {
                //        MessageBox.Show("You Can't add this product to your stock, Please check if this product is already out of stock!!", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //        return;
                //    }
                //}

                dgvProducts.Rows.Add(cboxProductBarcode.Text, cboxProductName.Text, txtQte.Text, txtCost.Text, txtSellPrice.Text, txtEmpPrice.Text, chkboxHasExpDate.Checked ? txtExpDate.Text : "", chkboxDiscount.Checked ? Int32.Parse(txtDiscount.Text) : 0, chkboxTVA.Checked);
                product.Quantity = Int32.Parse(txtQte.Text);
                product.Cost = Double.Parse(txtCost.Text);
                product.SellPrice = Double.Parse(txtSellPrice.Text);
                product.SecondaryPrice = Double.Parse(txtEmpPrice.Text);
                product.HasDiscount = chkboxDiscount.Checked;
                product.Discount = chkboxDiscount.Checked ? Int32.Parse(txtDiscount.Text) : 0;
                product.HasExpDate = chkboxHasExpDate.Checked;
                product.ExpDate = chkboxHasExpDate.Checked ? DateTime.Parse(txtExpDate.Text) : DateTime.Now;
                product.HasTVA = chkboxTVA.Checked;

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



            using (var ax = new LINQ.MiniGramDBDataContext(Classes.Globals.ConnectionString))
            {
                LINQ.TBLDELIVERY_RECEIPT dReceipt = new LINQ.TBLDELIVERY_RECEIPT();
                dReceipt.ReceiptBarcode = newBarcode;
                dReceipt.RefID = txtRefID.Text;
                dReceipt.ReceiptTypeID = 3;
                dReceipt.SupplierID = (int)cboxSupplier.SelectedValue;
                dReceipt.ReceiptDate = DateTime.Now;
                dReceipt.TotalQuantity = getTotalQte();
                dReceipt.TotalDiscount = getTotalDiscount();
                dReceipt.TotalDollar = getTotalDollar();
                dReceipt.TotalLBP = Int32.Parse((getNetPriceDollar() * Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString())).ToString());
                dReceipt.TotalTVA = getTotalTVA();
                ax.TBLDELIVERY_RECEIPTs.InsertOnSubmit(dReceipt);
                ax.SubmitChanges();

                foreach (LINQ.TBLDELIVERY_RECEIPTS_DETAIL product in productList)
                {
                    product.RID = dReceipt.ID;
                    LINQ.TBLPRODUCT prod = (from aj in ax.TBLPRODUCTs where aj.PID == product.PID select aj).SingleOrDefault();
                    if (product.HasExpDate)
                    {
                        LINQ.TBLEXPIREDDATE exp = new LINQ.TBLEXPIREDDATE();
                        exp.PID = product.PID;
                        exp.Qte = Int32.Parse(product.Quantity.ToString());
                        exp.ExpiredDate = product.ExpDate;
                        exp.dateCreated = DateTime.Now;
                        ax.TBLEXPIREDDATEs.InsertOnSubmit(exp);

                        if (prod.HasExpiredDate == 1)
                        {
                            prod.QTE = prod.QTE + product.Quantity;
                        }

                    }
                    else
                    {

                        prod.QTE = prod.QTE + product.Quantity;
                    }
                    prod.HasDiscount = product.HasDiscount;
                    prod.DiscountPercentage = product.HasDiscount ? product.Discount : 0;
                    prod.HasTVA = product.HasTVA;
                    prod.InitPrice = product.Cost;
                    prod.SecondaryPrice = product.SecondaryPrice;
                    prod.PRICE = product.SellPrice;
                }
                ax.TBLDELIVERY_RECEIPTS_DETAILs.InsertAllOnSubmit(productList);
                ax.SubmitChanges();

                DirectReceiptReportViewer drrv = new DirectReceiptReportViewer(Properties.Settings.Default.ReceiptType, 3, getTotalDiscount().ToString(), getTotalTVA().ToString(), dReceipt.TotalLBP.ToString(), getNetPriceDollar().ToString());
                drrv.receiptID = dReceipt.ID;
                drrv.ShowDialog();
            }

            this.Close();

        }

        private int getTotalQte()
        {
            int totqte = 0;
            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                totqte += Int32.Parse(row.Cells[2].Value.ToString());
            }

            return totqte;
        }

        private double getTotalDollar()
        {
            double totdollar = 0;
            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                totdollar += (Double.Parse(row.Cells[2].Value.ToString()) * Double.Parse(row.Cells[3].Value.ToString()));
            }

            return totdollar;
        }
        private double getTotalDiscount()
        {
            double totdiscount = 0;
            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                totdiscount += (Double.Parse(row.Cells[2].Value.ToString()) * (Double.Parse(row.Cells[3].Value.ToString()) * Double.Parse(row.Cells[7].Value.ToString())) / 100);
            }

            return totdiscount;
        }

        private double getTotalTVA()
        {
            double tottva = 0;
            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                if (bool.Parse(row.Cells[8].Value.ToString()) == true)
                {
                    tottva += (Double.Parse(row.Cells[2].Value.ToString()) * (Double.Parse(row.Cells[3].Value.ToString()) * 11) / 100);
                }

            }

            return tottva;
        }

        private double getNetPriceDollar()
        {
            return (getTotalDollar() - getTotalDiscount() + getTotalTVA());
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ColumnRemove.Index == e.ColumnIndex)
            {
                if (MessageBox.Show("Are You Sure?", "Warning!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    dgvProducts.Rows.Remove(dgvProducts.SelectedRows[0]);
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
            tot_final_price_lbp.Text = (getNetPriceDollar() * Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString())).ToString("#,0;-#,0") + " LBP";
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

        private void cboxSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var ax = new LINQ.MiniGramDBDataContext(Classes.Globals.ConnectionString))
            {
                tBLPRODUCTBindingSource.DataSource = ax.TBLPRODUCTs.ToList().Where((aj) => aj.ENABLED == true && aj.SID == Int32.Parse(cboxSupplier.SelectedValue.ToString()));
            }
        }
    }
}
