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
using System.Data.Odbc;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace MedicneOrder
{
    public partial class PrescriptionVerificationForm : Form
    {
        OracleConnection conn;
        OracleDataAdapter adapter;
        DataSet dataset;
        OracleCommandBuilder builder;

        public PrescriptionVerificationForm()
        {
            InitializeComponent();
            conn = DBConnection.GetConnection(); // Assumes you have the same DBConnection helper
            LoadPrescriptions();
            cmbStatus.Items.AddRange(new string[] { "Pending", "Approved", "Rejected" });
        }

        private void LoadPrescriptions()
        {
            try
            {
                string query = "SELECT PrescriptionID, UserID, UploadDate, PatientName, MedicineName, Dosage, Status FROM Prescriptions";
                adapter = new OracleDataAdapter(query, conn);
                builder = new OracleCommandBuilder(adapter);
                dataset = new DataSet();
                adapter.Fill(dataset, "Prescriptions");
                dgvPrescriptions.DataSource = dataset.Tables["Prescriptions"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void dgvPrescriptions_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPrescriptions.SelectedRows.Count > 0)
            {
                string status = dgvPrescriptions.SelectedRows[0].Cells["Status"].Value.ToString();
                cmbStatus.SelectedItem = status;
            }
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (dgvPrescriptions.SelectedRows.Count == 0 || cmbStatus.SelectedItem == null)
            {
                MessageBox.Show("Please select a row and a status.");
                return;
            }

            string selectedPrescriptionID = dgvPrescriptions.SelectedRows[0].Cells["PrescriptionID"].Value.ToString();
            string newStatus = cmbStatus.SelectedItem.ToString();

            foreach (DataRow row in dataset.Tables["Prescriptions"].Rows)
            {
                if (row["PrescriptionID"].ToString() == selectedPrescriptionID)
                {
                    row["Status"] = newStatus;
                    break;
                }
            }

            try
            {
                adapter.Update(dataset, "Prescriptions");
                MessageBox.Show("Status updated successfully.");
                LoadPrescriptions(); // Refresh data
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating status: " + ex.Message);
            }
        }
    }
}