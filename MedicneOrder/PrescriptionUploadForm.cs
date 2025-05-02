using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.Odbc;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace MedicneOrder
{
    public partial class PrescriptionUploadForm : Form
    {
        String ordb = "Data Source =ORCL ; User Id=scott; Password=tiger";

        OracleConnection conn;
        OracleDataAdapter adapter;
        DataSet dataset;
        OracleCommandBuilder builder;

        public PrescriptionUploadForm()
        {
            InitializeComponent();
            conn = new OracleConnection(ordb);
            conn.Open(); // Your DB connection method
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                string prescriptionID = txtPrescriptionID.Text.Trim();
                string userID = txtUserID.Text.Trim();
                DateTime uploadDate = dateTimePickerUploadDate.Value;
                string patientName = txtPatientName.Text.Trim();
                string medicineName = txtMedicineName.Text.Trim();
                string dosage = txtDosage.Text.Trim();

                if (string.IsNullOrWhiteSpace(prescriptionID) ||
                    string.IsNullOrWhiteSpace(userID) ||
                    string.IsNullOrWhiteSpace(patientName) ||
                    string.IsNullOrWhiteSpace(medicineName) ||
                    string.IsNullOrWhiteSpace(dosage))
                {
                    MessageBox.Show("Please fill all fields.");
                    return;
                }

                string query = "SELECT * FROM Prescriptions";

                adapter = new OracleDataAdapter(query, conn);
                builder = new OracleCommandBuilder(adapter);

                dataset = new DataSet();
                adapter.Fill(dataset, "Prescriptions");

                DataRow newRow = dataset.Tables["Prescriptions"].NewRow();
                newRow["PrescriptionID"] = prescriptionID;
                newRow["UserID"] = userID;
                newRow["UploadDate"] = uploadDate;
                newRow["PatientName"] = patientName;
                newRow["MedicineName"] = medicineName;
                newRow["Dosage"] = dosage;
                newRow["Status"] = "Pending";

                dataset.Tables["Prescriptions"].Rows.Add(newRow);
                adapter.Update(dataset, "Prescriptions");

                MessageBox.Show("Prescription uploaded successfully!");
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ClearFields()
        {
            txtPrescriptionID.Clear();
            txtUserID.Clear();
            dateTimePickerUploadDate.Value = DateTime.Now;
            txtPatientName.Clear();
            txtMedicineName.Clear();
            txtDosage.Clear();
        }

        private void PrescriptionUploadForm_Load(object sender, EventArgs e)
        {

        }
    }
}
