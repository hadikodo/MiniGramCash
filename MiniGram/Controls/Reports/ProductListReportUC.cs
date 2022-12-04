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
    public partial class ProductListReportUC : UserControl
    {

        private string barcode, pname, supplier;
        private bool? hasQte;
        private int? hasExpDate;
        public ProductListReportUC(string barcode,string pname, string supplier,bool? hasQte,int? hasExpDate)
        {
            this.barcode = barcode;
            this.pname = pname;
            this.supplier = supplier;
            this.hasQte = hasQte;
            this.hasExpDate = hasExpDate;
            InitializeComponent();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            refreshData();
        }

        private void refreshData()
        {
            using(var data = new MiniGramDBDataContext(Globals.ConnectionString))
            {
                spgetProductListResultBindingSource.DataSource = (from aj in data.sp_getProductList()
                                                                  where (barcode == null || aj.BARCODE.ToLower().Trim().Contains(barcode.ToLower().Trim())) &&
                                                                        (pname == null || aj.PNAME.ToLower().Trim().Contains(pname.ToLower().Trim())) &&
                                                                        (supplier == null || aj.SNAME.ToLower().Trim().Contains(supplier.ToLower().Trim())) &&
                                                                        (hasExpDate == null || aj.HasExpiredDate == hasExpDate) &&
                                                                        (hasQte == null || aj.HasQuantity == hasQte)
                                                                  select aj).ToList();
                reportViewer1.RefreshReport();
            }
        }
    }
}
