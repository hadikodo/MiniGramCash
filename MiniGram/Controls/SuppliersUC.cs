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
        private void refreshData()
        {
            spselectAllSuppliersResultBindingSource.DataSource = cnx.sp_selectAllSuppliers();
            dataGridView1.Refresh();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!(bool)cnx.fc_checkSupplierEnabledByID(Int32.Parse(row.Cells[0].Value.ToString())))
                {
                    row.DefaultCellStyle.BackColor = Color.DarkGray;
                }
            }
        }

        private void SuppliersUC_Load(object sender, EventArgs e)
        {
            refreshData();
        }

        private void addsupp_btn_Click(object sender, EventArgs e)
        {
            AddSupplierForm asf = new AddSupplierForm();
            asf.ShowDialog();
            refreshData();
        }

        private void enable_btn_Click(object sender, EventArgs e)
        {
            cnx.sp_enableSupplierByID(Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
            refreshData();
        }

        private void disable_btn_Click(object sender, EventArgs e)
        {
            cnx.sp_disableSupplierByID(Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
            refreshData();
        }
    }
}
