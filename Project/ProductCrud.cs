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
    public partial class ProductCrud : Form
    {
        ProductsService productsService;
        CategoriesService categoriesService;
        public ProductCrud()
        {
            InitializeComponent();
            productsService = new ProductsService();
            categoriesService = new CategoriesService();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            DataTable Products = productsService.GetProducts();

            DataTable Categories = categoriesService.GetCategories();

            dgv_products.DataSource = Products;
            cb_categories.DataSource = Categories;
            cb_categories.DisplayMember = "Category_Name";
            cb_categories.ValueMember = "Category_Id";

            btn_add.Enabled = true;
            btn_delete.Enabled = false;
            btn_update.Enabled = false;

            nud_id.Enabled = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string product_name = txt_productName.Text;
            int price = (int)nud_price.Value;
            int category_id = (int)cb_categories.SelectedValue;

            int rowsAffected = productsService.AddProducts(product_name, price, category_id);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Data Insrted");
                DataTable dt = productsService.GetProducts();
                dgv_products.DataSource = dt;
            }
        }
        private void dgv_products_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btn_add.Enabled = false;
            btn_delete.Enabled = true;
            btn_update.Enabled = true;

            DataGridViewRow row = dgv_products.SelectedRows[0];
            txt_productName.Text = row.Cells["Product_Name"].Value.ToString();

            string categoryName = row.Cells["Category_Name"].Value.ToString();
            int index = cb_categories.FindStringExact(categoryName);
            if (index >= 0)
            {
                cb_categories.SelectedIndex = index;
            }

            nud_id.Value = (int)row.Cells["Product_Id"].Value;
            nud_price.Value = (int)row.Cells["Price"].Value;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int RowsAffected = productsService.UpdateProducts((int)nud_id.Value, txt_productName.Text, (int)nud_price.Value, (int)cb_categories.SelectedValue);
            if (RowsAffected > 0)
            {
                MessageBox.Show("Data Updated");
                DataTable dt = productsService.GetProducts();
                dgv_products.DataSource = dt;
                btn_add.Enabled = true;
                btn_delete.Enabled = false;
                btn_update.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int RowsAffected = productsService.DeleteProducts((int)nud_id.Value);
            {
                MessageBox.Show("Data Deleted");
                DataTable dt = productsService.GetProducts();
                dgv_products.DataSource = dt;
                btn_add.Enabled = true;
                btn_delete.Enabled = false;
                btn_update.Enabled = false;
            }
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            categoryPage form4 = new categoryPage();
            form4.Show();
            this.Close();
        }

        private void dgv_products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
