using MiniGram.Classes;
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
    public partial class ExpiredDateForm : Form
    {
        private string productTitle;
        private int pid;
        public ExpiredDateForm(string title,int pid)
        {
            productTitle= title;
            this.pid = pid;
            InitializeComponent();
        }

        private void ExpiredDateForm_Load(object sender, EventArgs e)
        {
            lblProductTitle.Text = productTitle;
            if (pid != 0)
            {
                refreshData();
            }
        }

        private void refreshData()
        {
            using(var ax =new MiniGramDBDataContext(Globals.ConnectionString))
            {
                tBLEXPIREDDATEBindingSource.DataSource = (from aj in ax.TBLEXPIREDDATEs where aj.PID == pid select aj).ToList();
            }
            foreach(DataGridViewRow row in dgvExpiredDates.Rows)
            {
                if (DateTime.Parse(row.Cells[0].Value.ToString()) <= DateTime.Today)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    row.DefaultCellStyle.ForeColor = Color.White;
                    row.DefaultCellStyle.SelectionBackColor= Color.Red;
                    row.DefaultCellStyle.SelectionForeColor = Color.White;
                }
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new PickDateForm();
            frm.ShowDialog();
            if (frm.selectedDate != null && frm.qte != null)
            {
                using (var ax = new MiniGramDBDataContext(Globals.ConnectionString))
                {
                    var ExpList = (from aj in ax.TBLEXPIREDDATEs where aj.PID == pid select aj.ExpiredDate).ToList();

                    if (ExpList.Contains(frm.selectedDate.Value.Date))
                    {
                        TBLEXPIREDDATE currExpDate = (from aj in ax.TBLEXPIREDDATEs where aj.PID == pid && aj.ExpiredDate == frm.selectedDate.Value.Date select aj).Single();
                        currExpDate.Qte = currExpDate.Qte + Int32.Parse(frm.qte.ToString());
                    }
                    else
                    {
                        TBLEXPIREDDATE newExpDate = new TBLEXPIREDDATE();
                        newExpDate.ExpiredDate = frm.selectedDate;
                        newExpDate.Qte = (int)frm.qte;
                        newExpDate.dateCreated = DateTime.Now;
                        newExpDate.PID = pid;
                        ax.TBLEXPIREDDATEs.InsertOnSubmit(newExpDate);
                    }
                    ax.SubmitChanges();
                }
                refreshData();
            }
            else
            {
                MessageBox.Show("Some Information is Missing!!", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void dgvExpiredDates_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == deleteCol.Index)
            {
                if(MessageBox.Show("Are You Sure You Want Delete This Expired Date ??","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using (var data = new MiniGramDBDataContext(Globals.ConnectionString))
                    {
                        TBLEXPIREDDATE selected = (TBLEXPIREDDATE)tBLEXPIREDDATEBindingSource.Current;
                        var expd = (from aj in data.TBLEXPIREDDATEs where aj.ID == selected.ID select aj).Single();
                        data.TBLEXPIREDDATEs.DeleteOnSubmit(expd);
                        data.SubmitChanges();
                        refreshData();
                    }
                }
            }
        }
    }
}
