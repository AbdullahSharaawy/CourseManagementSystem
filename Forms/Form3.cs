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

namespace StudentPart
{
    public partial class RegistedCrss : Form
    {
        public RegistedCrss()
        {
            InitializeComponent();
            SqlConnection connection = new SqlConnection("Server=.;DataBase=MinyUniversity;Integrated Security=True");
            connection.Open();
            if (!connection.State.Equals(ConnectionState.Open))
            {
                MessageBox.Show("Connection failed");
                return;
            }
            string query = @"select Student.firstname+' '+Student.lastname as Name , Student.GPA , Student.no_hours , Student.Stage , Student.Email , Course.Code as CourseCode
,Course.Name as CourseName ,Enrollment.CourseGrade, Course.Category ,Exam.Title as ExamTitle, ExamScore.Grade as ExamGrade 
from Student inner join Enrollment on Enrollment.student_id=Student.student_id
inner join Course on Enrollment.course_id=Course.course_id
inner join ExamScore on Student.student_id=ExamScore.student_id
inner join Exam on Exam.exam_id=ExamScore.exam_id";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            if(reader.HasRows)
            {
                dataTable.Load(reader);
                dataGridView1.DataSource = dataTable;
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            else
            {
                MessageBox.Show("No data found");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
