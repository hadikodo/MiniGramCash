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
    public partial class ProductsCountOfSalesByDateUC : UserControl
    {
        private DateTime? from, to;
        public ProductsCountOfSalesByDateUC(DateTime? from,DateTime? to)
        {
            this.from = from;
            this.to = to;
            InitializeComponent();
        }

        private void ProductsCountOfSalesByDateUC_Load(object sender, EventArgs e)
        {
            refreshData(from,to);
        }

        private void refreshData(DateTime? from, DateTime? to)
        {
            using (var data = new MiniGramDBDataContext(Globals.ConnectionString))
            {
                sp_getSalesProductCountByDateResultBindingSource.DataSource = data.sp_getSalesProductCountByDate(from, to).ToList();
                reportViewer1.RefreshReport();
            }

        }
    }
}
