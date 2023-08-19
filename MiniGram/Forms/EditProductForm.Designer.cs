﻿namespace MiniGram.Forms
{
    partial class EditProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProductForm));
            this.panel3 = new System.Windows.Forms.Panel();
            this.logo_img = new System.Windows.Forms.PictureBox();
            this.exit_btn = new System.Windows.Forms.Button();
            this.keyboard_btn = new Syncfusion.WinForms.Controls.SfButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.warning_lable = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtSecondaryPrice = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiscountPercentage = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.chkboxHasDiscount = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.productname_txt = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.barcode_txt = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExpiredDate = new System.Windows.Forms.Button();
            this.checkBoxHasExpDate = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.textTVADesc = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label2 = new System.Windows.Forms.Label();
            this.chkboxHasQte = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.chkboxHasTVA = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.quantity_txt = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label5 = new System.Windows.Forms.Label();
            this.sell_price_txt = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label7 = new System.Windows.Forms.Label();
            this.supp_cbox = new System.Windows.Forms.ComboBox();
            this.label_2031 = new System.Windows.Forms.Label();
            this.init_price_txt = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_img)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSecondaryPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscountPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkboxHasDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productname_txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcode_txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxHasExpDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTVADesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkboxHasQte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkboxHasTVA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sell_price_txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.init_price_txt)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.logo_img);
            this.panel3.Controls.Add(this.exit_btn);
            this.panel3.Controls.Add(this.keyboard_btn);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1031, 114);
            this.panel3.TabIndex = 8;
            // 
            // logo_img
            // 
            this.logo_img.BackColor = System.Drawing.Color.Transparent;
            this.logo_img.Image = global::MiniGram.Properties.Resources.shipping;
            this.logo_img.Location = new System.Drawing.Point(7, 11);
            this.logo_img.Margin = new System.Windows.Forms.Padding(4);
            this.logo_img.Name = "logo_img";
            this.logo_img.Size = new System.Drawing.Size(82, 82);
            this.logo_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_img.TabIndex = 4;
            this.logo_img.TabStop = false;
            // 
            // exit_btn
            // 
            this.exit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.exit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_btn.FlatAppearance.BorderSize = 0;
            this.exit_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.exit_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.ForeColor = System.Drawing.Color.White;
            this.exit_btn.Location = new System.Drawing.Point(984, 11);
            this.exit_btn.Margin = new System.Windows.Forms.Padding(4);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(40, 37);
            this.exit_btn.TabIndex = 6;
            this.exit_btn.Text = "X";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // keyboard_btn
            // 
            this.keyboard_btn.AccessibleName = "Button";
            this.keyboard_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.keyboard_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.keyboard_btn.CanOverrideStyle = true;
            this.keyboard_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.keyboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.keyboard_btn.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyboard_btn.ForeColor = System.Drawing.Color.White;
            this.keyboard_btn.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.keyboard_btn.ImageMargin = new System.Windows.Forms.Padding(0);
            this.keyboard_btn.ImageSize = new System.Drawing.Size(25, 25);
            this.keyboard_btn.Location = new System.Drawing.Point(931, 11);
            this.keyboard_btn.Margin = new System.Windows.Forms.Padding(0);
            this.keyboard_btn.Name = "keyboard_btn";
            this.keyboard_btn.Size = new System.Drawing.Size(40, 37);
            this.keyboard_btn.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.keyboard_btn.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.keyboard_btn.Style.FocusedForeColor = System.Drawing.Color.White;
            this.keyboard_btn.Style.ForeColor = System.Drawing.Color.White;
            this.keyboard_btn.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.keyboard_btn.Style.HoverForeColor = System.Drawing.Color.White;
            this.keyboard_btn.Style.HoverImageForeColor = System.Drawing.Color.Empty;
            this.keyboard_btn.Style.Image = global::MiniGram.Properties.Resources.keyboard;
            this.keyboard_btn.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.keyboard_btn.Style.PressedForeColor = System.Drawing.Color.White;
            this.keyboard_btn.TabIndex = 24;
            this.keyboard_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.keyboard_btn.TextMargin = new System.Windows.Forms.Padding(0);
            this.keyboard_btn.ThemeName = "Office2016Colorful";
            this.keyboard_btn.UseVisualStyleBackColor = true;
            this.keyboard_btn.Click += new System.EventHandler(this.keyboard_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(97, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 82);
            this.label1.TabIndex = 5;
            this.label1.Text = "Edit Product";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1037, 925);
            this.tableLayoutPanel2.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.warning_lable);
            this.panel2.Controls.Add(this.add_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 795);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.panel2.Size = new System.Drawing.Size(1037, 130);
            this.panel2.TabIndex = 0;
            // 
            // warning_lable
            // 
            this.warning_lable.BackColor = System.Drawing.Color.Transparent;
            this.warning_lable.Dock = System.Windows.Forms.DockStyle.Top;
            this.warning_lable.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warning_lable.ForeColor = System.Drawing.Color.Red;
            this.warning_lable.Location = new System.Drawing.Point(10, 5);
            this.warning_lable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.warning_lable.Name = "warning_lable";
            this.warning_lable.Size = new System.Drawing.Size(1017, 39);
            this.warning_lable.TabIndex = 19;
            this.warning_lable.Text = "⚠ Some Required Information Is Incorrect ⚠";
            this.warning_lable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.add_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.add_btn.FlatAppearance.BorderSize = 0;
            this.add_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.add_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Bookman Old Style", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.Color.White;
            this.add_btn.Location = new System.Drawing.Point(10, 48);
            this.add_btn.Margin = new System.Windows.Forms.Padding(4);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(1017, 72);
            this.add_btn.TabIndex = 8;
            this.add_btn.Text = "SAVE";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 120);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(1037, 675);
            this.panel1.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txtSecondaryPrice, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtDiscountPercentage, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.chkboxHasDiscount, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.productname_txt, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.barcode_txt, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnExpiredDate, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxHasExpDate, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.textTVADesc, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chkboxHasQte, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.chkboxHasTVA, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.quantity_txt, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.sell_price_txt, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.supp_cbox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_2031, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.init_price_txt, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1017, 655);
            this.tableLayoutPanel1.TabIndex = 39;
            // 
            // txtSecondaryPrice
            // 
            this.txtSecondaryPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtSecondaryPrice.BeforeTouchSize = new System.Drawing.Size(509, 47);
            this.txtSecondaryPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtSecondaryPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSecondaryPrice.CanOverrideStyle = true;
            this.txtSecondaryPrice.CornerRadius = 5;
            this.txtSecondaryPrice.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtSecondaryPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSecondaryPrice.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtSecondaryPrice.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondaryPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtSecondaryPrice.Location = new System.Drawing.Point(508, 260);
            this.txtSecondaryPrice.Margin = new System.Windows.Forms.Padding(0);
            this.txtSecondaryPrice.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtSecondaryPrice.MinimumSize = new System.Drawing.Size(44, 30);
            this.txtSecondaryPrice.Name = "txtSecondaryPrice";
            this.txtSecondaryPrice.Size = new System.Drawing.Size(509, 47);
            this.txtSecondaryPrice.TabIndex = 4;
            this.txtSecondaryPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSecondaryPrice.ThemeName = "Default";
            this.txtSecondaryPrice.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtSecondaryPrice.ThemeStyle.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.txtSecondaryPrice.ThemeStyle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondaryPrice.ThemeStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtSecondaryPrice.ThemeStyle.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.txtSecondaryPrice.UseBorderColorOnFocus = true;
            this.txtSecondaryPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSecondaryPrice_KeyDown);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.label3.Location = new System.Drawing.Point(0, 260);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(508, 65);
            this.label3.TabIndex = 41;
            this.label3.Text = "⫸ 2nd Sell Price ( $ ) :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDiscountPercentage
            // 
            this.txtDiscountPercentage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtDiscountPercentage.BeforeTouchSize = new System.Drawing.Size(509, 47);
            this.txtDiscountPercentage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtDiscountPercentage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiscountPercentage.CanOverrideStyle = true;
            this.txtDiscountPercentage.CornerRadius = 5;
            this.txtDiscountPercentage.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtDiscountPercentage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDiscountPercentage.Enabled = false;
            this.txtDiscountPercentage.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtDiscountPercentage.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscountPercentage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtDiscountPercentage.Location = new System.Drawing.Point(508, 390);
            this.txtDiscountPercentage.Margin = new System.Windows.Forms.Padding(0);
            this.txtDiscountPercentage.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtDiscountPercentage.MinimumSize = new System.Drawing.Size(44, 30);
            this.txtDiscountPercentage.Name = "txtDiscountPercentage";
            this.txtDiscountPercentage.Size = new System.Drawing.Size(509, 47);
            this.txtDiscountPercentage.TabIndex = 6;
            this.txtDiscountPercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDiscountPercentage.ThemeName = "Default";
            this.txtDiscountPercentage.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtDiscountPercentage.ThemeStyle.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.txtDiscountPercentage.ThemeStyle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscountPercentage.ThemeStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtDiscountPercentage.ThemeStyle.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.txtDiscountPercentage.UseBorderColorOnFocus = true;
            // 
            // chkboxHasDiscount
            // 
            this.chkboxHasDiscount.BeforeTouchSize = new System.Drawing.Size(508, 65);
            this.chkboxHasDiscount.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.chkboxHasDiscount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.chkboxHasDiscount.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkboxHasDiscount.CheckedImage = global::MiniGram.Properties.Resources._checked;
            this.chkboxHasDiscount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkboxHasDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkboxHasDiscount.DrawFocusRectangle = false;
            this.chkboxHasDiscount.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxHasDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.chkboxHasDiscount.ImageCheckBox = true;
            this.chkboxHasDiscount.ImageCheckBoxSize = new System.Drawing.Size(30, 30);
            this.chkboxHasDiscount.Location = new System.Drawing.Point(0, 390);
            this.chkboxHasDiscount.Margin = new System.Windows.Forms.Padding(0);
            this.chkboxHasDiscount.MetroColor = System.Drawing.Color.Transparent;
            this.chkboxHasDiscount.Name = "chkboxHasDiscount";
            this.chkboxHasDiscount.Size = new System.Drawing.Size(508, 65);
            this.chkboxHasDiscount.TabIndex = 39;
            this.chkboxHasDiscount.Text = "⫸ Has Discount :";
            this.chkboxHasDiscount.ThemeName = "Default";
            this.chkboxHasDiscount.ThemesEnabled = true;
            this.chkboxHasDiscount.ThemeStyle.CheckBoxTickThickness = 5;
            this.chkboxHasDiscount.ThemeStyle.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold);
            this.chkboxHasDiscount.ThemeStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.chkboxHasDiscount.ThemeStyle.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.chkboxHasDiscount.ThemeStyle.HoverIntermediateTickColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.chkboxHasDiscount.ThemeStyle.HoverTickColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.chkboxHasDiscount.ThemeStyle.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.chkboxHasDiscount.ThemeStyle.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.chkboxHasDiscount.UncheckedImage = global::MiniGram.Properties.Resources._unchecked;
            this.chkboxHasDiscount.CheckedChanged += new System.EventHandler(this.chkboxHasDiscount_CheckedChanged);
            // 
            // productname_txt
            // 
            this.productname_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.productname_txt.BeforeTouchSize = new System.Drawing.Size(509, 47);
            this.productname_txt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.productname_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productname_txt.CanOverrideStyle = true;
            this.productname_txt.CornerRadius = 5;
            this.productname_txt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.productname_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productname_txt.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.productname_txt.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productname_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.productname_txt.Location = new System.Drawing.Point(508, 0);
            this.productname_txt.Margin = new System.Windows.Forms.Padding(0);
            this.productname_txt.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.productname_txt.MinimumSize = new System.Drawing.Size(44, 30);
            this.productname_txt.Name = "productname_txt";
            this.productname_txt.Size = new System.Drawing.Size(509, 47);
            this.productname_txt.TabIndex = 0;
            this.productname_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.productname_txt.ThemeName = "Default";
            this.productname_txt.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.productname_txt.ThemeStyle.CornerRadius = 5;
            this.productname_txt.ThemeStyle.DisabledBackColor = System.Drawing.Color.Gray;
            this.productname_txt.ThemeStyle.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.productname_txt.ThemeStyle.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.productname_txt.ThemeStyle.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.productname_txt.ThemeStyle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productname_txt.ThemeStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.productname_txt.ThemeStyle.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.productname_txt.UseBorderColorOnFocus = true;
            this.productname_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.productname_txt_KeyDown);
            // 
            // barcode_txt
            // 
            this.barcode_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.barcode_txt.BeforeTouchSize = new System.Drawing.Size(509, 47);
            this.barcode_txt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.barcode_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.barcode_txt.CanOverrideStyle = true;
            this.barcode_txt.CornerRadius = 5;
            this.barcode_txt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.barcode_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barcode_txt.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.barcode_txt.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcode_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.barcode_txt.Location = new System.Drawing.Point(508, 65);
            this.barcode_txt.Margin = new System.Windows.Forms.Padding(0);
            this.barcode_txt.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.barcode_txt.MinimumSize = new System.Drawing.Size(44, 30);
            this.barcode_txt.Name = "barcode_txt";
            this.barcode_txt.Size = new System.Drawing.Size(509, 47);
            this.barcode_txt.TabIndex = 1;
            this.barcode_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.barcode_txt.ThemeName = "Default";
            this.barcode_txt.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.barcode_txt.ThemeStyle.CornerRadius = 5;
            this.barcode_txt.ThemeStyle.DisabledBackColor = System.Drawing.Color.Gray;
            this.barcode_txt.ThemeStyle.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.barcode_txt.ThemeStyle.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.barcode_txt.ThemeStyle.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.barcode_txt.ThemeStyle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcode_txt.ThemeStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.barcode_txt.ThemeStyle.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.barcode_txt.UseBorderColorOnFocus = true;
            this.barcode_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.barcode_txt_KeyDown);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.label6.Location = new System.Drawing.Point(0, 65);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(508, 65);
            this.label6.TabIndex = 23;
            this.label6.Text = "⫸ Barcode :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnExpiredDate
            // 
            this.btnExpiredDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnExpiredDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExpiredDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExpiredDate.Enabled = false;
            this.btnExpiredDate.FlatAppearance.BorderSize = 0;
            this.btnExpiredDate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnExpiredDate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.btnExpiredDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpiredDate.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpiredDate.ForeColor = System.Drawing.Color.White;
            this.btnExpiredDate.Location = new System.Drawing.Point(508, 585);
            this.btnExpiredDate.Margin = new System.Windows.Forms.Padding(0);
            this.btnExpiredDate.Name = "btnExpiredDate";
            this.btnExpiredDate.Size = new System.Drawing.Size(509, 70);
            this.btnExpiredDate.TabIndex = 32;
            this.btnExpiredDate.Text = "Edit Expired Date";
            this.btnExpiredDate.UseVisualStyleBackColor = false;
            this.btnExpiredDate.Click += new System.EventHandler(this.btnExpiredDate_Click);
            // 
            // checkBoxHasExpDate
            // 
            this.checkBoxHasExpDate.BeforeTouchSize = new System.Drawing.Size(500, 62);
            this.checkBoxHasExpDate.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.checkBoxHasExpDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.checkBoxHasExpDate.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxHasExpDate.CheckedImage = global::MiniGram.Properties.Resources._checked;
            this.checkBoxHasExpDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxHasExpDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxHasExpDate.DrawFocusRectangle = false;
            this.checkBoxHasExpDate.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxHasExpDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.checkBoxHasExpDate.ImageCheckBox = true;
            this.checkBoxHasExpDate.ImageCheckBoxSize = new System.Drawing.Size(30, 30);
            this.checkBoxHasExpDate.Location = new System.Drawing.Point(4, 589);
            this.checkBoxHasExpDate.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxHasExpDate.MetroColor = System.Drawing.Color.Transparent;
            this.checkBoxHasExpDate.Name = "checkBoxHasExpDate";
            this.checkBoxHasExpDate.Size = new System.Drawing.Size(500, 62);
            this.checkBoxHasExpDate.TabIndex = 33;
            this.checkBoxHasExpDate.Text = "⫸ Has Expired Date :";
            this.checkBoxHasExpDate.ThemeName = "Default";
            this.checkBoxHasExpDate.ThemesEnabled = true;
            this.checkBoxHasExpDate.ThemeStyle.CheckBoxTickThickness = 5;
            this.checkBoxHasExpDate.ThemeStyle.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold);
            this.checkBoxHasExpDate.ThemeStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.checkBoxHasExpDate.ThemeStyle.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.checkBoxHasExpDate.ThemeStyle.HoverIntermediateTickColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.checkBoxHasExpDate.ThemeStyle.HoverTickColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.checkBoxHasExpDate.ThemeStyle.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.checkBoxHasExpDate.ThemeStyle.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.checkBoxHasExpDate.UncheckedImage = global::MiniGram.Properties.Resources._unchecked;
            this.checkBoxHasExpDate.CheckedChanged += new System.EventHandler(this.checkBoxAdv1_CheckedChanged);
            // 
            // textTVADesc
            // 
            this.textTVADesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textTVADesc.BeforeTouchSize = new System.Drawing.Size(509, 47);
            this.textTVADesc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.textTVADesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textTVADesc.CanOverrideStyle = true;
            this.textTVADesc.CornerRadius = 5;
            this.textTVADesc.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textTVADesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textTVADesc.Enabled = false;
            this.textTVADesc.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.textTVADesc.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTVADesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.textTVADesc.Location = new System.Drawing.Point(508, 455);
            this.textTVADesc.Margin = new System.Windows.Forms.Padding(0);
            this.textTVADesc.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.textTVADesc.MinimumSize = new System.Drawing.Size(44, 30);
            this.textTVADesc.Name = "textTVADesc";
            this.textTVADesc.Size = new System.Drawing.Size(509, 47);
            this.textTVADesc.TabIndex = 7;
            this.textTVADesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textTVADesc.ThemeName = "Default";
            this.textTVADesc.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.textTVADesc.ThemeStyle.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.textTVADesc.ThemeStyle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTVADesc.ThemeStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.textTVADesc.ThemeStyle.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.textTVADesc.UseBorderColorOnFocus = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(508, 65);
            this.label2.TabIndex = 8;
            this.label2.Text = "⫸ Product Name :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkboxHasQte
            // 
            this.chkboxHasQte.BeforeTouchSize = new System.Drawing.Size(508, 65);
            this.chkboxHasQte.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.chkboxHasQte.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.chkboxHasQte.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkboxHasQte.CheckedImage = global::MiniGram.Properties.Resources._checked;
            this.chkboxHasQte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkboxHasQte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkboxHasQte.DrawFocusRectangle = false;
            this.chkboxHasQte.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxHasQte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.chkboxHasQte.ImageCheckBox = true;
            this.chkboxHasQte.ImageCheckBoxSize = new System.Drawing.Size(30, 30);
            this.chkboxHasQte.Location = new System.Drawing.Point(0, 520);
            this.chkboxHasQte.Margin = new System.Windows.Forms.Padding(0);
            this.chkboxHasQte.MetroColor = System.Drawing.Color.Transparent;
            this.chkboxHasQte.Name = "chkboxHasQte";
            this.chkboxHasQte.Size = new System.Drawing.Size(508, 65);
            this.chkboxHasQte.TabIndex = 34;
            this.chkboxHasQte.Text = "⫸ Has Quantity :";
            this.chkboxHasQte.ThemeName = "Default";
            this.chkboxHasQte.ThemesEnabled = true;
            this.chkboxHasQte.ThemeStyle.CheckBoxTickThickness = 5;
            this.chkboxHasQte.ThemeStyle.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold);
            this.chkboxHasQte.ThemeStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.chkboxHasQte.ThemeStyle.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.chkboxHasQte.ThemeStyle.HoverIntermediateTickColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.chkboxHasQte.ThemeStyle.HoverTickColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.chkboxHasQte.ThemeStyle.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.chkboxHasQte.ThemeStyle.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.chkboxHasQte.UncheckedImage = global::MiniGram.Properties.Resources._unchecked;
            this.chkboxHasQte.CheckedChanged += new System.EventHandler(this.checkBoxAdv2_CheckedChanged);
            // 
            // chkboxHasTVA
            // 
            this.chkboxHasTVA.BeforeTouchSize = new System.Drawing.Size(508, 65);
            this.chkboxHasTVA.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.chkboxHasTVA.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.chkboxHasTVA.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkboxHasTVA.CheckedImage = global::MiniGram.Properties.Resources._checked;
            this.chkboxHasTVA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkboxHasTVA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkboxHasTVA.DrawFocusRectangle = false;
            this.chkboxHasTVA.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxHasTVA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.chkboxHasTVA.ImageCheckBox = true;
            this.chkboxHasTVA.ImageCheckBoxSize = new System.Drawing.Size(30, 30);
            this.chkboxHasTVA.Location = new System.Drawing.Point(0, 455);
            this.chkboxHasTVA.Margin = new System.Windows.Forms.Padding(0);
            this.chkboxHasTVA.MetroColor = System.Drawing.Color.Transparent;
            this.chkboxHasTVA.Name = "chkboxHasTVA";
            this.chkboxHasTVA.Size = new System.Drawing.Size(508, 65);
            this.chkboxHasTVA.TabIndex = 35;
            this.chkboxHasTVA.Text = "⫸ Include TVA :";
            this.chkboxHasTVA.ThemeName = "Default";
            this.chkboxHasTVA.ThemesEnabled = true;
            this.chkboxHasTVA.ThemeStyle.CheckBoxTickThickness = 5;
            this.chkboxHasTVA.ThemeStyle.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold);
            this.chkboxHasTVA.ThemeStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.chkboxHasTVA.ThemeStyle.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.chkboxHasTVA.ThemeStyle.HoverIntermediateTickColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.chkboxHasTVA.ThemeStyle.HoverTickColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.chkboxHasTVA.ThemeStyle.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.chkboxHasTVA.ThemeStyle.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.chkboxHasTVA.UncheckedImage = global::MiniGram.Properties.Resources._unchecked;
            this.chkboxHasTVA.CheckedChanged += new System.EventHandler(this.chkboxTVA_CheckedChanged);
            // 
            // quantity_txt
            // 
            this.quantity_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.quantity_txt.BeforeTouchSize = new System.Drawing.Size(509, 47);
            this.quantity_txt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.quantity_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quantity_txt.CanOverrideStyle = true;
            this.quantity_txt.CornerRadius = 5;
            this.quantity_txt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.quantity_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quantity_txt.Enabled = false;
            this.quantity_txt.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.quantity_txt.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.quantity_txt.Location = new System.Drawing.Point(508, 520);
            this.quantity_txt.Margin = new System.Windows.Forms.Padding(0);
            this.quantity_txt.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.quantity_txt.MinimumSize = new System.Drawing.Size(44, 30);
            this.quantity_txt.Name = "quantity_txt";
            this.quantity_txt.Size = new System.Drawing.Size(509, 47);
            this.quantity_txt.TabIndex = 8;
            this.quantity_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantity_txt.ThemeName = "Default";
            this.quantity_txt.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.quantity_txt.ThemeStyle.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.quantity_txt.ThemeStyle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_txt.ThemeStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.quantity_txt.ThemeStyle.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.quantity_txt.UseBorderColorOnFocus = true;
            this.quantity_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantity_txt_KeyPress);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.label5.Location = new System.Drawing.Point(0, 195);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(508, 65);
            this.label5.TabIndex = 14;
            this.label5.Text = "⫸ Sell Price ( $ ) :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sell_price_txt
            // 
            this.sell_price_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sell_price_txt.BeforeTouchSize = new System.Drawing.Size(509, 47);
            this.sell_price_txt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.sell_price_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sell_price_txt.CanOverrideStyle = true;
            this.sell_price_txt.CornerRadius = 5;
            this.sell_price_txt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.sell_price_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sell_price_txt.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.sell_price_txt.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sell_price_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.sell_price_txt.Location = new System.Drawing.Point(508, 195);
            this.sell_price_txt.Margin = new System.Windows.Forms.Padding(0);
            this.sell_price_txt.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.sell_price_txt.MinimumSize = new System.Drawing.Size(44, 30);
            this.sell_price_txt.Name = "sell_price_txt";
            this.sell_price_txt.Size = new System.Drawing.Size(509, 47);
            this.sell_price_txt.TabIndex = 3;
            this.sell_price_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sell_price_txt.ThemeName = "Default";
            this.sell_price_txt.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.sell_price_txt.ThemeStyle.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.sell_price_txt.ThemeStyle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sell_price_txt.ThemeStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.sell_price_txt.ThemeStyle.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.sell_price_txt.UseBorderColorOnFocus = true;
            this.sell_price_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sell_price_txt_KeyDown);
            this.sell_price_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.price_txt_KeyPress);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.label7.Location = new System.Drawing.Point(0, 130);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(508, 65);
            this.label7.TabIndex = 24;
            this.label7.Text = "⫸ Supplier :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // supp_cbox
            // 
            this.supp_cbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.supp_cbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.supp_cbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.supp_cbox.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supp_cbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.supp_cbox.FormattingEnabled = true;
            this.supp_cbox.Location = new System.Drawing.Point(508, 130);
            this.supp_cbox.Margin = new System.Windows.Forms.Padding(0);
            this.supp_cbox.Name = "supp_cbox";
            this.supp_cbox.Size = new System.Drawing.Size(509, 44);
            this.supp_cbox.TabIndex = 2;
            this.supp_cbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.supp_cbox_KeyDown);
            // 
            // label_2031
            // 
            this.label_2031.BackColor = System.Drawing.Color.Transparent;
            this.label_2031.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_2031.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_2031.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.label_2031.Location = new System.Drawing.Point(0, 325);
            this.label_2031.Margin = new System.Windows.Forms.Padding(0);
            this.label_2031.Name = "label_2031";
            this.label_2031.Size = new System.Drawing.Size(508, 65);
            this.label_2031.TabIndex = 38;
            this.label_2031.Text = "⫸ Cost ( $ ) :";
            this.label_2031.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // init_price_txt
            // 
            this.init_price_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.init_price_txt.BeforeTouchSize = new System.Drawing.Size(509, 47);
            this.init_price_txt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.init_price_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.init_price_txt.CanOverrideStyle = true;
            this.init_price_txt.CornerRadius = 5;
            this.init_price_txt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.init_price_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.init_price_txt.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.init_price_txt.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.init_price_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.init_price_txt.Location = new System.Drawing.Point(508, 325);
            this.init_price_txt.Margin = new System.Windows.Forms.Padding(0);
            this.init_price_txt.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.init_price_txt.MinimumSize = new System.Drawing.Size(44, 30);
            this.init_price_txt.Name = "init_price_txt";
            this.init_price_txt.Size = new System.Drawing.Size(509, 47);
            this.init_price_txt.TabIndex = 5;
            this.init_price_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.init_price_txt.ThemeName = "Default";
            this.init_price_txt.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.init_price_txt.ThemeStyle.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.init_price_txt.ThemeStyle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.init_price_txt.ThemeStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.init_price_txt.ThemeStyle.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.init_price_txt.UseBorderColorOnFocus = true;
            this.init_price_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.init_price_txt_KeyDown);
            // 
            // EditProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(1057, 945);
            this.Controls.Add(this.tableLayoutPanel2);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditProductForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditProductForm";
            this.Load += new System.EventHandler(this.EditProductForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_img)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSecondaryPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscountPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkboxHasDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productname_txt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcode_txt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxHasExpDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTVADesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkboxHasQte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkboxHasTVA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_txt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sell_price_txt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.init_price_txt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox logo_img;
        private System.Windows.Forms.Button exit_btn;
        private Syncfusion.WinForms.Controls.SfButton keyboard_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label warning_lable;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtSecondaryPrice;
        private System.Windows.Forms.Label label3;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtDiscountPercentage;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv chkboxHasDiscount;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt productname_txt;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt barcode_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExpiredDate;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxHasExpDate;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textTVADesc;
        private System.Windows.Forms.Label label2;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv chkboxHasQte;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv chkboxHasTVA;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt quantity_txt;
        private System.Windows.Forms.Label label5;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt sell_price_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox supp_cbox;
        private System.Windows.Forms.Label label_2031;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt init_price_txt;
    }
}