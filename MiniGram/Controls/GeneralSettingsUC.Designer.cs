namespace MiniGram.Controls
{
    partial class GeneralSettingsUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chkboxShowUnshowList = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxAdv1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboxReceiptSize = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.printer_drp = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dollar_price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkboxDisableReceiptPrnt = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkboxShowUnshowList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkboxDisableReceiptPrnt)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel3, 2);
            this.panel3.Controls.Add(this.chkboxDisableReceiptPrnt);
            this.panel3.Controls.Add(this.chkboxShowUnshowList);
            this.panel3.Controls.Add(this.checkBoxAdv1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(794, 219);
            this.panel3.TabIndex = 3;
            // 
            // chkboxShowUnshowList
            // 
            this.chkboxShowUnshowList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.chkboxShowUnshowList.BeforeTouchSize = new System.Drawing.Size(712, 51);
            this.chkboxShowUnshowList.BorderColor = System.Drawing.Color.Transparent;
            this.chkboxShowUnshowList.BorderSingle = System.Windows.Forms.ButtonBorderStyle.None;
            this.chkboxShowUnshowList.CheckedImage = global::MiniGram.Properties.Resources.accept;
            this.chkboxShowUnshowList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkboxShowUnshowList.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxShowUnshowList.ForeColor = System.Drawing.Color.White;
            this.chkboxShowUnshowList.GradientEnd = System.Drawing.Color.Transparent;
            this.chkboxShowUnshowList.GradientStart = System.Drawing.Color.Transparent;
            this.chkboxShowUnshowList.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.chkboxShowUnshowList.ImageCheckBox = true;
            this.chkboxShowUnshowList.ImageCheckBoxSize = new System.Drawing.Size(40, 40);
            this.chkboxShowUnshowList.Location = new System.Drawing.Point(29, 78);
            this.chkboxShowUnshowList.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.chkboxShowUnshowList.Name = "chkboxShowUnshowList";
            this.chkboxShowUnshowList.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.chkboxShowUnshowList.Size = new System.Drawing.Size(712, 51);
            this.chkboxShowUnshowList.TabIndex = 1;
            this.chkboxShowUnshowList.Text = "⩺ Show Items List in The Sale Page";
            this.chkboxShowUnshowList.TextShadow = true;
            this.chkboxShowUnshowList.ThemeName = "Default";
            this.chkboxShowUnshowList.ThemeStyle.BackColor = System.Drawing.Color.Transparent;
            this.chkboxShowUnshowList.ThemeStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxShowUnshowList.UncheckedImage = global::MiniGram.Properties.Resources._unchecked;
            // 
            // checkBoxAdv1
            // 
            this.checkBoxAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.checkBoxAdv1.BeforeTouchSize = new System.Drawing.Size(712, 51);
            this.checkBoxAdv1.BorderColor = System.Drawing.Color.Transparent;
            this.checkBoxAdv1.BorderSingle = System.Windows.Forms.ButtonBorderStyle.None;
            this.checkBoxAdv1.CheckedImage = global::MiniGram.Properties.Resources.accept;
            this.checkBoxAdv1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxAdv1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv1.ForeColor = System.Drawing.Color.White;
            this.checkBoxAdv1.GradientEnd = System.Drawing.Color.Transparent;
            this.checkBoxAdv1.GradientStart = System.Drawing.Color.Transparent;
            this.checkBoxAdv1.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.checkBoxAdv1.ImageCheckBox = true;
            this.checkBoxAdv1.ImageCheckBoxSize = new System.Drawing.Size(40, 40);
            this.checkBoxAdv1.Location = new System.Drawing.Point(29, 21);
            this.checkBoxAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.checkBoxAdv1.Name = "checkBoxAdv1";
            this.checkBoxAdv1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.checkBoxAdv1.Size = new System.Drawing.Size(712, 51);
            this.checkBoxAdv1.TabIndex = 0;
            this.checkBoxAdv1.Text = "⩺ Start MiniGram When Windows Start ";
            this.checkBoxAdv1.TextShadow = true;
            this.checkBoxAdv1.ThemeName = "Default";
            this.checkBoxAdv1.ThemeStyle.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxAdv1.ThemeStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv1.UncheckedImage = global::MiniGram.Properties.Resources._unchecked;
            this.checkBoxAdv1.CheckStateChanged += new System.EventHandler(this.checkBoxAdv1_CheckStateChanged);
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.cboxReceiptSize);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.printer_drp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 228);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 129);
            this.panel1.TabIndex = 3;
            // 
            // cboxReceiptSize
            // 
            this.cboxReceiptSize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboxReceiptSize.DropDownHeight = 300;
            this.cboxReceiptSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxReceiptSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.cboxReceiptSize.FormattingEnabled = true;
            this.cboxReceiptSize.IntegralHeight = false;
            this.cboxReceiptSize.Location = new System.Drawing.Point(254, 24);
            this.cboxReceiptSize.Margin = new System.Windows.Forms.Padding(0);
            this.cboxReceiptSize.MaxDropDownItems = 50;
            this.cboxReceiptSize.Name = "cboxReceiptSize";
            this.cboxReceiptSize.Size = new System.Drawing.Size(487, 37);
            this.cboxReceiptSize.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(24, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "Receipt Size :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Receipt Printer :";
            // 
            // printer_drp
            // 
            this.printer_drp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printer_drp.DropDownHeight = 300;
            this.printer_drp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printer_drp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.printer_drp.FormattingEnabled = true;
            this.printer_drp.IntegralHeight = false;
            this.printer_drp.Location = new System.Drawing.Point(254, 79);
            this.printer_drp.Margin = new System.Windows.Forms.Padding(0);
            this.printer_drp.MaxDropDownItems = 50;
            this.printer_drp.Name = "printer_drp";
            this.printer_drp.Size = new System.Drawing.Size(487, 37);
            this.printer_drp.TabIndex = 1;
            // 
            // panel2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel2, 2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dollar_price);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 363);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 84);
            this.panel2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(409, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "LBP";
            // 
            // dollar_price
            // 
            this.dollar_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dollar_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.dollar_price.Location = new System.Drawing.Point(253, 26);
            this.dollar_price.Name = "dollar_price";
            this.dollar_price.Size = new System.Drawing.Size(150, 35);
            this.dollar_price.TabIndex = 4;
            this.dollar_price.Text = "1500";
            this.dollar_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dollar_price.TextChanged += new System.EventHandler(this.dollar_price_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "$ To LBP Price :";
            // 
            // chkboxDisableReceiptPrnt
            // 
            this.chkboxDisableReceiptPrnt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.chkboxDisableReceiptPrnt.BeforeTouchSize = new System.Drawing.Size(712, 51);
            this.chkboxDisableReceiptPrnt.BorderColor = System.Drawing.Color.Transparent;
            this.chkboxDisableReceiptPrnt.BorderSingle = System.Windows.Forms.ButtonBorderStyle.None;
            this.chkboxDisableReceiptPrnt.CheckedImage = global::MiniGram.Properties.Resources.accept;
            this.chkboxDisableReceiptPrnt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkboxDisableReceiptPrnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxDisableReceiptPrnt.ForeColor = System.Drawing.Color.White;
            this.chkboxDisableReceiptPrnt.GradientEnd = System.Drawing.Color.Transparent;
            this.chkboxDisableReceiptPrnt.GradientStart = System.Drawing.Color.Transparent;
            this.chkboxDisableReceiptPrnt.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.chkboxDisableReceiptPrnt.ImageCheckBox = true;
            this.chkboxDisableReceiptPrnt.ImageCheckBoxSize = new System.Drawing.Size(40, 40);
            this.chkboxDisableReceiptPrnt.Location = new System.Drawing.Point(29, 135);
            this.chkboxDisableReceiptPrnt.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.chkboxDisableReceiptPrnt.Name = "chkboxDisableReceiptPrnt";
            this.chkboxDisableReceiptPrnt.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.chkboxDisableReceiptPrnt.Size = new System.Drawing.Size(712, 51);
            this.chkboxDisableReceiptPrnt.TabIndex = 2;
            this.chkboxDisableReceiptPrnt.Text = "⩺ Disable Receipt Printing On Checkout";
            this.chkboxDisableReceiptPrnt.TextShadow = true;
            this.chkboxDisableReceiptPrnt.ThemeName = "Default";
            this.chkboxDisableReceiptPrnt.ThemeStyle.BackColor = System.Drawing.Color.Transparent;
            this.chkboxDisableReceiptPrnt.ThemeStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxDisableReceiptPrnt.UncheckedImage = global::MiniGram.Properties.Resources._unchecked;
            this.chkboxDisableReceiptPrnt.CheckStateChanged += new System.EventHandler(this.chkboxDisableReceiptPrnt_CheckStateChanged);
            // 
            // GeneralSettingsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GeneralSettingsUC";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new System.EventHandler(this.GeneralSettingsUC_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkboxShowUnshowList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkboxDisableReceiptPrnt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxAdv1;
        private System.Windows.Forms.ComboBox printer_drp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dollar_price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboxReceiptSize;
        public Syncfusion.Windows.Forms.Tools.CheckBoxAdv chkboxShowUnshowList;
        public Syncfusion.Windows.Forms.Tools.CheckBoxAdv chkboxDisableReceiptPrnt;
    }
}
