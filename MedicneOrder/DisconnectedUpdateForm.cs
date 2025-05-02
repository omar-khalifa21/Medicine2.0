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
    public partial class DisconnectedUpdateForm : Form
    {
        String ordb = "Data Source =ORCL ; User Id=scott; Password=tiger";
        OracleConnection conn;
        OracleDataAdapter adapter;
        DataSet dataset;
        OracleCommandBuilder builder;

        public DisconnectedUpdateForm()
        {
            InitializeComponent();
            conn = new OracleConnection(ordb);
            conn.Open(); // Use the shared DB connection
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                string medicineId = txtMedicineID.Text.Trim();

                if (string.IsNullOrWhiteSpace(medicineId))
                {
                    MessageBox.Show("Please enter a Medicine ID.");
                    return;
                }

                string query = "SELECT * FROM Medicines WHERE MedicineID = :id";

                adapter = new OracleDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.Add("id", OracleDbType.Int32).Value = int.Parse(medicineId);

                dataset = new DataSet();
                adapter.Fill(dataset);

                if (dataset.Tables[0].Rows.Count > 0)
                {
                    DataRow row = dataset.Tables[0].Rows[0];

                    txtName.Text = row["MedicineName"].ToString();
                    txtCategory.Text = row["Category"].ToString();
                    txtPrice.Text = row["Price"].ToString();
                    txtQuantity.Text = row["QuantityInStock"].ToString();
                }
                else
                {
                    MessageBox.Show("Medicine not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataset == null || dataset.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("No medicine loaded to update.");
                    return;
                }

                DataRow row = dataset.Tables[0].Rows[0];

                // Update the row in memory
                row["MedicineName"] = txtName.Text.Trim();
                row["Category"] = txtCategory.Text.Trim();
                row["Price"] = decimal.Parse(txtPrice.Text.Trim());
                row["QuantityInStock"] = int.Parse(txtQuantity.Text.Trim());

                // Automatically generate the Update command
                builder = new OracleCommandBuilder(adapter);

                adapter.Update(dataset);

                MessageBox.Show("Medicine updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DisconnectedUpdateForm_Load(object sender, EventArgs e)
        {

        }
    }
}