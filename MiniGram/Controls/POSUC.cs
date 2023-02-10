using MiniGram.Classes;
using MiniGram.Forms;
using MiniGram.LINQ;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.Controls;
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

namespace MiniGram.Controls
{
    public partial class POSUC : UserControl
    {
        private MiniGramDBDataContext data;
        private TableLayoutPanel table;
        private int NewReceiptNumber;
        private string selectedProductName = "";
        private TBLRECEIPT receipt;
        public POSUC(TBLRECEIPT receipt)
        {
            this.receipt = receipt;
            InitializeComponent();
        }


        private void POSUC_Load(object sender, EventArgs e)
        {
            data = new MiniGramDBDataContext(Globals.ConnectionString);
            if (!Properties.Settings.Default.showListInSale)
            {
                tableLayoutPanel1.ColumnStyles[0].SizeType = SizeType.Absolute;
                tableLayoutPanel1.ColumnStyles[0].Width = 0;
                products_panel.Visible = false;
            }
            try
            {
                if (receipt == null)
                    NewReceiptNumber = Int32.Parse(data.sp_getLastReceiptID().ToList()[0].MAX_RID.ToString()) + 1;
                else
                {
                    NewReceiptNumber = receipt.RID;
                    getExistingReceipt();
                }
            }
            catch (Exception ex)
            {
                NewReceiptNumber = 0;
            }
            receipt_id.Text = NewReceiptNumber.ToString();
            ActiveControl = search_txt;
        }

        private void getExistingReceipt()
        {
            Globals.isReceiptOpen = true;
            List<int> productListIDs = (from aj in data.TBLHOLDDETAILs where aj.RID == receipt.RID select Int32.Parse(aj.PID.ToString())).ToList();
            List<TBLPRODUCT> productList = (from aj in data.TBLPRODUCTs where productListIDs.Contains(aj.PID) select aj).ToList();
            foreach (TBLPRODUCT product in productList)
            {
                try
                {
                    var holdItem = (from aj in data.TBLHOLDDETAILs where aj.PID == product.PID && aj.RID == receipt.RID select aj).Single();
                    string pname = product.PNAME;
                    int pid = data.sp_getProductByName(pname).ToList()[0].PID;
                    double dollar = data.sp_getProductByName(pname).ToList()[0].PRICE.Value;
                    string barcode = data.sp_getProductByName(pname).ToList()[0].BARCODE;
                    string supplier = data.sp_getSupplierByID(data.sp_getProductByName(pname).ToList()[0].SID.Value).ToList()[0].SNAME;
                    int lbp = Int32.Parse((dollar * double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString())).ToString());
                    bool exist = false;
                    for (int i = 0; i < holdItem.QTE; i++)
                    {
                        foreach (DataGridViewRow row in receipt_details.Rows)
                        {
                            if (row.Cells[1].Value.Equals(pname))
                            {
                                exist = true;
                                row.Cells[2].Value = supplier;
                                row.Cells[3].Value = Int32.Parse(row.Cells[3].Value.ToString()) + 1;
                                row.Cells[6].Value = Int32.Parse((double.Parse(row.Cells[3].Value.ToString()) * double.Parse(lbp.ToString())).ToString());
                                row.Cells[7].Value = double.Parse(row.Cells[3].Value.ToString()) * dollar;
                                tot_quantity.Text = getTotalQTE();
                                tot_dollar.Text = getTotalDollar() + " $";
                                tot_lbp.Text = getTotalLBP() + " LBP";
                                break;
                            }
                        }
                        if (!exist)
                        {
                            receipt_details.Rows.Add(barcode, pname, supplier, 1, dollar, lbp, lbp, dollar);
                            tot_quantity.Text = getTotalQTE();
                            tot_dollar.Text = getTotalDollar() + " $";
                            tot_lbp.Text = getTotalLBP() + " LBP";
                        }
                        search_txt.Text = "";
                        ActiveControl = search_txt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error When Adding Items Please Contact Support!!", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void refreshData(string str)
        {
            if (Properties.Settings.Default.showListInSale)
            {
                products_panel.Controls.Clear();
                table = new TableLayoutPanel();
                table.Margin = new Padding(0,0,0,0);
                products_panel.Controls.Add(table);
                table.Dock = DockStyle.Fill;
                products_panel.Padding = new Padding(0, 20, 0, 20);
                table.ColumnCount = 1;
                table.RowCount = (Int32.Parse(data.sp_getProductsCount(str).ToList()[0].Product_Number.ToString()) / table.ColumnCount) + 1;
                products_panel.AutoScrollMinSize = new Size(0, (table.RowCount + 1) * 100);
                int i = 0, j = 0, c = 0, p = Int32.Parse(data.sp_getProductsCount(str).ToList()[0].Product_Number.ToString());
                while (i < table.RowCount)
                {
                    while (j < table.ColumnCount)
                    {
                        if (c < p)
                        {
                            AddNewButton(i, j, c, p, str);
                        }
                        c++;
                        j++;
                    }
                    i++;
                    j = 0;
                }
            }
            ActiveControl = search_txt;
            Globals.isLoadingFinish = true;
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

        private string generateNewBarcode()
        {
            if (receipt == null)
            {

                Random random = new Random();
                int newBarcode = random.Next(1000, 9999999);
                var check = data.sp_getReceiptByBarcode(newBarcode.ToString()).ToList();
                if (check.Count > 0)
                    return generateNewBarcode();
                else
                    return newBarcode.ToString();
            }
            else return receipt.RBARCODE;
        }

        private void checkout_btn_Click(object sender, EventArgs e)
        {
            using (var cnx = new MiniGramDBDataContext(Globals.ConnectionString))
            {
                if (receipt_details.Rows.Count == 0)
                {
                    MessageBox.Show("Please Enter At Least One Product!!");
                }
                else
                {
                    string newBarcode = generateNewBarcode();
                    try
                    {
                        var newReceipt = new TBLRECEIPT();
                        //newReceipt.RID = NewReceiptNumber;
                        if (receipt == null)
                        {
                            newReceipt.RBARCODE = newBarcode;
                            newReceipt.RITEM_NB = Int32.Parse(tot_quantity.Text);
                            newReceipt.TOTAL_AMOUNTDollar = double.Parse(tot_dollar.Text.Split(' ')[0]);
                            newReceipt.TOTAL_AMOUNTLBP = Int32.Parse(tot_lbp.Text.Split(' ')[0]);
                            newReceipt.RDATE = DateTime.Now;
                            cnx.TBLRECEIPTs.InsertOnSubmit(newReceipt);
                            cnx.SubmitChanges();
                        }
                        else
                        {
                            var r = (from aj in cnx.TBLRECEIPTs where aj.RID == receipt.RID select aj).Single();
                            r.RITEM_NB = Int32.Parse(tot_quantity.Text);
                            r.TOTAL_AMOUNTDollar = double.Parse(tot_dollar.Text.Split(' ')[0]);
                            r.TOTAL_AMOUNTLBP = Int32.Parse(tot_lbp.Text.Split(' ')[0]);
                            r.RDATE = DateTime.Now;
                            r.isHold = false;
                            newReceipt = r;
                        }
                        foreach (DataGridViewRow row in receipt_details.Rows)
                        {
                            try
                            {
                                var product = cnx.sp_getProductByName(row.Cells[1].Value.ToString()).ToList();
                                if (product[0].HasQuantity == true)
                                {
                                    if (Int32.Parse(product[0].QTE.ToString()) < Int32.Parse(row.Cells[3].Value.ToString()))
                                    {
                                        MessageBox.Show("You Have " + product[0].QTE + " Of Product Name : " + product[0].PNAME + "\nPlease Check Your Products !!");
                                        search_txt.Text = "";
                                        ActiveControl = search_txt;
                                        return;
                                    }
                                    else if ((Int32.Parse(product[0].QTE.ToString()) == Int32.Parse(row.Cells[3].Value.ToString())))
                                    {
                                        TBLPRODUCT prod = (from aj in data.TBLPRODUCTs
                                                           where aj.PID == product[0].PID
                                                           select aj).Single();
                                        prod.QTE = 0;
                                        var newReceiptDetails = new TBLRECEIPTS_DETAIL();
                                        newReceiptDetails.RID = newReceipt.RID;
                                        newReceiptDetails.PID = product[0].PID;
                                        newReceiptDetails.QTE = Int32.Parse(row.Cells[3].Value.ToString());
                                        newReceiptDetails.PRICE_Dollar = double.Parse(row.Cells[4].Value.ToString());
                                        newReceiptDetails.TOTAL_PRICEDollar = double.Parse(row.Cells[7].Value.ToString());
                                        newReceiptDetails.PRICE_LBP = Int32.Parse(row.Cells[5].Value.ToString());
                                        newReceiptDetails.TOTAL_PRICELBP = Int32.Parse(row.Cells[6].Value.ToString());
                                        cnx.TBLRECEIPTS_DETAILs.InsertOnSubmit(newReceiptDetails);

                                    }
                                    else
                                    {
                                        data.sp_UpdateProductQuantity(product[0].PID, product[0].QTE - Int32.Parse(row.Cells[3].Value.ToString()));
                                        TBLPRODUCT prod = (from aj in cnx.TBLPRODUCTs
                                                           where aj.PID == product[0].PID
                                                           select aj).Single();
                                        prod.QTE = product[0].QTE - Int32.Parse(row.Cells[3].Value.ToString());
                                        var newReceiptDetails = new TBLRECEIPTS_DETAIL();
                                        newReceiptDetails.RID = newReceipt.RID;
                                        newReceiptDetails.PID = product[0].PID;
                                        newReceiptDetails.QTE = Int32.Parse(row.Cells[3].Value.ToString());
                                        newReceiptDetails.PRICE_Dollar = double.Parse(row.Cells[4].Value.ToString());
                                        newReceiptDetails.TOTAL_PRICEDollar = double.Parse(row.Cells[7].Value.ToString());
                                        newReceiptDetails.PRICE_LBP = Int32.Parse(row.Cells[5].Value.ToString());
                                        newReceiptDetails.TOTAL_PRICELBP = Int32.Parse(row.Cells[6].Value.ToString());
                                        cnx.TBLRECEIPTS_DETAILs.InsertOnSubmit(newReceiptDetails);
                                    }
                                }
                                else if (product[0].HasExpiredDate == 1)
                                {

                                    List<TBLEXPIREDDATE> ExpiredDateList = (from aj in cnx.TBLEXPIREDDATEs where aj.PID == product[0].PID && aj.ExpiredDate > DateTime.Today select aj).ToList();
                                    int totalQuantity = (from aj in ExpiredDateList where aj.ExpiredDate > DateTime.Today select aj.Qte).Sum(x => Convert.ToInt32(x));
                                    if (totalQuantity < Int32.Parse(row.Cells[3].Value.ToString()))
                                    {
                                        MessageBox.Show("You Have " + totalQuantity + " Of Product Name : " + product[0].PNAME + "\nPlease Check Your Products !!");
                                        search_txt.Text = "";
                                        ActiveControl = search_txt;
                                        return;
                                    }
                                    else if (totalQuantity == Int32.Parse(row.Cells[3].Value.ToString()))
                                    {
                                        TBLEXPIREDDATE minExpDate = (from aj in ExpiredDateList orderby aj.ExpiredDate ascending select aj).First();
                                        TBLPRODUCT prod = (from aj in cnx.TBLPRODUCTs
                                                           where aj.PID == product[0].PID
                                                           select aj).Single();
                                        prod.QTE = 0;
                                        cnx.TBLEXPIREDDATEs.DeleteOnSubmit(minExpDate);
                                        var newReceiptDetails = new TBLRECEIPTS_DETAIL();
                                        newReceiptDetails.RID = newReceipt.RID;
                                        newReceiptDetails.PID = product[0].PID;
                                        newReceiptDetails.QTE = Int32.Parse(row.Cells[3].Value.ToString());
                                        newReceiptDetails.PRICE_Dollar = double.Parse(row.Cells[4].Value.ToString());
                                        newReceiptDetails.TOTAL_PRICEDollar = double.Parse(row.Cells[7].Value.ToString());
                                        newReceiptDetails.PRICE_LBP = Int32.Parse(row.Cells[5].Value.ToString());
                                        newReceiptDetails.TOTAL_PRICELBP = Int32.Parse(row.Cells[6].Value.ToString());
                                        cnx.TBLRECEIPTS_DETAILs.InsertOnSubmit(newReceiptDetails);

                                    }
                                    else
                                    {
                                        int tmpqte = Int32.Parse(row.Cells[3].Value.ToString());
                                        while (tmpqte > 0)
                                        {
                                            TBLEXPIREDDATE minExpDate = (from aj in ExpiredDateList orderby aj.ExpiredDate ascending select aj).First();
                                            if (tmpqte < minExpDate.Qte)
                                            {
                                                minExpDate.Qte = minExpDate.Qte - tmpqte;
                                                tmpqte = tmpqte - minExpDate.Qte;
                                            }
                                            else
                                            {
                                                tmpqte = tmpqte - minExpDate.Qte;
                                                minExpDate.Qte = 0;
                                                ExpiredDateList.Remove(minExpDate);
                                                cnx.TBLEXPIREDDATEs.DeleteOnSubmit(minExpDate);
                                            }
                                        }
                                        TBLPRODUCT prod = (from aj in cnx.TBLPRODUCTs
                                                           where aj.PID == product[0].PID
                                                           select aj).Single();
                                        prod.QTE = (from aj in ExpiredDateList where aj.ExpiredDate > DateTime.Today select aj.Qte).Sum(x => Convert.ToInt32(x));
                                        var newReceiptDetails = new TBLRECEIPTS_DETAIL();
                                        newReceiptDetails.RID = newReceipt.RID;
                                        newReceiptDetails.PID = product[0].PID;
                                        newReceiptDetails.QTE = Int32.Parse(row.Cells[3].Value.ToString());
                                        newReceiptDetails.PRICE_Dollar = double.Parse(row.Cells[4].Value.ToString());
                                        newReceiptDetails.TOTAL_PRICEDollar = double.Parse(row.Cells[7].Value.ToString());
                                        newReceiptDetails.PRICE_LBP = Int32.Parse(row.Cells[5].Value.ToString());
                                        newReceiptDetails.TOTAL_PRICELBP = Int32.Parse(row.Cells[6].Value.ToString());
                                        cnx.TBLRECEIPTS_DETAILs.InsertOnSubmit(newReceiptDetails);
                                    }
                                }
                                else
                                {
                                    var newReceiptDetails = new TBLRECEIPTS_DETAIL();
                                    newReceiptDetails.RID = newReceipt.RID;
                                    newReceiptDetails.PID = product[0].PID;
                                    newReceiptDetails.QTE = Int32.Parse(row.Cells[3].Value.ToString());
                                    newReceiptDetails.PRICE_Dollar = double.Parse(row.Cells[4].Value.ToString());
                                    newReceiptDetails.TOTAL_PRICEDollar = double.Parse(row.Cells[7].Value.ToString());
                                    newReceiptDetails.PRICE_LBP = Int32.Parse(row.Cells[5].Value.ToString());
                                    newReceiptDetails.TOTAL_PRICELBP = Int32.Parse(row.Cells[6].Value.ToString());
                                    cnx.TBLRECEIPTS_DETAILs.InsertOnSubmit(newReceiptDetails);
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("An Error Occured When Adding Receipt, Please Call Support !!");
                                Globals.isReceiptOpen = false;
                                receipt_details.Rows.Clear();
                                receipt_id.Text = NewReceiptNumber.ToString();
                                search_txt.Text = "";
                                ActiveControl = search_txt;
                                return;
                            }
                        }
                        cnx.SubmitChanges();
                        if (!Properties.Settings.Default.printInCheckout)
                        {
                            DirectReceiptReportViewer drrv = new DirectReceiptReportViewer(Properties.Settings.Default.ReceiptType);
                            drrv.receiptID = newReceipt.RID;
                            drrv.ShowDialog();
                        }
                        receipt_details.Rows.Clear();
                        tot_lbp.Text = "0" + " LBP";
                        tot_dollar.Text = "0" + " $";
                        tot_quantity.Text = "0";
                        try
                        {
                            NewReceiptNumber = Int32.Parse(cnx.sp_getLastReceiptID().ToList()[0].MAX_RID.ToString()) + 1;
                        }
                        catch (Exception ex)
                        {
                            NewReceiptNumber = 1;
                        }
                        receipt_id.Text = NewReceiptNumber.ToString();
                        search_txt.Text = "";
                        ActiveControl = search_txt;
                    }
                    catch (Exception ex)
                    {
                        Globals.isReceiptOpen = false;
                        MessageBox.Show("An Error Occured When Adding Receipt, Please Call Support !!");
                    }
                }
                Globals.isReceiptOpen = false;
                receipt = null;
                this.Show();
            }
        }

        private void CleareReceipt()
        {
            receipt = null;
            POSUC_Load(null, null);
            receipt_id.Text = NewReceiptNumber.ToString();
            receipt_details.Rows.Clear();
            tot_lbp.Text = "0" + " LBP";
            tot_dollar.Text = "0" + " $";
            tot_quantity.Text = "0";
        }


        private void AddNewButton(int i, int j, int c, int p, string str)
        {
            var products = (from pr in data.sp_select_products(str)
                            where pr.Status.Equals("Enabled")
                            select pr).ToList();
            if (products.Count != 0)
            {
                SfButton button = new SfButton();
                button.AccessibleName = "Button";
                button.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
                button.BackgroundImageLayout = ImageLayout.Zoom;
                button.CanOverrideStyle = true;
                button.Cursor = Cursors.Hand;
                //button.FlatStyle = FlatStyle.Flat;
                button.Font = new Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                button.ForeColor = Color.White;
                button.Name = "product" + i.ToString() + j.ToString();
                button.Size = new Size(products_panel.Width, 75);
                button.Style.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
                button.Style.FocusedBackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
                button.Style.FocusedForeColor = Color.White;
                button.Style.ForeColor = Color.White;
                button.Style.HoverBackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
                button.Style.HoverForeColor = Color.White;
                button.Style.HoverImageForeColor = Color.Empty;
                button.Style.PressedBackColor = Color.White;
                button.Dock = DockStyle.Fill;
                button.Style.PressedForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
                button.TextImageRelation = TextImageRelation.Overlay;
                button.TextMargin = new Padding(0, 10, 0, 0);
                button.Padding = new Padding(50, 0, 0, 0);
                toolTip1.SetToolTip(button, products[c].ProductName + "  |  " + products[c].SupplierName);
                button.Text = products[c].ProductName;
                button.TextAlign = ContentAlignment.MiddleLeft;
                button.Style.HoverBorder = new Pen(Color.White);
                button.CanApplyTheme= true;
                button.Style.HoverBorder.Color = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
                button.Style.HoverBorder.Width = 0;
                button.Click += new EventHandler(add_btn_Click);
                table.Controls.Add(button, j, i);
            }
        }


        private string getTotalDollar()
        {
            double totalDollar = 0;
            foreach (DataGridViewRow row in receipt_details.Rows)
            {
                totalDollar += double.Parse(row.Cells[7].Value.ToString());
            }
            return totalDollar.ToString();
        }
        private string getTotalLBP()
        {
            int totalLBP = 0;
            foreach (DataGridViewRow row in receipt_details.Rows)
            {
                totalLBP += Int32.Parse(row.Cells[6].Value.ToString());
            }
            return totalLBP.ToString();
        }
        private string getTotalQTE()
        {
            int QTE = 0;
            foreach (DataGridViewRow row in receipt_details.Rows)
            {
                QTE += Int32.Parse(row.Cells[3].Value.ToString());
            }
            return QTE.ToString();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Globals.isReceiptOpen = true;
                string pname = (sender as SfButton).Text.Split('|')[0].Trim();
                int pid = data.sp_getProductByName(pname).ToList()[0].PID;
                double dollar = data.sp_getProductByName(pname).ToList()[0].PRICE.Value;
                string barcode = data.sp_getProductByName(pname).ToList()[0].BARCODE;
                string supplier = data.sp_getSupplierByID(data.sp_getProductByName(pname).ToList()[0].SID.Value).ToList()[0].SNAME;
                int lbp = Int32.Parse((dollar * double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString())).ToString());
                bool exist = false;
                foreach (DataGridViewRow row in receipt_details.Rows)
                {
                    if (row.Cells[1].Value.Equals(pname))
                    {
                        exist = true;
                        row.Cells[2].Value = supplier;
                        row.Cells[3].Value = Int32.Parse(row.Cells[3].Value.ToString()) + 1;
                        row.Cells[6].Value = Int32.Parse((double.Parse(row.Cells[3].Value.ToString()) * double.Parse(lbp.ToString())).ToString());
                        row.Cells[7].Value = double.Parse(row.Cells[3].Value.ToString()) * dollar;
                        tot_quantity.Text = getTotalQTE();
                        tot_dollar.Text = getTotalDollar() + " $";
                        tot_lbp.Text = getTotalLBP() + " LBP";
                        break;
                    }
                }
                if (!exist)
                {
                    receipt_details.Rows.Add(barcode, pname, supplier, 1, dollar, lbp, lbp, dollar);
                    tot_quantity.Text = getTotalQTE();
                    tot_dollar.Text = getTotalDollar() + " $";
                    tot_lbp.Text = getTotalLBP() + " LBP";
                }
                search_txt.Text = "";
                ActiveControl = search_txt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error When Adding Items Please Contact Support!!", "Error !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void change_quantity_btn_Click(object sender, EventArgs e)
        {
            if (receipt_details.Rows.Count <= 0)
            {
                MessageBox.Show("Please Select An Item First!!");
            }
            else
            {
                double dollar = double.Parse(receipt_details.SelectedRows[0].Cells[4].Value.ToString());
                int lbp = Convert.ToInt32(dollar) * Properties.Settings.Default.dollarLBPPrice;
                Globals.deleteNB = 0;
                ChangeQuantityForm cqf = new ChangeQuantityForm(Int32.Parse(receipt_details.SelectedRows[0].Cells[3].Value.ToString()));
                cqf.ShowDialog();
                if (Globals.deleteNB > 0)
                {
                    receipt_details.SelectedRows[0].Cells[3].Value = Globals.deleteNB;
                    receipt_details.SelectedRows[0].Cells[6].Value = Globals.deleteNB * lbp;
                    receipt_details.SelectedRows[0].Cells[7].Value = double.Parse(Globals.deleteNB.ToString()) * dollar;
                    tot_quantity.Text = getTotalQTE();
                    tot_dollar.Text = getTotalDollar() + " $";
                    tot_lbp.Text = getTotalLBP() + " LBP";
                }
            }
            ActiveControl = search_txt;
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (receipt_details.Rows.Count <= 0)
            {
                MessageBox.Show("Please Select An Item First!!");
            }
            else
            {
                Globals.deleteNB = 0;
                DeleteForm df = new DeleteForm(Int32.Parse(receipt_details.SelectedRows[0].Cells[3].Value.ToString()));
                df.ShowDialog();
                if (Globals.deleteNB != 0)
                {
                    if (Globals.deleteNB == Int32.Parse(receipt_details.SelectedRows[0].Cells[3].Value.ToString()))
                        receipt_details.Rows.RemoveAt(receipt_details.SelectedRows[0].Index);
                    else
                    {
                        receipt_details.SelectedRows[0].Cells[3].Value = (Int32.Parse(receipt_details.SelectedRows[0].Cells[3].Value.ToString()) - Globals.deleteNB).ToString();
                        receipt_details.SelectedRows[0].Cells[7].Value = (double.Parse(receipt_details.SelectedRows[0].Cells[3].Value.ToString()) * double.Parse(receipt_details.SelectedRows[0].Cells[4].Value.ToString())).ToString();
                        receipt_details.SelectedRows[0].Cells[6].Value = (Int32.Parse(receipt_details.SelectedRows[0].Cells[3].Value.ToString()) * Int32.Parse(receipt_details.SelectedRows[0].Cells[5].Value.ToString())).ToString();
                    }
                    tot_quantity.Text = getTotalQTE();
                    tot_dollar.Text = getTotalDollar() + " $";
                    tot_lbp.Text = getTotalLBP() + " LBP";
                }
            }
            ActiveControl = search_txt;
        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            refreshData(search_txt.Text);
        }

        private void add_btn_Click_1(object sender, EventArgs e)
        {
            /*try
            {
                string pname = search_txt.Text;
                int pid = data.sp_getProductByName(pname).ToList()[0].PID;
                double dollar = data.sp_getProductByName(pname).ToList()[0].PRICE.Value;
                string barcode = data.sp_getProductByName(pname).ToList()[0].BARCODE;
                int lbp = Convert.ToInt32(dollar) * Properties.Settings.Default.dollarLBPPrice;
                bool exist = false;
                foreach (DataGridViewRow row in receipt_details.Rows)
                {
                    if (row.Cells[1].Value.Equals(pname))
                    {
                        exist = true;
                        row.Cells[2].Value = Int32.Parse(row.Cells[2].Value.ToString()) + 1;
                        row.Cells[5].Value = Int32.Parse(row.Cells[2].Value.ToString()) * lbp;
                        row.Cells[6].Value = double.Parse(row.Cells[2].Value.ToString()) * dollar;
                        tot_quantity.Text = getTotalQTE();
                        tot_dollar.Text = getTotalDollar() + " $";
                        tot_lbp.Text = getTotalLBP() + " LBP";
                        break;
                    }
                }
                if (!exist)
                {
                    receipt_details.Rows.Add(barcode, data.sp_getProductByName(pname).ToList()[0].PNAME,1, dollar, lbp, lbp, dollar);
                    tot_quantity.Text = getTotalQTE();
                    tot_dollar.Text = getTotalDollar() + " $";
                    tot_lbp.Text = getTotalLBP() + " LBP";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please Enter A Valid Barcode Or Name !!");                
            }*/
            if (Properties.Settings.Default.showListInSale)
            {
                (table.Controls[0] as SfButton).PerformClick();
            }
            else
            {
                if(search_txt.Text != "") {
                    using (var ax = new MiniGramDBDataContext(Properties.Settings.Default.ConnectionString))
                    {
                        try
                        {
                            Globals.isReceiptOpen = true;
                            TBLPRODUCT product = (from aj in ax.TBLPRODUCTs where aj.BARCODE.Trim().ToLower() == search_txt.Text.Trim().ToLower() select aj).SingleOrDefault();
                            if (product == null)
                            {
                                search_txt.Text = "";
                                MessageBox.Show("This Item Not Exist! Try Again!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            string pname = product.PNAME;
                            int pid = data.sp_getProductByName(pname).ToList()[0].PID;
                            double dollar = data.sp_getProductByName(pname).ToList()[0].PRICE.Value;
                            string barcode = data.sp_getProductByName(pname).ToList()[0].BARCODE;
                            string supplier = data.sp_getSupplierByID(data.sp_getProductByName(pname).ToList()[0].SID.Value).ToList()[0].SNAME;
                            int lbp = Int32.Parse((dollar * double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString())).ToString());
                            bool exist = false;
                            foreach (DataGridViewRow row in receipt_details.Rows)
                            {
                                if (row.Cells[1].Value.Equals(pname))
                                {
                                    exist = true;
                                    row.Cells[2].Value = supplier;
                                    row.Cells[3].Value = Int32.Parse(row.Cells[3].Value.ToString()) + 1;
                                    row.Cells[6].Value = Int32.Parse((double.Parse(row.Cells[3].Value.ToString()) * double.Parse(lbp.ToString())).ToString());
                                    row.Cells[7].Value = double.Parse(row.Cells[3].Value.ToString()) * dollar;
                                    tot_quantity.Text = getTotalQTE();
                                    tot_dollar.Text = getTotalDollar() + " $";
                                    tot_lbp.Text = getTotalLBP() + " LBP";
                                    break;
                                }
                            }
                            if (!exist)
                            {
                                receipt_details.Rows.Add(barcode, pname, supplier, 1, dollar, lbp, lbp, dollar);
                                tot_quantity.Text = getTotalQTE();
                                tot_dollar.Text = getTotalDollar() + " $";
                                tot_lbp.Text = getTotalLBP() + " LBP";
                            }
                            search_txt.Text = "";
                            ActiveControl = search_txt;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error When Adding Items Please Contact Support!!", "Error !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            search_txt.Text = "";
            ActiveControl = search_txt;
        }

        private void keyboard_btn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = ((Environment.GetFolderPath(Environment.SpecialFolder.System) + @"\osk.exe"));
            Process process = new Process();
            process.StartInfo = ps;
            process.Start();
            ActiveControl = search_txt;
        }

        private void POSUC_KeyUp(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            e.SuppressKeyPress = true;
            if (e.KeyValue == 13)
            {
                add_btn_Click_1(add_btn, e);
            }
        }

        private void search_txt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                add_btn_Click_1(add_btn, e);
            }
        }

        private void btnNewReceipt_Click(object sender, EventArgs e)
        {
            if (Globals.isReceiptOpen)
            {
                var dialogResult = MessageBox.Show("Their Are an Existing Receipt Opened, Do You Want To Hold it ??", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    Globals.isReceiptOpen = true;
                }
                else if (dialogResult == DialogResult.No)
                {
                    Globals.isReceiptOpen = false;
                    CleareReceipt();
                }
                else
                {

                }

            }
            else
            {
                Globals.isReceiptOpen = true;
                CleareReceipt();
                refreshData("");
            }
        }

        private void btnHold_Click(object sender, EventArgs e)
        {
            using (var cnx = new MiniGramDBDataContext(Globals.ConnectionString))
            {
                if (MessageBox.Show("Are You Sure You Want To Hold This Receipt ??", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string newBarcode = generateNewBarcode();
                    if (receipt == null)
                        NewReceiptNumber = Int32.Parse(data.sp_getLastReceiptID().ToList()[0].MAX_RID.ToString()) + 1;
                    else
                    {
                        NewReceiptNumber = receipt.RID;
                    }
                    var newReceipt = new TBLRECEIPT();
                    if (receipt == null)
                    {
                        newReceipt.RBARCODE = newBarcode;
                        newReceipt.RITEM_NB = Int32.Parse(tot_quantity.Text);
                        newReceipt.TOTAL_AMOUNTDollar = double.Parse(tot_dollar.Text.Split(' ')[0]);
                        newReceipt.TOTAL_AMOUNTLBP = Int32.Parse(tot_lbp.Text.Split(' ')[0]);
                        newReceipt.RDATE = DateTime.Now;
                        newReceipt.isHold = true;
                        cnx.TBLRECEIPTs.InsertOnSubmit(newReceipt);
                        cnx.SubmitChanges();
                    }
                    else
                    {
                        var r = (from aj in cnx.TBLRECEIPTs where aj.RID == receipt.RID select aj).Single();
                        r.RITEM_NB = Int32.Parse(tot_quantity.Text);
                        r.TOTAL_AMOUNTDollar = double.Parse(tot_dollar.Text.Split(' ')[0]);
                        r.TOTAL_AMOUNTLBP = Int32.Parse(tot_lbp.Text.Split(' ')[0]);
                        r.isHold = true;
                        newReceipt = r;
                    }

                    foreach (DataGridViewRow row in receipt_details.Rows)
                    {
                        var product = cnx.sp_getProductByName(row.Cells[1].Value.ToString()).ToList();
                        var newHoldDetails = new TBLHOLDDETAIL();
                        newHoldDetails.RID = newReceipt.RID;
                        newHoldDetails.PID = product[0].PID;
                        newHoldDetails.QTE = Int32.Parse(row.Cells[3].Value.ToString());
                        newHoldDetails.PRICE_Dollar = Convert.ToDouble(row.Cells[4].Value.ToString());
                        newHoldDetails.TOTAL_PRICEDollar = Convert.ToDouble(row.Cells[7].Value.ToString());
                        newHoldDetails.PRICE_LBP = Int32.Parse(row.Cells[5].Value.ToString());
                        newHoldDetails.TOTAL_PRICELBP = Int32.Parse(row.Cells[6].Value.ToString());
                        cnx.TBLHOLDDETAILs.InsertOnSubmit(newHoldDetails);

                    }
                    cnx.SubmitChanges();
                    CleareReceipt();
                    Globals.isReceiptOpen = false;
                }
            }

        }
    }
}
