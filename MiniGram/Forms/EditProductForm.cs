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
    public partial class EditProductForm : Form
    {
        private int productID;
        private MiniGramDBDataContext cnx = new MiniGramDBDataContext();
        public EditProductForm(int PID)
        {
            InitializeComponent();
            productID = PID;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(productname_txt.Text) || string.IsNullOrEmpty(price_txt.Text))
            {
                warning_lable.Visible = true;
            }
            else
            {
                if (hasqte_combo.SelectedIndex == 0)
                {
                    quantity_txt.Text = "0";
                    using (var cnx = new MiniGramDBDataContext())
                    {
                        try
                        {
                            cnx.sp_UpdateProduct(productID,productname_txt.Text, Int32.Parse(quantity_txt.Text), float.Parse(price_txt.Text), false);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Something Went Wrong, The Product Not Updated, Please Call The Support!!");
                            this.Close();
                        }
                        MessageBox.Show("Product Update Successfully.");
                        this.Close();
                    }
                }
                else if (hasqte_combo.SelectedIndex == 1)
                {
                    if (string.IsNullOrEmpty(quantity_txt.Text))
                        warning_lable.Visible = true;
                    else
                    {
                        using (var cnx = new MiniGramDBDataContext())
                        {
                            try
                            {
                                cnx.sp_UpdateProduct(productID,productname_txt.Text, Int32.Parse(quantity_txt.Text), float.Parse(price_txt.Text), true);
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Something Went Wrong, The Product Not Updated, Please Call The Support!!");
                            }
                            MessageBox.Show("Product Update Successfully.");
                            this.Close();
                        }
                    }
                }
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditProductForm_Load(object sender, EventArgs e)
        {
            warning_lable.Visible = false;
            var product = (from p in cnx.TBLPRODUCTs
                          where p.PID == productID
                          select p).ToList();
            if (product != null)
            {
                productname_txt.Text = product[0].PNAME;
                hasqte_combo.SelectedIndex = Convert.ToInt32(product[0].HasQuantity);
                quantity_txt.Text = product[0].QTE.ToString();
                price_txt.Text = product[0].PRICE.ToString();
            }
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

        private void price_txt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void hasqte_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (hasqte_combo.SelectedIndex == 1)
            {
                label3.Enabled = true;
                quantity_txt.Enabled = true;
            }
            else if (hasqte_combo.SelectedIndex == 0)
            {
                label3.Enabled = false;
                quantity_txt.Enabled = false;
            }
        }
    }
}
