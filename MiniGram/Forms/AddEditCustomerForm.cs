using MiniGram.Classes;
using MiniGram.LINQ;
using Syncfusion.Windows.Forms.Tools;
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
using static Syncfusion.Windows.Forms.TabBar;

namespace MiniGram.Forms
{
    public partial class AddEditCustomerForm : Form
    {

        private int CustomerID = 0;

        public AddEditCustomerForm(int customerID)
        {
            InitializeComponent();
            CustomerID = customerID;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }

        private void RefreshCustomerData()
        {
            if (CustomerID != 0)
            {
                using (var ax = new MiniGramDBDataContext(Globals.ConnectionString))
                {
                    TBLCUSTOMER customer = (from aj in ax.TBLCUSTOMERs where aj.ID == CustomerID select aj).SingleOrDefault();

                    refreshAddresses();

                    chkboxIsVIP.Checked = customer.isVIP;
                    txtEmail.Text = customer.Email;
                    txtFullName.Text = customer.FullName;
                    txtPhoneNumber.Text = customer.PhoneNumber;
                    add_btn.Text = "SAVE";
                }
            }
            else
            {
                chkboxIsVIP.Checked = false;
                add_btn.Text = "ADD";
            }
        }

        private void refreshAddresses()
        {
            using (var ax = new MiniGramDBDataContext(Globals.ConnectionString))
            {
                List<TBLCUSTOMERS_ADDRESS> data = (from aj in ax.TBLCUSTOMERS_ADDRESSes where aj.CustomerID == CustomerID select aj).ToList();
                if (data.Count <= 0)
                {
                    btnEditSelectedAddress.Enabled = false;
                    return;
                }
                tBLCUSTOMERSADDRESSBindingSource.DataSource = data;
                dgvAddresses.Refresh();
            }
        }

        private void AddEditCustomerForm_Load(object sender, EventArgs e)
        {
            warning_lable.Visible = false;
            RefreshCustomerData();
        }

        private void AddNewCustomer()
        {


            TBLCUSTOMER customer = new TBLCUSTOMER();
            using (var ax = new MiniGramDBDataContext(Globals.ConnectionString))
            {
                customer.Email = txtEmail.Text;
                customer.FullName = txtFullName.Text;
                customer.PhoneNumber = txtPhoneNumber.Text;
                customer.isVIP = chkboxIsVIP.Checked;
                customer.Enabled = true;
                customer.dateCreated= DateTime.Now;
                ax.TBLCUSTOMERs.InsertOnSubmit(customer);
                ax.SubmitChanges();
                CustomerID = customer.ID;
            }
            this.Close();
        }

        private void SaveChange()
        {

            using (var ax = new MiniGramDBDataContext(Globals.ConnectionString))
            {
                TBLCUSTOMER customer = (from aj in ax.TBLCUSTOMERs where aj.ID == CustomerID select aj).SingleOrDefault();
                customer.Email = txtEmail.Text;
                customer.FullName = txtFullName.Text;
                customer.PhoneNumber = txtPhoneNumber.Text;
                customer.isVIP = chkboxIsVIP.Checked;
                ax.SubmitChanges();
            }
            this.Close();
        }

        private void keyboard_btn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = @"C:\Windows\System32\osk.exe";
            Process process = new Process();
            process.StartInfo = ps;
            process.Start();
            ActiveControl = txtFullName;
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddAddresses_Click(object sender, EventArgs e)
        {
            if (CustomerID == 0)
            {
                AddNewCustomer();
            }
                AddEditAddress aea = new AddEditAddress(0, CustomerID);
                aea.ShowDialog();
                refreshAddresses();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFullName.Text) || string.IsNullOrEmpty(txtPhoneNumber.Text) || dgvAddresses.Rows.Count <= 0)
            {
                warning_lable.Visible = true;
            }
            else
            {
                if (CustomerID == 0)
                {
                    AddNewCustomer();
                }
                else
                {
                    SaveChange();
                }
            }
        }

        private void chkboxIsVIP_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnEditSelectedAddress_Click(object sender, EventArgs e)
        {
            if (dgvAddresses.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Select Address From List First!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AddEditAddress aea = new AddEditAddress(0,CustomerID);
            aea.ShowDialog();
            refreshAddresses();
        }
    }
}
