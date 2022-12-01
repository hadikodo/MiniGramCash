using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGram.Controls
{
    public partial class AboutUC : UserControl
    {
        public AboutUC()
        {
            InitializeComponent();
        }

        private void ultraLiveTileView1_TileClick(object sender, Infragistics.Win.UltraWinLiveTileView.TileClickEventArgs e)
        {
            if (e.Tile.Key == "btnFacebook" ) {
                System.Diagnostics.Process.Start("http://www.facebook.com/SuperTechlb");
            }
            else if (e.Tile.Key == "btnWhatsapp")
            {
                System.Diagnostics.Process.Start("https://wa.me/96181656286?text=Hello");
            }
            else if (e.Tile.Key == "btnInstagram")
            {
                System.Diagnostics.Process.Start("https://www.instagram.com/supertechlb/");
            }
            else if (e.Tile.Key == "btnEmail")
            {
                System.Diagnostics.Process.Start("mailto:supertechlebanon@gmail.com");
            }
        }
    }
}
