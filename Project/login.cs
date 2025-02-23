using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using project.Bussiness;
using System.Data;
using System.Diagnostics;

namespace Project
{
    public partial class login : Form
    {
        UsersService usersService;
        public static int userId;
        public static string _userName;
        public login()
        {
            InitializeComponent();
            usersService = new UsersService();
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_email.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Email shouldn't be null");
            }
            else if (txt_password.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Password shouldn't be null");
            }
            else
            {
                DataTable login = usersService.LoginVaild(txt_email.Text, txt_password.Text);

                if (login.Rows.Count > 0)
                {
                    userId = (int)login.Rows[0]["User_Id"];
                    _userName = login.Rows[0]["User_Name"].ToString();
                    string role = login.Rows[0]["Role"].ToString();
                    if (role == "Admin")
                    {
                        categoryPage form4 = new categoryPage();
                        form4.Show();
                        this.Close();
                    }
                    else if (role == "User")
                    {
                        favPage form7 = new favPage();
                        form7.Show();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("user or password is incorrect");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_login.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(txt_password.PasswordChar == '*')
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
    }
}
