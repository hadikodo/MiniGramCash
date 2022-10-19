using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGram.Controls
{
    public partial class ConnectionSettingsUC : UserControl
    {
        public ConnectionSettingsUC()
        {
            InitializeComponent();
        }

        private void ConnectionSettingsUC_Load(object sender, EventArgs e)
        {

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

        public void LoadData()
        {
            server_name.Text = Properties.Settings.Default.ServerName.ToString();
            if (Properties.Settings.Default.ServerSecurity)
            {
                checkBoxAdv1.CheckState = CheckState.Checked;
                username_txt.Visible = true;
                password_txt.Visible = true;
                label1.Visible = true;
                label3.Visible = true;
                username_txt.Text = Properties.Settings.Default.Username;
                password_txt.Text = Properties.Settings.Default.Password;
            }
            else
            {
                checkBoxAdv1.CheckState = CheckState.Unchecked;
                username_txt.Visible = false;
                password_txt.Visible = false;
                label1.Visible = false;
                label3.Visible = false;
            }
            Properties.Settings.Default.somethingChanged = false;
            Properties.Settings.Default.Save();
        }

        public void Save()
        {
            string conn;
            if (checkBoxAdv1.Checked)
            {
               conn = "Data Source=" + server_name.Text + ";Initial Catalog=MiniGramCashDB;User ID=" + username_txt.Text + ";Password=" + password_txt.Text;
                if (testConnection(conn))
                {
                    Properties.Settings.Default.ServerName = server_name.Text;
                    Properties.Settings.Default.Username = username_txt.Text;
                    Properties.Settings.Default.Password = password_txt.Text;
                    Properties.Settings.Default.ServerSecurity = true;
                    Properties.Settings.Default.ConnectionString = conn;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    MessageBox.Show("Connection To Server Failed, Please Check Server Information !!", "Error");
                }
            }
            else
            {
               conn = "Data Source=" + server_name.Text + ";Initial Catalog=MiniGramCashDB;Integrated Security=True";
                if (testConnection(conn))
                {
                    Properties.Settings.Default.ServerName = server_name.Text;
                    Properties.Settings.Default.ServerSecurity = false;
                    Properties.Settings.Default.ConnectionString = conn;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    MessageBox.Show("Connection To Server Failed, Please Check Server Information !!", "Error");
                }
            }
            Properties.Settings.Default.somethingChanged = false;
            Properties.Settings.Default.Save();
        }

        private void checkBoxAdv1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxAdv1.Checked)
            {
                username_txt.Visible = true;
                password_txt.Visible = true;
                label1.Visible = true;
                label3.Visible = true;
                username_txt.Text = Properties.Settings.Default.Username;
                password_txt.Text = Properties.Settings.Default.Password;
            }
            else
            {
                username_txt.Visible = false;
                password_txt.Visible = false;
                label1.Visible = false;
                label3.Visible = false;
            }
            Properties.Settings.Default.somethingChanged = true;
            Properties.Settings.Default.Save();
        }

        private void server_name_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.somethingChanged = true;
            Properties.Settings.Default.Save();
        }

        private void username_txt_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.somethingChanged = true;
            Properties.Settings.Default.Save();
        }

        private void password_txt_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.somethingChanged = true;
            Properties.Settings.Default.Save();
        }
    }
}
