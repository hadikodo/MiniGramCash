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
    public partial class CustomProductForm : Form
    {

        public double customPrice = 0;

        public CustomProductForm()
        {
            InitializeComponent();
        }

        private void sfButton1_Click(object sender, EventArgs e)
        {
            customPrice = 0;
            this.Close();
        }

        private void keyboard_btn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = @"C:\Windows\System32\osk.exe";
            Process process = new Process();
            process.StartInfo = ps;
            process.Start();
            ActiveControl = txtCustomPrice;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtCustomPrice.Text))
            {
                customPrice = Math.Round(Convert.ToDouble(txtCustomPrice.Text),2);
                this.Close();
            }
            else
            {
                MessageBox.Show("You cannot enter an empty value !!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
