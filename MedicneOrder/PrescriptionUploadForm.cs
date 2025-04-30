using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace MedicneOrder
{
    public partial class PrescriptionUploadForm : Form
    {
        public PrescriptionUploadForm()
        {
            InitializeComponent();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select Prescription File";
            openFileDialog.Filter = "PDF Files|.pdf|Image Files|.jpg;.jpeg;.png|All Files|.";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = openFileDialog.FileName;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilePath.Text))
            {
                MessageBox.Show("Please select a file first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            byte[] fileData;
            try
            {
                fileData = File.ReadAllBytes(txtFilePath.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Replace YOUR_CONNECTION_STRING with your database connection string
            string connectionString = "YOUR_CONNECTION_STRING";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Prescriptions (UserID, UploadDate, PrescriptionFile, Status) 
                                 VALUES (@UserID, @UploadDate, @PrescriptionFile, @Status)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@UserID", SqlDbType.Int).Value = 1; // Assuming UserID 1 for now
                    command.Parameters.Add("@UploadDate", SqlDbType.DateTime).Value = DateTime.Now;
                    command.Parameters.Add("@PrescriptionFile", SqlDbType.VarBinary).Value = fileData;
                    command.Parameters.Add("@Status", SqlDbType.VarChar).Value = "Pending";

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Prescription uploaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
