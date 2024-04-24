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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGram.Controls
{
    public partial class POSUC : UserControl
    {
        private MiniGramDBDataContext data;
        private TableLayoutPanel table;
        private int? NewReceiptNumber;
        private string selectedProductName = "";
        private TBLRECEIPT receipt;
        public string cardNumber = "";
        private int receiptType = 1;
        private int receiptSwitcherValue = 1;
        private bool isErrorAppear = false;
        private int time = 0;
        private int inputQte = 1;

        public POSUC(TBLRECEIPT receipt)
        {
            this.receipt = receipt;
            InitializeComponent();
        }

        private void POSUC_Load(object sender, EventArgs e)
        {
            Globals.draftStockTempQte.Clear();
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
                        NewReceiptNumber = int.Parse(data.sp_getLastReceiptID().ToList()[0].MAX_RID.ToString()) + 1;

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
            List<int> productListIDs = (from aj in data.TBLHOLDDETAILs where aj.RID == receipt.RID select int.Parse(aj.PID.ToString())).ToList();
            List<TBLPRODUCT> productList = (from aj in data.TBLPRODUCTs where productListIDs.Contains(aj.PID) select aj).ToList();

            cardNumber = "";
            cboxDiscount.CheckState = !String.IsNullOrEmpty(cardNumber) ? CheckState.Checked : CheckState.Unchecked;
            foreach (TBLPRODUCT product in productList)
            {
                if (!Globals.draftStockTempQte.Keys.Contains(product.PID))
                    Globals.draftStockTempQte.Add(product.PID, 0);
                try
                {
                    double discount = 0;
                    var holdItem = (from aj in data.TBLHOLDDETAILs where aj.PID == product.PID && aj.RID == receipt.RID select aj).Single();
                    string pname = product.PNAME;

                    //int ExistingRowQTE = (from aj in receipt_details.Rows.Cast<DataGridViewRow>() where aj.Cells["PNAME"].Value.ToString() == pname select int.Parse(aj.Cells["QTE"].Value.ToString())).SingleOrDefault();
                    int ExistingRowQTE = int.Parse(holdItem.QTE.ToString());
                    int productCurrency = product.CurrencyID;
                    TBLCURRENCy currency = (from aj in data.TBLCURRENCies where aj.ID == productCurrency select aj).SingleOrDefault();
                    string currencyStr = (from aj in data.TBLCURRENCies where aj.ID == product.CurrencyID select aj.CurrencyName).SingleOrDefault();
                    double dollar = product.CurrencyID == 2 ? Math.Round(product.PRICE.Value,2) : Math.Round(Math.Round(Double.Parse(product.PRICE.Value.ToString()), 2) / Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()),2);
                    double unitprice = product.PRICE.Value;
                    if (product.HasQuantity == true && ExistingRowQTE > product.QTE)
                    {
                        List<TBLDELIVERY_RECEIPTS_DETAIL> HeldCurrentProductStock = (from aj in data.TBLDELIVERY_RECEIPTS_DETAILs join az in data.TBLDELIVERY_RECEIPTs on aj.RID equals az.ID where aj.PID == product.PID && aj.isInSale == false && az.StatusID >= 2 orderby aj.dateCreated ascending select aj).ToList();

                        if (HeldCurrentProductStock.Count > 0)
                        {
                            int HoldProductCurrencyID = (from aj in data.TBLDELIVERY_RECEIPTs where aj.ID == HeldCurrentProductStock[0].RID select int.Parse(aj.CurrencyID.ToString())).SingleOrDefault();
                            double holdProductPrice = Double.Parse(HeldCurrentProductStock[0].SellPrice.ToString());
                            if (HoldProductCurrencyID == currency.ID)
                            {
                                dollar = product.CurrencyID == 2 ? Math.Max(holdProductPrice, Double.Parse(product.PRICE.ToString())) : Double.Parse((Math.Max(holdProductPrice, Double.Parse(product.PRICE.ToString()))).ToString()) / Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString());
                                unitprice = product.CurrencyID == 2 ? Math.Max(holdProductPrice, Double.Parse(product.PRICE.ToString())) : Double.Parse((Math.Max(holdProductPrice, Double.Parse(product.PRICE.ToString()))).ToString());
                            }
                            else
                            {
                                dollar = product.CurrencyID == 2 ? Math.Max(holdProductPrice / Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()), Double.Parse(product.PRICE.ToString())) : Double.Parse((Math.Max(holdProductPrice * Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()), Double.Parse(product.PRICE.ToString()))).ToString()) / Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString());
                                unitprice = product.CurrencyID == 2 ? Math.Max(holdProductPrice / Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()), Double.Parse(product.PRICE.ToString())) : Double.Parse((Math.Max(holdProductPrice * Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()), Double.Parse(product.PRICE.ToString()))).ToString());
                            }              
                        }
                        else
                        {
                            MessageBox.Show("Your Stock in in Negative, This item is out of Stock, Please Check Your Stock Quantity of Product Name : " + pname + " .", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    double secondaryPrice = product.SecondaryPrice.Value;
                    double secondaryPriceDollar = product.CurrencyID == 2 ? Math.Round(secondaryPrice,2) : Math.Round(Math.Round(Double.Parse(secondaryPrice.ToString()),2) / Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()),2);
                    string barcode = product.BARCODE;
                    string supplier = data.sp_getSupplierByID(product.SID.Value).ToList()[0].SNAME;
                    int lbp = int.Parse(Math.Round(dollar * Properties.Settings.Default.dollarLBPPrice, 0).ToString());
                    double tva = product.HasTVA ? (secondaryPriceDollar * Double.Parse(Properties.Settings.Default.TVAPercentage.ToString()) / 100) : 0;
                    if (cboxDiscount.CheckState == CheckState.Unchecked)
                        discount = 0;
                    else if (cboxDiscount.CheckState == CheckState.Checked)
                        discount = product.InitPrice == 0 ? 0 : dollar - secondaryPriceDollar;
                    else if (cboxDiscount.CheckState == CheckState.Indeterminate)
                        discount = product.DiscountPercentage == null ? 0 : Double.Parse((dollar * Double.Parse(product.DiscountPercentage.ToString())).ToString()) / 100;
                    bool exist = false;
                    for (int i = 0; i < holdItem.QTE; i++)
                    {
                        foreach (DataGridViewRow row in receipt_details.Rows)
                        {
                            if (row.Cells["PNAME"].Value.Equals(pname))
                            {
                                exist = true;
                                row.Cells["SupplierName"].Value = supplier;
                                row.Cells["QTE"].Value = int.Parse(row.Cells["QTE"].Value.ToString()) + 1;
                                row.Cells["TotalLBP"].Value = Globals.LBPRounding(int.Parse((double.Parse(row.Cells["QTE"].Value.ToString()) * double.Parse(lbp.ToString())).ToString()));
                                row.Cells["TotalDollar"].Value = double.Parse(row.Cells["QTE"].Value.ToString()) * dollar;
                                row.Cells["UnitPrice"].Value = currency.ID == 1 ? Globals.LBPRounding(unitprice) : unitprice;
                                row.Cells["TotalPrice"].Value = double.Parse(row.Cells["QTE"].Value.ToString()) * (currency.ID == 1 ? Globals.LBPRounding(unitprice) : unitprice);
                                row.Cells["TotalTVA"].Value = int.Parse(row.Cells["QTE"].Value.ToString()) * tva;
                                row.Cells["TotalDiscount"].Value = int.Parse(row.Cells["QTE"].Value.ToString()) * discount;
                                row.Cells["SecondPrice"].Value = currency.ID == 1 ? Globals.LBPRounding(secondaryPrice) : secondaryPriceDollar;
                                row.Cells["Currency"].Value = currency.CurrencyName;
                                row.Cells["CurrencyID"].Value = product.CurrencyID;
                                tot_quantity.Text = getTotalQTE();
                                tot_net_dollar.Text = getTotalPrice() + " $";
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
                            receipt_details.Rows.Add(barcode, pname, supplier, 1, unitprice, unitprice, secondaryPrice, currency.CurrencyName, dollar, lbp, lbp, dollar, tva, discount, product.CurrencyID);
                            tot_quantity.Text = getTotalQTE();
                            tot_net_dollar.Text = getTotalPrice() + " $";
                            tot_tva.Text = (Double.Parse(getTotalTVA())).ToString() + " $";
                            double TotalDiscount = Double.Parse(getTotalDiscount());
                            tot_discount.Text = TotalDiscount.ToString() + " $";
                            tot_final_price_dolar.Text = getFinalPriceDollar(TotalDiscount).ToString() + " $";
                            tot_final_price_lbp.Text = getFinalPriceLBP(TotalDiscount).ToString("#,0;-#,0") + " LBP";
                        }               
                        search_txt.Text = "";
                        ActiveControl = search_txt;
                    }
                    Globals.draftStockTempQte[product.PID] = ExistingRowQTE;
                }
                catch
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
                table.RowCount = 21; //(int.Parse(data.sp_getProductsCount(str).ToList()[0].Product_Number.ToString()) / table.ColumnCount) + 1;
                products_panel.AutoScrollMinSize = new Size(0, (table.RowCount + 1) * 100);
                int i = 0, j = 0, c = 0, p = int.Parse(data.sp_getProductsCount(str).ToList()[0].Product_Number.ToString());
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
                        if (receipt == null)
                        {
                            newReceipt.RBARCODE = newBarcode;
                            newReceipt.RITEM_NB = int.Parse(tot_quantity.Text);
                            newReceipt.TOTAL_AMOUNTDollar = Math.Round(getFinalPriceDollar(TotalDiscount),3);
                            newReceipt.TOTAL_AMOUNTLBP = int.Parse(getFinalPriceLBP(TotalDiscount).ToString());
                            newReceipt.RDATE = DateTime.Now;
                            newReceipt.TotalTVA = double.Parse(getTotalTVA());
                            newReceipt.TotalDiscount = Math.Round(TotalDiscount,3);
                            newReceipt.ReceiptTypeID = receiptType;
                            newReceipt.customerLBP = customerLBP;
                            newReceipt.customerDollar = Math.Round(customerDollar,3);
                            newReceipt.restLBP = restLBP;
                            newReceipt.restDollar = Math.Round(restDollar,3);
                            newReceipt.UserID = 0;
                            newReceipt.EmpCardNumber = cardNumber;
                            cnx.TBLRECEIPTs.InsertOnSubmit(newReceipt);
                            cnx.SubmitChanges();
                        }
                        else
                        {
                            var r = (from aj in cnx.TBLRECEIPTs where aj.RID == receipt.RID select aj).Single();
                            r.RITEM_NB = int.Parse(tot_quantity.Text);
                            r.TOTAL_AMOUNTDollar = Math.Round(getFinalPriceDollar(TotalDiscount),3);
                            r.TOTAL_AMOUNTLBP = int.Parse(getFinalPriceLBP(TotalDiscount).ToString());
                            r.TotalTVA = Math.Round(double.Parse(getTotalTVA()),3);
                            r.RDATE = DateTime.Now;
                            r.isHold = false;
                            r.TotalDiscount = Math.Round(TotalDiscount,3);
                            r.ReceiptTypeID = receiptType;
                            r.UserID = 0;
                            r.EmpCardNumber = cardNumber;
                            newReceipt = r;
                        }
                        foreach (DataGridViewRow row in receipt_details.Rows)
                        {
                            try
                            {
                                var product = cnx.sp_getProductByName(row.Cells["PNAME"].Value.ToString()).ToList();
                                if (product[0].HasQuantity == true)
                                {

                                    TBLPRODUCT prod = (from aj in cnx.TBLPRODUCTs
                                                       where aj.PID == product[0].PID && aj.ENABLED == true
                                                       select aj).Single();

                                    int currentQuantity = prod.QTE;
                                    int inStockValue = 0;
                                    inStockValue = Globals.draftStockTempQte.TryGetValue(prod.PID, out inStockValue) ? inStockValue : 0;
                                    int newQuantity = currentQuantity - inStockValue;
                                    int DeliveryInNewQuantity = currentQuantity <= 0 ? inStockValue : (newQuantity > 0 ? 0 : Math.Abs(newQuantity));

                                    if (newQuantity < 0)
                                    {
                                        List<TBLDELIVERY_RECEIPTS_DETAIL> drd = (from aj in cnx.TBLDELIVERY_RECEIPTS_DETAILs join az in cnx.TBLDELIVERY_RECEIPTs on aj.RID equals az.ID where aj.PID == prod.PID && aj.isInSale == false && az.StatusID >= 2 && aj.Quantity > aj.inStockQuantity orderby aj.dateCreated ascending select aj).ToList();
                                        TBLDELIVERY_RECEIPT dReceipt = (from aj in cnx.TBLDELIVERY_RECEIPTs where aj.ID == drd[0].RID select aj).Single();

                                        if (dReceipt.StatusID >= 4)
                                        {
                                            drd[0].isInSale = true;
                                            drd[0].inStockQuantity = drd[0].inStockQuantity + inStockValue;
                                            prod.QTE = int.Parse((drd[0].Quantity - inStockValue).ToString());
                                            prod.CurrencyID = int.Parse(dReceipt.CurrencyID.ToString());
                                            prod.HasQuantity = !drd[0].HasExpDate;
                                            prod.SecondaryPrice = drd[0].SecondaryPrice;
                                            prod.PRICE = drd[0].SellPrice;
                                            prod.InitPrice = drd[0].Cost;
                                            prod.HasExpiredDate = drd[0].HasExpDate ? 1 : 0;
                                            prod.HasDiscount = drd[0].HasDiscount;
                                            prod.DiscountPercentage = drd[0].Discount;
                                            prod.HasTVA = drd[0].HasTVA;

                                            if (drd[0].HasExpDate)
                                            {
                                                TBLEXPIREDDATE exp = new TBLEXPIREDDATE();
                                                exp.PID = drd[0].PID;
                                                exp.Qte = prod.QTE;
                                                exp.ExpiredDate = drd[0].ExpDate;
                                                exp.dateCreated = DateTime.Now;
                                                cnx.TBLEXPIREDDATEs.InsertOnSubmit(exp);
                                            }
                                        }
                                        else
                                        {
                                            drd[0].isInSale = false;
                                            drd[0].inStockQuantity = drd[0].inStockQuantity + DeliveryInNewQuantity;
                                            prod.QTE = newQuantity;
                                        }
                                    }
                                    else
                                    {
                                        prod.QTE = newQuantity;
                                    }
                                }
                                else if (product[0].HasExpiredDate == 1)
                                {

                                    List<TBLEXPIREDDATE> ExpiredDateList = (from aj in cnx.TBLEXPIREDDATEs where aj.PID == product[0].PID && aj.ExpiredDate.Value > DateTime.Today select aj).ToList();
                                    int totalQuantity = (from aj in ExpiredDateList select aj.Qte).Sum(x => int.Parse(x.ToString()));
                                    if (totalQuantity == int.Parse(row.Cells["QTE"].Value.ToString()))
                                    {
                                        TBLEXPIREDDATE minExpDate = (from aj in ExpiredDateList orderby aj.ExpiredDate ascending select aj).First();
                                        TBLPRODUCT prod = (from aj in cnx.TBLPRODUCTs
                                                           where aj.PID == product[0].PID && aj.ENABLED == true
                                                           select aj).Single();
                                        prod.QTE = 0;
                                        cnx.TBLEXPIREDDATEs.DeleteOnSubmit(minExpDate);
                                        if (prod.QTE < 0)
                                        {
                                            List<TBLDELIVERY_RECEIPTS_DETAIL> drd = (from aj in cnx.TBLDELIVERY_RECEIPTS_DETAILs join az in cnx.TBLDELIVERY_RECEIPTs on aj.RID equals az.ID where aj.PID == prod.PID && aj.isInSale == false && az.StatusID >= 2 && aj.Quantity > aj.inStockQuantity orderby aj.dateCreated ascending select aj).ToList();
                                            TBLDELIVERY_RECEIPT dReceipt = (from aj in cnx.TBLDELIVERY_RECEIPTs where aj.ID == drd[0].RID select aj).Single();

                                            if (dReceipt.StatusID >= 4)
                                            {
                                                drd[0].isInSale = true;
                                                int inStockValue = 0;
                                                inStockValue = Globals.draftStockTempQte.TryGetValue(prod.PID, out inStockValue) ? inStockValue : 0;
                                                drd[0].inStockQuantity = drd[0].inStockQuantity + inStockValue;
                                                prod.QTE = int.Parse((drd[0].Quantity - inStockValue).ToString());
                                                prod.CurrencyID = int.Parse(dReceipt.CurrencyID.ToString());
                                                prod.HasQuantity = !drd[0].HasExpDate;
                                                prod.SecondaryPrice = drd[0].SecondaryPrice;
                                                prod.PRICE = drd[0].SellPrice;
                                                prod.InitPrice = drd[0].Cost;
                                                prod.HasExpiredDate = drd[0].HasExpDate ? 1 : 0;
                                                prod.HasDiscount = drd[0].HasDiscount;
                                                prod.DiscountPercentage = drd[0].Discount;
                                                prod.HasTVA = drd[0].HasTVA;

                                                if (drd[0].HasExpDate)
                                                {
                                                    TBLEXPIREDDATE exp = new TBLEXPIREDDATE();
                                                    exp.PID = drd[0].PID;
                                                    exp.Qte = prod.QTE;
                                                    exp.ExpiredDate = drd[0].ExpDate;
                                                    exp.dateCreated = DateTime.Now;
                                                    cnx.TBLEXPIREDDATEs.InsertOnSubmit(exp);
                                                }
                                            }
                                            else
                                            {
                                                drd[0].isInSale = false;
                                                int inStockValue = 0;
                                                inStockValue = Globals.draftStockTempQte.TryGetValue(prod.PID, out inStockValue) ? inStockValue : 0;
                                                drd[0].inStockQuantity = drd[0].inStockQuantity + inStockValue;
                                                prod.QTE = int.Parse((drd[0].Quantity - inStockValue).ToString());
                                            }
                                        }
                                    }
                                    else
                                    {
                                        TBLPRODUCT prod = (from aj in cnx.TBLPRODUCTs
                                                           where aj.PID == product[0].PID && aj.ENABLED == true
                                                           select aj).Single();
                                        prod.QTE = (from aj in ExpiredDateList select aj.Qte).Sum(x => int.Parse(x.ToString()));

                                        int tmpqte = prod.QTE;
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
                                        if (tmpqte < 0)
                                        {

                                            List<TBLDELIVERY_RECEIPTS_DETAIL> drd = (from aj in cnx.TBLDELIVERY_RECEIPTS_DETAILs join az in cnx.TBLDELIVERY_RECEIPTs on aj.RID equals az.ID where aj.PID == prod.PID && aj.isInSale == false && az.StatusID >= 2 && aj.Quantity > aj.inStockQuantity && aj.Quantity > aj.inStockQuantity orderby aj.dateCreated ascending select aj).ToList();
                                            TBLDELIVERY_RECEIPT dReceipt = (from aj in cnx.TBLDELIVERY_RECEIPTs where aj.ID == drd[0].RID select aj).Single();

                                            if (dReceipt.StatusID >= 4)
                                            {
                                                drd[0].isInSale = true;
                                                int inStockValue = 0;
                                                inStockValue = Globals.draftStockTempQte.TryGetValue(prod.PID, out inStockValue) ? inStockValue : 0;
                                                drd[0].inStockQuantity = drd[0].inStockQuantity + inStockValue;
                                                prod.QTE = int.Parse((drd[0].Quantity - inStockValue).ToString());
                                                prod.CurrencyID = int.Parse(dReceipt.CurrencyID.ToString());
                                                prod.HasQuantity = !drd[0].HasExpDate;
                                                prod.SecondaryPrice = drd[0].SecondaryPrice;
                                                prod.PRICE = drd[0].SellPrice;
                                                prod.InitPrice = drd[0].Cost;
                                                prod.HasExpiredDate = drd[0].HasExpDate ? 1 : 0;
                                                prod.HasDiscount = drd[0].HasDiscount;
                                                prod.DiscountPercentage = drd[0].Discount;
                                                prod.HasTVA = drd[0].HasTVA;

                                                if (drd[0].HasExpDate)
                                                {
                                                    TBLEXPIREDDATE exp = new TBLEXPIREDDATE();
                                                    exp.PID = drd[0].PID;
                                                    exp.Qte = prod.QTE;
                                                    exp.ExpiredDate = drd[0].ExpDate;
                                                    exp.dateCreated = DateTime.Now;
                                                    cnx.TBLEXPIREDDATEs.InsertOnSubmit(exp);
                                                }
                                            }
                                            else
                                            {
                                                drd[0].isInSale = false;
                                                prod.QTE = int.Parse((drd[0].Quantity - drd[0].inStockQuantity).ToString());
                                            }
                                        }
                                    }
                                }
                                var newReceiptDetails = new TBLRECEIPTS_DETAIL();
                                newReceiptDetails.RID = newReceipt.RID;
                                newReceiptDetails.PID = product[0].PID;
                                newReceiptDetails.QTE = Convert.ToInt32(row.Cells["QTE"].Value.ToString());
                                newReceiptDetails.PRICE_Dollar = Math.Round(double.Parse(row.Cells["DollarPrice"].Value.ToString()), 3);
                                newReceiptDetails.TOTAL_PRICEDollar = Math.Round(double.Parse(row.Cells["TotalDollar"].Value.ToString()), 3);
                                try
                                {
                                    newReceiptDetails.PRICE_LBP = Convert.ToInt32(row.Cells["LBPPrice"].Value.ToString());
                                }
                                catch
                                {
                                    newReceiptDetails.PRICE_LBP = 0;
                                }
                                try
                                {
                                    newReceiptDetails.TOTAL_PRICELBP = Convert.ToInt32(row.Cells["TotalLBP"].Value.ToString());
                                }
                                catch
                                {
                                    newReceiptDetails.TOTAL_PRICELBP = 0;
                                }                               
                                newReceiptDetails.TotalDiscount = Math.Round(double.Parse(row.Cells["TotalDiscount"].Value.ToString()), 3);
                                newReceiptDetails.CurrencyID = Convert.ToInt32(row.Cells["CurrencyID"].Value.ToString());
                                if (product[0].HasTVA)
                                    newReceiptDetails.TotalTVA = Double.Parse(newReceiptDetails.TOTAL_PRICEDollar.ToString()) * Double.Parse(Properties.Settings.Default.TVAPercentage.ToString()) / 100;
                                else
                                    newReceiptDetails.TotalTVA = 0;
                                cnx.TBLRECEIPTS_DETAILs.InsertOnSubmit(newReceiptDetails);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("An Error Occured When Adding Receipt, Please Call Support !!\n"+ex.Message+"\n"+ex.Message);
                            }
                        }
                        cnx.SubmitChanges();
                        if (!Properties.Settings.Default.printInCheckout)
                        {
                            int receiptTypeID = Properties.Settings.Default.ReceiptType;
                            int receiptNumber = receiptType;
                            string totalDiscount = getTotalDiscount();
                            string totalTVA = getTotalTVA();
                            string finalPriceLBP = getFinalPriceLBP(Double.Parse(getTotalDiscount())).ToString();
                            string finalPriceDollar = (Math.Round(getFinalPriceLBP(Double.Parse(getTotalDiscount())) / Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()), 2)).ToString();
                            Thread tr = new Thread(() =>
                            {
                                try
                                {
                                    DirectReceiptReportViewer drrv = new DirectReceiptReportViewer(receiptTypeID, receiptNumber, totalDiscount, totalTVA, finalPriceLBP, finalPriceDollar);
                                    drrv.receiptID = newReceipt.RID;
                                    drrv.Print();
                                    Thread.CurrentThread.Abort();
                                }
                                catch(Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                    Thread.CurrentThread.Abort();
                                }
                            });
                            tr.Priority = ThreadPriority.Highest;
                            tr.Start();
                        }
                        receipt_details.Rows.Clear();
                        tot_discount.Text = "0" + " $";
                        tot_net_dollar.Text = "0" + " $";
                        tot_quantity.Text = "0";
                        tot_tva.Text = "0" + " $";
                        tot_final_price_dolar.Text = "0" + " $";
                        tot_final_price_lbp.Text = "0" + " LBP";
                        cboxDiscount.CheckState = CheckState.Unchecked;
                        lblDiscount.Text = "Employee Discount";
                        Globals.draftStockTempQte.Clear();
                        cardNumber = "";
                        Properties.Settings.Default.BuyDollarLBPPrice = Properties.Settings.Default.dollarLBPPrice;
                        Properties.Settings.Default.dollarLBPPrice = Properties.Settings.Default.dollarLBPPrice;
                        Properties.Settings.Default.Save();
                        try
                        {
                            NewReceiptNumber = int.Parse(cnx.sp_getLastReceiptID().ToList()[0].MAX_RID.ToString()) + 1;
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
                        MessageBox.Show(ex.StackTrace + ex.Message + "\nAn Error Occured When Adding Receipt, Please Call Support !!");
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
            lblDiscount.Text = "Employee Discount";
            cardNumber = "";
            Properties.Settings.Default.BuyDollarLBPPrice = Properties.Settings.Default.dollarLBPPrice;
            Properties.Settings.Default.dollarLBPPrice = Properties.Settings.Default.dollarLBPPrice;
            Properties.Settings.Default.Save();
            Globals.draftStockTempQte.Clear();
        }


        private void AddNewButton(int i, int j, int c, int p, string str)
        {
            var products = (from pr in data.sp_select_products(str,false)
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
                totalDollar += double.Parse(row.Cells["TotalDollar"].Value.ToString());
            }
            return Math.Round(totalDollar,3).ToString();
        }
        private string getTotalLBP()
        {
            return Int64.Parse(Math.Round((Math.Round(getTotalPrice(), 2) * Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString())), 0).ToString()).ToString();
        }
        private string getTotalQTE()
        {
            int QTE = 0;
            foreach (DataGridViewRow row in receipt_details.Rows)
            {
                QTE += int.Parse(row.Cells["QTE"].Value.ToString());
            }
            return QTE.ToString();
        }

        private string getTotalTVA()
        {
            double tva = 0;
            foreach (DataGridViewRow row in receipt_details.Rows)
            {
                tva += Double.Parse(row.Cells["TotalTVA"].Value.ToString());
            }
            return Math.Round(tva, 3).ToString();

        }
        private string getTotalDiscount()
        {
            double discount = 0;
            foreach (DataGridViewRow row in receipt_details.Rows)
            {
                discount += Double.Parse(row.Cells["TotalDiscount"].Value.ToString());
            }
            return Math.Round(discount, 3).ToString();

        }

        private double getFinalPriceDollar(double discount)
        {

            return getTotalPrice() - discount + Double.Parse(getTotalTVA());

        }

        private double getFinalPriceLBP(double discount)
        {
            double finalprice = double.Parse(getFinalPriceDollar(discount).ToString()) * double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString());
            return Globals.LBPRounding(finalprice);
        }

        private double getTotalPrice()
        {
            double totalPrice = 0;
            foreach (DataGridViewRow row in receipt_details.Rows)
            {
                totalPrice += int.Parse(row.Cells["CurrencyID"].Value.ToString()) == 1 ? double.Parse(row.Cells["TotalPrice"].Value.ToString()) / double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()) : double.Parse(row.Cells["TotalPrice"].Value.ToString());
            }
            return Math.Round(totalPrice, 3);
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Globals.isReceiptOpen = true;
                string pname = (sender as SfButton).Text.Split('|')[0];

                TBLPRODUCT product = (from aj in data.TBLPRODUCTs where aj.ENABLED == true && aj.PNAME == pname select aj).SingleOrDefault();

                int ExistingRowQTE = (from aj in receipt_details.Rows.Cast<DataGridViewRow>() where aj.Cells["PNAME"].Value.ToString() == pname select int.Parse(aj.Cells["QTE"].Value.ToString())).SingleOrDefault();
                if (!Globals.draftStockTempQte.ContainsKey(product.PID))
                    Globals.draftStockTempQte.Add(product.PID, 0);
                int productCurrencyID = product.CurrencyID;
                TBLCURRENCy currency = (from aj in data.TBLCURRENCies where aj.ID == productCurrencyID select aj).SingleOrDefault();
                double dollar =     Math.Round(product.CurrencyID == 2 ? inputQte * product.PRICE.Value * receiptSwitcherValue : Double.Parse((inputQte * product.PRICE.Value * receiptSwitcherValue).ToString()) / Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()),3);
                double secondaryPrice = inputQte * product.SecondaryPrice.Value * receiptSwitcherValue;
                double secondaryPriceDollar = Math.Round(product.CurrencyID == 2 ? secondaryPrice : Double.Parse(secondaryPrice.ToString()) / Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()),3);
                double unitprice = product.PRICE.Value * receiptSwitcherValue;
                int lbp = int.Parse(Math.Round(dollar * Properties.Settings.Default.dollarLBPPrice, 0).ToString());
                List<TBLDELIVERY_RECEIPTS_DETAIL> HeldCurrentProductStock = (from aj in data.TBLDELIVERY_RECEIPTS_DETAILs join az in data.TBLDELIVERY_RECEIPTs on aj.RID equals az.ID where aj.PID == product.PID && aj.isInSale == false && az.StatusID >= 2 && az.ReceiptDate.Value.Date <= DateTime.Today.Date && (aj.Quantity + (product.QTE <= 0 ? 0 : product.QTE) > aj.inStockQuantity + ExistingRowQTE) orderby aj.dateCreated ascending select aj).ToList();

                if (receiptSwitcherValue == 1)
                {
                    if (product.HasQuantity == true && ExistingRowQTE + inputQte > product.QTE)
                    {
                        if (HeldCurrentProductStock.Count > 0)
                        {
                            int HoldProductCurrencyID = (from aj in data.TBLDELIVERY_RECEIPTs where aj.ID == HeldCurrentProductStock[0].RID select int.Parse(aj.CurrencyID.ToString())).SingleOrDefault();
                            double holdProductPrice = Double.Parse(HeldCurrentProductStock[0].SellPrice.ToString()) * receiptSwitcherValue;
                            double holdProductDollarPrice = Math.Round((HoldProductCurrencyID == 1 ? holdProductPrice / Int64.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()) : holdProductPrice), 3);
                            double holdProductSecondaryPrice = Double.Parse(HeldCurrentProductStock[0].SecondaryPrice.ToString()) * receiptSwitcherValue;
                            double holdProductSecondaryPriceDollar = Math.Round((HoldProductCurrencyID == 1 ? holdProductSecondaryPrice / Int64.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()) : holdProductSecondaryPrice), 3);
                            dollar = Math.Max(holdProductDollarPrice, dollar);
                            secondaryPriceDollar = dollar == holdProductDollarPrice ? holdProductSecondaryPriceDollar : secondaryPriceDollar;
                            secondaryPrice = dollar == holdProductDollarPrice ? holdProductSecondaryPrice : secondaryPrice;
                            productCurrencyID = dollar == holdProductDollarPrice ? HoldProductCurrencyID : productCurrencyID;
                            lbp = int.Parse(Math.Round(dollar * Properties.Settings.Default.dollarLBPPrice, 0).ToString());
                            if (HoldProductCurrencyID == currency.ID)
                            {
                                unitprice = Math.Round(product.CurrencyID == 2 ? Math.Max(holdProductDollarPrice, unitprice) : Double.Parse((Math.Max(holdProductPrice, unitprice)).ToString()), 3);
                                currency = (from aj in data.TBLCURRENCies where aj.ID == productCurrencyID select aj).SingleOrDefault();
                            }
                            else
                            {
                                unitprice = Math.Round(product.CurrencyID == 2 ? Math.Max(holdProductPrice, unitprice * Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString())) : Double.Parse((Math.Max(holdProductPrice, unitprice)).ToString()), 3);
                                currency = (from aj in data.TBLCURRENCies where aj.ID == productCurrencyID select aj).SingleOrDefault();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Your Stock in in Negative, This item is out of Stock, Please Check Your Stock Quantity of Product Name : " + pname + " .", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    Globals.draftStockTempQte[product.PID] = (ExistingRowQTE + inputQte) * receiptSwitcherValue;
                }
                else if (receiptSwitcherValue == -1)
                {
                    if (HeldCurrentProductStock.Count > 0)
                    {
                        int HoldProductCurrencyID = (from aj in data.TBLDELIVERY_RECEIPTs where aj.ID == HeldCurrentProductStock[0].RID select int.Parse(aj.CurrencyID.ToString())).SingleOrDefault();
                        double holdProductPrice = Double.Parse(HeldCurrentProductStock[0].SellPrice.ToString()) * receiptSwitcherValue;
                        double holdProductDollarPrice = Math.Round((HoldProductCurrencyID == 1 ? holdProductPrice / Int64.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()) : holdProductPrice), 3);
                        double holdProductSecondaryPrice = Double.Parse(HeldCurrentProductStock[0].SecondaryPrice.ToString()) * receiptSwitcherValue;
                        double holdProductSecondaryPriceDollar = Math.Round((HoldProductCurrencyID == 1 ? holdProductSecondaryPrice / Int64.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()) : holdProductSecondaryPrice), 3);
                        dollar = Math.Max(holdProductDollarPrice, dollar);
                        secondaryPriceDollar = dollar == holdProductDollarPrice ? holdProductSecondaryPriceDollar : secondaryPriceDollar;
                        secondaryPrice = dollar == holdProductDollarPrice ? holdProductSecondaryPrice : secondaryPrice;
                        productCurrencyID = dollar == holdProductDollarPrice ? HoldProductCurrencyID : productCurrencyID;
                        lbp = int.Parse(Math.Round(dollar * Properties.Settings.Default.dollarLBPPrice, 0).ToString());
                        if (HoldProductCurrencyID == currency.ID)
                        {
                            unitprice = Math.Round(product.CurrencyID == 2 ? Math.Max(holdProductDollarPrice, unitprice) : Double.Parse((Math.Max(holdProductPrice, unitprice)).ToString()), 3);
                            currency = (from aj in data.TBLCURRENCies where aj.ID == productCurrencyID select aj).SingleOrDefault();
                        }
                        else
                        {
                            unitprice = Math.Round(product.CurrencyID == 2 ? Math.Max(holdProductPrice, unitprice * Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString())) : Double.Parse((Math.Max(holdProductPrice, unitprice)).ToString()), 3);
                            currency = (from aj in data.TBLCURRENCies where aj.ID == productCurrencyID select aj).SingleOrDefault();
                        }
                    }
                    Globals.draftStockTempQte[product.PID] = (ExistingRowQTE + inputQte) * receiptSwitcherValue;
                }


                string barcode = product.BARCODE;
                string supplier = data.sp_getSupplierByID(product.SID.Value).ToList()[0].SNAME;
                double tva = product.HasTVA ? (inputQte * secondaryPriceDollar * Double.Parse(Properties.Settings.Default.TVAPercentage.ToString()) / 100) : 0;
                double discount = 0;

                if (cboxDiscount.CheckState == CheckState.Unchecked)
                    discount = 0;
                else if (cboxDiscount.CheckState == CheckState.Checked)
                    discount = Math.Round(product.InitPrice == 0 ? 0 : inputQte * (dollar - secondaryPriceDollar),3);
                else if (cboxDiscount.CheckState == CheckState.Indeterminate)
                    discount = Math.Round(product.DiscountPercentage == null ? 0 : inputQte * Double.Parse((dollar * Double.Parse(product.DiscountPercentage.ToString())).ToString()) / 100,3);
                bool exist = false;
                foreach (DataGridViewRow row in receipt_details.Rows)
                {
                    if (row.Cells["PNAME"].Value.Equals(pname))
                    {
                        exist = true;
                        row.Cells["SupplierName"].Value = supplier;
                        row.Cells["QTE"].Value = int.Parse(row.Cells["QTE"].Value.ToString()) + inputQte;
                        row.Cells["DollarPrice"].Value = cboxDiscount.CheckState == CheckState.Checked ? secondaryPriceDollar : dollar;
                        row.Cells["UnitPrice"].Value = currency.ID == 1 ? Globals.LBPRounding(unitprice) : unitprice;
                        row.Cells["TotalPrice"].Value = double.Parse(row.Cells["QTE"].Value.ToString()) * (currency.ID == 1 ? Globals.LBPRounding(unitprice) : unitprice);
                        row.Cells["LBPPrice"].Value = Globals.LBPRounding(cboxDiscount.CheckState == CheckState.Checked ?Int64.Parse((Math.Round(secondaryPriceDollar * Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()), 0)).ToString()) : lbp);
                        row.Cells["TotalLBP"].Value = int.Parse(Math.Round((double.Parse(row.Cells["QTE"].Value.ToString()) * double.Parse(lbp.ToString())),0).ToString());
                        row.Cells["TotalDollar"].Value = double.Parse(row.Cells["QTE"].Value.ToString()) * dollar;
                        row.Cells["TotalTVA"].Value = Double.Parse(row.Cells["QTE"].Value.ToString()) * tva;
                        row.Cells["TotalDiscount"].Value = Double.Parse(row.Cells["QTE"].Value.ToString()) * discount;
                        row.Cells["SecondPrice"].Value = currency.ID == 1 ? Globals.LBPRounding(secondaryPrice) : secondaryPriceDollar;
                        row.Cells["Currency"].Value = currency.CurrencyName;
                        row.Cells["CurrencyID"].Value = currency.ID;
                        tot_quantity.Text = getTotalQTE();
                        tot_net_dollar.Text = getTotalPrice() + " $";
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
                    receipt_details.Rows.Add(barcode, pname, supplier, inputQte, currency.ID == 1 ? Globals.LBPRounding(unitprice) : unitprice, currency.ID == 1 ? Globals.LBPRounding(unitprice) : unitprice, currency.ID == 1 ? Globals.LBPRounding(secondaryPrice) : secondaryPrice, currency.CurrencyName, dollar, Globals.LBPRounding(lbp), Globals.LBPRounding(lbp), dollar, tva, discount, currency.ID);
                    tot_quantity.Text = getTotalQTE();
                    tot_net_dollar.Text = getTotalPrice() + " $";
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
                Globals.newQteNb = 0;
                ChangeQuantityForm cqf = new ChangeQuantityForm(int.Parse(receipt_details.SelectedRows[0].Cells["QTE"].Value.ToString()));
                cqf.ShowDialog();

                string pname = receipt_details.SelectedRows[0].Cells["PNAME"].Value.ToString();
                TBLPRODUCT product = (from aj in data.TBLPRODUCTs where aj.ENABLED == true && aj.PNAME == pname select aj).SingleOrDefault();
                int productCurrencyID = product.CurrencyID;
                TBLCURRENCy currency = (from aj in data.TBLCURRENCies where aj.ID == productCurrencyID select aj).SingleOrDefault();
                double unitprice = product.PRICE.Value * receiptSwitcherValue;
                double dollar = product.CurrencyID == 2 ? Math.Round(product.PRICE.Value * receiptSwitcherValue,2) : Math.Round(Math.Round(Double.Parse((inputQte * product.PRICE.Value * receiptSwitcherValue).ToString()),2) / Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()),2);
                double secondaryPrice = product.SecondaryPrice.Value * receiptSwitcherValue;
                double secondaryPriceDollar = product.CurrencyID == 2 ? Math.Round(secondaryPrice,2) : Math.Round(Math.Round(Double.Parse(secondaryPrice.ToString()),2) / Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()),2);
                int lbp = int.Parse(Math.Round(dollar * Properties.Settings.Default.dollarLBPPrice, 0).ToString());
                List<TBLDELIVERY_RECEIPTS_DETAIL> HeldCurrentProductStock = (from aj in data.TBLDELIVERY_RECEIPTS_DETAILs join az in data.TBLDELIVERY_RECEIPTs on aj.RID equals az.ID where aj.PID == product.PID && aj.isInSale == false && az.StatusID >= 2 && az.ReceiptDate.Value.Date <= DateTime.Today.Date && aj.Quantity + (product.QTE <= 0 ? 0 : product.QTE) >= aj.inStockQuantity + Globals.newQteNb orderby aj.dateCreated ascending select aj).ToList();
                if (receiptSwitcherValue == 1)
                {
                    if (product.HasQuantity == true && Globals.newQteNb > product.QTE)
                    {
                        if (HeldCurrentProductStock.Count > 0)
                        {
                            int HoldProductCurrencyID = (from aj in data.TBLDELIVERY_RECEIPTs where aj.ID == HeldCurrentProductStock[0].RID select int.Parse(aj.CurrencyID.ToString())).SingleOrDefault();
                            double holdProductPrice = Double.Parse(HeldCurrentProductStock[0].SellPrice.ToString()) * receiptSwitcherValue;
                            double holdProductDollarPrice = Math.Round((HoldProductCurrencyID == 1 ? holdProductPrice / Int64.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()) : holdProductPrice), 3);
                            double holdProductSecondaryPrice = Double.Parse(HeldCurrentProductStock[0].SecondaryPrice.ToString()) * receiptSwitcherValue;
                            double holdProductSecondaryPriceDollar = Math.Round((HoldProductCurrencyID == 1 ? holdProductSecondaryPrice / Int64.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()) : holdProductSecondaryPrice), 3);
                            dollar = Math.Round(Math.Max(holdProductDollarPrice, dollar),2);
                            secondaryPriceDollar = dollar == holdProductDollarPrice ? holdProductSecondaryPriceDollar : secondaryPriceDollar;
                            secondaryPrice = dollar == holdProductDollarPrice ? holdProductSecondaryPrice : secondaryPrice;
                            productCurrencyID = dollar == holdProductDollarPrice ? HoldProductCurrencyID : productCurrencyID;
                            lbp = int.Parse(Math.Round(dollar * Properties.Settings.Default.dollarLBPPrice, 0).ToString());
                            if (HoldProductCurrencyID == currency.ID)
                            {
                                unitprice = Math.Round(product.CurrencyID == 2 ? Math.Max(holdProductDollarPrice, unitprice) : Double.Parse((Math.Max(holdProductPrice, unitprice)).ToString()), 3);
                                currency = (from aj in data.TBLCURRENCies where aj.ID == productCurrencyID select aj).SingleOrDefault();
                            }
                            else
                            {
                                unitprice = Math.Round(product.CurrencyID == 2 ? Math.Max(holdProductPrice, unitprice * Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString())) : Double.Parse((Math.Max(holdProductPrice, unitprice)).ToString()), 3);
                                currency = (from aj in data.TBLCURRENCies where aj.ID == productCurrencyID select aj).SingleOrDefault();
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("Your Stock in in Negative, This item is out of Stock, Please Check Your Stock Quantity of Product Name : " + pname + " .", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    Globals.draftStockTempQte[product.PID] = Globals.newQteNb * receiptSwitcherValue;
                }
                else if (receiptSwitcherValue == -1)
                {
                    if (HeldCurrentProductStock.Count > 0)
                    {
                        int HoldProductCurrencyID = (from aj in data.TBLDELIVERY_RECEIPTs where aj.ID == HeldCurrentProductStock[0].RID select int.Parse(aj.CurrencyID.ToString())).SingleOrDefault();
                        double holdProductPrice = Double.Parse(HeldCurrentProductStock[0].SellPrice.ToString()) * receiptSwitcherValue;
                        double holdProductDollarPrice = Math.Round((HoldProductCurrencyID == 1 ? holdProductPrice / Int64.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()) : holdProductPrice), 3);
                        double holdProductSecondaryPrice = Double.Parse(HeldCurrentProductStock[0].SecondaryPrice.ToString()) * receiptSwitcherValue;
                        double holdProductSecondaryPriceDollar = Math.Round((HoldProductCurrencyID == 1 ? holdProductSecondaryPrice / Int64.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()) : holdProductSecondaryPrice), 3);
                        dollar = Math.Max(holdProductDollarPrice, dollar);
                        secondaryPriceDollar = dollar == holdProductDollarPrice ? holdProductSecondaryPriceDollar : secondaryPriceDollar;
                        secondaryPrice = dollar == holdProductDollarPrice ? holdProductSecondaryPrice : secondaryPrice;
                        productCurrencyID = dollar == holdProductDollarPrice ? HoldProductCurrencyID : productCurrencyID;
                        lbp = int.Parse(Math.Round(dollar * Properties.Settings.Default.dollarLBPPrice, 0).ToString());
                        if (HoldProductCurrencyID == currency.ID)
                        {
                            unitprice = Math.Round(product.CurrencyID == 2 ? Math.Max(holdProductDollarPrice, unitprice) : Double.Parse((Math.Max(holdProductPrice, unitprice)).ToString()), 3);
                            currency = (from aj in data.TBLCURRENCies where aj.ID == productCurrencyID select aj).SingleOrDefault();
                        }
                        else
                        {
                            unitprice = Math.Round(product.CurrencyID == 2 ? Math.Max(holdProductPrice, unitprice * Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString())) : Double.Parse((Math.Max(holdProductPrice, unitprice)).ToString()), 3);
                            currency = (from aj in data.TBLCURRENCies where aj.ID == productCurrencyID select aj).SingleOrDefault();
                        }

                    }
                    Globals.draftStockTempQte[product.PID] = Globals.newQteNb * receiptSwitcherValue;
                }
                double tva = product.HasTVA ? (secondaryPriceDollar * Double.Parse(Properties.Settings.Default.TVAPercentage.ToString()) / 100) : 0;

                double discount = 0;
                if (cboxDiscount.CheckState == CheckState.Unchecked)
                    discount = 0;
                else if (cboxDiscount.CheckState == CheckState.Checked)
                    discount = Math.Round(product.InitPrice == 0 ? 0 : dollar - secondaryPriceDollar,3);
                else if (cboxDiscount.CheckState == CheckState.Indeterminate)
                    discount = Math.Round(product.DiscountPercentage == null ? 0 : Double.Parse((dollar * Double.Parse(product.DiscountPercentage.ToString())).ToString()) / 100,3);
                if (Globals.newQteNb > 0)
                {
                    receipt_details.SelectedRows[0].Cells["QTE"].Value = Globals.newQteNb;
                    receipt_details.SelectedRows[0].Cells["DollarPrice"].Value = cboxDiscount.CheckState == CheckState.Checked ? secondaryPriceDollar : dollar;
                    receipt_details.SelectedRows[0].Cells["UnitPrice"].Value = currency.ID == 1 ? Globals.LBPRounding(unitprice) : unitprice;
                    receipt_details.SelectedRows[0].Cells["TotalPrice"].Value = double.Parse(Globals.newQteNb.ToString()) * (currency.ID == 1 ? Globals.LBPRounding(unitprice) : unitprice);
                    receipt_details.SelectedRows[0].Cells["LBPPrice"].Value = Globals.LBPRounding(cboxDiscount.CheckState == CheckState.Checked ? Int64.Parse(Math.Round(secondaryPriceDollar * Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()), 0).ToString()) : int.Parse(Math.Round(dollar * Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()), 0).ToString()));
                    receipt_details.SelectedRows[0].Cells["TotalLBP"].Value = Globals.LBPRounding(Globals.newQteNb * lbp);
                    receipt_details.SelectedRows[0].Cells["TotalDollar"].Value = double.Parse(Globals.newQteNb.ToString()) * dollar;
                    receipt_details.SelectedRows[0].Cells["TotalDiscount"].Value = double.Parse(Globals.newQteNb.ToString()) * discount;
                    receipt_details.SelectedRows[0].Cells["SecondPrice"].Value = currency.ID == 1 ? Globals.LBPRounding(secondaryPrice) : secondaryPriceDollar;
                    if (Double.Parse(receipt_details.SelectedRows[0].Cells["TotalTVA"].Value.ToString()) != 0)
                        receipt_details.SelectedRows[0].Cells["TotalTVA"].Value = (Double.Parse(Globals.newQteNb.ToString()) * tva).ToString();
                    receipt_details.SelectedRows[0].Cells["Currency"].Value = currency.CurrencyName;
                    receipt_details.SelectedRows[0].Cells["CurrencyID"].Value = currency.ID;
                    tot_quantity.Text = getTotalQTE();
                    tot_net_dollar.Text = getTotalPrice() + " $";
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
                    string pname = row.Cells["PNAME"].Value.ToString();
                    int productCurrency = int.Parse(row.Cells["CurrencyID"].Value.ToString());
                    TBLCURRENCy currency = (from aj in data.TBLCURRENCies where aj.ID == productCurrency select aj).SingleOrDefault();
                    double dollar = Math.Round(productCurrency == 2 ? Double.Parse(row.Cells["DollarPrice"].Value.ToString()) : Double.Parse(row.Cells["LBPPrice"].Value.ToString()) / Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()),3);
                    double secondaryPrice = Double.Parse(row.Cells["SecondPrice"].Value.ToString());
                    double secondaryPriceDollar = Math.Round(productCurrency == 2 ? secondaryPrice : Double.Parse(secondaryPrice.ToString()) / Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()), 3);
                    double tva = data.sp_getProductByName(pname).ToList()[0].HasTVA ? (secondaryPriceDollar * Double.Parse(Properties.Settings.Default.TVAPercentage.ToString()) / 100) : 0;
                    double unitprice = Double.Parse(row.Cells["UnitPrice"].Value.ToString());
                    double discount = 0;
                    if (discountSelection == CheckState.Unchecked)
                    {
                        discount = 0;
                    }
                    else if (discountSelection == CheckState.Checked)
                    {
                        discount = Math.Round(secondaryPrice == 0 ? 0 : (dollar - secondaryPriceDollar) * Double.Parse(row.Cells["QTE"].Value.ToString()),3);
                    }
                    else if (discountSelection == CheckState.Indeterminate)
                    {
                        discount = Math.Round(data.sp_getProductByName(pname).ToList()[0].DiscountPercentage == null ? 0 : Double.Parse((dollar * Double.Parse(data.sp_getProductByName(pname).ToList()[0].DiscountPercentage.ToString())).ToString()) / 100,3);
                    }
                    row.Cells["SecondPrice"].Value = secondaryPrice;
                    row.Cells["TotalDiscount"].Value = discount;
                    if (Double.Parse(row.Cells["TotalTVA"].Value.ToString()) != 0)
                        row.Cells["TotalTVA"].Value = tva;
                    row.Cells["Currency"].Value = currency.CurrencyName;
                    row.Cells["CurrencyID"].Value = currency.ID;
                }
                tot_quantity.Text = getTotalQTE();
                tot_net_dollar.Text = getTotalPrice() + " $";
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
            if (receipt_details.Rows.Count <= 0 || receipt_details.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please Select An Item First!!");
            }
            else
            {
                Globals.newQteNb = 0;
                DeleteForm df = new DeleteForm(int.Parse(receipt_details.SelectedRows[0].Cells["QTE"].Value.ToString()));
                df.ShowDialog();
                string pname = receipt_details.SelectedRows[0].Cells["PNAME"].Value.ToString();
                TBLPRODUCT product = (from aj in data.TBLPRODUCTs where aj.ENABLED == true && aj.PNAME == pname select aj).SingleOrDefault();
                int ExistingRowQTE = (from aj in receipt_details.Rows.Cast<DataGridViewRow>() where aj.Cells["PNAME"].Value.ToString() == pname select int.Parse(aj.Cells["QTE"].Value.ToString())).SingleOrDefault();
                if (Globals.newQteNb != 0)
                {
                    int productCurrencyID = product.CurrencyID;
                    TBLCURRENCy currency = (from aj in data.TBLCURRENCies where aj.ID == productCurrencyID select aj).SingleOrDefault();
                    double dollar = Math.Round(product.CurrencyID == 2 ? product.PRICE.Value : Double.Parse(product.PRICE.Value.ToString()) / Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()),3);
                    double secondaryPrice = product.SecondaryPrice.Value * receiptSwitcherValue;
                    double secondaryPriceDollar = Math.Round(product.CurrencyID == 2 ? secondaryPrice : Double.Parse(secondaryPrice.ToString()) / Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()),3);
                    double unitprice = product.PRICE.Value * receiptSwitcherValue;
                    List<TBLDELIVERY_RECEIPTS_DETAIL> HeldCurrentProductStock = (from aj in data.TBLDELIVERY_RECEIPTS_DETAILs join az in data.TBLDELIVERY_RECEIPTs on aj.RID equals az.ID where aj.PID == product.PID && aj.isInSale == false && az.StatusID >= 2 && az.ReceiptDate.Value.Date <= DateTime.Today.Date && aj.Quantity + (product.QTE <= 0 ? 0 : product.QTE) >= (aj.inStockQuantity + ExistingRowQTE - Globals.newQteNb) orderby aj.dateCreated ascending select aj).ToList();
                    if (ExistingRowQTE - Globals.newQteNb > 0)
                    {

                        if (receiptSwitcherValue == 1)
                        {
                            if (product.HasQuantity == true && ExistingRowQTE + Globals.newQteNb > product.QTE)
                            {
                                if (HeldCurrentProductStock.Count > 0)
                                {
                                    int HoldProductCurrencyID = (from aj in data.TBLDELIVERY_RECEIPTs where aj.ID == HeldCurrentProductStock[0].RID select int.Parse(aj.CurrencyID.ToString())).SingleOrDefault();
                                    double holdProductPrice = Double.Parse(HeldCurrentProductStock[0].SellPrice.ToString()) * receiptSwitcherValue;
                                    double holdProductDollarPrice = Math.Round((HoldProductCurrencyID == 1 ? holdProductPrice / Int64.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()) : holdProductPrice), 3);
                                    double holdProductSecondaryPrice = Double.Parse(HeldCurrentProductStock[0].SecondaryPrice.ToString()) * receiptSwitcherValue;
                                    double holdProductSecondaryPriceDollar = Math.Round((HoldProductCurrencyID == 1 ? holdProductSecondaryPrice / Int64.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()) : holdProductSecondaryPrice), 3);
                                    dollar = Math.Max(holdProductDollarPrice, dollar);
                                    secondaryPriceDollar = dollar == holdProductDollarPrice ? holdProductSecondaryPriceDollar : secondaryPriceDollar;
                                    secondaryPrice = dollar == holdProductDollarPrice ? holdProductSecondaryPrice : secondaryPrice;
                                    productCurrencyID = dollar == holdProductDollarPrice ? HoldProductCurrencyID : productCurrencyID;
                                    if (HoldProductCurrencyID == currency.ID)
                                    {
                                        unitprice = Math.Round(product.CurrencyID == 2 ? Math.Max(holdProductDollarPrice, unitprice) : Double.Parse((Math.Max(holdProductPrice, unitprice)).ToString()), 3);
                                        currency = (from aj in data.TBLCURRENCies where aj.ID == productCurrencyID select aj).SingleOrDefault();
                                    }
                                    else
                                    {
                                        unitprice = Math.Round(product.CurrencyID == 2 ? Math.Max(holdProductPrice, unitprice * Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString())) : Double.Parse((Math.Max(holdProductPrice, unitprice)).ToString()), 3);
                                        currency = (from aj in data.TBLCURRENCies where aj.ID == productCurrencyID select aj).SingleOrDefault();
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("Your Stock in in Negative, This item is out of Stock, Please Check Your Stock Quantity of Product Name : " + pname + " .", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                            }
                            Globals.draftStockTempQte[product.PID] = Globals.newQteNb * receiptSwitcherValue;
                        }
                        else if (receiptSwitcherValue == -1)
                        {
                            if (HeldCurrentProductStock.Count > 0)
                            {
                                int HoldProductCurrencyID = (from aj in data.TBLDELIVERY_RECEIPTs where aj.ID == HeldCurrentProductStock[0].RID select int.Parse(aj.CurrencyID.ToString())).SingleOrDefault();
                                double holdProductPrice = Double.Parse(HeldCurrentProductStock[0].SellPrice.ToString()) * receiptSwitcherValue;
                                double holdProductDollarPrice = Math.Round((HoldProductCurrencyID == 1 ? holdProductPrice / Int64.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()) : holdProductPrice), 3);
                                double holdProductSecondaryPrice = Double.Parse(HeldCurrentProductStock[0].SecondaryPrice.ToString()) * receiptSwitcherValue;
                                double holdProductSecondaryPriceDollar = Math.Round((HoldProductCurrencyID == 1 ? holdProductSecondaryPrice / Int64.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()) : holdProductSecondaryPrice), 3);
                                dollar = Math.Max(holdProductDollarPrice, dollar);
                                secondaryPriceDollar = dollar == holdProductDollarPrice ? holdProductSecondaryPriceDollar : secondaryPriceDollar;
                                secondaryPrice = dollar == holdProductDollarPrice ? holdProductSecondaryPrice : secondaryPrice;
                                productCurrencyID = dollar == holdProductDollarPrice ? HoldProductCurrencyID : productCurrencyID;
                                if (HoldProductCurrencyID == currency.ID)
                                {
                                    unitprice = Math.Round(product.CurrencyID == 2 ? Math.Max(holdProductDollarPrice, unitprice) : Double.Parse((Math.Max(holdProductPrice, unitprice)).ToString()), 3);
                                    currency = (from aj in data.TBLCURRENCies where aj.ID == productCurrencyID select aj).SingleOrDefault();
                                }
                                else
                                {
                                    unitprice = Math.Round(product.CurrencyID == 2 ? Math.Max(holdProductPrice, unitprice * Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString())) : Double.Parse((Math.Max(holdProductPrice, unitprice)).ToString()), 3);
                                    currency = (from aj in data.TBLCURRENCies where aj.ID == productCurrencyID select aj).SingleOrDefault();
                                }

                            }
                            Globals.draftStockTempQte[product.PID] = Globals.newQteNb * receiptSwitcherValue;
                        }
                    }
                    else if (ExistingRowQTE - Globals.newQteNb == 0)
                    {
                        receipt_details.Rows.RemoveAt(receipt_details.SelectedRows[0].Index);
                        Globals.draftStockTempQte[product.PID] = 0;
                    }
                    else
                    {
                        Globals.draftStockTempQte[product.PID] = 0;
                        double discount = 0;

                        if (cboxDiscount.CheckState == CheckState.Unchecked)
                            discount = 0;
                        else if (cboxDiscount.CheckState == CheckState.Checked)
                            discount = Math.Round(product.InitPrice == 0 ? 0 : Double.Parse(receipt_details.SelectedRows[0].Cells["DollarPrice"].Value.ToString()) - secondaryPriceDollar,3);
                        else if (cboxDiscount.CheckState == CheckState.Indeterminate)
                            discount = Math.Round(product.DiscountPercentage == null ? 0 : Double.Parse((Double.Parse(receipt_details.SelectedRows[0].Cells["DollarPrice"].Value.ToString()) * Double.Parse(product.DiscountPercentage.ToString())).ToString()) / 100,3);
                        receipt_details.SelectedRows[0].Cells["QTE"].Value = (int.Parse(receipt_details.SelectedRows[0].Cells["QTE"].Value.ToString()) - Globals.newQteNb).ToString();
                        receipt_details.SelectedRows[0].Cells["UnitPrice"].Value = currency.ID == 1 ? Globals.LBPRounding(unitprice) : unitprice;
                        receipt_details.SelectedRows[0].Cells["TotalPrice"].Value = double.Parse(Globals.newQteNb.ToString()) * (currency.ID == 1 ? Globals.LBPRounding(unitprice) : unitprice);
                        receipt_details.SelectedRows[0].Cells["TotalDollar"].Value = (double.Parse(receipt_details.SelectedRows[0].Cells["QTE"].Value.ToString()) * double.Parse(receipt_details.SelectedRows[0].Cells["DollarPrice"].Value.ToString())).ToString();
                        receipt_details.SelectedRows[0].Cells["TotalLBP"].Value = Globals.LBPRounding((int.Parse(receipt_details.SelectedRows[0].Cells["QTE"].Value.ToString()) * int.Parse(receipt_details.SelectedRows[0].Cells["LBPPrice"].Value.ToString())));
                        receipt_details.SelectedRows[0].Cells["TotalDiscount"].Value = (Double.Parse(receipt_details.SelectedRows[0].Cells["QTE"].Value.ToString()) * discount).ToString();
                        receipt_details.SelectedRows[0].Cells["SecondPrice"].Value = currency.ID == 1 ? Globals.LBPRounding(secondaryPrice) : secondaryPriceDollar;
                        if (Double.Parse(receipt_details.SelectedRows[0].Cells["TotalTVA"].Value.ToString()) != 0)
                            receipt_details.SelectedRows[0].Cells["TotalTVA"].Value = (Double.Parse((Double.Parse(receipt_details.SelectedRows[0].Cells["QTE"].Value.ToString()) * Double.Parse(receipt_details.SelectedRows[0].Cells["SecondPrice"].Value.ToString()) * Double.Parse(Properties.Settings.Default.TVAPercentage.ToString())).ToString()) / 100).ToString();
                        receipt_details.SelectedRows[0].Cells["Currency"].Value = currency.CurrencyName;
                        receipt_details.SelectedRows[0].Cells["CurrencyID"].Value = currency.ID;
                    }
                }
            }
            tot_quantity.Text = getTotalQTE();
            tot_net_dollar.Text = getTotalPrice() + " $";
            tot_discount.Text = getTotalLBP() + " LBP";
            tot_tva.Text = (Double.Parse(getTotalTVA())).ToString() + " $";
            double TotalDiscount = Double.Parse(getTotalDiscount());
            tot_discount.Text = TotalDiscount.ToString() + " $";
            tot_final_price_dolar.Text = getFinalPriceDollar(TotalDiscount).ToString() + " $";
            tot_final_price_lbp.Text = getFinalPriceLBP(TotalDiscount).ToString("#,0;-#,0") + " LBP";
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
                    search_txt.Text = receipt_details.SelectedRows[0].Cells["Barcode"].Value.ToString();
                    add_btn_Click_1(null, null);
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
                            TBLPRODUCT product = (from aj in ax.TBLPRODUCTs where aj.ENABLED == true && aj.BARCODE.Trim().ToLower() == search_txt.Text.Split('|')[0].Trim().ToLower() select aj).SingleOrDefault();
                            if (product == null)
                            {
                                search_txt.Text = "";
                                MessageBox.Show("This Item Not Exist! Try Again!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            if (!Globals.draftStockTempQte.Keys.Contains(product.PID))
                                Globals.draftStockTempQte.Add(product.PID, 0);
                            string pname = product.PNAME;
                            int ExistingRowQTE = (from aj in receipt_details.Rows.Cast<DataGridViewRow>() where aj.Cells["PNAME"].Value.ToString() == pname select int.Parse(aj.Cells["QTE"].Value.ToString())).SingleOrDefault();

                            int productCurrencyID = product.CurrencyID;
                            TBLCURRENCy currency = (from aj in data.TBLCURRENCies where aj.ID == productCurrencyID select aj).SingleOrDefault();
                            double dollar = Math.Round(product.CurrencyID == 2 ? product.PRICE.Value * receiptSwitcherValue : Double.Parse((inputQte * product.PRICE.Value * receiptSwitcherValue).ToString()) / Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()),3);
                            int lbp = int.Parse(Math.Round(dollar * Properties.Settings.Default.dollarLBPPrice, 0).ToString());
                            double secondaryPrice = inputQte * product.SecondaryPrice.Value * receiptSwitcherValue;
                            double secondaryPriceDollar = Math.Round(product.CurrencyID == 2 ? secondaryPrice : Double.Parse(secondaryPrice.ToString()) / Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()),3);
                            double unitprice = product.PRICE.Value * receiptSwitcherValue;
                            List<TBLDELIVERY_RECEIPTS_DETAIL> HeldCurrentProductStock = (from aj in data.TBLDELIVERY_RECEIPTS_DETAILs join az in data.TBLDELIVERY_RECEIPTs on aj.RID equals az.ID where aj.PID == product.PID && aj.isInSale == false && az.StatusID >= 2 && az.ReceiptDate.Value.Date <= DateTime.Today.Date && (aj.Quantity + (product.QTE <= 0 ? 0 : product.QTE) > aj.inStockQuantity + ExistingRowQTE) orderby aj.dateCreated ascending select aj).ToList();

                            if (receiptSwitcherValue == 1)
                            {
                                if (product.HasQuantity == true && ExistingRowQTE + inputQte > product.QTE)
                                {
                                    if (HeldCurrentProductStock.Count > 0)
                                    {
                                        int HoldProductCurrencyID = (from aj in data.TBLDELIVERY_RECEIPTs where aj.ID == HeldCurrentProductStock[0].RID select int.Parse(aj.CurrencyID.ToString())).SingleOrDefault();
                                        double holdProductPrice = Double.Parse(HeldCurrentProductStock[0].SellPrice.ToString()) * receiptSwitcherValue;
                                        double holdProductDollarPrice = Math.Round((HoldProductCurrencyID == 1 ? holdProductPrice / Int64.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()) : holdProductPrice), 3);
                                        double holdProductSecondaryPrice = Double.Parse(HeldCurrentProductStock[0].SecondaryPrice.ToString()) * receiptSwitcherValue;
                                        double holdProductSecondaryPriceDollar = Math.Round((HoldProductCurrencyID == 1 ? holdProductSecondaryPrice / Int64.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()) : holdProductSecondaryPrice), 3);
                                        dollar = Math.Max(holdProductDollarPrice, dollar);
                                        secondaryPriceDollar = dollar == holdProductDollarPrice ? holdProductSecondaryPriceDollar : secondaryPriceDollar;
                                        secondaryPrice = dollar == holdProductDollarPrice ? holdProductSecondaryPrice : secondaryPrice;
                                        productCurrencyID = dollar == holdProductDollarPrice ? HoldProductCurrencyID : productCurrencyID;                  
                                        lbp = int.Parse(Math.Round(dollar * Properties.Settings.Default.dollarLBPPrice, 0).ToString());
                                        if (HoldProductCurrencyID == currency.ID)
                                        {
                                            unitprice = Math.Round(product.CurrencyID == 2 ? Math.Max(holdProductDollarPrice, unitprice) : Double.Parse((Math.Max(holdProductPrice, unitprice)).ToString()), 3);
                                            currency = (from aj in data.TBLCURRENCies where aj.ID == productCurrencyID select aj).SingleOrDefault();
                                        }
                                        else
                                        {
                                            unitprice = Math.Round(product.CurrencyID == 2 ? Math.Max(holdProductPrice, unitprice * Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString())) : Double.Parse((Math.Max(holdProductPrice, unitprice)).ToString()), 3);
                                            currency = (from aj in data.TBLCURRENCies where aj.ID == productCurrencyID select aj).SingleOrDefault();
                                        }
                                        
                                    }
                                    else
                                    {
                                        MessageBox.Show("Your Stock in in Negative, This item is out of Stock, Please Check Your Stock Quantity of Product Name : " + pname + " .", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        return;
                                    }
                                }
                                Globals.draftStockTempQte[product.PID] = (ExistingRowQTE + inputQte) * receiptSwitcherValue;
                            }
                            else if (receiptSwitcherValue == -1)
                            {
                                if (HeldCurrentProductStock.Count > 0)
                                {
                                    int HoldProductCurrencyID = (from aj in data.TBLDELIVERY_RECEIPTs where aj.ID == HeldCurrentProductStock[0].RID select int.Parse(aj.CurrencyID.ToString())).SingleOrDefault();
                                    double holdProductPrice = Double.Parse(HeldCurrentProductStock[0].SellPrice.ToString()) * receiptSwitcherValue;
                                    double holdProductDollarPrice = Math.Round((HoldProductCurrencyID == 1 ? holdProductPrice / Int64.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()) : holdProductPrice), 3);
                                    double holdProductSecondaryPrice = Double.Parse(HeldCurrentProductStock[0].SecondaryPrice.ToString()) * receiptSwitcherValue;
                                    double holdProductSecondaryPriceDollar = Math.Round((HoldProductCurrencyID == 1 ? holdProductSecondaryPrice / Int64.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()) : holdProductSecondaryPrice), 3);
                                    dollar = Math.Min(holdProductDollarPrice, dollar);
                                    secondaryPriceDollar = dollar == holdProductDollarPrice ? holdProductSecondaryPriceDollar : secondaryPriceDollar;
                                    secondaryPrice = dollar == holdProductDollarPrice ? holdProductSecondaryPrice : secondaryPrice;
                                    productCurrencyID = dollar == holdProductDollarPrice ? HoldProductCurrencyID : productCurrencyID;
                                    lbp = int.Parse(Math.Round(dollar * Properties.Settings.Default.dollarLBPPrice, 0).ToString());
                                    if (HoldProductCurrencyID == currency.ID)
                                    {
                                        unitprice = Math.Round(product.CurrencyID == 2 ? Math.Min(holdProductDollarPrice, unitprice) : Double.Parse((Math.Min(holdProductPrice, unitprice)).ToString()), 3);
                                        currency = (from aj in data.TBLCURRENCies where aj.ID == productCurrencyID select aj).SingleOrDefault();
                                    }
                                    else
                                    {
                                        unitprice = Math.Round(product.CurrencyID == 2 ? Math.Min(holdProductPrice, unitprice * Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString())) : Double.Parse((Math.Min(holdProductPrice, unitprice)).ToString()), 3);
                                        currency = (from aj in data.TBLCURRENCies where aj.ID == productCurrencyID select aj).SingleOrDefault();
                                    }
                                    
                                }
                                Globals.draftStockTempQte[product.PID] = (ExistingRowQTE + inputQte) * receiptSwitcherValue;
                            }

                            string barcode = product.BARCODE;
                            string supplier = data.sp_getSupplierByID(product.SID.Value).ToList()[0].SNAME;
                            double tva = product.HasTVA ? (inputQte * secondaryPriceDollar * Double.Parse(Properties.Settings.Default.TVAPercentage.ToString()) / 100) : 0;

                            double discount = 0;
                            if (cboxDiscount.CheckState == CheckState.Unchecked)
                                discount = 0;
                            else if (cboxDiscount.CheckState == CheckState.Checked)
                                discount = Math.Round(product.InitPrice == 0 ? 0 : inputQte * (dollar - secondaryPriceDollar),3);
                            else if (cboxDiscount.CheckState == CheckState.Indeterminate)
                                discount = Math.Round(product.DiscountPercentage == null ? 0 : inputQte * Double.Parse((dollar * Double.Parse(product.DiscountPercentage.ToString())).ToString()) / 100,3);
                            bool exist = false;
                            foreach (DataGridViewRow row in receipt_details.Rows)
                            {
                                if (row.Cells["PNAME"].Value.Equals(pname))
                                {
                                    exist = true;
                                    row.Cells["SupplierName"].Value = supplier;
                                    row.Cells["QTE"].Value = int.Parse(row.Cells["QTE"].Value.ToString()) + inputQte;
                                    row.Cells["DollarPrice"].Value = cboxDiscount.CheckState == CheckState.Checked ? secondaryPriceDollar : dollar;
                                    row.Cells["UnitPrice"].Value = currency.ID == 1 ? Globals.LBPRounding(unitprice) : unitprice;
                                    row.Cells["TotalPrice"].Value = double.Parse(row.Cells["QTE"].Value.ToString()) * (currency.ID == 1 ? Globals.LBPRounding(unitprice) : unitprice);
                                    row.Cells["LBPPrice"].Value = Globals.LBPRounding(cboxDiscount.CheckState == CheckState.Checked ? Int64.Parse((Math.Round(secondaryPriceDollar * Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()), 0)).ToString()) : lbp);
                                    row.Cells["TotalLBP"].Value = Globals.LBPRounding(int.Parse(Math.Round((double.Parse(row.Cells["QTE"].Value.ToString()) * double.Parse(lbp.ToString())), 0).ToString()));
                                    row.Cells["TotalDollar"].Value = double.Parse(row.Cells["QTE"].Value.ToString()) * dollar;
                                    if (Double.Parse(row.Cells["TotalTVA"].Value.ToString()) != 0)
                                        row.Cells["TotalTVA"].Value = (Double.Parse(row.Cells["QTE"].Value.ToString()) * tva).ToString();
                                    row.Cells["TotalDiscount"].Value = int.Parse(row.Cells["QTE"].Value.ToString()) * discount;
                                    row.Cells["SecondPrice"].Value = currency.ID == 1 ? Globals.LBPRounding(secondaryPrice) : secondaryPriceDollar ;
                                    row.Cells["Currency"].Value = currency.CurrencyName;
                                    row.Cells["CurrencyID"].Value = currency.ID;
                                    tot_quantity.Text = getTotalQTE();
                                    tot_net_dollar.Text = getTotalPrice() + " $";
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
                                receipt_details.Rows.Add(barcode, pname, supplier, inputQte, currency.ID == 1 ? Globals.LBPRounding(unitprice) : unitprice, currency.ID == 1 ? Globals.LBPRounding(unitprice) : unitprice, currency.ID == 1 ? Globals.LBPRounding(secondaryPrice) : secondaryPrice, currency.CurrencyName, dollar, Globals.LBPRounding(lbp), Globals.LBPRounding(lbp), dollar, tva, discount, currency.ID);
                                tot_quantity.Text = getTotalQTE();
                                tot_net_dollar.Text = getTotalPrice() + " $";
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
            ProcessStartInfo ps = new ProcessStartInfo()
            {
                FileName = "osk"
            };
            Process process = new Process { StartInfo = ps };
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
                            maxrid = int.Parse(data.sp_getLastReceiptID().ToList()[0].MAX_RID.ToString());
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
                    if (receipt == null)
                    {
                        newReceipt.RBARCODE = newBarcode;
                        newReceipt.RITEM_NB = int.Parse(tot_quantity.Text);
                        newReceipt.TOTAL_AMOUNTDollar = getFinalPriceDollar(TotalDiscount);
                        newReceipt.TOTAL_AMOUNTLBP = int.Parse(getFinalPriceLBP(TotalDiscount).ToString());
                        newReceipt.RDATE = DateTime.Now;
                        newReceipt.isHold = true;
                        newReceipt.TotalTVA = Double.Parse(getTotalTVA());
                        newReceipt.TotalDiscount = TotalDiscount;
                        newReceipt.EmpCardNumber = cardNumber;
                        newReceipt.ReceiptTypeID = 4;
                        newReceipt.UserID = 0;
                        cnx.TBLRECEIPTs.InsertOnSubmit(newReceipt);
                        cnx.SubmitChanges();
                    }
                    else
                    {
                        var r = (from aj in cnx.TBLRECEIPTs where aj.RID == receipt.RID select aj).Single();
                        r.RITEM_NB = int.Parse(tot_quantity.Text);
                        r.TOTAL_AMOUNTDollar = getFinalPriceDollar(TotalDiscount);
                        r.TOTAL_AMOUNTLBP = int.Parse(getFinalPriceLBP(TotalDiscount).ToString());
                        r.TotalTVA = Double.Parse(getTotalTVA());
                        r.isHold = true;
                        r.TotalDiscount = TotalDiscount;
                        r.EmpCardNumber = cardNumber;
                        r.ReceiptTypeID = 4;
                        r.UserID = 0;
                        receiptType = 4;
                        newReceipt = r;
                    }
                    foreach (DataGridViewRow row in receipt_details.Rows)
                    {
                        var product = cnx.sp_getProductByName(row.Cells["PNAME"].Value.ToString()).ToList();
                        var newHoldDetails = new TBLHOLDDETAIL();
                        newHoldDetails.RID = newReceipt.RID;
                        newHoldDetails.PID = product[0].PID;
                        newHoldDetails.QTE = int.Parse(row.Cells["QTE"].Value.ToString());
                        newHoldDetails.PRICE_Dollar = Convert.ToDouble(row.Cells["DollarPrice"].Value.ToString());
                        newHoldDetails.TOTAL_PRICEDollar = Convert.ToDouble(row.Cells["TotalDollar"].Value.ToString());
                        newHoldDetails.PRICE_LBP = int.Parse(row.Cells["LBPPrice"].Value.ToString());
                        newHoldDetails.TOTAL_PRICELBP = int.Parse(row.Cells["TotalLBP"].Value.ToString());
                        newHoldDetails.TotalTVA = Double.Parse(row.Cells["TotalTVA"].Value.ToString());
                        newHoldDetails.TotalDiscount = TotalDiscount;
                        newHoldDetails.CurrencyID = int.Parse(row.Cells["CurrencyID"].Value.ToString());
                        cnx.TBLHOLDDETAILs.InsertOnSubmit(newHoldDetails);

                    }
                    cnx.SubmitChanges();
                    receiptType = 4;
                    if (!Properties.Settings.Default.printInCheckout)
                    {
                        int receiptTypeID = Properties.Settings.Default.ReceiptType;
                        int receiptNumber = receiptType;
                        string totalDiscount = getTotalDiscount();
                        string totalTVA = getTotalTVA();
                        string finalPriceLBP = getFinalPriceLBP(Double.Parse(getTotalDiscount())).ToString();
                        string finalPriceDollar = (Math.Round(getFinalPriceLBP(Double.Parse(getTotalDiscount())) / Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()), 2)).ToString();
                        Thread tr = new Thread(() =>
                        {
                            //DirectReceiptReportViewer drrv = new DirectReceiptReportViewer(Properties.Settings.Default.ReceiptType, receiptType, getTotalDiscount(), getTotalTVA(), getFinalPriceLBP(Double.Parse(getTotalDiscount())).ToString(), getFinalPriceDollar(Double.Parse(getTotalDiscount())).ToString());
                            DirectReceiptReportViewer drrv = new DirectReceiptReportViewer(receiptTypeID, receiptNumber, totalDiscount, totalTVA, finalPriceLBP, finalPriceDollar);
                            drrv.receiptID = newReceipt.RID;
                            drrv.Print();
                            //drrv.ShowDialog();
                            Thread.CurrentThread.Abort();
                        });
                        tr.Start();
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
            else if (receiptType == 6)
            {
                MessageBox.Show("Finish The Junk Receipt First Or Press The New Receipt Button In The Top.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void switchReceiptType(int type)
        {
            int value = -1;
            if (type == 1)
            {
                lblReceiptType.Text = "Sale Receipt";
                lblReceiptType.BackColor = Color.FromArgb(0, 118, 125);
                lblReceiptType.ForeColor = Color.White;
                receiptType = type;
                receiptSwitcherValue = 1;
            }
            else if (type == 2)
            {
                if (MessageBox.Show("You Are Switching To Return Receipt Type, Are Your Sure ??", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    lblReceiptType.Text = "Return Receipt";
                    lblReceiptType.BackColor = Color.Red;
                    lblReceiptType.ForeColor = Color.White;
                    receiptType = type;
                    receiptSwitcherValue = -1;
                }
                else
                    return;
            }
            else if (type == 6)
            {
                if (MessageBox.Show("You Are Switching To Junk Receipt Type, Are Your Sure ??", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    lblReceiptType.Text = "Junk Receipt";
                    lblReceiptType.BackColor = Color.Yellow;
                    lblReceiptType.ForeColor = Color.FromArgb(0, 63, 63);
                    receiptType = type;
                    value = 1;
                    receiptSwitcherValue = 1;
                }
                else
                    return;
            }

            foreach (DataGridViewRow row in receipt_details.Rows)
            {
                string pname = row.Cells["PNAME"].Value.ToString();

                TBLPRODUCT product = (from aj in data.TBLPRODUCTs where aj.ENABLED == true && aj.PNAME == pname select aj).SingleOrDefault();

                int ExistingRowQTE = (from aj in receipt_details.Rows.Cast<DataGridViewRow>() where aj.Cells["PNAME"].Value.ToString() == pname select int.Parse(aj.Cells["QTE"].Value.ToString())).SingleOrDefault();
                if (ExistingRowQTE > product.QTE && product.QTE >= 0 && receiptSwitcherValue == 1)
                {
                    MessageBox.Show("Your Stock in in Negative, This item is out of Stock, Please Check Your Stock Quantity of Product Name : " + pname + " .", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lblReceiptType.Text = "Return Receipt";
                    lblReceiptType.BackColor = Color.Red;
                    lblReceiptType.ForeColor = Color.White;
                    receiptType = 2;
                    receiptSwitcherValue = -1;
                    return;
                }
                row.Cells["QTE"].Value = Int32.Parse(row.Cells["QTE"].Value.ToString());
                row.Cells["TotalLBP"].Value = Int32.Parse(row.Cells["TotalLBP"].Value.ToString()) * value;
                row.Cells["TotalDollar"].Value = Double.Parse(row.Cells["TotalDollar"].Value.ToString()) * value;
                row.Cells["TotalTVA"].Value = Double.Parse(row.Cells["TotalTVA"].Value.ToString()) * value;
                row.Cells["TotalDiscount"].Value = Double.Parse(row.Cells["TotalDiscount"].Value.ToString()) * value;
                row.Cells["SecondPrice"].Value = Double.Parse(row.Cells["SecondPrice"].Value.ToString()) * value;
                row.Cells["DollarPrice"].Value = Double.Parse(row.Cells["DollarPrice"].Value.ToString()) * value;
                row.Cells["LBPPrice"].Value = Int32.Parse(row.Cells["LBPPrice"].Value.ToString()) * value;
                row.Cells["UnitPrice"].Value = Double.Parse(row.Cells["UnitPrice"].Value.ToString()) * value;
                row.Cells["TotalPrice"].Value = Double.Parse(row.Cells["TotalPrice"].Value.ToString()) * value;

                foreach (var key in Globals.draftStockTempQte.Keys.ToList())
                {
                    Globals.draftStockTempQte[key] *= value;
                }

                tot_quantity.Text = getTotalQTE();
                tot_net_dollar.Text = getTotalPrice() + " $";
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
            //    updateDiscountPrices(int.Parse(value.ToString()));
            //}
            //else if (value.ToString() == "2")
            //{
            //    updateDiscountPrices(int.Parse(value.ToString()));
            //    lblDiscount.Text = "Discount";
            //    cardNumber = "";
            //}
            //else if (value.ToString() == "0")
            //{
            //    updateDiscountPrices(int.Parse(value.ToString()));
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
            //if (time >= 2 && search_txt.Text != "")
            //{
            //    int num;
            //    bool isDigit = int.TryParse(search_txt.Text, out num);
            //    if (!isDigit)
            //        return;
            //    if (num < 100 && num > 0)
            //    {
            //        inputQte = num;
            //        search_txt.Text = "|" + search_txt.Text;
            //        Console.WriteLine(inputQte.ToString());
            //    }
            //    else
            //    {
            //        inputQte = 1;
            //        Console.WriteLine(inputQte.ToString());
            //    }
            //    time = 0;
            //    timerRefreshInputQte.Stop();
            //}
            //else
            //{
            //    time++;
            //}
        }

        private void cboxDiscount_CheckedChanged(object sender, EventArgs e)
        {
            CheckState value = cboxDiscount.CheckState;
            if (value == CheckState.Checked)
            {
                updateDiscountPrices(value);
            }
            else if (value == CheckState.Unchecked)
            {
                updateDiscountPrices(value);
                lblDiscount.Text = "Discount";
                cardNumber = "";
            }

            ActiveControl = search_txt;
        }

        private void btnExtCheckOut_Click(object sender, EventArgs e)
        {

            double TotalDiscount = 0, customerDollar = 0, customerLBP = 0, restDollar = 0, restLBP = 0;

            if (cboxDiscount.CheckState == CheckState.Checked)
                TotalDiscount = Double.Parse(getTotalDiscount());

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
                            newReceipt.RITEM_NB = int.Parse(tot_quantity.Text);
                            newReceipt.TOTAL_AMOUNTDollar = getFinalPriceDollar(TotalDiscount);
                            newReceipt.TOTAL_AMOUNTLBP = int.Parse(getFinalPriceLBP(TotalDiscount).ToString());
                            newReceipt.RDATE = DateTime.Now;
                            newReceipt.TotalTVA = double.Parse(getTotalTVA());
                            newReceipt.TotalDiscount = TotalDiscount;
                            newReceipt.ReceiptTypeID = receiptType;
                            newReceipt.customerLBP = customerLBP;
                            newReceipt.customerDollar = customerDollar;
                            newReceipt.restLBP = restLBP;
                            newReceipt.restDollar = restDollar;
                            newReceipt.EmpCardNumber = "";
                            newReceipt.UserID = 0;
                            cnx.TBLRECEIPTs.InsertOnSubmit(newReceipt);
                            cnx.SubmitChanges();
                        }
                        else
                        {
                            var r = (from aj in cnx.TBLRECEIPTs where aj.RID == receipt.RID select aj).Single();
                            r.RITEM_NB = int.Parse(tot_quantity.Text);
                            r.TOTAL_AMOUNTDollar = Math.Round(getFinalPriceDollar(TotalDiscount),3);
                            r.TOTAL_AMOUNTLBP = int.Parse(getFinalPriceLBP(TotalDiscount).ToString());
                            r.TotalTVA = Math.Round(double.Parse(getTotalTVA()),3);
                            r.RDATE = DateTime.Now;
                            r.isHold = false;
                            r.TotalDiscount = Math.Round(TotalDiscount,3);
                            r.ReceiptTypeID = receiptType;
                            r.EmpCardNumber = "";
                            r.UserID = 0;
                            newReceipt = r;
                        }
                        foreach (DataGridViewRow row in receipt_details.Rows)
                        {
                            try
                            {
                                var product = cnx.sp_getProductByName(row.Cells["PNAME"].Value.ToString()).ToList();
                                if (product[0].HasQuantity == true)
                                {

                                    TBLPRODUCT prod = (from aj in cnx.TBLPRODUCTs
                                                       where aj.PID == product[0].PID && aj.ENABLED == true
                                                       select aj).Single();

                                    int currentQuantity = prod.QTE;
                                    int inStockValue = 0;
                                    inStockValue = Globals.draftStockTempQte.TryGetValue(prod.PID, out inStockValue) ? inStockValue : 0;
                                    int newQuantity = currentQuantity - inStockValue;
                                    int DeliveryInNewQuantity = currentQuantity <= 0 ? inStockValue : (newQuantity > 0 ? 0 : Math.Abs(newQuantity));

                                    if (newQuantity < 0)
                                    {

                                        List<TBLDELIVERY_RECEIPTS_DETAIL> drd = (from aj in cnx.TBLDELIVERY_RECEIPTS_DETAILs join az in cnx.TBLDELIVERY_RECEIPTs on aj.RID equals az.ID where aj.PID == prod.PID && aj.isInSale == false && az.StatusID >= 2 && aj.Quantity > aj.inStockQuantity orderby aj.dateCreated ascending select aj).ToList();
                                        TBLDELIVERY_RECEIPT dReceipt = (from aj in cnx.TBLDELIVERY_RECEIPTs where aj.ID == drd[0].RID select aj).Single();

                                        if (dReceipt.StatusID >= 4)
                                        {
                                            drd[0].isInSale = true;
                                            drd[0].inStockQuantity = drd[0].inStockQuantity + inStockValue;
                                            prod.QTE = int.Parse((drd[0].Quantity - inStockValue).ToString());
                                            prod.CurrencyID = int.Parse(dReceipt.CurrencyID.ToString());
                                            prod.HasQuantity = !drd[0].HasExpDate;
                                            prod.SecondaryPrice = drd[0].SecondaryPrice;
                                            prod.PRICE = drd[0].SellPrice;
                                            prod.InitPrice = drd[0].Cost;
                                            prod.HasExpiredDate = drd[0].HasExpDate ? 1 : 0;
                                            prod.HasDiscount = drd[0].HasDiscount;
                                            prod.DiscountPercentage = drd[0].Discount;
                                            prod.HasTVA = drd[0].HasTVA;

                                            if (drd[0].HasExpDate)
                                            {
                                                TBLEXPIREDDATE exp = new TBLEXPIREDDATE();
                                                exp.PID = drd[0].PID;
                                                exp.Qte = prod.QTE;
                                                exp.ExpiredDate = drd[0].ExpDate;
                                                exp.dateCreated = DateTime.Now;
                                                cnx.TBLEXPIREDDATEs.InsertOnSubmit(exp);
                                            }
                                        }
                                        else
                                        {
                                            drd[0].isInSale = false;
                                            drd[0].inStockQuantity = drd[0].inStockQuantity + DeliveryInNewQuantity;
                                            prod.QTE = newQuantity;
                                        }
                                    }
                                    else
                                    {
                                        prod.QTE = newQuantity;
                                    }
                                }
                                else if (product[0].HasExpiredDate == 1)
                                {

                                    List<TBLEXPIREDDATE> ExpiredDateList = (from aj in cnx.TBLEXPIREDDATEs where aj.PID == product[0].PID && aj.ExpiredDate > DateTime.Today select aj).ToList();
                                    int totalQuantity = (from aj in ExpiredDateList where aj.ExpiredDate > DateTime.Today select aj.Qte).Sum(x => int.Parse(x.ToString()));
                                    //if (totalQuantity < int.Parse(row.Cells["QTE"].Value.ToString()))
                                    //{
                                    //    MessageBox.Show("You Have " + totalQuantity + " Of Product Name : " + product[0].PNAME + "\nPlease Check Your Products !!");
                                    //    search_txt.Text = "";
                                    //    ActiveControl = search_txt;
                                    //    return;
                                    //}
                                    if (totalQuantity == int.Parse(row.Cells["QTE"].Value.ToString()))
                                    {
                                        TBLEXPIREDDATE minExpDate = (from aj in ExpiredDateList orderby aj.ExpiredDate ascending select aj).First();
                                        TBLPRODUCT prod = (from aj in cnx.TBLPRODUCTs
                                                           where aj.PID == product[0].PID && aj.ENABLED == true
                                                           select aj).Single();
                                        prod.QTE = 0;
                                        cnx.TBLEXPIREDDATEs.DeleteOnSubmit(minExpDate);
                                        if (prod.QTE < 0)
                                        {

                                            List<TBLDELIVERY_RECEIPTS_DETAIL> drd = (from aj in cnx.TBLDELIVERY_RECEIPTS_DETAILs join az in cnx.TBLDELIVERY_RECEIPTs on aj.RID equals az.ID where aj.PID == prod.PID && aj.isInSale == false && az.StatusID >= 2 && aj.Quantity > aj.inStockQuantity orderby aj.dateCreated ascending select aj).ToList();
                                            TBLDELIVERY_RECEIPT dReceipt = (from aj in cnx.TBLDELIVERY_RECEIPTs where aj.ID == drd[0].RID select aj).Single();

                                            if (dReceipt.StatusID >= 4)
                                            {
                                                drd[0].isInSale = true;
                                                prod.QTE = int.Parse((drd[0].Quantity - drd[0].inStockQuantity).ToString());
                                                prod.CurrencyID = int.Parse(dReceipt.CurrencyID.ToString());
                                                prod.HasQuantity = !drd[0].HasExpDate;
                                                prod.SecondaryPrice = drd[0].SecondaryPrice;
                                                prod.PRICE = drd[0].SellPrice;
                                                prod.InitPrice = drd[0].Cost;
                                                prod.HasExpiredDate = drd[0].HasExpDate ? 1 : 0;
                                                prod.HasDiscount = drd[0].HasDiscount;
                                                prod.DiscountPercentage = drd[0].Discount;
                                                prod.HasTVA = drd[0].HasTVA;

                                                if (drd[0].HasExpDate)
                                                {
                                                    TBLEXPIREDDATE exp = new TBLEXPIREDDATE();
                                                    exp.PID = drd[0].PID;
                                                    exp.Qte = prod.QTE;
                                                    exp.ExpiredDate = drd[0].ExpDate;
                                                    exp.dateCreated = DateTime.Now;
                                                    cnx.TBLEXPIREDDATEs.InsertOnSubmit(exp);
                                                }
                                            }
                                            else
                                            {
                                                drd[0].isInSale = false;
                                                prod.QTE = int.Parse((drd[0].Quantity - drd[0].inStockQuantity).ToString());
                                            }
                                        }

                                    }
                                    else
                                    {
                                        TBLPRODUCT prod = (from aj in cnx.TBLPRODUCTs
                                                           where aj.PID == product[0].PID && aj.ENABLED == true
                                                           select aj).Single();
                                        prod.QTE = (from aj in ExpiredDateList select aj.Qte).Sum(x => int.Parse(x.ToString()));

                                        int tmpqte = prod.QTE;
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
                                        if (tmpqte < 0)
                                        {
                                            List<TBLDELIVERY_RECEIPTS_DETAIL> drd = (from aj in cnx.TBLDELIVERY_RECEIPTS_DETAILs join az in cnx.TBLDELIVERY_RECEIPTs on aj.RID equals az.ID where aj.PID == prod.PID && aj.isInSale == false && az.StatusID >= 2 && aj.Quantity > aj.inStockQuantity orderby aj.dateCreated ascending select aj).ToList();
                                            TBLDELIVERY_RECEIPT dReceipt = (from aj in cnx.TBLDELIVERY_RECEIPTs where aj.ID == drd[0].RID select aj).Single();

                                            if (dReceipt.StatusID >= 4)
                                            {
                                                drd[0].isInSale = true;
                                                prod.QTE = int.Parse((drd[0].Quantity - drd[0].inStockQuantity).ToString());
                                                prod.CurrencyID = int.Parse(dReceipt.CurrencyID.ToString());
                                                prod.HasQuantity = !drd[0].HasExpDate;
                                                prod.SecondaryPrice = drd[0].SecondaryPrice;
                                                prod.PRICE = drd[0].SellPrice;
                                                prod.InitPrice = drd[0].Cost;
                                                prod.HasExpiredDate = drd[0].HasExpDate ? 1 : 0;
                                                prod.HasDiscount = drd[0].HasDiscount;
                                                prod.DiscountPercentage = drd[0].Discount;
                                                prod.HasTVA = drd[0].HasTVA;

                                                if (drd[0].HasExpDate)
                                                {
                                                    TBLEXPIREDDATE exp = new TBLEXPIREDDATE();
                                                    exp.PID = drd[0].PID;
                                                    exp.Qte = prod.QTE;
                                                    exp.ExpiredDate = drd[0].ExpDate;
                                                    exp.dateCreated = DateTime.Now;
                                                    cnx.TBLEXPIREDDATEs.InsertOnSubmit(exp);
                                                }
                                            }
                                            else
                                            {
                                                drd[0].isInSale = false;
                                                prod.QTE = int.Parse((drd[0].Quantity - drd[0].inStockQuantity).ToString());
                                            }
                                        }
                                    }
                                }

                                var newReceiptDetails = new TBLRECEIPTS_DETAIL();
                                newReceiptDetails.RID = newReceipt.RID;
                                newReceiptDetails.PID = product[0].PID;
                                newReceiptDetails.QTE = Convert.ToInt32(row.Cells["QTE"].Value.ToString());
                                newReceiptDetails.PRICE_Dollar = Math.Round(double.Parse(row.Cells["DollarPrice"].Value.ToString()), 3);
                                newReceiptDetails.TOTAL_PRICEDollar = Math.Round(double.Parse(row.Cells["TotalDollar"].Value.ToString()), 3);
                                try
                                {
                                    newReceiptDetails.PRICE_LBP = Convert.ToInt32(row.Cells["LBPPrice"].Value.ToString());
                                }
                                catch
                                {
                                    newReceiptDetails.PRICE_LBP = 0;
                                }
                                try
                                {
                                    newReceiptDetails.TOTAL_PRICELBP = Convert.ToInt32(row.Cells["TotalLBP"].Value.ToString());
                                }
                                catch
                                {
                                    newReceiptDetails.TOTAL_PRICELBP = 0;
                                }
                                newReceiptDetails.TotalDiscount = Math.Round(double.Parse(row.Cells["TotalDiscount"].Value.ToString()), 3);
                                newReceiptDetails.CurrencyID = Convert.ToInt32(row.Cells["CurrencyID"].Value.ToString());
                                if (product[0].HasTVA)
                                    newReceiptDetails.TotalTVA = Double.Parse(newReceiptDetails.TOTAL_PRICEDollar.ToString()) * Double.Parse(Properties.Settings.Default.TVAPercentage.ToString()) / 100;
                                else
                                    newReceiptDetails.TotalTVA = 0;
                                cnx.TBLRECEIPTS_DETAILs.InsertOnSubmit(newReceiptDetails);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("An Error Occured When Adding Receipt, Please Call Support !!\n" + ex.Message + "\n" + ex.Message);
                            }
                        }
                        cnx.SubmitChanges();
                        if (!Properties.Settings.Default.printInCheckout)
                        {
                            int receiptTypeID = Properties.Settings.Default.ReceiptType;
                            int receiptNumber = receiptType;
                            string totalDiscount = getTotalDiscount();
                            string totalTVA = getTotalTVA();
                            string finalPriceLBP = getFinalPriceLBP(Double.Parse(getTotalDiscount())).ToString();
                            string finalPriceDollar = (Math.Round(getFinalPriceLBP(Double.Parse(getTotalDiscount())) / Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()), 2)).ToString();
                            Thread tr = new Thread(() =>
                            {
                                //DirectReceiptReportViewer drrv = new DirectReceiptReportViewer(Properties.Settings.Default.ReceiptType, receiptType, getTotalDiscount(), getTotalTVA(), getFinalPriceLBP(Double.Parse(getTotalDiscount())).ToString(), getFinalPriceDollar(Double.Parse(getTotalDiscount())).ToString());
                                DirectReceiptReportViewer drrv = new DirectReceiptReportViewer(receiptTypeID, receiptNumber, totalDiscount, totalTVA, finalPriceLBP, finalPriceDollar);
                                drrv.receiptID = newReceipt.RID;
                                drrv.Print();
                                //drrv.ShowDialog();
                                Thread.CurrentThread.Abort();
                            });
                            tr.Start();
                        }
                        receipt_details.Rows.Clear();
                        tot_discount.Text = "0" + " $";
                        tot_net_dollar.Text = "0" + " $";
                        tot_quantity.Text = "0";
                        tot_tva.Text = "0" + " $";
                        tot_final_price_dolar.Text = "0" + " $";
                        tot_final_price_lbp.Text = "0" + " LBP";
                        cboxDiscount.CheckState = CheckState.Unchecked;
                        lblDiscount.Text = "Employee Discount";
                        Globals.draftStockTempQte.Clear();
                        cardNumber = "";
                        Properties.Settings.Default.BuyDollarLBPPrice = Properties.Settings.Default.dollarLBPPrice;
                        Properties.Settings.Default.dollarLBPPrice = Properties.Settings.Default.dollarLBPPrice;
                        Properties.Settings.Default.Save();
                        try
                        {
                            NewReceiptNumber = int.Parse(cnx.sp_getLastReceiptID().ToList()[0].MAX_RID.ToString()) + 1;
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

        private void btnJunk_Click(object sender, EventArgs e)
        {
            if (receiptType != 1)
            {
                switchReceiptType(1);
            }
            switchReceiptType(6);
        }
    }

    
}
