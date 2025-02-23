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
    public partial class register : Form
    {
        UsersService usersService;
        public register()
        {
            InitializeComponent();
            usersService = new UsersService();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {

            if (txt_username.Text.IsNullOrEmpty())
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
                int rowsAffected = usersService.AddUsers(txt_username.Text, txt_password.Text, txt_email.Text, (int)nud_age.Value, txt_address.Text, cb_role.Text);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Resgistered Successfull");
                    login form1 = new login();
                    form1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("email or password is already used");
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cb_role.SelectedIndex = 0;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (txt_password.PasswordChar == '*')
            {
                txt_password.PasswordChar = '\0';
                checkBox1.Text = "Hide Password";
            }
            else
            {
                txt_password.PasswordChar = '*';
                checkBox1.Text = "Show Password";
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
