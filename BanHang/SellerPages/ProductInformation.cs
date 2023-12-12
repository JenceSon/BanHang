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
            this.CenterToScreen();

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
        private void LoadProducts(List<Product> productsTmp)
        {
            this.ProductsTable.Rows.Clear();
            if (productsTmp != null)
            {
                string currentDir = System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
                IEnumerator<Product> it = productsTmp.GetEnumerator();
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
            if(productID != "")
            {
                ModifyProduct form = new ModifyProduct(productID);
                form.ShowDialog();
            }    
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
            this.SearchBtn.Enabled = true;
            this.SearchBtn.Visible = true;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            List<Product> productsFilter = new List<Product>();

            SqlConnection conn = new SqlConnection(ConnectDB.connString);
            SqlCommand cmd = new SqlCommand("dbo.filter_product", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@total_remaining_min_filter", (this.filterControl.MinRemain));
            cmd.Parameters.AddWithValue("@total_remaining_max_filter", this.filterControl.MaxRemain);
            cmd.Parameters.AddWithValue("@no_sales_min_filter", this.filterControl.MinNoSales);
            cmd.Parameters.AddWithValue("@no_sales_max_filter", this.filterControl.MaxNoSales);
            cmd.Parameters.AddWithValue("@min_price_filter", this.filterControl.MinPrice);
            cmd.Parameters.AddWithValue("@max_price_filter", this.filterControl.MaxPrice);
            cmd.Parameters.AddWithValue("@cat_filter", this.filterControl.CatID);
            cmd.Parameters.AddWithValue("@sid_filter", SellerMainPage.shop.Shop_id);

            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            foreach(DataRow dr in dt.Rows)
            {
                Product tmp = SellerMainPage.Products.Find(x => x.Product_id == dr["product_id"].ToString());
                int onSales = tmp.OnSales;
                if(
                   (onSales >= this.filterControl.MinOnSale || this.filterControl.MaxOnSale == -1) &&
                   (onSales <= this.filterControl.MaxOnSale || this.filterControl.MinOnSale == -1) 
                   )
                {
                    productsFilter.Add(tmp);
                }    

            }
            LoadProducts(productsFilter);
            this.filterControl.Visible = false;
            this.filterControl.Enabled = false;
            this.SearchBtn.Visible = false;
            this.SearchBtn.Enabled = false;
        }
    }
}
