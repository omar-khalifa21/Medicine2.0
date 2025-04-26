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

            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "SELECT Name ,Description, Price  ,StockQuantity, Category from Medicines WHERE MEDICINEID  =:id ";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("id", comboBox1.SelectedItem.ToString());
            OracleDataReader r = c.ExecuteReader();

            if (r.Read())
            {
                textBox1.Text = r[0].ToString();
                textBox5.Text = r[1].ToString();
                textBox4.Text = r[2].ToString();
                textBox3.Text = r[2].ToString();
                textBox2.Text = r[2].ToString();


            }

        }
    }
}
