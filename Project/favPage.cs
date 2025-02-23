using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using project.Bussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class favPage : Form
    {
        ProductsService productsService;
        FavoritesService favoritesService;

        public static int productId;
        public string productName;
        public favPage()
        {
            InitializeComponent();
            productsService = new ProductsService();
            favoritesService = new FavoritesService();
        }

        private void dgv_products_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dgv_products.SelectedRows[0];

            //productName = row.Cells["Product_Name"].Value.ToString();
            txt_product.Text = row.Cells["Product_Name"].Value.ToString();

            DataTable favProducts = productsService.GetFavProducts(txt_product.Text);
            productId = (int)favProducts.Rows[0]["Product_Id"];
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            DataTable favorites = favoritesService.GetFavorites(login.userId);

            dgv_Favourites.DataSource = favorites;

            DataTable products = productsService.GetProducts();
            dgv_products.DataSource = products;

            btn_delete.Enabled = false;
            l_hey.Text = $"Welcome : {login._userName.ToUpper()}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int RowsAffected = favoritesService.AddToFavorites(login.userId, productId);

            if (RowsAffected > 0)
            {
                MessageBox.Show("Added to favorites");
                DataTable favorites = favoritesService.GetFavorites(login.userId);
                dgv_Favourites.DataSource = favorites;
            }
            else
            {
                MessageBox.Show("Already in your favorites");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            login form1 = new login();
            form1.Show();
            this.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int rowsAffected = favoritesService.DeletefromFavorites(login.userId, productName);
            if (rowsAffected > 0)
            {
                MessageBox.Show("Product Deleted");
                DataTable dt = favoritesService.GetFavorites(login.userId);
                dgv_Favourites.DataSource = dt;

                btn_delete.Enabled = false;
            }
        }
        private void dgv_Favourites_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dgv_Favourites.SelectedRows[0];
            productName = row.Cells["Product_Name"].Value.ToString();

            btn_delete.Enabled = true;
        }
    }
}

