using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_form
{
	public partial class login : Form
	{
		public login()
		{
			InitializeComponent();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{ }

		//Hide password when form loads
		private void login_Load(object sender, EventArgs e)
		{
			tbpassword.PasswordChar = '*';
		}

		//Toggle show/hide password
		private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
		{
			if (chkShowPassword.Checked)
				tbpassword.PasswordChar = '\0';  // Show plain text
			else
				tbpassword.PasswordChar = '*';   // Hide again
		}

		private void BTNnum1_Click(object sender, EventArgs e)
		{
			if (tbusername.Text == "admin" && tbpassword.Text == "@123")
			{
				MessageBox.Show("Successfully Signed In ✨");
				Form3 Emp = new Form3();
				Emp.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Invalid User Name or Password");
			}
		}

		private void BTNnum2_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show(
			"Are you sure, Do you really want to Exit...?",
			"Exit",
			MessageBoxButtons.YesNo,
			MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private void BTNnum3_Click(object sender, EventArgs e)
		{
			About form2 = new About();
			form2.Show();
			this.Hide();
		}

		private void LBLnum2_Click(object sender, EventArgs e)
		{ }

		private void pictureBox1_Click(object sender, EventArgs e)
		{ }

		private void tbpassword_TextChanged(object sender, EventArgs e)
		{ }

		private void chkShowPassword_CheckedChanged_1(object sender, EventArgs e)
		{
			if (chkShowPassword.Checked)
				tbpassword.PasswordChar = '\0';  // Show plain text
			else
				tbpassword.PasswordChar = '*';   // Hide again
		}
	}
}