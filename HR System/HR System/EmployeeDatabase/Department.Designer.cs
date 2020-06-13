namespace EmployeeDatabase
{
    partial class Department
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Employee = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.filteremp = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Departments = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.filterdep = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Remove = new System.Windows.Forms.Button();
            this.Change = new System.Windows.Forms.Button();
            this.depid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.depname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.deploc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Add = new System.Windows.Forms.Button();
            this.addname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addloc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Employee);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.filteremp);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(373, 61);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(168, 416);
            this.groupBox5.TabIndex = 33;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Department\'s Employee";
            // 
            // Employee
            // 
            this.Employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee.FormattingEnabled = true;
            this.Employee.ItemHeight = 16;
            this.Employee.Location = new System.Drawing.Point(9, 21);
            this.Employee.Name = "Employee";
            this.Employee.Size = new System.Drawing.Size(153, 324);
            this.Employee.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 365);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Filter Employee";
            // 
            // filteremp
            // 
            this.filteremp.Location = new System.Drawing.Point(6, 381);
            this.filteremp.Name = "filteremp";
            this.filteremp.Size = new System.Drawing.Size(153, 22);
            this.filteremp.TabIndex = 1;
            this.filteremp.TextChanged += new System.EventHandler(this.filteremp_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Departments);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.filterdep);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(199, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 416);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Department";
            // 
            // Departments
            // 
            this.Departments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Departments.FormattingEnabled = true;
            this.Departments.ItemHeight = 16;
            this.Departments.Location = new System.Drawing.Point(9, 22);
            this.Departments.Name = "Departments";
            this.Departments.Size = new System.Drawing.Size(153, 324);
            this.Departments.TabIndex = 42;
            this.Departments.SelectedIndexChanged += new System.EventHandler(this.Departments_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filter Department";
            // 
            // filterdep
            // 
            this.filterdep.Location = new System.Drawing.Point(6, 381);
            this.filterdep.Name = "filterdep";
            this.filterdep.Size = new System.Drawing.Size(153, 22);
            this.filterdep.TabIndex = 1;
            this.filterdep.TextChanged += new System.EventHandler(this.filterdep_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Remove);
            this.groupBox2.Controls.Add(this.Change);
            this.groupBox2.Controls.Add(this.depid);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.depname);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.deploc);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 205);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Department Details";
            // 
            // Remove
            // 
            this.Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove.Location = new System.Drawing.Point(90, 170);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(69, 28);
            this.Remove.TabIndex = 44;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Change
            // 
            this.Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Change.Location = new System.Drawing.Point(15, 170);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(69, 28);
            this.Change.TabIndex = 29;
            this.Change.Text = "Change";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // depid
            // 
            this.depid.Location = new System.Drawing.Point(6, 49);
            this.depid.Name = "depid";
            this.depid.Size = new System.Drawing.Size(153, 22);
            this.depid.TabIndex = 3;
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
            // depname
            // 
            this.depname.Location = new System.Drawing.Point(6, 92);
            this.depname.MaxLength = 20;
            this.depname.Name = "depname";
            this.depname.Size = new System.Drawing.Size(153, 22);
            this.depname.TabIndex = 5;
            this.depname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.depname_KeyDown);
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
            // deploc
            // 
            this.deploc.Location = new System.Drawing.Point(6, 142);
            this.deploc.MaxLength = 15;
            this.deploc.Name = "deploc";
            this.deploc.Size = new System.Drawing.Size(153, 22);
            this.deploc.TabIndex = 7;
            this.deploc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.deploc_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Location";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Add);
            this.groupBox3.Controls.Add(this.addname);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.addloc);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(14, 283);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(169, 156);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add New Department";
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(94, 121);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(69, 28);
            this.Add.TabIndex = 29;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // addname
            // 
            this.addname.Location = new System.Drawing.Point(6, 43);
            this.addname.MaxLength = 20;
            this.addname.Name = "addname";
            this.addname.Size = new System.Drawing.Size(153, 22);
            this.addname.TabIndex = 5;
            this.addname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addname_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Name";
            // 
            // addloc
            // 
            this.addloc.Location = new System.Drawing.Point(6, 93);
            this.addloc.MaxLength = 15;
            this.addloc.Name = "addloc";
            this.addloc.Size = new System.Drawing.Size(153, 22);
            this.addloc.TabIndex = 7;
            this.addloc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addloc_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Location";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(14, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 31);
            this.label8.TabIndex = 32;
            this.label8.Text = "DEPARTMENT";
            // 
            // Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Name = "Department";
            this.Size = new System.Drawing.Size(557, 484);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox filteremp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox filterdep;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox depid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox depname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox deploc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox addname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox addloc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox Employee;
        private System.Windows.Forms.ListBox Departments;
        private System.Windows.Forms.Button Remove;
    }
}
