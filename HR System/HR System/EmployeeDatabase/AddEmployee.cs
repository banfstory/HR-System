using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace EmployeeDatabase
{
    public partial class AddEmployee : Form
    {
        Employee main;
        string connectionString;

        public AddEmployee(Employee m)
        {
            InitializeComponent();
            main = m;
            connectionString = Form1.connectDB;
            manid.Enabled = false;
            manjob.Enabled = false;
            depid.Enabled = false;
            deploc.Enabled = false;
            ManagerComboBox();
            DepartmentComboBox();
        }

        public void ManagerComboBox()
        {
            MySqlConnection dbconn = new MySqlConnection(connectionString);
            string query = "SELECT * FROM employees";
            dbconn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, dbconn);
            DataTable data = new DataTable();
            adapter.Fill(data);
            manname.DisplayMember = "emp_name";
            manname.ValueMember = "emp_id";
            manname.DataSource = data;
            // This row will be added in the current datatable
            DataRow dr = data.NewRow(); 
            dr["emp_name"] = "NONE";
            dr["emp_id"] = -1;
            data.Rows.InsertAt(dr, 0); // Insert row into datatable which interms update the combobox datasource 
            manname.SelectedIndex = 0;          
            dbconn.Close();           
        }

        public void DepartmentComboBox()
        {
            MySqlConnection dbconn = new MySqlConnection(connectionString);
            string query = "SELECT * FROM department";
            dbconn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, dbconn);
            DataTable data = new DataTable();
            adapter.Fill(data);
            depname.DisplayMember = "dep_name";
            depname.ValueMember = "dep_id";
            depname.DataSource = data;
            dbconn.Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string mangid;
            if ((int)manname.SelectedValue != -1)
            {
                mangid = manid.Text;
            }
            else
            {
                mangid = "NULL";
            }
            MySqlConnection dbconn = new MySqlConnection(connectionString);
            string query = "INSERT INTO employees (emp_name,job_name,manager_id,hire_date,salary,commision,dep_id) VALUES(@empname,@empjob,@manid,@hire,@salary,@comm,@depid)";
            dbconn.Open();
            MySqlCommand data = new MySqlCommand(query, dbconn);
            data.Parameters.AddWithValue("@empname", empname.Text.ToUpper());
            data.Parameters.AddWithValue("@empjob", empjob.Text.ToUpper());
            if (mangid != "NULL")
            {
                data.Parameters.AddWithValue("@manid", mangid);
            }
            else
            {
                data.Parameters.AddWithValue("@manid", DBNull.Value); 
            }
            data.Parameters.AddWithValue("@hire", emphire.Text);
            data.Parameters.AddWithValue("@salary", empsalary.Text);
            data.Parameters.AddWithValue("@comm", empcommis.Text);
            data.Parameters.AddWithValue("@depid", depid.Text);
            data.ExecuteNonQuery();
            dbconn.Close();
            this.Close();
            main.DisplayEmployee();
            MessageBox.Show("Employee has been added!");
        }

        private void Cacnel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void empname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                empjob.Focus();
            }
        }

        private void empjob_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                empsalary.Focus();
            }
        }

        private void empsalary_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                empcommis.Focus();
            }
        }

        private void empcommis_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                emphire.Focus();
            }
        }

        private void emphire_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                Add_Click(sender, e);
            }
        }

        private void manname_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((int)manname.SelectedValue != -1)
            {
                MySqlConnection dbconn = new MySqlConnection(connectionString);
                string query = "SELECT emp_id, job_name FROM employees WHERE emp_id=@id";
                dbconn.Open();
                MySqlCommand data = new MySqlCommand(query, dbconn);
                data.Parameters.AddWithValue("@id", manname.SelectedValue);
                MySqlDataReader reader = data.ExecuteReader();
                if (reader.Read())
                {
                    manid.Text = reader[0].ToString().Trim();
                    manjob.Text = reader[1].ToString().Trim();
                }
                dbconn.Close();
            }
            else
            {
                manid.Text = "";
                manjob.Text = "";
            }
        }

        private void depname_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection dbconn = new MySqlConnection(connectionString);
            string query = "SELECT dep_id, dep_location FROM department WHERE dep_id=@id";
            dbconn.Open();
            MySqlCommand data = new MySqlCommand(query, dbconn);
            data.Parameters.AddWithValue("@id", depname.SelectedValue);
            MySqlDataReader reader = data.ExecuteReader();
            if (reader.Read())
            {
                depid.Text = reader[0].ToString().Trim();
                deploc.Text = reader[1].ToString().Trim();
            }
            dbconn.Close();
        }

        private void NumOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (Char.IsDigit(c) == false && c != 8 && c != 46) // Only digits, backspace and delete are allowed to be used (backspace and delete is represented in ASCII)
            {
                e.Handled = true; // Cancel the event when set to true            
            }
        }
    }
}
