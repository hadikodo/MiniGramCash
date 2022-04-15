using MiniGram.Classes;
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
         protected override CreateParams CreateParams
         {
             get
             {
                 CreateParams handleparam = base.CreateParams;
                 handleparam.ExStyle = 0x02000000;
                 return handleparam;
             }
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
            currentWidth = panel55.Width;
            new_receipt_btn_Click(new_receipt_btn, e);
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
            prices_btn.BackColor = Color.FromArgb(0, 63, 63);
            new_receipt_btn.BackColor = Color.FromArgb(0, 63, 63);
            receipt_btn.BackColor = Color.FromArgb(0, 63, 63);
            items_btn.BackColor = Color.FromArgb(0, 63, 63);
            reports_btn.BackColor = Color.FromArgb(0, 63, 63);
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            refreshColors();
            prices_btn.BackColor = Color.White;
            title_lbl.Text = "Products And Prices";
            main_panel.Controls.Clear();
            ProductsUC puc = new ProductsUC();
            main_panel.Controls.Add(puc);
            puc.refreshData();
            puc.Dock = DockStyle.Fill;
        }

        private void new_receipt_btn_Click(object sender, EventArgs e)
        {
            refreshColors();
            new_receipt_btn.BackColor = Color.White;
            title_lbl.Text = "New Receipt";
            main_panel.Controls.Clear();
            POSUC posuc = new POSUC();
            main_panel.Controls.Add(posuc);
            posuc.refreshData("");
            posuc.Dock = DockStyle.Fill;
        }

        private void receipt_btn_Click(object sender, EventArgs e)
        {
            refreshColors();
            receipt_btn.BackColor = Color.White;
            title_lbl.Text = "Receipts";
            main_panel.Controls.Clear();
            ReceiptsUC ruc = new ReceiptsUC();
            main_panel.Controls.Add(ruc);
            ruc.refreshData();
            ruc.Dock = DockStyle.Fill;
        }

        private void products_btn_Click(object sender, EventArgs e)
        {
            refreshColors();
            items_btn.BackColor = Color.White;
            title_lbl.Text = "Stock";
            main_panel.Controls.Clear();
            ItemsUC iuc = new ItemsUC();
            main_panel.Controls.Add(iuc);
            iuc.refreshData();
            iuc.Dock = DockStyle.Fill;
        }

        private void MainForm_MaximizedBoundsChanged(object sender, EventArgs e)
        {

        }

        private void reports_btn_Click(object sender, EventArgs e)
        {
            refreshColors();
            reports_btn.BackColor = Color.White;
            title_lbl.Text = "Reports";
            main_panel.Controls.Clear();
        }
    }
}
