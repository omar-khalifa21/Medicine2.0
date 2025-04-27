using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Windows.Forms.VisualStyles;

namespace MedicneOrder
{
    public partial class InsertOrderForm : Form
    {
        string ordb = "Data Source =orcl ; User Id=HR; Password=hr";
        OracleConnection conn;
        public InsertOrderForm()
        {
            InitializeComponent();
        }

        private void InsertOrderForm_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select USERID from Users";
            cmd.CommandType = CommandType.Text;

            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader[0]);

            }

            cmd.CommandText = "Select MedicineID from Medicines ";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr[0]);

            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null ||
                string.IsNullOrEmpty(textBoxAmount.Text) ||
                string.IsNullOrEmpty(textBoxStatus.Text) ||
                string.IsNullOrEmpty(textBoxDate.Text))
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            // Generate new OrderID
            cmd.CommandText = "SELECT NVL(MAX(OrderID), 0) + 1 FROM Orders";
            int newOrderId = Convert.ToInt32(cmd.ExecuteScalar());

            // Insert the order
            cmd.CommandText = "INSERT INTO Orders (OrderID, UserID, OrderDate, TotalAmount, Status) " +
                              "VALUES (:id, :userid, :orderdate, :totalamount, :status)";

            cmd.Parameters.Clear();
            cmd.Parameters.Add("id", newOrderId);
            cmd.Parameters.Add("userid", comboBox1.SelectedItem);

            // Get the date from the textbox
            cmd.Parameters.Add("orderdate", Convert.ToDateTime(textBox1.Text));

            cmd.Parameters.Add("totalamount", Convert.ToDecimal(textBox3.Text));
            cmd.Parameters.Add("status", textBox2.Text);

            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
            {
                MessageBox.Show("Order inserted successfully!");
            }
            else
            {
                MessageBox.Show("Insertion failed.");
            }
        }

    }
}
