using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentPart
{
    public partial class StdHome : Form
    {
        private int _StudentID;
        public StdHome(int studentID)
        {
            InitializeComponent();
            _StudentID = studentID;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btnRegistCrs_Click(object sender, EventArgs e)
        {
            Form form = new RegistCrs(_StudentID);
            form.ShowDialog();
        }

        private void btnRegistedCrss_Click(object sender, EventArgs e)
        {
            Form form = new RegistedCrss(_StudentID);
            form.ShowDialog();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Form form = new StdInfo(_StudentID);
            form.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StdHome_Load(object sender, EventArgs e)
        {

        }
    }
}
