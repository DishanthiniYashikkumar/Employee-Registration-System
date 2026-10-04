namespace Login_form
{
	partial class login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
			this.LBLnum2 = new System.Windows.Forms.Label();
			this.LBLnum3 = new System.Windows.Forms.Label();
			this.tbusername = new System.Windows.Forms.TextBox();
			this.tbpassword = new System.Windows.Forms.TextBox();
			this.BTNnum1 = new System.Windows.Forms.Button();
			this.BTNnum2 = new System.Windows.Forms.Button();
			this.BTNnum3 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.chkShowPassword = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// LBLnum2
			// 
			this.LBLnum2.AutoSize = true;
			this.LBLnum2.Location = new System.Drawing.Point(195, 240);
			this.LBLnum2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.LBLnum2.Name = "LBLnum2";
			this.LBLnum2.Size = new System.Drawing.Size(130, 25);
			this.LBLnum2.TabIndex = 2;
			this.LBLnum2.Text = "User Name ";
			this.LBLnum2.Click += new System.EventHandler(this.LBLnum2_Click);
			// 
			// LBLnum3
			// 
			this.LBLnum3.AutoSize = true;
			this.LBLnum3.Location = new System.Drawing.Point(195, 333);
			this.LBLnum3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.LBLnum3.Name = "LBLnum3";
			this.LBLnum3.Size = new System.Drawing.Size(109, 25);
			this.LBLnum3.TabIndex = 3;
			this.LBLnum3.Text = "Password";
			// 
			// tbusername
			// 
			this.tbusername.Location = new System.Drawing.Point(200, 278);
			this.tbusername.Name = "tbusername";
			this.tbusername.Size = new System.Drawing.Size(381, 34);
			this.tbusername.TabIndex = 4;
			this.tbusername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// tbpassword
			// 
			this.tbpassword.Location = new System.Drawing.Point(200, 378);
			this.tbpassword.Name = "tbpassword";
			this.tbpassword.Size = new System.Drawing.Size(381, 34);
			this.tbpassword.TabIndex = 5;
			this.tbpassword.TextChanged += new System.EventHandler(this.tbpassword_TextChanged);
			// 
			// BTNnum1
			// 
			this.BTNnum1.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.BTNnum1.Location = new System.Drawing.Point(141, 455);
			this.BTNnum1.Name = "BTNnum1";
			this.BTNnum1.Size = new System.Drawing.Size(93, 41);
			this.BTNnum1.TabIndex = 6;
			this.BTNnum1.Text = "Login";
			this.BTNnum1.UseVisualStyleBackColor = false;
			this.BTNnum1.Click += new System.EventHandler(this.BTNnum1_Click);
			// 
			// BTNnum2
			// 
			this.BTNnum2.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.BTNnum2.Location = new System.Drawing.Point(544, 455);
			this.BTNnum2.Name = "BTNnum2";
			this.BTNnum2.Size = new System.Drawing.Size(95, 41);
			this.BTNnum2.TabIndex = 7;
			this.BTNnum2.Text = "Exit";
			this.BTNnum2.UseVisualStyleBackColor = false;
			this.BTNnum2.Click += new System.EventHandler(this.BTNnum2_Click);
			// 
			// BTNnum3
			// 
			this.BTNnum3.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.BTNnum3.Location = new System.Drawing.Point(331, 456);
			this.BTNnum3.Name = "BTNnum3";
			this.BTNnum3.Size = new System.Drawing.Size(103, 40);
			this.BTNnum3.TabIndex = 8;
			this.BTNnum3.Text = "About";
			this.BTNnum3.UseVisualStyleBackColor = false;
			this.BTNnum3.Click += new System.EventHandler(this.BTNnum3_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(234, 167);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(357, 22);
			this.label2.TabIndex = 11;
			this.label2.Text = "Ender your credentials to access the system ";
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.pictureBox2.Location = new System.Drawing.Point(1, -2);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(802, 166);
			this.pictureBox2.TabIndex = 12;
			this.pictureBox2.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label3.Location = new System.Drawing.Point(351, 119);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(83, 25);
			this.label3.TabIndex = 13;
			this.label3.Text = "Sign In";
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackColor = System.Drawing.Color.MidnightBlue;
			this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
			this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox3.Location = new System.Drawing.Point(347, 34);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(87, 72);
			this.pictureBox3.TabIndex = 14;
			this.pictureBox3.TabStop = false;
			// 
			// chkShowPassword
			// 
			this.chkShowPassword.AutoSize = true;
			this.chkShowPassword.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkShowPassword.Location = new System.Drawing.Point(200, 421);
			this.chkShowPassword.Name = "chkShowPassword";
			this.chkShowPassword.Size = new System.Drawing.Size(135, 23);
			this.chkShowPassword.TabIndex = 15;
			this.chkShowPassword.Text = "Show password";
			this.chkShowPassword.UseVisualStyleBackColor = true;
			this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged_1);
			// 
			// login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(806, 593);
			this.Controls.Add(this.chkShowPassword);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.BTNnum3);
			this.Controls.Add(this.BTNnum2);
			this.Controls.Add(this.BTNnum1);
			this.Controls.Add(this.tbpassword);
			this.Controls.Add(this.tbusername);
			this.Controls.Add(this.LBLnum3);
			this.Controls.Add(this.LBLnum2);
			this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.Black;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "login";
			this.Text = "Employee Registration System - Login";
			this.Load += new System.EventHandler(this.login_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label LBLnum2;
		private System.Windows.Forms.Label LBLnum3;
		private System.Windows.Forms.TextBox tbusername;
		private System.Windows.Forms.TextBox tbpassword;
		private System.Windows.Forms.Button BTNnum1;
		private System.Windows.Forms.Button BTNnum2;
		private System.Windows.Forms.Button BTNnum3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.CheckBox chkShowPassword;
	}
}

