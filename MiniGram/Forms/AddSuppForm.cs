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
    public partial class AddSuppForm : Form
    {
        public AddSuppForm()
        {
            InitializeComponent();
        }

        private void add_btn_Click(object sender, EventArgs e)
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
                        cnx.sp_addNewSupplier(suppname_txt.Text, phone_txt.Text, email_txt.Text);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Something Went Wrong, The New Item Not Added, Please Call The Support!!");
                        this.Close();
                    }
                    MessageBox.Show("New Item Added Successfully.");
                    this.Close();
                }

            }
        }

        private void AddItemForm_Load(object sender, EventArgs e)
        {
            warning_lable.Visible = false;
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void keyboard_btn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = ((Environment.GetFolderPath(Environment.SpecialFolder.System) + @"\osk.exe"));
            Process process = new Process();
            process.StartInfo = ps;
            process.Start();
            ActiveControl = suppname_txt;
        }
    }
}
