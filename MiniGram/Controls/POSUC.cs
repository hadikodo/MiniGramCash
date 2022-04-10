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
        private TableLayoutPanel table = new TableLayoutPanel();
        private int NewReceiptNumber;
        private string selectedProductName = "";
        public POSUC()
        {
            InitializeComponent();
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
            products_panel.Controls.Clear();
            products_panel.Controls.Add(table);
            table.Dock = DockStyle.Fill;
            table.ColumnCount = 3;
            table.RowCount= (Int32.Parse(data.sp_getProductsCount().ToList()[0].Product_Number.ToString())/table.ColumnCount)+1;
        }

        public void refreshData(string str)
        {
            int i = 0,j = 0,c = 0,p = Int32.Parse(data.sp_getProductsCount().ToList()[0].Product_Number.ToString());
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
                        button.Text = data.sp_select_products("").ToList()[c].ProductName;
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
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            string pname = (sender as SfButton).Text;
            int pid = data.sp_getProductByName(pname).ToList()[0].PID;
            double dollar = data.sp_getProductByName(pname).ToList()[0].PRICE.Value;
            int lbp = Convert.ToInt32(dollar) * Properties.Settings.Default.dollarLBPPrice;
            bool exist = false;
            foreach(DataGridViewRow row in receipt_details.Rows)
            {
                if (row.Cells[0].Value.Equals(pname))
                {
                    exist = true;
                    row.Cells[1].Value = Int32.Parse(row.Cells[1].Value.ToString()) + 1;
                    row.Cells[4].Value = Int32.Parse(row.Cells[1].Value.ToString()) * lbp;
                    row.Cells[5].Value = double.Parse(row.Cells[1].Value.ToString()) *dollar;
                    tot_quantity.Text = (Int32.Parse(tot_quantity.Text.ToString()) + 1).ToString();
                    tot_dollar.Text = (double.Parse(tot_dollar.Text.ToString().Split(' ')[0]) + dollar).ToString()+ " $";
                    tot_lbp.Text = (Int32.Parse(tot_lbp.Text.ToString().Split(' ')[0]) + lbp).ToString() + " LBP";
                    break;
                }
            }
            if (!exist)
            {
                receipt_details.Rows.Add(pname, 1, dollar, lbp, lbp, dollar);
                tot_quantity.Text = (Int32.Parse(tot_quantity.Text.ToString()) + 1).ToString();
                tot_dollar.Text = (double.Parse(tot_dollar.Text.ToString().Split(' ')[0]) + dollar).ToString() + " $";
                tot_lbp.Text = (Int32.Parse(tot_lbp.Text.ToString().Split(' ')[0]) + lbp).ToString() + " LBP";
            }
        }
    }
}
