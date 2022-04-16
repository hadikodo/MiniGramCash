namespace MiniGram.Forms
{
    partial class ProgressBarForm
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
            this.components = new System.ComponentModel.Container();
            this.progressBarAdv1 = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBarAdv1
            // 
            this.progressBarAdv1.BackColor = System.Drawing.Color.Transparent;
            this.progressBarAdv1.BackGradientEndColor = System.Drawing.Color.White;
            this.progressBarAdv1.BackGradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.progressBarAdv1.BackgroundFallbackStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.Tube;
            this.progressBarAdv1.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.Gradient;
            this.progressBarAdv1.BackMultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.progressBarAdv1.BackSegments = false;
            this.progressBarAdv1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            this.progressBarAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.progressBarAdv1.CustomText = "Please Wait...";
            this.progressBarAdv1.CustomWaitingRender = false;
            this.progressBarAdv1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBarAdv1.FontColor = System.Drawing.Color.WhiteSmoke;
            this.progressBarAdv1.ForegroundImage = null;
            this.progressBarAdv1.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.progressBarAdv1.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.progressBarAdv1.Location = new System.Drawing.Point(92, 56);
            this.progressBarAdv1.MultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.progressBarAdv1.Name = "progressBarAdv1";
            this.progressBarAdv1.ProgressFallbackStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Metro;
            this.progressBarAdv1.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.WaitingGradient;
            this.progressBarAdv1.SegmentWidth = 12;
            this.progressBarAdv1.Size = new System.Drawing.Size(242, 29);
            this.progressBarAdv1.TabIndex = 1;
            this.progressBarAdv1.Text = "Please Wait...";
            this.progressBarAdv1.TextStyle = Syncfusion.Windows.Forms.Tools.ProgressBarTextStyles.Custom;
            this.progressBarAdv1.ThemeName = "WaitingGradient";
            this.progressBarAdv1.ThemesEnabled = true;
            this.progressBarAdv1.WaitingGradientEnabled = true;
            this.progressBarAdv1.WaitingGradientWidth = 300;
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ProgressBarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 140);
            this.Controls.Add(this.progressBarAdv1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProgressBarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProgressBarForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ProgressBarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.ProgressBarAdv progressBarAdv1;
        private System.Windows.Forms.Timer timer1;
    }
}