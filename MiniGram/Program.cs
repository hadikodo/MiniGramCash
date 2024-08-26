﻿

using MiniGram.Forms;

using System;

using System.Data.SqlClient;

using System.Windows.Forms;

namespace MiniGram
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            using (var conn = new SqlConnection(Globals.ConnectionString))
            {
                try
                {
                    conn.Open();
                    Application.Run(Globals.mainForm);
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
