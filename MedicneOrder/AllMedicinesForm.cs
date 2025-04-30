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
    public partial class AllMedicinesForm : Form
    {

        string ordb = "Data Source =orcl ; User Id=HR; Password=hr";
        OracleConnection conn;
        public AllMedicinesForm()
        {
            InitializeComponent();
        }

        private void AllMedicinesForm_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GetInventory";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("result_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

            try
            {
                OracleDataReader reader = cmd.ExecuteReader();

                // Clear and setup DataGridView
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    dataGridView1.Columns.Add(reader.GetName(i), reader.GetName(i));
                }

                while (reader.Read())
                {
                    object[] row = new object[reader.FieldCount];
                    reader.GetValues(row);
                    dataGridView1.Rows.Add(row);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading inventory: " + ex.Message);
            }
        
    }

        private void AllMedicinesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (conn != null && conn.State == ConnectionState.Open)
                conn.Close();
        }
    }
}
