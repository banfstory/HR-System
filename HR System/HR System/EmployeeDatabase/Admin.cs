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
    public partial class Admin : UserControl
    {
        Form1 main;
        string connectionString;
        public Admin()
        {
            InitializeComponent();
            oldpass.PasswordChar = '*';
            npass.PasswordChar = '*';
            cnpass.PasswordChar = '*';
            adminid.Enabled = false;
        }

        public void DisplayAdmin(string id, Form1 m)
        {
            main = m;
            connectionString = Form1.connectDB;
            MySqlConnection dbconn = new MySqlConnection(connectionString);
            string query = "SELECT * FROM admin WHERE admin_id=@id";
            dbconn.Open();
            MySqlCommand data = new MySqlCommand(query, dbconn);
            data.Parameters.AddWithValue("@id", id);
            MySqlDataReader reader = data.ExecuteReader();
            if (reader.Read())
            {
                adminid.Text = reader[0].ToString().Trim();
                aname.Text = reader[1].ToString().Trim();
                auser.Text = reader[2].ToString().Trim();
            }
            ClearPassFields();
            dbconn.Close();
        }

        private void changedetails_Click(object sender, EventArgs e)
        {
            MySqlConnection dbconn = new MySqlConnection(connectionString);
            string query = "SELECT * FROM admin WHERE admin_username=@user";
            dbconn.Open();
            MySqlCommand data = new MySqlCommand(query, dbconn);
            data.Parameters.AddWithValue("@user", auser.Text);
            MySqlDataReader reader = data.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Username is already taken, please choose another");
            }
            else
            {
                dbconn.Close();
                query = "UPDATE admin SET admin_username=@user WHERE admin_id=@id";
                dbconn.Open();
                data = new MySqlCommand(query, dbconn);
                data.Parameters.AddWithValue("@id", adminid.Text);
                data.Parameters.AddWithValue("@user", auser.Text);
                data.ExecuteNonQuery();               
                MessageBox.Show("Admin username has been changed!");
            }
            dbconn.Close();
            auser.Focus();
        }

        private void changepass_Click(object sender, EventArgs e)
        {
            if (npass.Text == cnpass.Text)
            {
                HashAlgorithm alg = MD5.Create();
                byte[] h = alg.ComputeHash(Encoding.UTF8.GetBytes(oldpass.Text));
                string hashpass = BitConverter.ToString(h).Replace("-", "");
                MySqlConnection dbconn = new MySqlConnection(connectionString);
                string query = "SELECT * FROM admin WHERE admin_id=@id AND admin_password=@pass";
                dbconn.Open();
                MySqlCommand data = new MySqlCommand(query, dbconn);
                data.Parameters.AddWithValue("@id", adminid.Text);
                data.Parameters.AddWithValue("@pass", hashpass);
                MySqlDataReader reader = data.ExecuteReader();
                if (reader.Read())
                {
                    dbconn.Close();
                    h = alg.ComputeHash(Encoding.UTF8.GetBytes(npass.Text));
                    hashpass = BitConverter.ToString(h).Replace("-", "");
                    query = "UPDATE admin SET admin_password=@pass WHERE admin_id=@id";
                    dbconn.Open();
                    data = new MySqlCommand(query, dbconn);
                    data.Parameters.AddWithValue("@id", adminid.Text);
                    data.Parameters.AddWithValue("@pass", hashpass);
                    data.ExecuteNonQuery();
                    ClearPassFields();
                    MessageBox.Show("Password successful changed!");
                    dbconn.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect current password!");
                    dbconn.Close();
                }               
            }
            else
            {
                MessageBox.Show("New passwords do not match!");
            }
            oldpass.Focus();
        }

        private void changename_Click(object sender, EventArgs e)
        {
            MySqlConnection dbconn = new MySqlConnection(connectionString);
            string query = "UPDATE admin SET admin_fullname=@name WHERE admin_id=@id";
            dbconn.Open();
            MySqlCommand data = new MySqlCommand(query, dbconn);
            data.Parameters.AddWithValue("@id", adminid.Text);
            data.Parameters.AddWithValue("@name", aname.Text);
            data.ExecuteNonQuery();
            main.adminn.Text = aname.Text;
            MessageBox.Show("Name has been changed!");
            dbconn.Close();
            aname.Focus();
        }

        private void ClearPassFields()
        {
            oldpass.Text = "";
            npass.Text = "";
            cnpass.Text = "";
        }

        private void aname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                changename_Click(sender, e);
            }
        }

        private void auser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                changedetails_Click(sender, e);
            }
        }

        private void oldpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                npass.Focus();
            }
        }

        private void npass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                cnpass.Focus();
            }
        }

        private void cnpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                changepass_Click(sender, e);
            }
        }
    }
}
