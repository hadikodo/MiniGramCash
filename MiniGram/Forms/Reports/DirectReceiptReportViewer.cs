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

        public void Print()
        {
            if (typeID == 1 || typeID == 2 || typeID == 4 || typeID == 6)
            {
                
                if (sizeType == 1)
                {
                    List<sp_selectReceiptsDetailsResult> rptData = new List<sp_selectReceiptsDetailsResult>();

                    using(var dataReal = new MiniGramDBDataContext(Globals.ConnectionString))
                    {
                        rptData = (from aj in dataReal.sp_selectReceiptsDetails(receiptID) select aj).ToList();
                    }
                    sp_selectReceiptsDetailsResultBindingSource.DataSource = rptData;
                    ReportParameterCollection parameters = new ReportParameterCollection();
                    parameters.Add(new ReportParameter("TotalDiscount", TotalDiscount));
                    parameters.Add(new ReportParameter("TotalTVA", TotalTVA));
                    parameters.Add(new ReportParameter("FinalLBPPrice", FinalLBPPrice));
                    parameters.Add(new ReportParameter("FinalDollarPrice", FinalDollarPrice));
                    parameters.Add(new ReportParameter("ReceiptType", type));
                    reportViewerA4.LocalReport.SetParameters(parameters);
                    reportViewerA4.RefreshReport();
                    DirectPrintClass dpc = new DirectPrintClass();
                    dpc.Run(reportViewerA4.LocalReport);

                }
                else if (sizeType == 2)
                {
                    List<sp_selectReceiptsDetailsForReportMiniResult> rptData = new List<sp_selectReceiptsDetailsForReportMiniResult>();

                    using (var dataReal = new MiniGramDBDataContext(Globals.ConnectionString))
                    {
                        rptData = (from aj in dataReal.sp_selectReceiptsDetailsForReportMini(receiptID) select aj).ToList();
                    }
                    sp_selectReceiptsDetailsForReportMiniResultBindingSource.DataSource = rptData;
                    ReportParameterCollection parameters = new ReportParameterCollection();
                    parameters.Add(new ReportParameter("TotalDiscount", TotalDiscount));
                    parameters.Add(new ReportParameter("TotalTVA", TotalTVA));
                    parameters.Add(new ReportParameter("FinalLBPPrice", FinalLBPPrice));
                    parameters.Add(new ReportParameter("FinalDollarPrice", FinalDollarPrice));
                    parameters.Add(new ReportParameter("ReceiptType", type));
                    reportViewerMini.LocalReport.SetParameters(parameters);
                    reportViewerMini.RefreshReport();
                    DirectPrintClassMini dpc = new DirectPrintClassMini();
                    dpc.Run(reportViewerMini.LocalReport);
                }
            }
            else if (typeID == 3 || typeID == 5)
            {
                List<sp_selectDeliveryReceiptsDetailsResult> rptData = new List<sp_selectDeliveryReceiptsDetailsResult>();
                using (var dataReal = new MiniGramDBDataContext(Globals.ConnectionString))
                {
                    rptData = (from aj in dataReal.sp_selectDeliveryReceiptsDetails(receiptID) select aj).ToList();
                }
                sp_selectDeliveryReceiptsDetailsResultBindingSource.DataSource = rptData;
                if (sizeType == 1)
                {
                    ReportParameterCollection parameters = new ReportParameterCollection();
                    parameters.Add(new ReportParameter("TotalDiscount", TotalDiscount));
                    parameters.Add(new ReportParameter("TotalTVA", TotalTVA));
                    parameters.Add(new ReportParameter("FinalLBPPrice", FinalLBPPrice));
                    parameters.Add(new ReportParameter("FinalDollarPrice", FinalDollarPrice));
                    parameters.Add(new ReportParameter("ReceiptType", type));
                    deliveryInReportViewerA4.LocalReport.SetParameters(parameters);
                    deliveryInReportViewerA4.RefreshReport();
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
                    deliveryInReportViewerA4.RefreshReport();
                    DirectPrintClassMini dpc = new DirectPrintClassMini();
                    dpc.Run(deliveryInReportViewerA4.LocalReport);
                }
            }

            this.Close();
        }

        private void DirectReceiptReportViewer_Load(object sender, EventArgs e)
        {
        }
    }
}
