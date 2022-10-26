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
    public partial class ReceiptDetails : Form
    {
        private int receiptID;
        private MiniGramDBDataContext cnx = new MiniGramDBDataContext(Globals.ConnectionString);
        public ReceiptDetails(int id)
        {
            InitializeComponent();
            receiptID = id;
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            DirectReceiptReportViewer drrv = new DirectReceiptReportViewer();
            drrv.receiptID = receiptID;
            drrv.Show();
        }

        private void ReceiptDetails_Load(object sender, EventArgs e)
        {

        }

        public void refreshData()
        {
            spselectReceiptsDetailsResultBindingSource.DataSource = cnx.sp_selectReceiptsDetails(receiptID);
            dataGridView1.Refresh();
            var receipt = cnx.sp_getReceiptByID(receiptID).ToList()[0];
            dataGridView2.Rows.Add(receipt.RBARCODE, receipt.RITEM_NB, "", receipt.TOTAL_AMOUNTDollar, receipt.TOTAL_AMOUNTLBP);
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
