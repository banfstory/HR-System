namespace EmployeeDatabase
{
    partial class SalaryGrade
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.addmax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.addgrade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addmin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Remove = new System.Windows.Forms.Button();
            this.Change = new System.Windows.Forms.Button();
            this.egrade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.min = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.max = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Employee = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.filteremp = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Grade = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.filtergrade = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.addmax);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.Add);
            this.groupBox3.Controls.Add(this.addgrade);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.addmin);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(18, 289);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(169, 204);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Grade";
            // 
            // addmax
            // 
            this.addmax.Location = new System.Drawing.Point(6, 140);
            this.addmax.MaxLength = 11;
            this.addmax.Name = "addmax";
            this.addmax.Size = new System.Drawing.Size(153, 22);
            this.addmax.TabIndex = 30;
            this.addmax.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addmax_KeyDown);
            this.addmax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumOnly_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "Max Salary";
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(90, 168);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(69, 28);
            this.Add.TabIndex = 29;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // addgrade
            // 
            this.addgrade.Location = new System.Drawing.Point(6, 43);
            this.addgrade.MaxLength = 11;
            this.addgrade.Name = "addgrade";
            this.addgrade.Size = new System.Drawing.Size(153, 22);
            this.addgrade.TabIndex = 5;
            this.addgrade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addgrade_KeyDown);
            this.addgrade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumOnly_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Grade";
            // 
            // addmin
            // 
            this.addmin.Location = new System.Drawing.Point(6, 93);
            this.addmin.MaxLength = 11;
            this.addmin.Name = "addmin";
            this.addmin.Size = new System.Drawing.Size(153, 22);
            this.addmin.TabIndex = 7;
            this.addmin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addmin_KeyDown);
            this.addmin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumOnly_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Min Salary";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Remove);
            this.groupBox2.Controls.Add(this.Change);
            this.groupBox2.Controls.Add(this.egrade);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.min);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.max);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(18, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 205);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grade";
            // 
            // Remove
            // 
            this.Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove.Location = new System.Drawing.Point(90, 170);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(69, 28);
            this.Remove.TabIndex = 30;
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
            // egrade
            // 
            this.egrade.Location = new System.Drawing.Point(6, 49);
            this.egrade.Name = "egrade";
            this.egrade.Size = new System.Drawing.Size(153, 22);
            this.egrade.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Grade";
            // 
            // min
            // 
            this.min.Location = new System.Drawing.Point(6, 92);
            this.min.MaxLength = 11;
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(153, 22);
            this.min.TabIndex = 5;
            this.min.KeyDown += new System.Windows.Forms.KeyEventHandler(this.min_KeyDown);
            this.min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumOnly_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Min Salary";
            // 
            // max
            // 
            this.max.Location = new System.Drawing.Point(6, 142);
            this.max.MaxLength = 11;
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(153, 22);
            this.max.TabIndex = 7;
            this.max.KeyDown += new System.Windows.Forms.KeyEventHandler(this.max_KeyDown);
            this.max.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumOnly_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Max Salary";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Employee);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.filteremp);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(377, 67);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(168, 426);
            this.groupBox5.TabIndex = 37;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Employee";
            // 
            // Employee
            // 
            this.Employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee.FormattingEnabled = true;
            this.Employee.ItemHeight = 16;
            this.Employee.Location = new System.Drawing.Point(9, 21);
            this.Employee.Name = "Employee";
            this.Employee.Size = new System.Drawing.Size(153, 340);
            this.Employee.TabIndex = 42;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 379);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Filter Employee";
            // 
            // filteremp
            // 
            this.filteremp.Location = new System.Drawing.Point(6, 395);
            this.filteremp.Name = "filteremp";
            this.filteremp.Size = new System.Drawing.Size(153, 22);
            this.filteremp.TabIndex = 1;
            this.filteremp.TextChanged += new System.EventHandler(this.filteremp_TextChanged);
            this.filteremp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.filteremp_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Grade);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.filtergrade);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(203, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 426);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grade";
            // 
            // Grade
            // 
            this.Grade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grade.FormattingEnabled = true;
            this.Grade.ItemHeight = 16;
            this.Grade.Location = new System.Drawing.Point(6, 21);
            this.Grade.Name = "Grade";
            this.Grade.Size = new System.Drawing.Size(153, 340);
            this.Grade.TabIndex = 41;
            this.Grade.SelectedIndexChanged += new System.EventHandler(this.Grade_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filter Grade";
            // 
            // filtergrade
            // 
            this.filtergrade.Location = new System.Drawing.Point(6, 395);
            this.filtergrade.Name = "filtergrade";
            this.filtergrade.Size = new System.Drawing.Size(153, 22);
            this.filtergrade.TabIndex = 1;
            this.filtergrade.TextChanged += new System.EventHandler(this.filtergrade_TextChanged);
            this.filtergrade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.filtergrade_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(12, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 31);
            this.label8.TabIndex = 40;
            this.label8.Text = "GRADE";
            // 
            // SalaryGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Name = "SalaryGrade";
            this.Size = new System.Drawing.Size(559, 511);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox addgrade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox addmin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.TextBox egrade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox min;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox max;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox filteremp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox filtergrade;
        private System.Windows.Forms.TextBox addmax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox Employee;
        private System.Windows.Forms.ListBox Grade;
        private System.Windows.Forms.Button Remove;
    }
}
