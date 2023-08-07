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
            this.sp_selectReceiptsDetailsResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deliveryInReportViewerA4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_selectDeliveryReceiptsDetailsResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewerA4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewerMini = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_selectReceiptsDetailsForReportMiniResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sp_selectReceiptsDetailsResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_selectDeliveryReceiptsDetailsResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_selectReceiptsDetailsForReportMiniResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_selectReceiptsDetailsResultBindingSource
            // 
            this.sp_selectReceiptsDetailsResultBindingSource.DataSource = typeof(MiniGram.LINQ.sp_selectReceiptsDetailsResult);
            // 
            // deliveryInReportViewerA4
            // 
            this.deliveryInReportViewerA4.LocalReport.ReportEmbeddedResource = "MiniGram.Forms.Reports.RDLC.rptDeliveryIn.rdlc";
            this.deliveryInReportViewerA4.Location = new System.Drawing.Point(357, 313);
            this.deliveryInReportViewerA4.Name = "deliveryInReportViewerA4";
            this.deliveryInReportViewerA4.ServerReport.BearerToken = null;
            this.deliveryInReportViewerA4.Size = new System.Drawing.Size(396, 246);
            this.deliveryInReportViewerA4.TabIndex = 3;
            // 
            // sp_selectDeliveryReceiptsDetailsResultBindingSource
            // 
            this.sp_selectDeliveryReceiptsDetailsResultBindingSource.DataSource = typeof(MiniGram.LINQ.sp_selectDeliveryReceiptsDetailsResult);
            // 
            // reportViewerA4
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = null;
            this.reportViewerA4.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerA4.LocalReport.ReportEmbeddedResource = "MiniGram.Forms.Reports.RDLC.DirectReceiptReport.rdlc";
            this.reportViewerA4.Location = new System.Drawing.Point(12, 21);
            this.reportViewerA4.Name = "reportViewerA4";
            this.reportViewerA4.ServerReport.BearerToken = null;
            this.reportViewerA4.Size = new System.Drawing.Size(339, 246);
            this.reportViewerA4.TabIndex = 4;
            // 
            // reportViewerMini
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.sp_selectReceiptsDetailsForReportMiniResultBindingSource;
            this.reportViewerMini.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerMini.LocalReport.ReportEmbeddedResource = "MiniGram.Forms.Reports.RDLC.DirectReceiptReportMini.rdlc";
            this.reportViewerMini.Location = new System.Drawing.Point(357, 36);
            this.reportViewerMini.Name = "reportViewerMini";
            this.reportViewerMini.ServerReport.BearerToken = null;
            this.reportViewerMini.Size = new System.Drawing.Size(396, 246);
            this.reportViewerMini.TabIndex = 5;
            // 
            // sp_selectReceiptsDetailsForReportMiniResultBindingSource
            // 
            this.sp_selectReceiptsDetailsForReportMiniResultBindingSource.DataSource = typeof(MiniGram.LINQ.sp_selectReceiptsDetailsForReportMiniResult);
            // 
            // DirectReceiptReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 567);
            this.Controls.Add(this.reportViewerMini);
            this.Controls.Add(this.reportViewerA4);
            this.Controls.Add(this.deliveryInReportViewerA4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DirectReceiptReportViewer";
            this.Text = "DirectReceiptReportViewer";
            this.Load += new System.EventHandler(this.DirectReceiptReportViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_selectReceiptsDetailsResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_selectDeliveryReceiptsDetailsResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_selectReceiptsDetailsForReportMiniResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource sp_selectDeliveryReceiptsDetailsResultBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer deliveryInReportViewerA4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerA4;
        private System.Windows.Forms.BindingSource sp_selectReceiptsDetailsResultBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerMini;
        private System.Windows.Forms.BindingSource sp_selectReceiptsDetailsForReportMiniResultBindingSource;
    }
}