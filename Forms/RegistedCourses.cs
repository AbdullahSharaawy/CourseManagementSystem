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
        public RegistedCrss(int studentID)
        {
            InitializeComponent();
            SqlConnection connection = new SqlConnection("Server=.;DataBase=CourseManagementSystem;Integrated Security=True");
            connection.Open();
            if (!connection.State.Equals(ConnectionState.Open))
            {
                MessageBox.Show("Connection failed");
                return;
            }
            string query = @"select c.course_id, c.Name, c.Code, c.Category, c.no_hours  
                            from Course c  
                            inner join Enrollment e on e.course_id = c.course_id  
                            where e.student_id = @_studentID  
                            ORDER by c.course_id  ASC";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@_studentID", studentID);
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
            reader.Close();
            connection.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RegistedCrss_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
