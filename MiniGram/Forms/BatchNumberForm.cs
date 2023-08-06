using MiniGram.Controls;
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
    public partial class BatchNumberForm : Form
    {
        private POSUC form;
        public BatchNumberForm(POSUC form)
        {
            this.form = form;
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BatchNumberForm_Load(object sender, EventArgs e)
        {
            if (form.cardNumber != "")
                this.Close();
            ActiveControl = txtBatchNumber;
        }

        private void accept_btn_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txtBatchNumber.Text))
            //{
            //    MessageBox.Show("Please Enter A Valid Number !!","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            //    ActiveControl = txtBatchNumber;
            //}
            //else
            //{
            //    using (var ax = new OrganigramDBDataContext(Properties.Settings.Default.ConnectionStringUsers))
            //    {
            //        var usersCardNumbers = (from aj in ax.TblUsers select aj.CardNumber).ToList();
            //        if (usersCardNumbers.Contains(txtBatchNumber.Text)){
            //            form.cardNumber = txtBatchNumber.Text;
            //            this.Close();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Please Enter A Valid Number !!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            ActiveControl = txtBatchNumber;
            //        }

            //    }
            //}
        }

        private void keyboard_btn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = @"C:\Windows\System32\osk.exe";
            Process process = new Process();
            process.StartInfo = ps;
            process.Start();
            ActiveControl = txtBatchNumber;
        }

        private void txtBatchNumber_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                accept_btn_Click(accept_btn, e);
            }
        }
    }
}
