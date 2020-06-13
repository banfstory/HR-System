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
    public partial class SalaryGrade : UserControl
    {
        string connectionString;
        public SalaryGrade()
        {
            InitializeComponent();
            egrade.Enabled = false;
        }

        public void DisplayGrade()
        {
            connectionString = Form1.connectDB;
            ClearSalary();
            MySqlConnection dbconn = new MySqlConnection(connectionString);
            string query = "SELECT * FROM salary_grade ORDER BY grade ASC";
            dbconn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, dbconn);
            DataTable data = new DataTable();
            adapter.Fill(data);
            Grade.DisplayMember = "grade";
            Grade.ValueMember = "grade";
            Grade.DataSource = data;
        }

        private void Grade_SelectedIndexChanged(object sender, EventArgs e)
        {
            string grade = Grade.SelectedValue.ToString();
            MySqlConnection dbconn = new MySqlConnection(connectionString);
            string query = "SELECT * FROM employees, salary_grade WHERE salary BETWEEN min_salary AND max_salary AND grade=@grade ORDER BY emp_name ASC";
            dbconn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, dbconn);
            adapter.SelectCommand.Parameters.AddWithValue("@grade", grade);
            DataTable data = new DataTable();
            adapter.Fill(data);
            Employee.DisplayMember = "emp_name";
            Employee.ValueMember = "emp_id";
            Employee.DataSource = data;
            dbconn.Close();
            query = "SELECT * FROM salary_grade WHERE grade=@grade";
            dbconn.Open();
            MySqlCommand d = new MySqlCommand(query, dbconn);
            d.Parameters.AddWithValue("@grade", grade);
            MySqlDataReader reader = d.ExecuteReader();
            if (reader.Read())
            {
                egrade.Text = reader[0].ToString().Trim();
                min.Text = reader[1].ToString().Trim();
                max.Text = reader[2].ToString().Trim();
            }
            dbconn.Close();
            EmployeeTable();
        }

        private void filtergrade_TextChanged(object sender, EventArgs e)
        {
            GradeTable();
            EmployeeTable();
        }

        private void filteremp_TextChanged(object sender, EventArgs e)
        {
            EmployeeTable();
        }

        private void GradeTable()
        {
            MySqlConnection dbconn = new MySqlConnection(connectionString);
            string query = "SELECT * FROM salary_grade WHERE grade LIKE @grade";
            dbconn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, dbconn);
            adapter.SelectCommand.Parameters.AddWithValue("@grade", filtergrade.Text + "%");
            DataTable data = new DataTable();
            adapter.Fill(data);
            Grade.DisplayMember = "grade";
            Grade.ValueMember = "grade";
            Grade.DataSource = data;
            dbconn.Close();
        }

        private void EmployeeTable()
        {
            if (Grade.Items.Count != 0)
            {
                MySqlConnection dbconn = new MySqlConnection(connectionString);
                string query = "SELECT * FROM employees, salary_grade WHERE salary BETWEEN min_salary AND max_salary AND grade=@grade AND emp_name LIKE @emp ORDER BY emp_name ASC";
                dbconn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, dbconn);
                adapter.SelectCommand.Parameters.AddWithValue("@grade", Grade.SelectedValue);
                adapter.SelectCommand.Parameters.AddWithValue("@emp", filteremp.Text + "%");
                DataTable data = new DataTable();
                adapter.Fill(data);
                Employee.DisplayMember = "emp_name";
                Employee.ValueMember = "emp_id";
                Employee.DataSource = data;
                dbconn.Close();
            }
            else
            {
                Employee.DataSource = null;
            }
        }

        private void filtergrade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                filteremp.Focus();
            }
        }

        private void filteremp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                filtergrade.Focus();
            }
        }

        private void Change_Click(object sender, EventArgs e)
        {
            MySqlConnection dbconn = new MySqlConnection(connectionString);
            string query = "UPDATE salary_grade SET min_salary=@min, max_salary=@max WHERE grade=@grade";
            dbconn.Open();           
            MySqlCommand data = new MySqlCommand(query, dbconn);
            data.Parameters.AddWithValue("@grade", egrade.Text);
            data.Parameters.AddWithValue("@min", min.Text);
            data.Parameters.AddWithValue("@max", max.Text);
            data.ExecuteNonQuery();
            DisplayGrade();
            MessageBox.Show("Grade range has been changed");
            dbconn.Close();
            egrade.Focus();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            MySqlConnection dbconn = new MySqlConnection(connectionString);
            string query = "SELECT * FROM salary_grade WHERE grade=@grade";
            dbconn.Open();
            MySqlCommand data = new MySqlCommand(query, dbconn);
            data.Parameters.AddWithValue("grade", addgrade.Text);
            MySqlDataReader reader = data.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("This grade level already exist please pick another grade");
            }
            else
            {
                query = "INSERT INTO salary_grade VALUES(@grade, @min, @max)";
                dbconn.Close();
                dbconn.Open();
                data = new MySqlCommand(query, dbconn);
                data.Parameters.AddWithValue("@grade", addgrade.Text);
                data.Parameters.AddWithValue("@min", addmin.Text);
                data.Parameters.AddWithValue("@max", addmax.Text);
                data.ExecuteNonQuery();
                DisplayGrade();
                MessageBox.Show("Grade has been added!");
                ClearSalary();
                addgrade.Focus();
            }
            dbconn.Close();
        }


        private void Remove_Click(object sender, EventArgs e)
        {
            Confirm c = new Confirm();
            DialogResult show = c.ShowDialog();
            if (c.ConfirmDelete())
            {
                MySqlConnection dbconn = new MySqlConnection(connectionString);
                string query = "DELETE FROM salary_grade WHERE grade=@grade";
                dbconn.Open();
                MySqlCommand data = new MySqlCommand(query, dbconn);
                data.Parameters.AddWithValue("@grade", egrade.Text);
                data.ExecuteNonQuery();
                MessageBox.Show("Grade has been deleted!");
                DisplayGrade();
                dbconn.Close();
            }
        }

        public void ClearSalary()
        {
            addgrade.Text = "";
            addmin.Text = "";
            addmax.Text = "";
            filtergrade.Text = "";
            filteremp.Text = "";
        }

        private void min_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                max.Focus();
            }
        }

        private void max_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                Change_Click(sender, e);
            }
        }

        private void addgrade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                addmin.Focus();
            }
        }

        private void addmin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                addmax.Focus();
            }
        }

        private void addmax_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                Add_Click(sender, e);
            }
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
