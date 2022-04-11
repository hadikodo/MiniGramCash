namespace MiniGram.Controls
{
    partial class POSUC
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.products_panel = new System.Windows.Forms.Panel();
            this.search_panel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.delete_btn = new Syncfusion.WinForms.Controls.SfButton();
            this.change_quantity_btn = new Syncfusion.WinForms.Controls.SfButton();
            this.search_txt = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.search_btn = new Syncfusion.WinForms.Controls.SfButton();
            this.receipt_panel = new System.Windows.Forms.Panel();
            this.receipt_details = new System.Windows.Forms.DataGridView();
            this.total_panel = new System.Windows.Forms.Panel();
            this.tot_lbp = new System.Windows.Forms.Label();
            this.tot_dollar = new System.Windows.Forms.Label();
            this.tot_quantity = new System.Windows.Forms.Label();
            this.receipt_id = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkout_btn = new Syncfusion.WinForms.Controls.SfButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.spselectReceiptsResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DollarPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LBPPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalLBP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalDollar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.search_panel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search_txt)).BeginInit();
            this.receipt_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receipt_details)).BeginInit();
            this.total_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spselectReceiptsResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.products_panel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.search_panel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.receipt_panel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.total_panel, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1024, 768);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // products_panel
            // 
            this.products_panel.AutoScroll = true;
            this.products_panel.AutoScrollMinSize = new System.Drawing.Size(0, 20000);
            this.products_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.products_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.products_panel.Location = new System.Drawing.Point(3, 83);
            this.products_panel.Name = "products_panel";
            this.tableLayoutPanel1.SetRowSpan(this.products_panel, 2);
            this.products_panel.Size = new System.Drawing.Size(608, 682);
            this.products_panel.TabIndex = 0;
            // 
            // search_panel
            // 
            this.search_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.tableLayoutPanel1.SetColumnSpan(this.search_panel, 2);
            this.search_panel.Controls.Add(this.tableLayoutPanel2);
            this.search_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search_panel.Location = new System.Drawing.Point(3, 3);
            this.search_panel.Name = "search_panel";
            this.search_panel.Size = new System.Drawing.Size(1018, 74);
            this.search_panel.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.delete_btn, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.change_quantity_btn, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.search_txt, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.search_btn, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1018, 74);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // delete_btn
            // 
            this.delete_btn.AccessibleName = "Button";
            this.delete_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.delete_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.delete_btn.CanOverrideStyle = true;
            this.delete_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.ForeColor = System.Drawing.Color.White;
            this.delete_btn.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.delete_btn.ImageMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.delete_btn.ImageSize = new System.Drawing.Size(55, 55);
            this.delete_btn.Location = new System.Drawing.Point(914, 0);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(0);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(104, 74);
            this.delete_btn.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.delete_btn.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.delete_btn.Style.FocusedForeColor = System.Drawing.Color.White;
            this.delete_btn.Style.ForeColor = System.Drawing.Color.White;
            this.delete_btn.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.delete_btn.Style.HoverForeColor = System.Drawing.Color.White;
            this.delete_btn.Style.HoverImageForeColor = System.Drawing.Color.Empty;
            this.delete_btn.Style.Image = global::MiniGram.Properties.Resources.delete;
            this.delete_btn.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.delete_btn.Style.PressedForeColor = System.Drawing.Color.White;
            this.delete_btn.TabIndex = 20;
            this.delete_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.delete_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.delete_btn.TextMargin = new System.Windows.Forms.Padding(0);
            this.delete_btn.ThemeName = "Office2016Colorful";
            this.toolTip1.SetToolTip(this.delete_btn, "Delete The Selected Product");
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // change_quantity_btn
            // 
            this.change_quantity_btn.AccessibleName = "Button";
            this.change_quantity_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.change_quantity_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.change_quantity_btn.CanOverrideStyle = true;
            this.change_quantity_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.change_quantity_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.change_quantity_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.change_quantity_btn.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change_quantity_btn.ForeColor = System.Drawing.Color.White;
            this.change_quantity_btn.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.change_quantity_btn.ImageMargin = new System.Windows.Forms.Padding(0);
            this.change_quantity_btn.ImageSize = new System.Drawing.Size(55, 55);
            this.change_quantity_btn.Location = new System.Drawing.Point(813, 0);
            this.change_quantity_btn.Margin = new System.Windows.Forms.Padding(0);
            this.change_quantity_btn.Name = "change_quantity_btn";
            this.change_quantity_btn.Size = new System.Drawing.Size(101, 74);
            this.change_quantity_btn.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.change_quantity_btn.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.change_quantity_btn.Style.FocusedForeColor = System.Drawing.Color.White;
            this.change_quantity_btn.Style.ForeColor = System.Drawing.Color.White;
            this.change_quantity_btn.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.change_quantity_btn.Style.HoverForeColor = System.Drawing.Color.White;
            this.change_quantity_btn.Style.HoverImageForeColor = System.Drawing.Color.Empty;
            this.change_quantity_btn.Style.Image = global::MiniGram.Properties.Resources.boxes;
            this.change_quantity_btn.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.change_quantity_btn.Style.PressedForeColor = System.Drawing.Color.White;
            this.change_quantity_btn.TabIndex = 19;
            this.change_quantity_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.change_quantity_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.change_quantity_btn.TextMargin = new System.Windows.Forms.Padding(0);
            this.change_quantity_btn.ThemeName = "Office2016Colorful";
            this.toolTip1.SetToolTip(this.change_quantity_btn, "Change The Quantity Of The Selected Product");
            this.change_quantity_btn.UseVisualStyleBackColor = true;
            this.change_quantity_btn.Click += new System.EventHandler(this.change_quantity_btn_Click);
            // 
            // search_txt
            // 
            this.search_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.search_txt.BeforeTouchSize = new System.Drawing.Size(400, 40);
            this.search_txt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.search_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.search_txt.CanOverrideStyle = true;
            this.search_txt.CornerRadius = 5;
            this.search_txt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.search_txt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.search_txt.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.search_txt.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.search_txt.Location = new System.Drawing.Point(10, 24);
            this.search_txt.Margin = new System.Windows.Forms.Padding(10);
            this.search_txt.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.search_txt.MinimumSize = new System.Drawing.Size(34, 30);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(489, 40);
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
            this.search_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.ForeColor = System.Drawing.Color.White;
            this.search_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.search_btn.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.search_btn.ImageMargin = new System.Windows.Forms.Padding(0);
            this.search_btn.ImageSize = new System.Drawing.Size(40, 40);
            this.search_btn.Location = new System.Drawing.Point(519, 24);
            this.search_btn.Margin = new System.Windows.Forms.Padding(10);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(81, 40);
            this.search_btn.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.search_btn.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.search_btn.Style.FocusedForeColor = System.Drawing.Color.White;
            this.search_btn.Style.ForeColor = System.Drawing.Color.White;
            this.search_btn.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.search_btn.Style.HoverForeColor = System.Drawing.Color.White;
            this.search_btn.Style.HoverImageForeColor = System.Drawing.Color.Empty;
            this.search_btn.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.search_btn.Style.PressedForeColor = System.Drawing.Color.White;
            this.search_btn.TabIndex = 18;
            this.search_btn.Text = "Add";
            this.search_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.search_btn.TextMargin = new System.Windows.Forms.Padding(0);
            this.search_btn.ThemeName = "Office2016Colorful";
            this.toolTip1.SetToolTip(this.search_btn, "Add Product To Receipt");
            this.search_btn.UseVisualStyleBackColor = true;
            // 
            // receipt_panel
            // 
            this.receipt_panel.BackColor = System.Drawing.Color.White;
            this.receipt_panel.Controls.Add(this.receipt_details);
            this.receipt_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.receipt_panel.Location = new System.Drawing.Point(617, 83);
            this.receipt_panel.Name = "receipt_panel";
            this.receipt_panel.Size = new System.Drawing.Size(404, 406);
            this.receipt_panel.TabIndex = 2;
            // 
            // receipt_details
            // 
            this.receipt_details.AllowUserToAddRows = false;
            this.receipt_details.AllowUserToDeleteRows = false;
            this.receipt_details.AllowUserToResizeColumns = false;
            this.receipt_details.AllowUserToResizeRows = false;
            this.receipt_details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.receipt_details.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.receipt_details.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.receipt_details.ColumnHeadersHeight = 40;
            this.receipt_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.receipt_details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Barcode,
            this.PNAME,
            this.QTE,
            this.DollarPrice,
            this.LBPPrice,
            this.TotalLBP,
            this.TotalDollar});
            this.receipt_details.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.receipt_details.DefaultCellStyle = dataGridViewCellStyle2;
            this.receipt_details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.receipt_details.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.receipt_details.Location = new System.Drawing.Point(0, 0);
            this.receipt_details.MultiSelect = false;
            this.receipt_details.Name = "receipt_details";
            this.receipt_details.ReadOnly = true;
            this.receipt_details.RowHeadersWidth = 10;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.receipt_details.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.receipt_details.RowTemplate.Height = 35;
            this.receipt_details.RowTemplate.ReadOnly = true;
            this.receipt_details.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.receipt_details.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.receipt_details.Size = new System.Drawing.Size(404, 406);
            this.receipt_details.TabIndex = 1;
            // 
            // total_panel
            // 
            this.total_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.total_panel.Controls.Add(this.tot_lbp);
            this.total_panel.Controls.Add(this.tot_dollar);
            this.total_panel.Controls.Add(this.tot_quantity);
            this.total_panel.Controls.Add(this.receipt_id);
            this.total_panel.Controls.Add(this.label3);
            this.total_panel.Controls.Add(this.label2);
            this.total_panel.Controls.Add(this.label1);
            this.total_panel.Controls.Add(this.label6);
            this.total_panel.Controls.Add(this.checkout_btn);
            this.total_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.total_panel.Location = new System.Drawing.Point(617, 495);
            this.total_panel.Name = "total_panel";
            this.total_panel.Size = new System.Drawing.Size(404, 270);
            this.total_panel.TabIndex = 3;
            // 
            // tot_lbp
            // 
            this.tot_lbp.BackColor = System.Drawing.Color.White;
            this.tot_lbp.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tot_lbp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.tot_lbp.Location = new System.Drawing.Point(234, 151);
            this.tot_lbp.Name = "tot_lbp";
            this.tot_lbp.Size = new System.Drawing.Size(160, 24);
            this.tot_lbp.TabIndex = 30;
            this.tot_lbp.Text = "0 LBP";
            this.tot_lbp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tot_dollar
            // 
            this.tot_dollar.BackColor = System.Drawing.Color.White;
            this.tot_dollar.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tot_dollar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.tot_dollar.Location = new System.Drawing.Point(234, 107);
            this.tot_dollar.Name = "tot_dollar";
            this.tot_dollar.Size = new System.Drawing.Size(160, 24);
            this.tot_dollar.TabIndex = 29;
            this.tot_dollar.Text = "0 $";
            this.tot_dollar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tot_quantity
            // 
            this.tot_quantity.BackColor = System.Drawing.Color.White;
            this.tot_quantity.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tot_quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.tot_quantity.Location = new System.Drawing.Point(234, 62);
            this.tot_quantity.Name = "tot_quantity";
            this.tot_quantity.Size = new System.Drawing.Size(160, 24);
            this.tot_quantity.TabIndex = 28;
            this.tot_quantity.Text = "0";
            this.tot_quantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // receipt_id
            // 
            this.receipt_id.BackColor = System.Drawing.Color.White;
            this.receipt_id.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receipt_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.receipt_id.Location = new System.Drawing.Point(234, 15);
            this.receipt_id.Name = "receipt_id";
            this.receipt_id.Size = new System.Drawing.Size(160, 24);
            this.receipt_id.TabIndex = 27;
            this.receipt_id.Text = "0";
            this.receipt_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "Receipt ID : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "Total Quantity : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Total Price in LBP: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(14, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 24);
            this.label6.TabIndex = 23;
            this.label6.Text = "Total Price in $ : ";
            // 
            // checkout_btn
            // 
            this.checkout_btn.AccessibleName = "Button";
            this.checkout_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.checkout_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checkout_btn.CanOverrideStyle = true;
            this.checkout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkout_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.checkout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkout_btn.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkout_btn.ForeColor = System.Drawing.Color.White;
            this.checkout_btn.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checkout_btn.ImageMargin = new System.Windows.Forms.Padding(0);
            this.checkout_btn.ImageSize = new System.Drawing.Size(65, 65);
            this.checkout_btn.Location = new System.Drawing.Point(0, 195);
            this.checkout_btn.Margin = new System.Windows.Forms.Padding(0);
            this.checkout_btn.Name = "checkout_btn";
            this.checkout_btn.Size = new System.Drawing.Size(404, 75);
            this.checkout_btn.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.checkout_btn.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.checkout_btn.Style.FocusedForeColor = System.Drawing.Color.White;
            this.checkout_btn.Style.ForeColor = System.Drawing.Color.White;
            this.checkout_btn.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.checkout_btn.Style.HoverForeColor = System.Drawing.Color.White;
            this.checkout_btn.Style.HoverImageForeColor = System.Drawing.Color.Empty;
            this.checkout_btn.Style.Image = global::MiniGram.Properties.Resources.cashier;
            this.checkout_btn.Style.PressedBackColor = System.Drawing.Color.White;
            this.checkout_btn.Style.PressedForeColor = System.Drawing.Color.White;
            this.checkout_btn.TabIndex = 13;
            this.checkout_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.checkout_btn.TextMargin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.checkout_btn.ThemeName = "Office2016Colorful";
            this.toolTip1.SetToolTip(this.checkout_btn, "CHECKOUT");
            this.checkout_btn.UseVisualStyleBackColor = false;
            this.checkout_btn.Click += new System.EventHandler(this.checkout_btn_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 300;
            // 
            // spselectReceiptsResultBindingSource
            // 
            this.spselectReceiptsResultBindingSource.DataSource = typeof(MiniGram.LINQ.sp_selectReceiptsResult);
            // 
            // Barcode
            // 
            this.Barcode.FillWeight = 40F;
            this.Barcode.HeaderText = "Barcode";
            this.Barcode.Name = "Barcode";
            this.Barcode.ReadOnly = true;
            // 
            // PNAME
            // 
            this.PNAME.HeaderText = "Name";
            this.PNAME.Name = "PNAME";
            this.PNAME.ReadOnly = true;
            // 
            // QTE
            // 
            this.QTE.FillWeight = 30F;
            this.QTE.HeaderText = "Items";
            this.QTE.Name = "QTE";
            this.QTE.ReadOnly = true;
            // 
            // DollarPrice
            // 
            this.DollarPrice.FillWeight = 30F;
            this.DollarPrice.HeaderText = "Dollar";
            this.DollarPrice.Name = "DollarPrice";
            this.DollarPrice.ReadOnly = true;
            // 
            // LBPPrice
            // 
            this.LBPPrice.FillWeight = 30F;
            this.LBPPrice.HeaderText = "LBP";
            this.LBPPrice.Name = "LBPPrice";
            this.LBPPrice.ReadOnly = true;
            // 
            // TotalLBP
            // 
            this.TotalLBP.FillWeight = 40F;
            this.TotalLBP.HeaderText = "Tot. LBP";
            this.TotalLBP.Name = "TotalLBP";
            this.TotalLBP.ReadOnly = true;
            // 
            // TotalDollar
            // 
            this.TotalDollar.FillWeight = 30F;
            this.TotalDollar.HeaderText = "Tot. $";
            this.TotalDollar.Name = "TotalDollar";
            this.TotalDollar.ReadOnly = true;
            // 
            // POSUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "POSUC";
            this.Size = new System.Drawing.Size(1024, 768);
            this.Load += new System.EventHandler(this.POSUC_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.search_panel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search_txt)).EndInit();
            this.receipt_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.receipt_details)).EndInit();
            this.total_panel.ResumeLayout(false);
            this.total_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spselectReceiptsResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel products_panel;
        private System.Windows.Forms.Panel search_panel;
        private System.Windows.Forms.Panel receipt_panel;
        private System.Windows.Forms.Panel total_panel;
        private Syncfusion.WinForms.Controls.SfButton checkout_btn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView receipt_details;
        private System.Windows.Forms.BindingSource spselectReceiptsResultBindingSource;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label tot_lbp;
        private System.Windows.Forms.Label tot_dollar;
        private System.Windows.Forms.Label tot_quantity;
        private System.Windows.Forms.Label receipt_id;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt search_txt;
        private Syncfusion.WinForms.Controls.SfButton search_btn;
        private Syncfusion.WinForms.Controls.SfButton change_quantity_btn;
        private Syncfusion.WinForms.Controls.SfButton delete_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn PNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DollarPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn LBPPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalLBP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDollar;
    }
}
