using MiniGram.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGram.Forms
{
    public partial class SettingsForm : Form
    {
        private GeneralSettingsUC gsuc = new GeneralSettingsUC();
        private ConnectionSettingsUC csuc = new ConnectionSettingsUC();
        public bool isConnTest = false;
        public SettingsForm()
        {
            InitializeComponent();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            if(isConnTest)
                csuc.Save();
            else
                this.Close();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            if (isConnTest)
                connection_btn_Click(connection_btn, e);
            else
                general_btn_Click(general_btn, e);
        }

        private void general_btn_Click(object sender, EventArgs e)
        {
            refreshColors();
            general_btn.Style.BackColor = Color.White;
            title_lbl.Text = "Generals";
            if (Properties.Settings.Default.somethingChanged)
            {
                DialogResult dialogResult = MessageBox.Show("Do You Want To Save Changes??", "Important", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    csuc.Save();
                }
                else if (dialogResult == DialogResult.No)
                {
                    Properties.Settings.Default.somethingChanged = false;
                    Properties.Settings.Default.Save();
                }
            }
            main_panel.Controls.Clear();
            //gsuc.GeneralSettingsUC_Load(gsuc, e);
            gsuc.LoadData();
            main_panel.Controls.Add(gsuc);
            gsuc.Dock = DockStyle.Fill;
        }

        public void connection_btn_Click(object sender, EventArgs e)
        {
            refreshColors();
            connection_btn.Style.BackColor = Color.White;
            title_lbl.Text = "Connections";
            if (Properties.Settings.Default.somethingChanged)
            {
                DialogResult dialogResult = MessageBox.Show("Do You Want To Save Changes??", "Important", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    gsuc.Save();
                }
                else if(dialogResult == DialogResult.No)
                {
                    Properties.Settings.Default.somethingChanged = false;
                    Properties.Settings.Default.Save();
                }
            }
            main_panel.Controls.Clear();
            csuc.LoadData();
            main_panel.Controls.Add(csuc);
            csuc.Dock = DockStyle.Fill;
        }
        private void refreshColors()
        {
            connection_btn.Style.BackColor = Color.FromArgb(0, 63, 63);
            general_btn.Style.BackColor = Color.FromArgb(0, 63, 63);
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            gsuc.Save();
            csuc.Save();
            this.Close();
        }

        private void keyboard_btn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = ((Environment.GetFolderPath(Environment.SpecialFolder.System) + @"\osk.exe"));
            Process process = new Process();
            process.StartInfo = ps;
            process.Start();
        }
    }
}
