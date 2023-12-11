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
    public partial class AddProduct : Form
    {
        private string pathImg = "";
        public AddProduct()
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
            #endregion
            //auto generate PID
            PID.Text = getNewPID();


        }

        private string getNewPID()
        {
            string newPID = "";

            SqlConnection conn = new SqlConnection(ConnectDB.connString);
            SqlCommand cmd = new SqlCommand(@"Select dbo.generate_PID() as newPID", conn);

            conn.Open();
            newPID = cmd.ExecuteScalar().ToString();
            conn.Close();

            return newPID;
        }
        private void generateID_Click(object sender, EventArgs e)
        {
            PID.Text = getNewPID();

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ProductNameTextBox.Text = "";
            CategoryComboBox.Text = "";
            PID.Text = "";
            DescriptionTextBox.Text = "";
            PriceTextBox.Text = "0";
            AmountTextBox.Text = "0";
            ImgNameLabel.Text = "not found";
            ImgPictureBox.Image = null;
            this.pathImg = "";

        }
        private void PriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.')&&(e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void AmountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void AddImgBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "IMG (*.jpg, *.png)|*.jpg;*.png";
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ImgPictureBox.Image = new Bitmap(ofd.FileName);
                ImgNameLabel.Text = ofd.SafeFileName;
                pathImg = ofd.FileName;
            }
            else
            {
                pathImg = "";
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if
                (
                    ProductNameTextBox.Text == ""||
                    PID.Text == ""||
                    PriceTextBox.Text == ""||
                    AmountTextBox.Text == ""
                )
            {
                MessageBox.Show("Please fill in complete product information | ", "Add product failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlConnection conn = new SqlConnection(ConnectDB.connString);
            SqlCommand cmd = new SqlCommand("dbo.insert_product", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@product_id",PID.Text);
            cmd.Parameters.AddWithValue("@des",(DescriptionTextBox.Text == "" ? DBNull.Value : DescriptionTextBox.Text));
            cmd.Parameters.AddWithValue("@name",ProductNameTextBox.Text);
            cmd.Parameters.AddWithValue("@total_remaining", Convert.ToInt32(AmountTextBox.Text));
            cmd.Parameters.AddWithValue("@price",Convert.ToDecimal(PriceTextBox.Text));
            cmd.Parameters.AddWithValue("@cat",(CategoryComboBox.Text == ""? DBNull.Value : CategoryComboBox.SelectedValue.ToString()));
            cmd.Parameters.AddWithValue("@sid", SellerMainPage.shop.Shop_id);
            cmd.Parameters.AddWithValue("@img",(ImgNameLabel.Text == "not found" ? DBNull.Value : ImgNameLabel.Text));
            cmd.Parameters.AddWithValue("@result", "");

            conn.Open();
            string res = cmd.ExecuteScalar().ToString(); 
            conn.Close();

            if(res == "Successfully adding")
            {
                MessageBox.Show(res,"Notification",MessageBoxButtons.OK,MessageBoxIcon.Information);

                //copy img to repo
                if(ImgNameLabel.Text != "not found") //has image
                {
                    string des = System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName
                    + "\\IMG\\Product_n_variant\\"
                    + ImgNameLabel.Text;
                    if(!File.Exists(des)) //not existed yet
                    {
                        File.Copy(pathImg, des, true);
                    }
                    
                    
                }
                //update list product
                SellerMainPage.Products.Add(new Product(PID.Text));
            }
            else
            {
                string[] listError = res.Split('_');
                int i = 0;
                res = "";
                while(i < listError.Count())
                {
                    res += (listError[i] + "\n");
                    i++;
                }
                MessageBox.Show(res,"Fail",MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
