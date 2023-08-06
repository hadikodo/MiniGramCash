
namespace MiniGram.Forms
{
    partial class BatchNumberForm
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
            this.keyboard_btn = new Syncfusion.WinForms.Controls.SfButton();
            this.exit_btn = new Syncfusion.WinForms.Controls.SfButton();
            this.accept_btn = new Syncfusion.WinForms.Controls.SfButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBatchNumber = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            ((System.ComponentModel.ISupportInitialize)(this.txtBatchNumber)).BeginInit();
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
            this.keyboard_btn.Location = new System.Drawing.Point(510, 2);
            this.keyboard_btn.Margin = new System.Windows.Forms.Padding(0);
            this.keyboard_btn.Name = "keyboard_btn";
            this.keyboard_btn.Size = new System.Drawing.Size(36, 41);
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
            this.keyboard_btn.TabIndex = 39;
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
            this.exit_btn.Location = new System.Drawing.Point(556, 2);
            this.exit_btn.Margin = new System.Windows.Forms.Padding(10);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(36, 41);
            this.exit_btn.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.exit_btn.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.exit_btn.Style.FocusedForeColor = System.Drawing.Color.White;
            this.exit_btn.Style.ForeColor = System.Drawing.Color.White;
            this.exit_btn.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.exit_btn.Style.HoverForeColor = System.Drawing.Color.White;
            this.exit_btn.Style.HoverImageForeColor = System.Drawing.Color.Empty;
            this.exit_btn.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.exit_btn.Style.PressedForeColor = System.Drawing.Color.White;
            this.exit_btn.TabIndex = 38;
            this.exit_btn.Text = "X";
            this.exit_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.exit_btn.TextMargin = new System.Windows.Forms.Padding(0);
            this.exit_btn.ThemeName = "Office2016Colorful";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // accept_btn
            // 
            this.accept_btn.AccessibleName = "Button";
            this.accept_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.accept_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.accept_btn.CanOverrideStyle = true;
            this.accept_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accept_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.accept_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accept_btn.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accept_btn.ForeColor = System.Drawing.Color.White;
            this.accept_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.accept_btn.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.accept_btn.ImageMargin = new System.Windows.Forms.Padding(0);
            this.accept_btn.ImageSize = new System.Drawing.Size(40, 40);
            this.accept_btn.Location = new System.Drawing.Point(0, 240);
            this.accept_btn.Margin = new System.Windows.Forms.Padding(10);
            this.accept_btn.Name = "accept_btn";
            this.accept_btn.Size = new System.Drawing.Size(600, 60);
            this.accept_btn.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.accept_btn.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.accept_btn.Style.FocusedForeColor = System.Drawing.Color.White;
            this.accept_btn.Style.ForeColor = System.Drawing.Color.White;
            this.accept_btn.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.accept_btn.Style.HoverForeColor = System.Drawing.Color.White;
            this.accept_btn.Style.HoverImageForeColor = System.Drawing.Color.Empty;
            this.accept_btn.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.accept_btn.Style.PressedForeColor = System.Drawing.Color.White;
            this.accept_btn.TabIndex = 37;
            this.accept_btn.Text = "Accept";
            this.accept_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.accept_btn.TextMargin = new System.Windows.Forms.Padding(0);
            this.accept_btn.ThemeName = "Office2016Colorful";
            this.accept_btn.UseVisualStyleBackColor = false;
            this.accept_btn.Click += new System.EventHandler(this.accept_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(118, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(355, 32);
            this.label3.TabIndex = 36;
            this.label3.Text = "Enter The Card Number ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBatchNumber
            // 
            this.txtBatchNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtBatchNumber.BeforeTouchSize = new System.Drawing.Size(384, 40);
            this.txtBatchNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtBatchNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBatchNumber.CanOverrideStyle = true;
            this.txtBatchNumber.CornerRadius = 5;
            this.txtBatchNumber.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtBatchNumber.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtBatchNumber.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatchNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtBatchNumber.Location = new System.Drawing.Point(118, 151);
            this.txtBatchNumber.Margin = new System.Windows.Forms.Padding(10);
            this.txtBatchNumber.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtBatchNumber.MinimumSize = new System.Drawing.Size(34, 30);
            this.txtBatchNumber.Name = "txtBatchNumber";
            this.txtBatchNumber.PasswordChar = '●';
            this.txtBatchNumber.Size = new System.Drawing.Size(365, 42);
            this.txtBatchNumber.TabIndex = 35;
            this.txtBatchNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBatchNumber.ThemeName = "Default";
            this.txtBatchNumber.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtBatchNumber.ThemeStyle.CornerRadius = 5;
            this.txtBatchNumber.ThemeStyle.DisabledBackColor = System.Drawing.Color.Gray;
            this.txtBatchNumber.ThemeStyle.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.txtBatchNumber.ThemeStyle.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.txtBatchNumber.ThemeStyle.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.txtBatchNumber.ThemeStyle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatchNumber.ThemeStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtBatchNumber.ThemeStyle.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.txtBatchNumber.UseBorderColorOnFocus = true;
            this.txtBatchNumber.UseSystemPasswordChar = true;
            this.txtBatchNumber.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBatchNumber_KeyUp);
            // 
            // BatchNumberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.keyboard_btn);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.accept_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBatchNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BatchNumberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BatchNumberForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.BatchNumberForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtBatchNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.WinForms.Controls.SfButton keyboard_btn;
        private Syncfusion.WinForms.Controls.SfButton exit_btn;
        private Syncfusion.WinForms.Controls.SfButton accept_btn;
        private System.Windows.Forms.Label label3;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtBatchNumber;
    }
}