using MiniGram.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGram
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void sett_btn_Click(object sender, EventArgs e)
        {
            SettingsForm sf = new SettingsForm();
            sf.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dash_btn.Selected = true;
        }

        private void sfButton1_Click(object sender, EventArgs e)
        {
            menu_nav.ToggleDrawer();
            menu_nav.Focus();
        }

        private void menu_nav_Closing(object sender, CancelEventArgs e)
        {
            menu_toggle_btn.BackColor = Color.White;
            menu_toggle_btn.ForeColor = Color.FromArgb(0, 63, 63);
            menu_toggle_btn.Text = "Menu ▶";
            menu_toggle_btn.Width = 195;
            menu_toggle_btn.Update();
        }

        private void menu_nav_Opening(object sender, Syncfusion.Windows.Forms.Tools.NavigationDrawer.OpeningEventArgs e)
        {
            menu_toggle_btn.BackColor = Color.FromArgb(0, 63, 63);
            menu_toggle_btn.ForeColor = Color.White;
            menu_toggle_btn.Text = "MiniGram  ◀";
            menu_toggle_btn.Width = 318;
            menu_toggle_btn.Update();
        }

        private void menu_nav_ItemClicked(object sender, Syncfusion.Windows.Forms.Tools.MenuItemClickedEventArgs e)
        {
            if (dash_btn.Selected)
            {
                sale_btn.Selected = false;
            }
            else if (sale_btn.Selected)
            {
                dash_btn.Selected = false;
            }
        }
    }
}
