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
    public partial class AddSupplierForm : Form
    {
        public AddSupplierForm()
        {
            InitializeComponent();
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

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddSupplierForm_Load(object sender, EventArgs e)
        {
            warning_lable.Visible = false;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(suppname_txt.Text) || string.IsNullOrEmpty(phone_txt.Text) || string.IsNullOrEmpty(add1_txt.Text))
            {
                warning_lable.Visible = true;
            }
            else
            {
                using (var cnx = new MiniGramDBDataContext())
                {
                    cnx.sp_addNewSupplier(suppname_txt.Text, phone_txt.Text, email_txt.Text, add1_txt.Text, add2_txt.Text);
                    this.Close();
                }
            }
        }
    }
}
