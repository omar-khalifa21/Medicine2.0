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
using static System.Net.Mime.MediaTypeNames;

namespace MedicneOrder
{
    public partial class AdminUserManagementForm : Form
    {

        string ordb = "Data Source =orcl ; User Id=scott; Password=tiger";
        OracleConnection conn;

        public AdminUserManagementForm()
        {
            InitializeComponent();
        }

        private void AdminUserManagementForm_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select UserID from Users";
            cmd.CommandType = CommandType.Text;

            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader[0]);
                
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OracleCommand c = new OracleCommand();
                c.Connection = conn;

                // Fix the SQL statement: Removing extra comma
                c.CommandText = "UPDATE Users SET Username = :name, Email = :email, Phone = :number , Password = :pass , UserType = :type WHERE UserID = :id";
                c.CommandType = CommandType.Text;

                // Adding parameters with correct data types
                c.Parameters.Add("name", OracleDbType.Varchar2).Value = textBox1.Text; // Username
                c.Parameters.Add("email", OracleDbType.Varchar2).Value = textBox2.Text; // Email
                c.Parameters.Add("number", OracleDbType.Varchar2).Value = textBox3.Text; // Phone
                c.Parameters.Add("pass",OracleDbType.Varchar2).Value= textBox5.Text;
                c.Parameters.Add("type", OracleDbType.Varchar2).Value = textBox4.Text;
                c.Parameters.Add("id", OracleDbType.Int32).Value = Convert.ToInt32(comboBox1.SelectedItem.ToString()); // UserID

                // Execute the query
                int r = c.ExecuteNonQuery();
                if (r != -1)
                {
                    MessageBox.Show("User modified successfully.");
                }
                else
                {
                    MessageBox.Show("Error: User not modified.");
                }
            }
            catch (OracleException ex)
            {
                // Catching and displaying Oracle-specific errors
                MessageBox.Show("Oracle error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OracleCommand c = new OracleCommand();
                c.Connection = conn;

                // SQL to delete the user based on UserID
                c.CommandText = "DELETE FROM Users WHERE UserID = :id";

                // Adding the UserID parameter with the correct type
                c.Parameters.Add("id", OracleDbType.Int32).Value = Convert.ToInt32(comboBox1.SelectedItem.ToString()); // Assuming cmb_ID has the UserIDs

                // Execute the command
                int r = c.ExecuteNonQuery();

                // Check if the row was deleted
                if (r > 0)
                {
                    MessageBox.Show("User deleted successfully.");

                    // Remove the selected ID from the combo box
                    comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);

                    // Clear the form controls after successful deletion
                   textBox1.Text = "";
                   textBox2.Text = "";
                   textBox3.Text = "";
                   textBox4.Text = "";
                   textBox5.Text = "";

                }
                else
                {
                    MessageBox.Show("Error: User not deleted.");
                }
            }
            catch (OracleException ex)
            {
                // Catch any Oracle-specific errors
                MessageBox.Show("Oracle error: " + ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select Username , Email,  Phone , UserType , Password  from Users where UserID =:id ";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("id", comboBox1.SelectedItem.ToString());
            OracleDataReader r = c.ExecuteReader();

            if (r.Read()) {
                textBox1.Text = r[0].ToString();
                textBox2.Text = r[1].ToString(); 
                textBox3.Text = r[2].ToString();
                textBox4.Text = r[3].ToString();
                textBox5.Text = r[4].ToString();
                
            
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {

            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "Insert into Users values (:Userid , :name , :pass, :email, :phone, :usertype)";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("Userid", comboBox1.Text);
            c.Parameters.Add("Userid", textBox1.Text);
            c.Parameters.Add("Userid", textBox5.Text);
            c.Parameters.Add("Userid", textBox2.Text);
            c.Parameters.Add("Userid", textBox3.Text);
            c.Parameters.Add("Userid", textBox4.Text);

            int r  = c.ExecuteNonQuery();
            if (r != -1)
            {
                comboBox1.Items.Add(comboBox1.Text);
                MessageBox.Show("User added!!");
            }

        }
    }
}
