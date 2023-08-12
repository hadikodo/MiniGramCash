﻿namespace MiniGram.Forms
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
            this.sp_selectReceiptsDetailsResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spselectReceiptsDetailsResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewerA4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewerMini = new Microsoft.Reporting.WinForms.ReportViewer();
            this.deliveryInReportViewerA4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spselectDeliveryReceiptsDetailsResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sp_selectReceiptsDetailsResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spselectReceiptsDetailsResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spselectDeliveryReceiptsDetailsResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_selectReceiptsDetailsResultBindingSource
            // 
            this.sp_selectReceiptsDetailsResultBindingSource.DataSource = typeof(MiniGram.LINQ.sp_selectReceiptsDetailsResult);
            // 
            // spselectReceiptsDetailsResultBindingSource
            // 
            this.spselectReceiptsDetailsResultBindingSource.DataSource = typeof(MiniGram.LINQ.sp_selectReceiptsDetailsResult);
            // 
            // reportViewerA4
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sp_selectReceiptsDetailsResultBindingSource;
            this.reportViewerA4.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerA4.LocalReport.ReportEmbeddedResource = "MiniGram.Forms.Reports.RDLC.DirectReceiptReport.rdlc";
            this.reportViewerA4.Location = new System.Drawing.Point(12, 12);
            this.reportViewerA4.Name = "reportViewerA4";
            this.reportViewerA4.ServerReport.BearerToken = null;
            this.reportViewerA4.Size = new System.Drawing.Size(308, 246);
            this.reportViewerA4.TabIndex = 4;
            // 
            // reportViewerMini
            // 
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.sp_selectReceiptsDetailsResultBindingSource;
            this.reportViewerMini.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerMini.LocalReport.ReportEmbeddedResource = "MiniGram.Forms.Reports.RDLC.DirectReceiptReportMini.rdlc";
            this.reportViewerMini.Location = new System.Drawing.Point(378, 21);
            this.reportViewerMini.Name = "reportViewerMini";
            this.reportViewerMini.ServerReport.BearerToken = null;
            this.reportViewerMini.Size = new System.Drawing.Size(308, 246);
            this.reportViewerMini.TabIndex = 5;
            // 
            // deliveryInReportViewerA4
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.spselectDeliveryReceiptsDetailsResultBindingSource;
            this.deliveryInReportViewerA4.LocalReport.DataSources.Add(reportDataSource3);
            this.deliveryInReportViewerA4.LocalReport.ReportEmbeddedResource = "MiniGram.Forms.Reports.RDLC.rptDeliveryInNew.rdlc";
            this.deliveryInReportViewerA4.Location = new System.Drawing.Point(256, 290);
            this.deliveryInReportViewerA4.Name = "deliveryInReportViewerA4";
            this.deliveryInReportViewerA4.ServerReport.BearerToken = null;
            this.deliveryInReportViewerA4.Size = new System.Drawing.Size(396, 246);
            this.deliveryInReportViewerA4.TabIndex = 6;
            // 
            // spselectDeliveryReceiptsDetailsResultBindingSource
            // 
            this.spselectDeliveryReceiptsDetailsResultBindingSource.DataSource = typeof(MiniGram.LINQ.sp_selectDeliveryReceiptsDetailsResult);
            // 
            // DirectReceiptReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 567);
            this.Controls.Add(this.deliveryInReportViewerA4);
            this.Controls.Add(this.reportViewerMini);
            this.Controls.Add(this.reportViewerA4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DirectReceiptReportViewer";
            this.Text = "DirectReceiptReportViewer";
            this.Load += new System.EventHandler(this.DirectReceiptReportViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_selectReceiptsDetailsResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spselectReceiptsDetailsResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spselectDeliveryReceiptsDetailsResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource spselectReceiptsDetailsResultBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerA4;
        private System.Windows.Forms.BindingSource sp_selectReceiptsDetailsResultBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerMini;
        private Microsoft.Reporting.WinForms.ReportViewer deliveryInReportViewerA4;
        private System.Windows.Forms.BindingSource spselectDeliveryReceiptsDetailsResultBindingSource;
    }
}