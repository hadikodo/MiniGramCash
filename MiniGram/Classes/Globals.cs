using MiniGram.Controls;
using MiniGram.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGram.Classes
{
    class Globals
    {
        public static bool isSearchVisible { get; set; }
        public static int deleteNB { get; set; }
        public static int qteChangeNB { get; set; }
        public static bool isReceiptOpen { get; set; } = false;
        public static bool isLoadingFinish { get; set; }
        public static string ConnectionString { get; set; }
        public static string AppVersion { get; set; }
        public static MainForm mainForm { get; set; } = new MainForm();



        public const decimal DatabaseVersion = 1.00M;
    }
}
