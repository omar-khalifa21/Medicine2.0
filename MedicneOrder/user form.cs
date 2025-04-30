using Oracle.DataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace MedicneOrder
{
    public partial class Form1 : Form
    {
        private int userId;
        private string ordb = "Data Source=ORCL;User Id=scott;Password=tiger";
        private OracleConnection conn;

        public Form1(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            conn = new OracleConnection(ordb);
            LoadAllData();
        }

        private void LoadAllData()
        {
            try
            {
                conn.Open();

                // 1. Load customer info into textboxes
                string userQuery = "SELECT Username, UserID FROM Users WHERE UserID = :userId";
                OracleCommand userCmd = new OracleCommand(userQuery, conn);
                userCmd.Parameters.Add("userId", OracleDbType.Int32).Value = userId;

                using (OracleDataReader userReader = userCmd.ExecuteReader())
                {
                    if (userReader.Read())
                    {
                        textBox1.Text = userReader["Username"].ToString();
                        textBox2.Text = userReader["UserID"].ToString();
                    }
                }

                // 2. Load order history into dataGridView1
                string ordersQuery = @"SELECT OrderID, OrderDate, TotalAmount, Status 
                                    FROM Orders 
                                    WHERE UserID = :userId
                                    ORDER BY OrderDate DESC";

                OracleDataAdapter adapter = new OracleDataAdapter(ordersQuery, conn);
                adapter.SelectCommand.Parameters.Add("userId", OracleDbType.Int32).Value = userId;

                DataTable ordersTable = new DataTable();
                adapter.Fill(ordersTable);

                dataGridView1.DataSource = ordersTable;

                // Format columns
                dataGridView1.Columns["OrderID"].HeaderText = "Order #";
                dataGridView1.Columns["OrderDate"].HeaderText = "Date";
                dataGridView1.Columns["TotalAmount"].HeaderText = "Amount";
                dataGridView1.Columns["Status"].HeaderText = "Status";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Logout
        }
    }
}