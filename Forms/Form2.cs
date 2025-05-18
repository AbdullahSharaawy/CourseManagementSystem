using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentPart
{
    public partial class RegistCrs : Form
    {
        public RegistCrs()
        {
            InitializeComponent();
            SqlConnection connection = new SqlConnection("Server=.;DataBase=MinyUniversity;Integrated Security=True");
            connection.Open();
            if (!connection.State.Equals(ConnectionState.Open))
            {
                MessageBox.Show("Connection failed");
                return;
            }
            string query = "SELECT Name, Code FROM Course";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string courseName = reader["Name"].ToString();
                string courseCode = reader["Code"].ToString();
                string course = courseName + ", (" + courseCode + ")";
                cbCourseName.Items.Add(course);
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Server=.;DataBase=MinyUniversity;Integrated Security=True");
            connection.Open();
            if(cbCourseName.SelectedItem != null || textBox1.Text == null)
            {
                string course = cbCourseName.SelectedItem.ToString();
                string[] parts = course.Split(',');
                string courseCode = parts[1].Trim().TrimStart('(').TrimEnd(')');

                string query = "SELECT course_id FROM Course WHERE Code = @courseCode";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@courseCode", courseCode);
                SqlDataReader reader = command.ExecuteReader();

                string courseID = "";
                if (reader.Read())
                {
                    courseID = reader["course_id"].ToString();
                    MessageBox.Show($"Course ID: {courseID}");
                }
                reader.Close();
                MessageBox.Show(dateTimePicker1.Value.ToShortDateString());
                string query2 = $"insert into Enrollment(student_id, course_id, EnrollmentDate) values('{textBox1.Text}', '{courseID}', '{dateTimePicker1.Value.ToShortDateString()}')";
                SqlCommand command2 = new SqlCommand(query2, connection);
                try
                {
                    command2.ExecuteNonQuery();
                    MessageBox.Show("Enrollment successful");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Enrollment failed: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a course and enter a student ID.");
            }
        }

        private void cbCourseName_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
