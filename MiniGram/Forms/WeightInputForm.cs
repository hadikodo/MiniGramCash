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
    public partial class WeightInputForm : Form
    {

        public int _weight = 0;

        public WeightInputForm()
        {
            InitializeComponent();
        }

        private void frmWeightInput_Load(object sender, EventArgs e)
        {
            txtWeight.Text = _weight.ToString();
            ActiveControl = txtWeight;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKeyboard_Click(object sender, EventArgs e)
        {
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = @"C:\Windows\System32\osk.exe";
            Process process = new Process();
            process.StartInfo = ps;
            process.Start();
            ActiveControl = txtWeight;
        }

        private void accept_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtWeight.Text))
            {
                MessageBox.Show("Please Enter A Valid Weight !!");
                ActiveControl = txtWeight;
            }
            else
            {
                _weight = int.Parse(txtWeight.Text);

                if (_weight > 0)
                {
                    this.Close();
                }
                else
                {                    
                    MessageBox.Show("Please Enter A Valid Weight !!");
                    ActiveControl = txtWeight;
                }
            }
        }
        
        private void txtWeight_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                accept_btn_Click(accept_btn, e);
            }
        }
    }
}
