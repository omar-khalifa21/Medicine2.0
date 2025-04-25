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
    public partial class signup : Form
    {
        String ordb = "Data Source =ORCL ; User Id=scott; Password=tiger";
        OracleConnection conn;
        public signup()
        {
            InitializeComponent();
        }


        private void signup_Load(object sender, EventArgs e)
        {  //open conn
            conn = new OracleConnection(ordb);
            //conn.Open();
            //command

        }
        // Function to get next available 
        private int GetNextUserID()
        {
            string query = "SELECT NVL(MAX(UserID), 0) + 1 FROM Users";
            OracleCommand cmd = new OracleCommand(query, conn);
            conn.Open();
            int nextID = Convert.ToInt32(cmd.ExecuteScalar());
            return nextID;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password =textBox2.Text;
            string email = textBox3.Text;
            string phone = textBox4.Text;

            // Check all fields are filled
            if (string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("All fields are required");
                return;
            }

            try
            {
                // Get next UserID
                int newUserID = GetNextUserID();

                // Insert new user
                string insertSql = @"
                    INSERT INTO Users (UserID, Username, Password, Email, Phone, UserType) 
                    VALUES (:userID, :username, :password, :email, :phone, 'Customer')";

              //  conn.Open();
                OracleCommand cmd = new OracleCommand(insertSql, conn);
                cmd.Parameters.Add("userID", Text).Value = newUserID;
                cmd.Parameters.Add("username", textBox1.Text).Value = username;
                cmd.Parameters.Add("password", textBox2.Text).Value = password;
                cmd.Parameters.Add("email", textBox3.Text).Value = email;
                cmd.Parameters.Add("phone", textBox4.Text).Value = phone;

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show($"Account created! Your User ID is {newUserID}");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating account: " + ex.Message);
            }
            finally
            {
                //if (conn.State == ConnectionState.Open)
                    //conn.Close();
            }
        }

    }
    
}
