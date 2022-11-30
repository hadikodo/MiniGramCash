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
    public partial class HoldListUC : UserControl
    {
        private MiniGramDBDataContext cnx = new MiniGramDBDataContext(Globals.ConnectionString);
        public HoldListUC()
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

        private void HoldListUC_Load(object sender, EventArgs e)
        {
            search_txt.Visible = false;
            Globals.isSearchVisible = false;
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
            spselectReceiptsResultBindingSource.DataSource = cnx.sp_selectReceipts("").Where((aj) => aj.isHold);
            dataGridView1.Refresh();
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

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                spselectReceiptsResultBindingSource.DataSource = cnx.sp_selectReceipts(search_txt.Text).Where((aj) => aj.isHold);
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Print.Index)
            {
                DirectReceiptReportViewer drrv = new DirectReceiptReportViewer(Properties.Settings.Default.ReceiptType);
                drrv.receiptID = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                drrv.Show();
            }
            if(e.ColumnIndex == btnColumnOpen.Index)
            {
                var receipt = (from aj in cnx.TBLRECEIPTs where aj.RID == Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()) select aj).Single();
                receipt.isHold = false;
                cnx.SubmitChanges();
                POSUC pos = new POSUC(receipt);                
                Globals.mainForm.main_panel.Controls.Clear();
                pos.Dock = DockStyle.Fill;
                Globals.mainForm.main_panel.Controls.Add(pos);
                Globals.mainForm.refreshColors();
                Globals.mainForm.new_receipt_btn.BackColor= Color.White;
                pos.refreshData("");
                cnx.sp_deleteHoldReceiptDetailsByRID(receipt.RID);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ReceiptDetails rd = new ReceiptDetails(Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
            rd.refreshData();
            rd.ShowDialog();
            refreshData();
            search_txt.Text = "";
        }
    }
}
