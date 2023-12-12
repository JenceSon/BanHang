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
    public partial class Filter : UserControl
    {
        public Filter()
        {
            InitializeComponent();
            #region get list of category
            SqlConnection conn = new SqlConnection(ConnectDB.connString);
            SqlCommand cmd = new SqlCommand("Select * from Category where category_name != 'ALL CATEGORIES'", conn);

            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Close();

            CategoryComboBox.DataSource = ds.Tables[0];
            CategoryComboBox.DisplayMember = "category_name";
            CategoryComboBox.ValueMember = "category_id";
            CategoryComboBox.Text = "";
            #endregion
        }
        public double MinPrice { get => (MinPriceTxt.Text == ""? -1: Convert.ToDouble(MinPriceTxt.Text)); }
        public double MaxPrice { get =>(MaxPriceTxt.Text == ""? -1 : Convert.ToDouble(MaxPriceTxt.Text)); }
        public int MinRemain { get =>(TotalRemainFromTxt.Text ==""? -1 : Convert.ToInt32(TotalRemainFromTxt.Text)); }
        public int MaxRemain { get =>(TotalRemainToTxt.Text == ""? -1 : Convert.ToInt32(TotalRemainToTxt.Text)); }
        public int MinNoSales { get=>(NoSalesFromTxt.Text == ""? -1: Convert.ToInt32(NoSalesFromTxt.Text));}
        public int MaxNoSales { get=>(NoSalesToTxt.Text == ""? -1 : Convert.ToInt32(NoSalesToTxt.Text));}
        public int MinOnSale { get=>(OnSaleFromTxt.Text == ""? -1 : Convert.ToInt32(OnSaleFromTxt.Text));}
        public int MaxOnSale { get=>(OnSalesToTxt.Text == ""? -1 : Convert.ToInt32(OnSalesToTxt.Text));}
        public string CatID { get => (CategoryComboBox.Text == "" ? "" : CategoryComboBox.SelectedValue.ToString()); }

        private void Int_KeyPress(object sender, KeyPressEventArgs e) 
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void Double_KeyPress(object sender, KeyPressEventArgs e)
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
