namespace MiniGram.Controls
{
    partial class ProductsUC
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.search_txt = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.search_btn = new Syncfusion.WinForms.Controls.SfButton();
            this.disablecus_btn = new Syncfusion.WinForms.Controls.SfButton();
            this.enablecus_btn = new Syncfusion.WinForms.Controls.SfButton();
            this.addproduct_btn = new Syncfusion.WinForms.Controls.SfButton();
            this.keyboard_btn = new Syncfusion.WinForms.Controls.SfButton();
            this.btnDeliveryIn = new Syncfusion.WinForms.Controls.SfButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.spselectproductsResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerRefreshDataDelay = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.search_txt)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spselectproductsResultBindingSource)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // search_txt
            // 
            this.search_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.search_txt.BeforeTouchSize = new System.Drawing.Size(44, 30);
            this.search_txt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.search_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.search_txt.CanOverrideStyle = true;
            this.search_txt.CornerRadius = 5;
            this.search_txt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.search_txt.Dock = System.Windows.Forms.DockStyle.Left;
            this.search_txt.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.search_txt.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.search_txt.Location = new System.Drawing.Point(802, 4);
            this.search_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.search_txt.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.search_txt.MinimumSize = new System.Drawing.Size(44, 30);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(44, 30);
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
            this.search_btn.Location = new System.Drawing.Point(665, 0);
            this.search_btn.Margin = new System.Windows.Forms.Padding(0);
            this.search_btn.Name = "search_btn";
            this.search_btn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.search_btn.Size = new System.Drawing.Size(133, 84);
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
            this.toolTip1.SetToolTip(this.search_btn, "Search In Products.");
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // disablecus_btn
            // 
            this.disablecus_btn.AccessibleName = "Button";
            this.disablecus_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.disablecus_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.disablecus_btn.CanOverrideStyle = true;
            this.disablecus_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.disablecus_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.disablecus_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disablecus_btn.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disablecus_btn.ForeColor = System.Drawing.Color.White;
            this.disablecus_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.disablecus_btn.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.disablecus_btn.ImageMargin = new System.Windows.Forms.Padding(0);
            this.disablecus_btn.ImageSize = new System.Drawing.Size(35, 35);
            this.disablecus_btn.Location = new System.Drawing.Point(399, 0);
            this.disablecus_btn.Margin = new System.Windows.Forms.Padding(0);
            this.disablecus_btn.Name = "disablecus_btn";
            this.disablecus_btn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.disablecus_btn.Size = new System.Drawing.Size(133, 84);
            this.disablecus_btn.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.disablecus_btn.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.disablecus_btn.Style.FocusedForeColor = System.Drawing.Color.White;
            this.disablecus_btn.Style.ForeColor = System.Drawing.Color.White;
            this.disablecus_btn.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.disablecus_btn.Style.HoverForeColor = System.Drawing.Color.White;
            this.disablecus_btn.Style.HoverImageForeColor = System.Drawing.Color.Empty;
            this.disablecus_btn.Style.Image = global::MiniGram.Properties.Resources.off;
            this.disablecus_btn.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.disablecus_btn.Style.PressedForeColor = System.Drawing.Color.White;
            this.disablecus_btn.TabIndex = 14;
            this.disablecus_btn.Text = "Disable";
            this.disablecus_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.disablecus_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.disablecus_btn.TextMargin = new System.Windows.Forms.Padding(0);
            this.disablecus_btn.ThemeName = "Office2016Colorful";
            this.toolTip1.SetToolTip(this.disablecus_btn, "Disable Selected Product.");
            this.disablecus_btn.UseVisualStyleBackColor = true;
            this.disablecus_btn.Click += new System.EventHandler(this.disable_btn_Click);
            // 
            // enablecus_btn
            // 
            this.enablecus_btn.AccessibleName = "Button";
            this.enablecus_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.enablecus_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.enablecus_btn.CanOverrideStyle = true;
            this.enablecus_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enablecus_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enablecus_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enablecus_btn.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enablecus_btn.ForeColor = System.Drawing.Color.White;
            this.enablecus_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.enablecus_btn.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.enablecus_btn.ImageMargin = new System.Windows.Forms.Padding(0);
            this.enablecus_btn.ImageSize = new System.Drawing.Size(35, 35);
            this.enablecus_btn.Location = new System.Drawing.Point(266, 0);
            this.enablecus_btn.Margin = new System.Windows.Forms.Padding(0);
            this.enablecus_btn.Name = "enablecus_btn";
            this.enablecus_btn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.enablecus_btn.Size = new System.Drawing.Size(133, 84);
            this.enablecus_btn.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.enablecus_btn.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.enablecus_btn.Style.FocusedForeColor = System.Drawing.Color.White;
            this.enablecus_btn.Style.ForeColor = System.Drawing.Color.White;
            this.enablecus_btn.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.enablecus_btn.Style.HoverForeColor = System.Drawing.Color.White;
            this.enablecus_btn.Style.HoverImageForeColor = System.Drawing.Color.Empty;
            this.enablecus_btn.Style.Image = global::MiniGram.Properties.Resources.on;
            this.enablecus_btn.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.enablecus_btn.Style.PressedForeColor = System.Drawing.Color.White;
            this.enablecus_btn.TabIndex = 13;
            this.enablecus_btn.Text = "Enable";
            this.enablecus_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.enablecus_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.enablecus_btn.TextMargin = new System.Windows.Forms.Padding(0);
            this.enablecus_btn.ThemeName = "Office2016Colorful";
            this.toolTip1.SetToolTip(this.enablecus_btn, "Enable Selected Product.");
            this.enablecus_btn.UseVisualStyleBackColor = true;
            this.enablecus_btn.Click += new System.EventHandler(this.enable_btn_Click);
            // 
            // addproduct_btn
            // 
            this.addproduct_btn.AccessibleName = "Button";
            this.addproduct_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.addproduct_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addproduct_btn.CanOverrideStyle = true;
            this.addproduct_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addproduct_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addproduct_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addproduct_btn.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addproduct_btn.ForeColor = System.Drawing.Color.White;
            this.addproduct_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addproduct_btn.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addproduct_btn.ImageMargin = new System.Windows.Forms.Padding(0);
            this.addproduct_btn.ImageSize = new System.Drawing.Size(35, 35);
            this.addproduct_btn.Location = new System.Drawing.Point(0, 0);
            this.addproduct_btn.Margin = new System.Windows.Forms.Padding(0);
            this.addproduct_btn.Name = "addproduct_btn";
            this.addproduct_btn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.addproduct_btn.Size = new System.Drawing.Size(133, 84);
            this.addproduct_btn.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.addproduct_btn.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.addproduct_btn.Style.FocusedForeColor = System.Drawing.Color.White;
            this.addproduct_btn.Style.ForeColor = System.Drawing.Color.White;
            this.addproduct_btn.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.addproduct_btn.Style.HoverForeColor = System.Drawing.Color.White;
            this.addproduct_btn.Style.HoverImageForeColor = System.Drawing.Color.Empty;
            this.addproduct_btn.Style.Image = global::MiniGram.Properties.Resources.shipping;
            this.addproduct_btn.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.addproduct_btn.Style.PressedForeColor = System.Drawing.Color.White;
            this.addproduct_btn.TabIndex = 12;
            this.addproduct_btn.Text = "Add";
            this.addproduct_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addproduct_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.addproduct_btn.TextMargin = new System.Windows.Forms.Padding(0);
            this.addproduct_btn.ThemeName = "Office2016Colorful";
            this.toolTip1.SetToolTip(this.addproduct_btn, "Add New Product.");
            this.addproduct_btn.UseVisualStyleBackColor = true;
            this.addproduct_btn.Click += new System.EventHandler(this.addproduct_btn_Click);
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
            this.keyboard_btn.Location = new System.Drawing.Point(532, 0);
            this.keyboard_btn.Margin = new System.Windows.Forms.Padding(0);
            this.keyboard_btn.Name = "keyboard_btn";
            this.keyboard_btn.Size = new System.Drawing.Size(133, 84);
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
            // btnDeliveryIn
            // 
            this.btnDeliveryIn.AccessibleName = "Button";
            this.btnDeliveryIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnDeliveryIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeliveryIn.CanOverrideStyle = true;
            this.btnDeliveryIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeliveryIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeliveryIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeliveryIn.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeliveryIn.ForeColor = System.Drawing.Color.White;
            this.btnDeliveryIn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeliveryIn.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeliveryIn.ImageMargin = new System.Windows.Forms.Padding(0);
            this.btnDeliveryIn.ImageSize = new System.Drawing.Size(35, 35);
            this.btnDeliveryIn.Location = new System.Drawing.Point(133, 0);
            this.btnDeliveryIn.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeliveryIn.Name = "btnDeliveryIn";
            this.btnDeliveryIn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnDeliveryIn.Size = new System.Drawing.Size(133, 84);
            this.btnDeliveryIn.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnDeliveryIn.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnDeliveryIn.Style.FocusedForeColor = System.Drawing.Color.White;
            this.btnDeliveryIn.Style.ForeColor = System.Drawing.Color.White;
            this.btnDeliveryIn.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.btnDeliveryIn.Style.HoverForeColor = System.Drawing.Color.White;
            this.btnDeliveryIn.Style.HoverImageForeColor = System.Drawing.Color.Empty;
            this.btnDeliveryIn.Style.Image = global::MiniGram.Properties.Resources.supplier;
            this.btnDeliveryIn.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.btnDeliveryIn.Style.PressedForeColor = System.Drawing.Color.White;
            this.btnDeliveryIn.TabIndex = 23;
            this.btnDeliveryIn.Text = "Delivery In";
            this.btnDeliveryIn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeliveryIn.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.btnDeliveryIn.TextMargin = new System.Windows.Forms.Padding(0);
            this.btnDeliveryIn.ThemeName = "Office2016Colorful";
            this.toolTip1.SetToolTip(this.btnDeliveryIn, "Add New Delivery In Receipt.");
            this.btnDeliveryIn.UseVisualStyleBackColor = true;
            this.btnDeliveryIn.Click += new System.EventHandler(this.btnDeliveryIn_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 8;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel2.Controls.Add(this.btnDeliveryIn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.keyboard_btn, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.search_btn, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.disablecus_btn, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.enablecus_btn, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.addproduct_btn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.search_txt, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblCount, 7, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1357, 84);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCount.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.White;
            this.lblCount.Location = new System.Drawing.Point(1228, 0);
            this.lblCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(125, 84);
            this.lblCount.TabIndex = 24;
            this.lblCount.Text = "@count";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1357, 84);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(4, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1349, 837);
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
            this.iDDataGridViewTextBoxColumn,
            this.barcodeDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.supplierNameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.addedDateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.Edit});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.DataSource = this.spselectproductsResultBindingSource;
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
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.dataGridView1.Size = new System.Drawing.Size(1349, 837);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // barcodeDataGridViewTextBoxColumn
            // 
            this.barcodeDataGridViewTextBoxColumn.DataPropertyName = "Barcode";
            this.barcodeDataGridViewTextBoxColumn.HeaderText = "Barcode";
            this.barcodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.barcodeDataGridViewTextBoxColumn.Name = "barcodeDataGridViewTextBoxColumn";
            this.barcodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Product Name";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supplierNameDataGridViewTextBoxColumn
            // 
            this.supplierNameDataGridViewTextBoxColumn.DataPropertyName = "SupplierName";
            this.supplierNameDataGridViewTextBoxColumn.HeaderText = "Supplier Name";
            this.supplierNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.supplierNameDataGridViewTextBoxColumn.Name = "supplierNameDataGridViewTextBoxColumn";
            this.supplierNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addedDateDataGridViewTextBoxColumn
            // 
            this.addedDateDataGridViewTextBoxColumn.DataPropertyName = "AddedDate";
            this.addedDateDataGridViewTextBoxColumn.HeaderText = "Added Date";
            this.addedDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addedDateDataGridViewTextBoxColumn.Name = "addedDateDataGridViewTextBoxColumn";
            this.addedDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.HeaderText = "";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Edit.Text = "Edit";
            this.Edit.ToolTipText = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // spselectproductsResultBindingSource
            // 
            this.spselectproductsResultBindingSource.DataSource = typeof(MiniGram.LINQ.sp_select_productsResult);
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
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 846F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1357, 845);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 96);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1357, 845);
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
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.797797F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.2022F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1365, 945);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerRefreshDataDelay
            // 
            this.timerRefreshDataDelay.Interval = 500;
            this.timerRefreshDataDelay.Tick += new System.EventHandler(this.timerRefreshDataDelay_Tick);
            // 
            // ProductsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ProductsUC";
            this.Size = new System.Drawing.Size(1365, 945);
            this.Load += new System.EventHandler(this.CustomersUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.search_txt)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spselectproductsResultBindingSource)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private Syncfusion.WinForms.Controls.SfButton disablecus_btn;
        private Syncfusion.WinForms.Controls.SfButton enablecus_btn;
        private Syncfusion.WinForms.Controls.SfButton addproduct_btn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn column1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn address1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn address2DataGridViewTextBoxColumn;
        private Syncfusion.WinForms.Controls.SfButton search_btn;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt search_txt;
        private System.Windows.Forms.Timer timer1;
        private Syncfusion.WinForms.Controls.SfButton keyboard_btn;
        private System.Windows.Forms.BindingSource spselectproductsResultBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private Syncfusion.WinForms.Controls.SfButton btnDeliveryIn;
        private System.Windows.Forms.Timer timerRefreshDataDelay;
        private System.Windows.Forms.Label lblCount;
    }
}
