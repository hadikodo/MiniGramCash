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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.products_panel = new System.Windows.Forms.Panel();
            this.search_panel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.cboxDiscount = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.search_txt = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblReceiptType = new System.Windows.Forms.Label();
            this.btnSwitch = new Syncfusion.WinForms.Controls.SfButton();
            this.btnHold = new Syncfusion.WinForms.Controls.SfButton();
            this.keyboard_btn = new Syncfusion.WinForms.Controls.SfButton();
            this.delete_btn = new Syncfusion.WinForms.Controls.SfButton();
            this.change_quantity_btn = new Syncfusion.WinForms.Controls.SfButton();
            this.add_btn = new Syncfusion.WinForms.Controls.SfButton();
            this.receipt_panel = new System.Windows.Forms.Panel();
            this.receipt_details = new System.Windows.Forms.DataGridView();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DollarPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LBPPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalLBP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalDollar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalTVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecondPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_panel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tot_final_price_lbp = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tot_final_price_dolar = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tot_tva = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.receipt_id = new System.Windows.Forms.Label();
            this.tot_quantity = new System.Windows.Forms.Label();
            this.tot_net_dollar = new System.Windows.Forms.Label();
            this.tot_discount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.btnExtCheckOut = new Syncfusion.WinForms.Controls.SfButton();
            this.checkout_btn = new Syncfusion.WinForms.Controls.SfButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timerRefreshDataDelay = new System.Windows.Forms.Timer(this.components);
            this.timerRefreshInputQte = new System.Windows.Forms.Timer(this.components);
            this.spselectReceiptsResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.search_panel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search_txt)).BeginInit();
            this.receipt_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receipt_details)).BeginInit();
            this.total_panel.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spselectReceiptsResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.products_panel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.search_panel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.receipt_panel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.total_panel, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
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
            this.products_panel.Location = new System.Drawing.Point(0, 80);
            this.products_panel.Margin = new System.Windows.Forms.Padding(0);
            this.products_panel.Name = "products_panel";
            this.tableLayoutPanel1.SetRowSpan(this.products_panel, 2);
            this.products_panel.Size = new System.Drawing.Size(307, 688);
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
            this.tableLayoutPanel2.ColumnCount = 8;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.1848F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.213551F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.213551F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.53388F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.213551F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.213551F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.213551F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.213551F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSwitch, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnHold, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.keyboard_btn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.delete_btn, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.change_quantity_btn, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.add_btn, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1018, 74);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Controls.Add(this.lblDiscount, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.cboxDiscount, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(473, 0);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(209, 74);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDiscount.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.ForeColor = System.Drawing.Color.White;
            this.lblDiscount.Location = new System.Drawing.Point(3, 0);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(203, 37);
            this.lblDiscount.TabIndex = 26;
            this.lblDiscount.Text = "Employee Discount";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboxDiscount
            // 
            this.cboxDiscount.AutoSize = true;
            this.cboxDiscount.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cboxDiscount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboxDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboxDiscount.Location = new System.Drawing.Point(3, 40);
            this.cboxDiscount.Name = "cboxDiscount";
            this.cboxDiscount.Size = new System.Drawing.Size(203, 31);
            this.cboxDiscount.TabIndex = 27;
            this.cboxDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cboxDiscount.UseVisualStyleBackColor = true;
            this.cboxDiscount.CheckedChanged += new System.EventHandler(this.cboxDiscount_CheckedChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.search_txt, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblReceiptType, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(307, 74);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // search_txt
            // 
            this.search_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.search_txt.BeforeTouchSize = new System.Drawing.Size(187, 30);
            this.search_txt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.search_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.search_txt.CanOverrideStyle = true;
            this.search_txt.CornerRadius = 5;
            this.search_txt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.search_txt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.search_txt.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.search_txt.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.search_txt.Location = new System.Drawing.Point(0, 44);
            this.search_txt.Margin = new System.Windows.Forms.Padding(0);
            this.search_txt.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.search_txt.MinimumSize = new System.Drawing.Size(34, 30);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(307, 30);
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
            this.search_txt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.search_txt_KeyUp);
            // 
            // lblReceiptType
            // 
            this.lblReceiptType.AutoSize = true;
            this.lblReceiptType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReceiptType.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiptType.ForeColor = System.Drawing.Color.White;
            this.lblReceiptType.Location = new System.Drawing.Point(3, 0);
            this.lblReceiptType.Name = "lblReceiptType";
            this.lblReceiptType.Size = new System.Drawing.Size(301, 30);
            this.lblReceiptType.TabIndex = 18;
            this.lblReceiptType.Text = "Sale Receipt";
            this.lblReceiptType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSwitch
            // 
            this.btnSwitch.AccessibleName = "Button";
            this.btnSwitch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnSwitch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSwitch.CanOverrideStyle = true;
            this.btnSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSwitch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwitch.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwitch.ForeColor = System.Drawing.Color.White;
            this.btnSwitch.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSwitch.ImageMargin = new System.Windows.Forms.Padding(0);
            this.btnSwitch.ImageSize = new System.Drawing.Size(50, 50);
            this.btnSwitch.Location = new System.Drawing.Point(685, 3);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(77, 68);
            this.btnSwitch.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnSwitch.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnSwitch.Style.FocusedForeColor = System.Drawing.Color.White;
            this.btnSwitch.Style.ForeColor = System.Drawing.Color.White;
            this.btnSwitch.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.btnSwitch.Style.HoverForeColor = System.Drawing.Color.White;
            this.btnSwitch.Style.HoverImageForeColor = System.Drawing.Color.Empty;
            this.btnSwitch.Style.Image = global::MiniGram.Properties.Resources.refresh;
            this.btnSwitch.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.btnSwitch.Style.PressedForeColor = System.Drawing.Color.White;
            this.btnSwitch.TabIndex = 24;
            this.btnSwitch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSwitch.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.btnSwitch.TextMargin = new System.Windows.Forms.Padding(0);
            this.btnSwitch.ThemeName = "Office2016Colorful";
            this.toolTip1.SetToolTip(this.btnSwitch, "Switch Between Return And Sale.");
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // btnHold
            // 
            this.btnHold.AccessibleName = "Button";
            this.btnHold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnHold.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHold.CanOverrideStyle = true;
            this.btnHold.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHold.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHold.ForeColor = System.Drawing.Color.White;
            this.btnHold.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHold.ImageMargin = new System.Windows.Forms.Padding(0);
            this.btnHold.ImageSize = new System.Drawing.Size(50, 50);
            this.btnHold.Location = new System.Drawing.Point(768, 3);
            this.btnHold.Name = "btnHold";
            this.btnHold.Size = new System.Drawing.Size(77, 68);
            this.btnHold.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnHold.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnHold.Style.FocusedForeColor = System.Drawing.Color.White;
            this.btnHold.Style.ForeColor = System.Drawing.Color.White;
            this.btnHold.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.btnHold.Style.HoverForeColor = System.Drawing.Color.White;
            this.btnHold.Style.HoverImageForeColor = System.Drawing.Color.Empty;
            this.btnHold.Style.Image = global::MiniGram.Properties.Resources.list;
            this.btnHold.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.btnHold.Style.PressedForeColor = System.Drawing.Color.White;
            this.btnHold.TabIndex = 23;
            this.btnHold.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHold.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.btnHold.TextMargin = new System.Windows.Forms.Padding(0);
            this.btnHold.ThemeName = "Office2016Colorful";
            this.toolTip1.SetToolTip(this.btnHold, "Hold This Receipt");
            this.btnHold.UseVisualStyleBackColor = true;
            this.btnHold.Click += new System.EventHandler(this.btnHold_Click);
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
            this.keyboard_btn.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.keyboard_btn.ImageMargin = new System.Windows.Forms.Padding(0);
            this.keyboard_btn.ImageSize = new System.Drawing.Size(50, 50);
            this.keyboard_btn.Location = new System.Drawing.Point(310, 3);
            this.keyboard_btn.Name = "keyboard_btn";
            this.keyboard_btn.Size = new System.Drawing.Size(77, 68);
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
            this.keyboard_btn.TabIndex = 21;
            this.keyboard_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.keyboard_btn.TextMargin = new System.Windows.Forms.Padding(0);
            this.keyboard_btn.ThemeName = "Office2016Colorful";
            this.toolTip1.SetToolTip(this.keyboard_btn, "Open Touch Keyboard");
            this.keyboard_btn.UseVisualStyleBackColor = true;
            this.keyboard_btn.Click += new System.EventHandler(this.keyboard_btn_Click);
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
            this.delete_btn.ImageSize = new System.Drawing.Size(50, 50);
            this.delete_btn.Location = new System.Drawing.Point(934, 3);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(81, 68);
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
            this.change_quantity_btn.ImageSize = new System.Drawing.Size(50, 50);
            this.change_quantity_btn.Location = new System.Drawing.Point(851, 3);
            this.change_quantity_btn.Name = "change_quantity_btn";
            this.change_quantity_btn.Size = new System.Drawing.Size(77, 68);
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
            // add_btn
            // 
            this.add_btn.AccessibleName = "Button";
            this.add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.add_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.add_btn.CanOverrideStyle = true;
            this.add_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.Color.White;
            this.add_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.add_btn.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.add_btn.ImageMargin = new System.Windows.Forms.Padding(0);
            this.add_btn.ImageSize = new System.Drawing.Size(40, 40);
            this.add_btn.Location = new System.Drawing.Point(393, 3);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(77, 68);
            this.add_btn.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.add_btn.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.add_btn.Style.FocusedForeColor = System.Drawing.Color.White;
            this.add_btn.Style.ForeColor = System.Drawing.Color.White;
            this.add_btn.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.add_btn.Style.HoverForeColor = System.Drawing.Color.White;
            this.add_btn.Style.HoverImageForeColor = System.Drawing.Color.Empty;
            this.add_btn.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.add_btn.Style.PressedForeColor = System.Drawing.Color.White;
            this.add_btn.TabIndex = 18;
            this.add_btn.Text = "Add";
            this.add_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.add_btn.TextMargin = new System.Windows.Forms.Padding(0);
            this.add_btn.ThemeName = "Office2016Colorful";
            this.toolTip1.SetToolTip(this.add_btn, "Add Product To Receipt");
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click_1);
            // 
            // receipt_panel
            // 
            this.receipt_panel.BackColor = System.Drawing.Color.White;
            this.receipt_panel.Controls.Add(this.receipt_details);
            this.receipt_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.receipt_panel.Location = new System.Drawing.Point(310, 83);
            this.receipt_panel.Name = "receipt_panel";
            this.receipt_panel.Size = new System.Drawing.Size(711, 406);
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.SupplierName,
            this.QTE,
            this.DollarPrice,
            this.LBPPrice,
            this.TotalLBP,
            this.TotalDollar,
            this.TotalTVA,
            this.TotalDiscount,
            this.SecondPrice});
            this.receipt_details.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.receipt_details.DefaultCellStyle = dataGridViewCellStyle4;
            this.receipt_details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.receipt_details.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.receipt_details.Location = new System.Drawing.Point(0, 0);
            this.receipt_details.MultiSelect = false;
            this.receipt_details.Name = "receipt_details";
            this.receipt_details.ReadOnly = true;
            this.receipt_details.RowHeadersVisible = false;
            this.receipt_details.RowHeadersWidth = 10;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.receipt_details.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.receipt_details.RowTemplate.Height = 35;
            this.receipt_details.RowTemplate.ReadOnly = true;
            this.receipt_details.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.receipt_details.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.receipt_details.Size = new System.Drawing.Size(711, 406);
            this.receipt_details.TabIndex = 1;
            // 
            // Barcode
            // 
            this.Barcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Barcode.FillWeight = 10F;
            this.Barcode.HeaderText = "Barcode";
            this.Barcode.Name = "Barcode";
            this.Barcode.ReadOnly = true;
            // 
            // PNAME
            // 
            this.PNAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PNAME.FillWeight = 23F;
            this.PNAME.HeaderText = "Name";
            this.PNAME.Name = "PNAME";
            this.PNAME.ReadOnly = true;
            // 
            // SupplierName
            // 
            this.SupplierName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SupplierName.FillWeight = 20F;
            this.SupplierName.HeaderText = "Supplier Name";
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.ReadOnly = true;
            this.SupplierName.Visible = false;
            // 
            // QTE
            // 
            this.QTE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QTE.FillWeight = 6F;
            this.QTE.HeaderText = "Items";
            this.QTE.Name = "QTE";
            this.QTE.ReadOnly = true;
            // 
            // DollarPrice
            // 
            this.DollarPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DollarPrice.FillWeight = 8F;
            this.DollarPrice.HeaderText = "Dollar";
            this.DollarPrice.Name = "DollarPrice";
            this.DollarPrice.ReadOnly = true;
            // 
            // LBPPrice
            // 
            this.LBPPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Format = "#,0;-#,0";
            this.LBPPrice.DefaultCellStyle = dataGridViewCellStyle2;
            this.LBPPrice.FillWeight = 10F;
            this.LBPPrice.HeaderText = "LBP";
            this.LBPPrice.Name = "LBPPrice";
            this.LBPPrice.ReadOnly = true;
            // 
            // TotalLBP
            // 
            this.TotalLBP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Format = "#,0;-#,0";
            this.TotalLBP.DefaultCellStyle = dataGridViewCellStyle3;
            this.TotalLBP.FillWeight = 10F;
            this.TotalLBP.HeaderText = "Tot. LBP";
            this.TotalLBP.Name = "TotalLBP";
            this.TotalLBP.ReadOnly = true;
            // 
            // TotalDollar
            // 
            this.TotalDollar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalDollar.FillWeight = 8F;
            this.TotalDollar.HeaderText = "Tot. $";
            this.TotalDollar.Name = "TotalDollar";
            this.TotalDollar.ReadOnly = true;
            // 
            // TotalTVA
            // 
            this.TotalTVA.HeaderText = "Tot. TVA $";
            this.TotalTVA.MinimumWidth = 200;
            this.TotalTVA.Name = "TotalTVA";
            this.TotalTVA.ReadOnly = true;
            this.TotalTVA.Visible = false;
            // 
            // TotalDiscount
            // 
            this.TotalDiscount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalDiscount.FillWeight = 8F;
            this.TotalDiscount.HeaderText = "Tot. % $";
            this.TotalDiscount.Name = "TotalDiscount";
            this.TotalDiscount.ReadOnly = true;
            // 
            // SecondPrice
            // 
            this.SecondPrice.HeaderText = "Second Price";
            this.SecondPrice.Name = "SecondPrice";
            this.SecondPrice.ReadOnly = true;
            this.SecondPrice.Visible = false;
            // 
            // total_panel
            // 
            this.total_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.total_panel.Controls.Add(this.tableLayoutPanel5);
            this.total_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.total_panel.Location = new System.Drawing.Point(310, 495);
            this.total_panel.Name = "total_panel";
            this.total_panel.Size = new System.Drawing.Size(711, 270);
            this.total_panel.TabIndex = 3;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel7, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(711, 270);
            this.tableLayoutPanel5.TabIndex = 32;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tot_final_price_lbp, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.tot_final_price_dolar, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.tot_tva, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.receipt_id, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tot_quantity, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.tot_net_dollar, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.tot_discount, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 7;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(605, 264);
            this.tableLayoutPanel3.TabIndex = 31;
            // 
            // tot_final_price_lbp
            // 
            this.tot_final_price_lbp.BackColor = System.Drawing.Color.White;
            this.tot_final_price_lbp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tot_final_price_lbp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tot_final_price_lbp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tot_final_price_lbp.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tot_final_price_lbp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.tot_final_price_lbp.Location = new System.Drawing.Point(305, 222);
            this.tot_final_price_lbp.Name = "tot_final_price_lbp";
            this.tot_final_price_lbp.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.tot_final_price_lbp.Size = new System.Drawing.Size(297, 42);
            this.tot_final_price_lbp.TabIndex = 36;
            this.tot_final_price_lbp.Text = "0 LBP";
            this.tot_final_price_lbp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 222);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label7.Size = new System.Drawing.Size(296, 42);
            this.label7.TabIndex = 35;
            this.label7.Text = "Total Net LBP  : ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tot_final_price_dolar
            // 
            this.tot_final_price_dolar.BackColor = System.Drawing.Color.White;
            this.tot_final_price_dolar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tot_final_price_dolar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tot_final_price_dolar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tot_final_price_dolar.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tot_final_price_dolar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.tot_final_price_dolar.Location = new System.Drawing.Point(305, 185);
            this.tot_final_price_dolar.Name = "tot_final_price_dolar";
            this.tot_final_price_dolar.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.tot_final_price_dolar.Size = new System.Drawing.Size(297, 37);
            this.tot_final_price_dolar.TabIndex = 34;
            this.tot_final_price_dolar.Text = "0 $";
            this.tot_final_price_dolar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 185);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label5.Size = new System.Drawing.Size(296, 37);
            this.label5.TabIndex = 33;
            this.label5.Text = "Total Net $  : ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tot_tva
            // 
            this.tot_tva.BackColor = System.Drawing.Color.White;
            this.tot_tva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tot_tva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tot_tva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tot_tva.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tot_tva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.tot_tva.Location = new System.Drawing.Point(305, 148);
            this.tot_tva.Name = "tot_tva";
            this.tot_tva.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.tot_tva.Size = new System.Drawing.Size(297, 37);
            this.tot_tva.TabIndex = 32;
            this.tot_tva.Text = "0 $";
            this.tot_tva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 148);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(296, 37);
            this.label4.TabIndex = 31;
            this.label4.Text = "Total TVA  $ : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 111);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(296, 37);
            this.label1.TabIndex = 24;
            this.label1.Text = "Total Discount Price $ : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // receipt_id
            // 
            this.receipt_id.BackColor = System.Drawing.Color.White;
            this.receipt_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.receipt_id.Dock = System.Windows.Forms.DockStyle.Fill;
            this.receipt_id.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.receipt_id.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receipt_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.receipt_id.Location = new System.Drawing.Point(305, 0);
            this.receipt_id.Name = "receipt_id";
            this.receipt_id.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.receipt_id.Size = new System.Drawing.Size(297, 37);
            this.receipt_id.TabIndex = 27;
            this.receipt_id.Text = "0";
            this.receipt_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tot_quantity
            // 
            this.tot_quantity.BackColor = System.Drawing.Color.White;
            this.tot_quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tot_quantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tot_quantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tot_quantity.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tot_quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.tot_quantity.Location = new System.Drawing.Point(305, 37);
            this.tot_quantity.Name = "tot_quantity";
            this.tot_quantity.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.tot_quantity.Size = new System.Drawing.Size(297, 37);
            this.tot_quantity.TabIndex = 28;
            this.tot_quantity.Text = "0";
            this.tot_quantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tot_net_dollar
            // 
            this.tot_net_dollar.BackColor = System.Drawing.Color.White;
            this.tot_net_dollar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tot_net_dollar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tot_net_dollar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tot_net_dollar.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tot_net_dollar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.tot_net_dollar.Location = new System.Drawing.Point(305, 74);
            this.tot_net_dollar.Name = "tot_net_dollar";
            this.tot_net_dollar.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.tot_net_dollar.Size = new System.Drawing.Size(297, 37);
            this.tot_net_dollar.TabIndex = 29;
            this.tot_net_dollar.Text = "0 $";
            this.tot_net_dollar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tot_discount
            // 
            this.tot_discount.BackColor = System.Drawing.Color.White;
            this.tot_discount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tot_discount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tot_discount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tot_discount.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tot_discount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.tot_discount.Location = new System.Drawing.Point(305, 111);
            this.tot_discount.Name = "tot_discount";
            this.tot_discount.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.tot_discount.Size = new System.Drawing.Size(297, 37);
            this.tot_discount.TabIndex = 30;
            this.tot_discount.Text = "0 $";
            this.tot_discount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 74);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label6.Size = new System.Drawing.Size(296, 37);
            this.label6.TabIndex = 23;
            this.label6.Text = "Total Price $ : ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 37);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(296, 37);
            this.label2.TabIndex = 25;
            this.label2.Text = "Total Items : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(296, 37);
            this.label3.TabIndex = 26;
            this.label3.Text = "Receipt ID : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.btnExtCheckOut, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.checkout_btn, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(614, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(94, 264);
            this.tableLayoutPanel7.TabIndex = 32;
            // 
            // btnExtCheckOut
            // 
            this.btnExtCheckOut.AccessibleName = "Button";
            this.btnExtCheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnExtCheckOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExtCheckOut.CanOverrideStyle = true;
            this.btnExtCheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExtCheckOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExtCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtCheckOut.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnExtCheckOut.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExtCheckOut.ImageMargin = new System.Windows.Forms.Padding(0);
            this.btnExtCheckOut.ImageSize = new System.Drawing.Size(35, 35);
            this.btnExtCheckOut.Location = new System.Drawing.Point(3, 187);
            this.btnExtCheckOut.Name = "btnExtCheckOut";
            this.btnExtCheckOut.Size = new System.Drawing.Size(88, 74);
            this.btnExtCheckOut.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnExtCheckOut.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnExtCheckOut.Style.FocusedForeColor = System.Drawing.Color.White;
            this.btnExtCheckOut.Style.ForeColor = System.Drawing.Color.White;
            this.btnExtCheckOut.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.btnExtCheckOut.Style.HoverForeColor = System.Drawing.Color.White;
            this.btnExtCheckOut.Style.HoverImageForeColor = System.Drawing.Color.Empty;
            this.btnExtCheckOut.Style.PressedBackColor = System.Drawing.Color.White;
            this.btnExtCheckOut.Style.PressedForeColor = System.Drawing.Color.White;
            this.btnExtCheckOut.TabIndex = 14;
            this.btnExtCheckOut.Text = "Ext...";
            this.btnExtCheckOut.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.btnExtCheckOut.TextMargin = new System.Windows.Forms.Padding(0);
            this.btnExtCheckOut.ThemeName = "Office2016Colorful";
            this.toolTip1.SetToolTip(this.btnExtCheckOut, "Extended Checkout");
            this.btnExtCheckOut.UseVisualStyleBackColor = false;
            this.btnExtCheckOut.Click += new System.EventHandler(this.btnExtCheckOut_Click);
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
            this.checkout_btn.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checkout_btn.ImageMargin = new System.Windows.Forms.Padding(0);
            this.checkout_btn.ImageSize = new System.Drawing.Size(50, 50);
            this.checkout_btn.Location = new System.Drawing.Point(3, 3);
            this.checkout_btn.Name = "checkout_btn";
            this.checkout_btn.Size = new System.Drawing.Size(88, 178);
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
            this.checkout_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // timerRefreshDataDelay
            // 
            this.timerRefreshDataDelay.Interval = 500;
            this.timerRefreshDataDelay.Tick += new System.EventHandler(this.timerRefreshDataDelay_Tick);
            // 
            // timerRefreshInputQte
            // 
            this.timerRefreshInputQte.Interval = 500;
            this.timerRefreshInputQte.Tick += new System.EventHandler(this.timerRefreshInputQte_Tick);
            // 
            // spselectReceiptsResultBindingSource
            // 
            this.spselectReceiptsResultBindingSource.DataSource = typeof(MiniGram.LINQ.sp_selectReceiptsResult);
            // 
            // POSUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "POSUC";
            this.Size = new System.Drawing.Size(1024, 768);
            this.Load += new System.EventHandler(this.POSUC_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.POSUC_KeyUp);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.search_panel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search_txt)).EndInit();
            this.receipt_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.receipt_details)).EndInit();
            this.total_panel.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spselectReceiptsResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
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
        private System.Windows.Forms.Label tot_discount;
        private System.Windows.Forms.Label tot_net_dollar;
        private System.Windows.Forms.Label tot_quantity;
        private System.Windows.Forms.Label receipt_id;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Syncfusion.WinForms.Controls.SfButton add_btn;
        private Syncfusion.WinForms.Controls.SfButton change_quantity_btn;
        private Syncfusion.WinForms.Controls.SfButton delete_btn;
        private Syncfusion.WinForms.Controls.SfButton keyboard_btn;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt search_txt;
        public System.Windows.Forms.Panel products_panel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Syncfusion.WinForms.Controls.SfButton btnHold;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tot_tva;
        private System.Windows.Forms.Label tot_final_price_dolar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label tot_final_price_lbp;
        private System.Windows.Forms.Label label7;
        private Syncfusion.WinForms.Controls.SfButton btnSwitch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lblReceiptType;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Timer timerRefreshDataDelay;
        private System.Windows.Forms.Timer timerRefreshInputQte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn PNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DollarPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn LBPPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalLBP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDollar;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalTVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecondPrice;
        private System.Windows.Forms.CheckBox cboxDiscount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private Syncfusion.WinForms.Controls.SfButton btnExtCheckOut;
    }
}
