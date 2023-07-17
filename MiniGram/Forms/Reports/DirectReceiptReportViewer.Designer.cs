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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectReceiptReportViewer));
            this.spselectReceiptsDetailsResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_selectDeliveryReceiptsDetailsResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewerA4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewerMini = new Microsoft.Reporting.WinForms.ReportViewer();
            this.deliveryInReportViewerA4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.deliveryInReportViewerMini = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.spselectReceiptsDetailsResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_selectDeliveryReceiptsDetailsResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // spselectReceiptsDetailsResultBindingSource
            // 
            this.spselectReceiptsDetailsResultBindingSource.DataSource = typeof(MiniGram.LINQ.sp_selectReceiptsDetailsResult);
            // 
            // sp_selectDeliveryReceiptsDetailsResultBindingSource
            // 
            this.sp_selectDeliveryReceiptsDetailsResultBindingSource.DataSource = typeof(MiniGram.LINQ.sp_selectDeliveryReceiptsDetailsResult);
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
            this.reportViewerMini.LocalReport.ReportEmbeddedResource = "MiniGram.Reports.DirectReceiptReportMini.rdlc";
            this.reportViewerMini.Location = new System.Drawing.Point(357, 0);
            this.reportViewerMini.Name = "reportViewerMini";
            this.reportViewerMini.ServerReport.BearerToken = null;
            this.reportViewerMini.Size = new System.Drawing.Size(396, 246);
            this.reportViewerMini.TabIndex = 1;
            this.reportViewerMini.Visible = false;
            // 
            // deliveryInReportViewerA4
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.sp_selectDeliveryReceiptsDetailsResultBindingSource;
            this.deliveryInReportViewerA4.LocalReport.DataSources.Add(reportDataSource2);
            this.deliveryInReportViewerA4.LocalReport.ReportEmbeddedResource = "MiniGram.Forms.Reports.RDLC.rptDeliveryIn.rdlc";
            this.deliveryInReportViewerA4.Location = new System.Drawing.Point(0, 313);
            this.deliveryInReportViewerA4.Name = "deliveryInReportViewerA4";
            this.deliveryInReportViewerA4.ServerReport.BearerToken = null;
            this.deliveryInReportViewerA4.Size = new System.Drawing.Size(351, 246);
            this.deliveryInReportViewerA4.TabIndex = 2;
            // 
            // deliveryInReportViewerMini
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.sp_selectDeliveryReceiptsDetailsResultBindingSource;
            this.deliveryInReportViewerMini.LocalReport.DataSources.Add(reportDataSource3);
            this.deliveryInReportViewerMini.LocalReport.ReportEmbeddedResource = "MiniGram.Forms.Reports.RDLC.rptDeliveryIn.rdlc";
            this.deliveryInReportViewerMini.Location = new System.Drawing.Point(357, 277);
            this.deliveryInReportViewerMini.Name = "deliveryInReportViewerMini";
            this.deliveryInReportViewerMini.ServerReport.BearerToken = null;
            this.deliveryInReportViewerMini.Size = new System.Drawing.Size(396, 246);
            this.deliveryInReportViewerMini.TabIndex = 3;
            // 
            // DirectReceiptReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 567);
            this.Controls.Add(this.deliveryInReportViewerMini);
            this.Controls.Add(this.deliveryInReportViewerA4);
            this.Controls.Add(this.reportViewerMini);
            this.Controls.Add(this.reportViewerA4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DirectReceiptReportViewer";
            this.Text = "DirectReceiptReportViewer";
            this.Load += new System.EventHandler(this.DirectReceiptReportViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spselectReceiptsDetailsResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_selectDeliveryReceiptsDetailsResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerA4;
        private System.Windows.Forms.BindingSource spselectReceiptsDetailsResultBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerMini;
        private Microsoft.Reporting.WinForms.ReportViewer deliveryInReportViewerA4;
        private System.Windows.Forms.BindingSource sp_selectDeliveryReceiptsDetailsResultBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer deliveryInReportViewerMini;
    }
}