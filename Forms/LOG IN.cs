using StudentPart;
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

namespace project_1
{
    public partial class F_LOGIN : Form
    {
        public F_LOGIN()
        {
            InitializeComponent();
        }

        private void B_SingUP_Click(object sender, EventArgs e)
        {
            @switch F1 = new @switch();
            F1.Show();
            this.Hide();
        }

        private void B_LogIN_Click(object sender, EventArgs e)
        {
            string connectionString = Connection.ConnectionText;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string userType = CB_UserType.Text.Trim();
                    string email = TB_Email.Text.Trim();
                    string password = TB_Password.Text;

                    if (userType == "Student")
                    {
                        string query = "SELECT student_id FROM Student WHERE Email = @Email AND Password = @Password";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            int studentId = Convert.ToInt32(result);
                            MessageBox.Show("Login successful!");

                            Form F1 = new StdHome(studentId);
                            F1.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid credentials. Please try again.");
                        }
                    }
                    else if (userType == "Instructor")
                    {
                        string query = "SELECT instructor_id FROM Instructor WHERE Email = @Email AND Password = @Password";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            int instructorId = Convert.ToInt32(result);
                            MessageBox.Show("Login successful!");
                            Form F1 = new TeacherHome(instructorId);
                            F1.Show();
                            this.Hide();

                        }
                        else
                        {
                            MessageBox.Show("Invalid credentials. Please try again.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select a valid user type.");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }


        private void B_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void F_LOGIN_Load(object sender, EventArgs e)
        {

        }
    }
}
