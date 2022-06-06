﻿using MiniGram.LINQ;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGram.Forms
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddSupplierForm_Load(object sender, EventArgs e)
        {
            warning_lable.Visible = false;
            hasqte_combo.SelectedIndex = 0;
            using(var cnx = new MiniGramDBDataContext(Properties.Settings.Default.ConnectionString))
            {
                var suppList = cnx.sp_select_suppliers("").ToList();
                foreach(var supp in suppList)
                {
                    supp_cbox.Items.Add(supp.SupplierName);
                }
            }
            //supp_cbox.SelectedIndex = 0;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(productname_txt.Text) || string.IsNullOrEmpty(price_txt.Text))
            {
                warning_lable.Visible = true;
            }
            else
            {
                if (string.IsNullOrEmpty(barcode_txt.Text))
                    barcode_txt.Text = "0";
                if (hasqte_combo.SelectedIndex == 0)
                {
                    quantity_txt.Text = "0";
                    using (var cnx = new MiniGramDBDataContext(Properties.Settings.Default.ConnectionString))
                    {
                        try
                        {
                            int sid = cnx.sp_getSIDBySNAME(supp_cbox.SelectedText).ToList()[0].SID;
                            cnx.sp_addNewProduct(productname_txt.Text,barcode_txt.Text, Int32.Parse(quantity_txt.Text), float.Parse(price_txt.Text), false,sid);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Something Went Wrong, The New Product Not Added, Please Call The Support!!");
                            this.Close();
                        }
                        MessageBox.Show("New Product Added Successfully.");
                        this.Close();
                    }
                }
                else if(hasqte_combo.SelectedIndex == 1)
                {
                    if(string.IsNullOrEmpty(quantity_txt.Text))
                        warning_lable.Visible=true;
                    else
                    {
                        using (var cnx = new MiniGramDBDataContext(Properties.Settings.Default.ConnectionString))
                        {
                            try
                            {
                                int sid = cnx.sp_getSIDBySNAME(supp_cbox.SelectedText).ToList()[0].SID;
                                cnx.sp_addNewProduct(productname_txt.Text, barcode_txt.Text, Int32.Parse(quantity_txt.Text), float.Parse(price_txt.Text), true,sid);
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Something Went Wrong, The New Product Not Added, Please Call The Support!!");
                                this.Close();
                            }
                            MessageBox.Show("New Product Added Successfully.");
                            this.Close();
                        }
                    }
                }
            }
        }

        private void quantity_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = false;
            }
        }

        private void price_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = false;
            }
        }

        private void hasqte_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (hasqte_combo.SelectedIndex == 1)
            {
                label3.Enabled = true;
                quantity_txt.Enabled = true;
            }
            else if (hasqte_combo.SelectedIndex == 0)
            {
                label3.Enabled = false;
                quantity_txt.Enabled = false;
            }
        }

        private void barcode_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = false;
            }
        }

        private void keyboard_btn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = ((Environment.GetFolderPath(Environment.SpecialFolder.System) + @"\osk.exe"));
            Process process = new Process();
            process.StartInfo = ps;
            process.Start();
            ActiveControl = productname_txt;
        }
    }
}
