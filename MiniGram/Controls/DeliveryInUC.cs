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
    public partial class DeliveryInUC : UserControl
    {

        private int time = 0;
        private Dictionary<int, string> StatusDictionary = new Dictionary<int, string>();

        public DeliveryInUC()
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

        private void InitPermissions()
        {
            //btnAddDeliveryIn.Visible = Globals.permissionAddEditDeliveryInReceipt;      
        }

        private void DeliveryInUC_Load(object sender, EventArgs e)
        {
            InitPermissions();
            InitFilters();
            search_txt.Visible = false;
            Globals.isSearchVisible = false;
        }

        private void InitFilters()
        {
            StatusDictionary.Add(0,"All");
            StatusDictionary.Add(1,"New");
            StatusDictionary.Add(2,"Sent To Accounting");
            StatusDictionary.Add(3,"Locked By Accounting");
            StatusDictionary.Add(4,"Approved By Accounting");

            tBLSTATUSBindingSource.DataSource = StatusDictionary;
            cboxStatusFilter.DataSource = tBLSTATUSBindingSource;
            cboxStatusFilter.ValueMember = "Key";
            cboxStatusFilter.DisplayMember = "Value";
        }

        private void btnAddDeliveryIn_Click(object sender, EventArgs e)
        {
            DeliveryInForm dif = new DeliveryInForm(0,1);
            dif.ShowDialog();
            refreshData("");
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
            using (MiniGramDBDataContext cnx = new MiniGramDBDataContext(Globals.ConnectionString))
            {
                bool isAccounting = true; //Globals.permissionCanLockOrUnlockDeliveryIn || Globals.permissionCanApproveDeliveryIn;

                List<sp_selectDeliveryReceiptsResult> data = new List<sp_selectDeliveryReceiptsResult>();

                if(isAccounting)
                    data = (from aj in cnx.sp_selectDeliveryReceipts(str) where aj.StatusID > 1 select aj).ToList();
                else
                    data = (from aj in cnx.sp_selectDeliveryReceipts(str) select aj).ToList();

                spselectDeliveryReceiptsResultBindingSource.DataSource = (from aj in data where cboxStatusFilter.SelectedValue == null || cboxStatusFilter.SelectedValue.ToString() == "0" || aj.StatusID.ToString() == cboxStatusFilter.SelectedValue.ToString() orderby aj.Date descending select aj).Take(200).ToList();
                dataGridView1.Refresh();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    int statusID = int.Parse(row.Cells["StatusIDColumn"].Value.ToString());
                    switch (statusID)
                    {
                        case 1:
                            row.Cells["StatusNameColumn"].Style.BackColor = Color.Lime;
                            row.Cells["StatusNameColumn"].Style.ForeColor = Color.FromArgb(0,63,63);
                            break;
                        case 2:
                            row.Cells["StatusNameColumn"].Style.BackColor = Color.Yellow;
                            row.Cells["StatusNameColumn"].Style.ForeColor = Color.FromArgb(0, 63, 63);
                            break;
                        case 3:
                            row.Cells["StatusNameColumn"].Style.BackColor = Color.LightGray;
                            row.Cells["StatusNameColumn"].Style.ForeColor = Color.FromArgb(0, 63, 63);
                            break;
                        case 4:
                            row.Cells["StatusNameColumn"].Style.BackColor = Color.Green;
                            row.Cells["StatusNameColumn"].Style.ForeColor = Color.White;
                            break;
                    }
                }
            }
        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            time = 0;
            timerRefreshDataDelay.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!Globals.isSearchVisible)
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUnlock.Visible = int.Parse(dataGridView1.SelectedRows[0].Cells["StatusIDColumn"].Value.ToString()) == 3;
            if(e.ColumnIndex == dataGridView1.SelectedRows[0].Cells["EditColumn"].ColumnIndex)
            {
                if (int.Parse(dataGridView1.SelectedRows[0].Cells["StatusIDColumn"].Value.ToString()) == 2)
                {
                    if (MessageBox.Show("When You Open This Receipt Will Be Locked, Want To Continue??", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (var ax = new MiniGramDBDataContext(Globals.ConnectionString))
                        {
                            TBLDELIVERY_RECEIPT receipt = (from aj in ax.TBLDELIVERY_RECEIPTs where aj.ID == int.Parse(dataGridView1.SelectedRows[0].Cells["IDColumn"].Value.ToString()) select aj).SingleOrDefault();
                            receipt.StatusID = 3;
                            ax.SubmitChanges();
                            refreshData("");
                        }
                    }
                    else
                        return;
                }
                    DeliveryInForm dif = new DeliveryInForm(int.Parse(dataGridView1.SelectedRows[0].Cells["IDColumn"].Value.ToString()), int.Parse(dataGridView1.SelectedRows[0].Cells["StatusIDColumn"].Value.ToString()));
                    dif.ShowDialog();
                    refreshData("");
            }
        }

        private void btnUnlock_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Unlock This Receipt ??", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (var ax = new MiniGramDBDataContext(Globals.ConnectionString))
                    {
                        TBLDELIVERY_RECEIPT receipt = (from aj in ax.TBLDELIVERY_RECEIPTs where aj.ID == int.Parse(dataGridView1.SelectedRows[0].Cells["IDColumn"].Value.ToString()) select aj).SingleOrDefault();
                        receipt.StatusID = 2;
                        ax.SubmitChanges();
                    }
                    btnUnlock.Visible = false;
                    refreshData("");
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void cboxStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshData("");
        }
    }
}
