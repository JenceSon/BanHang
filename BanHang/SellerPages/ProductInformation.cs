using BanHang.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        public Image Resize(Image image,int w,int h)
        {
            Bitmap bmp = new Bitmap(w,h);
            Graphics g = Graphics.FromImage(bmp);
            g.DrawImage(image,0,0,w,h);
            g.Dispose();
            return bmp;
        }
        private void LoadProducts(List<Product> products)
        {
            if (products != null)
            {
                string currentDir = System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
                IEnumerator<Product> it = SellerMainPage.Products.GetEnumerator();
                while (it.MoveNext())
                {
                    Product product = it.Current;
                    string fileName = product.Img;
                    string pathImg = currentDir + "\\IMG\\Product_n_variant\\" + fileName;
                    if ((fileName != "" || fileName != null) && File.Exists(pathImg))
                    {
                        Image img = Image.FromFile(pathImg);
                        img = Resize(img, 300, 300);
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
            ModifyProduct form = new ModifyProduct();
            form.ShowDialog();
        }

        private void SeeVariantBtn_Click(object sender, EventArgs e)
        {
            Variant form = new Variant();
            form.ShowDialog();
        }
    }
}
