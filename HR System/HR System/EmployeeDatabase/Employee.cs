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

namespace EmployeeDatabase
{
    public partial class Employee : UserControl
    {
        public string connectionString;

        public Employee()
        {
            InitializeComponent();
            empid.Enabled = false;
            empgrade.Enabled = false;
            manid.Enabled = false;
            depid.Enabled = false;
            manjob.Enabled = false;
            deploc.Enabled = false;
        }

        public void DisplayEmployee()
        {
            connectionString = Form1.connectDB;
            filteremp.Text = "";
            ManagerComboBox();
            DepartmentComboBox();
            MySqlConnection dbconn = new MySqlConnection(connectionString);
            string query = "SELECT * FROM employees ORDER BY emp_name";
            dbconn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, dbconn);
            DataTable data = new DataTable();
            Employees.DisplayMember = "emp_name";
            Employees.ValueMember = "emp_id";
            adapter.Fill(data);
            Employees.DataSource = data;
            dbconn.Close();
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

        private void Employees_SelectedIndexChanged(object sender, EventArgs e) 
        {
            MySqlConnection dbconn = new MySqlConnection(connectionString);
            string query = "SELECT e.emp_id, e.emp_name, e.job_name, ROUND(e.salary,0), ROUND(e.commision,0), g.grade, e.manager_id, d.dep_id FROM employees e, department d, salary_grade g WHERE e.dep_id=d.dep_id AND e.salary BETWEEN g.min_salary AND g.max_salary AND e.emp_id=@id";
            dbconn.Open();
            MySqlCommand data = new MySqlCommand(query, dbconn);
            data.Parameters.AddWithValue("@id", Employees.SelectedValue);
            MySqlDataReader reader = data.ExecuteReader();
            if (reader.Read())
            {
                empid.Text = reader[0].ToString().Trim();
                empname.Text = reader[1].ToString().Trim();
                empjob.Text = reader[2].ToString().Trim();
                empsalary.Text = reader[3].ToString().Trim();
                empcommis.Text = reader[4].ToString().Trim();
                empgrade.Text = reader[5].ToString().Trim();
                if (reader[6].ToString() != "")
                {
                    manname.SelectedValue = reader[6].ToString().Trim();
                }
                else
                {
                    manname.SelectedValue = -1; // Select the item that has id of -1
                }
                depname.SelectedValue = reader[7].ToString().Trim();
            }
            dbconn.Close();
        }

        private void filteremp_TextChanged(object sender, EventArgs e)
        {
            EmployeeTable();
        }

        private void EmployeeTable()
        {
            MySqlConnection dbconn = new MySqlConnection(connectionString);
            string query = "SELECT * FROM employees WHERE emp_name LIKE @emp ORDER BY emp_name";
            dbconn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, dbconn);
            adapter.SelectCommand.Parameters.AddWithValue("@emp", filteremp.Text + "%");
            DataTable data = new DataTable();
            adapter.Fill(data);
            Employees.DisplayMember = "emp_name";
            Employees.ValueMember = "emp_id";
            Employees.DataSource = data;
            dbconn.Close();
        }

        private void Change_Click(object sender, EventArgs e)
        {
            MySqlConnection dbconn = new MySqlConnection(connectionString);
            string query = "UPDATE employees SET emp_name=@name,job_name=@job,manager_id=@mang,salary=@salary,commision=@comm,dep_id=@dep WHERE emp_id=@id";
            dbconn.Open();
            MySqlCommand data = new MySqlCommand(query, dbconn);
            data.Parameters.AddWithValue("@id", empid.Text);
            data.Parameters.AddWithValue("@name", empname.Text.ToUpper());
            data.Parameters.AddWithValue("@job", empjob.Text.ToUpper());
            if ((int)manname.SelectedValue != -1)
            {
                data.Parameters.AddWithValue("@mang", manid.Text);
            }
            else
            {
                data.Parameters.AddWithValue("@mang", DBNull.Value); // Mangerid value will be set to null when database is updated
            }
            data.Parameters.AddWithValue("@salary", empsalary.Text);
            data.Parameters.AddWithValue("@comm", empcommis.Text);
            data.Parameters.AddWithValue("@dep", depid.Text);
            data.ExecuteNonQuery();
            dbconn.Close();
            DisplayEmployee();
            filteremp.Focus();
            filteremp.Text = "";
            MessageBox.Show("Employee details has been changed!");
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            Confirm c = new Confirm();
            DialogResult show = c.ShowDialog();
            if (c.ConfirmDelete())
            {
                MySqlConnection dbconn = new MySqlConnection(connectionString);
                string query = "UPDATE employees SET manager_id=NULL WHERE manager_id=@id";
                dbconn.Open();
                MySqlCommand data = new MySqlCommand(query, dbconn);
                data.Parameters.AddWithValue("@id", empid.Text);
                data.ExecuteNonQuery();
                dbconn.Close();

                query = "DELETE FROM employees WHERE emp_id=@id";
                dbconn.Open();
                data = new MySqlCommand(query, dbconn);
                data.Parameters.AddWithValue("@id", empid.Text);
                data.ExecuteNonQuery();
                dbconn.Close();
                DisplayEmployee();
                filteremp.Focus();
                MessageBox.Show("Employee has been deleted!");
            }
            filteremp.Text = "";
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
                Change_Click(sender, e);
            }
        }

        private void filteremp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                empname.Focus();
            }
        }

        private void addemp_Click(object sender, EventArgs e)
        {
            AddEmployee a = new AddEmployee(this);
            DialogResult d = a.ShowDialog();
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
