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

namespace MedicneOrder
{
    public partial class LoginForm : Form
    {
        String ordb = "Data Source =ORCL ; User Id=scott; Password=tiger";
        OracleConnection conn;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //open conn
            conn = new OracleConnection(ordb);
            conn.Open();
            //command
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = textBox1.Text;
            string password = textBox2.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password");
                return;
            }

            try
            {
                string query = "SELECT UserID, UserType FROM Users WHERE Username = :username AND Password = :password";

                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add("username", textBox1.Text);
                cmd.Parameters.Add("password", textBox2.Text);

                OracleDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int userId = Convert.ToInt32(reader["UserID"]);
                    string userType = reader["UserType"].ToString();

                    // Open appropriate form based on user type
                    switch (userType)
                    {
                        case "Customer":
                            User user = new User(userId); //3shan el userid
                            user.Show();
                            this.Hide(); // Hide the login form//ya rab yshta8al
                            break;
                        case "Pharmacist":
                            // logic form bta3 pharm
                            break;
                        case "Admin":
                            AdminUserManagementForm adminUserManagementForm = new AdminUserManagementForm();
                            adminUserManagementForm.Show();

                            break;
                        default:
                            MessageBox.Show("Unknown user type");
                            break;
                    }

                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                //  if (conn.State == ConnectionState.Open)
                //    conn.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            signup signup = new signup();  // Create instance
            signup.Show();  // Show the form non-modally
            this.Hide();  // Optional: hide the login form

        }
    }

}


