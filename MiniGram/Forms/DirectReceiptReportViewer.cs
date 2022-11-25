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
        private int type;
        public DirectReceiptReportViewer(int type)
        {
            this.type = type;
            InitializeComponent();
        }

        private void DirectReceiptReportViewer_Load(object sender, EventArgs e)
        {
            spselectReceiptsDetailsResultBindingSource.DataSource = data.sp_selectReceiptsDetails(receiptID);
            if (type == 1)
            {               
                this.reportViewerA4.RefreshReport();
                DirectPrintClass dpc = new DirectPrintClass();
                dpc.Run(reportViewerA4.LocalReport);
            }
            else if (type == 2)
            {
                this.reportViewerMini.RefreshReport();
                DirectPrintClassMini dpc = new DirectPrintClassMini();
                dpc.Run(reportViewerMini.LocalReport);
            }

            this.Close();

        }
    }
}
