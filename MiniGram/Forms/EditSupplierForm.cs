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
    public partial class EditSupplierForm : Form
    {
        private int SupplierID;
        private MiniGramDBDataContext data = new MiniGramDBDataContext(Globals.ConnectionString);
        public EditSupplierForm(int SID)
        {
            InitializeComponent();
            SupplierID = SID;
        }

        private void EditItemForm_Load(object sender, EventArgs e)
        {
            warning_lable.Visible = false;
            var supp = (from i in data.TBLSUPPLIERs
                        where i.SID == SupplierID
                        select i).ToList();
            if (supp != null)
            {
                suppname_txt.Text = supp[0].SNAME;
                email_txt.Text = supp[0].SEMAIL;
                phone_txt.Text = supp[0].SPHONE;
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quantity_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = false;
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(suppname_txt.Text) || string.IsNullOrEmpty(phone_txt.Text))
            {
                warning_lable.Visible = true;
            }
            else
            {
                if (string.IsNullOrEmpty(email_txt.Text))
                    email_txt.Text = "-";
                using (var cnx = new MiniGramDBDataContext(Globals.ConnectionString))
                {
                    try
                    {
                        cnx.sp_UpdateSupplier(SupplierID,suppname_txt.Text,phone_txt.Text, email_txt.Text);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Something Went Wrong, The Item Not Updated, Please Call The Support!!");
                        this.Close();
                    }
                    MessageBox.Show("Item Update Successfully.");
                    this.Close();
                }

            }
        }

        private void keyboard_btn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = @"C:\Windows\System32\osk.exe";
            Process process = new Process();
            process.StartInfo = ps;
            process.Start();
            ActiveControl = suppname_txt;
        }
    }
}
