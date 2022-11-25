using Syncfusion.Olap.MDXQueryParser;
using Syncfusion.Windows.Shared;
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
    public partial class PickDateForm : Form
    {
        public DateTime? selectedDate = null;
        public int? qte = null;
        public PickDateForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (date.SelectedDate != null && txtQte.Text != "")
            {
                selectedDate = date.SelectedDate;
                qte = Int32.Parse(txtQte.Text.Trim());
                this.Hide();
            }
            else
            {
                MessageBox.Show("Some Information is Missing !!","Error!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
        }

        private void PickDateForm_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
