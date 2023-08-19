using MiniGram.Classes;
using MiniGram.LINQ;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGram.Forms
{
    public partial class ReceiptDetails : Form
    {
        private int receiptID;
        private MiniGramDBDataContext cnx = new MiniGramDBDataContext(Globals.ConnectionString);
        public ReceiptDetails(int id)
        {
            this.receiptID = id;
            InitializeComponent();

        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            TBLRECEIPT receipt = (from aj in cnx.TBLRECEIPTs where aj.RID == receiptID select aj).SingleOrDefault();
            double? finaldollar = receipt.TOTAL_AMOUNTDollar - receipt.TotalDiscount + receipt.TotalTVA;
            int? finalLBP = Int32.Parse((finaldollar * Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString())).ToString());
            Thread tr = new Thread(() =>
            {
                DirectReceiptReportViewer drrv = new DirectReceiptReportViewer(Properties.Settings.Default.ReceiptType, receipt.ReceiptTypeID, receipt.TotalDiscount.ToString(), receipt.TotalTVA.ToString(), finalLBP.ToString(), finaldollar.ToString());
                drrv.receiptID = receiptID;
                drrv.Show();
                Thread.CurrentThread.Abort();
            });
            tr.Start();
        }

        private void ReceiptDetails_Load(object sender, EventArgs e)
        {

        }

        public void refreshData()
        {
            spselectReceiptsDetailsResultBindingSource.DataSource = cnx.sp_selectReceiptsDetails(receiptID);
            dataGridView1.Refresh();
            sp_getReceiptByIDResult receipt = cnx.sp_getReceiptByID(receiptID).ToList()[0];
            dataGridView2.Rows.Add(receipt.RBARCODE, receipt.RITEM_NB, "", receipt.TOTAL_AMOUNTDollar, receipt.TOTAL_AMOUNTLBP);

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
