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
        public POSUC()
        {
            InitializeComponent();

        }


        private void POSUC_Load(object sender, EventArgs e)
        {
            data = new MiniGramDBDataContext(Globals.ConnectionString);
            try
            {
                NewReceiptNumber = Int32.Parse(data.sp_getLastReceiptID().ToList()[0].MAX_RID.ToString()) + 1;
            }
            catch (Exception ex)
            {
                NewReceiptNumber = 1;
            }
            receipt_id.Text = NewReceiptNumber.ToString();
            ActiveControl = search_txt;
        }


        void test(TableLayoutPanel table)
        {

        }
        public void refreshData(string str)
        {
            products_panel.Controls.Clear();
            table = new TableLayoutPanel();
            products_panel.Controls.Add(table);
            table.Dock = DockStyle.Fill;
            products_panel.Padding = new Padding(20, 20, 10, 20);
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
            Random random = new Random();
            int newBarcode = random.Next(1000000, 9999999);
            var check = data.sp_getReceiptByBarcode(newBarcode.ToString()).ToList();
            if (check.Count > 0)
                return generateNewBarcode();
            else
                return newBarcode.ToString();

        }

        private void checkout_btn_Click(object sender, EventArgs e)
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
                    //data.sp_insertNewRecipt(newBarcode,Int32.Parse(tot_quantity.Text),double.Parse(tot_dollar.Text.Split(' ')[0]),Int32.Parse(tot_lbp.Text.Split(' ')[0]));
                    var newReceipt = new TBLRECEIPT();
                    newReceipt.RBARCODE = newBarcode;
                    newReceipt.RITEM_NB = Int32.Parse(tot_quantity.Text);
                    newReceipt.TOTAL_AMOUNTDollar = double.Parse(tot_dollar.Text.Split(' ')[0]);
                    newReceipt.TOTAL_AMOUNTLBP = Int32.Parse(tot_lbp.Text.Split(' ')[0]);
                    newReceipt.RDATE = DateTime.Now;
                    data.TBLRECEIPTs.InsertOnSubmit(newReceipt);
                    data.SubmitChanges();

                    foreach (DataGridViewRow row in receipt_details.Rows)
                    {
                        try
                        {
                            var product = data.sp_getProductByName(row.Cells[1].Value.ToString()).ToList();
                            if (product[0].HasQuantity == true)
                            {
                                if (Int32.Parse(product[0].QTE.ToString()) < Int32.Parse(row.Cells[3].Value.ToString()))
                                {
                                    MessageBox.Show("You Have " + product[0].QTE + " Of Product Name : " + product[0].PNAME + "\nPlease Check Your Products !!");
                                    //data.sp_deleteReceiptByBarcode(newBarcode);
                                    //data.sp_deleteReceiptDetailsByRID(Int32.Parse(receipt_id.Text));
                                    search_txt.Text = "";
                                    ActiveControl = search_txt;
                                    return;
                                }
                                else if ((Int32.Parse(product[0].QTE.ToString()) == Int32.Parse(row.Cells[3].Value.ToString())))
                                {
                                    //data.sp_UpdateProductQuantity(product[0].PID, 0);
                                    TBLPRODUCT prod = (from aj in data.TBLPRODUCTs
                                                       where aj.PID == product[0].PID
                                                       select aj).Single();
                                    prod.QTE = 0;
                                    //data.sp_insertNewReciptDetail(Int32.Parse(receipt_id.Text), product[0].PID, Int32.Parse(row.Cells[3].Value.ToString()), double.Parse(row.Cells[4].Value.ToString()), double.Parse(row.Cells[7].Value.ToString()), Int32.Parse(row.Cells[5].Value.ToString()), Int32.Parse(row.Cells[6].Value.ToString()));
                                    var newReceiptDetails = new TBLRECEIPTS_DETAIL();
                                    newReceiptDetails.RID = newReceipt.RID;
                                    newReceiptDetails.PID = product[0].PID;
                                    newReceiptDetails.QTE = Int32.Parse(row.Cells[3].Value.ToString());
                                    newReceiptDetails.PRICE_Dollar = double.Parse(row.Cells[4].Value.ToString());
                                    newReceiptDetails.TOTAL_PRICEDollar = double.Parse(row.Cells[7].Value.ToString());
                                    newReceiptDetails.PRICE_LBP = Int32.Parse(row.Cells[5].Value.ToString());
                                    newReceiptDetails.TOTAL_PRICELBP = Int32.Parse(row.Cells[6].Value.ToString());
                                    data.TBLRECEIPTS_DETAILs.InsertOnSubmit(newReceiptDetails);

                                }
                                else
                                {
                                    data.sp_UpdateProductQuantity(product[0].PID, product[0].QTE - Int32.Parse(row.Cells[3].Value.ToString()));
                                    TBLPRODUCT prod = (from aj in data.TBLPRODUCTs
                                                       where aj.PID == product[0].PID
                                                       select aj).Single();
                                    prod.QTE = product[0].QTE - Int32.Parse(row.Cells[3].Value.ToString());
                                    //data.sp_insertNewReciptDetail(Int32.Parse(receipt_id.Text), product[0].PID, Int32.Parse(row.Cells[3].Value.ToString()), double.Parse(row.Cells[4].Value.ToString()), double.Parse(row.Cells[7].Value.ToString()), Int32.Parse(row.Cells[5].Value.ToString()), Int32.Parse(row.Cells[6].Value.ToString()));
                                    var newReceiptDetails = new TBLRECEIPTS_DETAIL();
                                    newReceiptDetails.RID = newReceipt.RID;
                                    newReceiptDetails.PID = product[0].PID;
                                    newReceiptDetails.QTE = Int32.Parse(row.Cells[3].Value.ToString());
                                    newReceiptDetails.PRICE_Dollar = double.Parse(row.Cells[4].Value.ToString());
                                    newReceiptDetails.TOTAL_PRICEDollar = double.Parse(row.Cells[7].Value.ToString());
                                    newReceiptDetails.PRICE_LBP = Int32.Parse(row.Cells[5].Value.ToString());
                                    newReceiptDetails.TOTAL_PRICELBP = Int32.Parse(row.Cells[6].Value.ToString());
                                    data.TBLRECEIPTS_DETAILs.InsertOnSubmit(newReceiptDetails);
                                }
                            }
                            else if (product[0].HasExpiredDate == 1)
                            {

                                List<TBLEXPIREDDATE> ExpiredDateList = (from aj in data.TBLEXPIREDDATEs where aj.PID == product[0].PID && aj.ExpiredDate > DateTime.Today select aj).ToList();
                                int totalQuantity = (from aj in ExpiredDateList where aj.ExpiredDate > DateTime.Today select aj.Qte).Sum(x => Convert.ToInt32(x));
                                if (totalQuantity < Int32.Parse(row.Cells[3].Value.ToString()))
                                {
                                    MessageBox.Show("You Have " + totalQuantity + " Of Product Name : " + product[0].PNAME + "\nPlease Check Your Products !!");
                                    //data.sp_deleteReceiptByBarcode(newBarcode);
                                    //data.sp_deleteReceiptDetailsByRID(Int32.Parse(receipt_id.Text));
                                    search_txt.Text = "";
                                    ActiveControl = search_txt;
                                    return;
                                }
                                else if (totalQuantity == Int32.Parse(row.Cells[3].Value.ToString()))
                                {
                                    TBLEXPIREDDATE minExpDate = (from aj in ExpiredDateList orderby aj.ExpiredDate ascending select aj).First();
                                    TBLPRODUCT prod = (from aj in data.TBLPRODUCTs
                                                       where aj.PID == product[0].PID
                                                       select aj).Single();
                                    prod.QTE = 0;
                                    data.TBLEXPIREDDATEs.DeleteOnSubmit(minExpDate);
                                    var newReceiptDetails = new TBLRECEIPTS_DETAIL();
                                    newReceiptDetails.RID = newReceipt.RID;
                                    newReceiptDetails.PID = product[0].PID;
                                    newReceiptDetails.QTE = Int32.Parse(row.Cells[3].Value.ToString());
                                    newReceiptDetails.PRICE_Dollar = double.Parse(row.Cells[4].Value.ToString());
                                    newReceiptDetails.TOTAL_PRICEDollar = double.Parse(row.Cells[7].Value.ToString());
                                    newReceiptDetails.PRICE_LBP = Int32.Parse(row.Cells[5].Value.ToString());
                                    newReceiptDetails.TOTAL_PRICELBP = Int32.Parse(row.Cells[6].Value.ToString());
                                    data.TBLRECEIPTS_DETAILs.InsertOnSubmit(newReceiptDetails);

                                }
                                else
                                {
                                    int tmpqte = Int32.Parse(row.Cells[3].Value.ToString());
                                    while (tmpqte > 0)
                                    {
                                        TBLEXPIREDDATE minExpDate = (from aj in ExpiredDateList orderby aj.ExpiredDate ascending select aj).First();
                                        if(tmpqte < minExpDate.Qte)
                                        {
                                            minExpDate.Qte = minExpDate.Qte - tmpqte;
                                        }
                                        else
                                        {
                                            minExpDate.Qte = 0;
                                            ExpiredDateList.Remove(minExpDate);
                                            data.TBLEXPIREDDATEs.DeleteOnSubmit(minExpDate);
                                        }
                                        tmpqte = tmpqte- minExpDate.Qte;
                                    }
                                    TBLPRODUCT prod = (from aj in data.TBLPRODUCTs
                                                       where aj.PID == product[0].PID
                                                       select aj).Single();
                                    prod.QTE = (from aj in ExpiredDateList where aj.ExpiredDate > DateTime.Today select aj.Qte).Sum(x => Convert.ToInt32(x));
                                    //data.sp_insertNewReciptDetail(Int32.Parse(receipt_id.Text), product[0].PID, Int32.Parse(row.Cells[3].Value.ToString()), double.Parse(row.Cells[4].Value.ToString()), double.Parse(row.Cells[7].Value.ToString()), Int32.Parse(row.Cells[5].Value.ToString()), Int32.Parse(row.Cells[6].Value.ToString()));
                                    var newReceiptDetails = new TBLRECEIPTS_DETAIL();
                                    newReceiptDetails.RID = newReceipt.RID;
                                    newReceiptDetails.PID = product[0].PID;
                                    newReceiptDetails.QTE = Int32.Parse(row.Cells[3].Value.ToString());
                                    newReceiptDetails.PRICE_Dollar = double.Parse(row.Cells[4].Value.ToString());
                                    newReceiptDetails.TOTAL_PRICEDollar = double.Parse(row.Cells[7].Value.ToString());
                                    newReceiptDetails.PRICE_LBP = Int32.Parse(row.Cells[5].Value.ToString());
                                    newReceiptDetails.TOTAL_PRICELBP = Int32.Parse(row.Cells[6].Value.ToString());
                                    data.TBLRECEIPTS_DETAILs.InsertOnSubmit(newReceiptDetails);
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
                                data.TBLRECEIPTS_DETAILs.InsertOnSubmit(newReceiptDetails);
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
                    data.SubmitChanges();
                    DirectReceiptReportViewer drrv = new DirectReceiptReportViewer(Properties.Settings.Default.ReceiptType);
                    drrv.receiptID = newReceipt.RID;
                    drrv.ShowDialog();
                    receipt_details.Rows.Clear();
                    tot_lbp.Text = "0" + " LBP";
                    tot_dollar.Text = "0" + " $";
                    tot_quantity.Text = "0";
                    try
                    {
                        NewReceiptNumber = Int32.Parse(data.sp_getLastReceiptID().ToList()[0].MAX_RID.ToString()) + 1;
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
            this.Show();
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
                button.FlatStyle = FlatStyle.Flat;
                button.Font = new Font("Bookman Old Style", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
                button.ThemeName = "Office2016Colorful";
                button.Margin = new Padding(8, 8, 8, 8);
                button.Padding = new Padding(50, 0, 0, 0);
                toolTip1.SetToolTip(button, products[c].ProductName + "  |  " + products[c].SupplierName);
                button.UseVisualStyleBackColor = false;
                button.Text = products[c].ProductName;
                button.TextAlign = ContentAlignment.MiddleLeft;
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
                MessageBox.Show("Error!!", "Error When Adding Items Please Contact Support!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            (table.Controls[0] as SfButton).PerformClick();
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
    }
}
