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
    public partial class TeacherHome : Form
    {
        private int _instructorId;
        string connectionString = @"Server=.; Database=CourseManagementSystem; Integrated Security=True;";

        public TeacherHome(int instructorId)
        {
            InitializeComponent();
            _instructorId = instructorId;
        }

        private void TeacherHome_Load(object sender, EventArgs e)
        {
            // Set up placeholder text for all textboxes
            AttachPlaceholderHandlers(TB_Name, "Course Name");
            AttachPlaceholderHandlers(TB_Code, "Course Code");
            AttachPlaceholderHandlers(TB_Category, "Category");
            AttachPlaceholderHandlers(TB_Semester, "Semester");
            AttachPlaceholderHandlers(TB_StudyingYear, "Studying Year");
            AttachPlaceholderHandlers(TB_Hours, "Number of Hours");
            AttachPlaceholderHandlers(TB_ExamNumber, "Exam Number");
            AttachPlaceholderHandlers(TB_ExamTitle, "Exam Title");
            AttachPlaceholderHandlers(TB_ExamDescription, "Exam Description");
            AttachPlaceholderHandlers(TB_MaxMark, "Max Mark");

            // Load courses
            LoadInstructorCourses();
        }

        private void AttachPlaceholderHandlers(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = Color.Gray;

            textBox.Enter += (s, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };

            textBox.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = Color.Gray;
                }
            };
        }

        private void LoadInstructorCourses()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT course_id, Name FROM Course WHERE instructor_id = @InstructorID AND is_Active = 1";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@InstructorID", _instructorId);

                    SqlDataReader reader = cmd.ExecuteReader();
                    CB_Courses.Items.Clear();

                    while (reader.Read())
                    {
                        CB_Courses.Items.Add($"{reader["course_id"]} - {reader["Name"]}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading courses: " + ex.Message);
                }
            }
        }

        private void B_AddCourse_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (IsPlaceholderOrEmpty(TB_Name) || IsPlaceholderOrEmpty(TB_Code) ||
                IsPlaceholderOrEmpty(TB_Category) || IsPlaceholderOrEmpty(TB_Semester) ||
                IsPlaceholderOrEmpty(TB_StudyingYear) || IsPlaceholderOrEmpty(TB_Hours))
            {
                MessageBox.Show("Please fill in all course fields.");
                return;
            }

            // Validate that Hours is a number
            if (!int.TryParse(TB_Hours.Text, out int hours))
            {
                MessageBox.Show("Number of Hours must be a valid number.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = @"INSERT INTO Course (Name, Code, Category, Semester, StudyingYear, no_hours, is_Active, instructor_id)
                                     VALUES (@Name, @Code, @Category, @Semester, @StudyingYear, @NoHours, 1, @InstructorID)";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@Name", TB_Name.Text);
                    cmd.Parameters.AddWithValue("@Code", TB_Code.Text);
                    cmd.Parameters.AddWithValue("@Category", TB_Category.Text);
                    cmd.Parameters.AddWithValue("@Semester", TB_Semester.Text);
                    cmd.Parameters.AddWithValue("@StudyingYear", TB_StudyingYear.Text);
                    cmd.Parameters.AddWithValue("@NoHours", hours);
                    cmd.Parameters.AddWithValue("@InstructorID", _instructorId);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Course added successfully!");

                    // Clear fields and reload courses
                    ClearCourseFields();
                    LoadInstructorCourses();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding course: " + ex.Message);
                }
            }
        }

        private void B_UpdateCourse_Click(object sender, EventArgs e)
        {
            if (CB_Courses.SelectedItem == null)
            {
                MessageBox.Show("Please select a course.");
                return;
            }

            // Validate input fields
            if (IsPlaceholderOrEmpty(TB_Name) || IsPlaceholderOrEmpty(TB_Code) ||
                IsPlaceholderOrEmpty(TB_Category) || IsPlaceholderOrEmpty(TB_Semester) ||
                IsPlaceholderOrEmpty(TB_StudyingYear) || IsPlaceholderOrEmpty(TB_Hours))
            {
                MessageBox.Show("Please fill in all course fields.");
                return;
            }

            // Validate that Hours is a number
            if (!int.TryParse(TB_Hours.Text, out int hours))
            {
                MessageBox.Show("Number of Hours must be a valid number.");
                return;
            }

            int courseId = int.Parse(CB_Courses.SelectedItem.ToString().Split('-')[0].Trim());

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = @"UPDATE Course SET Name = @Name, Code = @Code, Category = @Category, 
                                     Semester = @Semester, StudyingYear = @StudyingYear, no_hours = @NoHours
                                     WHERE course_id = @CourseId AND instructor_id = @InstructorID";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@CourseId", courseId);
                    cmd.Parameters.AddWithValue("@Name", TB_Name.Text);
                    cmd.Parameters.AddWithValue("@Code", TB_Code.Text);
                    cmd.Parameters.AddWithValue("@Category", TB_Category.Text);
                    cmd.Parameters.AddWithValue("@Semester", TB_Semester.Text);
                    cmd.Parameters.AddWithValue("@StudyingYear", TB_StudyingYear.Text);
                    cmd.Parameters.AddWithValue("@NoHours", hours);
                    cmd.Parameters.AddWithValue("@InstructorID", _instructorId);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Course updated successfully!");
                        LoadInstructorCourses();
                    }
                    else
                    {
                        MessageBox.Show("Update failed. Course may no longer exist or you don't have permission.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating course: " + ex.Message);
                }
            }
        }

        private void B_HideCourse_Click(object sender, EventArgs e)
        {
            if (CB_Courses.SelectedItem == null)
            {
                MessageBox.Show("Please select a course.");
                return;
            }

            int courseId = int.Parse(CB_Courses.SelectedItem.ToString().Split('-')[0].Trim());

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "UPDATE Course SET is_Active = 0 WHERE course_id = @CourseId AND instructor_id = @InstructorID";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@CourseId", courseId);
                    cmd.Parameters.AddWithValue("@InstructorID", _instructorId);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Course hidden successfully.");
                        LoadInstructorCourses();
                        ClearCourseFields();
                    }
                    else
                    {
                        MessageBox.Show("Failed to hide course. Course may no longer exist or you don't have permission.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error hiding course: " + ex.Message);
                }
            }
        }

        private void B_AddExam_Click(object sender, EventArgs e)
        {
            if (CB_Courses.SelectedItem == null)
            {
                MessageBox.Show("Please select a course.");
                return;
            }

            // Validate exam fields
            if (IsPlaceholderOrEmpty(TB_ExamNumber) || IsPlaceholderOrEmpty(TB_ExamTitle) ||
                IsPlaceholderOrEmpty(TB_ExamDescription) || IsPlaceholderOrEmpty(TB_MaxMark))
            {
                MessageBox.Show("Please fill in all exam fields.");
                return;
            }

            // Validate that ExamNumber and MaxMark are numbers
            if (!int.TryParse(TB_ExamNumber.Text, out int examNumber))
            {
                MessageBox.Show("Exam Number must be a valid number.");
                return;
            }

            if (!int.TryParse(TB_MaxMark.Text, out int maxMark))
            {
                MessageBox.Show("Max Mark must be a valid number.");
                return;
            }

            // Validate dates
            if (DTP_End.Value <= DTP_Start.Value)
            {
                MessageBox.Show("End date must be after start date.");
                return;
            }

            int courseId = int.Parse(CB_Courses.SelectedItem.ToString().Split('-')[0].Trim());

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = @"INSERT INTO Exam (ExamNumber, Title, Description, MaxMark, StartDate, EndDate, course_id)
                                     VALUES (@ExamNumber, @Title, @Description, @MaxMark, @StartDate, @EndDate, @CourseId)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ExamNumber", examNumber);
                    cmd.Parameters.AddWithValue("@Title", TB_ExamTitle.Text);
                    cmd.Parameters.AddWithValue("@Description", TB_ExamDescription.Text);
                    cmd.Parameters.AddWithValue("@MaxMark", maxMark);
                    cmd.Parameters.AddWithValue("@StartDate", DTP_Start.Value);
                    cmd.Parameters.AddWithValue("@EndDate", DTP_End.Value);
                    cmd.Parameters.AddWithValue("@CourseId", courseId);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Exam added successfully!");
                    ClearExamFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding exam: " + ex.Message);
                }
            }
        }

        // Helper methods for field validation and clearing
        private bool IsPlaceholderOrEmpty(TextBox textBox)
        {
            return string.IsNullOrWhiteSpace(textBox.Text) ||
                   textBox.ForeColor == Color.Gray;
        }

        private void ClearCourseFields()
        {
            // Reset course fields to placeholders
            AttachPlaceholderHandlers(TB_Name, "Course Name");
            AttachPlaceholderHandlers(TB_Code, "Course Code");
            AttachPlaceholderHandlers(TB_Category, "Category");
            AttachPlaceholderHandlers(TB_Semester, "Semester");
            AttachPlaceholderHandlers(TB_StudyingYear, "Studying Year");
            AttachPlaceholderHandlers(TB_Hours, "Number of Hours");
        }

        private void ClearExamFields()
        {
            // Reset exam fields to placeholders
            AttachPlaceholderHandlers(TB_ExamNumber, "Exam Number");
            AttachPlaceholderHandlers(TB_ExamTitle, "Exam Title");
            AttachPlaceholderHandlers(TB_ExamDescription, "Exam Description");
            AttachPlaceholderHandlers(TB_MaxMark, "Max Mark");

            // Reset date pickers to current date/time
            DTP_Start.Value = DateTime.Now;
            DTP_End.Value = DateTime.Now.AddHours(1);
        }

        private void btListCourses_Click(object sender, EventArgs e)
        {
            Form f = new Courses();
            f.ShowDialog();
        }

        private void btListStudents_Click(object sender, EventArgs e)
        {
            Form f=new studnets_filter();
            f.ShowDialog();
        }
    }
}