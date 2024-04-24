
using MiniGram.Classes;
using MiniGram.Forms;
using Syncfusion.ProjIO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
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



            Thread thread = new Thread(async () =>
            {
                try
                {
                    string timeServerUrl = "http://worldclockapi.com/api/json/utc/now"; // You can replace this URL with any time server URL

                    using (HttpClient client = new HttpClient())
                    {
                        HttpResponseMessage response = await client.GetAsync(timeServerUrl);

                        if (response.IsSuccessStatusCode)
                        {
                            string jsonString = await response.Content.ReadAsStringAsync();
                            dynamic result = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonString);
                            string currentTime = result.currentDateTime;

                            DateTime internetTime = DateTime.Parse(currentTime);

                            SetSystemTime(internetTime);

                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
                Thread.CurrentThread.Abort();

            });
            thread.Start();

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

        static void createDatabase()
        {
            string connectionString = "Data Source=localhost;Initial Catalog=master;Integrated Security=True";
            string url = "https://download1076.mediafire.com/ghhxe6bs55rgmx6s7D68za6QoG4BJF6Bq6HZODQZNUiwZoLC-fpcxGh2c4rtQSr_X3eC3QoM-5PVS2n0OHffAKNX3zq4T3sLgecOaPyxqHRAVhJTQuBmj5hwwmKwwSLfpBsU1P94IcGEg3JjLwrO6o0eFv0tJ19CRB-1QSrB-uJP/f51kbke1h4pg7bo/MiniGramDBScript.sql"; // Replace with the URL of your SQL file

            // Download SQL file content from URL
            string sqlCommands = "";
            using (WebClient client = new WebClient())
            {
                client.Headers.Add("User-Agent", "Mozilla/5.0");
                client.Headers.Add("Accept", "text/plain");
                try
                {
                    sqlCommands = client.DownloadString(url);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error downloading SQL file: " + ex.Message);
                }
            }

            // Establish connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    // Execute SQL commands
                    SqlCommand command = new SqlCommand("CREATE DATABASE MiniGramCashDB", connection);
                    command.ExecuteNonQuery();

                    Console.WriteLine("SQL file executed successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error executing SQL file: " + ex.Message);
                }
            }
            connectionString = "Data Source=localhost;Initial Catalog=MiniGramCashDB;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlCommands, connection);
                command.ExecuteNonQuery();
            }
        }

        static void SetSystemTime(DateTime newTime)
        {
            // Check if setting system time requires administrative privileges
            if (!System.Diagnostics.Debugger.IsAttached && !new System.Security.Principal.WindowsPrincipal(System.Security.Principal.WindowsIdentity.GetCurrent()).IsInRole(System.Security.Principal.WindowsBuiltInRole.Administrator))
            {
                throw new Exception("Setting system time requires administrative privileges.");
            }

            // Invoke Windows API to set system time
            SYSTEMTIME systemTime = new SYSTEMTIME();
            systemTime.Year = (ushort)newTime.Year;
            systemTime.Month = (ushort)newTime.Month;
            systemTime.Day = (ushort)newTime.Day;
            systemTime.Hour = (ushort)newTime.Hour;
            systemTime.Minute = (ushort)newTime.Minute;
            systemTime.Second = (ushort)newTime.Second;
            systemTime.Milliseconds = (ushort)newTime.Millisecond;

            SetSystemTime(ref systemTime);
        }

        // Windows API declaration to set system time
        [System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool SetSystemTime(ref SYSTEMTIME systemTime);

        // Struct representing system time
        public struct SYSTEMTIME
        {
            public ushort Year;
            public ushort Month;
            public ushort DayOfWeek;
            public ushort Day;
            public ushort Hour;
            public ushort Minute;
            public ushort Second;
            public ushort Milliseconds;
        }

        private static void deleteMiniGramDirectories()
        {
            // Path to the directories
            string miniGramDirectoryC = @"C:\MiniGram";
            string superTechDirectoryC = @"C:\Supertech";
            string miniGramDirectoryD = @"C:\MiniGram";
            string superTechDirectoryD = @"C:\Supertech";

            if (Directory.Exists(miniGramDirectoryC))
            {
                DeleteDirectory(miniGramDirectoryC);
            }

            if (Directory.Exists(miniGramDirectoryD))
            {
                DeleteDirectory(miniGramDirectoryD);
            }

            if (Directory.Exists(superTechDirectoryC))
            {
                DeleteDirectory(superTechDirectoryC);
            }

            if (Directory.Exists(superTechDirectoryD))
            {
                DeleteDirectory(superTechDirectoryD);
            }
        }

        private static void DeleteDirectory(string path)
        {
            // Delete all files and subdirectories within the directory
            foreach (string file in Directory.GetFiles(path))
            {
                File.SetAttributes(file, FileAttributes.Normal); // Remove read-only attribute if present
                File.Delete(file);
            }
            foreach (string dir in Directory.GetDirectories(path))
            {
                DeleteDirectory(dir);
            }

            // Delete the directory itself
            Directory.Delete(path, true);
        }

    }
}
