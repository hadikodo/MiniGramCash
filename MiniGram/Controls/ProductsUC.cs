using Infragistics.Win.UltraWinGrid;
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

        private int time = 0;
        
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
            using(MiniGramDBDataContext cnx = new MiniGramDBDataContext(Globals.ConnectionString))
            {
                cnx.sp_enableProductByID(Int32.Parse(ultraGridProducts.ActiveRow.Cells[0].Value.ToString()));
                refreshData("");
            }

        }

        private void disable_btn_Click(object sender, EventArgs e)
        {
            using (MiniGramDBDataContext cnx = new MiniGramDBDataContext(Globals.ConnectionString))
            {
                cnx.sp_disableProductByID(Int32.Parse(ultraGridProducts.ActiveRow.Cells[0].Value.ToString()));
                refreshData("");
            }

        }
        public void refreshData(string str)
        {
            int enabledProduct = 0;
            using (MiniGramDBDataContext cnx = new MiniGramDBDataContext(Globals.ConnectionString))
            {
                try
                {
                    var data = cnx.sp_select_products(str).ToList();
                    lblCount.Text = data.Count().ToString();
                    bindingSource1.DataSource = data.ToList().Take(500);
                    foreach (UltraGridRow row in ultraGridProducts.Rows)
                    {
                        if (row.Cells[7].Value != null && !row.Cells[7].Value.ToString().Equals("Enabled"))
                        {
                            row.CellAppearance.BackColor = Color.DarkGray;
                            row.Appearance.BackColor = Color.DarkGray;
                            enabledProduct--;
                        }
                        if (row.Cells[4].Value == null || Int32.Parse(row.Cells[4].Value.ToString()) < 0)
                        {
                            row.CellAppearance.BackColor = Color.Red;
                            row.Appearance.BackColor = Color.Red;
                        }
                        enabledProduct++;
                    }
                }catch(Exception ex)
                {

                }
            }


        }

        private void addproduct_btn_Click(object sender, EventArgs e)
        {
            AddProductForm apf = new AddProductForm();
            apf.ShowDialog();
            refreshData("");
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
                refreshData("");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(!Globals.isSearchVisible)
            {
                if (search_txt.Width < 200)
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
                time = 0;
                timerRefreshDataDelay.Start();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void keyboard_btn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = @"C:\Windows\System32\osk.exe";
            Process process = new Process();
            process.StartInfo = ps;
            process.Start();
            search_btn_Click(sender, e);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDeliveryIn_Click(object sender, EventArgs e)
        {
            DeliveryInForm dif = new DeliveryInForm();
            dif.ShowDialog();
            refreshData("");
        }

        private void timerRefreshDataDelay_Tick(object sender, EventArgs e)
        {
            if (time >= 2)
            {
                refreshData(search_txt.Text);
                time = 0;
                timerRefreshDataDelay.Stop();
            }
            else
            {
                time++;
            }
        }

        private void ultraGridProducts_ClickCellButton(object sender, CellEventArgs e)
        {
            try
            {
                EditProductForm epf = new EditProductForm(Convert.ToInt32(ultraGridProducts.ActiveRow.Cells[0].Value.ToString()));
                epf.ShowDialog();
                refreshData("");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Show Info !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ultraGridProducts_DoubleClickRow(object sender, DoubleClickRowEventArgs e)
        {
            EditProductForm epf = new EditProductForm(Convert.ToInt32(ultraGridProducts.ActiveRow.Cells[0].Value.ToString()));
            epf.ShowDialog();
            refreshData("");
        }
    }
}
