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
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("sp_select_productsResult", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ID");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Barcode");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ProductName");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("SupplierName");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Quantity");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Price");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("AddedDate");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Status");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn9 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("InitPrice");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn10 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("SecondaryPrice");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn11 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("HasTVA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn12 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("DiscountPercentage");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn13 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("HasDiscount");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn14 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ShowMore", 0);
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
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
            this.ultraGridProducts = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerRefreshDataDelay = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.search_txt)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGridProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
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
            this.search_txt.Location = new System.Drawing.Point(603, 3);
            this.search_txt.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.search_txt.MinimumSize = new System.Drawing.Size(34, 30);
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
            this.search_btn.Location = new System.Drawing.Point(500, 0);
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
            this.disablecus_btn.Location = new System.Drawing.Point(300, 0);
            this.disablecus_btn.Margin = new System.Windows.Forms.Padding(0);
            this.disablecus_btn.Name = "disablecus_btn";
            this.disablecus_btn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.disablecus_btn.Size = new System.Drawing.Size(100, 69);
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
            this.enablecus_btn.Location = new System.Drawing.Point(200, 0);
            this.enablecus_btn.Margin = new System.Windows.Forms.Padding(0);
            this.enablecus_btn.Name = "enablecus_btn";
            this.enablecus_btn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.enablecus_btn.Size = new System.Drawing.Size(100, 69);
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
            this.addproduct_btn.Size = new System.Drawing.Size(100, 69);
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
            this.keyboard_btn.Location = new System.Drawing.Point(400, 0);
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
            this.btnDeliveryIn.Location = new System.Drawing.Point(100, 0);
            this.btnDeliveryIn.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeliveryIn.Name = "btnDeliveryIn";
            this.btnDeliveryIn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnDeliveryIn.Size = new System.Drawing.Size(100, 69);
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
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1018, 69);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCount.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.White;
            this.lblCount.Location = new System.Drawing.Point(921, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(94, 69);
            this.lblCount.TabIndex = 24;
            this.lblCount.Text = "@count";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // panel3
            // 
            this.panel3.Controls.Add(this.ultraGridProducts);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1012, 681);
            this.panel3.TabIndex = 1;
            // 
            // ultraGridProducts
            // 
            this.ultraGridProducts.DataSource = this.bindingSource1;
            appearance1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            appearance1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraGridProducts.DisplayLayout.Appearance = appearance1;
            this.ultraGridProducts.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn1.Nullable = Infragistics.Win.UltraWinGrid.Nullable.EmptyString;
            ultraGridColumn1.Width = 59;
            ultraGridColumn2.AutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.None;
            ultraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.MaxWidth = 180;
            ultraGridColumn2.MinWidth = 180;
            ultraGridColumn2.Nullable = Infragistics.Win.UltraWinGrid.Nullable.EmptyString;
            ultraGridColumn2.Width = 180;
            ultraGridColumn3.AutoEditMode = Infragistics.Win.DefaultableBoolean.False;
            ultraGridColumn3.AutoSizeEdit = Infragistics.Win.DefaultableBoolean.False;
            ultraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn3.Header.Caption = "Name";
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridColumn3.Nullable = Infragistics.Win.UltraWinGrid.Nullable.EmptyString;
            ultraGridColumn3.Width = 14;
            ultraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn4.Header.Caption = "Supplier";
            ultraGridColumn4.Header.VisiblePosition = 3;
            ultraGridColumn4.MaxWidth = 180;
            ultraGridColumn4.MinWidth = 180;
            ultraGridColumn4.Nullable = Infragistics.Win.UltraWinGrid.Nullable.EmptyString;
            ultraGridColumn4.Width = 180;
            ultraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn5.Header.VisiblePosition = 4;
            ultraGridColumn5.MaxWidth = 100;
            ultraGridColumn5.MinWidth = 100;
            ultraGridColumn5.Nullable = Infragistics.Win.UltraWinGrid.Nullable.EmptyString;
            ultraGridColumn5.Width = 100;
            ultraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn6.Header.VisiblePosition = 5;
            ultraGridColumn6.MaxWidth = 100;
            ultraGridColumn6.MinWidth = 100;
            ultraGridColumn6.Nullable = Infragistics.Win.UltraWinGrid.Nullable.EmptyString;
            ultraGridColumn6.Width = 100;
            ultraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn7.Header.Caption = "Added Date";
            ultraGridColumn7.Header.VisiblePosition = 6;
            ultraGridColumn7.MaxWidth = 180;
            ultraGridColumn7.MinWidth = 180;
            ultraGridColumn7.Nullable = Infragistics.Win.UltraWinGrid.Nullable.EmptyString;
            ultraGridColumn7.Width = 180;
            ultraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn8.Header.VisiblePosition = 7;
            ultraGridColumn8.MaxWidth = 150;
            ultraGridColumn8.MinWidth = 150;
            ultraGridColumn8.Nullable = Infragistics.Win.UltraWinGrid.Nullable.EmptyString;
            ultraGridColumn8.Width = 150;
            ultraGridColumn9.Header.VisiblePosition = 8;
            ultraGridColumn9.Hidden = true;
            ultraGridColumn9.Nullable = Infragistics.Win.UltraWinGrid.Nullable.EmptyString;
            ultraGridColumn9.Width = 84;
            ultraGridColumn10.Header.VisiblePosition = 9;
            ultraGridColumn10.Hidden = true;
            ultraGridColumn10.Nullable = Infragistics.Win.UltraWinGrid.Nullable.EmptyString;
            ultraGridColumn10.Width = 138;
            ultraGridColumn11.Header.VisiblePosition = 10;
            ultraGridColumn11.Hidden = true;
            ultraGridColumn11.Nullable = Infragistics.Win.UltraWinGrid.Nullable.EmptyString;
            ultraGridColumn11.Width = 97;
            ultraGridColumn12.Header.VisiblePosition = 11;
            ultraGridColumn12.Hidden = true;
            ultraGridColumn12.Nullable = Infragistics.Win.UltraWinGrid.Nullable.EmptyString;
            ultraGridColumn12.Width = 202;
            ultraGridColumn13.Header.VisiblePosition = 12;
            ultraGridColumn13.Hidden = true;
            ultraGridColumn13.Nullable = Infragistics.Win.UltraWinGrid.Nullable.EmptyString;
            ultraGridColumn13.Width = 167;
            ultraGridColumn14.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            appearance2.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            appearance2.BorderColor = System.Drawing.Color.White;
            appearance2.BorderColor2 = System.Drawing.Color.White;
            appearance2.Cursor = System.Windows.Forms.Cursors.Hand;
            appearance2.ForeColor = System.Drawing.Color.White;
            appearance2.TextHAlignAsString = "Center";
            appearance2.TextVAlignAsString = "Middle";
            ultraGridColumn14.CellAppearance = appearance2;
            appearance3.BorderColor = System.Drawing.Color.White;
            appearance3.BorderColor2 = System.Drawing.Color.White;
            ultraGridColumn14.CellButtonAppearance = appearance3;
            ultraGridColumn14.Header.Caption = "";
            ultraGridColumn14.Header.VisiblePosition = 13;
            ultraGridColumn14.MaxWidth = 120;
            ultraGridColumn14.MinWidth = 120;
            ultraGridColumn14.Nullable = Infragistics.Win.UltraWinGrid.Nullable.EmptyString;
            ultraGridColumn14.NullText = "Show More";
            ultraGridColumn14.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
            ultraGridColumn14.Width = 120;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3,
            ultraGridColumn4,
            ultraGridColumn5,
            ultraGridColumn6,
            ultraGridColumn7,
            ultraGridColumn8,
            ultraGridColumn9,
            ultraGridColumn10,
            ultraGridColumn11,
            ultraGridColumn12,
            ultraGridColumn13,
            ultraGridColumn14});
            this.ultraGridProducts.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.ultraGridProducts.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.ultraGridProducts.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            appearance4.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance4.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraGridProducts.DisplayLayout.GroupByBox.Appearance = appearance4;
            appearance5.ForeColor = System.Drawing.SystemColors.Control;
            this.ultraGridProducts.DisplayLayout.GroupByBox.BandLabelAppearance = appearance5;
            this.ultraGridProducts.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            appearance6.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance6.ForeColor = System.Drawing.SystemColors.Control;
            this.ultraGridProducts.DisplayLayout.GroupByBox.PromptAppearance = appearance6;
            this.ultraGridProducts.DisplayLayout.InterBandSpacing = 10;
            this.ultraGridProducts.DisplayLayout.MaxColScrollRegions = 1;
            this.ultraGridProducts.DisplayLayout.MaxRowScrollRegions = 1;
            appearance7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            appearance7.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            appearance7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            appearance7.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            appearance7.BorderColor3DBase = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            appearance7.Cursor = System.Windows.Forms.Cursors.Hand;
            appearance7.FontData.BoldAsString = "True";
            appearance7.FontData.Name = "Bookman Old Style";
            appearance7.FontData.SizeInPoints = 10F;
            appearance7.ForeColor = System.Drawing.Color.White;
            appearance7.TextHAlignAsString = "Center";
            appearance7.TextVAlignAsString = "Middle";
            this.ultraGridProducts.DisplayLayout.Override.ActiveCellAppearance = appearance7;
            appearance8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            appearance8.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            appearance8.FontData.BoldAsString = "True";
            appearance8.FontData.Name = "Bookman Old Style";
            appearance8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ultraGridProducts.DisplayLayout.Override.ActiveRowAppearance = appearance8;
            appearance9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            appearance9.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            appearance9.BorderColor3DBase = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ultraGridProducts.DisplayLayout.Override.AddRowCellAppearance = appearance9;
            this.ultraGridProducts.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            this.ultraGridProducts.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed;
            this.ultraGridProducts.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None;
            this.ultraGridProducts.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed;
            this.ultraGridProducts.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.ultraGridProducts.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraGridProducts.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False;
            this.ultraGridProducts.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.None;
            this.ultraGridProducts.DisplayLayout.Override.BorderStyleHeader = Infragistics.Win.UIElementBorderStyle.Solid;
            this.ultraGridProducts.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance10.BackColor = System.Drawing.Color.Transparent;
            appearance10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ultraGridProducts.DisplayLayout.Override.CardAreaAppearance = appearance10;
            appearance11.BackColor = System.Drawing.Color.White;
            appearance11.BackColor2 = System.Drawing.Color.White;
            appearance11.BackGradientAlignment = Infragistics.Win.GradientAlignment.Client;
            appearance11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            appearance11.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            appearance11.BorderColor3DBase = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            appearance11.FontData.BoldAsString = "True";
            appearance11.FontData.ItalicAsString = "False";
            appearance11.FontData.Name = "Bookman Old Style";
            appearance11.FontData.SizeInPoints = 10F;
            appearance11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            appearance11.TextHAlignAsString = "Center";
            appearance11.TextVAlignAsString = "Middle";
            this.ultraGridProducts.DisplayLayout.Override.CellAppearance = appearance11;
            appearance12.BorderColor = System.Drawing.Color.White;
            appearance12.BorderColor2 = System.Drawing.Color.White;
            this.ultraGridProducts.DisplayLayout.Override.CellButtonAppearance = appearance12;
            this.ultraGridProducts.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.ultraGridProducts.DisplayLayout.Override.CellPadding = 0;
            this.ultraGridProducts.DisplayLayout.Override.CellSpacing = 3;
            this.ultraGridProducts.DisplayLayout.Override.FixedRowIndicator = Infragistics.Win.UltraWinGrid.FixedRowIndicator.None;
            appearance13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            appearance13.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            appearance13.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance13.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraGridProducts.DisplayLayout.Override.GroupByRowAppearance = appearance13;
            appearance14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            appearance14.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            appearance14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            appearance14.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            appearance14.BorderColor3DBase = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            appearance14.FontData.BoldAsString = "True";
            appearance14.FontData.Name = "Bookman Old Style";
            appearance14.FontData.SizeInPoints = 13F;
            appearance14.ForeColor = System.Drawing.Color.White;
            appearance14.TextHAlignAsString = "Center";
            appearance14.TextVAlignAsString = "Middle";
            appearance14.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraGridProducts.DisplayLayout.Override.HeaderAppearance = appearance14;
            this.ultraGridProducts.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle;
            this.ultraGridProducts.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance15.BackColor = System.Drawing.Color.White;
            appearance15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            appearance15.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            appearance15.BorderColor3DBase = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            appearance15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ultraGridProducts.DisplayLayout.Override.RowAppearance = appearance15;
            appearance16.BackColor = System.Drawing.Color.ForestGreen;
            this.ultraGridProducts.DisplayLayout.Override.RowSelectorAppearance = appearance16;
            this.ultraGridProducts.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            this.ultraGridProducts.DisplayLayout.Override.RowSelectorWidth = 10;
            this.ultraGridProducts.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.Fixed;
            this.ultraGridProducts.DisplayLayout.Override.RowSpacingAfter = 3;
            this.ultraGridProducts.DisplayLayout.Override.RowSpacingBefore = 2;
            appearance17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            appearance17.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            appearance17.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            appearance17.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            appearance17.BorderColor3DBase = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ultraGridProducts.DisplayLayout.Override.SelectedCellAppearance = appearance17;
            appearance18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            appearance18.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            appearance18.FontData.BoldAsString = "True";
            appearance18.FontData.Name = "Bookman Old Style";
            appearance18.FontData.SizeInPoints = 12F;
            appearance18.TextHAlignAsString = "Center";
            appearance18.TextVAlignAsString = "Middle";
            this.ultraGridProducts.DisplayLayout.Override.SelectedRowAppearance = appearance18;
            this.ultraGridProducts.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None;
            this.ultraGridProducts.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None;
            this.ultraGridProducts.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Single;
            appearance19.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ultraGridProducts.DisplayLayout.Override.TemplateAddRowAppearance = appearance19;
            this.ultraGridProducts.DisplayLayout.Override.TipStyleScroll = Infragistics.Win.UltraWinGrid.TipStyle.Show;
            this.ultraGridProducts.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None;
            this.ultraGridProducts.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.ultraGridProducts.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.ultraGridProducts.DisplayLayout.SelectionOverlayBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.ultraGridProducts.DisplayLayout.SelectionOverlayColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.ultraGridProducts.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraGridProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraGridProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraGridProducts.Location = new System.Drawing.Point(0, 0);
            this.ultraGridProducts.Margin = new System.Windows.Forms.Padding(2);
            this.ultraGridProducts.Name = "ultraGridProducts";
            this.ultraGridProducts.Size = new System.Drawing.Size(1012, 681);
            this.ultraGridProducts.TabIndex = 0;
            this.ultraGridProducts.Text = "ultraGrid1";
            this.ultraGridProducts.ClickCellButton += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.ultraGridProducts_ClickCellButton);
            this.ultraGridProducts.DoubleClickRow += new Infragistics.Win.UltraWinGrid.DoubleClickRowEventHandler(this.ultraGridProducts_DoubleClickRow);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(MiniGram.LINQ.sp_select_productsResult);
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
            // timerRefreshDataDelay
            // 
            this.timerRefreshDataDelay.Interval = 500;
            this.timerRefreshDataDelay.Tick += new System.EventHandler(this.timerRefreshDataDelay_Tick);
            // 
            // ProductsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProductsUC";
            this.Size = new System.Drawing.Size(1024, 768);
            this.Load += new System.EventHandler(this.CustomersUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.search_txt)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGridProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
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
        private Syncfusion.WinForms.Controls.SfButton btnDeliveryIn;
        private System.Windows.Forms.Timer timerRefreshDataDelay;
        private System.Windows.Forms.Label lblCount;
        private Infragistics.Win.UltraWinGrid.UltraGrid ultraGridProducts;
        private System.Windows.Forms.BindingSource spselectproductsResultBindingSource;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}
