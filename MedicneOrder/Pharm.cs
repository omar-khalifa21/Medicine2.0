using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicneOrder
{
    public partial class Pharm : Form
    {
        String ordb = "Data Source =ORCL ; User Id=scott; Password=tiger";
        OracleConnection conn;
        public Pharm()
        {
            InitializeComponent();
        }

        private void Pharm_Load(object sender, EventArgs e)
        {         //open conn
            conn = new OracleConnection(ordb);
            conn.Open();
            //command
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select inventoryid from inventory";
            c.CommandType = CommandType.Text;
            OracleDataReader r = c.ExecuteReader();
            while (r.Read())
            {
                comboBox1.Items.Add(r["inventoryid"].ToString()); // ✅ Add each inventory ID to combo
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedId = comboBox1.SelectedItem.ToString();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            {
                cmd.CommandText = "SELECT MEDICINEID, LASTUPDATED, QUANTITY FROM INVENTORY WHERE INVENTORYID = :id";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("id", comboBox1.SelectedItem.ToString());
                OracleDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    textBox2.Text = reader["MEDICINEID"].ToString();
                    textBox3.Text = Convert.ToDateTime(reader["LASTUPDATED"]).ToString("yyyy-MM-dd");
                    textBox4.Text = reader["QUANTITY"].ToString();
                }

               // conn.Close();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrescriptionUploadForm form = new PrescriptionUploadForm();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrescriptionVerificationForm form = new PrescriptionVerificationForm(); 
                form.Show();
        }
    }
}

