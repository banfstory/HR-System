namespace EmployeeDatabase
{
    partial class Admin
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.changedetails = new System.Windows.Forms.Button();
            this.adminid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.auser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cnpass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.changepass = new System.Windows.Forms.Button();
            this.oldpass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.npass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.changename = new System.Windows.Forms.Button();
            this.aname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.changedetails);
            this.groupBox2.Controls.Add(this.adminid);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.auser);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(22, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 155);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Change Username";
            // 
            // changedetails
            // 
            this.changedetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changedetails.Location = new System.Drawing.Point(28, 114);
            this.changedetails.Name = "changedetails";
            this.changedetails.Size = new System.Drawing.Size(131, 28);
            this.changedetails.TabIndex = 29;
            this.changedetails.Text = "Change Username";
            this.changedetails.UseVisualStyleBackColor = true;
            this.changedetails.Click += new System.EventHandler(this.changedetails_Click);
            // 
            // adminid
            // 
            this.adminid.Location = new System.Drawing.Point(6, 40);
            this.adminid.Name = "adminid";
            this.adminid.Size = new System.Drawing.Size(153, 22);
            this.adminid.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID";
            // 
            // auser
            // 
            this.auser.Location = new System.Drawing.Point(6, 83);
            this.auser.MaxLength = 50;
            this.auser.Name = "auser";
            this.auser.Size = new System.Drawing.Size(153, 22);
            this.auser.TabIndex = 7;
            this.auser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.auser_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Username";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cnpass);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.changepass);
            this.groupBox1.Controls.Add(this.oldpass);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.npass);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(201, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 201);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change Password";
            // 
            // cnpass
            // 
            this.cnpass.Location = new System.Drawing.Point(6, 133);
            this.cnpass.MaxLength = 50;
            this.cnpass.Name = "cnpass";
            this.cnpass.Size = new System.Drawing.Size(153, 22);
            this.cnpass.TabIndex = 30;
            this.cnpass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cnpass_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 16);
            this.label7.TabIndex = 31;
            this.label7.Text = "Confirm New Password";
            // 
            // changepass
            // 
            this.changepass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changepass.Location = new System.Drawing.Point(25, 161);
            this.changepass.Name = "changepass";
            this.changepass.Size = new System.Drawing.Size(134, 28);
            this.changepass.TabIndex = 29;
            this.changepass.Text = "Change Password";
            this.changepass.UseVisualStyleBackColor = true;
            this.changepass.Click += new System.EventHandler(this.changepass_Click);
            // 
            // oldpass
            // 
            this.oldpass.Location = new System.Drawing.Point(6, 41);
            this.oldpass.MaxLength = 50;
            this.oldpass.Name = "oldpass";
            this.oldpass.Size = new System.Drawing.Size(153, 22);
            this.oldpass.TabIndex = 5;
            this.oldpass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.oldpass_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Old Password";
            // 
            // npass
            // 
            this.npass.Location = new System.Drawing.Point(6, 83);
            this.npass.MaxLength = 50;
            this.npass.Name = "npass";
            this.npass.Size = new System.Drawing.Size(153, 22);
            this.npass.TabIndex = 7;
            this.npass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.npass_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "New Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(16, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 31);
            this.label8.TabIndex = 31;
            this.label8.Text = "ADMIN";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.changename);
            this.groupBox3.Controls.Add(this.aname);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(22, 217);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(169, 103);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Change Display Name";
            // 
            // changename
            // 
            this.changename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changename.Location = new System.Drawing.Point(47, 68);
            this.changename.Name = "changename";
            this.changename.Size = new System.Drawing.Size(112, 28);
            this.changename.TabIndex = 29;
            this.changename.Text = "Change Name";
            this.changename.UseVisualStyleBackColor = true;
            this.changename.Click += new System.EventHandler(this.changename_Click);
            // 
            // aname
            // 
            this.aname.Location = new System.Drawing.Point(6, 40);
            this.aname.MaxLength = 50;
            this.aname.Name = "aname";
            this.aname.Size = new System.Drawing.Size(153, 22);
            this.aname.TabIndex = 5;
            this.aname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.aname_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Name";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Admin";
            this.Size = new System.Drawing.Size(386, 336);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox adminid;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox auser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button changedetails;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox cnpass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button changepass;
        private System.Windows.Forms.TextBox oldpass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox npass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button changename;
        private System.Windows.Forms.TextBox aname;
        private System.Windows.Forms.Label label9;
    }
}
