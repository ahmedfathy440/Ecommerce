using Microsoft.IdentityModel.Tokens;
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
    public partial class userPage : Form
    {
        UsersService usersService;
        public userPage()
        {
            InitializeComponent();
            usersService = new UsersService();
        }


        private void Form5_Load(object sender, EventArgs e)
        {
            DataTable Users = usersService.GetUsers();

            dgv_users.DataSource = Users;
            cb_role.SelectedIndex = 0;
        }
        int selectedId;
        private void dgv_users_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btn_add.Enabled = false;
            btn_update.Enabled = true;
            btn_delete.Enabled = true;

            DataGridViewRow row = dgv_users.SelectedRows[0];

            selectedId = Convert.ToInt32(row.Cells["user_Id"].Value);

            txt_email.Text = row.Cells["Email"].Value.ToString();
            txt_address.Text = row.Cells["Address"].Value.ToString();
            txt_name.Text = row.Cells["User_Name"].Value.ToString();
            txt_password.Text = row.Cells["Password"].Value.ToString();
            nud_age.Value = (int)row.Cells["Age"].Value;
            string role = row.Cells["role"].Value.ToString();
            int index = cb_role.FindStringExact(role);
            if (index >= 0)
            {
                cb_role.SelectedIndex = index;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_name.Text.IsNullOrEmpty())
            {
                MessageBox.Show("You should enter your Name");
            }
            else if (txt_email.Text.IsNullOrEmpty())
            {
                MessageBox.Show("You should enter your email");
            }
            else if (txt_password.Text.IsNullOrEmpty())
            {
                MessageBox.Show("You should enter your Password");
            }
            else
            {
                int rowsAffected = usersService.AddUsers(txt_name.Text, txt_password.Text, txt_email.Text, (int)nud_age.Value, txt_address.Text, cb_role.Text);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("User Added Successfully");
                    DataTable Users = usersService.GetUsers();
                    dgv_users.DataSource = Users;
                }
            }
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            int RowsAffected = usersService.UpdateUsers(selectedId, txt_name.Text, txt_password.Text, txt_email.Text, (int)nud_age.Value, txt_address.Text, cb_role.Text);
            if (RowsAffected > 0)
            {
                MessageBox.Show("User Updated");
                DataTable dt = usersService.GetUsers();
                dgv_users.DataSource = dt;
                btn_add.Enabled = true;
                btn_delete.Enabled = false;
                btn_update.Enabled = false;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int RowsAffected = usersService.DeleteUsers(selectedId);
            if (RowsAffected > 0)
            {
                MessageBox.Show("User Deleted");
                DataTable dt = usersService.GetUsers();
                dgv_users.DataSource = dt;
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
    }
}
