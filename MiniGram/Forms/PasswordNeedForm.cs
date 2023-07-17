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
    public partial class PasswordNeedForm : Form
    {
        public bool isPasswordCorrect = false;
        private bool isErrorAppear = false;
        public PasswordNeedForm()
        {
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            isPasswordCorrect = false;
            this.Close();
        }

        private void accept_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                isErrorAppear = true;
                txtPassword.Text = "";
                MessageBox.Show("Please Enter At Least 6 Character !!");
                return;
            }
            if (txtPassword.Text == "2023")
            {
                isPasswordCorrect = true;
                this.Close();
            }
            else
            {
                isErrorAppear = true;
                txtPassword.Text = "";
                MessageBox.Show("Incorrect Password !!", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void keyboard_btn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = @"C:\Windows\System32\osk.exe";
            Process process = new Process();
            process.StartInfo = ps;
            process.Start();
        }

        private void PasswordNeedForm_Load(object sender, EventArgs e)
        {
            txtPassword.Focus();
        }

        private void PasswordNeedForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (!isErrorAppear)
                    accept_btn_Click(accept_btn, e);
                else
                    isErrorAppear = false;                
            }
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (!isErrorAppear)
                    accept_btn_Click(accept_btn, e);
                else
                    isErrorAppear = false;
            }
        }
    }
}
