using BanHang.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanHang.SellerPages
{
    public partial class ProductInformation : Form
    {
        public ProductInformation()
        {
            InitializeComponent();
            LoadProducts(SellerMainPage.Products);
        }
        public Image Resize(Image image, int w, int h)
        {
            Bitmap bmp = new Bitmap(w, h);
            Graphics g = Graphics.FromImage(bmp);
            g.DrawImage(image, 0, 0, w, h);
            g.Dispose();
            return bmp;
        }
        private void LoadProducts(List<Product> products)
        {
            this.ProductsTable.Rows.Clear();
            if (products != null)
            {
                string currentDir = System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
                IEnumerator<Product> it = SellerMainPage.Products.GetEnumerator();
                while (it.MoveNext())
                {
                    Product product = it.Current;
                    string fileName = product.Img;
                    string pathImg = currentDir + "\\IMG\\Product_n_variant\\" + fileName;
                    if ((fileName != "" && fileName != null) && File.Exists(pathImg))
                    {
                        Image img = Image.FromFile(pathImg);
                        img = Resize(img, 250, 300);
                        ProductsTable.Rows.Add(
                        img,
                        product.Product_id,
                        product.Name,
                        product.MinPrice,
                        product.MaxPrice,
                        product.Des,
                        product.NoSales,
                        product.TotalRemaining,
                        product.OnSales,
                        product.CatName
                        );
                    }
                    else ProductsTable.Rows.Add(
                        null,
                        product.Product_id,
                        product.Name,
                        product.MinPrice,
                        product.MaxPrice,
                        product.Des,
                        product.NoSales,
                        product.TotalRemaining,
                        product.OnSales,
                        product.CatName
                        );
                }
            }
        }
        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            AddProduct form = new AddProduct();
            form.ShowDialog();
        }

        private void ModifyBtn_Click(object sender, EventArgs e)
        {
            string productID = ProductsTable.CurrentRow.Cells["IDCol"].Value.ToString();
            ModifyProduct form = new ModifyProduct(productID);
            form.ShowDialog();
        }

        private void SeeVariantBtn_Click(object sender, EventArgs e)
        {
            Variant form = new Variant();
            form.ShowDialog();
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this product ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            int rowIdx = ProductsTable.CurrentCell.RowIndex;
            string productID = ProductsTable.CurrentRow.Cells["IDCol"].Value.ToString();

            SqlConnection conn = new SqlConnection(ConnectDB.connString);
            SqlCommand cmd = new SqlCommand("dbo.delete_product", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@product_id", productID);

            conn.Open();
            string res = cmd.ExecuteScalar().ToString();
            conn.Close();

            if (res == "Successfully deleting")
            {
                ProductsTable.Rows.RemoveAt(rowIdx);
                MessageBox.Show("Successfully delete", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //update list prodcut
                SellerMainPage.Products.RemoveAll(x => x.Product_id == productID);
            }
            else
            {
                MessageBox.Show(res, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshPB_Click(object sender, EventArgs e)
        {
            this.LoadProducts(SellerMainPage.Products);
        }

        private void FilterPB_Click(object sender, EventArgs e)
        {
            this.filterControl.Visible = true;
            this.filterControl.Enabled = true;
        }
    }
}
