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

    public partial class DeliveryReceiptDetailsForm : Form
    {

        private int receiptID;
        private MiniGramDBDataContext cnx = new MiniGramDBDataContext(Globals.ConnectionString);

        public DeliveryReceiptDetailsForm( int id)
        {
            this.receiptID = id;

            InitializeComponent();
        }

        private void DeliveryReceiptDetailsForm_Load(object sender, EventArgs e)
        {

        }

        public void refreshData()
        {
            spselectDeliveryReceiptsDetailsResultBindingSource.DataSource = cnx.sp_selectDeliveryReceiptsDetails(receiptID).ToList();
            tBLDELIVERYRECEIPTBindingSource.DataSource = (from aj in cnx.TBLDELIVERY_RECEIPTs where aj.ID == receiptID select aj).ToList();
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            TBLDELIVERY_RECEIPT receipt = (from aj in cnx.TBLDELIVERY_RECEIPTs where aj.ID == receiptID select aj).SingleOrDefault();
            double? finaldollar = receipt.TotalDollar - receipt.TotalDiscount + receipt.TotalTVA;
            int? finalLBP = Int32.Parse((finaldollar * Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString())).ToString());
            DirectReceiptReportViewer drrv = new DirectReceiptReportViewer(Properties.Settings.Default.ReceiptType, Int32.Parse(receipt.ReceiptTypeID.ToString()), receipt.TotalDiscount.ToString(), receipt.TotalTVA.ToString(), finalLBP.ToString(), finaldollar.ToString());
            drrv.receiptID = receiptID;
            drrv.Show();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
