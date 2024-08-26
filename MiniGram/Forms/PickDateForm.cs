using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniGram.LINQ;

namespace MiniGram.Forms
{
    public partial class PickDateForm : Form
    {
        private TBLEXPIREDDATE expDate;
        private int pid;

        public PickDateForm(int pid,TBLEXPIREDDATE expDate)
        {
            this.pid = pid;
            this.expDate = expDate != null ? expDate : new TBLEXPIREDDATE();
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (date.SelectedDate != null && !string.IsNullOrEmpty(txtQte.Text))
            {
                using(var ax = new MiniGramDBDataContext(Globals.ConnectionString))
                {
                    if (expDate != null && expDate.ID != 0)
                    {
                        expDate = (from aj in ax.TBLEXPIREDDATEs where aj.ID == expDate.ID select aj).SingleOrDefault();
                        expDate.ExpiredDate = date.SelectedDate.Value.Date;
                        expDate.Qte = int.Parse(txtQte.Text);
                    }
                    else
                    {
                        expDate.PID = pid;
                        expDate.ExpiredDate = date.SelectedDate.Value.Date;
                        expDate.dateCreated = DateTime.Now;
                        expDate.Qte = int.Parse(txtQte.Text);
                        ax.TBLEXPIREDDATEs.InsertOnSubmit(expDate);
                    }
                    ax.SubmitChanges();
                }
                Close();
            }
            else
            {
                MessageBox.Show("Some Information is Missing !!","Error!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
        }

        private void PickDateForm_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            LoadData();
        }

        private void LoadData()
        {
            if (expDate != null)
            {
                date.SelectedDate = expDate.ExpiredDate;
                txtQte.Text = expDate.Qte.ToString();
            }
            else
            {
                date.SelectedDate = DateTime.Now;
                txtQte.Text = "0";
            }

            this.ActiveControl = txtQte;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtQte_TextChanged(object sender, EventArgs e)
        {
            if (!Globals.IsNumeric(txtQte.Text))
                txtQte.Text = "";
        }
    }
}
