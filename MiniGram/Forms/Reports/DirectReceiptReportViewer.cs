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
        private int sizeType;
        private int typeID;
        private string type,TotalDiscount, TotalTVA, FinalLBPPrice, FinalDollarPrice;

        public DirectReceiptReportViewer(int sizeType,int ReceiptType, string TotalDiscount, string TotalTVA, string FinalLBPPrice, string FinalDollarPrice)
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

        private void DirectReceiptReportViewer_Load(object sender, EventArgs e)
        {
            if (typeID == 1 || typeID == 2 || typeID == 4)
            {
                spselectReceiptsDetailsResultBindingSource.DataSource = data.sp_selectReceiptsDetails(receiptID).ToList();
                if (sizeType == 1)
                {
                    this.reportViewerA4.RefreshReport();
                    ReportParameterCollection parameters = new ReportParameterCollection();
                    parameters.Add(new ReportParameter("TotalDiscount", TotalDiscount));
                    parameters.Add(new ReportParameter("TotalTVA", TotalTVA));
                    parameters.Add(new ReportParameter("FinalLBPPrice", FinalLBPPrice));
                    parameters.Add(new ReportParameter("FinalDollarPrice", FinalDollarPrice));
                    parameters.Add(new ReportParameter("ReceiptType", type));
                    reportViewerA4.LocalReport.SetParameters(parameters);
                    DirectPrintClass dpc = new DirectPrintClass();
                    dpc.Run(reportViewerA4.LocalReport);
                }
                else if (sizeType == 2)
                {
                    this.reportViewerMini.RefreshReport();
                    ReportParameterCollection parameters = new ReportParameterCollection();
                    parameters.Add(new ReportParameter("TotalDiscount", TotalDiscount));
                    parameters.Add(new ReportParameter("TotalTVA", TotalTVA));
                    parameters.Add(new ReportParameter("FinalLBPPrice", FinalLBPPrice));
                    parameters.Add(new ReportParameter("FinalDollarPrice", FinalDollarPrice));
                    parameters.Add(new ReportParameter("ReceiptType", type));
                    reportViewerMini.LocalReport.SetParameters(parameters);
                    DirectPrintClassMini dpc = new DirectPrintClassMini();
                    dpc.Run(reportViewerMini.LocalReport);
                }
            }
            else if (typeID == 3 || typeID == 5)
            {
                sp_selectDeliveryReceiptsDetailsResultBindingSource.DataSource = data.sp_selectDeliveryReceiptsDetails(receiptID).ToList();
                if (sizeType == 1)
                {
                    this.deliveryInReportViewerA4.RefreshReport();
                    ReportParameterCollection parameters = new ReportParameterCollection();
                    parameters.Add(new ReportParameter("TotalDiscount", TotalDiscount));
                    parameters.Add(new ReportParameter("TotalTVA", TotalTVA));
                    parameters.Add(new ReportParameter("FinalLBPPrice", FinalLBPPrice));
                    parameters.Add(new ReportParameter("FinalDollarPrice", FinalDollarPrice));
                    parameters.Add(new ReportParameter("ReceiptType", type));
                    deliveryInReportViewerA4.LocalReport.SetParameters(parameters);
                    DirectPrintClass dpc = new DirectPrintClass();
                    dpc.Run(deliveryInReportViewerA4.LocalReport);
                }
                else if (sizeType == 2)
                {
                    this.deliveryInReportViewerMini.RefreshReport();
                    ReportParameterCollection parameters = new ReportParameterCollection();
                    parameters.Add(new ReportParameter("TotalDiscount", TotalDiscount));
                    parameters.Add(new ReportParameter("TotalTVA", TotalTVA));
                    parameters.Add(new ReportParameter("FinalLBPPrice", FinalLBPPrice));
                    parameters.Add(new ReportParameter("FinalDollarPrice", FinalDollarPrice));
                    parameters.Add(new ReportParameter("ReceiptType", type));
                    deliveryInReportViewerMini.LocalReport.SetParameters(parameters);
                    DirectPrintClassMini dpc = new DirectPrintClassMini();
                    dpc.Run(deliveryInReportViewerMini.LocalReport);
                }
            }

            this.Close();
        }
    }
}
