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

namespace MiniGram.Controls
{
    public partial class ReceiptsUC : UserControl
    {
        private MiniGramDBDataContext cnx = new MiniGramDBDataContext();
        public ReceiptsUC()
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

        private void ReceiptsUC_Load(object sender, EventArgs e)
        {
            search_txt.Visible = false;
            Globals.isSearchVisible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                
            }
            if (e.ColumnIndex == 7)
            {
                ReceiptDetails rd = new ReceiptDetails(Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
                rd.refreshData();
                rd.ShowDialog();
                refreshData();
                search_txt.Text = "";
            }
        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                spselectReceiptsResultBindingSource.DataSource = cnx.sp_selectReceipts(search_txt.Text);
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {

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
        public void refreshData()
        {
            spselectReceiptsResultBindingSource.DataSource = cnx.sp_selectReceipts("");
            dataGridView1.Refresh();
        }
    }
}
