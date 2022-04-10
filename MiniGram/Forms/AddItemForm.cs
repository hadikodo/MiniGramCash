using MiniGram.LINQ;
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
    public partial class AddItemForm : Form
    {
        public AddItemForm()
        {
            InitializeComponent();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(itemname_txt.Text) || string.IsNullOrEmpty(quantity_txt.Text))
            {
                warning_lable.Visible = true;
            }
            else
            {
                if (string.IsNullOrEmpty(unit_txt.Text))
                    unit_txt.Text = "-";
                using (var cnx = new MiniGramDBDataContext())
                {
                    try
                    {
                        cnx.sp_addNewItem(itemname_txt.Text, Int32.Parse(quantity_txt.Text), unit_txt.Text);
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
    }
}
