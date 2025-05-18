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
    public partial class StdInfo : Form
    {
        private int _StudentID;
        public StdInfo(int studentID)
        {
            _StudentID = studentID;
            InitializeComponent();
            SqlConnection connection = new SqlConnection("Server=.;DataBase=CourseManagementSystem;Integrated Security=True");
            connection.Open();
            if (!connection.State.Equals(ConnectionState.Open))
            {
                MessageBox.Show("Connection failed");
                return;
            }
            string query = @"SELECT * FROM Student where student_id = @studentID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@studentID", studentID);
            SqlDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            if (reader.HasRows)
            {
                dataTable.Load(reader);
                dataGridView1.DataSource = dataTable;
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            else
            {
                MessageBox.Show("No data found");
            }
            List<string> columns = new List<string>();
            columns = dataTable.Columns.Cast<DataColumn>().Select(column => column.ColumnName).ToList();
            foreach (string column in columns)
            {
                comboBox1.Items.Add(column);
            }
            connection.Close();
            reader.Close();
        }

        private void StdInfo_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string column = comboBox1.SelectedItem.ToString();
            string value = txtNewData.Text.ToString();
            SqlConnection connection = new SqlConnection("Server=.;DataBase=MinyUniversity;Integrated Security=True");
            connection.Open();
            if (string.IsNullOrEmpty(column) || string.IsNullOrEmpty(value))
            {
                MessageBox.Show("Please select a column and enter a value.");
                return;
            }
            string query = $"UPDATE Student SET {column} = @value WHERE student_id = @studentID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@value", value);
            command.Parameters.AddWithValue("@studentID", _StudentID.ToString());
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Update successful");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Update failed: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
