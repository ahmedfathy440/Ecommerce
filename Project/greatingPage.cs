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
    public partial class greatingPage : Form
    {
        public greatingPage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            register form2 = new register();
            form2.Show();
            //this.Hide();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            login form1 = new login();
            form1.Show();
            //this.Hide();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            btn_login.BackColor = Color.Transparent;
            btn_register.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            p_exit.BackColor = Color.Transparent;
        }

        private void p_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
