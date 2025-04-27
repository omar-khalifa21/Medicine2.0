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
    public partial class DisconnectedUpdateForm : Form
    {
        private SqlDataAdapter dataAdapter;
        private DataSet dataSet;
        private string connectionString = "YOUR_CONNECTION_STRING";

        public DisconnectedUpdateForm()
        {
            InitializeComponent();
        }

        private void DisconnectedUpdateForm_Load(object sender, EventArgs e)
        {
            LoadMedicines();
        }

        private void LoadMedicines()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                dataAdapter = new SqlDataAdapter("SELECT * FROM Medicines", connection);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "Medicines");

                dgvMedicines.DataSource = dataSet.Tables["Medicines"];
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                dataAdapter.Update(dataSet, "Medicines");
                MessageBox.Show("Updates saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMedicines();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadMedicines();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
