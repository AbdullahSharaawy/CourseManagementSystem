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
        public StdInfo()
        {
            InitializeComponent();
            SqlConnection connection = new SqlConnection("Server=.;DataBase=MinyUniversity;Integrated Security=True");
            connection.Open();
            if (!connection.State.Equals(ConnectionState.Open))
            {
                MessageBox.Show("Connection failed");
                return;
            }
            string query = "SELECT * FROM Student";
            SqlCommand command = new SqlCommand(query, connection);
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
        }

        private void StdInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
