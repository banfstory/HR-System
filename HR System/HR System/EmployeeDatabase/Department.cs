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
    public partial class Department : UserControl
    {
        string connectionString;
        public Department()
        {
            InitializeComponent();
            depid.Enabled = false;
        }

        public void DisplayDepartment()
        {
            connectionString = Form1.connectDB;
            ClearDepartment();
            MySqlConnection dbconn = new MySqlConnection(connectionString);
            string query = "SELECT * FROM department ORDER BY dep_name";
            dbconn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, dbconn);
            DataTable data = new DataTable();
            adapter.Fill(data);
            Departments.DisplayMember = "dep_name";
            Departments.ValueMember = "dep_id";
            Departments.DataSource = data;    
            dbconn.Close();
        }

        private void Departments_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = Departments.SelectedValue.ToString();
            MySqlConnection dbconn = new MySqlConnection(connectionString);
            string query = "SELECT * FROM employees WHERE dep_id=@id ORDER BY emp_name";
            dbconn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, dbconn);
            adapter.SelectCommand.Parameters.AddWithValue("@id", id);
            DataTable data = new DataTable();
            adapter.Fill(data);
            Employee.DisplayMember = "emp_name";
            Employee.ValueMember = "emp_id";
            Employee.DataSource = data;
            dbconn.Close();

            query = "SELECT * FROM department WHERE dep_id=@id";
            dbconn.Open();
            MySqlCommand d = new MySqlCommand(query, dbconn);
            d.Parameters.AddWithValue("@id", Departments.SelectedValue);
            MySqlDataReader reader = d.ExecuteReader();
            if (reader.Read())
            {
                depid.Text = reader[0].ToString().Trim();
                depname.Text = reader[1].ToString().Trim();
                deploc.Text = reader[2].ToString().Trim();
            }
            dbconn.Close();
            EmployeeTable();
        }

        private void filterdep_TextChanged(object sender, EventArgs e)
        {
            DepartmentTable();
            EmployeeTable();
        }

        private void filteremp_TextChanged(object sender, EventArgs e)
        {
            EmployeeTable();
        }

        private void DepartmentTable()
        {
            MySqlConnection dbconn = new MySqlConnection(connectionString);
            string query = "SELECT * FROM department WHERE dep_name LIKE @name ORDER BY dep_name";
            dbconn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, dbconn);
            DataTable data = new DataTable();
            adapter.SelectCommand.Parameters.AddWithValue("@name", filterdep.Text + "%");
            Departments.DisplayMember = "dep_name";
            Departments.ValueMember = "dep_id";
            adapter.Fill(data);
            Departments.DataSource = data;
            dbconn.Clone();
        }

        private void EmployeeTable()
        {
            if (Departments.Items.Count != 0)
            {
                MySqlConnection dbconn = new MySqlConnection(connectionString);
                string query = "SELECT * FROM employees WHERE dep_id=@id AND emp_name LIKE @emp ORDER BY emp_name";               
                dbconn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, dbconn);
                DataTable data = new DataTable();
                adapter.SelectCommand.Parameters.AddWithValue("@id", Departments.SelectedValue);
                adapter.SelectCommand.Parameters.AddWithValue("@emp", filteremp.Text + "%");
                Employee.DisplayMember = "emp_name";
                Employee.ValueMember = "emp_id";
                adapter.Fill(data);
                Employee.DataSource = data;
                dbconn.Clone();
            }
            else
            {
                Employee.DataSource = null;
            }
        }

        private void Change_Click(object sender, EventArgs e)
        {
            if (depid.Text != "1")
            {
                MySqlConnection dbconn = new MySqlConnection(connectionString);
                string query = "UPDATE department SET dep_name=@name, dep_location=@loc WHERE dep_id=@id";
                dbconn.Open();
                MySqlCommand data = new MySqlCommand(query, dbconn);
                data.Parameters.AddWithValue("@id", depid.Text);
                data.Parameters.AddWithValue("@name", depname.Text.ToUpper());
                data.Parameters.AddWithValue("@loc", deploc.Text.ToUpper());
                data.ExecuteNonQuery();
                dbconn.Close();
                DisplayDepartment();
                depname.Focus();
                MessageBox.Show("Department details has been changed!");
            }
            else
            {
                MessageBox.Show("You are not allowed to make changes to this department!");
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            MySqlConnection dbconn = new MySqlConnection(connectionString);
            string query = "INSERT INTO department (dep_name, dep_location) VALUES (@name, @loc)";
            dbconn.Open();
            MySqlCommand data = new MySqlCommand(query, dbconn);
            data.Parameters.AddWithValue("@name", addname.Text.ToUpper());
            data.Parameters.AddWithValue("@loc", addloc.Text.ToUpper());
            data.ExecuteNonQuery();
            dbconn.Close();
            addname.Text = "";
            addloc.Text = "";
            DisplayDepartment();
            addname.Focus();
            ClearDepartment();
            MessageBox.Show("Department has been added!");
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (depid.Text != "1")
            {
                Confirm c = new Confirm();
                DialogResult show = c.ShowDialog();
                if (c.ConfirmDelete())
                {
                    MySqlConnection dbconn = new MySqlConnection(connectionString);
                    string query = "UPDATE employees SET dep_id=1 WHERE dep_id=@id";
                    dbconn.Open();
                    MySqlCommand data = new MySqlCommand(query, dbconn);
                    data.Parameters.AddWithValue("@id", depid.Text);
                    data.ExecuteNonQuery();
                    dbconn.Close();

                    query = "DELETE FROM department WHERE dep_id=@id";
                    dbconn.Open();
                    data = new MySqlCommand(query, dbconn);
                    data.Parameters.AddWithValue("@id", depid.Text);
                    data.ExecuteNonQuery();
                    dbconn.Close();
                    DisplayDepartment();
                    depname.Focus();
                    MessageBox.Show("Department has been deleted!");
                }
            }
            else
            {
                MessageBox.Show("You are not allowed to remove this department!");
            }
            ClearDepartment();
        }

        private void ClearDepartment()
        {
            addname.Text = "";
            addloc.Text = "";
            filterdep.Text = "";
            filteremp.Text = "";
        }

        private void depname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                deploc.Focus();
            }
        }

        private void deploc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                Change_Click(sender, e);
            }
        }

        private void addname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                addloc.Focus();
            }
        }

        private void addloc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                Add_Click(sender, e);
            }
        }
    }
}
