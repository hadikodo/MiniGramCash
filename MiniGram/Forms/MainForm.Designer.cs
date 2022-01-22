namespace MiniGram
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.exit_btn = new System.Windows.Forms.Button();
            this.minimize_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menu_toggle_btn = new Syncfusion.WinForms.Controls.SfButton();
            this.menu_nav = new Syncfusion.Windows.Forms.Tools.NavigationDrawer();
            this.dash_btn = new Syncfusion.Windows.Forms.Tools.DrawerMenuItem();
            this.sale_btn = new Syncfusion.Windows.Forms.Tools.DrawerMenuItem();
            this.sett_btn = new System.Windows.Forms.Button();
            this.parentBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.exit_btn.Location = new System.Drawing.Point(1293, 7);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(30, 30);
            this.exit_btn.TabIndex = 0;
            this.exit_btn.Text = "X";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // minimize_btn
            // 
            this.minimize_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.minimize_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize_btn.FlatAppearance.BorderSize = 0;
            this.minimize_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.minimize_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.minimize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize_btn.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize_btn.ForeColor = System.Drawing.Color.White;
            this.minimize_btn.Location = new System.Drawing.Point(1257, 7);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Size = new System.Drawing.Size(30, 30);
            this.minimize_btn.TabIndex = 1;
            this.minimize_btn.Text = "—";
            this.minimize_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.minimize_btn.UseVisualStyleBackColor = false;
            this.minimize_btn.Click += new System.EventHandler(this.minimize_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.menu_toggle_btn);
            this.panel1.Controls.Add(this.menu_nav);
            this.panel1.Controls.Add(this.sett_btn);
            this.panel1.Controls.Add(this.exit_btn);
            this.panel1.Controls.Add(this.minimize_btn);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1336, 744);
            this.panel1.TabIndex = 2;
            // 
            // menu_toggle_btn
            // 
            this.menu_toggle_btn.AccessibleName = "Button";
            this.menu_toggle_btn.BackColor = System.Drawing.Color.White;
            this.menu_toggle_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menu_toggle_btn.CanOverrideStyle = true;
            this.menu_toggle_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu_toggle_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_toggle_btn.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_toggle_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.menu_toggle_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_toggle_btn.ImageSize = new System.Drawing.Size(70, 70);
            this.menu_toggle_btn.Location = new System.Drawing.Point(0, 0);
            this.menu_toggle_btn.Margin = new System.Windows.Forms.Padding(0);
            this.menu_toggle_btn.Name = "menu_toggle_btn";
            this.menu_toggle_btn.Size = new System.Drawing.Size(318, 88);
            this.menu_toggle_btn.Style.BackColor = System.Drawing.Color.White;
            this.menu_toggle_btn.Style.FocusedBackColor = System.Drawing.Color.White;
            this.menu_toggle_btn.Style.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.menu_toggle_btn.Style.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.menu_toggle_btn.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.menu_toggle_btn.Style.HoverForeColor = System.Drawing.Color.White;
            this.menu_toggle_btn.Style.HoverImageForeColor = System.Drawing.Color.Empty;
            this.menu_toggle_btn.Style.Image = global::MiniGram.Properties.Resources.logo;
            this.menu_toggle_btn.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.menu_toggle_btn.Style.PressedForeColor = System.Drawing.Color.White;
            this.menu_toggle_btn.TabIndex = 6;
            this.menu_toggle_btn.Text = "MiniGram";
            this.menu_toggle_btn.ThemeName = "Office2016Colorful";
            this.menu_toggle_btn.UseVisualStyleBackColor = false;
            this.menu_toggle_btn.Click += new System.EventHandler(this.sfButton1_Click);
            // 
            // menu_nav
            // 
            this.menu_nav.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.menu_nav.AnimationDuration = 30;
            this.menu_nav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menu_nav.CanApplyTheme = false;
            this.menu_nav.DrawerHeight = 1080;
            this.menu_nav.DrawerWidth = 317;
            this.menu_nav.Items.Add(this.dash_btn);
            this.menu_nav.Items.Add(this.sale_btn);
            this.menu_nav.Location = new System.Drawing.Point(0, 88);
            this.menu_nav.Margin = new System.Windows.Forms.Padding(0);
            this.menu_nav.Name = "menu_nav";
            this.menu_nav.Size = new System.Drawing.Size(318, 656);
            this.menu_nav.Style = Syncfusion.Windows.Forms.Tools.NavigationDrawerStyle.Office2016White;
            this.menu_nav.TabIndex = 5;
            this.menu_nav.ThemeName = "Office2016White";
            this.menu_nav.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.menu_nav.ThemeStyle.DisabledBackColor = System.Drawing.Color.White;
            this.menu_nav.ThemeStyle.DisabledFooterBackColor = System.Drawing.Color.White;
            this.menu_nav.ThemeStyle.DisabledFooterBorderColor = System.Drawing.Color.White;
            this.menu_nav.ThemeStyle.DisabledFooterForeColor = System.Drawing.Color.White;
            this.menu_nav.ThemeStyle.DisabledHeaderBackColor = System.Drawing.Color.White;
            this.menu_nav.ThemeStyle.DisabledHeaderForeColor = System.Drawing.Color.White;
            this.menu_nav.ThemeStyle.DisabledPanelBackColor = System.Drawing.Color.White;
            this.menu_nav.ThemeStyle.FooterBackColor = System.Drawing.Color.White;
            this.menu_nav.ThemeStyle.FooterBorderColor = System.Drawing.Color.White;
            this.menu_nav.ThemeStyle.FooterBorderThickness = 0;
            this.menu_nav.ThemeStyle.FooterForeColor = System.Drawing.Color.White;
            this.menu_nav.ThemeStyle.FooterHoverBackColor = System.Drawing.Color.White;
            this.menu_nav.ThemeStyle.FooterHoverForeColor = System.Drawing.Color.White;
            this.menu_nav.ThemeStyle.HeaderBackColor = System.Drawing.Color.White;
            this.menu_nav.ThemeStyle.HeaderForeColor = System.Drawing.Color.White;
            this.menu_nav.ThemeStyle.PanelBackColor = System.Drawing.Color.White;
            this.menu_nav.ThemeStyle.SelectedFooterBackColor = System.Drawing.Color.White;
            this.menu_nav.ThemeStyle.SelectedFooterForeColor = System.Drawing.Color.White;
            this.menu_nav.TouchThreshold = 0;
            this.menu_nav.Transition = Syncfusion.Windows.Forms.Tools.Transition.Push;
            this.menu_nav.Opening += new Syncfusion.Windows.Forms.Tools.NavigationDrawer.OpeningEventHandler(this.menu_nav_Opening);
            this.menu_nav.Closing += new Syncfusion.Windows.Forms.Tools.NavigationDrawer.ClosingEventHandler(this.menu_nav_Closing);
            // 
            // dash_btn
            // 
            this.dash_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.dash_btn.BackColor = System.Drawing.Color.White;
            this.dash_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dash_btn.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.dash_btn.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dash_btn.ForeColor = System.Drawing.Color.White;
            this.dash_btn.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.dash_btn.ItemText = "Dashboard";
            this.dash_btn.Location = new System.Drawing.Point(2, 0);
            this.dash_btn.Margin = new System.Windows.Forms.Padding(0);
            this.dash_btn.Name = "dash_btn";
            this.dash_btn.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.dash_btn.Size = new System.Drawing.Size(317, 60);
            this.dash_btn.TabIndex = 0;
            this.dash_btn.Text = "Dashboard";
            this.dash_btn.TextAlign = Syncfusion.Windows.Forms.Tools.TextAlignment.Center;
            this.dash_btn.TextColor = System.Drawing.Color.White;
            // 
            // sale_btn
            // 
            this.sale_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.sale_btn.BackColor = System.Drawing.Color.White;
            this.sale_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sale_btn.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.sale_btn.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sale_btn.ForeColor = System.Drawing.Color.White;
            this.sale_btn.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.sale_btn.ItemText = "Sales";
            this.sale_btn.Location = new System.Drawing.Point(2, 60);
            this.sale_btn.Margin = new System.Windows.Forms.Padding(0);
            this.sale_btn.Name = "sale_btn";
            this.sale_btn.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.sale_btn.Size = new System.Drawing.Size(317, 60);
            this.sale_btn.TabIndex = 1;
            this.sale_btn.Text = "Sales";
            this.sale_btn.TextAlign = Syncfusion.Windows.Forms.Tools.TextAlignment.Center;
            this.sale_btn.TextColor = System.Drawing.Color.White;
            // 
            // sett_btn
            // 
            this.sett_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sett_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.sett_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sett_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sett_btn.FlatAppearance.BorderSize = 0;
            this.sett_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.sett_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.sett_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sett_btn.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sett_btn.ForeColor = System.Drawing.Color.White;
            this.sett_btn.Image = global::MiniGram.Properties.Resources.small_sett;
            this.sett_btn.Location = new System.Drawing.Point(1221, 7);
            this.sett_btn.Name = "sett_btn";
            this.sett_btn.Size = new System.Drawing.Size(30, 30);
            this.sett_btn.TabIndex = 4;
            this.sett_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sett_btn.UseVisualStyleBackColor = false;
            this.sett_btn.Click += new System.EventHandler(this.sett_btn_Click);
            // 
            // parentBarItem1
            // 
            this.parentBarItem1.BarName = "parentBarItem1";
            this.parentBarItem1.MetroColor = System.Drawing.Color.LightSkyBlue;
            this.parentBarItem1.ShowToolTipInPopUp = false;
            this.parentBarItem1.SizeToFit = true;
            this.parentBarItem1.WrapLength = 20;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(1360, 768);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MiniGram";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button minimize_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button sett_btn;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem1;
        private Syncfusion.Windows.Forms.Tools.NavigationDrawer menu_nav;
        private Syncfusion.Windows.Forms.Tools.DrawerMenuItem dash_btn;
        private Syncfusion.WinForms.Controls.SfButton menu_toggle_btn;
        private Syncfusion.Windows.Forms.Tools.DrawerMenuItem sale_btn;
    }
}

