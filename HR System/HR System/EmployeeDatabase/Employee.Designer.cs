namespace EmployeeDatabase
{
    partial class Employee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.filteremp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Employees = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.empid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.empname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.empjob = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.empsalary = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.empcommis = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.depid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.deploc = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.empgrade = new System.Windows.Forms.TextBox();
            this.Remove = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.Change = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.depname = new System.Windows.Forms.ComboBox();
            this.manjob = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.manid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.manname = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.addemp = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // filteremp
            // 
            this.filteremp.Location = new System.Drawing.Point(6, 281);
            this.filteremp.Name = "filteremp";
            this.filteremp.Size = new System.Drawing.Size(153, 22);
            this.filteremp.TabIndex = 1;
            this.filteremp.TextChanged += new System.EventHandler(this.filteremp_TextChanged);
            this.filteremp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.filteremp_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filter Employee";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Employees);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.filteremp);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(381, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 317);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee";
            // 
            // Employees
            // 
            this.Employees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employees.FormattingEnabled = true;
            this.Employees.ItemHeight = 16;
            this.Employees.Location = new System.Drawing.Point(6, 19);
            this.Employees.Name = "Employees";
            this.Employees.Size = new System.Drawing.Size(153, 228);
            this.Employees.TabIndex = 44;
            this.Employees.SelectedIndexChanged += new System.EventHandler(this.Employees_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID";
            // 
            // empid
            // 
            this.empid.Location = new System.Drawing.Point(6, 49);
            this.empid.Name = "empid";
            this.empid.Size = new System.Drawing.Size(153, 22);
            this.empid.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name";
            // 
            // empname
            // 
            this.empname.Location = new System.Drawing.Point(6, 92);
            this.empname.MaxLength = 25;
            this.empname.Name = "empname";
            this.empname.Size = new System.Drawing.Size(153, 22);
            this.empname.TabIndex = 5;
            this.empname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.empname_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Job";
            // 
            // empjob
            // 
            this.empjob.Location = new System.Drawing.Point(6, 142);
            this.empjob.MaxLength = 25;
            this.empjob.Name = "empjob";
            this.empjob.Size = new System.Drawing.Size(153, 22);
            this.empjob.TabIndex = 7;
            this.empjob.KeyDown += new System.Windows.Forms.KeyEventHandler(this.empjob_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Salary";
            // 
            // empsalary
            // 
            this.empsalary.Location = new System.Drawing.Point(6, 185);
            this.empsalary.MaxLength = 10;
            this.empsalary.Name = "empsalary";
            this.empsalary.Size = new System.Drawing.Size(153, 22);
            this.empsalary.TabIndex = 9;
            this.empsalary.KeyDown += new System.Windows.Forms.KeyEventHandler(this.empsalary_KeyDown);
            this.empsalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumOnly_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Commision";
            // 
            // empcommis
            // 
            this.empcommis.Location = new System.Drawing.Point(6, 233);
            this.empcommis.MaxLength = 7;
            this.empcommis.Name = "empcommis";
            this.empcommis.Size = new System.Drawing.Size(153, 22);
            this.empcommis.TabIndex = 11;
            this.empcommis.KeyDown += new System.Windows.Forms.KeyEventHandler(this.empcommis_KeyDown);
            this.empcommis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumOnly_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "ID";
            // 
            // depid
            // 
            this.depid.Location = new System.Drawing.Point(6, 55);
            this.depid.Name = "depid";
            this.depid.Size = new System.Drawing.Size(153, 22);
            this.depid.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Location";
            // 
            // deploc
            // 
            this.deploc.Location = new System.Drawing.Point(6, 147);
            this.deploc.Name = "deploc";
            this.deploc.Size = new System.Drawing.Size(153, 22);
            this.deploc.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.empgrade);
            this.groupBox2.Controls.Add(this.Remove);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.Change);
            this.groupBox2.Controls.Add(this.empcommis);
            this.groupBox2.Controls.Add(this.empid);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.empname);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.empjob);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.empsalary);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 350);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Employee Details";
            // 
            // empgrade
            // 
            this.empgrade.Location = new System.Drawing.Point(6, 276);
            this.empgrade.Name = "empgrade";
            this.empgrade.Size = new System.Drawing.Size(153, 22);
            this.empgrade.TabIndex = 28;
            // 
            // Remove
            // 
            this.Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove.Location = new System.Drawing.Point(86, 308);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(73, 28);
            this.Remove.TabIndex = 29;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 260);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 16);
            this.label13.TabIndex = 29;
            this.label13.Text = "Grade";
            // 
            // Change
            // 
            this.Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Change.Location = new System.Drawing.Point(12, 308);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(68, 28);
            this.Change.TabIndex = 28;
            this.Change.Text = "Change";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.depname);
            this.groupBox3.Controls.Add(this.deploc);
            this.groupBox3.Controls.Add(this.depid);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(189, 237);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(171, 176);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Department Details";
            // 
            // depname
            // 
            this.depname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.depname.FormattingEnabled = true;
            this.depname.Location = new System.Drawing.Point(6, 102);
            this.depname.Name = "depname";
            this.depname.Size = new System.Drawing.Size(153, 24);
            this.depname.TabIndex = 34;
            this.depname.SelectedIndexChanged += new System.EventHandler(this.depname_SelectedIndexChanged);
            // 
            // manjob
            // 
            this.manjob.Location = new System.Drawing.Point(6, 138);
            this.manjob.Name = "manjob";
            this.manjob.Size = new System.Drawing.Size(153, 22);
            this.manjob.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 16);
            this.label12.TabIndex = 24;
            this.label12.Text = "Job";
            // 
            // manid
            // 
            this.manid.Location = new System.Drawing.Point(6, 46);
            this.manid.Name = "manid";
            this.manid.Size = new System.Drawing.Size(153, 22);
            this.manid.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "ID";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.manname);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.manid);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.manjob);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(189, 63);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(171, 168);
            this.groupBox5.TabIndex = 27;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Manager Details";
            // 
            // manname
            // 
            this.manname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.manname.FormattingEnabled = true;
            this.manname.Location = new System.Drawing.Point(6, 92);
            this.manname.Name = "manname";
            this.manname.Size = new System.Drawing.Size(153, 24);
            this.manname.TabIndex = 33;
            this.manname.SelectedIndexChanged += new System.EventHandler(this.manname_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(14, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(162, 31);
            this.label14.TabIndex = 32;
            this.label14.Text = "EMPLOYEE";
            // 
            // addemp
            // 
            this.addemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addemp.Location = new System.Drawing.Point(404, 390);
            this.addemp.Name = "addemp";
            this.addemp.Size = new System.Drawing.Size(145, 28);
            this.addemp.TabIndex = 30;
            this.addemp.Text = "Add New Employee";
            this.addemp.UseVisualStyleBackColor = true;
            this.addemp.Click += new System.EventHandler(this.addemp_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addemp);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Employee";
            this.Size = new System.Drawing.Size(574, 444);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox filteremp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox empid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox empname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox empjob;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox empsalary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox empcommis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox depid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox deploc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox empgrade;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.TextBox manjob;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox manid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox Employees;
        private System.Windows.Forms.Button addemp;
        private System.Windows.Forms.ComboBox depname;
        private System.Windows.Forms.ComboBox manname;
    }
}
