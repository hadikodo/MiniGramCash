namespace MiniGram.Forms
{
    partial class DirectReceiptReportViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectReceiptReportViewer));
            this.spselectReceiptsDetailsResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewerA4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewerMini = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.spselectReceiptsDetailsResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // spselectReceiptsDetailsResultBindingSource
            // 
            this.spselectReceiptsDetailsResultBindingSource.DataSource = typeof(MiniGram.LINQ.sp_selectReceiptsDetailsResult);
            // 
            // reportViewerA4
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spselectReceiptsDetailsResultBindingSource;
            this.reportViewerA4.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerA4.LocalReport.ReportEmbeddedResource = "MiniGram.Reports.DirectReceiptReport.rdlc";
            this.reportViewerA4.Location = new System.Drawing.Point(0, 0);
            this.reportViewerA4.Name = "reportViewerA4";
            this.reportViewerA4.ServerReport.BearerToken = null;
            this.reportViewerA4.Size = new System.Drawing.Size(351, 307);
            this.reportViewerA4.TabIndex = 0;
            this.reportViewerA4.Visible = false;
            // 
            // reportViewerMini
            // 
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.spselectReceiptsDetailsResultBindingSource;
            this.reportViewerMini.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerMini.LocalReport.ReportEmbeddedResource = "MiniGram.Reports.DirectReceiptReportMini.rdlc";
            this.reportViewerMini.Location = new System.Drawing.Point(357, 0);
            this.reportViewerMini.Name = "reportViewerMini";
            this.reportViewerMini.ServerReport.BearerToken = null;
            this.reportViewerMini.Size = new System.Drawing.Size(396, 246);
            this.reportViewerMini.TabIndex = 1;
            this.reportViewerMini.Visible = false;
            // 
            // DirectReceiptReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 702);
            this.Controls.Add(this.reportViewerMini);
            this.Controls.Add(this.reportViewerA4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DirectReceiptReportViewer";
            this.Text = "DirectReceiptReportViewer";
            this.Load += new System.EventHandler(this.DirectReceiptReportViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spselectReceiptsDetailsResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerA4;
        private System.Windows.Forms.BindingSource spselectReceiptsDetailsResultBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerMini;
    }
}