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
        private string name, des, img, catid;
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
                img = (string)cmd.ExecuteScalar();
                conn.Close();

                return img;
            }
        }
        public string CatId
        {
            get
            {
                SqlConnection conn = new SqlConnection(ConnectDB.connString);
                SqlCommand cmd = new SqlCommand(@"Select category_id from Product where product_id = @product_id", conn);
                cmd.Parameters.AddWithValue("@product_id", this.product_id);

                conn.Open();
                catid = (string)cmd.ExecuteScalar();
                conn.Close();

                return catid;
            }
        }
        public string CatName
        {
            get
            {
                SqlConnection conn = new SqlConnection(ConnectDB.connString);
                SqlCommand cmd = new SqlCommand(@"Select category_name from Category where catgory_id = @category_id", conn);
                cmd.Parameters.AddWithValue("@category_id", this.catid);

                conn.Open();
                string catname = (string)cmd.ExecuteScalar();
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
                SqlCommand cmd = new SqlCommand(
                    @"select count(*) as num
                    from Product_instance
                    where product_id = @product_id and instance_id not in 
                    (select instance_id from Is_contained)", conn);
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
