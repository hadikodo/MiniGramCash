namespace MiniGram.Controls
{
    partial class CustomersUC
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.keyboard_btn = new Syncfusion.WinForms.Controls.SfButton();
            this.search_txt = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.search_btn = new Syncfusion.WinForms.Controls.SfButton();
            this.disable_btn = new Syncfusion.WinForms.Controls.SfButton();
            this.enable_btn = new Syncfusion.WinForms.Controls.SfButton();
            this.addcustomer_btn = new Syncfusion.WinForms.Controls.SfButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.spselectAllCustomersResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVIP = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnEnabled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnShowMore = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.search_txt)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spselectAllCustomersResultBindingSource)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // keyboard_btn
            // 
            this.keyboard_btn.AccessibleName = "Button";
            this.keyboard_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.keyboard_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.keyboard_btn.CanOverrideStyle = true;
            this.keyboard_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.keyboard_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keyboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.keyboard_btn.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyboard_btn.ForeColor = System.Drawing.Color.White;
            this.keyboard_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.keyboard_btn.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.keyboard_btn.ImageMargin = new System.Windows.Forms.Padding(0);
            this.keyboard_btn.ImageSize = new System.Drawing.Size(45, 45);
            this.keyboard_btn.Location = new System.Drawing.Point(300, 0);
            this.keyboard_btn.Margin = new System.Windows.Forms.Padding(0);
            this.keyboard_btn.Name = "keyboard_btn";
            this.keyboard_btn.Size = new System.Drawing.Size(100, 69);
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
            this.keyboard_btn.TabIndex = 23;
            this.keyboard_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.keyboard_btn.TextMargin = new System.Windows.Forms.Padding(0);
            this.keyboard_btn.ThemeName = "Office2016Colorful";
            this.toolTip1.SetToolTip(this.keyboard_btn, "Open Touch Keyboard");
            this.keyboard_btn.UseVisualStyleBackColor = true;
            this.keyboard_btn.Click += new System.EventHandler(this.keyboard_btn_Click);
            // 
            // search_txt
            // 
            this.search_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.search_txt.BeforeTouchSize = new System.Drawing.Size(34, 40);
            this.search_txt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.search_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.search_txt.CanOverrideStyle = true;
            this.search_txt.CornerRadius = 5;
            this.search_txt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.search_txt.Dock = System.Windows.Forms.DockStyle.Left;
            this.search_txt.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.search_txt.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.search_txt.Location = new System.Drawing.Point(503, 3);
            this.search_txt.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.search_txt.MinimumSize = new System.Drawing.Size(34, 30);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(34, 40);
            this.search_txt.TabIndex = 17;
            this.search_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.search_txt.ThemeName = "Default";
            this.search_txt.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.search_txt.ThemeStyle.CornerRadius = 5;
            this.search_txt.ThemeStyle.DisabledBackColor = System.Drawing.Color.Gray;
            this.search_txt.ThemeStyle.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.search_txt.ThemeStyle.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.search_txt.ThemeStyle.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.search_txt.ThemeStyle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_txt.ThemeStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.search_txt.ThemeStyle.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.toolTip1.SetToolTip(this.search_txt, "The Name Of The New Product");
            this.search_txt.UseBorderColorOnFocus = true;
            this.search_txt.TextChanged += new System.EventHandler(this.search_txt_TextChanged);
            // 
            // search_btn
            // 
            this.search_btn.AccessibleName = "Button";
            this.search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.search_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.search_btn.CanOverrideStyle = true;
            this.search_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.ForeColor = System.Drawing.Color.White;
            this.search_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.search_btn.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.search_btn.ImageMargin = new System.Windows.Forms.Padding(0);
            this.search_btn.ImageSize = new System.Drawing.Size(35, 35);
            this.search_btn.Location = new System.Drawing.Point(400, 0);
            this.search_btn.Margin = new System.Windows.Forms.Padding(0);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(100, 69);
            this.search_btn.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.search_btn.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.search_btn.Style.FocusedForeColor = System.Drawing.Color.White;
            this.search_btn.Style.ForeColor = System.Drawing.Color.White;
            this.search_btn.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.search_btn.Style.HoverForeColor = System.Drawing.Color.White;
            this.search_btn.Style.HoverImageForeColor = System.Drawing.Color.Empty;
            this.search_btn.Style.Image = global::MiniGram.Properties.Resources.search;
            this.search_btn.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.search_btn.Style.PressedForeColor = System.Drawing.Color.White;
            this.search_btn.TabIndex = 16;
            this.search_btn.Text = "Search";
            this.search_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.search_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.search_btn.TextMargin = new System.Windows.Forms.Padding(0);
            this.search_btn.ThemeName = "Office2016Colorful";
            this.toolTip1.SetToolTip(this.search_btn, "Search For Customer");
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // disable_btn
            // 
            this.disable_btn.AccessibleName = "Button";
            this.disable_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.disable_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.disable_btn.CanOverrideStyle = true;
            this.disable_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.disable_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.disable_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disable_btn.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disable_btn.ForeColor = System.Drawing.Color.White;
            this.disable_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.disable_btn.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.disable_btn.ImageMargin = new System.Windows.Forms.Padding(0);
            this.disable_btn.ImageSize = new System.Drawing.Size(35, 35);
            this.disable_btn.Location = new System.Drawing.Point(200, 0);
            this.disable_btn.Margin = new System.Windows.Forms.Padding(0);
            this.disable_btn.Name = "disable_btn";
            this.disable_btn.Size = new System.Drawing.Size(100, 69);
            this.disable_btn.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.disable_btn.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.disable_btn.Style.FocusedForeColor = System.Drawing.Color.White;
            this.disable_btn.Style.ForeColor = System.Drawing.Color.White;
            this.disable_btn.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.disable_btn.Style.HoverForeColor = System.Drawing.Color.White;
            this.disable_btn.Style.HoverImageForeColor = System.Drawing.Color.Empty;
            this.disable_btn.Style.Image = global::MiniGram.Properties.Resources.off;
            this.disable_btn.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.disable_btn.Style.PressedForeColor = System.Drawing.Color.White;
            this.disable_btn.TabIndex = 14;
            this.disable_btn.Text = "Disable";
            this.disable_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.disable_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.disable_btn.TextMargin = new System.Windows.Forms.Padding(0);
            this.disable_btn.ThemeName = "Office2016Colorful";
            this.toolTip1.SetToolTip(this.disable_btn, "Disable Selected Customer");
            this.disable_btn.UseVisualStyleBackColor = false;
            this.disable_btn.Click += new System.EventHandler(this.disable_btn_Click);
            // 
            // enable_btn
            // 
            this.enable_btn.AccessibleName = "Button";
            this.enable_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.enable_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.enable_btn.CanOverrideStyle = true;
            this.enable_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enable_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enable_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enable_btn.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enable_btn.ForeColor = System.Drawing.Color.White;
            this.enable_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.enable_btn.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.enable_btn.ImageMargin = new System.Windows.Forms.Padding(0);
            this.enable_btn.ImageSize = new System.Drawing.Size(35, 35);
            this.enable_btn.Location = new System.Drawing.Point(100, 0);
            this.enable_btn.Margin = new System.Windows.Forms.Padding(0);
            this.enable_btn.Name = "enable_btn";
            this.enable_btn.Size = new System.Drawing.Size(100, 69);
            this.enable_btn.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.enable_btn.Style.FocusedBackColor = System.Drawing.Color.Transparent;
            this.enable_btn.Style.FocusedForeColor = System.Drawing.Color.Transparent;
            this.enable_btn.Style.ForeColor = System.Drawing.Color.White;
            this.enable_btn.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.enable_btn.Style.HoverForeColor = System.Drawing.Color.White;
            this.enable_btn.Style.HoverImageForeColor = System.Drawing.Color.Empty;
            this.enable_btn.Style.Image = global::MiniGram.Properties.Resources.on;
            this.enable_btn.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.enable_btn.Style.PressedForeColor = System.Drawing.Color.White;
            this.enable_btn.TabIndex = 13;
            this.enable_btn.Text = "Enable";
            this.enable_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.enable_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.enable_btn.TextMargin = new System.Windows.Forms.Padding(0);
            this.enable_btn.ThemeName = "Office2016Colorful";
            this.toolTip1.SetToolTip(this.enable_btn, "Enable Selected Customer");
            this.enable_btn.UseVisualStyleBackColor = false;
            this.enable_btn.Click += new System.EventHandler(this.enable_btn_Click);
            // 
            // addcustomer_btn
            // 
            this.addcustomer_btn.AccessibleName = "Button";
            this.addcustomer_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.addcustomer_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addcustomer_btn.CanOverrideStyle = true;
            this.addcustomer_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addcustomer_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addcustomer_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addcustomer_btn.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addcustomer_btn.ForeColor = System.Drawing.Color.White;
            this.addcustomer_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addcustomer_btn.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addcustomer_btn.ImageMargin = new System.Windows.Forms.Padding(0);
            this.addcustomer_btn.ImageSize = new System.Drawing.Size(35, 35);
            this.addcustomer_btn.Location = new System.Drawing.Point(0, 0);
            this.addcustomer_btn.Margin = new System.Windows.Forms.Padding(0);
            this.addcustomer_btn.Name = "addcustomer_btn";
            this.addcustomer_btn.Size = new System.Drawing.Size(100, 69);
            this.addcustomer_btn.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.addcustomer_btn.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.addcustomer_btn.Style.FocusedForeColor = System.Drawing.Color.White;
            this.addcustomer_btn.Style.ForeColor = System.Drawing.Color.White;
            this.addcustomer_btn.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.addcustomer_btn.Style.HoverForeColor = System.Drawing.Color.White;
            this.addcustomer_btn.Style.HoverImageForeColor = System.Drawing.Color.Empty;
            this.addcustomer_btn.Style.Image = global::MiniGram.Properties.Resources.add;
            this.addcustomer_btn.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.addcustomer_btn.Style.PressedForeColor = System.Drawing.Color.White;
            this.addcustomer_btn.TabIndex = 12;
            this.addcustomer_btn.Text = "Add";
            this.addcustomer_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addcustomer_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.addcustomer_btn.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.addcustomer_btn.ThemeName = "Office2016Colorful";
            this.toolTip1.SetToolTip(this.addcustomer_btn, "Add New Customer");
            this.addcustomer_btn.UseVisualStyleBackColor = false;
            this.addcustomer_btn.Click += new System.EventHandler(this.addcustomer_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 69);
            this.panel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 618F));
            this.tableLayoutPanel2.Controls.Add(this.keyboard_btn, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.search_txt, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.search_btn, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.disable_btn, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.enable_btn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.addcustomer_btn, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1018, 69);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1012, 681);
            this.panel3.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnFullName,
            this.ColumnPhoneNumber,
            this.ColumnEmail,
            this.ColumnVIP,
            this.ColumnEnabled,
            this.ColumnShowMore});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.DataSource = this.spselectAllCustomersResultBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 10;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1012, 681);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // spselectAllCustomersResultBindingSource
            // 
            this.spselectAllCustomersResultBindingSource.DataSource = typeof(MiniGram.LINQ.sp_selectAllCustomersResult);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 687F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1018, 687);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1018, 687);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.797797F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.2022F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1024, 768);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ColumnID
            // 
            this.ColumnID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnID.DataPropertyName = "ID";
            this.ColumnID.FillWeight = 15.85214F;
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            // 
            // ColumnFullName
            // 
            this.ColumnFullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnFullName.DataPropertyName = "FullName";
            this.ColumnFullName.FillWeight = 7.767547F;
            this.ColumnFullName.HeaderText = "Full Name";
            this.ColumnFullName.Name = "ColumnFullName";
            this.ColumnFullName.ReadOnly = true;
            // 
            // ColumnPhoneNumber
            // 
            this.ColumnPhoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnPhoneNumber.DataPropertyName = "PhoneNumber";
            this.ColumnPhoneNumber.FillWeight = 56.38131F;
            this.ColumnPhoneNumber.HeaderText = "Phone";
            this.ColumnPhoneNumber.Name = "ColumnPhoneNumber";
            this.ColumnPhoneNumber.ReadOnly = true;
            this.ColumnPhoneNumber.Width = 200;
            // 
            // ColumnEmail
            // 
            this.ColumnEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnEmail.DataPropertyName = "Email";
            this.ColumnEmail.FillWeight = 106.4986F;
            this.ColumnEmail.HeaderText = "Email";
            this.ColumnEmail.Name = "ColumnEmail";
            this.ColumnEmail.ReadOnly = true;
            this.ColumnEmail.Width = 200;
            // 
            // ColumnVIP
            // 
            this.ColumnVIP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnVIP.DataPropertyName = "isVIP";
            this.ColumnVIP.FillWeight = 68.71929F;
            this.ColumnVIP.HeaderText = "VIP";
            this.ColumnVIP.Name = "ColumnVIP";
            this.ColumnVIP.ReadOnly = true;
            // 
            // ColumnEnabled
            // 
            this.ColumnEnabled.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnEnabled.DataPropertyName = "Enabled";
            this.ColumnEnabled.FillWeight = 89.45119F;
            this.ColumnEnabled.HeaderText = "Enabled";
            this.ColumnEnabled.Name = "ColumnEnabled";
            this.ColumnEnabled.ReadOnly = true;
            this.ColumnEnabled.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnEnabled.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnShowMore
            // 
            this.ColumnShowMore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.ColumnShowMore.DefaultCellStyle = dataGridViewCellStyle10;
            this.ColumnShowMore.FillWeight = 355.33F;
            this.ColumnShowMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColumnShowMore.HeaderText = "";
            this.ColumnShowMore.Name = "ColumnShowMore";
            this.ColumnShowMore.ReadOnly = true;
            this.ColumnShowMore.Text = "Show More";
            this.ColumnShowMore.UseColumnTextForButtonValue = true;
            // 
            // CustomersUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CustomersUC";
            this.Size = new System.Drawing.Size(1024, 768);
            this.Load += new System.EventHandler(this.CustomersUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.search_txt)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spselectAllCustomersResultBindingSource)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn column1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn address1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn address2DataGridViewTextBoxColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Syncfusion.WinForms.Controls.SfButton keyboard_btn;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt search_txt;
        private Syncfusion.WinForms.Controls.SfButton search_btn;
        private Syncfusion.WinForms.Controls.SfButton disable_btn;
        private Syncfusion.WinForms.Controls.SfButton enable_btn;
        private Syncfusion.WinForms.Controls.SfButton addcustomer_btn;
        private System.Windows.Forms.BindingSource spselectAllCustomersResultBindingSource;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmail;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnVIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEnabled;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnShowMore;
    }
}
