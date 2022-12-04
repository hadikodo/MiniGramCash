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

namespace MiniGram.Controls.Reports
{
    public partial class DailyCashReportUC : UserControl
    {
        private DateTime? from, to;
        public DailyCashReportUC(DateTime? from,DateTime? to)
        {
            this.from = from;
            this.to = to;
            InitializeComponent();
        }

        private void DailyCashReportUC_Load(object sender, EventArgs e)
        {
            refreshData(from,to);
        }

        public void refreshData(DateTime? from,DateTime? to)
        {
            using (var data = new MiniGramDBDataContext(Globals.ConnectionString))
            {
                spgetDailyCashByDateResultBindingSource.DataSource = data.sp_getDailyCashByDate(from,to).ToList();
                reportViewer1.RefreshReport();
            }
        }
    }
}
