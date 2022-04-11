using MiniGram.Classes;
using MiniGram.Forms;
using MiniGram.LINQ;
using Syncfusion.WinForms.Controls;
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
    public partial class POSUC : UserControl
    {
        private MiniGramDBDataContext data = new MiniGramDBDataContext();
        private TableLayoutPanel table;
        private int NewReceiptNumber;
        private string selectedProductName = "";
        public POSUC()
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

        private void checkout_btn_Click(object sender, EventArgs e)
        {

        }

        private void POSUC_Load(object sender, EventArgs e)
        {
            try
            {
                NewReceiptNumber = Int32.Parse(data.sp_getLastReceiptID().ToList()[0].MAX_RID.ToString());
            }catch(Exception ex)
            {
                NewReceiptNumber = 1;
            }
            receipt_id.Text = NewReceiptNumber.ToString();
            ActiveControl = search_txt;
        }

        public void refreshData(string str)
        {
            products_panel.Controls.Clear();
            table =new TableLayoutPanel();
            products_panel.Controls.Add(table);
            table.Dock = DockStyle.Fill;
            table.ColumnCount = 3;
            table.RowCount = (Int32.Parse(data.sp_getProductsCount(str).ToList()[0].Product_Number.ToString()) / table.ColumnCount) + 1;
            int i = 0,j = 0,c = 0,p = Int32.Parse(data.sp_getProductsCount(str).ToList()[0].Product_Number.ToString());
            while(i < table.RowCount)
            {
                while(j < table.ColumnCount)
                {
                    if (c < p)
                    {
                        SfButton button = new SfButton();
                        button.AccessibleName = "Button";
                        button.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
                        button.BackgroundImageLayout = ImageLayout.Zoom;
                        button.CanOverrideStyle = true;
                        button.Cursor = Cursors.Hand;
                        button.FlatStyle = FlatStyle.Flat;
                        button.Font = new Font("Bookman Old Style", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        button.ForeColor = Color.White;
                        button.Name = "product" + i.ToString() + j.ToString();
                        button.Size = new Size(300, 75);
                        button.Style.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
                        button.Style.FocusedBackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
                        button.Style.FocusedForeColor = Color.White;
                        button.Style.ForeColor = Color.White;
                        button.Style.HoverBackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
                        button.Style.HoverForeColor = Color.White;
                        button.Style.HoverImageForeColor = Color.Empty;
                        button.Style.PressedBackColor = Color.White;
                        button.Style.PressedForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
                        button.TextImageRelation = TextImageRelation.Overlay;
                        button.TextMargin = new Padding(0, 10, 0, 0);
                        button.ThemeName = "Office2016Colorful";
                        button.Margin = new Padding(25, 25,25,25);
                        toolTip1.SetToolTip(button, data.sp_select_products(str).ToList()[c].ProductName);
                        button.UseVisualStyleBackColor = false;
                        button.Text = data.sp_select_products(str).ToList()[c].ProductName;
                        button.TextAlign = ContentAlignment.MiddleCenter;
                        button.Click += new EventHandler(add_btn_Click);
                        table.Controls.Add(button, j, i);
                    }
                    c++;
                    j++;
                }
                i++;
                j = 0;
            }
            ActiveControl = search_txt;
        }
        private string getTotalDollar()
        {
            double totalDollar = 0;
            foreach(DataGridViewRow row in receipt_details.Rows)
            {
                totalDollar += double.Parse(row.Cells[6].Value.ToString());
            }
            return totalDollar.ToString();
        }
        private string getTotalLBP()
        {
            int totalLBP = 0;
            foreach (DataGridViewRow row in receipt_details.Rows)
            {
                totalLBP += Int32.Parse(row.Cells[5].Value.ToString());
            }
            return totalLBP.ToString();
        }
        private string getTotalQTE()
        {
            int QTE = 0;
            foreach (DataGridViewRow row in receipt_details.Rows)
            {
                QTE += Int32.Parse(row.Cells[2].Value.ToString());
            }
            return QTE.ToString();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            string pname = (sender as SfButton).Text;
            int pid = data.sp_getProductByName(pname).ToList()[0].PID;
            double dollar = data.sp_getProductByName(pname).ToList()[0].PRICE.Value;
            string barcode = data.sp_getProductByName(pname).ToList()[0].BARCODE;
            int lbp = Convert.ToInt32(dollar) * Properties.Settings.Default.dollarLBPPrice;
            bool exist = false;
            foreach(DataGridViewRow row in receipt_details.Rows)
            {
                if (row.Cells[1].Value.Equals(pname))
                {
                    exist = true;
                    row.Cells[2].Value = Int32.Parse(row.Cells[2].Value.ToString()) + 1;
                    row.Cells[5].Value = Int32.Parse(row.Cells[2].Value.ToString()) * lbp;
                    row.Cells[6].Value = double.Parse(row.Cells[2].Value.ToString()) *dollar;
                    tot_quantity.Text = getTotalQTE();
                    tot_dollar.Text = getTotalDollar() + " $";
                    tot_lbp.Text = getTotalLBP() + " LBP";
                    break;
                }
            }
            if (!exist)
            {
                receipt_details.Rows.Add(barcode,pname, 1, dollar, lbp, lbp, dollar);
                tot_quantity.Text = getTotalQTE();
                tot_dollar.Text = getTotalDollar() + " $";
                tot_lbp.Text = getTotalLBP() + " LBP";
            }
            ActiveControl = search_txt;
        }

        private void change_quantity_btn_Click(object sender, EventArgs e)
        {
            double dollar = double.Parse(receipt_details.SelectedRows[0].Cells[3].Value.ToString());
            int lbp = Convert.ToInt32(dollar) * Properties.Settings.Default.dollarLBPPrice;
            Globals.deleteNB = 0;
            ChangeQuantityForm cqf = new ChangeQuantityForm(Int32.Parse(receipt_details.SelectedRows[0].Cells[2].Value.ToString()));
            cqf.ShowDialog();
            if (Globals.deleteNB > 0)
            {
                receipt_details.SelectedRows[0].Cells[2].Value = Globals.deleteNB;
                receipt_details.SelectedRows[0].Cells[5].Value = Globals.deleteNB * lbp;
                receipt_details.SelectedRows[0].Cells[6].Value = double.Parse(Globals.deleteNB.ToString()) * dollar;
                tot_quantity.Text = getTotalQTE();
                tot_dollar.Text = getTotalDollar() + " $";
                tot_lbp.Text = getTotalLBP() + " LBP";
            }
            ActiveControl = search_txt;
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            Globals.deleteNB = 0;
            DeleteForm df = new DeleteForm(Int32.Parse(receipt_details.SelectedRows[0].Cells[2].Value.ToString()));
            df.ShowDialog();
            if (Globals.deleteNB != 0)
            {
                if (Globals.deleteNB == Int32.Parse(receipt_details.SelectedRows[0].Cells[2].Value.ToString()))
                    receipt_details.Rows.RemoveAt(receipt_details.SelectedRows[0].Index);
                else
                {
                    receipt_details.SelectedRows[0].Cells[2].Value = (Int32.Parse(receipt_details.SelectedRows[0].Cells[2].Value.ToString()) - Globals.deleteNB).ToString();
                    receipt_details.SelectedRows[0].Cells[6].Value = (double.Parse(receipt_details.SelectedRows[0].Cells[2].Value.ToString()) * double.Parse(receipt_details.SelectedRows[0].Cells[3].Value.ToString())).ToString();
                    receipt_details.SelectedRows[0].Cells[5].Value = (Int32.Parse(receipt_details.SelectedRows[0].Cells[2].Value.ToString()) * Int32.Parse(receipt_details.SelectedRows[0].Cells[4].Value.ToString())).ToString();
                }
                tot_quantity.Text = getTotalQTE();
                tot_dollar.Text = getTotalDollar() + " $";
                tot_lbp.Text = getTotalLBP() + " LBP";
            }
            ActiveControl = search_txt;
        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            refreshData(search_txt.Text);
        }
    }
}
