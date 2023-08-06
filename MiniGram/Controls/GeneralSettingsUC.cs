﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGram.Controls
{
    public partial class GeneralSettingsUC : UserControl
    {
        public GeneralSettingsUC()
        {
            InitializeComponent();
        }

        private void checkBoxAdv1_CheckStateChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.somethingChanged = true;
            Properties.Settings.Default.Save();
        }

        private void GeneralSettingsUC_Load(object sender, EventArgs e)
        {

        }

        public void LoadData()
        {
            if (Properties.Settings.Default.startup)
                checkBoxAdv1.CheckState = CheckState.Checked;
            else
                checkBoxAdv1.CheckState = CheckState.Unchecked;

            if (Properties.Settings.Default.showListInSale)
                chkboxShowUnshowList.CheckState = CheckState.Checked;
            else
                chkboxShowUnshowList.CheckState = CheckState.Unchecked;

            if (Properties.Settings.Default.printInCheckout)
                chkboxDisableReceiptPrnt.CheckState = CheckState.Checked;
            else
                chkboxDisableReceiptPrnt.CheckState = CheckState.Unchecked;

            if (Properties.Settings.Default.CheckoutExtended)
                checkBoxEnableExtendedCheckout.CheckState = CheckState.Checked;
            else
                checkBoxEnableExtendedCheckout.CheckState = CheckState.Unchecked;


            Dictionary<int,string> ReceiptSize = new Dictionary<int,string>();
            ReceiptSize.Add(1, "A4 ( 21 x 29.7 cm )");
            ReceiptSize.Add(2, "70 mm");
            cboxReceiptSize.DataSource = new BindingSource(ReceiptSize, null);
            cboxReceiptSize.DisplayMember= "Value";
            cboxReceiptSize.ValueMember= "Key";

            cboxReceiptSize.SelectedValue = Properties.Settings.Default.ReceiptType;
            string strDefaultPrinter = Properties.Settings.Default.printerName;
            foreach (String strPrinter in PrinterSettings.InstalledPrinters)
            {
                printer_drp.Items.Add(strPrinter);
                if (strPrinter == strDefaultPrinter)
                {
                    printer_drp.SelectedIndex = printer_drp.Items.IndexOf(strPrinter);
                }
            }
            BuyDollarPrice.Text = Properties.Settings.Default.BuyDollarLBPPrice.ToString();
            SellDollarPrice.Text = Properties.Settings.Default.dollarLBPPrice.ToString();
            txtTVALBPPrice.Text = Properties.Settings.Default.TVALBPPrice.ToString();
            txtTVAPercentage.Text = Properties.Settings.Default.TVAPercentage.ToString();
            Properties.Settings.Default.somethingChanged = false;
            Properties.Settings.Default.Save();
        }

        private void printer_drp_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.somethingChanged = true;
            Properties.Settings.Default.Save();
        }

        public void Save()
        {
            if (checkBoxAdv1.Checked)
            {
                Properties.Settings.Default.startup = true;
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
                {
                    key.SetValue("MiniGram", "\"" + Application.ExecutablePath + "\"");
                }
            }
            else
            {
                Properties.Settings.Default.startup = false;
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
                {
                    try
                    {
                        key.DeleteValue("MiniGram");
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
            }
            Properties.Settings.Default.showListInSale = chkboxShowUnshowList.Checked;
            Properties.Settings.Default.printInCheckout = chkboxDisableReceiptPrnt.Checked;
            Properties.Settings.Default.CheckoutExtended = checkBoxEnableExtendedCheckout.Checked;
            Properties.Settings.Default.ReceiptType = Int32.Parse(cboxReceiptSize.SelectedValue.ToString());
            Properties.Settings.Default.printerName = printer_drp.SelectedItem.ToString();
            Properties.Settings.Default.dollarLBPPrice = Int32.Parse(SellDollarPrice.Text);
            Properties.Settings.Default.BuyDollarLBPPrice = Int32.Parse(BuyDollarPrice.Text);
            Properties.Settings.Default.TVALBPPrice = Int32.Parse(txtTVALBPPrice.Text);
            Properties.Settings.Default.TVAPercentage = Int32.Parse(txtTVAPercentage.Text);
            Properties.Settings.Default.somethingChanged = false;
            Properties.Settings.Default.Save();
        }

        private void dollar_price_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.somethingChanged = true;
            Properties.Settings.Default.Save();
        }

        private void chkboxDisableReceiptPrnt_CheckStateChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.somethingChanged = true;
            Properties.Settings.Default.Save();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtTVALBPPrice_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.somethingChanged = true;
            Properties.Settings.Default.Save();
        }

        private void txtTVAPercentage_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.somethingChanged = true;
            Properties.Settings.Default.Save();
        }

        private void BuyDollarPrice_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.somethingChanged = true;
            Properties.Settings.Default.Save();
        }
    }
}
