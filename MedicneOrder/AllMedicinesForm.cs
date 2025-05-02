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

        string ordb = "Data Source =orcl ; User Id=scott; Password=tiger";
        OracleConnection conn;
        public AllMedicinesForm()
        {
            InitializeComponent();
        }

        private void AllMedicinesForm_Load(object sender, EventArgs e)
        {
            AllMedicinesForm medform = new AllMedicinesForm();
            LoginForm login = new LoginForm();  // Create instance
 login.Show();  

        }
    }
}
