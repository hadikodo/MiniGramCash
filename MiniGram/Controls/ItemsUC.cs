using MiniGram.Classes;
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
    public partial class ItemsUC : UserControl
    {
        private MiniGramDBDataContext cnx = new MiniGramDBDataContext();
        public ItemsUC()
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
        public void refreshData()
        {
            spselectitemResultBindingSource.DataSource = cnx.sp_select_item("");
            dataGridView1.Refresh();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.Cells[5].Value.ToString().Equals("Enabled"))
                {
                    row.DefaultCellStyle.BackColor = Color.DarkGray;
                }
            }
        }

        private void SuppliersUC_Load(object sender, EventArgs e)
        {
            Globals.isSearchVisible = false;
            search_txt.Visible = false;
        }

        private void addsupp_btn_Click(object sender, EventArgs e)
        {
            AddItemForm aif = new AddItemForm();
            aif.ShowDialog();
            refreshData();
        }

        private void enable_btn_Click(object sender, EventArgs e)
        {
            cnx.sp_enableItemByID(Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
            refreshData();
        }

        private void disable_btn_Click(object sender, EventArgs e)
        {
            cnx.sp_disableItemByID(Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
            refreshData();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!Globals.isSearchVisible)
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

        private void search_btn_Click(object sender, EventArgs e)
        {
            if (!Globals.isSearchVisible)
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

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                spselectitemResultBindingSource.DataSource = cnx.sp_select_item(search_txt.Text);
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                EditItemForm eif = new EditItemForm(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
                eif.ShowDialog();
                refreshData();
            }
        }
    }
}
