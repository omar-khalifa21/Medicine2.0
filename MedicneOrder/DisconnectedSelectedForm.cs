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
    public partial class DisconnectedSelectedForm : Form
    {
        OracleConnection conn;
        OracleDataAdapter adapter;
        DataSet dataset;

        public DisconnectedSelectedForm()
        {
            InitializeComponent();
            conn = DBConnection.GetConnection(); // Use the connection helper class
        }

        private void DisconnectedSelectForm_Load(object sender, EventArgs e)
        {
            // Load filter options into the combo box
            cmbFilter.Items.Add("Name");
            cmbFilter.Items.Add("Category");
            cmbFilter.SelectedIndex = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = txtSearch.Text.Trim();

                if (string.IsNullOrWhiteSpace(searchTerm))
                {
                    MessageBox.Show("Please enter a search term.");
                    return;
                }

                string selectedFilter = cmbFilter.SelectedItem.ToString();
                string query = "";

                if (selectedFilter == "Name")
                {
                    query = "SELECT MedicineID, MedicineName, Category, Price, QuantityInStock FROM Medicines WHERE LOWER(MedicineName) LIKE :searchTerm";
                }
                else if (selectedFilter == "Category")
                {
                    query = "SELECT MedicineID, MedicineName, Category, Price, QuantityInStock FROM Medicines WHERE LOWER(Category) LIKE :searchTerm";
                }

                adapter = new OracleDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.Add("searchTerm", "%" + searchTerm.ToLower() + "%");

                dataset = new DataSet();
                adapter.Fill(dataset);

                dgvResults.DataSource = dataset.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}