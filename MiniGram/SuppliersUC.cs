using MiniGram.Forms;
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

namespace MiniGram
{
    public partial class SuppliersUC : UserControl
    {
        private MiniGramDBDataContext cnx = new MiniGramDBDataContext();
        public SuppliersUC()
        {
            InitializeComponent();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }

        private void SuppliersUC_Load(object sender, EventArgs e)
        {
          spselectAllSuppliersResultBindingSource.DataSource = cnx.sp_selectAllSuppliers();
        }

        private void addsupp_btn_Click(object sender, EventArgs e)
        {
            AddSupplierForm asf = new AddSupplierForm();
            asf.ShowDialog();
            spselectAllSuppliersResultBindingSource.DataSource = cnx.sp_selectAllSuppliers();
            dataGridView1.Refresh();
        }
    }
}
