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
using System.Data.SqlClient;// Library required to connect with SQL Database
using System.IO; // Library required to write text files


namespace Login_form // Defining the namespace for the project
{   
	public partial class Form3 : Form // Defining the Employee Details Form class which inherits from Form
	{   // Creating a SQL Connection object to connect with the database
		private SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-AUC1C8J\SQLEXPRESS;Initial Catalog=Employee;Integrated Security=True");
		// Variable to store the ID of the selected Employee row
		private int id = 0;
		// Constructor - Runs automatically when the Employee Details Form is created
		public Form3()
		{
			InitializeComponent();// Initializes all form controls and components
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
		// Event triggered when the Logout Button is clicked
		private void btnlogout_Click(object sender, EventArgs e)
		{   // Create a new instance of the Login Form
			login lo = new login();
			// Open the Login Form
			lo.Show();
			// Hide the Employee Details Form
			this.Hide();
		}
		// Event triggered when the Employee Details Form loads
		private void Form3_Load(object sender, EventArgs e)
		{   // Load the database table when the form opens
			LoadTBL();	
		}
		// Event triggered when the Add Button is clicked
		private void btnadd_Click(object sender, EventArgs e)
		{   // Open the database connection
			con.Open();
			// Write an INSERT query to add a new record into the Employee Details table
			string sql = "INSERT INTO [Employee Details] (Name,Age,Location,Password) VALUES ('" + tbname.Text + "' , '" + tbage.Text + "' , '" + tblocation.Text + "' , '" + tbpass.Text + "')";
			// Create a SQL Command object to execute the query
			SqlCommand cmd = new SqlCommand(sql, con);
			// Execute the query and get the number of rows affected
			int rowCount = cmd.ExecuteNonQuery();
			// Close the database connection
			con.Close();

			// Check if the record was successfully inserted
			if (rowCount > 0)
			{   // Display success message if data is inserted successfully
				MessageBox.Show("Data Inserted");
				// Refresh the table to show the updated data
				LoadTBL();
				

			}
			else
			{   // Display error message if insertion failed
				MessageBox.Show("Data Can not Insert , Contact admin");
			}
		}
		// Function to load the database table into the DataGridView
		private void LoadTBL()
		{   // Open the database connection
			con.Open();
			// Write a SELECT query to retrieve all records from the Employee Details table
			string sql = "SELECT * FROM [Employee Details]";
			// Create a SqlDataAdapter to fetch data from the database
			SqlDataAdapter nis = new SqlDataAdapter(sql, con);
			// Create a DataTable to store the retrieved data
			DataTable da = new DataTable();
			// Fill the DataTable with data from the database
			nis.Fill(da);
			// Display the data in the DataGridView
			LoadDB.DataSource = da;
			// Close the database connection
			con.Close();
		}


		// Event triggered when a cell in the DataGridView is clicked
		private void LoadDB_CellClick(object sender, DataGridViewCellEventArgs e)
		{   // Get the index of the clicked row
			int RI = e.RowIndex;
			// Get the Employee ID from the first column and store it in the id variable
			id = Convert.ToInt32(LoadDB.Rows[RI].Cells[0].Value.ToString());
			// Display the Employee Name in the Name TextBox
			tbname.Text = LoadDB.Rows[RI].Cells[1].Value.ToString();
			// Display the Employee Age in the Age TextBox
			tbage.Text = LoadDB.Rows[RI].Cells[2].Value.ToString();
			// Display the Employee Location in the Location TextBox
			tblocation.Text = LoadDB.Rows[RI].Cells[3].Value.ToString();
			// Display the Employee Password in the Password TextBox
			tbpass.Text = LoadDB.Rows[RI].Cells[4].Value.ToString();
		}
		// Event triggered when the Delete Button is clicked
		private void btndelete_Click(object sender, EventArgs e)
		{   // Show a confirmation dialog before deleting the record
			if (MessageBox.Show("Do you really wanna Delete?", "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

			{	// Open the database connection
				con.Open();
				// Write a DELETE query to remove the record with the selected ID
				string sql = "DELETE FROM [Employee Details] WHERE ID = " + id +";";
				// Create a SQL Command object to execute the query
				SqlCommand cmd = new SqlCommand(sql, con);
				// Execute the query and get the number of rows affected
				int rowCount = cmd.ExecuteNonQuery();
				// Close the database connection
				con.Close();
				// Check if the record was successfully deleted
				if (rowCount > 0)
				{   // Display success message if data is deleted successfully
					MessageBox.Show("Data Deletion Success");
					// Refresh the table to show the updated data
					LoadTBL();
					

				}
				else
				{   // Display error message if deletion failed
					MessageBox.Show("Data Can not Delete , Contact admin");
				}
			}

		}
		// Event triggered when the Update Button is clicked
		private void btnupdate_Click(object sender, EventArgs e)
		{   // Show a confirmation dialog before updating the record
			if (MessageBox.Show("Do you really wanna update?", "Update confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			
				{	// Open the database connection
					con.Open();
					// Write an UPDATE query to modify the record with the selected ID
					string sql = "UPDATE [Employee Details] SET Name ='" + tbname.Text + "',Age = '" + tbage.Text + "', Location = '" + tblocation.Text + "', Password = '" + tbpass.Text + "' WHERE id = " + id + ";";// ID is int - no quotes needed
					// Create a SQL Command object to execute the query
					SqlCommand cmd = new SqlCommand(sql, con);
					// Execute the query and get the number of rows affected
					int rowCount = cmd.ExecuteNonQuery();
					// Close the database connection
					con.Close();

				// Check if the record was successfully updated
				if (rowCount > 0)
					{
						// Display success message if data is updated successfully
						MessageBox.Show("Data Updated");
						// Refresh the table to show the updated data
						LoadTBL();
						

				}
					else
					{
						// Display error message if update failed
						MessageBox.Show("Data Can not Update  , Contact admin");
					}
				}
			
		}
	}
}
