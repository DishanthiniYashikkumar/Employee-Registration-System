namespace Login_form
{
	partial class Form3
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tbpass = new System.Windows.Forms.TextBox();
			this.tblocation = new System.Windows.Forms.TextBox();
			this.tbage = new System.Windows.Forms.TextBox();
			this.tbname = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.LoadDB = new System.Windows.Forms.DataGridView();
			this.btnadd = new System.Windows.Forms.Button();
			this.btndelete = new System.Windows.Forms.Button();
			this.btnlogout = new System.Windows.Forms.Button();
			this.btnupdate = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.LoadDB)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.pictureBox1.Location = new System.Drawing.Point(0, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(778, 155);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(219, 102);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(374, 32);
			this.label1.TabIndex = 1;
			this.label1.Text = "Employee Registration Details";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tbpass);
			this.groupBox1.Controls.Add(this.tblocation);
			this.groupBox1.Controls.Add(this.tbage);
			this.groupBox1.Controls.Add(this.tbname);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(12, 182);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(766, 217);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Employee Details";
			// 
			// tbpass
			// 
			this.tbpass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbpass.Location = new System.Drawing.Point(187, 166);
			this.tbpass.Name = "tbpass";
			this.tbpass.Size = new System.Drawing.Size(527, 30);
			this.tbpass.TabIndex = 7;
			// 
			// tblocation
			// 
			this.tblocation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tblocation.Location = new System.Drawing.Point(187, 118);
			this.tblocation.Name = "tblocation";
			this.tblocation.Size = new System.Drawing.Size(527, 30);
			this.tblocation.TabIndex = 6;
			// 
			// tbage
			// 
			this.tbage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbage.Location = new System.Drawing.Point(187, 65);
			this.tbage.Name = "tbage";
			this.tbage.Size = new System.Drawing.Size(527, 30);
			this.tbage.TabIndex = 5;
			// 
			// tbname
			// 
			this.tbname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbname.Location = new System.Drawing.Point(187, 17);
			this.tbname.Name = "tbname";
			this.tbname.Size = new System.Drawing.Size(527, 30);
			this.tbname.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(16, 171);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(109, 25);
			this.label5.TabIndex = 3;
			this.label5.Text = "Password";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(16, 123);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 25);
			this.label4.TabIndex = 2;
			this.label4.Text = "Location";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(16, 65);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 25);
			this.label3.TabIndex = 1;
			this.label3.Text = "Age";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(16, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 25);
			this.label2.TabIndex = 0;
			this.label2.Text = "Name";
			// 
			// LoadDB
			// 
			this.LoadDB.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
			this.LoadDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.LoadDB.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.LoadDB.Location = new System.Drawing.Point(12, 484);
			this.LoadDB.Name = "LoadDB";
			this.LoadDB.RowHeadersWidth = 51;
			this.LoadDB.RowTemplate.Height = 24;
			this.LoadDB.Size = new System.Drawing.Size(766, 188);
			this.LoadDB.TabIndex = 3;
			this.LoadDB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LoadDB_CellClick);
			this.LoadDB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// btnadd
			// 
			this.btnadd.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnadd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnadd.Location = new System.Drawing.Point(121, 418);
			this.btnadd.Name = "btnadd";
			this.btnadd.Size = new System.Drawing.Size(102, 38);
			this.btnadd.TabIndex = 4;
			this.btnadd.Text = "Add";
			this.btnadd.UseVisualStyleBackColor = false;
			this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
			// 
			// btndelete
			// 
			this.btndelete.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btndelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btndelete.Location = new System.Drawing.Point(651, 418);
			this.btndelete.Name = "btndelete";
			this.btndelete.Size = new System.Drawing.Size(107, 38);
			this.btndelete.TabIndex = 6;
			this.btndelete.Text = "Delete";
			this.btndelete.UseVisualStyleBackColor = false;
			this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
			// 
			// btnlogout
			// 
			this.btnlogout.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnlogout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnlogout.Location = new System.Drawing.Point(651, 678);
			this.btnlogout.Name = "btnlogout";
			this.btnlogout.Size = new System.Drawing.Size(107, 45);
			this.btnlogout.TabIndex = 7;
			this.btnlogout.Text = "Logout";
			this.btnlogout.UseVisualStyleBackColor = false;
			this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
			// 
			// btnupdate
			// 
			this.btnupdate.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnupdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnupdate.Location = new System.Drawing.Point(372, 418);
			this.btnupdate.Name = "btnupdate";
			this.btnupdate.Size = new System.Drawing.Size(112, 38);
			this.btnupdate.TabIndex = 8;
			this.btnupdate.Text = "Update";
			this.btnupdate.UseVisualStyleBackColor = false;
			this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.MidnightBlue;
			this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox2.Location = new System.Drawing.Point(360, 34);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(79, 65);
			this.pictureBox2.TabIndex = 9;
			this.pictureBox2.TabStop = false;
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(803, 735);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.btnupdate);
			this.Controls.Add(this.btnlogout);
			this.Controls.Add(this.btndelete);
			this.Controls.Add(this.btnadd);
			this.Controls.Add(this.LoadDB);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form3";
			this.Text = "Employee Registration Form";
			this.Load += new System.EventHandler(this.Form3_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.LoadDB)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbpass;
		private System.Windows.Forms.TextBox tblocation;
		private System.Windows.Forms.TextBox tbage;
		private System.Windows.Forms.TextBox tbname;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView LoadDB;
		private System.Windows.Forms.Button btnadd;
		private System.Windows.Forms.Button btndelete;
		private System.Windows.Forms.Button btnlogout;
		private System.Windows.Forms.Button btnupdate;
		private System.Windows.Forms.PictureBox pictureBox2;
	}
}