using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AlternativeMedicineFinder
{
	public partial class Form1 : Form
	{
		private string connectionString = "Data Source=xxxxxxx-xxxxxxx\\SQLEXPRESS;Initial Catalog=Medicines;Integrated Security=SSPI;";
		public Form1()
		{
			InitializeComponent();
			InitializeUI(); // Call the method to initialize UI
		}

		// Method to initialize UI
		private void InitializeUI()
		{
			// Customize the search box (textBoxMedicine)
			textBoxMedicine.BackColor = Color.WhiteSmoke;
			textBoxMedicine.ForeColor = Color.Black;
			textBoxMedicine.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Regular);
			textBoxMedicine.BorderStyle = BorderStyle.FixedSingle;
			textBoxMedicine.TextAlign = HorizontalAlignment.Left;

			// Customize the search button (buttonMedicine)
			buttonMedicine.BackColor = Color.SkyBlue;
			buttonMedicine.ForeColor = Color.Black;
			buttonMedicine.Font = new Font("Calibri", 9, FontStyle.Regular);
			buttonMedicine.FlatStyle = FlatStyle.Popup;
			buttonMedicine.Text = "Search";

			// Customize the DataGridView (dataGridView1)
			dataGridView1.BackgroundColor = Color.White;
			dataGridView1.DefaultCellStyle.BackColor = Color.LightBlue; // Set default cell background color
			dataGridView1.DefaultCellStyle.ForeColor = Color.Black; // Set default cell text color
			dataGridView1.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Regular); // Set default cell font
			dataGridView1.GridColor = Color.Black; // Set grid color

			// Customize column headers
			dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkBlue; // Set column header background color
			dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Set column header text color
			dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 10, FontStyle.Bold); // Set column header font

			// Set row height
			dataGridView1.RowTemplate.Height = 30; // Set row height

			// Enable visual styles
			dataGridView1.EnableHeadersVisualStyles = false; // Disable default header styles
			dataGridView1.AllowUserToAddRows = false; // Disable row for new records
		}

		private void buttonMedicine_Click(object sender, EventArgs e)
		{
			string searchTerm = textBoxMedicine.Text.Trim();

			// Validate the search term
			if (string.IsNullOrEmpty(searchTerm))
			{
				MessageBox.Show("Please enter a search term.");
				return;
			}

			// Execute the SQL query to search for medicines with the given name and retrieve other medicines with the same drug
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				string query = @"SELECT m1.MedicinesC AS 'Medicine', 
                                m2.MedicinesC AS 'Alternate Medicines',
                                m1.DrugsC AS 'Medicinal Drug'
                         FROM MedicinesT m1
                         INNER JOIN MedicinesT m2 ON m1.DrugsC = m2.DrugsC
                         WHERE m1.MedicinesC = @SearchTerm
                         AND m2.MedicinesC != @SearchTerm";

				using (SqlCommand command = new SqlCommand(query, connection))
				{
					// Add search term as parameter to prevent SQL injection
					command.Parameters.AddWithValue("@SearchTerm", searchTerm);

					try
					{
						connection.Open();
						SqlDataReader reader = command.ExecuteReader();

						// Bind the search results to the DataGridView control
						DataTable dataTable = new DataTable();
						dataTable.Load(reader);
						dataGridView1.DataSource = dataTable;

						if (dataTable.Rows.Count == 0)
						{
							MessageBox.Show("No matching medicine found.");
						}

						reader.Close();
					}
					catch (Exception ex)
					{
						MessageBox.Show("Error executing SQL query: " + ex.Message);
					}
				}
			}
		}



		private void textBoxMedicine_TextChanged(object sender, EventArgs e)
		{


		}

		private void label1Medicine_Click(object sender, EventArgs e)
		{
			// Your event handling code here
		}

		private void label2Medicine_Click(object sender, EventArgs e)
		{
			// Your event handling code here
		}


	}
}
