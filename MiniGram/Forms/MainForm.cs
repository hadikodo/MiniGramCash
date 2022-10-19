using MiniGram.Classes;
using MiniGram.Controls;
using MiniGram.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            new Thread(() =>
            {
                SettingsForm sf = new SettingsForm();
                sf.ShowDialog();
            }).Start();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //DateTime start = new DateTime(2022, 6, 10);
            //DateTime end = new DateTime(2022, 7, 11);
            //if (DateTime.Now > end || DateTime.Now < start)
            //{
                //MessageBox.Show("Trial Version End!\nPlease Purchase The Full Version To Continue.", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Application.Exit();
            //}
            //else
            //{
                //int day = (end - start).Days - (DateTime.Now - start).Days;
                //MessageBox.Show("Trial Version Will End In " + day + " Days\nPlease Purchase The Full Version.", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                currentWidth = panel55.Width;
                new_receipt_btn_Click(new_receipt_btn, e);
            //}
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
            suppliers_btn.BackColor = Color.FromArgb(0, 63, 63);
        }
        public bool testConnection(string ConnString)
        {
            try
            {
                string cnn = ConnString;
                SqlConnectionStringBuilder conn = new SqlConnectionStringBuilder(cnn);
                conn.ConnectTimeout = 1;
                cnn = conn.ToString();
                using (SqlConnection cn = new SqlConnection(cnn))
                {
                    cn.Open();
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        private async void new_receipt_btn_Click(object sender, EventArgs e)
        {
                refreshColors();
                new_receipt_btn.BackColor = Color.White;
                title_lbl.Text = "New Receipt";
                main_panel.Controls.Clear();
                POSUC posuc = new POSUC();
                posuc.Dock = DockStyle.Fill;
                main_panel.Controls.Add(posuc);
                await Task.Run(() =>
                {
                    ProgressBarForm pbf = new ProgressBarForm(1);
                    pbf.ShowDialog();
                    if (!testConnection(Properties.Settings.Default.ConnectionString))
                    {
                        MessageBox.Show("Connection Error!!\nPlease Check The Settings.");
                        SettingsForm sf = new SettingsForm();
                        sf.isConnTest = true;
                        sf.ShowDialog();
                        new_receipt_btn_Click(sender, e);
                    }
                });
                posuc.refreshData("");

        }

        private async void receipt_btn_Click(object sender, EventArgs e)
        {
        if (Globals.isReceiptOpen)
        {
            MessageBox.Show("Please Finish Your Current Receipt First!!", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            refreshColors();
            receipt_btn.BackColor = Color.White;
            title_lbl.Text = "Receipts";
            main_panel.Controls.Clear();
            ReceiptsUC ruc = new ReceiptsUC();
            ruc.Dock = DockStyle.Fill;
            await Task.Run(() =>
            {
                ProgressBarForm pbf = new ProgressBarForm(1);
                pbf.ShowDialog();
                if (!testConnection(Properties.Settings.Default.ConnectionString))
                {
                    MessageBox.Show("Connection Error!!\nPlease Check The Settings.");
                    SettingsForm sf = new SettingsForm();
                    sf.isConnTest = true;
                    sf.ShowDialog();
                    receipt_btn_Click(sender, e);
                }
            });
            main_panel.Controls.Add(ruc);
            ruc.refreshData();
            }
        }
        private void MainForm_MaximizedBoundsChanged(object sender, EventArgs e)
        {

        }

        private async void products_prices_btn_Click(object sender, EventArgs e)
        {
            if (Globals.isReceiptOpen)
            {
                MessageBox.Show("Please Finish Your Current Receipt First!!", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                refreshColors();
                prices_btn.BackColor = Color.White;
                title_lbl.Text = "Products And Prices";
                main_panel.Controls.Clear();
                ProductsUC puc = new ProductsUC();
                puc.Dock = DockStyle.Fill;
                await Task.Run(() =>
                {
                    ProgressBarForm pbf = new ProgressBarForm(1);
                    pbf.ShowDialog();
                    if (!testConnection(Properties.Settings.Default.ConnectionString))
                    {
                        MessageBox.Show("Connection Error!!\nPlease Check The Settings.");
                        SettingsForm sf = new SettingsForm();
                        sf.isConnTest = true;
                        sf.ShowDialog();
                        products_prices_btn_Click(sender, e);
                    }
                });
                main_panel.Controls.Add(puc);
                puc.refreshData();
            }
        }

        private async void suppliers_btn_Click(object sender, EventArgs e)
        {
            if (Globals.isReceiptOpen)
            {
                MessageBox.Show("Please Finish Your Current Receipt First!!", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                refreshColors();
                suppliers_btn.BackColor = Color.White;
                title_lbl.Text = "Suppliers";
                main_panel.Controls.Clear();
                SupplierUC iuc = new SupplierUC();
                iuc.Dock = DockStyle.Fill;
                await Task.Run(() =>
                {
                    ProgressBarForm pbf = new ProgressBarForm(1);
                    pbf.ShowDialog();
                    if (!testConnection(Properties.Settings.Default.ConnectionString))
                    {
                        MessageBox.Show("Connection Error!!\nPlease Check The Settings.");
                        SettingsForm sf = new SettingsForm();
                        sf.isConnTest = true;
                        sf.ShowDialog();
                        suppliers_btn_Click(sender, e);
                    }
                });
                main_panel.Controls.Add(iuc);
                iuc.refreshData();
            }
        }
    }
}
