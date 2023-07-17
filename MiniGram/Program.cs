
using MiniGram.Classes;
using MiniGram.Forms;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGram
{
    internal static class Program
    {
        ///// <summary>
        ///// The main entry point for the application.
        ///// </summary>
        //[DllImport("gdi32.dll",EntryPoint ="AddFontResourceW",SetLastError =true)]
        //public static extern int AddFontResource([In][MarshalAs(UnmanagedType.LPWStr)] string lpFileName);

        //[DllImport("gdi32.dll", EntryPoint = "RemoveFontResourceW", SetLastError = true)]
        //public static extern int RemoveFontResource([In][MarshalAs(UnmanagedType.LPWStr)] string lpFileName);

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
                    //Console.WriteLine(AddFontResource("X:\\MiniGramCash\\MiniGram\\Fonts\\Bookman Old Style.ttf"));
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
