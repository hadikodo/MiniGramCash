namespace MiniGram.Forms
{
    partial class AddEditCustomerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.keyboard_btn = new Syncfusion.WinForms.Controls.SfButton();
            this.warning_lable = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.chkboxIsVIP = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.txtFullName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtPhoneNumber = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddAddresses = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvAddresses = new System.Windows.Forms.DataGridView();
            this.btnEditSelectedAddress = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtEmail = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.exit_btn = new System.Windows.Forms.Button();
            this.logo_img = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tBLCUSTOMERSADDRESSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.chkboxIsVIP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumber)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddresses)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLCUSTOMERSADDRESSBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.keyboard_btn.TabIndex = 29;
            this.keyboard_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.keyboard_btn.TextMargin = new System.Windows.Forms.Padding(0);
            this.keyboard_btn.ThemeName = "Office2016Colorful";
            this.keyboard_btn.UseVisualStyleBackColor = true;
            this.keyboard_btn.Click += new System.EventHandler(this.keyboard_btn_Click);
            // 
            // warning_lable
            // 
            this.warning_lable.BackColor = System.Drawing.Color.Transparent;
            this.warning_lable.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warning_lable.ForeColor = System.Drawing.Color.Red;
            this.warning_lable.Location = new System.Drawing.Point(5, 555);
            this.warning_lable.Name = "warning_lable";
            this.warning_lable.Size = new System.Drawing.Size(759, 32);
            this.warning_lable.TabIndex = 19;
            this.warning_lable.Text = "⚠ Some Required Information Is Incorrect ⚠";
            this.warning_lable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // add_btn
            // 
            this.add_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.add_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_btn.FlatAppearance.BorderSize = 0;
            this.add_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.add_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Bookman Old Style", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.Color.White;
            this.add_btn.Location = new System.Drawing.Point(5, 608);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(759, 50);
            this.add_btn.TabIndex = 8;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // chkboxIsVIP
            // 
            this.chkboxIsVIP.BeforeTouchSize = new System.Drawing.Size(753, 44);
            this.chkboxIsVIP.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.chkboxIsVIP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.chkboxIsVIP.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkboxIsVIP.CheckedImage = global::MiniGram.Properties.Resources._checked;
            this.tableLayoutPanel1.SetColumnSpan(this.chkboxIsVIP, 2);
            this.chkboxIsVIP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkboxIsVIP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkboxIsVIP.DrawFocusRectangle = false;
            this.chkboxIsVIP.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxIsVIP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.chkboxIsVIP.ImageCheckBox = true;
            this.chkboxIsVIP.ImageCheckBoxSize = new System.Drawing.Size(30, 30);
            this.chkboxIsVIP.Location = new System.Drawing.Point(3, 153);
            this.chkboxIsVIP.MetroColor = System.Drawing.Color.Transparent;
            this.chkboxIsVIP.Name = "chkboxIsVIP";
            this.chkboxIsVIP.Size = new System.Drawing.Size(753, 44);
            this.chkboxIsVIP.TabIndex = 39;
            this.chkboxIsVIP.Text = "⫸ VIP :";
            this.chkboxIsVIP.ThemeName = "Default";
            this.chkboxIsVIP.ThemesEnabled = true;
            this.chkboxIsVIP.ThemeStyle.CheckBoxTickThickness = 5;
            this.chkboxIsVIP.ThemeStyle.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold);
            this.chkboxIsVIP.ThemeStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.chkboxIsVIP.ThemeStyle.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.chkboxIsVIP.ThemeStyle.HoverIntermediateTickColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.chkboxIsVIP.ThemeStyle.HoverTickColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.chkboxIsVIP.ThemeStyle.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.chkboxIsVIP.ThemeStyle.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.chkboxIsVIP.UncheckedImage = global::MiniGram.Properties.Resources._unchecked;
            this.chkboxIsVIP.CheckedChanged += new System.EventHandler(this.chkboxIsVIP_CheckedChanged);
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtFullName.BeforeTouchSize = new System.Drawing.Size(34, 40);
            this.txtFullName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFullName.CanOverrideStyle = true;
            this.txtFullName.CornerRadius = 5;
            this.txtFullName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtFullName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFullName.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtFullName.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtFullName.Location = new System.Drawing.Point(382, 3);
            this.txtFullName.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtFullName.MinimumSize = new System.Drawing.Size(34, 30);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(374, 39);
            this.txtFullName.TabIndex = 0;
            this.txtFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFullName.ThemeName = "Default";
            this.txtFullName.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtFullName.ThemeStyle.CornerRadius = 5;
            this.txtFullName.ThemeStyle.DisabledBackColor = System.Drawing.Color.Gray;
            this.txtFullName.ThemeStyle.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.txtFullName.ThemeStyle.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.txtFullName.ThemeStyle.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.txtFullName.ThemeStyle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.ThemeStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtFullName.ThemeStyle.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.txtFullName.UseBorderColorOnFocus = true;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtPhoneNumber.BeforeTouchSize = new System.Drawing.Size(34, 40);
            this.txtPhoneNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhoneNumber.CanOverrideStyle = true;
            this.txtPhoneNumber.CornerRadius = 5;
            this.txtPhoneNumber.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtPhoneNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPhoneNumber.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtPhoneNumber.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtPhoneNumber.Location = new System.Drawing.Point(382, 53);
            this.txtPhoneNumber.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtPhoneNumber.MinimumSize = new System.Drawing.Size(34, 30);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(374, 39);
            this.txtPhoneNumber.TabIndex = 22;
            this.txtPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPhoneNumber.ThemeName = "Default";
            this.txtPhoneNumber.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtPhoneNumber.ThemeStyle.CornerRadius = 5;
            this.txtPhoneNumber.ThemeStyle.DisabledBackColor = System.Drawing.Color.Gray;
            this.txtPhoneNumber.ThemeStyle.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.txtPhoneNumber.ThemeStyle.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.txtPhoneNumber.ThemeStyle.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.txtPhoneNumber.ThemeStyle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.ThemeStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtPhoneNumber.ThemeStyle.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.txtPhoneNumber.UseBorderColorOnFocus = true;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.label6.Location = new System.Drawing.Point(3, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(373, 50);
            this.label6.TabIndex = 23;
            this.label6.Text = "⫸ Phone Number :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAddAddresses
            // 
            this.btnAddAddresses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnAddAddresses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAddresses.FlatAppearance.BorderSize = 0;
            this.btnAddAddresses.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnAddAddresses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.btnAddAddresses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAddresses.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAddresses.ForeColor = System.Drawing.Color.White;
            this.btnAddAddresses.Location = new System.Drawing.Point(5, 481);
            this.btnAddAddresses.Name = "btnAddAddresses";
            this.btnAddAddresses.Size = new System.Drawing.Size(376, 44);
            this.btnAddAddresses.TabIndex = 32;
            this.btnAddAddresses.Text = "Add New Address";
            this.btnAddAddresses.UseVisualStyleBackColor = false;
            this.btnAddAddresses.Click += new System.EventHandler(this.btnAddAddresses_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dgvAddresses);
            this.panel1.Controls.Add(this.btnEditSelectedAddress);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.warning_lable);
            this.panel1.Controls.Add(this.add_btn);
            this.panel1.Controls.Add(this.btnAddAddresses);
            this.panel1.Location = new System.Drawing.Point(12, 95);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(769, 663);
            this.panel1.TabIndex = 28;
            // 
            // dgvAddresses
            // 
            this.dgvAddresses.AllowUserToAddRows = false;
            this.dgvAddresses.AllowUserToDeleteRows = false;
            this.dgvAddresses.AutoGenerateColumns = false;
            this.dgvAddresses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAddresses.BackgroundColor = System.Drawing.Color.White;
            this.dgvAddresses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAddresses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAddresses.ColumnHeadersHeight = 50;
            this.dgvAddresses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAddresses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ColumnAddress});
            this.dgvAddresses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvAddresses.DataSource = this.tBLCUSTOMERSADDRESSBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAddresses.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAddresses.EnableHeadersVisualStyles = false;
            this.dgvAddresses.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.dgvAddresses.Location = new System.Drawing.Point(5, 209);
            this.dgvAddresses.Name = "dgvAddresses";
            this.dgvAddresses.ReadOnly = true;
            this.dgvAddresses.RowHeadersVisible = false;
            this.dgvAddresses.RowHeadersWidth = 20;
            this.dgvAddresses.RowTemplate.Height = 30;
            this.dgvAddresses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAddresses.Size = new System.Drawing.Size(759, 266);
            this.dgvAddresses.TabIndex = 42;
            // 
            // btnEditSelectedAddress
            // 
            this.btnEditSelectedAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnEditSelectedAddress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditSelectedAddress.Enabled = false;
            this.btnEditSelectedAddress.FlatAppearance.BorderSize = 0;
            this.btnEditSelectedAddress.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnEditSelectedAddress.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.btnEditSelectedAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditSelectedAddress.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSelectedAddress.ForeColor = System.Drawing.Color.White;
            this.btnEditSelectedAddress.Location = new System.Drawing.Point(388, 481);
            this.btnEditSelectedAddress.Name = "btnEditSelectedAddress";
            this.btnEditSelectedAddress.Size = new System.Drawing.Size(376, 44);
            this.btnEditSelectedAddress.TabIndex = 40;
            this.btnEditSelectedAddress.Text = "Edit Selected Address";
            this.btnEditSelectedAddress.UseVisualStyleBackColor = false;
            this.btnEditSelectedAddress.Click += new System.EventHandler(this.btnEditSelectedAddress_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txtEmail, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtFullName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtPhoneNumber, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.chkboxIsVIP, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(759, 198);
            this.tableLayoutPanel1.TabIndex = 39;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtEmail.BeforeTouchSize = new System.Drawing.Size(34, 40);
            this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.CanOverrideStyle = true;
            this.txtEmail.CornerRadius = 5;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEmail.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtEmail.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtEmail.Location = new System.Drawing.Point(382, 103);
            this.txtEmail.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtEmail.MinimumSize = new System.Drawing.Size(34, 30);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(374, 39);
            this.txtEmail.TabIndex = 41;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEmail.ThemeName = "Default";
            this.txtEmail.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtEmail.ThemeStyle.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.txtEmail.ThemeStyle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ThemeStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtEmail.ThemeStyle.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.txtEmail.UseBorderColorOnFocus = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(373, 50);
            this.label2.TabIndex = 8;
            this.label2.Text = "⫸ Full Name :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.label7.TabIndex = 24;
            this.label7.Text = "⫸ Email :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.exit_btn.TabIndex = 27;
            this.exit_btn.Text = "X";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // logo_img
            // 
            this.logo_img.BackColor = System.Drawing.Color.Transparent;
            this.logo_img.Image = global::MiniGram.Properties.Resources.add;
            this.logo_img.Location = new System.Drawing.Point(12, 11);
            this.logo_img.Name = "logo_img";
            this.logo_img.Size = new System.Drawing.Size(75, 75);
            this.logo_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_img.TabIndex = 25;
            this.logo_img.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(93, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 66);
            this.label1.TabIndex = 26;
            this.label1.Text = "New Customer";
            // 
            // tBLCUSTOMERSADDRESSBindingSource
            // 
            this.tBLCUSTOMERSADDRESSBindingSource.DataSource = typeof(MiniGram.LINQ.TBLCUSTOMERS_ADDRESS);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // ColumnAddress
            // 
            this.ColumnAddress.DataPropertyName = "AddressDescription";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.ColumnAddress.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnAddress.HeaderText = "Addresses";
            this.ColumnAddress.Name = "ColumnAddress";
            this.ColumnAddress.ReadOnly = true;
            // 
            // AddEditCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(793, 768);
            this.Controls.Add(this.keyboard_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.logo_img);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEditCustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEditCustomerForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddEditCustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chkboxIsVIP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumber)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddresses)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLCUSTOMERSADDRESSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.WinForms.Controls.SfButton keyboard_btn;
        private System.Windows.Forms.Label warning_lable;
        private System.Windows.Forms.Button add_btn;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv chkboxIsVIP;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFullName;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtPhoneNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddAddresses;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.PictureBox logo_img;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtEmail;
        private System.Windows.Forms.Button btnEditSelectedAddress;
        private System.Windows.Forms.DataGridView dgvAddresses;
        private System.Windows.Forms.BindingSource tBLCUSTOMERSADDRESSBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAddress;
    }
}