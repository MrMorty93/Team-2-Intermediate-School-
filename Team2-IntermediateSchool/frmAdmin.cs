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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            frmStudents students = new frmStudents();
            students.ShowDialog();
        }

        private void btnTeachers_Click(object sender, EventArgs e)
        {

        }

        private void btnOfficers_Click(object sender, EventArgs e)
        {

        }
    }
}
