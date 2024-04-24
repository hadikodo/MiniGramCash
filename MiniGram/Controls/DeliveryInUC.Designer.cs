
namespace MiniGram.Controls
{
    partial class DeliveryInUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timerRefreshDataDelay = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarcodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalDollarColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalLBPColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalTVAColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalDiscountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddedDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrencyIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CrrencyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.spselectDeliveryReceiptsResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnUnlock = new Syncfusion.WinForms.Controls.SfButton();
            this.keyboard_btn = new Syncfusion.WinForms.Controls.SfButton();
            this.search_btn = new Syncfusion.WinForms.Controls.SfButton();
            this.btnAddDeliveryIn = new Syncfusion.WinForms.Controls.SfButton();
            this.search_txt = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxStatusFilter = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tBLSTATUSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spselectDeliveryReceiptsResultBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search_txt)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSTATUSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // timerRefreshDataDelay
            // 
            this.timerRefreshDataDelay.Interval = 500;
            this.timerRefreshDataDelay.Tick += new System.EventHandler(this.timerRefreshDataDelay_Tick);
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
            this.tableLayoutPanel1.TabIndex = 2;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.BarcodeColumn,
            this.QuantityColumn,
            this.TotalDollarColumn,
            this.TotalLBPColumn,
            this.TotalTVAColumn,
            this.TotalDiscountColumn,
            this.AddedDateColumn,
            this.CurrencyIDColumn,
            this.CrrencyColumn,
            this.UserIDColumn,
            this.StatusIDColumn,
            this.StatusNameColumn,
            this.EditColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.DataSource = this.spselectDeliveryReceiptsResultBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 10;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1012, 681);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // IDColumn
            // 
            this.IDColumn.DataPropertyName = "ID";
            this.IDColumn.HeaderText = "ID";
            this.IDColumn.Name = "IDColumn";
            this.IDColumn.ReadOnly = true;
            this.IDColumn.Visible = false;
            // 
            // BarcodeColumn
            // 
            this.BarcodeColumn.DataPropertyName = "BARCODE";
            this.BarcodeColumn.HeaderText = "BARCODE";
            this.BarcodeColumn.Name = "BarcodeColumn";
            this.BarcodeColumn.ReadOnly = true;
            // 
            // QuantityColumn
            // 
            this.QuantityColumn.DataPropertyName = "NumberOfItem";
            this.QuantityColumn.HeaderText = "Quantity";
            this.QuantityColumn.Name = "QuantityColumn";
            this.QuantityColumn.ReadOnly = true;
            // 
            // TotalDollarColumn
            // 
            this.TotalDollarColumn.DataPropertyName = "TotalDolarPrice";
            this.TotalDollarColumn.HeaderText = "Tot. $";
            this.TotalDollarColumn.Name = "TotalDollarColumn";
            this.TotalDollarColumn.ReadOnly = true;
            // 
            // TotalLBPColumn
            // 
            this.TotalLBPColumn.DataPropertyName = "TotalLBPPrice";
            this.TotalLBPColumn.HeaderText = "Tot. LBP";
            this.TotalLBPColumn.Name = "TotalLBPColumn";
            this.TotalLBPColumn.ReadOnly = true;
            // 
            // TotalTVAColumn
            // 
            this.TotalTVAColumn.DataPropertyName = "TotalTVAPrice";
            this.TotalTVAColumn.HeaderText = "Tot. TVA";
            this.TotalTVAColumn.Name = "TotalTVAColumn";
            this.TotalTVAColumn.ReadOnly = true;
            // 
            // TotalDiscountColumn
            // 
            this.TotalDiscountColumn.DataPropertyName = "TotalDiscount";
            this.TotalDiscountColumn.HeaderText = "Tot. Discount";
            this.TotalDiscountColumn.Name = "TotalDiscountColumn";
            this.TotalDiscountColumn.ReadOnly = true;
            // 
            // AddedDateColumn
            // 
            this.AddedDateColumn.DataPropertyName = "Date";
            this.AddedDateColumn.HeaderText = "Added Date";
            this.AddedDateColumn.Name = "AddedDateColumn";
            this.AddedDateColumn.ReadOnly = true;
            // 
            // CurrencyIDColumn
            // 
            this.CurrencyIDColumn.DataPropertyName = "CurrencyID";
            this.CurrencyIDColumn.HeaderText = "CurrencyID";
            this.CurrencyIDColumn.Name = "CurrencyIDColumn";
            this.CurrencyIDColumn.ReadOnly = true;
            this.CurrencyIDColumn.Visible = false;
            // 
            // CrrencyColumn
            // 
            this.CrrencyColumn.DataPropertyName = "CurrencyName";
            this.CrrencyColumn.HeaderText = "Currency";
            this.CrrencyColumn.Name = "CrrencyColumn";
            this.CrrencyColumn.ReadOnly = true;
            // 
            // UserIDColumn
            // 
            this.UserIDColumn.DataPropertyName = "UserID";
            this.UserIDColumn.HeaderText = "UserID";
            this.UserIDColumn.Name = "UserIDColumn";
            this.UserIDColumn.ReadOnly = true;
            this.UserIDColumn.Visible = false;
            // 
            // StatusIDColumn
            // 
            this.StatusIDColumn.DataPropertyName = "StatusID";
            this.StatusIDColumn.HeaderText = "StatusID";
            this.StatusIDColumn.Name = "StatusIDColumn";
            this.StatusIDColumn.ReadOnly = true;
            this.StatusIDColumn.Visible = false;
            // 
            // StatusNameColumn
            // 
            this.StatusNameColumn.DataPropertyName = "StatusName";
            this.StatusNameColumn.HeaderText = "Status";
            this.StatusNameColumn.Name = "StatusNameColumn";
            this.StatusNameColumn.ReadOnly = true;
            // 
            // EditColumn
            // 
            this.EditColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EditColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditColumn.HeaderText = "";
            this.EditColumn.Name = "EditColumn";
            this.EditColumn.ReadOnly = true;
            this.EditColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EditColumn.Text = "Open =>";
            this.EditColumn.ToolTipText = "Open ";
            this.EditColumn.UseColumnTextForButtonValue = true;
            // 
            // spselectDeliveryReceiptsResultBindingSource
            // 
            this.spselectDeliveryReceiptsResultBindingSource.DataSource = typeof(MiniGram.LINQ.sp_selectDeliveryReceiptsResult);
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
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnUnlock, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.keyboard_btn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.search_btn, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAddDeliveryIn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.search_txt, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1018, 69);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnUnlock
            // 
            this.btnUnlock.AccessibleName = "Button";
            this.btnUnlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnUnlock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUnlock.CanOverrideStyle = true;
            this.btnUnlock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnlock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUnlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnlock.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnlock.ForeColor = System.Drawing.Color.White;
            this.btnUnlock.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUnlock.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUnlock.ImageMargin = new System.Windows.Forms.Padding(0);
            this.btnUnlock.ImageSize = new System.Drawing.Size(35, 35);
            this.btnUnlock.Location = new System.Drawing.Point(918, 0);
            this.btnUnlock.Margin = new System.Windows.Forms.Padding(0);
            this.btnUnlock.Name = "btnUnlock";
            this.btnUnlock.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnUnlock.Size = new System.Drawing.Size(100, 69);
            this.btnUnlock.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnUnlock.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnUnlock.Style.FocusedForeColor = System.Drawing.Color.White;
            this.btnUnlock.Style.ForeColor = System.Drawing.Color.White;
            this.btnUnlock.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.btnUnlock.Style.HoverForeColor = System.Drawing.Color.White;
            this.btnUnlock.Style.HoverImageForeColor = System.Drawing.Color.Empty;
            this.btnUnlock.Style.Image = global::MiniGram.Properties.Resources._unchecked;
            this.btnUnlock.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.btnUnlock.Style.PressedForeColor = System.Drawing.Color.White;
            this.btnUnlock.TabIndex = 23;
            this.btnUnlock.Text = "Unlock";
            this.btnUnlock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUnlock.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.btnUnlock.TextMargin = new System.Windows.Forms.Padding(0);
            this.btnUnlock.ThemeName = "Office2016Colorful";
            this.toolTip1.SetToolTip(this.btnUnlock, "Unlock Thias Receipt.");
            this.btnUnlock.UseVisualStyleBackColor = true;
            this.btnUnlock.Visible = false;
            this.btnUnlock.Click += new System.EventHandler(this.btnUnlock_Click);
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
            this.keyboard_btn.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyboard_btn.ForeColor = System.Drawing.Color.White;
            this.keyboard_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.keyboard_btn.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.keyboard_btn.ImageMargin = new System.Windows.Forms.Padding(0);
            this.keyboard_btn.ImageSize = new System.Drawing.Size(45, 45);
            this.keyboard_btn.Location = new System.Drawing.Point(100, 0);
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
            this.keyboard_btn.TabIndex = 22;
            this.keyboard_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.keyboard_btn.TextMargin = new System.Windows.Forms.Padding(0);
            this.keyboard_btn.ThemeName = "Office2016Colorful";
            this.toolTip1.SetToolTip(this.keyboard_btn, "Open Touch Keyboard");
            this.keyboard_btn.UseVisualStyleBackColor = true;
            this.keyboard_btn.Click += new System.EventHandler(this.keyboard_btn_Click);
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
            this.search_btn.Location = new System.Drawing.Point(200, 0);
            this.search_btn.Margin = new System.Windows.Forms.Padding(0);
            this.search_btn.Name = "search_btn";
            this.search_btn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
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
            this.search_btn.TabIndex = 15;
            this.search_btn.Text = "Search";
            this.search_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.search_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.search_btn.TextMargin = new System.Windows.Forms.Padding(0);
            this.search_btn.ThemeName = "Office2016Colorful";
            this.toolTip1.SetToolTip(this.search_btn, "Search In Delivery In.");
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // btnAddDeliveryIn
            // 
            this.btnAddDeliveryIn.AccessibleName = "Button";
            this.btnAddDeliveryIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnAddDeliveryIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddDeliveryIn.CanOverrideStyle = true;
            this.btnAddDeliveryIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDeliveryIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddDeliveryIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDeliveryIn.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDeliveryIn.ForeColor = System.Drawing.Color.White;
            this.btnAddDeliveryIn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddDeliveryIn.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddDeliveryIn.ImageMargin = new System.Windows.Forms.Padding(0);
            this.btnAddDeliveryIn.ImageSize = new System.Drawing.Size(35, 35);
            this.btnAddDeliveryIn.Location = new System.Drawing.Point(0, 0);
            this.btnAddDeliveryIn.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddDeliveryIn.Name = "btnAddDeliveryIn";
            this.btnAddDeliveryIn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnAddDeliveryIn.Size = new System.Drawing.Size(100, 69);
            this.btnAddDeliveryIn.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnAddDeliveryIn.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnAddDeliveryIn.Style.FocusedForeColor = System.Drawing.Color.White;
            this.btnAddDeliveryIn.Style.ForeColor = System.Drawing.Color.White;
            this.btnAddDeliveryIn.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.btnAddDeliveryIn.Style.HoverForeColor = System.Drawing.Color.White;
            this.btnAddDeliveryIn.Style.HoverImageForeColor = System.Drawing.Color.Empty;
            this.btnAddDeliveryIn.Style.Image = global::MiniGram.Properties.Resources.shipping;
            this.btnAddDeliveryIn.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.btnAddDeliveryIn.Style.PressedForeColor = System.Drawing.Color.White;
            this.btnAddDeliveryIn.TabIndex = 12;
            this.btnAddDeliveryIn.Text = "Add";
            this.btnAddDeliveryIn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddDeliveryIn.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.btnAddDeliveryIn.TextMargin = new System.Windows.Forms.Padding(0);
            this.btnAddDeliveryIn.ThemeName = "Office2016Colorful";
            this.toolTip1.SetToolTip(this.btnAddDeliveryIn, "Add New Delivery In.");
            this.btnAddDeliveryIn.UseVisualStyleBackColor = true;
            this.btnAddDeliveryIn.Click += new System.EventHandler(this.btnAddDeliveryIn_Click);
            // 
            // search_txt
            // 
            this.search_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.search_txt.BeforeTouchSize = new System.Drawing.Size(34, 30);
            this.search_txt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.search_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.search_txt.CanOverrideStyle = true;
            this.search_txt.CornerRadius = 5;
            this.search_txt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.search_txt.Dock = System.Windows.Forms.DockStyle.Left;
            this.search_txt.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.search_txt.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.search_txt.Location = new System.Drawing.Point(303, 3);
            this.search_txt.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.search_txt.MinimumSize = new System.Drawing.Size(34, 30);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(34, 30);
            this.search_txt.TabIndex = 16;
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
            this.toolTip1.SetToolTip(this.search_txt, "The Barcode Or The ID of The Delivery In.");
            this.search_txt.UseBorderColorOnFocus = true;
            this.search_txt.TextChanged += new System.EventHandler(this.search_txt_TextChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.cboxStatusFilter, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(621, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(194, 63);
            this.tableLayoutPanel4.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboxStatusFilter
            // 
            this.cboxStatusFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboxStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxStatusFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxStatusFilter.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxStatusFilter.FormattingEnabled = true;
            this.cboxStatusFilter.Location = new System.Drawing.Point(3, 34);
            this.cboxStatusFilter.Name = "cboxStatusFilter";
            this.cboxStatusFilter.Size = new System.Drawing.Size(188, 27);
            this.cboxStatusFilter.TabIndex = 1;
            this.cboxStatusFilter.SelectedIndexChanged += new System.EventHandler(this.cboxStatusFilter_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tBLSTATUSBindingSource
            // 
            this.tBLSTATUSBindingSource.DataSource = typeof(MiniGram.LINQ.TBLSTATUS);
            // 
            // DeliveryInUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DeliveryInUC";
            this.Size = new System.Drawing.Size(1024, 768);
            this.Load += new System.EventHandler(this.DeliveryInUC_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spselectDeliveryReceiptsResultBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search_txt)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSTATUSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerRefreshDataDelay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ToolTip toolTip1;
        private Syncfusion.WinForms.Controls.SfButton keyboard_btn;
        private Syncfusion.WinForms.Controls.SfButton search_btn;
        private Syncfusion.WinForms.Controls.SfButton btnAddDeliveryIn;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt search_txt;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.BindingSource spselectDeliveryReceiptsResultBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarcodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDollarColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalLBPColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalTVAColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDiscountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddedDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrencyIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CrrencyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusNameColumn;
        private System.Windows.Forms.DataGridViewButtonColumn EditColumn;
        private Syncfusion.WinForms.Controls.SfButton btnUnlock;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxStatusFilter;
        private System.Windows.Forms.BindingSource tBLSTATUSBindingSource;
    }
}
