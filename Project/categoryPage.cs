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
    public partial class categoryPage : Form
    {
        CategoriesService categoriesService;
        public categoryPage()
        {
            InitializeComponent();
            categoriesService = new CategoriesService();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ProductCrud form3 = new ProductCrud();
            form3.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            userPage form5 = new userPage();
            form5.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            DataTable Categories = categoriesService.GetCategories();

            dgv_categories.DataSource = Categories;
            btn_add.Enabled = true;
            btn_delete.Enabled = false;
            btn_update.Enabled = false;
            l_hey.Text = $"Welcome : {login._userName.ToUpper()}";
        }

        private void dgv_categories_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btn_add.Enabled = false;
            btn_delete.Enabled = true;
            btn_update.Enabled = true;

            DataGridViewRow row = dgv_categories.SelectedRows[0];

            txt_name.Text = row.Cells["Category_Name"].Value.ToString();
            nud_id.Value = (int)row.Cells["Category_id"].Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rowsAffected = categoriesService.AddCategories(txt_name.Text);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Data Insrted");
                DataTable dt = categoriesService.GetCategories();
                dgv_categories.DataSource = dt;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int rowsAffected = categoriesService.UpdateCategories((int)nud_id.Value, txt_name.Text);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Data Updated");
                DataTable dt = categoriesService.GetCategories();
                dgv_categories.DataSource = dt;
                btn_add.Enabled = true;
                btn_delete.Enabled = false;
                btn_update.Enabled = false;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int rowsAffected = categoriesService.DeleteCategories((int)nud_id.Value);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Data Deleted");
                DataTable dt = categoriesService.GetCategories();
                dgv_categories.DataSource = dt;
                btn_add.Enabled = true;
                btn_delete.Enabled = false;
                btn_update.Enabled = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            login form1 = new login();
            form1.Show();
            this.Close();

        }
    }
}
