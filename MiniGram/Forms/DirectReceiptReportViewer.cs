﻿using MiniGram.LINQ;
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
    public partial class DirectReceiptReportViewer : Form
    {
        private MiniGramDBDataContext data = new MiniGramDBDataContext();
        public int receiptID;       
        public DirectReceiptReportViewer()
        {
            InitializeComponent();
        }

        private void DirectReceiptReportViewer_Load(object sender, EventArgs e)
        {
            spselectReceiptsDetailsResultBindingSource.DataSource = data.sp_selectReceiptsDetails(receiptID);
            this.reportViewer1.RefreshReport();
            //reportViewer1.LocalReport
        }
    }
}
