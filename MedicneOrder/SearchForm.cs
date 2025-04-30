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

namespace MedicneOrder
{
    public partial class SearchForm : Form
    {
        string ordb = "Data Source =orcl ; User Id=HR; Password=hr";
        OracleConnection conn;
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select MedicineID from Medicines ";
            cmd.CommandType = CommandType.Text;

            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader[0]);

            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {




        }

        

        private void button1_Click(object sender, EventArgs e)
        {

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GetMedicineByID";
            cmd.CommandType = CommandType.StoredProcedure;

            // Input parameter
            cmd.Parameters.Add("p_id", OracleDbType.Int32).Value = int.Parse(comboBox1.SelectedItem.ToString());

            // Output parameters
            cmd.Parameters.Add("p_name", OracleDbType.Varchar2, 100).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("p_description", OracleDbType.Varchar2, 200).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("p_price", OracleDbType.Decimal).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("p_stock", OracleDbType.Int32).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("p_category", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;

            try
            {
                cmd.ExecuteNonQuery();

                if (cmd.Parameters["p_name"].Value != DBNull.Value)
                {
                    textBox1.Text = cmd.Parameters["p_name"].Value.ToString();
                    textBox5.Text = cmd.Parameters["p_description"].Value.ToString();
                    textBox4.Text = cmd.Parameters["p_price"].Value.ToString();
                    textBox3.Text = cmd.Parameters["p_stock"].Value.ToString();
                    textBox2.Text = cmd.Parameters["p_category"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("No medicine found for the selected ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}
