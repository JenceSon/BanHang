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
    public partial class Finance : UserControl
    {
        public Finance()
        {
            InitializeComponent();
        }

        public void LoadFinance()
        {
            this.ListProductRevenue.Rows.Clear();

            SqlConnection conn = new SqlConnection(ConnectDB.connString);
            SqlCommand cmd = new SqlCommand(@"Select * from dbo.sum_revenue(@shopID,@startDate,@endDate)", conn);
            cmd.Parameters.AddWithValue("@shopID", SellerMainPage.shop.Shop_id);

            cmd.Parameters.AddWithValue("@startDate", StartdatePicker.Text);
            cmd.Parameters.AddWithValue("@endDate", EnddatePicker.Text);

            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            double total = 0;

            foreach (DataRow dr in dt.Rows)
            {
                this.ListProductRevenue.Rows.Add(dr["product_id"], dr["name"], dr["total_revenue"]);
                total += Convert.ToDouble(dr["total_revenue"]);
            }
            this.TotalRevenue.Text = total.ToString();

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            LoadFinance();
        }
    }
}
