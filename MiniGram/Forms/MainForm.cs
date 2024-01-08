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
        private ProgressBar progressBar;
        public MainForm()
        {
            Init();
            InitializeComponent();
        }

        private void RunLoadingThread()
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += RunThread;
            worker.RunWorkerCompleted += HandleThreadCompletion;
            worker.RunWorkerAsync();
        }

        private void RunThread(System.Object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            ProgressBarForm pgb = new ProgressBarForm(3);
            pgb.ShowDialog();
        }

        private void HandleThreadCompletion(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {

        }
        private void exit_btn_Click(object sender, EventArgs e)
        {
            if (Globals.isReceiptOpen)
            {
                MessageBox.Show("Please Finish Your Current Receipt First!!", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Application.Exit();
            }
        }

        private void minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void sett_btn_Click(object sender, EventArgs e)
        {
            PasswordNeedForm psf = new PasswordNeedForm();
            psf.ShowDialog();
            if (psf.isPasswordCorrect)
            {
                new Thread(() =>
                {
                    SettingsForm sf = new SettingsForm();
                    sf.ShowDialog();
                }).Start();

            }
            psf.Dispose();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            currentWidth = panel55.Width;
            new_receipt_btn_Click(null, null);
            if (Properties.Settings.Default.AppVersion.ToString() != Globals.AppVersion)
            {
                UpdateInfoForm uif = new UpdateInfoForm(Globals.AppVersion);
                uif.ShowDialog();
                Properties.Settings.Default.AppVersion = Globals.AppVersion;
                Properties.Settings.Default.Save();
            }
        }

        private void Init()
        {
            Globals.ConnectionString = Properties.Settings.Default.ConnectionString;
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

        public void refreshColors()
        {
            prices_btn.BackColor = Color.FromArgb(0, 63, 63);
            new_receipt_btn.BackColor = Color.FromArgb(0, 63, 63);
            receipt_btn.BackColor = Color.FromArgb(0, 63, 63);
            suppliers_btn.BackColor = Color.FromArgb(0, 63, 63);
            btnReports.BackColor = Color.FromArgb(0, 63, 63);
            btnAbout.BackColor = Color.FromArgb(0, 63, 63);
            btnHoldList.BackColor = Color.FromArgb(0, 63, 63);
            btnDashboard.BackColor = Color.FromArgb(0, 63, 63);
            btnCustomer.BackColor = Color.FromArgb(0, 63, 63);
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

        private void new_receipt_btn_Click(object sender, EventArgs e)
        {

            RunLoadingThread();
            refreshColors();
            new_receipt_btn.BackColor = Color.White;
            title_lbl.Text = "New Receipt";
            main_panel.Controls.Clear();
            POSUC posuc = new POSUC(null);
            posuc.Dock = DockStyle.Fill;
            main_panel.Controls.Add(posuc);

            if (!testConnection(Globals.ConnectionString))
            {
                MessageBox.Show("Connection Error!!\nPlease Check The Settings.");
                SettingsForm sf = new SettingsForm();
                sf.isConnTest = true;
                sf.ShowDialog();
                new_receipt_btn_Click(sender, e);
            }
            posuc.refreshData("");

        }

        private async void receipt_btn_Click(object sender, EventArgs e)
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
                if (!testConnection(Globals.ConnectionString))
                {
                    MessageBox.Show("Connection Error!!\nPlease Check The Settings.");
                    SettingsForm sf = new SettingsForm();
                    sf.isConnTest = true;
                    sf.ShowDialog();
                    receipt_btn_Click(sender, e);
                }
            });
            main_panel.Controls.Add(ruc);
            ruc.refreshData("");

        }
        private void MainForm_MaximizedBoundsChanged(object sender, EventArgs e)
        {

        }

        private async void products_prices_btn_Click(object sender, EventArgs e)
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
                if (!testConnection(Globals.ConnectionString))
                {
                    MessageBox.Show("Connection Error!!\nPlease Check The Settings.");
                    SettingsForm sf = new SettingsForm();
                    sf.isConnTest = true;
                    sf.ShowDialog();
                    products_prices_btn_Click(sender, e);
                }
            });
            main_panel.Controls.Add(puc);
            puc.refreshData("");

        }

        private async void suppliers_btn_Click(object sender, EventArgs e)
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
                if (!testConnection(Globals.ConnectionString))
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
            //   }
        }

        private void btnReports_Click(object sender, EventArgs e)
        {

            refreshColors();
            btnReports.BackColor = Color.White;
            title_lbl.Text = "Reports";
            main_panel.Controls.Clear();
            ReportsUC ruc = new ReportsUC();
            ruc.Dock = DockStyle.Fill;
            main_panel.Controls.Add(ruc);

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {

            refreshColors();
            btnAbout.BackColor = Color.White;
            title_lbl.Text = "About Us";
            main_panel.Controls.Clear();
            AboutUC auc = new AboutUC();
            auc.Dock = DockStyle.Fill;
            main_panel.Controls.Add(auc);

        }

        private async void btnHoldList_Click(object sender, EventArgs e)
        {

            refreshColors();
            btnHoldList.BackColor = Color.White;
            title_lbl.Text = "Receipt Waiting List";
            main_panel.Controls.Clear();
            HoldListUC huc = new HoldListUC();
            huc.Dock = DockStyle.Fill;
            await Task.Run(() =>
            {
                ProgressBarForm pbf = new ProgressBarForm(1);
                pbf.ShowDialog();
                if (!testConnection(Globals.ConnectionString))
                {
                    MessageBox.Show("Connection Error!!\nPlease Check The Settings.");
                    SettingsForm sf = new SettingsForm();
                    sf.isConnTest = true;
                    sf.ShowDialog();
                    btnHoldList_Click(sender, e);
                }
            });
            main_panel.Controls.Add(huc);
            huc.refreshData();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

            refreshColors();
            btnDashboard.BackColor = Color.White;
            title_lbl.Text = "Dashboard";
            main_panel.Controls.Clear();
            DashboardUC duc = new DashboardUC();
            duc.Dock = DockStyle.Fill;
            main_panel.Controls.Add(duc);
        }

        private async void btnCustomer_Click(object sender, EventArgs e)
        {
            refreshColors();
            btnCustomer.BackColor = Color.White;
            title_lbl.Text = "Customers";
            main_panel.Controls.Clear();
            CustomersUC cuc = new CustomersUC();
            cuc.Dock = DockStyle.Fill;
            await Task.Run(() =>
            {
                ProgressBarForm pbf = new ProgressBarForm(1);
                pbf.ShowDialog();
                if (!testConnection(Globals.ConnectionString))
                {
                    MessageBox.Show("Connection Error!!\nPlease Check The Settings.");
                    SettingsForm sf = new SettingsForm();
                    sf.isConnTest = true;
                    sf.ShowDialog();
                    products_prices_btn_Click(sender, e);
                }
            });
            main_panel.Controls.Add(cuc);
            cuc.refreshData("");
        }
    }
}
