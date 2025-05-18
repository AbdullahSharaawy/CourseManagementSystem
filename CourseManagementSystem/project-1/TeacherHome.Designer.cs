namespace project_1
{
    partial class TeacherHome
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.CB_Courses = new System.Windows.Forms.ComboBox();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.TB_Code = new System.Windows.Forms.TextBox();
            this.TB_Category = new System.Windows.Forms.TextBox();
            this.TB_Semester = new System.Windows.Forms.TextBox();
            this.TB_StudyingYear = new System.Windows.Forms.TextBox();
            this.TB_Hours = new System.Windows.Forms.TextBox();
            this.B_AddCourse = new System.Windows.Forms.Button();
            this.B_UpdateCourse = new System.Windows.Forms.Button();
            this.B_HideCourse = new System.Windows.Forms.Button();
            this.TB_ExamNumber = new System.Windows.Forms.TextBox();
            this.TB_ExamTitle = new System.Windows.Forms.TextBox();
            this.TB_ExamDescription = new System.Windows.Forms.TextBox();
            this.TB_MaxMark = new System.Windows.Forms.TextBox();
            this.DTP_Start = new System.Windows.Forms.DateTimePicker();
            this.DTP_End = new System.Windows.Forms.DateTimePicker();
            this.B_AddExam = new System.Windows.Forms.Button();
            this.btListCourses = new System.Windows.Forms.Button();
            this.btListStudents = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CB_Courses
            // 
            this.CB_Courses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Courses.Location = new System.Drawing.Point(20, 20);
            this.CB_Courses.Name = "CB_Courses";
            this.CB_Courses.Size = new System.Drawing.Size(300, 21);
            this.CB_Courses.TabIndex = 0;
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(20, 60);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(300, 20);
            this.TB_Name.TabIndex = 1;
            // 
            // TB_Code
            // 
            this.TB_Code.Location = new System.Drawing.Point(20, 90);
            this.TB_Code.Name = "TB_Code";
            this.TB_Code.Size = new System.Drawing.Size(300, 20);
            this.TB_Code.TabIndex = 2;
            // 
            // TB_Category
            // 
            this.TB_Category.Location = new System.Drawing.Point(20, 120);
            this.TB_Category.Name = "TB_Category";
            this.TB_Category.Size = new System.Drawing.Size(300, 20);
            this.TB_Category.TabIndex = 3;
            // 
            // TB_Semester
            // 
            this.TB_Semester.Location = new System.Drawing.Point(20, 150);
            this.TB_Semester.Name = "TB_Semester";
            this.TB_Semester.Size = new System.Drawing.Size(300, 20);
            this.TB_Semester.TabIndex = 4;
            // 
            // TB_StudyingYear
            // 
            this.TB_StudyingYear.Location = new System.Drawing.Point(20, 180);
            this.TB_StudyingYear.Name = "TB_StudyingYear";
            this.TB_StudyingYear.Size = new System.Drawing.Size(300, 20);
            this.TB_StudyingYear.TabIndex = 5;
            // 
            // TB_Hours
            // 
            this.TB_Hours.Location = new System.Drawing.Point(20, 210);
            this.TB_Hours.Name = "TB_Hours";
            this.TB_Hours.Size = new System.Drawing.Size(300, 20);
            this.TB_Hours.TabIndex = 6;
            // 
            // B_AddCourse
            // 
            this.B_AddCourse.Location = new System.Drawing.Point(350, 60);
            this.B_AddCourse.Name = "B_AddCourse";
            this.B_AddCourse.Size = new System.Drawing.Size(120, 30);
            this.B_AddCourse.TabIndex = 7;
            this.B_AddCourse.Text = "Add Course";
            this.B_AddCourse.Click += new System.EventHandler(this.B_AddCourse_Click);
            // 
            // B_UpdateCourse
            // 
            this.B_UpdateCourse.Location = new System.Drawing.Point(350, 100);
            this.B_UpdateCourse.Name = "B_UpdateCourse";
            this.B_UpdateCourse.Size = new System.Drawing.Size(120, 30);
            this.B_UpdateCourse.TabIndex = 8;
            this.B_UpdateCourse.Text = "Update Course";
            this.B_UpdateCourse.Click += new System.EventHandler(this.B_UpdateCourse_Click);
            // 
            // B_HideCourse
            // 
            this.B_HideCourse.Location = new System.Drawing.Point(350, 140);
            this.B_HideCourse.Name = "B_HideCourse";
            this.B_HideCourse.Size = new System.Drawing.Size(120, 30);
            this.B_HideCourse.TabIndex = 9;
            this.B_HideCourse.Text = "Hide Course";
            this.B_HideCourse.Click += new System.EventHandler(this.B_HideCourse_Click);
            // 
            // TB_ExamNumber
            // 
            this.TB_ExamNumber.Location = new System.Drawing.Point(20, 260);
            this.TB_ExamNumber.Name = "TB_ExamNumber";
            this.TB_ExamNumber.Size = new System.Drawing.Size(300, 20);
            this.TB_ExamNumber.TabIndex = 10;
            // 
            // TB_ExamTitle
            // 
            this.TB_ExamTitle.Location = new System.Drawing.Point(20, 290);
            this.TB_ExamTitle.Name = "TB_ExamTitle";
            this.TB_ExamTitle.Size = new System.Drawing.Size(300, 20);
            this.TB_ExamTitle.TabIndex = 11;
            // 
            // TB_ExamDescription
            // 
            this.TB_ExamDescription.Location = new System.Drawing.Point(20, 320);
            this.TB_ExamDescription.Name = "TB_ExamDescription";
            this.TB_ExamDescription.Size = new System.Drawing.Size(300, 20);
            this.TB_ExamDescription.TabIndex = 12;
            // 
            // TB_MaxMark
            // 
            this.TB_MaxMark.Location = new System.Drawing.Point(20, 350);
            this.TB_MaxMark.Name = "TB_MaxMark";
            this.TB_MaxMark.Size = new System.Drawing.Size(300, 20);
            this.TB_MaxMark.TabIndex = 13;
            // 
            // DTP_Start
            // 
            this.DTP_Start.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";
            this.DTP_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_Start.Location = new System.Drawing.Point(20, 380);
            this.DTP_Start.Name = "DTP_Start";
            this.DTP_Start.Size = new System.Drawing.Size(300, 20);
            this.DTP_Start.TabIndex = 14;
            // 
            // DTP_End
            // 
            this.DTP_End.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";
            this.DTP_End.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_End.Location = new System.Drawing.Point(20, 410);
            this.DTP_End.Name = "DTP_End";
            this.DTP_End.Size = new System.Drawing.Size(300, 20);
            this.DTP_End.TabIndex = 15;
            // 
            // B_AddExam
            // 
            this.B_AddExam.Location = new System.Drawing.Point(350, 260);
            this.B_AddExam.Name = "B_AddExam";
            this.B_AddExam.Size = new System.Drawing.Size(120, 30);
            this.B_AddExam.TabIndex = 16;
            this.B_AddExam.Text = "Add Exam";
            this.B_AddExam.Click += new System.EventHandler(this.B_AddExam_Click);
            // 
            // btListCourses
            // 
            this.btListCourses.Location = new System.Drawing.Point(350, 11);
            this.btListCourses.Name = "btListCourses";
            this.btListCourses.Size = new System.Drawing.Size(120, 30);
            this.btListCourses.TabIndex = 17;
            this.btListCourses.Text = "List of Courses";
            this.btListCourses.Click += new System.EventHandler(this.btListCourses_Click);
            // 
            // btListStudents
            // 
            this.btListStudents.Location = new System.Drawing.Point(476, 11);
            this.btListStudents.Name = "btListStudents";
            this.btListStudents.Size = new System.Drawing.Size(120, 30);
            this.btListStudents.TabIndex = 18;
            this.btListStudents.Text = "List of Students";
            this.btListStudents.Click += new System.EventHandler(this.btListStudents_Click);
            // 
            // TeacherHome
            // 
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(600, 460);
            this.Controls.Add(this.btListStudents);
            this.Controls.Add(this.btListCourses);
            this.Controls.Add(this.CB_Courses);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.TB_Code);
            this.Controls.Add(this.TB_Category);
            this.Controls.Add(this.TB_Semester);
            this.Controls.Add(this.TB_StudyingYear);
            this.Controls.Add(this.TB_Hours);
            this.Controls.Add(this.B_AddCourse);
            this.Controls.Add(this.B_UpdateCourse);
            this.Controls.Add(this.B_HideCourse);
            this.Controls.Add(this.TB_ExamNumber);
            this.Controls.Add(this.TB_ExamTitle);
            this.Controls.Add(this.TB_ExamDescription);
            this.Controls.Add(this.TB_MaxMark);
            this.Controls.Add(this.DTP_Start);
            this.Controls.Add(this.DTP_End);
            this.Controls.Add(this.B_AddExam);
            this.Name = "TeacherHome";
            this.Text = "Instructor Home";
            this.Load += new System.EventHandler(this.TeacherHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ComboBox CB_Courses;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.TextBox TB_Code;
        private System.Windows.Forms.TextBox TB_Category;
        private System.Windows.Forms.TextBox TB_Semester;
        private System.Windows.Forms.TextBox TB_StudyingYear;
        private System.Windows.Forms.TextBox TB_Hours;
        private System.Windows.Forms.Button B_AddCourse;
        private System.Windows.Forms.Button B_UpdateCourse;
        private System.Windows.Forms.Button B_HideCourse;
        private System.Windows.Forms.TextBox TB_ExamNumber;
        private System.Windows.Forms.TextBox TB_ExamTitle;
        private System.Windows.Forms.TextBox TB_ExamDescription;
        private System.Windows.Forms.TextBox TB_MaxMark;
        private System.Windows.Forms.DateTimePicker DTP_Start;
        private System.Windows.Forms.DateTimePicker DTP_End;
        private System.Windows.Forms.Button B_AddExam;
        private System.Windows.Forms.Button btListCourses;
        private System.Windows.Forms.Button btListStudents;
    }
}