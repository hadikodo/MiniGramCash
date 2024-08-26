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
    public partial class AddEditAddress : Form
    {

        private int addressID,CustomerId;

        public AddEditAddress(int id,int customerID)
        {
            this.addressID = id;
            this.CustomerId= customerID;
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void keyboard_btn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = @"C:\Windows\System32\osk.exe";
            Process process = new Process();
            process.StartInfo = ps;
            process.Start();
            ActiveControl = txtAddress;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Address Field Can't Be Empty!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = txtAddress;
                return;
            }
            using (var ax = new MiniGramDBDataContext(Globals.ConnectionString))
            {
                if (addressID == 0)
                {
                    TBLCUSTOMERS_ADDRESS address = new TBLCUSTOMERS_ADDRESS();
                    address.AddressDescription = txtAddress.Text;
                    address.CustomerID = CustomerId;
                    ax.TBLCUSTOMERS_ADDRESSes.InsertOnSubmit(address);
                    ax.SubmitChanges();
                }
                else
                {
                    TBLCUSTOMERS_ADDRESS address = (from aj in ax.TBLCUSTOMERS_ADDRESSes where aj.ID == addressID && aj.CustomerID == CustomerId select aj).SingleOrDefault();
                    address.AddressDescription = txtAddress.Text;
                    ax.SubmitChanges();
                }
            }
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Address Field Can't Be Empty!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = txtAddress;
                return;
            }
            if (MessageBox.Show("Are You Sure You Want To Delete This Address ??", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (var ax = new MiniGramDBDataContext(Globals.ConnectionString))
                {
                    TBLCUSTOMERS_ADDRESS address = (from aj in ax.TBLCUSTOMERS_ADDRESSes where aj.ID == addressID && aj.CustomerID==CustomerId select aj).SingleOrDefault();
                    ax.TBLCUSTOMERS_ADDRESSes.DeleteOnSubmit(address);
                    ax.SubmitChanges();
                }
                this.Close();
            }
        }

        private void AddEditAddress_Load(object sender, EventArgs e)
        {
            if (addressID != 0)
            {
                using (var ax = new MiniGramDBDataContext(Globals.ConnectionString))
                {
                    TBLCUSTOMERS_ADDRESS address = (from aj in ax.TBLCUSTOMERS_ADDRESSes where aj.ID == addressID && aj.CustomerID == CustomerId  select aj).SingleOrDefault();
                    txtAddress.Text = address.AddressDescription;
                }
            }
        }
    }
}
