// Importing required system libraries for the application
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Defining the namespace for the project
namespace Login_form
{   // Defining the About Form class which inherits from Form
	public partial class About : Form
	{   // Constructor - Runs automatically when the About Form is created
		public About()
		{   // Initializes all form controls and components
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		// Event triggered when the Close Button is clicked
		private void btnclose_Click(object sender, EventArgs e)
		{   // Create a new instance of the Login Form
			login log = new login();
			// Open the Login Form
			log.Show();
			// Hide the About Form
			this.Hide();
		}
	}
}
