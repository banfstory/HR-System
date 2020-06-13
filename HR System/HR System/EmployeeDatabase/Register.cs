using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace EmployeeDatabase
{
    public partial class Register : UserControl
    {
        Form1 main;
        public Register()
        {
            InitializeComponent();
            pass.PasswordChar = '*';
            cpass.PasswordChar = '*';
        }

        public void getMain(Form1 m)
        {
            main = m;
        }

        private void regis_Click(object sender, EventArgs e)
        {
            if (user.Text.Trim() != "" && pass.Text.Trim() != "" && cpass.Text.Trim() != "" && fullname.Text.Trim() != "" && pass.Text.Trim() == cpass.Text.Trim()) 
            {
                string connectionString = Form1.connectDB;
                string query = "SELECT * FROM admin WHERE admin_username = @user";
                MySqlConnection dbconn = new MySqlConnection(connectionString);
                dbconn.Open();
                MySqlCommand data = new MySqlCommand(query, dbconn);
                data.Parameters.AddWithValue("@user", user.Text);
                MySqlDataReader reader = data.ExecuteReader();
                if (reader.Read())
                {
                    user.Focus();
                    MessageBox.Show("This user already exist, please try again!");
                    dbconn.Close();
                }
                else
                {
                    dbconn.Close();
                    dbconn.Open();
                    HashAlgorithm alg = MD5.Create();
                    byte[] h = alg.ComputeHash(Encoding.UTF8.GetBytes(pass.Text));
                    string hashpass = BitConverter.ToString(h).Replace("-", "");
                    string adduser = "INSERT INTO admin (admin_fullname, admin_username, admin_password) VALUES (@name,@user,@pass)";
                    data = new MySqlCommand(adduser, dbconn);
                    data.Parameters.AddWithValue("@user", user.Text);
                    data.Parameters.AddWithValue("@pass", hashpass);
                    data.Parameters.AddWithValue("@name", fullname.Text);
                    data.ExecuteNonQuery();
                    main.Register.Hide();
                    main.Login.Show();
                    main.Height = 500;
                    MessageBox.Show("You have successfully registered!");
                    ResetDetails();
                    dbconn.Close();
                }
            }
            else
            {
                user.Focus();
                MessageBox.Show("One or more of the field(s) is empty or passwords do not match, please try again!");
            }
        }

        public void ResetDetails()
        {
            user.Text = "";
            pass.Text = "";
            cpass.Text = "";
            fullname.Text = "";
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            ResetDetails();
            main.Register.Hide();
            main.Login.Show();
            main.Height = 500;
        }

        private void user_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                pass.Focus();
            }
        }

        private void pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                cpass.Focus();
            }
        }

        private void cpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                fullname.Focus();
            }
        }

        private void fullname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                regis_Click(sender, e);
            }
        }
    }
}
