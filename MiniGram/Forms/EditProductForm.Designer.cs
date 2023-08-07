namespace MiniGram.Forms
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.warning_lable = new System.Windows.Forms.Label();
            this.save_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtSecondaryPrice = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiscountPercentage = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.chkboxHasDiscount = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.btnExpiredDate = new System.Windows.Forms.Button();
            this.chkboxHasExpDate = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label2 = new System.Windows.Forms.Label();
            this.productname_txt = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label6 = new System.Windows.Forms.Label();
            this.supp_cbox = new System.Windows.Forms.ComboBox();
            this.barcode_txt = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.sell_price_txt = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chkboxHasQte = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.quantity_txt = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.chkboxHasTVA = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.textTVADesc = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.init_price_txt = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label3 = new System.Windows.Forms.Label();
            this.exit_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.logo_img = new System.Windows.Forms.PictureBox();
            this.keyboard_btn = new Syncfusion.WinForms.Controls.SfButton();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSecondaryPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscountPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkboxHasDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkboxHasExpDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productname_txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcode_txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sell_price_txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkboxHasQte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkboxHasTVA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTVADesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.init_price_txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_img)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.warning_lable);
            this.panel1.Controls.Add(this.save_btn);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(12, 95);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(769, 663);
            this.panel1.TabIndex = 11;
            // 
            // warning_lable
            // 
            this.warning_lable.BackColor = System.Drawing.Color.Transparent;
            this.warning_lable.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warning_lable.ForeColor = System.Drawing.Color.Red;
            this.warning_lable.Location = new System.Drawing.Point(5, 558);
            this.warning_lable.Name = "warning_lable";
            this.warning_lable.Size = new System.Drawing.Size(759, 32);
            this.warning_lable.TabIndex = 19;
            this.warning_lable.Text = "⚠ Some Required Information Is Incorrect ⚠";
            this.warning_lable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // save_btn
            // 
            this.save_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.save_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.save_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_btn.FlatAppearance.BorderSize = 0;
            this.save_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.save_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_btn.Font = new System.Drawing.Font("Bookman Old Style", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.ForeColor = System.Drawing.Color.White;
            this.save_btn.Location = new System.Drawing.Point(5, 608);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(759, 50);
            this.save_btn.TabIndex = 8;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txtSecondaryPrice, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtDiscountPercentage, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.chkboxHasDiscount, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.btnExpiredDate, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.chkboxHasExpDate, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.productname_txt, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.supp_cbox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.barcode_txt, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.sell_price_txt, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.chkboxHasQte, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.quantity_txt, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.chkboxHasTVA, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.textTVADesc, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.init_price_txt, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(759, 524);
            this.tableLayoutPanel1.TabIndex = 40;
            // 
            // txtSecondaryPrice
            // 
            this.txtSecondaryPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtSecondaryPrice.BeforeTouchSize = new System.Drawing.Size(374, 40);
            this.txtSecondaryPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtSecondaryPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSecondaryPrice.CanOverrideStyle = true;
            this.txtSecondaryPrice.CornerRadius = 5;
            this.txtSecondaryPrice.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtSecondaryPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSecondaryPrice.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtSecondaryPrice.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondaryPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtSecondaryPrice.Location = new System.Drawing.Point(382, 203);
            this.txtSecondaryPrice.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtSecondaryPrice.MinimumSize = new System.Drawing.Size(34, 30);
            this.txtSecondaryPrice.Name = "txtSecondaryPrice";
            this.txtSecondaryPrice.Size = new System.Drawing.Size(374, 40);
            this.txtSecondaryPrice.TabIndex = 39;
            this.txtSecondaryPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSecondaryPrice.ThemeName = "Default";
            this.txtSecondaryPrice.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtSecondaryPrice.ThemeStyle.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.txtSecondaryPrice.ThemeStyle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondaryPrice.ThemeStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtSecondaryPrice.ThemeStyle.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.txtSecondaryPrice.UseBorderColorOnFocus = true;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.label4.Location = new System.Drawing.Point(0, 200);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(379, 50);
            this.label4.TabIndex = 38;
            this.label4.Text = "⫸ Employee Price ( $ ) :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDiscountPercentage
            // 
            this.txtDiscountPercentage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtDiscountPercentage.BeforeTouchSize = new System.Drawing.Size(374, 40);
            this.txtDiscountPercentage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtDiscountPercentage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiscountPercentage.CanOverrideStyle = true;
            this.txtDiscountPercentage.CornerRadius = 5;
            this.txtDiscountPercentage.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtDiscountPercentage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDiscountPercentage.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtDiscountPercentage.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscountPercentage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtDiscountPercentage.Location = new System.Drawing.Point(382, 327);
            this.txtDiscountPercentage.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtDiscountPercentage.MinimumSize = new System.Drawing.Size(34, 30);
            this.txtDiscountPercentage.Name = "txtDiscountPercentage";
            this.txtDiscountPercentage.Size = new System.Drawing.Size(374, 40);
            this.txtDiscountPercentage.TabIndex = 37;
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
            this.chkboxHasDiscount.BeforeTouchSize = new System.Drawing.Size(373, 44);
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
            this.chkboxHasDiscount.Location = new System.Drawing.Point(3, 327);
            this.chkboxHasDiscount.MetroColor = System.Drawing.Color.Transparent;
            this.chkboxHasDiscount.Name = "chkboxHasDiscount";
            this.chkboxHasDiscount.Size = new System.Drawing.Size(373, 44);
            this.chkboxHasDiscount.TabIndex = 36;
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
            this.btnExpiredDate.Location = new System.Drawing.Point(382, 477);
            this.btnExpiredDate.Name = "btnExpiredDate";
            this.btnExpiredDate.Size = new System.Drawing.Size(374, 44);
            this.btnExpiredDate.TabIndex = 28;
            this.btnExpiredDate.Text = "Edit Expired Date";
            this.btnExpiredDate.UseVisualStyleBackColor = false;
            this.btnExpiredDate.Click += new System.EventHandler(this.btnExpiredDate_Click);
            // 
            // chkboxHasExpDate
            // 
            this.chkboxHasExpDate.BeforeTouchSize = new System.Drawing.Size(373, 44);
            this.chkboxHasExpDate.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.chkboxHasExpDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.chkboxHasExpDate.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkboxHasExpDate.CheckedImage = global::MiniGram.Properties.Resources._checked;
            this.chkboxHasExpDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkboxHasExpDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkboxHasExpDate.DrawFocusRectangle = false;
            this.chkboxHasExpDate.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxHasExpDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.chkboxHasExpDate.ImageCheckBox = true;
            this.chkboxHasExpDate.ImageCheckBoxSize = new System.Drawing.Size(30, 30);
            this.chkboxHasExpDate.Location = new System.Drawing.Point(3, 477);
            this.chkboxHasExpDate.MetroColor = System.Drawing.Color.Transparent;
            this.chkboxHasExpDate.Name = "chkboxHasExpDate";
            this.chkboxHasExpDate.Size = new System.Drawing.Size(373, 44);
            this.chkboxHasExpDate.TabIndex = 30;
            this.chkboxHasExpDate.Text = "⫸ Has Expired Date :";
            this.chkboxHasExpDate.ThemeName = "Default";
            this.chkboxHasExpDate.ThemesEnabled = true;
            this.chkboxHasExpDate.ThemeStyle.CheckBoxTickThickness = 5;
            this.chkboxHasExpDate.ThemeStyle.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold);
            this.chkboxHasExpDate.ThemeStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.chkboxHasExpDate.ThemeStyle.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.chkboxHasExpDate.ThemeStyle.HoverIntermediateTickColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.chkboxHasExpDate.ThemeStyle.HoverTickColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.chkboxHasExpDate.ThemeStyle.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.chkboxHasExpDate.ThemeStyle.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.chkboxHasExpDate.UncheckedImage = global::MiniGram.Properties.Resources._unchecked;
            this.chkboxHasExpDate.CheckedChanged += new System.EventHandler(this.checkBoxAdv1_CheckedChanged);
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
            this.label2.Size = new System.Drawing.Size(379, 50);
            this.label2.TabIndex = 8;
            this.label2.Text = "⫸ Product Name :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // productname_txt
            // 
            this.productname_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.productname_txt.BeforeTouchSize = new System.Drawing.Size(374, 40);
            this.productname_txt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.productname_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productname_txt.CanOverrideStyle = true;
            this.productname_txt.CornerRadius = 5;
            this.productname_txt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.productname_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productname_txt.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.productname_txt.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productname_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.productname_txt.Location = new System.Drawing.Point(382, 3);
            this.productname_txt.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.productname_txt.MinimumSize = new System.Drawing.Size(34, 30);
            this.productname_txt.Name = "productname_txt";
            this.productname_txt.Size = new System.Drawing.Size(374, 40);
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
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.label6.Location = new System.Drawing.Point(0, 50);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(379, 50);
            this.label6.TabIndex = 23;
            this.label6.Text = "⫸ Barcode :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // supp_cbox
            // 
            this.supp_cbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.supp_cbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.supp_cbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.supp_cbox.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supp_cbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.supp_cbox.FormattingEnabled = true;
            this.supp_cbox.Location = new System.Drawing.Point(382, 103);
            this.supp_cbox.Name = "supp_cbox";
            this.supp_cbox.Size = new System.Drawing.Size(374, 36);
            this.supp_cbox.TabIndex = 27;
            // 
            // barcode_txt
            // 
            this.barcode_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.barcode_txt.BeforeTouchSize = new System.Drawing.Size(374, 40);
            this.barcode_txt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.barcode_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.barcode_txt.CanOverrideStyle = true;
            this.barcode_txt.CornerRadius = 5;
            this.barcode_txt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.barcode_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barcode_txt.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.barcode_txt.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcode_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.barcode_txt.Location = new System.Drawing.Point(382, 53);
            this.barcode_txt.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.barcode_txt.MinimumSize = new System.Drawing.Size(34, 30);
            this.barcode_txt.Name = "barcode_txt";
            this.barcode_txt.Size = new System.Drawing.Size(374, 40);
            this.barcode_txt.TabIndex = 22;
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
            // 
            // sell_price_txt
            // 
            this.sell_price_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sell_price_txt.BeforeTouchSize = new System.Drawing.Size(374, 40);
            this.sell_price_txt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.sell_price_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sell_price_txt.CanOverrideStyle = true;
            this.sell_price_txt.CornerRadius = 5;
            this.sell_price_txt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.sell_price_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sell_price_txt.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.sell_price_txt.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sell_price_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.sell_price_txt.Location = new System.Drawing.Point(382, 153);
            this.sell_price_txt.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.sell_price_txt.MinimumSize = new System.Drawing.Size(34, 30);
            this.sell_price_txt.Name = "sell_price_txt";
            this.sell_price_txt.Size = new System.Drawing.Size(374, 40);
            this.sell_price_txt.TabIndex = 10;
            this.sell_price_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sell_price_txt.ThemeName = "Default";
            this.sell_price_txt.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.sell_price_txt.ThemeStyle.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.sell_price_txt.ThemeStyle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sell_price_txt.ThemeStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.sell_price_txt.ThemeStyle.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.sell_price_txt.UseBorderColorOnFocus = true;
            this.sell_price_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.price_txt_KeyPress);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.label5.Location = new System.Drawing.Point(0, 150);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(379, 50);
            this.label5.TabIndex = 14;
            this.label5.Text = "⫸ Sell Price ( $ ) :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.label7.Location = new System.Drawing.Point(3, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(373, 50);
            this.label7.TabIndex = 26;
            this.label7.Text = "⫸ Supplier :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkboxHasQte
            // 
            this.chkboxHasQte.BeforeTouchSize = new System.Drawing.Size(373, 44);
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
            this.chkboxHasQte.Location = new System.Drawing.Point(3, 427);
            this.chkboxHasQte.MetroColor = System.Drawing.Color.Transparent;
            this.chkboxHasQte.Name = "chkboxHasQte";
            this.chkboxHasQte.Size = new System.Drawing.Size(373, 44);
            this.chkboxHasQte.TabIndex = 31;
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
            // quantity_txt
            // 
            this.quantity_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.quantity_txt.BeforeTouchSize = new System.Drawing.Size(374, 40);
            this.quantity_txt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.quantity_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quantity_txt.CanOverrideStyle = true;
            this.quantity_txt.CornerRadius = 5;
            this.quantity_txt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.quantity_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quantity_txt.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.quantity_txt.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.quantity_txt.Location = new System.Drawing.Point(382, 427);
            this.quantity_txt.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.quantity_txt.MinimumSize = new System.Drawing.Size(34, 30);
            this.quantity_txt.Name = "quantity_txt";
            this.quantity_txt.Size = new System.Drawing.Size(374, 40);
            this.quantity_txt.TabIndex = 9;
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
            // chkboxHasTVA
            // 
            this.chkboxHasTVA.BeforeTouchSize = new System.Drawing.Size(373, 44);
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
            this.chkboxHasTVA.Location = new System.Drawing.Point(3, 377);
            this.chkboxHasTVA.MetroColor = System.Drawing.Color.Transparent;
            this.chkboxHasTVA.Name = "chkboxHasTVA";
            this.chkboxHasTVA.Size = new System.Drawing.Size(373, 44);
            this.chkboxHasTVA.TabIndex = 33;
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
            // textTVADesc
            // 
            this.textTVADesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textTVADesc.BeforeTouchSize = new System.Drawing.Size(374, 40);
            this.textTVADesc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.textTVADesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textTVADesc.CanOverrideStyle = true;
            this.textTVADesc.CornerRadius = 5;
            this.textTVADesc.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textTVADesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textTVADesc.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.textTVADesc.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTVADesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textTVADesc.Location = new System.Drawing.Point(382, 377);
            this.textTVADesc.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.textTVADesc.MinimumSize = new System.Drawing.Size(34, 30);
            this.textTVADesc.Name = "textTVADesc";
            this.textTVADesc.Size = new System.Drawing.Size(374, 40);
            this.textTVADesc.TabIndex = 32;
            this.textTVADesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textTVADesc.ThemeName = "Default";
            this.textTVADesc.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.textTVADesc.ThemeStyle.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.textTVADesc.ThemeStyle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTVADesc.ThemeStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.textTVADesc.ThemeStyle.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.textTVADesc.UseBorderColorOnFocus = true;
            // 
            // init_price_txt
            // 
            this.init_price_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.init_price_txt.BeforeTouchSize = new System.Drawing.Size(374, 40);
            this.init_price_txt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.init_price_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.init_price_txt.CanOverrideStyle = true;
            this.init_price_txt.CornerRadius = 5;
            this.init_price_txt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.init_price_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.init_price_txt.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.init_price_txt.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.init_price_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.init_price_txt.Location = new System.Drawing.Point(382, 253);
            this.init_price_txt.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.init_price_txt.MinimumSize = new System.Drawing.Size(34, 30);
            this.init_price_txt.Name = "init_price_txt";
            this.init_price_txt.Size = new System.Drawing.Size(374, 40);
            this.init_price_txt.TabIndex = 34;
            this.init_price_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.init_price_txt.ThemeName = "Default";
            this.init_price_txt.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.init_price_txt.ThemeStyle.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.init_price_txt.ThemeStyle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.init_price_txt.ThemeStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.init_price_txt.ThemeStyle.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.init_price_txt.UseBorderColorOnFocus = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.label3.Location = new System.Drawing.Point(0, 250);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(379, 50);
            this.label3.TabIndex = 35;
            this.label3.Text = "⫸ Cost ( $ ) :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.exit_btn.Location = new System.Drawing.Point(751, 11);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(30, 30);
            this.exit_btn.TabIndex = 10;
            this.exit_btn.Text = "X";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(93, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 66);
            this.label1.TabIndex = 9;
            this.label1.Text = "Edit Product";
            // 
            // logo_img
            // 
            this.logo_img.BackColor = System.Drawing.Color.Transparent;
            this.logo_img.Image = global::MiniGram.Properties.Resources.shipping;
            this.logo_img.Location = new System.Drawing.Point(12, 11);
            this.logo_img.Name = "logo_img";
            this.logo_img.Size = new System.Drawing.Size(75, 75);
            this.logo_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_img.TabIndex = 8;
            this.logo_img.TabStop = false;
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
            this.keyboard_btn.Location = new System.Drawing.Point(710, 11);
            this.keyboard_btn.Margin = new System.Windows.Forms.Padding(0);
            this.keyboard_btn.Name = "keyboard_btn";
            this.keyboard_btn.Size = new System.Drawing.Size(30, 30);
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
            // EditProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(793, 768);
            this.Controls.Add(this.keyboard_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logo_img);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditProductForm";
            this.Load += new System.EventHandler(this.EditProductForm_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSecondaryPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscountPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkboxHasDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkboxHasExpDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productname_txt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcode_txt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sell_price_txt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkboxHasQte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_txt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkboxHasTVA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTVADesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.init_price_txt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label warning_lable;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Label label5;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt sell_price_txt;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt quantity_txt;
        private System.Windows.Forms.Label label2;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt productname_txt;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox logo_img;
        private System.Windows.Forms.Label label6;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt barcode_txt;
        private Syncfusion.WinForms.Controls.SfButton keyboard_btn;
        private System.Windows.Forms.ComboBox supp_cbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnExpiredDate;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv chkboxHasExpDate;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv chkboxHasQte;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv chkboxHasTVA;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textTVADesc;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt init_price_txt;
        private System.Windows.Forms.Label label3;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtDiscountPercentage;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv chkboxHasDiscount;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtSecondaryPrice;
        private System.Windows.Forms.Label label4;
    }
}