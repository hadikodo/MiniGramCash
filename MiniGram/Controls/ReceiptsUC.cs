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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGram.Controls
{
    public partial class ReceiptsUC : UserControl
    {
        private MiniGramDBDataContext cnx = new MiniGramDBDataContext(Globals.ConnectionString);

        private int time = 0;


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

        private void refreshCbox()
        {
            Dictionary<int, string> dicRType = new Dictionary<int, string>();
            dicRType.Add(1, "Sale");
            dicRType.Add(2, "Return");
            dicRType.Add(3, "Delivery In");

            cboxReceiptsType.DataSource = new BindingSource(dicRType, null);
            cboxReceiptsType.ValueMember = "Key";
            cboxReceiptsType.DisplayMember = "Value";
            cboxReceiptsType.SelectedValue = 1;
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
            refreshCbox();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Print.Index)
            {
                int RID = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

                if (cboxReceiptsType.SelectedValue.ToString() == "1" || cboxReceiptsType.SelectedValue.ToString() == "2")
                {
                    TBLRECEIPT receipt = (from aj in cnx.TBLRECEIPTs where aj.RID == RID select aj).SingleOrDefault();
                    double? finaldollar = receipt.TOTAL_AMOUNTDollar - receipt.TotalDiscount + receipt.TotalTVA;
                    int? finalLBP = Int32.Parse((finaldollar * Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString())).ToString());
                    Thread tr = new Thread(() =>
                    {
                        DirectReceiptReportViewer drrv = new DirectReceiptReportViewer(Properties.Settings.Default.ReceiptType, receipt.ReceiptTypeID, receipt.TotalDiscount.ToString(), receipt.TotalTVA.ToString(), finalLBP.ToString(), finaldollar.ToString());
                        drrv.receiptID = RID;
                        drrv.Print();
                    });
                    tr.Start();
                }
            }
            if (e.ColumnIndex == ShowMore.Index)
            {
                if (cboxReceiptsType.SelectedValue.ToString() == "1" || cboxReceiptsType.SelectedValue.ToString() == "2")
                {
                    ReceiptDetails rd = new ReceiptDetails(Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
                    rd.refreshData();
                    rd.ShowDialog();
                }
                else if (cboxReceiptsType.SelectedValue.ToString() == "4")
                {

                }

                refreshData("");
                search_txt.Text = "";
            }
        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            time = 0;
            timerRefreshDataDelay.Start();
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
                refreshData("");
            }
        }
        public void refreshData(string str)
        {
            if (cboxReceiptsType.SelectedValue.ToString() == "1" || cboxReceiptsType.SelectedValue.ToString() == "2")
            {
                spselectReceiptsResultBindingSource.DataSource = cnx.sp_selectReceipts(str).Where((aj) => !aj.isHold && aj.ReceiptTypeID.ToString() == cboxReceiptsType.SelectedValue.ToString());
                dataGridView2.Visible = false;
                dataGridView1.Visible = true;
                dataGridView1.Dock = DockStyle.Fill;
                dataGridView1.Refresh();
            }
            else if (cboxReceiptsType.SelectedValue.ToString() == "3")
            {
                spselectDeliveryReceiptsResultBindingSource.DataSource = cnx.sp_selectDeliveryReceipts(str).Where((aj) => aj.ReceiptTypeID.ToString() == cboxReceiptsType.SelectedValue.ToString());
                dataGridView1.Visible = false;
                dataGridView2.Visible = true;
                dataGridView2.Dock = DockStyle.Fill;
                dataGridView2.Refresh();
            }

        }

        private void keyboard_btn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = @"C:\Windows\System32\osk.exe";
            Process process = new Process();
            process.StartInfo = ps;
            process.Start();
            search_btn_Click(search_btn, e);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ReceiptDetails rd = new ReceiptDetails(Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
            rd.refreshData();
            rd.ShowDialog();
            refreshData("");
            search_txt.Text = "";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void spselectReceiptsResultBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void cboxReceiptsType_SelectedValueChanged(object sender, EventArgs e)
        {
            refreshData("");
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Print.Index)
            {
                int RID = Int32.Parse(dataGridView2.SelectedRows[0].Cells[0].Value.ToString());

                if (cboxReceiptsType.SelectedValue.ToString() == "3" || cboxReceiptsType.SelectedValue.ToString() == "5")
                {
                    TBLDELIVERY_RECEIPT receipt = (from aj in cnx.TBLDELIVERY_RECEIPTs where aj.ID == RID select aj).SingleOrDefault();
                    double? finaldollar = receipt.TotalDollar - receipt.TotalDiscount + receipt.TotalTVA;
                    int? finalLBP = Int32.Parse((finaldollar * Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString())).ToString());
                    DirectReceiptReportViewer drrv = new DirectReceiptReportViewer(Properties.Settings.Default.ReceiptType, Int32.Parse(receipt.ReceiptTypeID.ToString()), receipt.TotalDiscount.ToString(), receipt.TotalTVA.ToString(), finalLBP.ToString(), finaldollar.ToString());
                    drrv.receiptID = RID;
                    drrv.Show();
                }
            }
            if (e.ColumnIndex == ShowMore.Index)
            {
                if (cboxReceiptsType.SelectedValue.ToString() == "3" || cboxReceiptsType.SelectedValue.ToString() == "5")
                {
                    DeliveryReceiptDetailsForm rd = new DeliveryReceiptDetailsForm(Int32.Parse(dataGridView2.SelectedRows[0].Cells[0].Value.ToString()));
                    rd.refreshData();
                    rd.ShowDialog();
                }

                refreshData("");
                search_txt.Text = "";
            }
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DeliveryReceiptDetailsForm rd = new DeliveryReceiptDetailsForm(Int32.Parse(dataGridView2.SelectedRows[0].Cells[0].Value.ToString()));
            rd.refreshData();
            rd.ShowDialog();
            refreshData("");
            search_txt.Text = "";
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
    }
}
