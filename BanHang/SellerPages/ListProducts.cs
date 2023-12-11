using BanHang.Models;
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

namespace BanHang.SellerPages
{
    public partial class ListProducts : UserControl
    {
        public ListProducts()
        {
            InitializeComponent();
            ProductTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void SeeMoreBtn_Click(object sender, EventArgs e)
        {
            ProductInformation form = new ProductInformation();
            form.ShowDialog();
        }

        public void CreateProducts()
        {
            SellerMainPage.Products.Clear(); //must clear before regenerate list of products

            SqlConnection conn = new SqlConnection(ConnectDB.connString);
            SqlCommand cmd = new SqlCommand(@"Select * from [Product] where shop_id = @sid", conn);
            cmd.Parameters.AddWithValue("@sid", SellerMainPage.shop.Shop_id);

            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            foreach (DataRow dr in dt.Rows)
            {
                SellerMainPage.Products.Add(new Product(dr["product_id"].ToString()));
            }

        }
        public void LoadProducts()
        {
            this.ProductTable.Rows.Clear();
            IEnumerator<Product> it = SellerMainPage.Products.GetEnumerator();
            while (it.MoveNext())
            {
                Product product = it.Current;
                ProductTable.Rows.Add(product.Product_id, product.Name, product.TotalRemaining, product.OnSales, product.MinPrice, product.MaxPrice);
            }
        }
    }
}
