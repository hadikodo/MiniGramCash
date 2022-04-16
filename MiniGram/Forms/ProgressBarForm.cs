using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGram.Forms
{
    public partial class ProgressBarForm : Form
    {
        private int second;
        public ProgressBarForm(int s)
        {
            InitializeComponent();
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
            second = s;
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.LimeGreen, e.ClipRectangle);
        }

        private void ProgressBarForm_Load(object sender, EventArgs e)
        {
            timer1.Interval = second * 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
