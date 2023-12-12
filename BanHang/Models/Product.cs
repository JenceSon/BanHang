using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanHang.Models
{
    public class Product
    {
        private string product_id;
        public string Product_id { get => product_id; set => product_id = value; }
        private string name, des, img;
        private int totalRemaining, noSales, onSales;
        private double minPrice, maxPrice;

        public string Name
        {
            get
            {
                SqlConnection conn = new SqlConnection(ConnectDB.connString);
                SqlCommand cmd = new SqlCommand(@"Select [name] from Product where product_id = @product_id", conn);
                cmd.Parameters.AddWithValue("@product_id", this.product_id);

                conn.Open();
                name = (string)cmd.ExecuteScalar();
                conn.Close();

                return name;
            }
        }
        public string Des
        {
            get
            {
                SqlConnection conn = new SqlConnection(ConnectDB.connString);
                SqlCommand cmd = new SqlCommand(@"Select [description] from Product where product_id = @product_id", conn);
                cmd.Parameters.AddWithValue("@product_id", this.product_id);

                conn.Open();
                des = (string)cmd.ExecuteScalar();
                conn.Close();

                return des;
            }
        }
        public string Img
        {
            get
            {
                SqlConnection conn = new SqlConnection(ConnectDB.connString);
                SqlCommand cmd = new SqlCommand(@"Select img from Product where product_id = @product_id", conn);
                cmd.Parameters.AddWithValue("@product_id", this.product_id);

                conn.Open();
                img = cmd.ExecuteScalar().ToString();
                conn.Close();
                if (img == "") return "NULL.png";
                return img;
            }
        }
        public string CatName
        {
            get
            {
                SqlConnection conn = new SqlConnection(ConnectDB.connString);
                SqlCommand cmd = new SqlCommand(@"Select c.category_name from Category c, Product p where c.category_id = p.category_id and p.product_id = @product_id", conn);
                cmd.Parameters.AddWithValue("@product_id",this.product_id);

                conn.Open();
                object value = cmd.ExecuteScalar();
                if(value == null)
                {
                    conn.Close() ;
                    return "";
                }
                string catname = value.ToString();
                conn.Close();
                return catname;
            }
        }
        public int TotalRemaining
        {
            get
            {
                SqlConnection conn = new SqlConnection(ConnectDB.connString);
                SqlCommand cmd = new SqlCommand(@"Select total_remaining from Product where product_id = @product_id", conn);
                cmd.Parameters.AddWithValue("@product_id", this.product_id);

                conn.Open();
                totalRemaining = (int)cmd.ExecuteScalar();
                conn.Close();

                return totalRemaining;
            }
        }
        public int NoSales
        {
            get
            {
                SqlConnection conn = new SqlConnection(ConnectDB.connString);
                SqlCommand cmd = new SqlCommand(@"Select no_sales from Product where product_id = @product_id", conn);
                cmd.Parameters.AddWithValue("@product_id", this.product_id);

                conn.Open();
                noSales = (int)cmd.ExecuteScalar();
                conn.Close();

                return noSales;
            }
        }
        public double MinPrice
        {
            get
            {
                SqlConnection conn = new SqlConnection(ConnectDB.connString);
                SqlCommand cmd = new SqlCommand(@"Select minimum_price from Product where product_id = @product_id", conn);
                cmd.Parameters.AddWithValue("@product_id", this.product_id);

                conn.Open();
                minPrice = Convert.ToDouble(cmd.ExecuteScalar());
                conn.Close();

                return minPrice;
            }
        }
        public double MaxPrice
        {
            get
            {
                SqlConnection conn = new SqlConnection(ConnectDB.connString);
                SqlCommand cmd = new SqlCommand(@"Select maximum_price from Product where product_id = @product_id", conn);
                cmd.Parameters.AddWithValue("@product_id", this.product_id);

                conn.Open();
                maxPrice = Convert.ToDouble(cmd.ExecuteScalar());
                conn.Close();

                return maxPrice;
            }
        }
        public int OnSales
        {
            get
            {
                SqlConnection conn = new SqlConnection(ConnectDB.connString);
                SqlCommand cmd = new SqlCommand(@"select dbo.no_instance_on_sale(@product_id) as num", conn);
                cmd.Parameters.AddWithValue("@product_id", this.product_id);

                conn.Open();
                onSales = (int)cmd.ExecuteScalar();
                conn.Close();

                return onSales;
            }
        }
        public Product(string product_id)
        {
            this.product_id = product_id;
        }
    }
}
