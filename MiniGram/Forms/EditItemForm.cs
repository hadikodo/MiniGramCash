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
    public partial class EditItemForm : Form
    {
        private int ItemID;
        private MiniGramDBDataContext data = new MiniGramDBDataContext();
        public EditItemForm(int itemID)
        {
            InitializeComponent();
            ItemID = itemID;
        }

        private void EditItemForm_Load(object sender, EventArgs e)
        {
            warning_lable.Visible = false;
            var item = (from i in data.TBLITEMs
                           where i.IID == ItemID
                           select i).ToList();
            if (item != null)
            {
                itemname_txt.Text = item[0].INAME;
                quantity_txt.Text = item[0].QTE.ToString();
                unit_txt.Text = item[0].UNIT.ToString();
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
                        cnx.sp_UpdateItem(ItemID,itemname_txt.Text, Int32.Parse(quantity_txt.Text), unit_txt.Text);
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
    }
}
