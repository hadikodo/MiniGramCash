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
            panelHasQte.Visible = false;
            panelHasExpDate.Visible = false;
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

                int? hasExpDate = null;
                bool? hasQte = null;

                if (chkHasExpDate.CheckState == CheckState.Checked)
                    hasExpDate = 1;
                else if(chkHasExpDate.CheckState == CheckState.Unchecked)
                    hasExpDate = 0;

                if (chkHasQte.CheckState == CheckState.Checked)
                    hasQte = true; 
                else if (chkHasQte.CheckState == CheckState.Unchecked)
                    hasQte = false;

                ProductListReportUC productList = new ProductListReportUC(txtBarcode.Text, txtPName.Text, txtSupplier.Text, hasQte, hasExpDate);
                productList.Dock = DockStyle.Fill;
                switchControl(productList);
                panelBarcode.Visible = true;
                panelPName.Visible = true;
                panelSupplier.Visible = true;
                panelHasQte.Visible = true;
                panelHasExpDate.Visible = true;
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
                DirectPrintClass dpc = new DirectPrintClass();
                dpc.Run(report);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Can't Print This Report, Please Contact Support !!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
        }
    }
}
