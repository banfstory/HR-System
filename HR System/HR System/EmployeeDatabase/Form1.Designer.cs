namespace EmployeeDatabase
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.navi = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.Button();
            this.admin = new System.Windows.Forms.Button();
            this.manag = new System.Windows.Forms.Button();
            this.emp = new System.Windows.Forms.Button();
            this.depart = new System.Windows.Forms.Button();
            this.grade = new System.Windows.Forms.Button();
            this.heading = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.adminn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SalaryGrade = new EmployeeDatabase.SalaryGrade();
            this.Department = new EmployeeDatabase.Department();
            this.Manager = new EmployeeDatabase.Manager();
            this.Admins = new EmployeeDatabase.Admin();
            this.Employee = new EmployeeDatabase.Employee();
            this.Login = new EmployeeDatabase.Login();
            this.Register = new EmployeeDatabase.Register();
            this.navi.SuspendLayout();
            this.heading.SuspendLayout();
            this.SuspendLayout();
            // 
            // navi
            // 
            this.navi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.navi.Controls.Add(this.logout);
            this.navi.Controls.Add(this.admin);
            this.navi.Controls.Add(this.manag);
            this.navi.Controls.Add(this.emp);
            this.navi.Controls.Add(this.depart);
            this.navi.Controls.Add(this.grade);
            this.navi.Location = new System.Drawing.Point(-2, -1);
            this.navi.Name = "navi";
            this.navi.Size = new System.Drawing.Size(185, 667);
            this.navi.TabIndex = 9;
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("Arial", 14F);
            this.logout.ForeColor = System.Drawing.Color.White;
            this.logout.Location = new System.Drawing.Point(3, 518);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(182, 80);
            this.logout.TabIndex = 14;
            this.logout.TabStop = false;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // admin
            // 
            this.admin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.admin.FlatAppearance.BorderSize = 0;
            this.admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin.Font = new System.Drawing.Font("Arial", 14F);
            this.admin.ForeColor = System.Drawing.Color.White;
            this.admin.Location = new System.Drawing.Point(3, 438);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(182, 80);
            this.admin.TabIndex = 15;
            this.admin.TabStop = false;
            this.admin.Text = "Admin";
            this.admin.UseVisualStyleBackColor = false;
            this.admin.Click += new System.EventHandler(this.admin_Click);
            // 
            // manag
            // 
            this.manag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.manag.FlatAppearance.BorderSize = 0;
            this.manag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manag.Font = new System.Drawing.Font("Arial", 14F);
            this.manag.ForeColor = System.Drawing.Color.White;
            this.manag.Location = new System.Drawing.Point(3, 198);
            this.manag.Name = "manag";
            this.manag.Size = new System.Drawing.Size(182, 80);
            this.manag.TabIndex = 11;
            this.manag.TabStop = false;
            this.manag.Text = "Managers";
            this.manag.UseVisualStyleBackColor = false;
            this.manag.Click += new System.EventHandler(this.manag_Click);
            // 
            // emp
            // 
            this.emp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.emp.FlatAppearance.BorderSize = 0;
            this.emp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emp.Font = new System.Drawing.Font("Arial", 14F);
            this.emp.ForeColor = System.Drawing.Color.White;
            this.emp.Location = new System.Drawing.Point(3, 118);
            this.emp.Name = "emp";
            this.emp.Size = new System.Drawing.Size(182, 80);
            this.emp.TabIndex = 10;
            this.emp.TabStop = false;
            this.emp.Text = "Employees";
            this.emp.UseVisualStyleBackColor = false;
            this.emp.Click += new System.EventHandler(this.emp_Click);
            // 
            // depart
            // 
            this.depart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.depart.FlatAppearance.BorderSize = 0;
            this.depart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.depart.Font = new System.Drawing.Font("Arial", 14F);
            this.depart.ForeColor = System.Drawing.Color.White;
            this.depart.Location = new System.Drawing.Point(3, 278);
            this.depart.Name = "depart";
            this.depart.Size = new System.Drawing.Size(182, 80);
            this.depart.TabIndex = 12;
            this.depart.TabStop = false;
            this.depart.Text = "Departments";
            this.depart.UseVisualStyleBackColor = false;
            this.depart.Click += new System.EventHandler(this.depart_Click);
            // 
            // grade
            // 
            this.grade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.grade.FlatAppearance.BorderSize = 0;
            this.grade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grade.Font = new System.Drawing.Font("Arial", 14F);
            this.grade.ForeColor = System.Drawing.Color.White;
            this.grade.Location = new System.Drawing.Point(3, 358);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(182, 80);
            this.grade.TabIndex = 13;
            this.grade.TabStop = false;
            this.grade.Text = "Salary Grade";
            this.grade.UseVisualStyleBackColor = false;
            this.grade.Click += new System.EventHandler(this.grade_Click);
            // 
            // heading
            // 
            this.heading.BackColor = System.Drawing.Color.SlateBlue;
            this.heading.Controls.Add(this.label1);
            this.heading.Controls.Add(this.adminn);
            this.heading.Controls.Add(this.label3);
            this.heading.Location = new System.Drawing.Point(183, -1);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(629, 100);
            this.heading.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SlateBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(178, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 31);
            this.label3.TabIndex = 12;
            this.label3.Text = "EMPLOYEE SYSTEM";
            // 
            // adminn
            // 
            this.adminn.AutoSize = true;
            this.adminn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.adminn.Location = new System.Drawing.Point(491, 34);
            this.adminn.Name = "adminn";
            this.adminn.Size = new System.Drawing.Size(42, 16);
            this.adminn.TabIndex = 13;
            this.adminn.Text = "name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(491, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Welcome";
            // 
            // SalaryGrade
            // 
            this.SalaryGrade.Location = new System.Drawing.Point(210, 117);
            this.SalaryGrade.Name = "SalaryGrade";
            this.SalaryGrade.Size = new System.Drawing.Size(559, 514);
            this.SalaryGrade.TabIndex = 15;
            // 
            // Department
            // 
            this.Department.Location = new System.Drawing.Point(212, 117);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(557, 484);
            this.Department.TabIndex = 14;
            // 
            // Manager
            // 
            this.Manager.Location = new System.Drawing.Point(208, 117);
            this.Manager.Name = "Manager";
            this.Manager.Size = new System.Drawing.Size(561, 533);
            this.Manager.TabIndex = 13;
            // 
            // Admins
            // 
            this.Admins.Location = new System.Drawing.Point(208, 117);
            this.Admins.Name = "Admins";
            this.Admins.Size = new System.Drawing.Size(379, 345);
            this.Admins.TabIndex = 12;
            // 
            // Employee
            // 
            this.Employee.Location = new System.Drawing.Point(208, 117);
            this.Employee.Name = "Employee";
            this.Employee.Size = new System.Drawing.Size(553, 511);
            this.Employee.TabIndex = 11;
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.LightCyan;
            this.Login.Location = new System.Drawing.Point(-2, -1);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(487, 448);
            this.Login.TabIndex = 0;
            // 
            // Register
            // 
            this.Register.BackColor = System.Drawing.Color.LightCyan;
            this.Register.Location = new System.Drawing.Point(-2, -1);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(487, 555);
            this.Register.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(809, 662);
            this.Controls.Add(this.Employee);
            this.Controls.Add(this.heading);
            this.Controls.Add(this.navi);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.Manager);
            this.Controls.Add(this.SalaryGrade);
            this.Controls.Add(this.Department);
            this.Controls.Add(this.Admins);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee System";
            this.navi.ResumeLayout(false);
            this.heading.ResumeLayout(false);
            this.heading.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public Login Login;
        public Register Register;
        public System.Windows.Forms.Panel navi;
        private System.Windows.Forms.Button emp;
        private System.Windows.Forms.Button manag;
        private System.Windows.Forms.Button grade;
        private System.Windows.Forms.Button depart;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button admin;
        public System.Windows.Forms.Panel heading;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label adminn;
        private System.Windows.Forms.Label label1;
        private Employee Employee;
        private Admin Admins;
        private Manager Manager;
        private Department Department;
        private SalaryGrade SalaryGrade;
    }
}

