using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team2_IntermediateSchool
{
    public partial class frmTeacher : Form
    {
        public frmTeacher()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            frmAttendance attendance = new frmAttendance();
            attendance.ShowDialog();
        }

        private void btnGrades_Click(object sender, EventArgs e)
        {

        }

        private void btnAssignments_Click(object sender, EventArgs e)
        {

        }

        private void btnSeating_Click(object sender, EventArgs e)
        {

        }
    }
}
