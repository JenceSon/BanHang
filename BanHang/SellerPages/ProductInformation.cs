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
            LoadProducts();
        }
        private void LoadProducts(List<Product> products = null)
        {
            if (products == null)
            {
                IEnumerator<Product> it = SellerMainPage.Products.GetEnumerator();
                while (it.MoveNext())
                {
                    Product product = it.Current;
                    ProductsTable.Rows.Add(
                        product.Img,
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
