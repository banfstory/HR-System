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
    public partial class Login : UserControl
    {
        Form1 main;
        public Login()
        {
            InitializeComponent();
            pass.PasswordChar = '*';
        }

        public void getMain(Form1 m)
        {
            main = m;
        }

        private void log_Click(object sender, EventArgs e)
        {
            if (user.Text.Trim() != "" && pass.Text.Trim() != "")
            {
                HashAlgorithm alg = MD5.Create();
                byte[] h = alg.ComputeHash(Encoding.UTF8.GetBytes(pass.Text));
                string hashpass = BitConverter.ToString(h).Replace("-", "");
                string connectionString = Form1.connectDB;
                string query = "SELECT * FROM admin WHERE admin_username = @user AND admin_password = @pass";              
                MySqlConnection dbconn = new MySqlConnection(connectionString);
                dbconn.Open();
                MySqlCommand data = new MySqlCommand(query, dbconn);
                data.Parameters.AddWithValue("@user", user.Text);
                data.Parameters.AddWithValue("@pass", hashpass);
                MySqlDataReader reader = data.ExecuteReader();
                if (reader.Read())
                {
                    dbconn.Close();
                    dbconn.Open();
                    string qid = "SELECT * FROM admin WHERE admin_username = @user";
                    data = new MySqlCommand(qid, dbconn);
                    data.Parameters.AddWithValue("@user", user.Text);
                    reader = data.ExecuteReader();
                    while (reader.Read())
                    {
                        main.id = reader[0].ToString().Trim();
                        main.name = reader[1].ToString().Trim();
                        main.user = reader[2].ToString().Trim();
                    }
                    ResetDetails();
                    main.signin();                               
                    dbconn.Close();
                }
                else
                {
                    user.Focus();
                    MessageBox.Show("Invalid username and password, please try again!");
                    dbconn.Close();
                }
            }
            else
            {
                user.Focus();
                MessageBox.Show("The username or password is empty, please try again!");
            }
        }

        private void ResetDetails()
        {
            user.Text = "";
            pass.Text = "";
        }

        private void regis_Click(object sender, EventArgs e)
        {
            main.Login.Hide();
            main.Register.Show();
            ResetDetails();
            main.Height = 550;
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
                log_Click(sender, e);
            }
        }
    }
}
