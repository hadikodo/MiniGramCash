using MiniGram.Controls;
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
        private Boolean isOpened = true;
        private int currentWidth;
        public MainForm()
        {
            InitializeComponent();
        }
       /* protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle = 0x02000000;
                return handleparam;
            }
        }*/

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
            currentWidth = panel55.Width;
            dashboard_btn_Click(dashboard_btn, e);
            
        }

        private void sfButton1_Click(object sender, EventArgs e)
        {
            animationTimer.Start();
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            if (isOpened)
            {
                if (panel55.Width != 0)
                {
                    panel55.Width -= 70;
                }
                else
                {
                    isOpened = false;
                    animationTimer.Stop();
                }
            }
            else
            {
                if (panel55.Width <= currentWidth)
                {
                    panel55.Width += 70;
                }
                else
                {
                    panel55.Width = currentWidth;
                    isOpened = true;
                    animationTimer.Stop();
                }
            }
        }

        private void refreshColors()
        {
            dashboard_btn.BackColor = Color.FromArgb(0, 63, 63);
            new_receipt_btn.BackColor = Color.FromArgb(0, 63, 63);
            receipt_btn.BackColor = Color.FromArgb(0, 63, 63);
            contract_btn.BackColor = Color.FromArgb(0, 63, 63);
            products_btn.BackColor = Color.FromArgb(0, 63, 63);
            suppliers_btn.BackColor = Color.FromArgb(0, 63, 63);
            customers_btn.BackColor = Color.FromArgb(0, 63, 63);
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            refreshColors();
            dashboard_btn.BackColor = Color.White;
            title_lbl.Text = "Dashboard";
        }

        private void new_receipt_btn_Click(object sender, EventArgs e)
        {
            refreshColors();
            new_receipt_btn.BackColor = Color.White;
            title_lbl.Text = "New Receipt";
        }

        private void receipt_btn_Click(object sender, EventArgs e)
        {
            refreshColors();
            receipt_btn.BackColor = Color.White;
            title_lbl.Text = "Receipts";
        }

        private void contract_btn_Click(object sender, EventArgs e)
        {
            refreshColors();
            contract_btn.BackColor = Color.White;
            title_lbl.Text = "Contracts";
        }

        private void products_btn_Click(object sender, EventArgs e)
        {
            refreshColors();
            products_btn.BackColor = Color.White;
            title_lbl.Text = "Products";
        }

        private void suppliers_btn_Click(object sender, EventArgs e)
        {
            refreshColors();
            suppliers_btn.BackColor = Color.White;
            title_lbl.Text = "Suppliers";
            main_panel.Controls.Clear();
            SuppliersUC suc  = new SuppliersUC();
            main_panel.Controls.Add(suc);
            suc.Dock = DockStyle.Fill;
            suc.refreshData();
        }

        private void customers_btn_Click(object sender, EventArgs e)
        {
            refreshColors();
            customers_btn.BackColor = Color.White;
            title_lbl.Text = "Customers";
            main_panel.Controls.Clear();
            CustomersUC cuc = new CustomersUC();
            main_panel.Controls.Add(cuc);
            cuc.Dock = DockStyle.Fill;
            cuc.refreshData();
        }

        private void MainForm_MaximizedBoundsChanged(object sender, EventArgs e)
        {

        }
    }
}
