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
    public partial class ExtendedCheckoutForm : Form
    {
        public double totalDollar, totalLBP, restDollar = 0, restLBP = 0, customerDollar = 0, customerLBP = 0, rate = Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString());
        

        private void txtCustomerDollar_KeyUp(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            e.SuppressKeyPress = true;
            if (e.KeyValue == 13)
            {
                if (txtCustomerDollar.Text == "")
                    customerDollar = totalDollar;
                else
                    customerDollar = Int32.Parse(txtCustomerDollar.Text);

                customerLBP = customerDollar * rate ;
                restDollar = totalDollar - customerDollar;
                restLBP = restDollar * rate;

                refreshTxtBoxes();
                ActiveControl = checkout_btn;
            }
        }

        private void txtCustomerDollar_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCustomerLBP_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtRestDollar_KeyUp(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            e.SuppressKeyPress = true;
            if (e.KeyValue == 13)
            {
                if (txtCustomerDollar.Text == "")
                    customerDollar = totalDollar;
                else
                    customerDollar = Int32.Parse(txtCustomerDollar.Text);

                customerLBP = customerDollar * rate;
                restDollar = totalDollar - customerDollar;
                restLBP = restDollar * rate;

                refreshTxtBoxes();
                ActiveControl = checkout_btn;
            }
        }

        private void txtRestLBP_KeyUp(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            e.SuppressKeyPress = true;
            if (e.KeyValue == 13)
            {
                if (txtCustomerLBP.Text == "")
                    customerLBP = totalLBP;
                else
                    customerLBP = Int32.Parse(txtCustomerLBP.Text);

                customerDollar = customerLBP / rate;
                restDollar = totalDollar - customerDollar;
                restLBP = restDollar * rate;

                refreshTxtBoxes();
                ActiveControl = checkout_btn;
            }
        }

        private void txtCustomerLBP_KeyUp(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            e.SuppressKeyPress = true;
            if (e.KeyValue == 13)
            {
                if (txtCustomerLBP.Text == "")
                    customerLBP = totalLBP;
                else
                    customerLBP = Int32.Parse(txtCustomerLBP.Text);

                customerDollar = customerLBP /rate;
                restDollar = totalDollar - customerDollar;
                restLBP = restDollar * rate;

                refreshTxtBoxes();
                ActiveControl = checkout_btn;
            }
        }

        public ExtendedCheckoutForm(double totDollar, double totLBP)
        {
            this.totalDollar = totDollar;
            this.totalLBP = totLBP;

            InitializeComponent();
        }

        private void ExtendedCheckoutForm_Load(object sender, EventArgs e)
        {
            customerDollar = totalDollar;
            customerLBP = totalLBP;
            restDollar = customerDollar - totalDollar;
            restLBP = customerLBP - totalLBP;

            refreshTxtBoxes();
        }

        private void refreshTxtBoxes()
        {
            txtCustomerDollar.Text = Math.Round(customerDollar,3).ToString();
            txtCustomerLBP.Text = customerLBP.ToString();
            txtRestDollar.Text = Math.Round(restDollar,3).ToString() + " $";
            txtRestLBP.Text = restLBP.ToString("#,0;-#,0") + " LBP";
        }

        private void checkout_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
