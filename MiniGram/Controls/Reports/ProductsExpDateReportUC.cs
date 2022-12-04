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
    public partial class ProductsExpDateReportUC : UserControl
    {
        public ProductsExpDateReportUC()
        {
            InitializeComponent();
        }

        private void ProductsExpDateReportUC_Load(object sender, EventArgs e)
        {
            using(var data = new MiniGramDBDataContext(Globals.ConnectionString))
            {
                spgetAllExpiredDateProductsResultBindingSource.DataSource = data.sp_getAllExpiredDateProducts().ToList();
                reportViewer1.RefreshReport();
            }
        }
    }
}
