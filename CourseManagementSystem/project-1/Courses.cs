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
    public partial class Courses : Form
    {
       
        public Courses()
        {
            InitializeComponent();
        }
        public delegate void dgFillComboBox();
        public static event dgFillComboBox evFillComboBox;

        private DataTable getCourses()
        {
            string query = "select Course.*,Instructor.firstname+' '+Instructor.lastname as InstructorName from Course inner join Instructor on Course.instructor_id=Instructor.instructor_id";
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
      

       

        private void Courses_Load(object sender, EventArgs e)
        {
            dgCourses.DataSource = getCourses();
            dgCourses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgCourses.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Filter.ComboItems = new string[] { "None", "Name", "Code", "semester", "Studying Year", "Category", "no_hours", "is_Active", "Instructor Name" };
            Filter._AllData=getCourses();
            evFillComboBox();
        }

        private void filter1_evFilterResult(object sender, DataTable e)
        {
            if (e != null)
            {
                dgCourses.DataSource = e;


            }
        }
    }
}
