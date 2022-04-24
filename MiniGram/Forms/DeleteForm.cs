using MiniGram.Classes;
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
    public partial class DeleteForm : Form
    {
        private int itemNB;
        public DeleteForm(int itemnb)
        {
            InitializeComponent();
            itemNB = itemnb;
        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {
            item_number.Text = itemNB.ToString();
            ActiveControl = item_number;
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(item_number.Text)){
                MessageBox.Show("Please Enter A Number !!");
            }
            else {
                if (Int32.Parse(item_number.Text) <= itemNB)
                {
                    Globals.deleteNB = Int32.Parse(item_number.Text);
                    this.Close();
                }
                else
                {
                    Globals.deleteNB = itemNB;
                    this.Close();
                }
            }
        }

        private void DeleteForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                delete_btn_Click(delete_btn, e);
            }
        }

        private void item_number_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                delete_btn_Click(delete_btn, e);
            }
        }

        private void sfButton1_Click(object sender, EventArgs e)
        {
            Globals.deleteNB = 0;
            this.Close();
        }

        private void keyboard_btn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = ((Environment.GetFolderPath(Environment.SpecialFolder.System) + @"\osk.exe"));
            Process process = new Process();
            process.StartInfo = ps;
            process.Start();
            ActiveControl = item_number;
        }
    }
}
