using MiniGram.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGram.Forms
{
    public partial class ChangeQuantityForm : Form
    {
        private int itemNB;
        public ChangeQuantityForm(int itemnb)
        {
            InitializeComponent();
            itemNB = itemnb;
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void item_number_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                accept_btn_Click(accept_btn, e);
            }
        }

        private void accept_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(item_number.Text))
            {
                MessageBox.Show("Please Enter A Valid Number !!");
                ActiveControl = item_number;
            }
            else
            {
                if (itemNB > 0)
                {
                    Globals.deleteNB = Int32.Parse(item_number.Text);
                    this.Close();
                }
                else
                {
                    Globals.deleteNB = itemNB;
                    MessageBox.Show("Please Enter A Valid Number !!");
                    ActiveControl = item_number;
                }
            }
        }

        private void ChangeQuantityForm_Load(object sender, EventArgs e)
        {
            item_number.Text = itemNB.ToString();
            ActiveControl = item_number;
        }
    }
}
