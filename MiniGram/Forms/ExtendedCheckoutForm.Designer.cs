
namespace MiniGram.Forms
{
    partial class ExtendedCheckoutForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new Syncfusion.WinForms.Controls.SfButton();
            this.checkout_btn = new Syncfusion.WinForms.Controls.SfButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustomerDollar = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtCustomerLBP = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtRestDollar = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtRestLBP = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerDollar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerLBP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRestDollar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRestLBP)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 380);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkout_btn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(380, 380);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleName = "Button";
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancel.CanOverrideStyle = true;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancel.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancel.ImageMargin = new System.Windows.Forms.Padding(0);
            this.btnCancel.ImageSize = new System.Drawing.Size(40, 40);
            this.btnCancel.Location = new System.Drawing.Point(345, 0);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(35, 30);
            this.btnCancel.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnCancel.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnCancel.Style.FocusedForeColor = System.Drawing.Color.White;
            this.btnCancel.Style.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.btnCancel.Style.HoverForeColor = System.Drawing.Color.White;
            this.btnCancel.Style.HoverImageForeColor = System.Drawing.Color.Empty;
            this.btnCancel.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.btnCancel.Style.PressedForeColor = System.Drawing.Color.White;
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "X";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.btnCancel.TextMargin = new System.Windows.Forms.Padding(0);
            this.btnCancel.ThemeName = "Office2016Colorful";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // checkout_btn
            // 
            this.checkout_btn.AccessibleName = "Button";
            this.checkout_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.checkout_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checkout_btn.CanOverrideStyle = true;
            this.checkout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkout_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkout_btn.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkout_btn.ForeColor = System.Drawing.Color.White;
            this.checkout_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkout_btn.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checkout_btn.ImageMargin = new System.Windows.Forms.Padding(0);
            this.checkout_btn.ImageSize = new System.Drawing.Size(40, 40);
            this.checkout_btn.Location = new System.Drawing.Point(0, 320);
            this.checkout_btn.Margin = new System.Windows.Forms.Padding(0);
            this.checkout_btn.Name = "checkout_btn";
            this.checkout_btn.Size = new System.Drawing.Size(380, 60);
            this.checkout_btn.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.checkout_btn.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.checkout_btn.Style.FocusedForeColor = System.Drawing.Color.White;
            this.checkout_btn.Style.ForeColor = System.Drawing.Color.White;
            this.checkout_btn.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.checkout_btn.Style.HoverForeColor = System.Drawing.Color.White;
            this.checkout_btn.Style.HoverImageForeColor = System.Drawing.Color.Empty;
            this.checkout_btn.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.checkout_btn.Style.PressedForeColor = System.Drawing.Color.White;
            this.checkout_btn.TabIndex = 19;
            this.checkout_btn.Text = "CHECKOUT";
            this.checkout_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.checkout_btn.TextMargin = new System.Windows.Forms.Padding(0);
            this.checkout_btn.ThemeName = "Office2016Colorful";
            this.checkout_btn.UseVisualStyleBackColor = true;
            this.checkout_btn.Click += new System.EventHandler(this.checkout_btn_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtCustomerDollar, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtCustomerLBP, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtRestDollar, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.txtRestLBP, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 7);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 33);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 9;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(374, 284);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(15, 2, 5, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 33);
            this.label4.TabIndex = 38;
            this.label4.Text = "Customer ($) :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCustomerDollar
            // 
            this.txtCustomerDollar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtCustomerDollar.BeforeTouchSize = new System.Drawing.Size(187, 30);
            this.txtCustomerDollar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtCustomerDollar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerDollar.CanOverrideStyle = true;
            this.txtCustomerDollar.CornerRadius = 2;
            this.txtCustomerDollar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtCustomerDollar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCustomerDollar.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtCustomerDollar.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerDollar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtCustomerDollar.Location = new System.Drawing.Point(187, 34);
            this.txtCustomerDollar.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.txtCustomerDollar.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtCustomerDollar.MinimumSize = new System.Drawing.Size(34, 30);
            this.txtCustomerDollar.Name = "txtCustomerDollar";
            this.txtCustomerDollar.Size = new System.Drawing.Size(187, 30);
            this.txtCustomerDollar.TabIndex = 37;
            this.txtCustomerDollar.Text = "0.0 $";
            this.txtCustomerDollar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCustomerDollar.ThemeName = "Default";
            this.txtCustomerDollar.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtCustomerDollar.ThemeStyle.CornerRadius = 5;
            this.txtCustomerDollar.ThemeStyle.DisabledBackColor = System.Drawing.Color.Gray;
            this.txtCustomerDollar.ThemeStyle.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.txtCustomerDollar.ThemeStyle.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.txtCustomerDollar.ThemeStyle.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.txtCustomerDollar.ThemeStyle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerDollar.ThemeStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtCustomerDollar.ThemeStyle.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.txtCustomerDollar.UseBorderColorOnFocus = true;
            this.txtCustomerDollar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerDollar_KeyPress);
            this.txtCustomerDollar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCustomerDollar_KeyUp);
            // 
            // txtCustomerLBP
            // 
            this.txtCustomerLBP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtCustomerLBP.BeforeTouchSize = new System.Drawing.Size(187, 30);
            this.txtCustomerLBP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtCustomerLBP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerLBP.CanOverrideStyle = true;
            this.txtCustomerLBP.CornerRadius = 2;
            this.txtCustomerLBP.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtCustomerLBP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCustomerLBP.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtCustomerLBP.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerLBP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtCustomerLBP.Location = new System.Drawing.Point(187, 94);
            this.txtCustomerLBP.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.txtCustomerLBP.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtCustomerLBP.MinimumSize = new System.Drawing.Size(34, 30);
            this.txtCustomerLBP.Name = "txtCustomerLBP";
            this.txtCustomerLBP.Size = new System.Drawing.Size(187, 30);
            this.txtCustomerLBP.TabIndex = 31;
            this.txtCustomerLBP.Text = "0 LBP";
            this.txtCustomerLBP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCustomerLBP.ThemeName = "Default";
            this.txtCustomerLBP.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtCustomerLBP.ThemeStyle.CornerRadius = 5;
            this.txtCustomerLBP.ThemeStyle.DisabledBackColor = System.Drawing.Color.Gray;
            this.txtCustomerLBP.ThemeStyle.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.txtCustomerLBP.ThemeStyle.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.txtCustomerLBP.ThemeStyle.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.txtCustomerLBP.ThemeStyle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerLBP.ThemeStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtCustomerLBP.ThemeStyle.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.txtCustomerLBP.UseBorderColorOnFocus = true;
            this.txtCustomerLBP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerLBP_KeyPress);
            this.txtCustomerLBP.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCustomerLBP_KeyUp);
            // 
            // txtRestDollar
            // 
            this.txtRestDollar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtRestDollar.BeforeTouchSize = new System.Drawing.Size(187, 30);
            this.txtRestDollar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtRestDollar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRestDollar.CanOverrideStyle = true;
            this.txtRestDollar.CornerRadius = 2;
            this.txtRestDollar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtRestDollar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRestDollar.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtRestDollar.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRestDollar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtRestDollar.Location = new System.Drawing.Point(187, 154);
            this.txtRestDollar.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.txtRestDollar.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtRestDollar.MinimumSize = new System.Drawing.Size(34, 30);
            this.txtRestDollar.Name = "txtRestDollar";
            this.txtRestDollar.ReadOnly = true;
            this.txtRestDollar.Size = new System.Drawing.Size(187, 30);
            this.txtRestDollar.TabIndex = 32;
            this.txtRestDollar.Text = "0.0 $";
            this.txtRestDollar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRestDollar.ThemeName = "Default";
            this.txtRestDollar.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtRestDollar.ThemeStyle.CornerRadius = 5;
            this.txtRestDollar.ThemeStyle.DisabledBackColor = System.Drawing.Color.Gray;
            this.txtRestDollar.ThemeStyle.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.txtRestDollar.ThemeStyle.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.txtRestDollar.ThemeStyle.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.txtRestDollar.ThemeStyle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRestDollar.ThemeStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtRestDollar.ThemeStyle.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.txtRestDollar.UseBorderColorOnFocus = true;
            this.txtRestDollar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtRestDollar_KeyUp);
            // 
            // txtRestLBP
            // 
            this.txtRestLBP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtRestLBP.BeforeTouchSize = new System.Drawing.Size(187, 30);
            this.txtRestLBP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtRestLBP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRestLBP.CanOverrideStyle = true;
            this.txtRestLBP.CornerRadius = 2;
            this.txtRestLBP.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtRestLBP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRestLBP.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtRestLBP.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRestLBP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtRestLBP.Location = new System.Drawing.Point(187, 214);
            this.txtRestLBP.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.txtRestLBP.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtRestLBP.MinimumSize = new System.Drawing.Size(34, 30);
            this.txtRestLBP.Name = "txtRestLBP";
            this.txtRestLBP.ReadOnly = true;
            this.txtRestLBP.Size = new System.Drawing.Size(187, 30);
            this.txtRestLBP.TabIndex = 33;
            this.txtRestLBP.Text = "0 LBP";
            this.txtRestLBP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRestLBP.ThemeName = "Default";
            this.txtRestLBP.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtRestLBP.ThemeStyle.CornerRadius = 5;
            this.txtRestLBP.ThemeStyle.DisabledBackColor = System.Drawing.Color.Gray;
            this.txtRestLBP.ThemeStyle.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.txtRestLBP.ThemeStyle.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.txtRestLBP.ThemeStyle.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.txtRestLBP.ThemeStyle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRestLBP.ThemeStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtRestLBP.ThemeStyle.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.txtRestLBP.UseBorderColorOnFocus = true;
            this.txtRestLBP.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtRestLBP_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(15, 2, 5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 33);
            this.label1.TabIndex = 34;
            this.label1.Text = "Customer (LBP) :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(15, 2, 5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 33);
            this.label2.TabIndex = 35;
            this.label2.Text = "Rest ($) :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(15, 2, 5, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 33);
            this.label3.TabIndex = 36;
            this.label3.Text = "Rest (LBP) :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ExtendedCheckoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExtendedCheckoutForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExtendedCheckoutForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ExtendedCheckoutForm_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerDollar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerLBP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRestDollar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRestLBP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Syncfusion.WinForms.Controls.SfButton checkout_btn;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtCustomerLBP;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtRestDollar;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtRestLBP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtCustomerDollar;
        private Syncfusion.WinForms.Controls.SfButton btnCancel;
    }
}