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
using System.Security.Cryptography;

namespace EmployeeDatabase
{
    public partial class Form1 : Form
    {
        public static string connectDB = "datasource = localhost; username = root; password =''; database = employees database; SslMode = none";
        Button selebutton = null;
        int selectedForm = 0;
        Color bg = Color.FromArgb(128, 128, 255);
        Color selebg = Color.SlateBlue;
        public string name = "";
        public string id = "";
        public string user = "";

        public Form1()
        {
            InitializeComponent();
            HideForms();
            heading.Hide();
            navi.Hide();
            this.Height = 500;
            this.Width = 500;
            Login.getMain(this);
            Register.getMain(this);
            Register.Hide();
        }

        public void SwitchForms(int s)
        {
            switch (selectedForm)
            {
                case 0:
                    Employee.Hide();
                    selectedForm = s;
                    break;
                case 1:
                    Manager.Hide();
                    selectedForm = s;
                    break;
                case 2:
                    Department.Hide();
                    selectedForm = s;
                    break;
                case 3:
                    SalaryGrade.Hide();
                    selectedForm = s;
                    break;
                case 4:
                    Admins.Hide();
                    selectedForm = s;
                    break;
            }
        }

        public void HideForms()
        {
            Employee.Hide();
            Manager.Hide();
            Department.Hide();
            SalaryGrade.Hide();
            Admins.Hide();
        }

        public void signin()
        {
            Login.Hide();
            heading.Show();
            Employee.Show();
            navi.Show();
            Height = 700;
            Width = 825;
            selectedForm = 0;
            selebutton = emp;
            selebutton.BackColor = selebg;
            Employee.DisplayEmployee();
            this.CenterToScreen();
            adminn.Text = name;
            MessageBox.Show("Login in successful!");
        }

        public void signout()
        {
            selebutton.BackColor = bg;
            selebutton = null;
            name = "";
            id = "";
            user = "";
            HideForms();
            navi.Hide();
            heading.Hide();
            Login.Show();
            Height = 500;
            Width = 500;
            this.CenterToScreen();
            MessageBox.Show("You have signed out!");
        }

        public void navsele(Button b)
        {
            selebutton.BackColor = bg;
            selebutton = null;
            selebutton = b;
            selebutton.BackColor = selebg;
        }

        private void emp_Click(object sender, EventArgs e)
        {
            navsele((Button)sender);
            SwitchForms(0);
            Employee.Show();
            Employee.DisplayEmployee();
            Employee.filteremp.Focus();           
        }

        private void manag_Click(object sender, EventArgs e)
        {
            navsele((Button)sender);
            SwitchForms(1);
            Manager.Show();
            Manager.DisplayManagers();
            Manager.filtermanag.Focus();
        }

        private void depart_Click(object sender, EventArgs e)
        {
            navsele((Button)sender);
            SwitchForms(2);
            Department.Show();
            Department.DisplayDepartment();
            Department.filterdep.Focus();
        }

        private void grade_Click(object sender, EventArgs e)
        {
            navsele((Button)sender);
            SwitchForms(3);
            SalaryGrade.Show();
            SalaryGrade.filtergrade.Focus();
            SalaryGrade.DisplayGrade();
        }

        private void admin_Click(object sender, EventArgs e)
        {
            navsele((Button)sender);
            SwitchForms(4);
            Admins.Show();
            Admins.auser.Focus();
            Admins.DisplayAdmin(id, this);  
        }

        private void logout_Click(object sender, EventArgs e)
        {
            signout();
        }
    }
}
