using DVLD;
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
    public partial class studnets_filter : Form
    {
        public studnets_filter()
        {
            InitializeComponent();
        }
        public delegate void dgFillComboBox();
        public static event dgFillComboBox evFillComboBox;

        private DataTable getStudents()
        {
            string query = @"select Student.firstname+' '+Student.lastname as Name , Student.GPA , Student.no_hours , Student.Stage , Student.Email , Course.Code as CourseCode
,Course.Name as CourseName ,Enrollment.CourseGrade, Course.Category ,Exam.Title as ExamTitle, ExamScore.Grade as ExamGrade 
from Student inner join Enrollment on Enrollment.student_id=Student.student_id
inner join Course on Enrollment.course_id=Course.course_id
inner join ExamScore on Student.student_id=ExamScore.student_id
inner join Exam on Exam.exam_id=ExamScore.exam_id";

            DataTable dataTable = new DataTable();
            using (SqlConnection conn = new SqlConnection(Connection.ConnectionText))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        dataTable.Load(reader);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
                finally { conn.Close(); }
                return dataTable;
            }
        }




       

        

        private void studnets_filter_Load(object sender, EventArgs e)
        {
            dgStudents.DataSource = getStudents();
            dgStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgStudents.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Filter.ComboItems = new string[] { "None", "Name", "GPA", "no_hours", "Stage", "Email", "Course Code", "Category", "Exam Title","Exam Grade" };
            
            Filter._AllData = getStudents();

            evFillComboBox();
        }

        private void filter1_evFilterResult(object sender, DataTable e)
        {
            if (e != null)
            {
                dgStudents.DataSource = e;

            }
        }
    }
}
