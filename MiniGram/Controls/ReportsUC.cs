using Microsoft.Reporting.WinForms;
using MiniGram.Classes;
using MiniGram.Controls.Reports;
using MiniGram.LINQ;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGram.Controls
{
    public partial class ReportsUC : UserControl
    {

        private Dictionary<int, string> ReportsDict; 
        private LocalReport report = new LocalReport();
        public ReportsUC()
        {
            InitializeComponent();
        }

        private void ReportsUC_Load(object sender, EventArgs e)
        {
            panelFromDate.Visible = true;
            panelToDate.Visible = true;
            ResetFiltersStatus();
            Init();
        }

        private void Init()
        {
            ReportsDict = new Dictionary<int, string>();
            ReportsDict.Add(-1, "Select Report");
            ReportsDict.Add(1, "Expired Date Report");
            ReportsDict.Add(2, "Daily Cash Report");
            ReportsDict.Add(3, "Sales Products Count Report");
            ReportsDict.Add(4, "Products List Report");
            cboxReportType.DataSource = new BindingSource(ReportsDict, null);
            cboxReportType.ValueMember = "Key";
            cboxReportType.DisplayMember = "Value";
            dtpFrom.Value = DateTime.Today.AddMonths(-1);
            dtpTo.Value = DateTime.Today;
        }

        private void switchControl(Control control)
        {
            ResetFiltersStatus();
            reportMainPanel.Controls.Clear();
            reportMainPanel.Controls.Add(control);
        }

        private void ResetFiltersStatus()
        {

            mainTable.ColumnStyles[1].SizeType = SizeType.Absolute;
            mainTable.ColumnStyles[1].Width = 0;
            mainTable.ColumnStyles[2].SizeType = SizeType.Absolute;
            mainTable.ColumnStyles[2].Width = 0;
            panelBarcode.Visible = false;
            panelPName.Visible = false;
            panelSupplier.Visible = false;
        }


        private void cboxReportType_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboxReportType.SelectedValue.Equals(1))
            {
                ProductsExpDateReportUC productsExpDateReportUC = new ProductsExpDateReportUC();
                productsExpDateReportUC.Dock = DockStyle.Fill;
                switchControl(productsExpDateReportUC);
                report = productsExpDateReportUC.reportViewer1.LocalReport;
            }
            else if (cboxReportType.SelectedValue.Equals(2))
            {
                DailyCashReportUC dailyCashReport = new DailyCashReportUC(dtpFrom.Value,dtpTo.Value);
                dailyCashReport.Dock = DockStyle.Fill;
                switchControl(dailyCashReport);
                mainTable.ColumnStyles[1].SizeType = SizeType.Absolute;
                mainTable.ColumnStyles[1].Width = 250;
                mainTable.ColumnStyles[2].SizeType = SizeType.Absolute;
                mainTable.ColumnStyles[2].Width = 250;
                report = dailyCashReport.reportViewer1.LocalReport;
            }
            else if (cboxReportType.SelectedValue.Equals(3))
            {
                ProductsCountOfSalesByDateUC salesByDateUC = new ProductsCountOfSalesByDateUC(dtpFrom.Value, dtpTo.Value);
                salesByDateUC.Dock = DockStyle.Fill;
                switchControl(salesByDateUC);
                mainTable.ColumnStyles[1].SizeType = SizeType.Absolute;
                mainTable.ColumnStyles[1].Width = 250;
                mainTable.ColumnStyles[2].SizeType = SizeType.Absolute;
                mainTable.ColumnStyles[2].Width = 250;
                report = salesByDateUC.reportViewer1.LocalReport;
            }
            else if (cboxReportType.SelectedValue.Equals(4))
            {

                ProductListReportUC productList = new ProductListReportUC(txtBarcode.Text, txtPName.Text, txtSupplier.Text, null, null);
                productList.Dock = DockStyle.Fill;
                switchControl(productList);
                panelBarcode.Visible = true;
                panelPName.Visible = true;
                panelSupplier.Visible = true;
                report = productList.reportViewer1.LocalReport;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cboxReportType_SelectedValueChanged(null, null);
        }

        private void chkHasExpDate_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkHasQte_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSupplier_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                DirectPrintClassLandscape dpc = new DirectPrintClassLandscape();
                dpc.Run(report);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Can't Print This Report, Please Contact Support !!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
        }

        private void btnToday_Click(object sender, EventArgs e)
        {

        }

        private void dtpTo_Click(object sender, EventArgs e)
        {

        }

        private void dtpFrom_Click(object sender, EventArgs e)
        {

        }

        private void reportMainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
