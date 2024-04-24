using MiniGram.Controls;
using MiniGram.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniGram.LINQ;
using System.Windows.Forms;

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

            double num1 = price / 1000;
            num1 = Math.Round(num1,0);
            newPrice = num1 * 1000;

            return newPrice;
        }
    }
}
