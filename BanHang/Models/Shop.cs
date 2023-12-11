using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanHang.Models
{
    public class Shop
    {
        private string shop_id, bio, urlLink, name, date_joined;
        private int no_following, no_follower, no_product;
        private double rating;
        public string Shop_id { get => shop_id; set => shop_id = value; }
        public string Bio
        {
            get
            {
                SqlConnection conn = new SqlConnection(ConnectDB.connString);
                SqlCommand cmd = new SqlCommand(@"Select bio from Shop where shop_id = @shop_id", conn);
                cmd.Parameters.AddWithValue("@shop_id", this.shop_id);

                conn.Open();
                bio = (string)cmd.ExecuteScalar();
                conn.Close();

                return bio;
            }
        }

        public string UrlLink
        {
            get
            {
                SqlConnection conn = new SqlConnection(ConnectDB.connString);
                SqlCommand cmd = new SqlCommand(@"Select url_link from Shop where shop_id = @shop_id", conn);
                cmd.Parameters.AddWithValue("@shop_id", this.shop_id);

                conn.Open();
                urlLink = (string)cmd.ExecuteScalar();
                conn.Close();

                return urlLink;
            }
        }

        public string Name
        {
            get
            {
                SqlConnection conn = new SqlConnection(ConnectDB.connString);
                SqlCommand cmd = new SqlCommand(@"Select [name] from Shop where shop_id = @shop_id", conn);
                cmd.Parameters.AddWithValue("@shop_id", this.shop_id);

                conn.Open();
                name = (string)cmd.ExecuteScalar();
                conn.Close();

                return name;
            }
        }

        public string DateJoined
        {
            get
            {
                SqlConnection conn = new SqlConnection(ConnectDB.connString);
                SqlCommand cmd = new SqlCommand(@"Select date_joined from Shop where shop_id = @shop_id", conn);
                cmd.Parameters.AddWithValue("@shop_id", this.shop_id);

                conn.Open();
                date_joined = Convert.ToString(cmd.ExecuteScalar());
                date_joined = Convert.ToDateTime(date_joined).Date.ToString("yyyy-MM-dd");
                conn.Close();

                return date_joined;
            }
        }

        public int No_following
        {
            get
            {
                SqlConnection conn = new SqlConnection(ConnectDB.connString);
                SqlCommand cmd = new SqlCommand(@"Select no_following from Shop where shop_id = @shop_id", conn);
                cmd.Parameters.AddWithValue("@shop_id", this.shop_id);

                conn.Open();
                no_following = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();

                return no_following;
            }
        }

        public int No_folower
        {
            get
            {
                SqlConnection conn = new SqlConnection(ConnectDB.connString);
                SqlCommand cmd = new SqlCommand(@"Select no_follower from Shop where shop_id = @shop_id", conn);
                cmd.Parameters.AddWithValue("@shop_id", this.shop_id);

                conn.Open();
                no_follower = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();

                return no_follower;
            }
        }

        public int No_product
        {
            get
            {
                SqlConnection conn = new SqlConnection(ConnectDB.connString);
                SqlCommand cmd = new SqlCommand(@"Select no_product from Shop where shop_id = @shop_id", conn);
                cmd.Parameters.AddWithValue("@shop_id", this.shop_id);

                conn.Open();
                no_product = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();

                return no_product;
            }
        }


        public double Rating
        {
            get
            {
                SqlConnection conn = new SqlConnection(ConnectDB.connString);
                SqlCommand cmd = new SqlCommand(@"Select rating from Shop where shop_id = @shop_id", conn);
                cmd.Parameters.AddWithValue("@shop_id", this.shop_id);

                conn.Open();
                rating = Convert.ToDouble(cmd.ExecuteScalar());
                conn.Close();

                return rating;
            }
        }

        public Shop(string shop_id)
        {
            this.shop_id = shop_id;
        }
    }
}
