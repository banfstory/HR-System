namespace EmployeeDatabase
{
    partial class Manager
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
            this.deplocation = new System.Windows.Forms.TextBox();
            this.depid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.depname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mangjob = new System.Windows.Forms.TextBox();
            this.manggrade = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.mangcommis = new System.Windows.Forms.TextBox();
            this.mangid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mangname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mangsalary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Managers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.filtermanag = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Employees = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.filteremp = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.deplocation);
            this.groupBox3.Controls.Add(this.depid);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.depname);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(15, 361);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(171, 162);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Department Details";
            // 
            // deplocation
            // 
            this.deplocation.Location = new System.Drawing.Point(6, 129);
            this.deplocation.Name = "deplocation";
            this.deplocation.Size = new System.Drawing.Size(153, 22);
            this.deplocation.TabIndex = 17;
            // 
            // depid
            // 
            this.depid.Location = new System.Drawing.Point(6, 37);
            this.depid.Name = "depid";
            this.depid.Size = new System.Drawing.Size(153, 22);
            this.depid.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "ID";
            // 
            // depname
            // 
            this.depname.Location = new System.Drawing.Point(6, 84);
            this.depname.Name = "depname";
            this.depname.Size = new System.Drawing.Size(153, 22);
            this.depname.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Location";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mangjob);
            this.groupBox2.Controls.Add(this.manggrade);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.mangcommis);
            this.groupBox2.Controls.Add(this.mangid);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.mangname);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.mangsalary);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(15, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 295);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manager Details";
            // 
            // mangjob
            // 
            this.mangjob.Location = new System.Drawing.Point(6, 130);
            this.mangjob.MaxLength = 25;
            this.mangjob.Name = "mangjob";
            this.mangjob.Size = new System.Drawing.Size(153, 22);
            this.mangjob.TabIndex = 30;
            // 
            // manggrade
            // 
            this.manggrade.Location = new System.Drawing.Point(6, 264);
            this.manggrade.Name = "manggrade";
            this.manggrade.Size = new System.Drawing.Size(153, 22);
            this.manggrade.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 248);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 16);
            this.label13.TabIndex = 29;
            this.label13.Text = "Grade";
            // 
            // mangcommis
            // 
            this.mangcommis.Location = new System.Drawing.Point(6, 221);
            this.mangcommis.MaxLength = 7;
            this.mangcommis.Name = "mangcommis";
            this.mangcommis.Size = new System.Drawing.Size(153, 22);
            this.mangcommis.TabIndex = 11;
            // 
            // mangid
            // 
            this.mangid.Location = new System.Drawing.Point(6, 37);
            this.mangid.Name = "mangid";
            this.mangid.Size = new System.Drawing.Size(153, 22);
            this.mangid.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID";
            // 
            // mangname
            // 
            this.mangname.Location = new System.Drawing.Point(6, 80);
            this.mangname.MaxLength = 25;
            this.mangname.Name = "mangname";
            this.mangname.Size = new System.Drawing.Size(153, 22);
            this.mangname.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Job";
            // 
            // mangsalary
            // 
            this.mangsalary.Location = new System.Drawing.Point(6, 173);
            this.mangsalary.MaxLength = 10;
            this.mangsalary.Name = "mangsalary";
            this.mangsalary.Size = new System.Drawing.Size(153, 22);
            this.mangsalary.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Salary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Commision";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Managers);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.filtermanag);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(203, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 416);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manager";
            // 
            // Managers
            // 
            this.Managers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Managers.FormattingEnabled = true;
            this.Managers.ItemHeight = 16;
            this.Managers.Location = new System.Drawing.Point(6, 21);
            this.Managers.Name = "Managers";
            this.Managers.Size = new System.Drawing.Size(153, 324);
            this.Managers.TabIndex = 3;
            this.Managers.SelectedIndexChanged += new System.EventHandler(this.Managers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filter Manager";
            // 
            // filtermanag
            // 
            this.filtermanag.Location = new System.Drawing.Point(6, 381);
            this.filtermanag.Name = "filtermanag";
            this.filtermanag.Size = new System.Drawing.Size(153, 22);
            this.filtermanag.TabIndex = 5;
            this.filtermanag.TextChanged += new System.EventHandler(this.filtermanag_TextChanged);
            this.filtermanag.KeyDown += new System.Windows.Forms.KeyEventHandler(this.filtermanag_KeyDown);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Employees);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.filteremp);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(377, 60);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(168, 416);
            this.groupBox5.TabIndex = 31;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Manager\'s Employee";
            // 
            // Employees
            // 
            this.Employees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employees.FormattingEnabled = true;
            this.Employees.ItemHeight = 16;
            this.Employees.Location = new System.Drawing.Point(9, 21);
            this.Employees.Name = "Employees";
            this.Employees.Size = new System.Drawing.Size(153, 324);
            this.Employees.TabIndex = 4;
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
            this.filteremp.TabIndex = 5;
            this.filteremp.TextChanged += new System.EventHandler(this.filteremp_TextChanged);
            this.filteremp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.filteremp_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(15, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 31);
            this.label11.TabIndex = 33;
            this.label11.Text = "MANAGER";
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Manager";
            this.Size = new System.Drawing.Size(561, 579);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox deplocation;
        private System.Windows.Forms.TextBox depid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox depname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox manggrade;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox mangcommis;
        private System.Windows.Forms.TextBox mangid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mangname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mangsalary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox filtermanag;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox filteremp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox Managers;
        private System.Windows.Forms.ListBox Employees;
        private System.Windows.Forms.TextBox mangjob;
    }
}
