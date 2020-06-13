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
    public partial class Manager : UserControl
    {
        string connectionString;
        public Manager()
        {
            InitializeComponent();
            DisableAll();
        }

        public void DisplayManagers()
        {
            connectionString = Form1.connectDB;
            ClearManager();
            MySqlConnection dbconn = new MySqlConnection(connectionString);
            string query = "SELECT emp_id, emp_name FROM employees WHERE emp_id IN(SELECT DISTINCT manager_id FROM employees WHERE manager_id IS NOT NULL) ORDER BY emp_name ASC";         
            dbconn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, dbconn);
            DataTable data = new DataTable();
            adapter.Fill(data);
            Managers.DisplayMember = "emp_name";
            Managers.ValueMember = "emp_id";
            Managers.DataSource = data;
            dbconn.Close();
        }

        private void Managers_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetFields();
            MySqlConnection dbconn = new MySqlConnection(connectionString);
            string id = Managers.SelectedValue.ToString();
            string query = "SELECT * FROM employees e, department d, salary_grade s WHERE e.dep_id=d.dep_id AND e.salary BETWEEN s.min_salary AND s.max_salary AND emp_id=@id";
            dbconn.Open();
            MySqlCommand data = new MySqlCommand(query, dbconn);
            data.Parameters.AddWithValue("@id", id);
            MySqlDataReader reader = data.ExecuteReader();
            if (reader.Read())
            {
                mangid.Text = reader[0].ToString().Trim();
                mangname.Text = reader[1].ToString().Trim();
                mangjob.Text = reader[2].ToString().Trim();
                mangsalary.Text = reader[5].ToString().Trim();
                mangcommis.Text = reader[6].ToString().Trim();
                manggrade.Text = reader[11].ToString().Trim();
                depid.Text = reader[8].ToString().Trim();
                depname.Text = reader[9].ToString().Trim();
                deplocation.Text = reader[10].ToString().Trim();
            }
            dbconn.Close();
            dbconn.Open();
            query = "SELECT emp_id, emp_name FROM employees WHERE manager_id=@id AND emp_name LIKE @name ORDER BY emp_name ASC";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, dbconn);
            adapter.SelectCommand.Parameters.AddWithValue("@id", id);
            adapter.SelectCommand.Parameters.AddWithValue("@name", filteremp.Text + "%");
            DataTable d = new DataTable();
            adapter.Fill(d);
            Employees.DisplayMember = "emp_name";
            Employees.ValueMember = "emp_id";
            Employees.DataSource = d;
            dbconn.Close();
            EmployeeTable();
        }

        private void filtermanag_TextChanged(object sender, EventArgs e)
        {
            ManagerTable();
            EmployeeTable();
        }

        private void filteremp_TextChanged(object sender, EventArgs e)
        {
            EmployeeTable();
        }

        private void ManagerTable()
        {
            MySqlConnection dbconn = new MySqlConnection(connectionString);
            string query = "SELECT emp_id, emp_name FROM employees WHERE emp_id IN(SELECT DISTINCT manager_id FROM employees WHERE manager_id IS NOT NULL) AND emp_name LIKE @name ORDER BY emp_name ASC";
            dbconn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, dbconn);
            adapter.SelectCommand.Parameters.AddWithValue("@name", filtermanag.Text + "%");
            DataTable data = new DataTable();
            adapter.Fill(data);
            Managers.DisplayMember = "emp_name";
            Managers.ValueMember = "emp_id";
            Managers.DataSource = data;
            dbconn.Close();
        }

        private void EmployeeTable()
        {
            if (Managers.Items.Count != 0)
            {
                string id = Managers.SelectedValue.ToString();
                MySqlConnection dbconn = new MySqlConnection(connectionString);
                dbconn.Open();
                string query = "SELECT emp_id, emp_name FROM employees WHERE manager_id=@id AND emp_name LIKE @name ORDER BY emp_name ASC";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, dbconn);
                adapter.SelectCommand.Parameters.AddWithValue("@id", id);
                adapter.SelectCommand.Parameters.AddWithValue("@name", filteremp.Text + "%");
                DataTable d = new DataTable();
                adapter.Fill(d);
                Employees.DisplayMember = "emp_name";
                Employees.ValueMember = "emp_id";
                Employees.DataSource = d;
                dbconn.Close();
            }
            else
            {
                Employees.DataSource = null;
            }
        }

        private void ResetFields()
        {
            mangid.Text = "";
            mangname.Text = "";
            mangjob.Text = "";
            mangsalary.Text = "";
            mangcommis.Text = "";
            manggrade.Text = "";
            depid.Text = "";
            depname.Text = "";
            deplocation.Text = "";
        }

        private void DisableAll()
        {
            mangid.Enabled = false;
            mangname.Enabled = false;
            mangjob.Enabled = false;
            mangsalary.Enabled = false;
            mangcommis.Enabled = false;
            manggrade.Enabled = false;
            depid.Enabled = false;
            depname.Enabled = false;
            deplocation.Enabled = false;
        }

        private void ClearManager()
        {
            filtermanag.Text = "";
            filteremp.Text = "";
        }

        private void filtermanag_KeyDown(object sender, KeyEventArgs e)
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
                filtermanag.Focus();
            }
        }
    }
}
