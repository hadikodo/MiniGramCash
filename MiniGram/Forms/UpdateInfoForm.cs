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
    public partial class UpdateInfoForm : Form
    {
        private string newVersion;
        public UpdateInfoForm(string newVersion)
        {
            this.newVersion = newVersion;
            InitializeComponent();
        }

        private void UpdateInfoForm_Load(object sender, EventArgs e)
        {
            lblTitle.Text = lblTitle.Text + newVersion;
        }
    }
}
