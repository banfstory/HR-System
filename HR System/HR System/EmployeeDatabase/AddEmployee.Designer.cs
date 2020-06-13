namespace EmployeeDatabase
{
    partial class AddEmployee
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.manname = new System.Windows.Forms.ComboBox();
            this.manid = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.manjob = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.depname = new System.Windows.Forms.ComboBox();
            this.deploc = new System.Windows.Forms.TextBox();
            this.depid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.emphire = new System.Windows.Forms.MaskedTextBox();
            this.empjob = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.empcommis = new System.Windows.Forms.TextBox();
            this.empname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.empsalary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Cacnel = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.manname);
            this.groupBox5.Controls.Add(this.manid);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.manjob);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(187, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(171, 168);
            this.groupBox5.TabIndex = 30;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Employee\'s Manager";
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
            // manname
            // 
            this.manname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.manname.FormattingEnabled = true;
            this.manname.Location = new System.Drawing.Point(6, 98);
            this.manname.Name = "manname";
            this.manname.Size = new System.Drawing.Size(153, 24);
            this.manname.TabIndex = 31;
            this.manname.SelectedIndexChanged += new System.EventHandler(this.manname_SelectedIndexChanged);
            // 
            // manid
            // 
            this.manid.Location = new System.Drawing.Point(6, 46);
            this.manid.Name = "manid";
            this.manid.Size = new System.Drawing.Size(153, 22);
            this.manid.TabIndex = 19;
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "Name";
            // 
            // manjob
            // 
            this.manjob.Location = new System.Drawing.Point(6, 138);
            this.manjob.Name = "manjob";
            this.manjob.Size = new System.Drawing.Size(153, 22);
            this.manjob.TabIndex = 23;
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
            this.groupBox3.Location = new System.Drawing.Point(187, 186);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(171, 176);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Employee\'s Department";
            // 
            // depname
            // 
            this.depname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.depname.FormattingEnabled = true;
            this.depname.Location = new System.Drawing.Point(6, 105);
            this.depname.Name = "depname";
            this.depname.Size = new System.Drawing.Size(153, 24);
            this.depname.TabIndex = 32;
            this.depname.SelectedIndexChanged += new System.EventHandler(this.depname_SelectedIndexChanged);
            // 
            // deploc
            // 
            this.deploc.Location = new System.Drawing.Point(6, 147);
            this.deploc.Name = "deploc";
            this.deploc.Size = new System.Drawing.Size(153, 22);
            this.deploc.TabIndex = 17;
            // 
            // depid
            // 
            this.depid.Location = new System.Drawing.Point(6, 55);
            this.depid.Name = "depid";
            this.depid.Size = new System.Drawing.Size(153, 22);
            this.depid.TabIndex = 13;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.emphire);
            this.groupBox2.Controls.Add(this.empjob);
            this.groupBox2.Controls.Add(this.Add);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.empcommis);
            this.groupBox2.Controls.Add(this.empname);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.empsalary);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 293);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Employee Details";
            // 
            // emphire
            // 
            this.emphire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emphire.Location = new System.Drawing.Point(10, 232);
            this.emphire.Mask = "0000-00-00";
            this.emphire.Name = "emphire";
            this.emphire.Size = new System.Drawing.Size(153, 22);
            this.emphire.TabIndex = 32;
            this.emphire.KeyDown += new System.Windows.Forms.KeyEventHandler(this.emphire_KeyDown);
            // 
            // empjob
            // 
            this.empjob.Location = new System.Drawing.Point(10, 95);
            this.empjob.MaxLength = 25;
            this.empjob.Name = "empjob";
            this.empjob.Size = new System.Drawing.Size(153, 22);
            this.empjob.TabIndex = 29;
            this.empjob.KeyDown += new System.Windows.Forms.KeyEventHandler(this.empjob_KeyDown);
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(107, 257);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(56, 28);
            this.Add.TabIndex = 28;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Hire Date";
            // 
            // empcommis
            // 
            this.empcommis.Location = new System.Drawing.Point(10, 186);
            this.empcommis.MaxLength = 7;
            this.empcommis.Name = "empcommis";
            this.empcommis.Size = new System.Drawing.Size(153, 22);
            this.empcommis.TabIndex = 11;
            this.empcommis.KeyDown += new System.Windows.Forms.KeyEventHandler(this.empcommis_KeyDown);
            this.empcommis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumOnly_KeyPress);
            // 
            // empname
            // 
            this.empname.Location = new System.Drawing.Point(10, 45);
            this.empname.MaxLength = 25;
            this.empname.Name = "empname";
            this.empname.Size = new System.Drawing.Size(153, 22);
            this.empname.TabIndex = 5;
            this.empname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.empname_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Job";
            // 
            // empsalary
            // 
            this.empsalary.Location = new System.Drawing.Point(10, 138);
            this.empsalary.MaxLength = 10;
            this.empsalary.Name = "empsalary";
            this.empsalary.Size = new System.Drawing.Size(153, 22);
            this.empsalary.TabIndex = 9;
            this.empsalary.KeyDown += new System.Windows.Forms.KeyEventHandler(this.empsalary_KeyDown);
            this.empsalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumOnly_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Salary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Commision";
            // 
            // Cacnel
            // 
            this.Cacnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cacnel.Location = new System.Drawing.Point(115, 327);
            this.Cacnel.Name = "Cacnel";
            this.Cacnel.Size = new System.Drawing.Size(66, 28);
            this.Cacnel.TabIndex = 30;
            this.Cacnel.Text = "Cancel";
            this.Cacnel.UseVisualStyleBackColor = true;
            this.Cacnel.Click += new System.EventHandler(this.Cacnel_Click);
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(371, 371);
            this.Controls.Add(this.Cacnel);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEmployee";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox manid;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox manjob;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox deploc;
        private System.Windows.Forms.TextBox depid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox empcommis;
        private System.Windows.Forms.TextBox empname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox empsalary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Cacnel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox manname;
        private System.Windows.Forms.ComboBox depname;
        private System.Windows.Forms.TextBox empjob;
        private System.Windows.Forms.MaskedTextBox emphire;
    }
}