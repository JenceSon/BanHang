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
    public partial class AddInstance : Form
    {
        string productID = "";
        public AddInstance(string productID)
        {
            InitializeComponent();
            this.productID = productID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product tmp = SellerMainPage.Products.Find(x => x.Product_id == this.productID);

            if (tmp == null) return;
            SqlConnection conn = new SqlConnection(ConnectDB.connString);
            SqlCommand cmd = new SqlCommand("dbo.add_instance", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@product_id", this.productID);
            cmd.Parameters.AddWithValue("@no_add", this.numericUpDown1.Value);
            cmd.Parameters.AddWithValue("@price",Convert.ToInt32( this.PriceTxt.Text));

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            this.Close();

        }

        private void PriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
