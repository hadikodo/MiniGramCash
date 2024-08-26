namespace MiniGram.Forms
{
    partial class ChooseCustomerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.keyboard_btn = new Syncfusion.WinForms.Controls.SfButton();
            this.exit_btn = new Syncfusion.WinForms.Controls.SfButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.logo_img = new System.Windows.Forms.PictureBox();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.tBLCUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtCustomerNameOrID = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.accept_btn = new Syncfusion.WinForms.Controls.SfButton();
            this.timerRefreshDataDelay = new System.Windows.Forms.Timer(this.components);
            this.chkboxVIP = new System.Windows.Forms.CheckBox();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.logo_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLCUSTOMERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerNameOrID)).BeginInit();
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
            this.keyboard_btn.Location = new System.Drawing.Point(865, 23);
            this.keyboard_btn.Margin = new System.Windows.Forms.Padding(0);
            this.keyboard_btn.Name = "keyboard_btn";
            this.keyboard_btn.Size = new System.Drawing.Size(48, 50);
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
            this.keyboard_btn.TabIndex = 46;
            this.keyboard_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.keyboard_btn.TextMargin = new System.Windows.Forms.Padding(0);
            this.keyboard_btn.ThemeName = "Office2016Colorful";
            this.keyboard_btn.UseVisualStyleBackColor = true;
            this.keyboard_btn.Click += new System.EventHandler(this.keyboard_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.AccessibleName = "Button";
            this.exit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.exit_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exit_btn.CanOverrideStyle = true;
            this.exit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.ForeColor = System.Drawing.Color.White;
            this.exit_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exit_btn.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exit_btn.ImageMargin = new System.Windows.Forms.Padding(0);
            this.exit_btn.ImageSize = new System.Drawing.Size(40, 40);
            this.exit_btn.Location = new System.Drawing.Point(927, 23);
            this.exit_btn.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(48, 50);
            this.exit_btn.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.exit_btn.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.exit_btn.Style.FocusedForeColor = System.Drawing.Color.White;
            this.exit_btn.Style.ForeColor = System.Drawing.Color.White;
            this.exit_btn.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.exit_btn.Style.HoverForeColor = System.Drawing.Color.White;
            this.exit_btn.Style.HoverImageForeColor = System.Drawing.Color.Empty;
            this.exit_btn.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.exit_btn.Style.PressedForeColor = System.Drawing.Color.White;
            this.exit_btn.TabIndex = 45;
            this.exit_btn.Text = "X";
            this.exit_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.exit_btn.TextMargin = new System.Windows.Forms.Padding(0);
            this.exit_btn.ThemeName = "Office2016Colorful";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Bookman Old Style", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(124, 44);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(459, 56);
            this.lblTitle.TabIndex = 47;
            this.lblTitle.Text = "Select Customer :";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logo_img
            // 
            this.logo_img.BackColor = System.Drawing.Color.Transparent;
            this.logo_img.Image = global::MiniGram.Properties.Resources.customer;
            this.logo_img.Location = new System.Drawing.Point(16, 23);
            this.logo_img.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logo_img.Name = "logo_img";
            this.logo_img.Size = new System.Drawing.Size(100, 92);
            this.logo_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_img.TabIndex = 48;
            this.logo_img.TabStop = false;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.AutoGenerateColumns = false;
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomers.ColumnHeadersHeight = 50;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dgvCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvCustomers.DataSource = this.tBLCUSTOMERBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustomers.EnableHeadersVisualStyles = false;
            this.dgvCustomers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.dgvCustomers.Location = new System.Drawing.Point(16, 245);
            this.dgvCustomers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersVisible = false;
            this.dgvCustomers.RowHeadersWidth = 20;
            this.dgvCustomers.RowTemplate.Height = 30;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(968, 384);
            this.dgvCustomers.TabIndex = 49;
            this.dgvCustomers.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvCustomers_KeyUp);
            // 
            // tBLCUSTOMERBindingSource
            // 
            this.tBLCUSTOMERBindingSource.DataSource = typeof(MiniGram.LINQ.TBLCUSTOMER);
            // 
            // txtCustomerNameOrID
            // 
            this.txtCustomerNameOrID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtCustomerNameOrID.BeforeTouchSize = new System.Drawing.Size(849, 50);
            this.txtCustomerNameOrID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtCustomerNameOrID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerNameOrID.CanOverrideStyle = true;
            this.txtCustomerNameOrID.CornerRadius = 5;
            this.txtCustomerNameOrID.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtCustomerNameOrID.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtCustomerNameOrID.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerNameOrID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtCustomerNameOrID.Location = new System.Drawing.Point(16, 180);
            this.txtCustomerNameOrID.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.txtCustomerNameOrID.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtCustomerNameOrID.MinimumSize = new System.Drawing.Size(44, 30);
            this.txtCustomerNameOrID.Name = "txtCustomerNameOrID";
            this.txtCustomerNameOrID.Size = new System.Drawing.Size(849, 50);
            this.txtCustomerNameOrID.TabIndex = 50;
            this.txtCustomerNameOrID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCustomerNameOrID.ThemeName = "Default";
            this.txtCustomerNameOrID.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtCustomerNameOrID.ThemeStyle.CornerRadius = 5;
            this.txtCustomerNameOrID.ThemeStyle.DisabledBackColor = System.Drawing.Color.Gray;
            this.txtCustomerNameOrID.ThemeStyle.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.txtCustomerNameOrID.ThemeStyle.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.txtCustomerNameOrID.ThemeStyle.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.txtCustomerNameOrID.ThemeStyle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerNameOrID.ThemeStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtCustomerNameOrID.ThemeStyle.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.txtCustomerNameOrID.UseBorderColorOnFocus = true;
            this.txtCustomerNameOrID.TextChanged += new System.EventHandler(this.txtCustomerNameOrID_TextChanged);
            this.txtCustomerNameOrID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCustomerNameOrID_KeyUp);
            // 
            // accept_btn
            // 
            this.accept_btn.AccessibleName = "Button";
            this.accept_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.accept_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.accept_btn.CanOverrideStyle = true;
            this.accept_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accept_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accept_btn.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accept_btn.ForeColor = System.Drawing.Color.White;
            this.accept_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.accept_btn.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.accept_btn.ImageMargin = new System.Windows.Forms.Padding(0);
            this.accept_btn.ImageSize = new System.Drawing.Size(40, 40);
            this.accept_btn.Location = new System.Drawing.Point(16, 645);
            this.accept_btn.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.accept_btn.Name = "accept_btn";
            this.accept_btn.Size = new System.Drawing.Size(968, 74);
            this.accept_btn.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.accept_btn.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.accept_btn.Style.FocusedForeColor = System.Drawing.Color.White;
            this.accept_btn.Style.ForeColor = System.Drawing.Color.White;
            this.accept_btn.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.accept_btn.Style.HoverForeColor = System.Drawing.Color.White;
            this.accept_btn.Style.HoverImageForeColor = System.Drawing.Color.Empty;
            this.accept_btn.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.accept_btn.Style.PressedForeColor = System.Drawing.Color.White;
            this.accept_btn.TabIndex = 51;
            this.accept_btn.Text = "Accept";
            this.accept_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.accept_btn.TextMargin = new System.Windows.Forms.Padding(0);
            this.accept_btn.ThemeName = "Office2016Colorful";
            this.accept_btn.UseVisualStyleBackColor = false;
            this.accept_btn.Click += new System.EventHandler(this.accept_btn_Click);
            this.accept_btn.KeyUp += new System.Windows.Forms.KeyEventHandler(this.accept_btn_KeyUp);
            // 
            // timerRefreshDataDelay
            // 
            this.timerRefreshDataDelay.Interval = 250;
            this.timerRefreshDataDelay.Tick += new System.EventHandler(this.timerRefreshDataDelay_Tick);
            // 
            // chkboxVIP
            // 
            this.chkboxVIP.AutoSize = true;
            this.chkboxVIP.Checked = true;
            this.chkboxVIP.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkboxVIP.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxVIP.ForeColor = System.Drawing.Color.White;
            this.chkboxVIP.Location = new System.Drawing.Point(884, 187);
            this.chkboxVIP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkboxVIP.Name = "chkboxVIP";
            this.chkboxVIP.Size = new System.Drawing.Size(91, 40);
            this.chkboxVIP.TabIndex = 52;
            this.chkboxVIP.Text = "VIP";
            this.chkboxVIP.ThreeState = true;
            this.chkboxVIP.UseVisualStyleBackColor = true;
            this.chkboxVIP.CheckedChanged += new System.EventHandler(this.chkboxVIP_CheckedChanged);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 80;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.FillWeight = 10.20409F;
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "Full Name";
            this.fullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.FillWeight = 279.5918F;
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneNumberDataGridViewTextBoxColumn.Width = 120;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.FillWeight = 10.20409F;
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 230;
            // 
            // ChooseCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1000, 738);
            this.Controls.Add(this.chkboxVIP);
            this.Controls.Add(this.accept_btn);
            this.Controls.Add(this.txtCustomerNameOrID);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.logo_img);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.keyboard_btn);
            this.Controls.Add(this.exit_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChooseCustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChooseCustomerForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ChooseCustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLCUSTOMERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerNameOrID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.WinForms.Controls.SfButton keyboard_btn;
        private Syncfusion.WinForms.Controls.SfButton exit_btn;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox logo_img;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtCustomerNameOrID;
        private System.Windows.Forms.BindingSource tBLCUSTOMERBindingSource;
        private Syncfusion.WinForms.Controls.SfButton accept_btn;
        private System.Windows.Forms.Timer timerRefreshDataDelay;
        private System.Windows.Forms.CheckBox chkboxVIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}