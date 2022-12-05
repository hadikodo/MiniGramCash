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

namespace MiniGram.Controls
{
    public partial class DashboardUC : UserControl
    {
        public DashboardUC()
        {
            InitializeComponent();
        }

        private void ultraLabel1_Click(object sender, EventArgs e)
        {

        }

        private void DashboardUC_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString();
            refreshData();
        }


        public void refreshData()
        {
            using (var data = new MiniGramDBDataContext(Globals.ConnectionString))
            {

                var list1 = data.sp_getBestItems(DateTime.Today).ToList().OrderBy((aj) => aj.TOTAL);
                var list2 = data.sp_getBestSuppliers(DateTime.Today).ToList().OrderBy((aj) => aj.TOTAL);
                if(list1.Count() > 0 && list2.Count() > 0 )
                {
                    bindingBestItems.DataSource = list1;
                    bindingBestSuppliers.DataSource = list2;
                }
                lblTodaySale.Text = (from aj in data.TBLRECEIPTs where aj.RDATE.Value.Date == DateTime.Today.Date select aj.TOTAL_AMOUNTDollar).ToList().Sum(x => Convert.ToDouble(x)).ToString() + " $";
                lblTodayYesterday.Text = ((from aj in data.TBLRECEIPTs where aj.RDATE.Value.Date == DateTime.Today.Date select aj.TOTAL_AMOUNTDollar).ToList().Sum(x => Convert.ToDouble(x)) - (from aj in data.TBLRECEIPTs where aj.RDATE.Value.Date == DateTime.Today.AddDays(-1).Date select aj.TOTAL_AMOUNTDollar).ToList().Sum(x => Convert.ToDouble(x))).ToString() + " $";
                lblTotalReceipt.Text = (from aj in data.TBLRECEIPTs where aj.RDATE.Value.Date == DateTime.Today.Date select aj.RID).ToList().Count().ToString();
                lblTotalItems.Text = (from aj in data.TBLRECEIPTs where aj.RDATE.Value.Date == DateTime.Today.Date select aj.RITEM_NB).ToList().Sum(x => Convert.ToInt32(x)).ToString();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            refreshData();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString();
        }
    }
}
