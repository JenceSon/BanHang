using BanHang.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanHang.SellerPages
{
    public partial class LoginSeller : Form
    {
        private static LoginSeller instance = null;
        public static LoginSeller Instance
        {
            get
            {
                if (instance == null) instance = new LoginSeller();
                return instance;
            }
        }
        public LoginSeller()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            /*
            //query
            SqlConnection conn = new SqlConnection(ConnectDB.connString);
            string query = @"select dbo.check_login_seller(@user_name,@email,@pwd)";
            SqlCommand cmd = new SqlCommand(query, conn);

            //pass para
            if (EmailTextBox.Text.Contains('@'))
            {
                cmd.Parameters.AddWithValue("@email", EmailTextBox.Text);
                cmd.Parameters.AddWithValue("@user_name", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@email", DBNull.Value);
                cmd.Parameters.AddWithValue("@user_name", EmailTextBox.Text);
            }
            cmd.Parameters.AddWithValue("@pwd", PasswordTextBox.Text);

            //open and exec
            conn.Open();
            string shop_id = (string)cmd.ExecuteScalar();
            conn.Close();

            if (shop_id == "Deny")
            {
                MessageBox.Show("Wrong information !!", "Deny login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SellerMainPage form = new SellerMainPage(shop_id);
                form.Show();
                this.Hide();

            }*/
            SellerMainPage form = new SellerMainPage("SID000001");
            form.Show();
            this.Hide();
        }

        private void EmailTextBox_Leave(object sender, EventArgs e)
        {
            if (EmailTextBox.Text == "")
            {
                EmailTextBox.Text = "Enter your email or username";
                EmailTextBox.ForeColor = Color.LightGray;
            }
        }

        private void PwdTextBox_Leave(Object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == "")
            {
                PasswordTextBox.PasswordChar = '\0';
                PasswordTextBox.Text = "Enter your password";
                PasswordTextBox.ForeColor = Color.LightGray;

            }

        }
        private void EmailTextBox_Enter(Object sender, EventArgs e)
        {
            if (EmailTextBox.Text == "Enter your email or username")
            {
                EmailTextBox.Text = "";
                EmailTextBox.ForeColor = Color.Black;
            }
        }

        private void PwdTextBox_Enter(Object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == "Enter your password")
            {
                PasswordTextBox.Text = "";
                PasswordTextBox.ForeColor = Color.Black;
                PasswordTextBox.PasswordChar = '*';
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
