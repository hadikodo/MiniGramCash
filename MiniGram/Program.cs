
using MiniGram.Classes;
using MiniGram.Forms;
using MiniGram.LINQ;
using Syncfusion.PresentationToPdfConverter;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Deployment.Application;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
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
            using(var conn = new SqlConnection(Globals.ConnectionString))
            {
                try
                {
                    conn.Open();
                    //Console.WriteLine(AddFontResource("X:\\MiniGramCash\\MiniGram\\Fonts\\Bookman Old Style.ttf"));
                    using(var ax  = new MiniGramDBDataContext(Globals.ConnectionString))
                    {
                        TBLVERSION currentDatabaseVersion = (from aj in ax.TBLVERSIONs where aj.ID == 1 select aj).SingleOrDefault();
                        if(currentDatabaseVersion != null && currentDatabaseVersion.CurrentVersion != Globals.DatabaseVersion) {
                            try
                            {

                                string script = @"
                                                               ";
                                SqlCommand cmd = new SqlCommand(script, conn);
                                cmd.ExecuteNonQuery();

                            }catch(Exception ex) { 
                            
                            }
                            currentDatabaseVersion.CurrentVersion = Globals.DatabaseVersion;
                            ax.SubmitChanges();
                        }
                    }
                    conn.Close();


                    if (ApplicationDeployment.IsNetworkDeployed)
                    {
                        Globals.AppVersion = ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();
                    }
                    else
                    {
                        Globals.AppVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
                    }
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
