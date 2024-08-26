namespace MiniGram.Forms
{
    partial class WeightInputForm
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
            this.btnKeyboard = new Syncfusion.WinForms.Controls.SfButton();
            this.btnExit = new Syncfusion.WinForms.Controls.SfButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWeight = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.accept_btn = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKeyboard
            // 
            this.btnKeyboard.AccessibleName = "Button";
            this.btnKeyboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnKeyboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKeyboard.CanOverrideStyle = true;
            this.btnKeyboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKeyboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeyboard.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeyboard.ForeColor = System.Drawing.Color.White;
            this.btnKeyboard.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKeyboard.ImageMargin = new System.Windows.Forms.Padding(0);
            this.btnKeyboard.ImageSize = new System.Drawing.Size(25, 25);
            this.btnKeyboard.Location = new System.Drawing.Point(508, 4);
            this.btnKeyboard.Margin = new System.Windows.Forms.Padding(0);
            this.btnKeyboard.Name = "btnKeyboard";
            this.btnKeyboard.Size = new System.Drawing.Size(36, 41);
            this.btnKeyboard.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnKeyboard.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnKeyboard.Style.FocusedForeColor = System.Drawing.Color.White;
            this.btnKeyboard.Style.ForeColor = System.Drawing.Color.White;
            this.btnKeyboard.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.btnKeyboard.Style.HoverForeColor = System.Drawing.Color.White;
            this.btnKeyboard.Style.HoverImageForeColor = System.Drawing.Color.Empty;
            this.btnKeyboard.Style.Image = global::MiniGram.Properties.Resources.keyboard;
            this.btnKeyboard.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.btnKeyboard.Style.PressedForeColor = System.Drawing.Color.White;
            this.btnKeyboard.TabIndex = 40;
            this.btnKeyboard.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.btnKeyboard.TextMargin = new System.Windows.Forms.Padding(0);
            this.btnKeyboard.ThemeName = "Office2016Colorful";
            this.btnKeyboard.UseVisualStyleBackColor = true;
            this.btnKeyboard.Click += new System.EventHandler(this.btnKeyboard_Click);
            // 
            // btnExit
            // 
            this.btnExit.AccessibleName = "Button";
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.CanOverrideStyle = true;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.ImageMargin = new System.Windows.Forms.Padding(0);
            this.btnExit.ImageSize = new System.Drawing.Size(40, 40);
            this.btnExit.Location = new System.Drawing.Point(554, 4);
            this.btnExit.Margin = new System.Windows.Forms.Padding(10);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(36, 41);
            this.btnExit.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnExit.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnExit.Style.FocusedForeColor = System.Drawing.Color.White;
            this.btnExit.Style.ForeColor = System.Drawing.Color.White;
            this.btnExit.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.btnExit.Style.HoverForeColor = System.Drawing.Color.White;
            this.btnExit.Style.HoverImageForeColor = System.Drawing.Color.Empty;
            this.btnExit.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.btnExit.Style.PressedForeColor = System.Drawing.Color.White;
            this.btnExit.TabIndex = 39;
            this.btnExit.Text = "X";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.btnExit.TextMargin = new System.Windows.Forms.Padding(0);
            this.btnExit.ThemeName = "Office2016Colorful";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(119, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(362, 32);
            this.label3.TabIndex = 37;
            this.label3.Text = "Enter The Weight Amout";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtWeight
            // 
            this.txtWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtWeight.BeforeTouchSize = new System.Drawing.Size(172, 42);
            this.txtWeight.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWeight.CanOverrideStyle = true;
            this.txtWeight.CornerRadius = 5;
            this.txtWeight.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtWeight.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtWeight.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtWeight.Location = new System.Drawing.Point(208, 153);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(10);
            this.txtWeight.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtWeight.MinimumSize = new System.Drawing.Size(34, 30);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(172, 42);
            this.txtWeight.TabIndex = 36;
            this.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWeight.ThemeName = "Default";
            this.txtWeight.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtWeight.ThemeStyle.CornerRadius = 5;
            this.txtWeight.ThemeStyle.DisabledBackColor = System.Drawing.Color.Gray;
            this.txtWeight.ThemeStyle.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.txtWeight.ThemeStyle.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.txtWeight.ThemeStyle.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.txtWeight.ThemeStyle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.ThemeStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtWeight.ThemeStyle.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.txtWeight.UseBorderColorOnFocus = true;
            this.txtWeight.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtWeight_KeyUp);
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
            this.accept_btn.TabIndex = 41;
            this.accept_btn.Text = "Accept";
            this.accept_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.accept_btn.TextMargin = new System.Windows.Forms.Padding(0);
            this.accept_btn.ThemeName = "Office2016Colorful";
            this.accept_btn.UseVisualStyleBackColor = false;
            this.accept_btn.Click += new System.EventHandler(this.accept_btn_Click);
            // 
            // WeightInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.accept_btn);
            this.Controls.Add(this.btnKeyboard);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtWeight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WeightInputForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmWeightInput";
            this.Load += new System.EventHandler(this.frmWeightInput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.WinForms.Controls.SfButton btnKeyboard;
        private Syncfusion.WinForms.Controls.SfButton btnExit;
        private System.Windows.Forms.Label label3;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtWeight;
        private Syncfusion.WinForms.Controls.SfButton accept_btn;
    }
}