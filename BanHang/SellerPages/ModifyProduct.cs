using BanHang.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanHang.SellerPages
{
    public partial class ModifyProduct : Form
    {
        private string productIDtmp = "";
        private string pathImg = "";
        public ModifyProduct(string productId)
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

            LoadProductInfo(productId);
            productIDtmp = productId;
        }
        private void LoadProductInfo(string productId)
        {
            Product tmp = SellerMainPage.Products.Find(x => x.Product_id == productId);
            if (tmp != null)
            {
                this.ProductNameTextBox.Text = tmp.Name;
                this.CategoryComboBox.Text = tmp.CatName;
                this.PidTextBox.Text = tmp.Product_id;
                this.DescriptionTextBox.Text = tmp.Des;
                this.MinPriceTextBox.Text = tmp.MinPrice.ToString();
                this.MaxPriceTextBox.Text = tmp.MaxPrice.ToString();
                this.OnSaleLabel.Text = tmp.OnSales.ToString();
                this.TotalRemainTextBox.Text = tmp.TotalRemaining.ToString();

                string imgName = tmp.Img;
                string pathImg = System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName
                    + "\\IMG\\Product_n_variant\\" + imgName;

                if (File.Exists(pathImg))
                {
                    Image img = Image.FromFile(pathImg);
                    ImgNameLabel.Text = imgName;
                    ImagePB.Image = img;
                }

            }

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            LoadProductInfo(productIDtmp);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (
                ProductNameTextBox.Text == "" ||
                PidTextBox.Text == "" ||
                MinPriceTextBox.Text == "" ||
                MaxPriceTextBox.Text == "" ||
                TotalRemainTextBox.Text == ""
              )
            {
                MessageBox.Show("Please fill in complete product information | ", "Add product failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            SqlConnection conn = new SqlConnection(ConnectDB.connString);
            SqlCommand cmd = new SqlCommand("dbo.update_product", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@pid_current", productIDtmp);
            cmd.Parameters.AddWithValue("@pid_new", PidTextBox.Text);
            cmd.Parameters.AddWithValue("@des", (DescriptionTextBox.Text == "" ? DBNull.Value : DescriptionTextBox.Text));
            cmd.Parameters.AddWithValue("@name", ProductNameTextBox.Text);
            cmd.Parameters.AddWithValue("@total_remaining", Convert.ToInt32(TotalRemainTextBox.Text));
            cmd.Parameters.AddWithValue("@min_price", Convert.ToDouble(MinPriceTextBox.Text));
            cmd.Parameters.AddWithValue("@max_price", Convert.ToDouble(MaxPriceTextBox.Text));
            cmd.Parameters.AddWithValue("@cat", (CategoryComboBox.Text == "" ? DBNull.Value : CategoryComboBox.SelectedValue.ToString()));
            cmd.Parameters.AddWithValue("@sid", SellerMainPage.shop.Shop_id);
            cmd.Parameters.AddWithValue("@img", (ImgNameLabel.Text == "not found" ? DBNull.Value : ImgNameLabel.Text));

            conn.Open();
            string res = cmd.ExecuteScalar().ToString();
            conn.Close();

            if (res == "Successfully updating")
            {
                MessageBox.Show(res, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //copy img to repo
                if (ImgNameLabel.Text != "not found") //has image
                {
                    string des = System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName
                    + "\\IMG\\Product_n_variant\\"
                    + ImgNameLabel.Text;
                    if (!File.Exists(des)) //not existed yet
                    {
                        File.Copy(pathImg, des, true);
                    }


                }
                //update list product
                SellerMainPage.Products.RemoveAll(x=> x.Product_id == productIDtmp);
                SellerMainPage.Products.Add(new Product(PidTextBox.Text));
                productIDtmp = PidTextBox.Text;
            }
            else
            {
                string[] listError = res.Split('_');
                int i = 0;
                res = "";
                while (i < listError.Count())
                {
                    res += (listError[i] + "\n");
                    i++;
                }
                MessageBox.Show(res, "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void AddImgBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "IMG (*.jpg, *.png)|*.jpg;*.png";
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ImagePB.Image = new Bitmap(ofd.FileName);
                ImgNameLabel.Text = ofd.SafeFileName;
                pathImg = ofd.FileName;
            }
            else
            {
                pathImg = "";
            }

        }

        private void PriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.') && (e.KeyChar != '-'))
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
            PidTextBox.Text = getNewPID();
        }
    }
}
