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
    public partial class CustomersUC : UserControl
    {
        private MiniGramDBDataContext cnx = new MiniGramDBDataContext();
        public CustomersUC()
        {
            InitializeComponent();
        }

        private void addcustomer_btn_Click(object sender, EventArgs e)
        {

        }

        private void CustomersUC_Load(object sender, EventArgs e)
        {

        }

        private void enable_btn_Click(object sender, EventArgs e)
        {
            cnx.sp_enableCustomerByID(Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
            refreshData();
        }

        private void disable_btn_Click(object sender, EventArgs e)
        {
            cnx.sp_disableCustomerByID(Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
            refreshData();
        }
        public void refreshData()
        {
            spselectAllCustomersResultBindingSource.DataSource = cnx.sp_selectAllCustomers();
            dataGridView1.Refresh();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!(bool)cnx.fc_checkCustomerEnabledByID(Int32.Parse(row.Cells[0].Value.ToString())))
                {
                    row.DefaultCellStyle.BackColor = Color.DarkGray;
                }
            }
        }
    }
}
