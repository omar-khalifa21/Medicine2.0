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
using Oracle.ManagedDataAccess.Client;

namespace MedicneOrder
{
    public partial class PrescriptionVerificationForm : Form
    {
        private SqlDataAdapter dataAdapter;
        private DataSet dataSet;
        private string connectionString = "YOUR_CONNECTION_STRING";

        public PrescriptionVerificationForm()
        {
            InitializeComponent();
        }

        private void PrescriptionVerificationForm_Load(object sender, EventArgs e)
        {
            LoadPrescriptions();
        }

        private void LoadPrescriptions()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                dataAdapter = new SqlDataAdapter("SELECT * FROM Prescriptions", connection);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "Prescriptions");

                dgvPrescriptions.DataSource = dataSet.Tables["Prescriptions"];
            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (dgvPrescriptions.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvPrescriptions.SelectedRows)
                {
                    row.Cells["Status"].Value = "Approved";
                }
            }
            else
            {
                MessageBox.Show("Please select a prescription to approve.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (dgvPrescriptions.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvPrescriptions.SelectedRows)
                {
                    row.Cells["Status"].Value = "Rejected";
                }
            }
            else
            {
                MessageBox.Show("Please select a prescription to reject.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                dataAdapter.Update(dataSet, "Prescriptions");
                MessageBox.Show("Changes saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPrescriptions();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving changes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadPrescriptions();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
