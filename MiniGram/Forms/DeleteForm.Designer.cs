namespace MiniGram.Forms
{
    partial class DeleteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteForm));
            this.item_number = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label3 = new System.Windows.Forms.Label();
            this.delete_btn = new Syncfusion.WinForms.Controls.SfButton();
            this.sfButton1 = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)(this.item_number)).BeginInit();
            this.SuspendLayout();
            // 
            // item_number
            // 
            this.item_number.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.item_number.BeforeTouchSize = new System.Drawing.Size(172, 42);
            this.item_number.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.item_number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.item_number.CanOverrideStyle = true;
            this.item_number.CornerRadius = 5;
            this.item_number.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.item_number.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.item_number.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_number.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.item_number.Location = new System.Drawing.Point(208, 156);
            this.item_number.Margin = new System.Windows.Forms.Padding(10);
            this.item_number.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.item_number.MinimumSize = new System.Drawing.Size(34, 30);
            this.item_number.Name = "item_number";
            this.item_number.Size = new System.Drawing.Size(172, 42);
            this.item_number.TabIndex = 18;
            this.item_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.item_number.ThemeName = "Default";
            this.item_number.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.item_number.ThemeStyle.CornerRadius = 5;
            this.item_number.ThemeStyle.DisabledBackColor = System.Drawing.Color.Gray;
            this.item_number.ThemeStyle.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.item_number.ThemeStyle.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.item_number.ThemeStyle.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.item_number.ThemeStyle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_number.ThemeStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.item_number.ThemeStyle.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.item_number.UseBorderColorOnFocus = true;
            this.item_number.KeyUp += new System.Windows.Forms.KeyEventHandler(this.item_number_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(26, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(545, 32);
            this.label3.TabIndex = 27;
            this.label3.Text = "How Many Item You Need To Delete ?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // delete_btn
            // 
            this.delete_btn.AccessibleName = "Button";
            this.delete_btn.BackColor = System.Drawing.Color.Red;
            this.delete_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.delete_btn.CanOverrideStyle = true;
            this.delete_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.ForeColor = System.Drawing.Color.White;
            this.delete_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.delete_btn.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.delete_btn.ImageMargin = new System.Windows.Forms.Padding(0);
            this.delete_btn.ImageSize = new System.Drawing.Size(40, 40);
            this.delete_btn.Location = new System.Drawing.Point(0, 240);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(10);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(600, 60);
            this.delete_btn.Style.BackColor = System.Drawing.Color.Red;
            this.delete_btn.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.delete_btn.Style.FocusedForeColor = System.Drawing.Color.White;
            this.delete_btn.Style.ForeColor = System.Drawing.Color.White;
            this.delete_btn.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.delete_btn.Style.HoverForeColor = System.Drawing.Color.White;
            this.delete_btn.Style.HoverImageForeColor = System.Drawing.Color.Empty;
            this.delete_btn.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.delete_btn.Style.PressedForeColor = System.Drawing.Color.White;
            this.delete_btn.TabIndex = 28;
            this.delete_btn.Text = "Delete";
            this.delete_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.delete_btn.TextMargin = new System.Windows.Forms.Padding(0);
            this.delete_btn.ThemeName = "Office2016Colorful";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // sfButton1
            // 
            this.sfButton1.AccessibleName = "Button";
            this.sfButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.sfButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sfButton1.CanOverrideStyle = true;
            this.sfButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sfButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sfButton1.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfButton1.ForeColor = System.Drawing.Color.White;
            this.sfButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sfButton1.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sfButton1.ImageMargin = new System.Windows.Forms.Padding(0);
            this.sfButton1.ImageSize = new System.Drawing.Size(40, 40);
            this.sfButton1.Location = new System.Drawing.Point(554, 7);
            this.sfButton1.Margin = new System.Windows.Forms.Padding(10);
            this.sfButton1.Name = "sfButton1";
            this.sfButton1.Size = new System.Drawing.Size(36, 41);
            this.sfButton1.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.sfButton1.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.sfButton1.Style.FocusedForeColor = System.Drawing.Color.White;
            this.sfButton1.Style.ForeColor = System.Drawing.Color.White;
            this.sfButton1.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.sfButton1.Style.HoverForeColor = System.Drawing.Color.White;
            this.sfButton1.Style.HoverImageForeColor = System.Drawing.Color.Empty;
            this.sfButton1.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.sfButton1.Style.PressedForeColor = System.Drawing.Color.White;
            this.sfButton1.TabIndex = 29;
            this.sfButton1.Text = "X";
            this.sfButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.sfButton1.TextMargin = new System.Windows.Forms.Padding(0);
            this.sfButton1.ThemeName = "Office2016Colorful";
            this.sfButton1.UseVisualStyleBackColor = false;
            this.sfButton1.Click += new System.EventHandler(this.sfButton1_Click);
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.sfButton1);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.item_number);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.DeleteForm_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DeleteForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.item_number)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TextBoxExt item_number;
        private System.Windows.Forms.Label label3;
        private Syncfusion.WinForms.Controls.SfButton delete_btn;
        private Syncfusion.WinForms.Controls.SfButton sfButton1;
    }
}