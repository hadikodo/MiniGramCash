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
            this.label6 = new System.Windows.Forms.Label();
            this.barcode_txt = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.hasqte_combo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.warning_lable = new System.Windows.Forms.Label();
            this.save_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.price_txt = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label3 = new System.Windows.Forms.Label();
            this.quantity_txt = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label2 = new System.Windows.Forms.Label();
            this.productname_txt = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.exit_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.logo_img = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barcode_txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.price_txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productname_txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_img)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.barcode_txt);
            this.panel1.Controls.Add(this.hasqte_combo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.warning_lable);
            this.panel1.Controls.Add(this.save_btn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.price_txt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.quantity_txt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.productname_txt);
            this.panel1.Location = new System.Drawing.Point(12, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 663);
            this.panel1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.label6.Location = new System.Drawing.Point(22, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 32);
            this.label6.TabIndex = 23;
            this.label6.Text = "⫸ Barcode :";
            // 
            // barcode_txt
            // 
            this.barcode_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.barcode_txt.BeforeTouchSize = new System.Drawing.Size(400, 40);
            this.barcode_txt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.barcode_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.barcode_txt.CanOverrideStyle = true;
            this.barcode_txt.CornerRadius = 5;
            this.barcode_txt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.barcode_txt.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.barcode_txt.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcode_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.barcode_txt.Location = new System.Drawing.Point(328, 126);
            this.barcode_txt.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.barcode_txt.MinimumSize = new System.Drawing.Size(34, 30);
            this.barcode_txt.Name = "barcode_txt";
            this.barcode_txt.Size = new System.Drawing.Size(400, 40);
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
            // hasqte_combo
            // 
            this.hasqte_combo.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hasqte_combo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.hasqte_combo.FormattingEnabled = true;
            this.hasqte_combo.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.hasqte_combo.Location = new System.Drawing.Point(328, 200);
            this.hasqte_combo.Name = "hasqte_combo";
            this.hasqte_combo.Size = new System.Drawing.Size(400, 36);
            this.hasqte_combo.TabIndex = 21;
            this.hasqte_combo.SelectedIndexChanged += new System.EventHandler(this.hasqte_combo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.label4.Location = new System.Drawing.Point(22, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 32);
            this.label4.TabIndex = 20;
            this.label4.Text = "⫸ Has Quantity :";
            // 
            // warning_lable
            // 
            this.warning_lable.AutoSize = true;
            this.warning_lable.BackColor = System.Drawing.Color.Transparent;
            this.warning_lable.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warning_lable.ForeColor = System.Drawing.Color.Red;
            this.warning_lable.Location = new System.Drawing.Point(53, 424);
            this.warning_lable.Name = "warning_lable";
            this.warning_lable.Size = new System.Drawing.Size(662, 32);
            this.warning_lable.TabIndex = 19;
            this.warning_lable.Text = "⚠ Some Required Information Is Incorrect ⚠";
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
            this.save_btn.Location = new System.Drawing.Point(298, 487);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(150, 120);
            this.save_btn.TabIndex = 8;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.label5.Location = new System.Drawing.Point(22, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 32);
            this.label5.TabIndex = 14;
            this.label5.Text = "⫸ Price in $ :";
            // 
            // price_txt
            // 
            this.price_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.price_txt.BeforeTouchSize = new System.Drawing.Size(400, 40);
            this.price_txt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.price_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.price_txt.CanOverrideStyle = true;
            this.price_txt.CornerRadius = 5;
            this.price_txt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.price_txt.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.price_txt.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.price_txt.Location = new System.Drawing.Point(328, 340);
            this.price_txt.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.price_txt.MinimumSize = new System.Drawing.Size(34, 30);
            this.price_txt.Name = "price_txt";
            this.price_txt.Size = new System.Drawing.Size(400, 40);
            this.price_txt.TabIndex = 10;
            this.price_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.price_txt.ThemeName = "Default";
            this.price_txt.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.price_txt.ThemeStyle.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.price_txt.ThemeStyle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_txt.ThemeStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.price_txt.ThemeStyle.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.price_txt.UseBorderColorOnFocus = true;
            this.price_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.price_txt_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.label3.Location = new System.Drawing.Point(22, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "⫸ Initial Quantity :";
            // 
            // quantity_txt
            // 
            this.quantity_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.quantity_txt.BeforeTouchSize = new System.Drawing.Size(400, 40);
            this.quantity_txt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.quantity_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quantity_txt.CanOverrideStyle = true;
            this.quantity_txt.CornerRadius = 5;
            this.quantity_txt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.quantity_txt.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.quantity_txt.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.quantity_txt.Location = new System.Drawing.Point(328, 270);
            this.quantity_txt.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.quantity_txt.MinimumSize = new System.Drawing.Size(34, 30);
            this.quantity_txt.Name = "quantity_txt";
            this.quantity_txt.Size = new System.Drawing.Size(400, 40);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.label2.Location = new System.Drawing.Point(22, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "⫸ Product Name :";
            // 
            // productname_txt
            // 
            this.productname_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.productname_txt.BeforeTouchSize = new System.Drawing.Size(400, 40);
            this.productname_txt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.productname_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productname_txt.CanOverrideStyle = true;
            this.productname_txt.CornerRadius = 5;
            this.productname_txt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.productname_txt.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.productname_txt.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productname_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.productname_txt.Location = new System.Drawing.Point(328, 56);
            this.productname_txt.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.productname_txt.MinimumSize = new System.Drawing.Size(34, 30);
            this.productname_txt.Name = "productname_txt";
            this.productname_txt.Size = new System.Drawing.Size(400, 40);
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
            // exit_btn
            // 
            this.exit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.exit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_btn.FlatAppearance.BorderSize = 0;
            this.exit_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.exit_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // EditProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(793, 768);
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
            this.TopMost = true;
            this.Load += new System.EventHandler(this.EditProductForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barcode_txt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.price_txt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_txt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productname_txt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox hasqte_combo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label warning_lable;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Label label5;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt price_txt;
        private System.Windows.Forms.Label label3;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt quantity_txt;
        private System.Windows.Forms.Label label2;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt productname_txt;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox logo_img;
        private System.Windows.Forms.Label label6;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt barcode_txt;
    }
}