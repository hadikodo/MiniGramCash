using Infragistics.Win.Description;
using MiniGram.Classes;
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

namespace MiniGram.Forms
{
    public partial class ChooseCustomerForm : Form
    {
        public TBLCUSTOMER customer = null;

        public ChooseCustomerForm()
        {
            InitializeComponent();
        }

        private int time = 0;

        private void ChooseCustomerForm_Load(object sender, EventArgs e)
        {
            ActiveControl = txtCustomerNameOrID;
            refreshData("");
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void keyboard_btn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = @"C:\Windows\System32\osk.exe";
            Process process = new Process();
            process.StartInfo = ps;
            process.Start();
            ActiveControl = txtCustomerNameOrID;
        }

        private void accept_btn_Click(object sender, EventArgs e)
        {
            int CustomerID = Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells[0].Value.ToString());
            using (var ax = new MiniGramDBDataContext(Globals.ConnectionString))
            {
                customer = (from aj in ax.TBLCUSTOMERs where aj.ID == CustomerID select aj).Single();
            }
            this.Close();
        }

        private void refreshData(string str)
        {
            using(var ax = new MiniGramDBDataContext(Globals.ConnectionString))
            {
                tBLCUSTOMERBindingSource.DataSource = (from aj in ax.TBLCUSTOMERs 
                                                       where (chkboxVIP.CheckState == CheckState.Indeterminate ||
                                                              aj.isVIP == chkboxVIP.Checked) && 
                                                             (aj.FullName.Contains(str) ||
                                                              aj.PhoneNumber.Contains(str) ||
                                                              aj.ID.ToString().Contains(str) ||
                                                              aj.Email.Contains(str))
                                                       select aj).ToList();
            }
        }

        private void timerRefreshDataDelay_Tick(object sender, EventArgs e)
        {
            if (time >= 2)
            {
                refreshData(txtCustomerNameOrID.Text);
                time = 0;
                timerRefreshDataDelay.Stop();
            }
            else
            {
                time++;
            }
        }

        private void txtCustomerNameOrID_TextChanged(object sender, EventArgs e)
        {
            time = 0;
            timerRefreshDataDelay.Start();
        }

        private void txtCustomerNameOrID_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                accept_btn_Click(sender, e);
            }
        }

        private void dgvCustomers_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                accept_btn_Click(sender, e);
            }
        }

        private void accept_btn_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                accept_btn_Click(sender, e);
            }
        }

        private void chkboxVIP_CheckedChanged(object sender, EventArgs e)
        {
            refreshData(txtCustomerNameOrID.Text);
        }
    }
}
