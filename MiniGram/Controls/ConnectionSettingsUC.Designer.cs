namespace MiniGram.Controls
{
    partial class ConnectionSettingsUC
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.server_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxAdv1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBoxAdv2 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.txtUsername2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUserServer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.server_name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.password_txt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.checkBoxAdv1);
            this.panel1.Controls.Add(this.username_txt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 219);
            this.panel1.TabIndex = 0;
            // 
            // server_name
            // 
            this.server_name.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.server_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.server_name.Location = new System.Drawing.Point(224, 28);
            this.server_name.Name = "server_name";
            this.server_name.Size = new System.Drawing.Size(378, 32);
            this.server_name.TabIndex = 6;
            this.server_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.server_name.TextChanged += new System.EventHandler(this.server_name_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(52, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Main Server :";
            // 
            // password_txt
            // 
            this.password_txt.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.password_txt.Location = new System.Drawing.Point(224, 172);
            this.password_txt.Name = "password_txt";
            this.password_txt.PasswordChar = '*';
            this.password_txt.Size = new System.Drawing.Size(378, 32);
            this.password_txt.TabIndex = 12;
            this.password_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password_txt.UseSystemPasswordChar = true;
            this.password_txt.TextChanged += new System.EventHandler(this.password_txt_TextChanged);
            // 
            // label4
            // 
            this.label4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(108, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(494, 54);
            this.label4.TabIndex = 8;
            this.label4.Text = "⩺ Server Security ON/OFF ⩹";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(52, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Password :";
            // 
            // checkBoxAdv1
            // 
            this.checkBoxAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.checkBoxAdv1.BeforeTouchSize = new System.Drawing.Size(546, 54);
            this.checkBoxAdv1.BorderColor = System.Drawing.Color.Transparent;
            this.checkBoxAdv1.BorderSingle = System.Windows.Forms.ButtonBorderStyle.None;
            this.checkBoxAdv1.CheckedImage = global::MiniGram.Properties.Resources._checked;
            this.checkBoxAdv1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxAdv1.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv1.ForeColor = System.Drawing.Color.White;
            this.checkBoxAdv1.GradientEnd = System.Drawing.Color.Transparent;
            this.checkBoxAdv1.GradientStart = System.Drawing.Color.Transparent;
            this.checkBoxAdv1.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.checkBoxAdv1.ImageCheckBox = true;
            this.checkBoxAdv1.ImageCheckBoxSize = new System.Drawing.Size(45, 45);
            this.checkBoxAdv1.Location = new System.Drawing.Point(56, 73);
            this.checkBoxAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.checkBoxAdv1.Name = "checkBoxAdv1";
            this.checkBoxAdv1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.checkBoxAdv1.Size = new System.Drawing.Size(546, 54);
            this.checkBoxAdv1.TabIndex = 7;
            this.checkBoxAdv1.TextContentAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBoxAdv1.TextShadow = true;
            this.checkBoxAdv1.ThemeName = "Default";
            this.checkBoxAdv1.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.checkBoxAdv1.ThemeStyle.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv1.UncheckedImage = global::MiniGram.Properties.Resources._unchecked;
            this.checkBoxAdv1.CheckStateChanged += new System.EventHandler(this.checkBoxAdv1_CheckStateChanged);
            // 
            // username_txt
            // 
            this.username_txt.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.username_txt.Location = new System.Drawing.Point(224, 134);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(378, 32);
            this.username_txt.TabIndex = 10;
            this.username_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.username_txt.TextChanged += new System.EventHandler(this.username_txt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Username :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtPassword2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.checkBoxAdv2);
            this.panel2.Controls.Add(this.txtUsername2);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtUserServer);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 228);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 219);
            this.panel2.TabIndex = 1;
            this.panel2.Visible = false;
            // 
            // txtPassword2
            // 
            this.txtPassword2.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtPassword2.Location = new System.Drawing.Point(224, 171);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.PasswordChar = '*';
            this.txtPassword2.Size = new System.Drawing.Size(378, 32);
            this.txtPassword2.TabIndex = 18;
            this.txtPassword2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword2.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(108, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(494, 54);
            this.label6.TabIndex = 14;
            this.label6.Text = "⩺ Server Security ON/OFF ⩹";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(52, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "Password :";
            // 
            // checkBoxAdv2
            // 
            this.checkBoxAdv2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.checkBoxAdv2.BeforeTouchSize = new System.Drawing.Size(546, 54);
            this.checkBoxAdv2.BorderColor = System.Drawing.Color.Transparent;
            this.checkBoxAdv2.BorderSingle = System.Windows.Forms.ButtonBorderStyle.None;
            this.checkBoxAdv2.CheckedImage = global::MiniGram.Properties.Resources._checked;
            this.checkBoxAdv2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxAdv2.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv2.ForeColor = System.Drawing.Color.White;
            this.checkBoxAdv2.GradientEnd = System.Drawing.Color.Transparent;
            this.checkBoxAdv2.GradientStart = System.Drawing.Color.Transparent;
            this.checkBoxAdv2.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.checkBoxAdv2.ImageCheckBox = true;
            this.checkBoxAdv2.ImageCheckBoxSize = new System.Drawing.Size(45, 45);
            this.checkBoxAdv2.Location = new System.Drawing.Point(56, 72);
            this.checkBoxAdv2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.checkBoxAdv2.Name = "checkBoxAdv2";
            this.checkBoxAdv2.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.checkBoxAdv2.Size = new System.Drawing.Size(546, 54);
            this.checkBoxAdv2.TabIndex = 13;
            this.checkBoxAdv2.TextContentAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBoxAdv2.TextShadow = true;
            this.checkBoxAdv2.ThemeName = "Default";
            this.checkBoxAdv2.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.checkBoxAdv2.ThemeStyle.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv2.UncheckedImage = global::MiniGram.Properties.Resources._unchecked;
            this.checkBoxAdv2.CheckStateChanged += new System.EventHandler(this.checkBoxAdv2_CheckStateChanged);
            // 
            // txtUsername2
            // 
            this.txtUsername2.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtUsername2.Location = new System.Drawing.Point(224, 133);
            this.txtUsername2.Name = "txtUsername2";
            this.txtUsername2.Size = new System.Drawing.Size(378, 32);
            this.txtUsername2.TabIndex = 16;
            this.txtUsername2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(52, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "Username :";
            // 
            // txtUserServer
            // 
            this.txtUserServer.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserServer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.txtUserServer.Location = new System.Drawing.Point(224, 24);
            this.txtUserServer.Name = "txtUserServer";
            this.txtUserServer.Size = new System.Drawing.Size(378, 32);
            this.txtUserServer.TabIndex = 8;
            this.txtUserServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(52, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Users Server :";
            // 
            // ConnectionSettingsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ConnectionSettingsUC";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new System.EventHandler(this.ConnectionSettingsUC_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox server_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        public Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxAdv1;
        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserServer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxAdv2;
        private System.Windows.Forms.TextBox txtUsername2;
        private System.Windows.Forms.Label label8;
    }
}
