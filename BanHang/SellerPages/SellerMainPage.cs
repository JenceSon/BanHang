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
    public partial class SellerMainPage : Form
    {
        public static Shop shop;
        public static List<Product> Products;
        public SellerMainPage(string shop_id)
        {
            InitializeComponent();

            #region create shop
            SqlConnection conn = new SqlConnection(ConnectDB.connString);
            SqlCommand cmd = new SqlCommand(@"select * from Shop where shop_id = @shop_id", conn);

            cmd.Parameters.AddWithValue("@shop_id", shop_id);

            conn.Open();

            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);


            conn.Close();

            foreach (DataRow dr in dt.Rows)
            {
                shop = new Shop(
                    Convert.ToString(dr["shop_id"]));
            }
            this.Text = "Hello " + shop.Name;
            this.shopInformation.LoadShopInfo();
            #endregion


            #region load products of shop
            Products = new List<Product>();
            this.listProducts.CreateProducts();
            this.listProducts.LoadProducts();
            #endregion


            #region load finance
            this.finance.LoadFinance();
            #endregion

        }
        #region event
        private void LogoButton_MouseEnter(object sender, EventArgs e)
        {

        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            LoginSeller.Instance.Show();
            this.Close();
        }

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            listProducts.Visible = true;
            finance.Visible = false;
            shopInformation.Visible = false;
            listProducts.BringToFront();
        }

        private void FinanceButton_Click(object sender, EventArgs e)
        {
            listProducts.Visible = false;
            finance.Visible = true;
            shopInformation.Visible = false;
            finance.BringToFront();
        }

        private void OverviewButton_Click(object sender, EventArgs e)
        {
            listProducts.Visible = false;
            finance.Visible = false;
            shopInformation.Visible = true;
            shopInformation.BringToFront();
        }
        #endregion

        #region method
        public void RefreshShopInfo()
        {
            this.Text = "Hello " + shop.Name;
            this.shopInformation.LoadShopInfo();
        }

        #endregion
    }
}
