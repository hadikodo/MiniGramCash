using MiniGram.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGram.Forms
{
    public partial class StratScreenForm : Form
    {
        public StratScreenForm()
        {
            InitializeComponent();
        }

        private void StratScreenForm_Load(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(() =>
            {

                    Application.Run(Globals.mainForm);
            }));
            thread.Start();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            this.Close();
        }
    }
}
