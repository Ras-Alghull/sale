using IT4solutionsPointOfSalesSoftware.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace IT4solutionsPointOfSalesSoftware.Screens.SalesF
{
    public partial class SaleInvoice : MetroFramework.Forms.MetroForm
    {
        public SaleInvoice()
        {
            InitializeComponent();
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void SaleInvoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iT4SolutionsPosDataSet1.SalesOrder' table. You can move, or remove it, as needed.
           // this.salesOrderTableAdapter.Fill(this.iT4SolutionsPosDataSet1.SalesOrder);
            UsernameTextBx.Text = LoggedInUser.UserName;
            DateTextBox.Text = DateTime.Now.ToString("dd-mmmm-yyyy h:mm:ss tt");
        }

        private void SearchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                String input = SearchTextBox.Text.ToString().Trim();
                if (input.Length == 0)
                {
                    return;
                }
                else
                {
                    using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionString()))
                        con.Open();


                    if (Regex.IsMatch(input, "^[0-9]+$"))

                    {
                          int ninput;
                          bool result = int.TryParse(input, out ninput);
                          if (result)
                          {
                              

                           using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionString()))
                              {
                                  SqlCommand cmd;
                                  String query = "SELECT * FROM Product WHERE Barcode LIKE +'%'+ @barcode +'%'";
                                      cmd = new SqlCommand(query, con);
                                      cmd.Parameters.Add(new SqlParameter ("@barcode", ninput + "%"));
                                      con.Open();
                                      SqlDataAdapter da = new SqlDataAdapter(cmd);
                                      DataTable dt = new DataTable();
                                      da.Fill(dt);

                                      if (dt.Rows.Count == 0)
                                      {
                                          MessageBox.Show("Product Not Found" );
                                          SearchTextBox.Clear();
                                          QuantityTextBox.Text = "1";
                                          ProductNameTextBox.Clear();
                                          PriceTextBox.Clear();
                                          StockTextBox.Clear();
                                          TotalTextBox.Clear();
                                          SearchTextBox.Focus();
                                      }
                                      else if (dt.Rows.Count == 1)
                                      {
                                          ProductNameTextBox.Text = dt.Rows[0]["Name"].ToString();
                                          PriceTextBox.Text = dt.Rows[0]["SalePrice"].ToString();
                                          StockTextBox.Text = dt.Rows[0]["stock"].ToString();
                                          PIDTextBox.Text = dt.Rows[0]["ProductID"].ToString();
                                          QuantityTextBox.Focus();

                                      }
                                  }
                             

                              }
                          }
                        

                  
                }
            }
        }
        

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QuantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
          if (e.KeyChar == (Char)Keys.Enter)
            {
                if (QuantityTextBox.Text.Length == 0)
             {
                     return;
             }
             else 
            {
               int qty = Convert.ToInt32(QuantityTextBox.Text);
               int stock = Convert.ToInt32(StockTextBox.Text);
               
               if(qty>stock)
              {
               MessageBox.Show("Out of stock"); 
              }
             else
             {
             int productID = Convert.ToInt32(PIDTextBox.Text);
             String name = ProductNameTextBox.Text;
             int price = Convert.ToInt32(PriceTextBox.Text);
             int amount = (qty * price);
             if (test())
             {
                 MessageBox.Show("Out of stock"); 
             }
             else
             {
                 SalesInvoiceGrid.Rows.Add(productID, name, price, qty, amount);
                 calculatebill();
                 SearchTextBox.Clear();
                 QuantityTextBox.Text = "1";
                 PIDTextBox.Clear();
                 ProductNameTextBox.Clear();
                 PriceTextBox.Clear();
                 StockTextBox.Clear();
                 SearchTextBox.Focus();
             }
           
            }
           }
           }
        }

      

        private bool test()
        {
            for (int i = 0; i < SalesInvoiceGrid.Rows.Count; i++)
            {
                int newstock = Convert.ToInt32(StockTextBox.Text) - Convert.ToInt32(SalesInvoiceGrid.Rows[i].Cells["Quantity"].Value) - Convert.ToInt32(QuantityTextBox.Text);
                int qty = Convert.ToInt32(StockTextBox.Text);

                if (newstock >qty )
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return true;

           
          
        }
private void calculatebill()
    {
     int totalbill = 0;
     for(int i = 0; i<SalesInvoiceGrid.Rows.Count; i++)
     {
        totalbill = totalbill + Convert.ToInt32(SalesInvoiceGrid.Rows[i].Cells["amount"].Value);
    }
        TotalTextBox.Text = totalbill.ToString();
        }

private void SalesInvoiceGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
{
    if (e.ColumnIndex == 3)
    {
        int qty = Convert.ToInt32(SalesInvoiceGrid.Rows[e.RowIndex].Cells["qty"].Value);
        int price = Convert.ToInt32(SalesInvoiceGrid.Rows[e.RowIndex].Cells["price"].Value);
        int amount = qty * price;
        SalesInvoiceGrid.Rows[e.RowIndex].Cells["amount"].Value = amount;
        calculatebill();
    }
}
Bitmap bmp;
private void SaleButton_Click(object sender, EventArgs e)
{
    int height = SalesInvoiceGrid.Height;
    SalesInvoiceGrid.Height = SalesInvoiceGrid.RowCount * SalesInvoiceGrid.RowTemplate.Height * 2;
    bmp = new Bitmap(SalesInvoiceGrid.Width, SalesInvoiceGrid.Height);
    SalesInvoiceGrid.DrawToBitmap(bmp, new Rectangle(0, 0, SalesInvoiceGrid.Width, SalesInvoiceGrid.Height));  //(bmp, new Rectangle(0, 0, SalesInvoiceGrid.Width, SalesInvoiceGrid.Height));
    SalesInvoiceGrid.Height = height;
    printPreviewDialog1.ShowDialog();
}

private void PrintReceipt_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
{
    e.Graphics.DrawImage(bmp, 0, 0);
}

private void ProductInfoGroup_Enter(object sender, EventArgs e)
{

}

private void UsernameTextBx_Click(object sender, EventArgs e)
{

}


        }

   

    }
