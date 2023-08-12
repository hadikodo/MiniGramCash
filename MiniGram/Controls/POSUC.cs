using MiniGram.Classes;
using MiniGram.Forms;
using MiniGram.LINQ;
using Syncfusion.PMML;
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
using static Syncfusion.Windows.Forms.TabBar;

namespace MiniGram.Controls
{
    public partial class POSUC : UserControl
    {
        private MiniGramDBDataContext data;
        private TableLayoutPanel table;
        private int NewReceiptNumber;
        private string selectedProductName = "";
        private TBLRECEIPT receipt;
        private int receiptType = 1;
        private int receiptSwitcherValue = 1;
        private bool isErrorAppear = false;
        private int time = 0;
        private int inputQte = 1;
        private TBLCUSTOMER customer = null;

        public POSUC(TBLRECEIPT receipt)
        {
            this.receipt = receipt;
            InitializeComponent();
        }

        private void InitComboDiscount()
        {
            //Dictionary<int, string> DictionaryDiscount = new Dictionary<int, string>();
            //DictionaryDiscount.Add(0, "None");
            //DictionaryDiscount.Add(1, "Discount");
            //DictionaryDiscount.Add(2, "General Discount");
            //cboxDiscount.DataSource = new BindingSource(DictionaryDiscount, null);
            //cboxDiscount.DisplayMember = "Value";
            //cboxDiscount.ValueMember = "Key";
        }

        private void POSUC_Load(object sender, EventArgs e)
        {
            //InitComboDiscount();
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
                    try
                    {
                        NewReceiptNumber = Int32.Parse(data.sp_getLastReceiptID().ToList()[0].MAX_RID.ToString()) + 1;

                    }
                    catch (Exception ex)
                    {
                        NewReceiptNumber = 1;
                    }


                else
                {
                    NewReceiptNumber = receipt.RID;
                    getExistingReceipt();
                }
            }
            catch (Exception ex)
            {
                NewReceiptNumber = 1;
            }
            receipt_id.Text = NewReceiptNumber.ToString();
            ActiveControl = search_txt;
        }

        private void getExistingReceipt()
        {
            receipt_details.Rows.Clear();
            Globals.isReceiptOpen = true;
            List<int> productListIDs = (from aj in data.TBLHOLDDETAILs where aj.RID == receipt.RID select Int32.Parse(aj.PID.ToString())).ToList();
            List<TBLPRODUCT> productList = (from aj in data.TBLPRODUCTs where productListIDs.Contains(aj.PID) select aj).ToList();
            int? customerID = (from aj in data.TBLRECEIPTs where aj.RID == receipt.RID select aj.CustomerID).SingleOrDefault();
            if(customerID != 0 )
            {
                customer = (from aj in data.TBLCUSTOMERs where aj.ID == customerID select aj).SingleOrDefault();
                if (customer.isVIP)
                    cboxDiscount.CheckState = CheckState.Checked;
                else if (!customer.isVIP)
                    cboxDiscount.CheckState = CheckState.Unchecked;
                else
                    cboxDiscount.CheckState = CheckState.Indeterminate;
            }

            foreach (TBLPRODUCT product in productList)
            {
                try
                {
                    double discount = 0;
                    var holdItem = (from aj in data.TBLHOLDDETAILs where aj.PID == product.PID && aj.RID == receipt.RID select aj).Single();
                    string pname = product.PNAME;
                    int pid = data.sp_getProductByName(pname).ToList()[0].PID;
                    double dollar = data.sp_getProductByName(pname).ToList()[0].PRICE.Value;                    
                    double secondaryPrice = data.sp_getProductByName(pname).ToList()[0].SecondaryPrice.Value;
                    string barcode = data.sp_getProductByName(pname).ToList()[0].BARCODE;
                    string supplier = data.sp_getSupplierByID(data.sp_getProductByName(pname).ToList()[0].SID.Value).ToList()[0].SNAME;
                    int lbp = Int32.Parse((dollar * double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString())).ToString());
                    double tva = data.sp_getProductByName(pname).ToList()[0].HasTVA ? (secondaryPrice * Double.Parse(Properties.Settings.Default.TVAPercentage.ToString()) / 100) : 0;
                    if (cboxDiscount.CheckState == CheckState.Unchecked)
                        discount = 0;
                    else if (cboxDiscount.CheckState == CheckState.Checked)
                        discount = data.sp_getProductByName(pname).ToList()[0].SecondaryPrice == 0 ? 0 : dollar - secondaryPrice;
                    else if (cboxDiscount.CheckState == CheckState.Indeterminate)
                        discount = data.sp_getProductByName(pname).ToList()[0].DiscountPercentage == null ? 0 : Double.Parse((dollar * Double.Parse(data.sp_getProductByName(pname).ToList()[0].DiscountPercentage.ToString())).ToString()) / 100;
                    double? cost = data.sp_getProductByName(pname).ToList()[0].InitPrice;  
                    double? profit = dollar + tva - discount - cost;
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
                                row.Cells[8].Value = Int32.Parse(row.Cells[3].Value.ToString()) * tva;
                                row.Cells[9].Value = Int32.Parse(row.Cells[3].Value.ToString()) * discount;
                                row.Cells[10].Value = secondaryPrice;
                                row.Cells[11].Value = double.Parse(row.Cells[3].Value.ToString()) * profit;
                                tot_quantity.Text = getTotalQTE();
                                tot_net_dollar.Text = getTotalDollar() + " $";
                                tot_tva.Text = (Double.Parse(getTotalTVA())).ToString() + " $";
                                double TotalDiscount = Double.Parse(getTotalDiscount());
                                tot_discount.Text = TotalDiscount.ToString() + " $";
                                tot_final_price_dolar.Text = getFinalPriceDollar(TotalDiscount).ToString() + " $";
                                tot_final_price_lbp.Text = getFinalPriceLBP(TotalDiscount).ToString("#,0;-#,0") + " LBP";
                                break;
                            }
                        }
                        if (!exist)
                        {
                            receipt_details.Rows.Add(barcode, pname, supplier, 1, dollar, lbp, lbp, dollar, tva, discount, secondaryPrice, profit);
                            tot_quantity.Text = getTotalQTE();
                            tot_net_dollar.Text = getTotalDollar() + " $";
                            tot_tva.Text = (Double.Parse(getTotalTVA())).ToString() + " $";
                            double TotalDiscount = Double.Parse(getTotalDiscount());
                            tot_discount.Text = TotalDiscount.ToString() + " $";
                            tot_final_price_dolar.Text = getFinalPriceDollar(TotalDiscount).ToString() + " $";
                            tot_final_price_lbp.Text = getFinalPriceLBP(TotalDiscount).ToString("#,0;-#,0") + " LBP";
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
            data = new MiniGramDBDataContext(Globals.ConnectionString);
            if (Properties.Settings.Default.showListInSale)
            {

                products_panel.Controls.Clear();
                table = new TableLayoutPanel();
                table.Margin = new Padding(0, 0, 0, 0);
                products_panel.Controls.Add(table);
                table.Dock = DockStyle.Fill;
                products_panel.Padding = new Padding(0, 20, 0, 20);
                table.ColumnCount = 1;
                table.RowCount = 21; //(Int32.Parse(data.sp_getProductsCount(str).ToList()[0].Product_Number.ToString()) / table.ColumnCount) + 1;
                products_panel.AutoScrollMinSize = new Size(0, (table.RowCount + 1) * 100);
                int i = 0, j = 0, c = 0, p = Int32.Parse(data.sp_getProductsCount(str).ToList()[0].Product_Number.ToString());
                if (p > 20)
                    p = 20;
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
            double TotalDiscount = 0, customerDollar = 0, customerLBP = 0, restDollar = 0, restLBP = 0;

            if (cboxDiscount.CheckState == CheckState.Checked)
                TotalDiscount = Double.Parse(getTotalDiscount());


            //if (Properties.Settings.Default.CheckoutExtended)
            //{
            //    ExtendedCheckoutForm ecf = new ExtendedCheckoutForm(getFinalPriceDollar(TotalDiscount), getFinalPriceLBP(TotalDiscount));
            //    ecf.ShowDialog();
            //    restDollar = Math.Round(ecf.restDollar,3);
            //    restLBP = ecf.restLBP;
            //    customerDollar = Math.Round(ecf.customerDollar,3);
            //    customerLBP = ecf.customerLBP;
            //    //ecf.Dispose();
            //}

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
                        int CustomerID = 0;
                        if (customer != null)
                            CustomerID = customer.ID;

                        //newReceipt.RID = NewReceiptNumber;
                        if (receipt == null)
                        {
                            newReceipt.RBARCODE = newBarcode;
                            newReceipt.RITEM_NB = Int32.Parse(tot_quantity.Text);
                            newReceipt.TOTAL_AMOUNTDollar = getFinalPriceDollar(TotalDiscount);
                            newReceipt.TOTAL_AMOUNTLBP = Int32.Parse(getFinalPriceLBP(TotalDiscount).ToString());
                            newReceipt.RDATE = DateTime.Now;
                            newReceipt.TotalTVA = double.Parse(getTotalTVA());
                            newReceipt.TotalDiscount = TotalDiscount;
                            newReceipt.ReceiptTypeID = receiptType;
                            newReceipt.customerLBP = customerLBP;
                            newReceipt.customerDollar = customerDollar;
                            newReceipt.restLBP = restLBP;
                            newReceipt.restDollar = restDollar;
                            newReceipt.TotalProfit = getTotalReceiptProfit();
                            newReceipt.CustomerID = CustomerID;
                            cnx.TBLRECEIPTs.InsertOnSubmit(newReceipt);
                            cnx.SubmitChanges();
                        }
                        else
                        {
                            var r = (from aj in cnx.TBLRECEIPTs where aj.RID == receipt.RID select aj).Single();
                            r.RITEM_NB = Int32.Parse(tot_quantity.Text);
                            r.TOTAL_AMOUNTDollar = getFinalPriceDollar(TotalDiscount);
                            r.TOTAL_AMOUNTLBP = Int32.Parse(getFinalPriceLBP(TotalDiscount).ToString());
                            r.TotalTVA = double.Parse(getTotalTVA());
                            r.RDATE = DateTime.Now;
                            r.isHold = false;
                            r.TotalDiscount = TotalDiscount;
                            r.ReceiptTypeID = receiptType;
                            r.TotalProfit = getTotalReceiptProfit();
                            r.CustomerID = CustomerID;
                            newReceipt = r;
                        }
                        foreach (DataGridViewRow row in receipt_details.Rows)
                        {
                            try
                            {
                                var product = cnx.sp_getProductByName(row.Cells[1].Value.ToString()).ToList();
                                if (product[0].HasQuantity == true)
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
                                    newReceiptDetails.TotalDiscount = double.Parse(row.Cells[9].Value.ToString());
                                    newReceiptDetails.Profit = double.Parse(row.Cells[11].Value.ToString());
                                    if (prod.HasTVA)
                                        newReceiptDetails.TotalTVA = Double.Parse(newReceiptDetails.TOTAL_PRICEDollar.ToString()) * Double.Parse(Properties.Settings.Default.TVAPercentage.ToString()) / 100;
                                    else
                                        newReceiptDetails.TotalTVA = 0;
                                    cnx.TBLRECEIPTS_DETAILs.InsertOnSubmit(newReceiptDetails);
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
                                        newReceiptDetails.TotalDiscount = double.Parse(row.Cells[9].Value.ToString());
                                        newReceiptDetails.Profit = double.Parse(row.Cells[11].Value.ToString());
                                        if (prod.HasTVA)
                                            newReceiptDetails.TotalTVA = Double.Parse(newReceiptDetails.TOTAL_PRICEDollar.ToString()) * Double.Parse(Properties.Settings.Default.TVAPercentage.ToString()) / 100;
                                        else
                                            newReceiptDetails.TotalTVA = 0;
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
                                        newReceiptDetails.TotalDiscount = double.Parse(row.Cells[9].Value.ToString());
                                        newReceiptDetails.Profit = double.Parse(row.Cells[11].Value.ToString());
                                        if (prod.HasTVA)
                                            newReceiptDetails.TotalTVA = Double.Parse(newReceiptDetails.TOTAL_PRICEDollar.ToString()) * Double.Parse(Properties.Settings.Default.TVAPercentage.ToString()) / 100;
                                        else
                                            newReceiptDetails.TotalTVA = 0;
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
                                    newReceiptDetails.TotalDiscount = double.Parse(row.Cells[9].Value.ToString());
                                    newReceiptDetails.Profit = double.Parse(row.Cells[11].Value.ToString());
                                    if (product[0].HasTVA)
                                        newReceiptDetails.TotalTVA = Double.Parse(newReceiptDetails.TOTAL_PRICEDollar.ToString()) * Double.Parse(Properties.Settings.Default.TVAPercentage.ToString()) / 100;
                                    else
                                        newReceiptDetails.TotalTVA = 0;
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
                            DirectReceiptReportViewer drrv = new DirectReceiptReportViewer(Properties.Settings.Default.ReceiptType, receiptType, getTotalDiscount(), getTotalTVA(), getFinalPriceLBP(Double.Parse(getTotalDiscount())).ToString(), getFinalPriceDollar(Double.Parse(getTotalDiscount())).ToString());
                            drrv.receiptID = newReceipt.RID;
                            drrv.ShowDialog();
                        }
                        receipt_details.Rows.Clear();
                        tot_discount.Text = "0" + " $";
                        tot_net_dollar.Text = "0" + " $";
                        tot_quantity.Text = "0";
                        tot_tva.Text = "0" + " $";
                        tot_final_price_dolar.Text = "0" + " $";
                        tot_final_price_lbp.Text = "0" + " LBP";
                        cboxDiscount.CheckState = CheckState.Unchecked;
                        lblDiscount.Text = "Normal Price";
                        customer = null;
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
                inputQte = 1;
                this.Show();
            }
        }

        private void CleareReceipt()
        {
            receipt = null;
            POSUC_Load(null, null);
            receipt_id.Text = NewReceiptNumber.ToString();
            receipt_details.Rows.Clear();
            tot_discount.Text = "0" + " $";
            tot_net_dollar.Text = "0" + " $";
            tot_quantity.Text = "0";
            tot_tva.Text = "0" + " $";
            tot_final_price_dolar.Text = "0" + " $";
            tot_final_price_lbp.Text = "0" + " LBP";
            cboxDiscount.CheckState = CheckState.Unchecked;
            lblDiscount.Text = "Normal Price";
            customer = null;
        }


        private void AddNewButton(int i, int j, int c, int p, string str)
        {
            var products = (from pr in data.sp_select_products(str)
                            where pr.Status.Equals("Enabled")
                            select pr).Take(20).ToList();
            if (products.Count != 0)
            {
                SfButton button = new SfButton();
                button.AccessibleName = "Button";
                button.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
                button.BackgroundImageLayout = ImageLayout.Zoom;
                button.CanOverrideStyle = true;
                button.Cursor = Cursors.Hand;
                button.Font = new Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
                if (products[c].HasTVA)
                    toolTip1.SetToolTip(button, (Double.Parse((Double.Parse((Double.Parse(products[c].Price.ToString()) * Double.Parse(Properties.Settings.Default.TVAPercentage.ToString())).ToString()) / 100).ToString()) + Double.Parse((Double.Parse(products[c].Price.ToString())).ToString())).ToString());
                else
                    toolTip1.SetToolTip(button, products[c].Price.ToString());
                button.Text = products[c].ProductName;
                button.TextAlign = ContentAlignment.MiddleLeft;
                button.Style.HoverBorder = new Pen(Color.White);
                button.CanApplyTheme = true;
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

        private string getTotalTVA()
        {
            double tva = 0;
            foreach (DataGridViewRow row in receipt_details.Rows)
            {
                tva += Double.Parse(row.Cells[8].Value.ToString());
            }
            return tva.ToString();

        }
        private string getTotalDiscount()
        {
            double discount = 0;
            foreach (DataGridViewRow row in receipt_details.Rows)
            {
                discount += Double.Parse(row.Cells[9].Value.ToString());
            }
            return discount.ToString();

        }

        private double getFinalPriceDollar(double discount)
        {

            return Double.Parse(getTotalDollar()) - discount + Double.Parse(getTotalTVA());

        }

        private double getFinalPriceLBP(double discount)
        {

            double finalprice = double.Parse(getFinalPriceDollar(discount).ToString()) * double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString());
            return finalprice;
        }

        private double getTotalReceiptProfit()
        {
            double totalprofit = 0;
            foreach (DataGridViewRow row in receipt_details.Rows)
            {
                totalprofit += Double.Parse(row.Cells[11].Value.ToString());
            }
            return totalprofit;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {

                Globals.isReceiptOpen = true;
                string pname = (sender as SfButton).Text.Split('|')[0].Trim();
                int pid = data.sp_getProductByName(pname).ToList()[0].PID;
                double dollar = inputQte *  data.sp_getProductByName(pname).ToList()[0].PRICE.Value * receiptSwitcherValue;
                string barcode = data.sp_getProductByName(pname).ToList()[0].BARCODE;
                string supplier = data.sp_getSupplierByID(data.sp_getProductByName(pname).ToList()[0].SID.Value).ToList()[0].SNAME;
                int lbp =  Int32.Parse((dollar * double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString())).ToString());
                double secondaryPrice = inputQte *  data.sp_getProductByName(pname).ToList()[0].SecondaryPrice.Value * receiptSwitcherValue;
                double tva = data.sp_getProductByName(pname).ToList()[0].HasTVA ? (inputQte *  secondaryPrice * Double.Parse(Properties.Settings.Default.TVAPercentage.ToString()) / 100) : 0;
                double discount = 0;
                if (cboxDiscount.CheckState == CheckState.Unchecked)
                    discount = 0;
                else if (cboxDiscount.CheckState == CheckState.Checked)
                    discount = data.sp_getProductByName(pname).ToList()[0].SecondaryPrice == 0 ? 0 : inputQte * ( dollar - secondaryPrice);
                else if (cboxDiscount.CheckState == CheckState.Indeterminate)
                    discount = data.sp_getProductByName(pname).ToList()[0].DiscountPercentage == null ? 0 : inputQte * Double.Parse((dollar * Double.Parse(data.sp_getProductByName(pname).ToList()[0].DiscountPercentage.ToString())).ToString()) / 100;
                double? cost = data.sp_getProductByName(pname).ToList()[0].InitPrice;
                double? profit = dollar + tva - discount - cost;
                bool exist = false;
                foreach (DataGridViewRow row in receipt_details.Rows)
                {
                    if (row.Cells[1].Value.Equals(pname))
                    {
                        exist = true;
                        row.Cells[2].Value = supplier;
                        row.Cells[3].Value = Int32.Parse(row.Cells[3].Value.ToString()) + inputQte;
                        row.Cells[4].Value = cboxDiscount.CheckState == CheckState.Checked ? secondaryPrice : dollar;
                        row.Cells[5].Value = cboxDiscount.CheckState == CheckState.Checked ? Int32.Parse((secondaryPrice * Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString())).ToString()) : lbp;
                        row.Cells[6].Value = Int32.Parse((double.Parse(row.Cells[3].Value.ToString()) * double.Parse(lbp.ToString())).ToString());
                        row.Cells[7].Value = double.Parse(row.Cells[3].Value.ToString()) * dollar;
                        row.Cells[8].Value = Double.Parse(row.Cells[3].Value.ToString()) * tva;
                        row.Cells[9].Value = Double.Parse(row.Cells[3].Value.ToString()) * discount;
                        row.Cells[10].Value = secondaryPrice;
                        row.Cells[11].Value = double.Parse(row.Cells[3].Value.ToString()) * profit;
                        tot_quantity.Text = getTotalQTE();
                        tot_net_dollar.Text = getTotalDollar() + " $";
                        tot_discount.Text = getTotalLBP() + " LBP";
                        tot_tva.Text = (Double.Parse(getTotalTVA())).ToString() + " $";
                        double TotalDiscount = Double.Parse(getTotalDiscount());
                        tot_discount.Text = TotalDiscount.ToString() + " $";
                        tot_final_price_dolar.Text = getFinalPriceDollar(TotalDiscount).ToString() + " $";
                        tot_final_price_lbp.Text = getFinalPriceLBP(TotalDiscount).ToString("#,0;-#,0") + " LBP";
                        break;
                    }
                }
                if (!exist)
                {
                    receipt_details.Rows.Add(barcode, pname, supplier, inputQte, cboxDiscount.CheckState == CheckState.Checked ? secondaryPrice : dollar, cboxDiscount.CheckState == CheckState.Checked ? Int32.Parse((secondaryPrice * Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString())).ToString()) : lbp, lbp, dollar, tva, discount, secondaryPrice,profit);
                    tot_quantity.Text = getTotalQTE();
                    tot_net_dollar.Text = getTotalDollar() + " $";
                    tot_discount.Text = getTotalLBP() + " LBP";
                    tot_tva.Text = (Double.Parse(getTotalTVA())).ToString() + " $";
                    double TotalDiscount = Double.Parse(getTotalDiscount());
                    tot_discount.Text = TotalDiscount.ToString() + " $";
                    tot_final_price_dolar.Text = getFinalPriceDollar(TotalDiscount).ToString() + " $";
                    tot_final_price_lbp.Text = getFinalPriceLBP(TotalDiscount).ToString("#,0;-#,0") + " LBP";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error When Adding Items Please Contact Support!!", "Error !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            inputQte = 1;
            search_txt.Text = "";
            receipt_details.Rows[receipt_details.Rows.Count - 1].Selected = true;
            receipt_details.FirstDisplayedScrollingRowIndex = receipt_details.Rows.Count - 1;
            ActiveControl = search_txt;
        }

        private void change_quantity_btn_Click(object sender, EventArgs e)
        {
            if (receipt_details.Rows.Count <= 0)
            {
                MessageBox.Show("Please Select An Item First!!");
            }
            else
            {
                string pname = receipt_details.SelectedRows[0].Cells[1].Value.ToString();
                double dollar = double.Parse(data.sp_getProductByName(pname).ToList()[0].PRICE.Value.ToString());
                int lbp = Int32.Parse((dollar * Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString())).ToString());
                double secondaryPrice = data.sp_getProductByName(pname).ToList()[0].SecondaryPrice.Value * receiptSwitcherValue;
                double tva = data.sp_getProductByName(pname).ToList()[0].HasTVA ? (secondaryPrice * Double.Parse(Properties.Settings.Default.TVAPercentage.ToString()) / 100) : 0;
                double discount = 0;
                if (cboxDiscount.CheckState == CheckState.Unchecked)
                    discount = 0;
                else if (cboxDiscount.CheckState == CheckState.Checked)
                    discount = data.sp_getProductByName(pname).ToList()[0].SecondaryPrice == 0 ? 0 : dollar - secondaryPrice;
                else if (cboxDiscount.CheckState == CheckState.Indeterminate)
                    discount = data.sp_getProductByName(pname).ToList()[0].DiscountPercentage == null ? 0 : Double.Parse((dollar * Double.Parse(data.sp_getProductByName(pname).ToList()[0].DiscountPercentage.ToString())).ToString()) / 100;
                double? cost = data.sp_getProductByName(pname).ToList()[0].InitPrice;
                double? profit = dollar + tva - discount - cost;
                Globals.deleteNB = 0;
                ChangeQuantityForm cqf = new ChangeQuantityForm(Int32.Parse(receipt_details.SelectedRows[0].Cells[3].Value.ToString()));
                cqf.ShowDialog();
                if (Globals.deleteNB > 0)
                {
                    receipt_details.SelectedRows[0].Cells[3].Value = Globals.deleteNB;
                    receipt_details.SelectedRows[0].Cells[4].Value = cboxDiscount.CheckState == CheckState.Checked ? secondaryPrice : dollar;
                    receipt_details.SelectedRows[0].Cells[5].Value = cboxDiscount.CheckState == CheckState.Checked ? Int32.Parse((secondaryPrice * Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString())).ToString()) : Int32.Parse((dollar * Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString())).ToString());
                    receipt_details.SelectedRows[0].Cells[6].Value = Globals.deleteNB * lbp;
                    receipt_details.SelectedRows[0].Cells[7].Value = double.Parse(Globals.deleteNB.ToString()) * dollar;
                    receipt_details.SelectedRows[0].Cells[9].Value = double.Parse(Globals.deleteNB.ToString()) * discount;
                    receipt_details.SelectedRows[0].Cells[10].Value = secondaryPrice;
                    receipt_details.SelectedRows[0].Cells[11].Value = double.Parse(receipt_details.SelectedRows[0].Cells[3].Value.ToString()) * profit;
                    if (Double.Parse(receipt_details.SelectedRows[0].Cells[8].Value.ToString()) != 0)
                        receipt_details.SelectedRows[0].Cells[8].Value = (Double.Parse(Globals.deleteNB.ToString()) * tva).ToString();
                    tot_quantity.Text = getTotalQTE();
                    tot_net_dollar.Text = getTotalDollar() + " $";
                    tot_discount.Text = getTotalLBP() + " LBP";
                    tot_tva.Text = (Double.Parse(getTotalTVA())).ToString() + " $";
                    double TotalDiscount = Double.Parse(getTotalDiscount());
                    tot_discount.Text = TotalDiscount.ToString() + " $";
                    tot_final_price_dolar.Text = getFinalPriceDollar(TotalDiscount).ToString() + " $";
                    tot_final_price_lbp.Text = getFinalPriceLBP(TotalDiscount).ToString("#,0;-#,0") + " LBP";
                }
            }
            ActiveControl = search_txt;
        }

        private void updateDiscountPrices(CheckState discountSelection)
        {
            if (receipt_details.Rows.Count != 0)
            {
                foreach (DataGridViewRow row in receipt_details.Rows)
                {
                    string pname = row.Cells[1].Value.ToString();
                    double dollar = double.Parse(data.sp_getProductByName(pname).ToList()[0].PRICE.Value.ToString());
                    double secondaryPrice = data.sp_getProductByName(pname).ToList()[0].SecondaryPrice.Value * receiptSwitcherValue;
                    double tva = data.sp_getProductByName(pname).ToList()[0].HasTVA ? (secondaryPrice * Double.Parse(Properties.Settings.Default.TVAPercentage.ToString()) / 100) : 0;
                    double discount = 0;
                    double? cost = data.sp_getProductByName(pname).ToList()[0].InitPrice;
                    if (discountSelection == CheckState.Unchecked)
                    {
                        discount = 0;
                        row.Cells[4].Value = dollar;
                        row.Cells[5].Value = Int32.Parse((dollar * Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString())).ToString());
                    }
                    else if (discountSelection == CheckState.Checked)
                    {
                        discount = data.sp_getProductByName(pname).ToList()[0].SecondaryPrice == 0 ? 0 : (dollar - secondaryPrice) * double.Parse(row.Cells[3].Value.ToString());
                        row.Cells[4].Value = secondaryPrice;
                        row.Cells[5].Value = Int32.Parse((secondaryPrice * Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString())).ToString());                       
                    }
                    else if (discountSelection == CheckState.Indeterminate)
                        discount = data.sp_getProductByName(pname).ToList()[0].DiscountPercentage == null ? 0 : Double.Parse((dollar * Double.Parse(data.sp_getProductByName(pname).ToList()[0].DiscountPercentage.ToString())).ToString()) / 100;
                    double? profit = dollar + tva - discount - cost;
                    row.Cells[10].Value = secondaryPrice;
                    row.Cells[9].Value = discount;
                    if (Double.Parse(row.Cells[8].Value.ToString()) != 0)
                        row.Cells[8].Value = tva;
                    row.Cells[11].Value = double.Parse(row.Cells[3].Value.ToString()) * profit;
                }
                tot_quantity.Text = getTotalQTE();
                tot_net_dollar.Text = getTotalDollar() + " $";
                tot_discount.Text = getTotalLBP() + " LBP";
                tot_tva.Text = (Double.Parse(getTotalTVA())).ToString() + " $";
                double TotalDiscount = Double.Parse(getTotalDiscount());
                tot_discount.Text = TotalDiscount.ToString() + " $";
                tot_final_price_dolar.Text = getFinalPriceDollar(TotalDiscount).ToString() + " $";
                tot_final_price_lbp.Text = getFinalPriceLBP(TotalDiscount).ToString("#,0;-#,0") + " LBP";
                ActiveControl = search_txt;
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (receipt_details.Rows.Count <= 0 || receipt_details.SelectedRows.Count <=0)
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
                        string pname = receipt_details.SelectedRows[0].Cells[1].Value.ToString();
                        double secondaryPrice = data.sp_getProductByName(pname).ToList()[0].SecondaryPrice.Value * receiptSwitcherValue;
                        double discount = 0;
                        if (cboxDiscount.CheckState == CheckState.Unchecked)
                            discount = 0;
                        else if (cboxDiscount.CheckState == CheckState.Checked)
                            discount = data.sp_getProductByName(pname).ToList()[0].SecondaryPrice == 0 ? 0 : Double.Parse(receipt_details.SelectedRows[0].Cells[4].Value.ToString()) - secondaryPrice;
                        else if (cboxDiscount.CheckState == CheckState.Indeterminate)
                            discount = data.sp_getProductByName(pname).ToList()[0].DiscountPercentage == null ? 0 : Double.Parse((Double.Parse(receipt_details.SelectedRows[0].Cells[4].Value.ToString()) * Double.Parse(data.sp_getProductByName(pname).ToList()[0].DiscountPercentage.ToString())).ToString()) / 100;
                        double? cost = data.sp_getProductByName(pname).ToList()[0].InitPrice;
                        receipt_details.SelectedRows[0].Cells[3].Value = (Int32.Parse(receipt_details.SelectedRows[0].Cells[3].Value.ToString()) - Globals.deleteNB).ToString();
                        receipt_details.SelectedRows[0].Cells[7].Value = (double.Parse(receipt_details.SelectedRows[0].Cells[3].Value.ToString()) * double.Parse(receipt_details.SelectedRows[0].Cells[4].Value.ToString())).ToString();
                        receipt_details.SelectedRows[0].Cells[6].Value = (Int32.Parse(receipt_details.SelectedRows[0].Cells[3].Value.ToString()) * Int32.Parse(receipt_details.SelectedRows[0].Cells[5].Value.ToString())).ToString();
                        receipt_details.SelectedRows[0].Cells[9].Value = (Double.Parse(receipt_details.SelectedRows[0].Cells[3].Value.ToString()) * discount).ToString();
                        receipt_details.SelectedRows[0].Cells[10].Value = secondaryPrice;
                        double tva = 0;
                        if (Double.Parse(receipt_details.SelectedRows[0].Cells[8].Value.ToString()) != 0)
                            tva = Double.Parse((Double.Parse(receipt_details.SelectedRows[0].Cells[3].Value.ToString()) * Double.Parse(receipt_details.SelectedRows[0].Cells[10].Value.ToString()) * Double.Parse(Properties.Settings.Default.TVAPercentage.ToString())).ToString()) / 100;
                        double? profit = double.Parse(receipt_details.SelectedRows[0].Cells[4].Value.ToString()) + tva - discount - cost;
                        receipt_details.SelectedRows[0].Cells[11].Value = double.Parse(receipt_details.SelectedRows[0].Cells[3].Value.ToString()) * profit;
                    }
                    tot_quantity.Text = getTotalQTE();
                    tot_net_dollar.Text = getTotalDollar() + " $";
                    tot_discount.Text = getTotalLBP() + " LBP";
                    tot_tva.Text = (Double.Parse(getTotalTVA())).ToString() + " $";
                    double TotalDiscount = Double.Parse(getTotalDiscount());
                    tot_discount.Text = TotalDiscount.ToString() + " $";
                    tot_final_price_dolar.Text = getFinalPriceDollar(TotalDiscount).ToString() + " $";
                    tot_final_price_lbp.Text = getFinalPriceLBP(TotalDiscount).ToString("#,0;-#,0") + " LBP";
                }
            }
            ActiveControl = search_txt;
        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            if (search_txt.Text == "")
                inputQte = 1;
            Int64 barcode;
            bool isDigit = Int64.TryParse(search_txt.Text, out barcode);
            if (!isDigit)
            {
                time = 0;
                timerRefreshDataDelay.Start();
            }
            else
            {
                time = 0;
                timerRefreshInputQte.Start();
            }
        }

        private void add_btn_Click_1(object sender, EventArgs e)
        {
            timerRefreshInputQte.Stop();
            time = 0;
            Int64 b;
            bool isDigit = Int64.TryParse(search_txt.Text, out b);

            if (Properties.Settings.Default.showListInSale && !isDigit && !search_txt.Text.Contains("|"))
            {
                try
                {
                    (table.Controls[0] as SfButton).PerformClick();
                }
                catch (Exception ex)
                {
                    isErrorAppear = true;
                    search_txt.Text = "";
                    MessageBox.Show("This Item Not Exist! Try Again!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else
            {
                if (search_txt.Text != "")
                {
                    using (var ax = new MiniGramDBDataContext(Properties.Settings.Default.ConnectionString))
                    {
                        try
                        {
                            Globals.isReceiptOpen = true;
                            TBLPRODUCT product = (from aj in ax.TBLPRODUCTs where aj.BARCODE.Trim().ToLower() == search_txt.Text.Split('|')[0].Trim().ToLower() select aj).SingleOrDefault();
                            if (product == null)
                            {
                                search_txt.Text = "";
                                MessageBox.Show("This Item Not Exist! Try Again!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            string pname = product.PNAME;
                            int pid = data.sp_getProductByName(pname).ToList()[0].PID;
                            double dollar = inputQte * data.sp_getProductByName(pname).ToList()[0].PRICE.Value * receiptSwitcherValue;
                            string barcode = data.sp_getProductByName(pname).ToList()[0].BARCODE;
                            string supplier = data.sp_getSupplierByID(data.sp_getProductByName(pname).ToList()[0].SID.Value).ToList()[0].SNAME;
                            int lbp = Int32.Parse((dollar * double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString())).ToString());
                            double secondaryPrice = inputQte * data.sp_getProductByName(pname).ToList()[0].SecondaryPrice.Value * receiptSwitcherValue;
                            double tva = data.sp_getProductByName(pname).ToList()[0].HasTVA ? (inputQte * secondaryPrice * Double.Parse(Properties.Settings.Default.TVAPercentage.ToString()) / 100) : 0;

                            double discount = 0;
                            if (cboxDiscount.CheckState == CheckState.Unchecked)
                                discount = 0;
                            else if (cboxDiscount.CheckState == CheckState.Checked)
                                discount = data.sp_getProductByName(pname).ToList()[0].SecondaryPrice == 0 ? 0 : inputQte * (dollar - secondaryPrice);
                            else if (cboxDiscount.CheckState == CheckState.Indeterminate)
                                discount = data.sp_getProductByName(pname).ToList()[0].DiscountPercentage == null ? 0 : inputQte * Double.Parse((dollar * Double.Parse(data.sp_getProductByName(pname).ToList()[0].DiscountPercentage.ToString())).ToString()) / 100;
                            double? cost = data.sp_getProductByName(pname).ToList()[0].InitPrice;
                            double? profit = dollar + tva - discount - cost;
                            bool exist = false;
                            foreach (DataGridViewRow row in receipt_details.Rows)
                            {
                                if (row.Cells[1].Value.Equals(pname))
                                {
                                    exist = true;
                                    row.Cells[2].Value = supplier;
                                    row.Cells[3].Value = Int32.Parse(row.Cells[3].Value.ToString()) + inputQte;
                                    row.Cells[4].Value = cboxDiscount.CheckState == CheckState.Checked ? secondaryPrice : dollar;
                                    row.Cells[5].Value = cboxDiscount.CheckState == CheckState.Checked ? Int32.Parse((secondaryPrice * Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString())).ToString()) :lbp;
                                    row.Cells[6].Value = Int32.Parse((double.Parse(row.Cells[3].Value.ToString()) * double.Parse(lbp.ToString())).ToString());
                                    row.Cells[7].Value = double.Parse(row.Cells[3].Value.ToString()) * dollar;
                                    if (Double.Parse(row.Cells[8].Value.ToString()) != 0)
                                        row.Cells[8].Value = (Double.Parse(row.Cells[3].Value.ToString()) * tva).ToString();
                                    row.Cells[9].Value = Int32.Parse(row.Cells[3].Value.ToString()) * discount;
                                    row.Cells[10].Value = secondaryPrice;
                                    row.Cells[11].Value = double.Parse(row.Cells[3].Value.ToString()) * profit;
                                    tot_quantity.Text = getTotalQTE();
                                    tot_net_dollar.Text = getTotalDollar() + " $";
                                    tot_discount.Text = getTotalLBP() + " LBP";
                                    tot_tva.Text = (Double.Parse(getTotalTVA())).ToString() + " $";
                                    double TotalDiscount = Double.Parse(getTotalDiscount());
                                    tot_discount.Text = TotalDiscount.ToString() + " $";
                                    tot_final_price_dolar.Text = getFinalPriceDollar(TotalDiscount).ToString() + " $";
                                    tot_final_price_lbp.Text = getFinalPriceLBP(TotalDiscount).ToString("#,0;-#,0") + " LBP";// + " LBP";
                                    //double num = getFinalPriceLBP(TotalDiscount) % Math.Round(getFinalPriceLBP(TotalDiscount), 0);
                                    //MessageBox.Show(num.ToString());
                                    break;
                                }
                            }
                            if (!exist)
                            {
                                receipt_details.Rows.Add(barcode, pname, supplier, inputQte, cboxDiscount.CheckState == CheckState.Checked ? secondaryPrice : dollar, cboxDiscount.CheckState.ToString() == "1" ? Int32.Parse((secondaryPrice * Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString())).ToString()) : lbp, lbp, dollar, tva, discount, secondaryPrice,profit);
                                tot_quantity.Text = getTotalQTE();
                                tot_net_dollar.Text = getTotalDollar() + " $";
                                tot_discount.Text = getTotalLBP() + " LBP";
                                tot_tva.Text = (Double.Parse(getTotalTVA())).ToString() + " $";
                                double TotalDiscount = Double.Parse(getTotalDiscount());
                                tot_discount.Text = TotalDiscount.ToString() + " $";
                                tot_final_price_dolar.Text = getFinalPriceDollar(TotalDiscount).ToString() + " $";
                                tot_final_price_lbp.Text = getFinalPriceLBP(TotalDiscount).ToString("#,0;-#,0") + " LBP";// + " LBP";
                                //double num = 1000 - (getFinalPriceLBP(TotalDiscount) % 1000);
                                //MessageBox.Show(num.ToString());
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
            inputQte = 1;
            search_txt.Text = "";
            receipt_details.Rows[receipt_details.Rows.Count - 1].Selected = true;
            receipt_details.FirstDisplayedScrollingRowIndex = receipt_details.Rows.Count - 1;
            ActiveControl = search_txt;
        }

        private void keyboard_btn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = "C:\\Windows\\System32\\osk.exe";
            Process process = new Process();
            process.StartInfo = ps;
            process.Start();
            ActiveControl = search_txt;
        }

        private void POSUC_KeyUp(object sender, KeyEventArgs e)
        {
            if (search_txt.Text == "")
                return;
            if (e.KeyValue != 13)
            { 

            }
            else
            {
                if (!isErrorAppear)
                    add_btn_Click_1(null, null);
                else
                    isErrorAppear = false;
            }
        }

        private void search_txt_KeyUp(object sender, KeyEventArgs e)
        {
            if (search_txt.Text == "")
                return;
            e.Handled = true;
            e.SuppressKeyPress = true;
            if (e.KeyValue != 13)
            {

            }
            else
            {
                if (!isErrorAppear)
                    add_btn_Click_1(null, null);
                else
                    isErrorAppear = false;
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
            if (receiptType == 2)
            {
                MessageBox.Show("You Cannot Hold Return Receipt !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double TotalDiscount = 0;
            if (cboxDiscount.CheckState == CheckState.Unchecked)
                TotalDiscount = Double.Parse(getTotalDiscount());
            using (var cnx = new MiniGramDBDataContext(Globals.ConnectionString))
            {
                if (MessageBox.Show("Are You Sure You Want To Hold This Receipt ??", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string newBarcode = generateNewBarcode();
                    if (receipt == null)
                    {
                        int maxrid;
                        try
                        {
                            maxrid = Int32.Parse(data.sp_getLastReceiptID().ToList()[0].MAX_RID.ToString());
                        }
                        catch (Exception ex)
                        {
                            maxrid = 0;
                        }
                        NewReceiptNumber = maxrid + 1;
                    }
                    else
                    {
                        NewReceiptNumber = receipt.RID;
                    }
                    var newReceipt = new TBLRECEIPT();

                    int CustomerID = 0;
                    if (customer != null)
                        CustomerID = customer.ID;
                    if (receipt == null)
                    {
                        newReceipt.RBARCODE = newBarcode;
                        newReceipt.RITEM_NB = Int32.Parse(tot_quantity.Text);
                        newReceipt.TOTAL_AMOUNTDollar = getFinalPriceDollar(TotalDiscount);
                        newReceipt.TOTAL_AMOUNTLBP = Int32.Parse(getFinalPriceLBP(TotalDiscount).ToString());
                        newReceipt.RDATE = DateTime.Now;
                        newReceipt.isHold = true;
                        newReceipt.TotalTVA = Double.Parse(getTotalTVA());
                        newReceipt.TotalDiscount = TotalDiscount;
                        newReceipt.ReceiptTypeID = 4;
                        newReceipt.TotalProfit = getTotalReceiptProfit();
                        newReceipt.CustomerID = CustomerID;
                        cnx.TBLRECEIPTs.InsertOnSubmit(newReceipt);
                        cnx.SubmitChanges();
                    }
                    else
                    {
                        var r = (from aj in cnx.TBLRECEIPTs where aj.RID == receipt.RID select aj).Single();
                        r.RITEM_NB = Int32.Parse(tot_quantity.Text);
                        r.TOTAL_AMOUNTDollar = getFinalPriceDollar(TotalDiscount);
                        r.TOTAL_AMOUNTLBP = Int32.Parse(getFinalPriceLBP(TotalDiscount).ToString());
                        r.TotalTVA = Double.Parse(getTotalTVA());
                        r.isHold = true;
                        r.TotalDiscount = TotalDiscount;
                        r.ReceiptTypeID = 4;
                        r.TotalProfit = getTotalReceiptProfit();
                        r.CustomerID = CustomerID;
                        receiptType = 4;
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
                        newHoldDetails.TotalTVA = Double.Parse(row.Cells[8].Value.ToString());
                        newHoldDetails.Profit = Double.Parse(row.Cells[11].Value.ToString());
                        newHoldDetails.TotalDiscount = TotalDiscount;
                        cnx.TBLHOLDDETAILs.InsertOnSubmit(newHoldDetails);

                    }
                    cnx.SubmitChanges();
                    receiptType = 4;
                    if (!Properties.Settings.Default.printInCheckout)
                    {
                        DirectReceiptReportViewer drrv = new DirectReceiptReportViewer(Properties.Settings.Default.ReceiptType, receiptType, getTotalDiscount(), getTotalTVA(), getFinalPriceLBP(Double.Parse(getTotalDiscount())).ToString(), getFinalPriceDollar(Double.Parse(getTotalDiscount())).ToString());
                        drrv.receiptID = newReceipt.RID;
                        drrv.ShowDialog();
                    }
                    CleareReceipt();
                    Globals.isReceiptOpen = false;
                }
            }

        }

        private void chkboxApplyDiscount_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            if (receiptType == 1)
            {
                switchReceiptType(2);
            }
            else if (receiptType == 2)
            {
                switchReceiptType(1);
            }

        }

        private void switchReceiptType(int type)
        {
            int value = -1;
            if (type == 1)
            {
                lblReceiptType.Text = "Sale Receipt";
                lblReceiptType.BackColor = Color.FromArgb(0, 118, 125);
                receiptType = type;
                receiptSwitcherValue = 1;
            }
            else if (type == 2)
            {
                if (MessageBox.Show("You Are Switching To Return Receipt Type, Are Your Sure ??", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    lblReceiptType.Text = "Return Receipt";
                    lblReceiptType.BackColor = Color.Red;
                    receiptType = type;
                    receiptSwitcherValue = -1;
                }
                else
                    return;
            }

            foreach (DataGridViewRow row in receipt_details.Rows)
            {
                row.Cells[3].Value = Int32.Parse(row.Cells[3].Value.ToString()) * value;
                row.Cells[6].Value = Int32.Parse(row.Cells[6].Value.ToString()) * value;
                row.Cells[7].Value = Double.Parse(row.Cells[7].Value.ToString()) * value;
                row.Cells[8].Value = Double.Parse(row.Cells[8].Value.ToString()) * value;
                row.Cells[9].Value = Double.Parse(row.Cells[9].Value.ToString()) * value;
                row.Cells[10].Value = Double.Parse(row.Cells[10].Value.ToString()) * value;
                row.Cells[11].Value = Double.Parse(row.Cells[11].Value.ToString()) * value;
                tot_quantity.Text = getTotalQTE();
                tot_net_dollar.Text = getTotalDollar() + " $";
                tot_discount.Text = getTotalLBP() + " LBP";
                tot_tva.Text = (Double.Parse(getTotalTVA())).ToString() + " $";
                double TotalDiscount = Double.Parse(getTotalDiscount());
                tot_discount.Text = TotalDiscount.ToString() + " $";
                tot_final_price_dolar.Text = getFinalPriceDollar(TotalDiscount).ToString() + " $";
                tot_final_price_lbp.Text = getFinalPriceLBP(TotalDiscount).ToString("#,0;-#,0") + " LBP";
            }
        }

        private void cboxDiscount_SelectedValueChanged(object sender, EventArgs e)
        {
            //string value = cboxDiscount.SelectedValue.ToString();
            //if (value.ToString() == "1")
            //{
            //    BatchNumberForm bnf = new BatchNumberForm(this);
            //    bnf.ShowDialog();
            //    if (cardNumber == "")
            //    {
            //        cboxDiscount.SelectedValue = 0;
            //        return;
            //    }
            //    else
            //    {
            //        using (var ax = new OrganigramDBDataContext(Properties.Settings.Default.ConnectionStringUsers))
            //        {
            //            List<TblUser> userCardNumber = (from aj in ax.TblUsers where aj.CardNumber == cardNumber select aj).ToList();
            //            lblDiscount.Text = userCardNumber.Count != 0 ? userCardNumber[0].FullNameEn : "Discount";
            //        }
            //    }
            //    updateDiscountPrices(Int32.Parse(value.ToString()));
            //}
            //else if (value.ToString() == "2")
            //{
            //    updateDiscountPrices(Int32.Parse(value.ToString()));
            //    lblDiscount.Text = "Discount";
            //    cardNumber = "";
            //}
            //else if (value.ToString() == "0")
            //{
            //    updateDiscountPrices(Int32.Parse(value.ToString()));
            //    lblDiscount.Text = "Discount";
            //    cardNumber = "";
            //}

            //ActiveControl = search_txt;
        }

        private void timerRefreshDataDelay_Tick(object sender, EventArgs e)
        {
            if (time >= 2)
            {
                refreshData(search_txt.Text);
                time = 0;
                timerRefreshDataDelay.Stop();
            }
            else
            {
                time++;
            }
        }

        private void btnCheckoutExt_Click(object sender, EventArgs e)
        {

        }

        private void timerRefreshInputQte_Tick(object sender, EventArgs e)
        {
            if (time >= 2 && search_txt.Text != "")
            {
                int num;
                bool isDigit = int.TryParse(search_txt.Text, out num);
                if (!isDigit)
                    return;
                if (num < 100 && num > 0)
                {
                    inputQte = num;
                    search_txt.Text = "|"+search_txt.Text;
                    Console.WriteLine(inputQte.ToString());
                }
                else
                {
                    inputQte = 1;
                    Console.WriteLine(inputQte.ToString());
                }
                time = 0;
                timerRefreshInputQte.Stop();
            }
            else
            {
                time++;
            }
        }

        private void btnExtCheckOut_Click(object sender, EventArgs e)
        {

            double TotalDiscount = 0, customerDollar = 0, customerLBP = 0, restDollar = 0, restLBP = 0;

            if (cboxDiscount.CheckState == CheckState.Checked)
                TotalDiscount = Double.Parse(getTotalDiscount());


            using (var cnx = new MiniGramDBDataContext(Globals.ConnectionString))
            {
                if (receipt_details.Rows.Count == 0)
                {
                    MessageBox.Show("Please Enter At Least One Product!!");
                }
                else
                {

                    ExtendedCheckoutForm ecf = new ExtendedCheckoutForm(getFinalPriceDollar(TotalDiscount), getFinalPriceLBP(TotalDiscount));
                    ecf.ShowDialog();
                    if (ecf.canceled)
                    {
                        return;
                    }
                    restDollar = Math.Round(ecf.restDollar, 3);
                    restLBP = ecf.restLBP;
                    customerDollar = Math.Round(ecf.customerDollar, 3);
                    customerLBP = ecf.customerLBP;
                    
                    string newBarcode = generateNewBarcode();
                    try
                    {
                        var newReceipt = new TBLRECEIPT();

                        int CustomerID = 0;
                        if (customer != null)
                            CustomerID = customer.ID;
                        //newReceipt.RID = NewReceiptNumber;
                        if (receipt == null)
                        {
                            newReceipt.RBARCODE = newBarcode;
                            newReceipt.RITEM_NB = Int32.Parse(tot_quantity.Text);
                            newReceipt.TOTAL_AMOUNTDollar = getFinalPriceDollar(TotalDiscount);
                            newReceipt.TOTAL_AMOUNTLBP = Int32.Parse(getFinalPriceLBP(TotalDiscount).ToString());
                            newReceipt.RDATE = DateTime.Now;
                            newReceipt.TotalTVA = double.Parse(getTotalTVA());
                            newReceipt.TotalDiscount = TotalDiscount;
                            newReceipt.ReceiptTypeID = receiptType;
                            newReceipt.customerLBP = customerLBP;
                            newReceipt.customerDollar = customerDollar;
                            newReceipt.restLBP = restLBP;
                            newReceipt.restDollar = restDollar;
                            newReceipt.TotalProfit = getTotalReceiptProfit();
                            newReceipt.CustomerID = CustomerID;
                            cnx.TBLRECEIPTs.InsertOnSubmit(newReceipt);
                            cnx.SubmitChanges();
                        }
                        else
                        {
                            var r = (from aj in cnx.TBLRECEIPTs where aj.RID == receipt.RID select aj).Single();
                            r.RITEM_NB = Int32.Parse(tot_quantity.Text);
                            r.TOTAL_AMOUNTDollar = getFinalPriceDollar(TotalDiscount);
                            r.TOTAL_AMOUNTLBP = Int32.Parse(getFinalPriceLBP(TotalDiscount).ToString());
                            r.TotalTVA = double.Parse(getTotalTVA());
                            r.RDATE = DateTime.Now;
                            r.isHold = false;
                            r.TotalDiscount = TotalDiscount;
                            r.ReceiptTypeID = receiptType;
                            r.TotalProfit = getTotalReceiptProfit();
                            r.CustomerID = CustomerID;
                            newReceipt = r;
                        }
                        foreach (DataGridViewRow row in receipt_details.Rows)
                        {
                            try
                            {
                                var product = cnx.sp_getProductByName(row.Cells[1].Value.ToString()).ToList();
                                if (product[0].HasQuantity == true)
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
                                    newReceiptDetails.TotalDiscount = double.Parse(row.Cells[9].Value.ToString());
                                    newReceiptDetails.Profit = double.Parse(row.Cells[11].Value.ToString());
                                    if (prod.HasTVA)
                                        newReceiptDetails.TotalTVA = Double.Parse(newReceiptDetails.TOTAL_PRICEDollar.ToString()) * Double.Parse(Properties.Settings.Default.TVAPercentage.ToString()) / 100;
                                    else
                                        newReceiptDetails.TotalTVA = 0;
                                    cnx.TBLRECEIPTS_DETAILs.InsertOnSubmit(newReceiptDetails);
                                    //}
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
                                        newReceiptDetails.TotalDiscount = double.Parse(row.Cells[9].Value.ToString());
                                        newReceiptDetails.Profit = double.Parse(row.Cells[11].Value.ToString());

                                        if (prod.HasTVA)
                                            newReceiptDetails.TotalTVA = Double.Parse(newReceiptDetails.TOTAL_PRICEDollar.ToString()) * Double.Parse(Properties.Settings.Default.TVAPercentage.ToString()) / 100;
                                        else
                                            newReceiptDetails.TotalTVA = 0;
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
                                        newReceiptDetails.TotalDiscount = double.Parse(row.Cells[9].Value.ToString());
                                        newReceiptDetails.Profit = double.Parse(row.Cells[11].Value.ToString());
                                        if (prod.HasTVA)
                                            newReceiptDetails.TotalTVA = Double.Parse(newReceiptDetails.TOTAL_PRICEDollar.ToString()) * Double.Parse(Properties.Settings.Default.TVAPercentage.ToString()) / 100;
                                        else
                                            newReceiptDetails.TotalTVA = 0;
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
                                    newReceiptDetails.TotalDiscount = double.Parse(row.Cells[9].Value.ToString());
                                    newReceiptDetails.Profit = double.Parse(row.Cells[11].Value.ToString());
                                    
                                    if (product[0].HasTVA)
                                        newReceiptDetails.TotalTVA = Double.Parse(newReceiptDetails.TOTAL_PRICEDollar.ToString()) * Double.Parse(Properties.Settings.Default.TVAPercentage.ToString()) / 100;
                                    else
                                        newReceiptDetails.TotalTVA = 0;
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
                            DirectReceiptReportViewer drrv = new DirectReceiptReportViewer(Properties.Settings.Default.ReceiptType, receiptType, getTotalDiscount(), getTotalTVA(), getFinalPriceLBP(Double.Parse(getTotalDiscount())).ToString(), getFinalPriceDollar(Double.Parse(getTotalDiscount())).ToString());
                            drrv.receiptID = newReceipt.RID;
                            drrv.ShowDialog();
                        }
                        receipt_details.Rows.Clear();
                        tot_discount.Text = "0" + " $";
                        tot_net_dollar.Text = "0" + " $";
                        tot_quantity.Text = "0";
                        tot_tva.Text = "0" + " $";
                        tot_final_price_dolar.Text = "0" + " $";
                        tot_final_price_lbp.Text = "0" + " LBP";
                        cboxDiscount.CheckState = CheckState.Unchecked;
                        lblDiscount.Text = "Discount";
                        customer = null;
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
                inputQte = 1;
                this.Show();
            }
        }

        private void cboxDiscount_CheckStateChanged(object sender, EventArgs e)
        {
            CheckState value = cboxDiscount.CheckState;
            if (value == CheckState.Checked)
            {
                updateDiscountPrices(value);

                if(customer != null)
                    lblDiscount.Text = "VIP Price (" + customer.FullName + ")";
                else
                    lblDiscount.Text = "VIP Price";
            }
            else if (value == CheckState.Indeterminate)
            {
                updateDiscountPrices(value);
                if (customer != null)
                    lblDiscount.Text = "% Discount (" + customer.FullName + ")";
                else
                    lblDiscount.Text = "% Discount";

            }
            else if (value == CheckState.Unchecked)
            {
                updateDiscountPrices(value);
                if (customer != null)
                    lblDiscount.Text = "Normal Price (" + customer.FullName + ")";
                else
                    lblDiscount.Text = "Normal Price";
            }

            ActiveControl = search_txt;
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            ChooseCustomerForm ccf = new ChooseCustomerForm();
            ccf.ShowDialog();
            customer = ccf.customer;

            if (customer == null) return;

            if (customer.isVIP)
                cboxDiscount.CheckState = CheckState.Checked;
            else if (!customer.isVIP)
                cboxDiscount.CheckState = CheckState.Unchecked;
            else
                cboxDiscount.CheckState = CheckState.Indeterminate;
        }
    }
}
