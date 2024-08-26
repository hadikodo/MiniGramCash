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
        private int pid;
        private TBLPRODUCT product = new TBLPRODUCT();
        public List<TBLEXPIREDDATE> expDateList;

        public ExpiredDateForm(int pid, List<TBLEXPIREDDATE> expDateList)
        {
            this.pid = pid;
            this.expDateList = expDateList;

            InitializeComponent();
        }

        private void ExpiredDateForm_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            product = LoadProduct(pid);
            lblProductTitle.Text = product.PNAME;

            if (pid != 0)
            {
                refreshData();
            }
        }

        private TBLPRODUCT LoadProduct(int pid)
        {
            TBLPRODUCT product = new TBLPRODUCT();

            if (pid == 0)
                return product;

            using(var ax = new MiniGramDBDataContext(Globals.ConnectionString))
            {
                product = (from aj in ax.TBLPRODUCTs where aj.PID == pid select aj).SingleOrDefault();
            }

            return product;
        }

        private void refreshData()
        {
            using(var ax =new MiniGramDBDataContext(Globals.ConnectionString))
            {
                tBLEXPIREDDATEBindingSource.DataSource = (from aj in ax.TBLEXPIREDDATEs where aj.PID == pid select aj).ToList();
            }

            foreach(DataGridViewRow row in dgvExpiredDates.Rows)
            {
                if (DateTime.Parse(row.Cells[0].Value.ToString()).Date <= DateTime.Today.Date)
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
            PickDateForm frm = new PickDateForm(product.PID,null);
            frm.ShowDialog();
            refreshData();
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
                    }
                    refreshData();
                }
            }
        }

        private void dgvExpiredDates_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TBLEXPIREDDATE selectedExpDate = (TBLEXPIREDDATE)tBLEXPIREDDATEBindingSource.Current;
            PickDateForm frm = new PickDateForm(product.PID, selectedExpDate);
            frm.ShowDialog();
            refreshData();
        }
    }
}
