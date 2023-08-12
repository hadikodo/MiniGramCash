using Microsoft.Reporting.WinForms;
using MiniGram.Classes;
using MiniGram.LINQ;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGram.Forms
{
    public partial class DirectReceiptReportViewer : Form
    {
        private MiniGramDBDataContext data = new MiniGramDBDataContext(Globals.ConnectionString);
        public int receiptID;
        protected int sizeType;
        protected int typeID;
        protected String type, TotalDiscount, TotalTVA, FinalLBPPrice, FinalDollarPrice;
        protected int? customerID;

        public DirectReceiptReportViewer(int sizeType, int ReceiptType, String TotalDiscount, String TotalTVA, String FinalLBPPrice, String FinalDollarPrice)
        {
            this.sizeType = sizeType;
            this.TotalDiscount = TotalDiscount;
            this.TotalTVA = TotalTVA;
            this.FinalLBPPrice = FinalLBPPrice;
            this.FinalDollarPrice = FinalDollarPrice;
            this.typeID = ReceiptType;
            this.type = (from aj in data.TBLRECEIPTTYPEs where aj.ID == ReceiptType select aj.TypeName).ToList()[0];
            InitializeComponent();
        }

        private void Print()
        {
            if (typeID == 1 || typeID == 2 || typeID == 4)
            {
                customerID = (from aj in data.TBLRECEIPTs where aj.RID == receiptID select aj.CustomerID).SingleOrDefault();
                TBLCUSTOMER customer = new TBLCUSTOMER();
                customer.FullName = "";
                if(customerID!= null)
                    customer = (from aj in data.TBLCUSTOMERs where aj.ID == customerID select aj).SingleOrDefault();

                if (sizeType == 1)
                {

                    sp_selectReceiptsDetailsResultBindingSource.DataSource = data.sp_selectReceiptsDetails(receiptID).ToList();
                    ReportParameterCollection parameters = new ReportParameterCollection();
                    parameters.Add(new ReportParameter("TotalDiscount", TotalDiscount));
                    parameters.Add(new ReportParameter("TotalTVA", TotalTVA));
                    parameters.Add(new ReportParameter("FinalLBPPrice", FinalLBPPrice));
                    parameters.Add(new ReportParameter("FinalDollarPrice", FinalDollarPrice));
                    parameters.Add(new ReportParameter("ReceiptType", type));
                    parameters.Add(new ReportParameter("CustomerName", customer.FullName));
                    reportViewerA4.LocalReport.SetParameters(parameters);
                    this.reportViewerA4.RefreshReport();
                    DirectPrintClass dpc = new DirectPrintClass();
                    dpc.Run(reportViewerA4.LocalReport);

                }
                else if (sizeType == 2)
                {
                    spselectReceiptsDetailsResultBindingSource.DataSource = data.sp_selectReceiptsDetails(receiptID).ToList();
                    ReportParameterCollection parameters = new ReportParameterCollection();
                    parameters.Add(new ReportParameter("TotalDiscount", TotalDiscount));
                    parameters.Add(new ReportParameter("TotalTVA", TotalTVA));
                    parameters.Add(new ReportParameter("FinalLBPPrice", FinalLBPPrice));
                    parameters.Add(new ReportParameter("FinalDollarPrice", FinalDollarPrice));
                    parameters.Add(new ReportParameter("ReceiptType", type));
                    parameters.Add(new ReportParameter("CustomerName", customer.FullName));
                    reportViewerMini.LocalReport.SetParameters(parameters);
                    this.reportViewerMini.RefreshReport();
                    DirectPrintClassMini dpc = new DirectPrintClassMini();
                    dpc.Run(reportViewerMini.LocalReport);
                }
            }
            else if (typeID == 3 || typeID == 5)
            {
                spselectDeliveryReceiptsDetailsResultBindingSource.DataSource = data.sp_selectDeliveryReceiptsDetails(receiptID).ToList();
                if (sizeType == 1)
                {
                    
                    ReportParameterCollection parameters = new ReportParameterCollection();
                    parameters.Add(new ReportParameter("TotalDiscount", TotalDiscount));
                    parameters.Add(new ReportParameter("TotalTVA", TotalTVA));
                    parameters.Add(new ReportParameter("FinalLBPPrice", FinalLBPPrice));
                    parameters.Add(new ReportParameter("FinalDollarPrice", FinalDollarPrice));
                    parameters.Add(new ReportParameter("ReceiptType", type));
                    deliveryInReportViewerA4.LocalReport.SetParameters(parameters);
                    this.deliveryInReportViewerA4.RefreshReport();
                    DirectPrintClass dpc = new DirectPrintClass();
                    dpc.Run(deliveryInReportViewerA4.LocalReport);
                }
                else if (sizeType == 2)
                {
                    
                    ReportParameterCollection parameters = new ReportParameterCollection();
                    parameters.Add(new ReportParameter("TotalDiscount", TotalDiscount));
                    parameters.Add(new ReportParameter("TotalTVA", TotalTVA));
                    parameters.Add(new ReportParameter("FinalLBPPrice", FinalLBPPrice));
                    parameters.Add(new ReportParameter("FinalDollarPrice", FinalDollarPrice));
                    parameters.Add(new ReportParameter("ReceiptType", type));
                    deliveryInReportViewerA4.LocalReport.SetParameters(parameters);
                    this.deliveryInReportViewerA4.RefreshReport();
                    DirectPrintClassMini dpc = new DirectPrintClassMini();
                    dpc.Run(deliveryInReportViewerA4.LocalReport);
                }
            }

            this.Close();
        }

        private void DirectReceiptReportViewer_Load(object sender, EventArgs e)
        {
            Print();
        }
    }
}
