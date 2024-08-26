using MiniGram.Controls;
using MiniGram.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniGram.LINQ;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Data.SqlClient;
using System.IO;
using System.Net;

namespace MiniGram
{
    public class Globals
    {
        public static bool isSearchVisible { get; set; }
        public static int newQteNb { get; set; }
        public static int qteChangeNB { get; set; }
        public static bool isReceiptOpen { get; set; } = false;
        public static bool isLoadingFinish { get; set; }
        public static string ConnectionString { get; set; }
        public static MainForm mainForm { get; set; } = new MainForm();
        public static Dictionary<int, int> draftStockTempQte { get; set; } = new Dictionary<int, int>();

        public static double LBPRounding(double price)
        {
            double newPrice = 0;

            double num1 = price / 100;
            num1 = Math.Round(num1,0);
            newPrice = num1 * 100;

            return newPrice;
        }

        public static bool IsNumeric(string str)
        {
            return decimal.TryParse(str, out _);
        }

        //Check If First Price Greater Than Second Price
        public static bool ComparePrices(double? FirstPriceValue, int? FirstPriceCurrency, double? SecondPriceValue, int? SecondPriceCurrency)
        {
            bool isTrue = true;

            if (FirstPriceCurrency == SecondPriceCurrency)
            {
                isTrue = FirstPriceValue >= SecondPriceValue;
            }
            else
            {
                if (SecondPriceCurrency == 2)
                    isTrue = FirstPriceValue / Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString()) >= SecondPriceValue;
                if (FirstPriceCurrency == 2)
                    isTrue = FirstPriceValue >= SecondPriceValue / Double.Parse(Properties.Settings.Default.dollarLBPPrice.ToString());
            }
            return isTrue;
        }

        public static double DBVersion
        {
            get
            {
                return Properties.Settings.Default.DBVersion;
            }
            set
            {
                Properties.Settings.Default.DBVersion = value;
                Properties.Settings.Default.Save(); // Save the changes
            }
        }

       public  static void UpdateDatabase(double reqDBVer)
        {
            Globals.DBVersion = reqDBVer;
            string connectionString = "Data Source=localhost;Initial Catalog=MiniGramCashDB;Integrated Security=True";
            string url = "https://download1638.mediafire.com/rywv353c5yhgdxEhhiBTehvRSv6Svj6rkMlELUJCl6jsqy4Gx1fimnPrVrKr_NudLf4lVgzNcLFwYrFfg9lNOg15NB7M4sPjjAMo1nNYpVBs14KiKGeH3jh71BVwDAlNFe6sXRrOIPke3rV8EE4IYn55zHJ91fpTxYIxCRic2RFR/i8ljlddptpw37yg/DB_1.8.sql"; // Replace with the URL of your SQL file

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
