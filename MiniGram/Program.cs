
using MiniGram.Classes;
using MiniGram.Forms;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGram
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using(var conn = new SqlConnection(Globals.ConnectionString))
            {
                try
                {
                    conn.Open();
                    Application.Run(new StratScreenForm());
                }
                catch (SqlException)
                {
                    MessageBox.Show("Please Check The Server Name Then Re-Open The System.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Run(new SettingsForm());
                }
            }
        }
    }
}
