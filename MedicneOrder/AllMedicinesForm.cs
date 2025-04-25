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
        public AllMedicinesForm()
        {
            InitializeComponent();
        }

        private void AllMedicinesForm_Load(object sender, EventArgs e)
        {
            AllMedicinesForm medform = new AllMedicinesForm();
            LoginForm login = new LoginForm();  // Create instance
            login.Show();  // Show the form non-modally
            medform.Hide();  // Optional: hide the login form
        }
    }
}
