namespace EmployeeDatabase
{
    partial class Register
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
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.regis = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cpass = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.fullname = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SlateBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(87, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "EMPLOYEE SYSTEM";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 139);
            this.panel1.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SlateBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(87, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "REGISTER";
            // 
            // regis
            // 
            this.regis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regis.Location = new System.Drawing.Point(146, 443);
            this.regis.Name = "regis";
            this.regis.Size = new System.Drawing.Size(134, 40);
            this.regis.TabIndex = 13;
            this.regis.Text = "Create Account";
            this.regis.UseVisualStyleBackColor = true;
            this.regis.Click += new System.EventHandler(this.regis_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Username";
            // 
            // pass
            // 
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.Location = new System.Drawing.Point(206, 270);
            this.pass.MaxLength = 50;
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(186, 26);
            this.pass.TabIndex = 10;
            this.pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pass_KeyDown);
            // 
            // user
            // 
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.Location = new System.Drawing.Point(206, 211);
            this.user.MaxLength = 50;
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(186, 26);
            this.user.TabIndex = 9;
            this.user.KeyDown += new System.Windows.Forms.KeyEventHandler(this.user_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Confirm Password";
            // 
            // cpass
            // 
            this.cpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpass.Location = new System.Drawing.Point(206, 321);
            this.cpass.MaxLength = 50;
            this.cpass.Name = "cpass";
            this.cpass.Size = new System.Drawing.Size(186, 26);
            this.cpass.TabIndex = 11;
            this.cpass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cpass_KeyDown);
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.Location = new System.Drawing.Point(298, 443);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(94, 40);
            this.Cancel.TabIndex = 14;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(101, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Full Name";
            // 
            // fullname
            // 
            this.fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullname.Location = new System.Drawing.Point(206, 378);
            this.fullname.MaxLength = 50;
            this.fullname.Name = "fullname";
            this.fullname.Size = new System.Drawing.Size(186, 26);
            this.fullname.TabIndex = 12;
            this.fullname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fullname_KeyDown);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fullname);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cpass);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.regis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.user);
            this.Name = "Register";
            this.Size = new System.Drawing.Size(500, 500);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button regis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cpass;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fullname;
    }
}
