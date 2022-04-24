using MiniGram.Classes;
using MiniGram.Forms;
using MiniGram.LINQ;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGram.Controls
{
    public partial class ProductsUC : UserControl
    {
        private MiniGramDBDataContext cnx = new MiniGramDBDataContext(Properties.Settings.Default.ConnectionString);
        public ProductsUC()
        {
            InitializeComponent();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle = 0x02000000;
                return handleparam;
            }
        }

        private void CustomersUC_Load(object sender, EventArgs e)
        {
            search_txt.Visible = false;
            Globals.isSearchVisible = false;
        }

        private void enable_btn_Click(object sender, EventArgs e)
        {
            cnx.sp_enableProductByID(Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
            refreshData();
        }

        private void disable_btn_Click(object sender, EventArgs e)
        {
            cnx.sp_disableProductByID(Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
            refreshData();
        }
        public void refreshData()
        {          
            spselectproductsResultBindingSource.DataSource = cnx.sp_select_products("");
            dataGridView1.Refresh();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.Cells[6].Value.ToString().Equals("Enabled"))
                {
                    row.DefaultCellStyle.BackColor = Color.DarkGray;
                }
            }           
        }

        private void addproduct_btn_Click(object sender, EventArgs e)
        {
            AddProductForm apf = new AddProductForm();
            apf.ShowDialog();
            refreshData();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            if(!Globals.isSearchVisible)
            {
                search_txt.Visible = true;

                this.ActiveControl = search_txt;
                timer1.Start();
            }
            else
            {
                
                timer1.Start();
                refreshData();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(!Globals.isSearchVisible)
            {
                if (search_txt.Width < 500)
                    search_txt.Width += 50;
                else
                {
                    Globals.isSearchVisible = true;
                    timer1.Stop();
                }
            }
            else
            {
                if (search_txt.Width > 50)
                    search_txt.Width -= 50;
                else
                {
                    search_txt.Text = "";
                    search_txt.Visible = false;
                    Globals.isSearchVisible = false;
                    timer1.Stop();
                }
            }
        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                spselectproductsResultBindingSource.DataSource = cnx.sp_select_products(search_txt.Text);
                dataGridView1.Refresh();
            } catch (Exception ex)
            {

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                EditProductForm epf = new EditProductForm(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
                epf.ShowDialog();
                refreshData();
            }
        }

        private void keyboard_btn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = ((Environment.GetFolderPath(Environment.SpecialFolder.System) + @"\osk.exe"));
            Process process = new Process();
            process.StartInfo = ps;
            process.Start();
            search_btn_Click(search_btn, e);
        }
    }
}
