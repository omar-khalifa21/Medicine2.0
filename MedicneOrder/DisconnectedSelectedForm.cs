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
        private SqlDataAdapter dataAdapter;
        private DataSet dataSet;
        private string connectionString = "YOUR_CONNECTION_STRING";

        public DisconnectedSelectedForm()
        {
            InitializeComponent();
        }

        private void DisconnectedSelectedForm_Load(object sender, EventArgs e)
        {
            LoadMedicines();
        }

        private void LoadMedicines()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                dataAdapter = new SqlDataAdapter("SELECT MedicineID, Name, Price, StockQuantity FROM Medicines", connection);
                dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "Medicines");

                dgvSelectedMedicines.DataSource = dataSet.Tables["Medicines"];
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
