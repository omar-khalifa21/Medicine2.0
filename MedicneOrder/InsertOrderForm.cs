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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MedicneOrder
{
    public partial class InsertOrderForm : Form
    {
        string ordb = "Data Source =orcl ; User Id=scott; Password=tiger";
        OracleConnection conn;

        public InsertOrderForm()
        {
            InitializeComponent();
        }

        private void InsertOrderForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "Insert into Orders values (:ordername , :id )";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("ordername", textBox1.Text);
            c.Parameters.Add("id", textBox2.Text);

        }
    }
}
