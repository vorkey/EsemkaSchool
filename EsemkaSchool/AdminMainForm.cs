using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsemkaSchool
{
    public partial class AdminMainForm : Form
    {
        private readonly LoginForm parent;
        public AdminMainForm(LoginForm parent)
        {
            InitializeComponent();
            this.parent = parent;
            parent.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMasterMajor_Click(object sender, EventArgs e)
        {
            var f = new MasterMajorForm(this);
            f.ShowDialog();
        }

        private void btnMasterTestSchedule_Click(object sender, EventArgs e)
        {
            var f = new MasterTestScheduleForm(this);
            f.ShowDialog();
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            var f = new ReviewRegistrationDocumentsForm(this);
            f.ShowDialog();
        }

        private void AdminMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }
    }
}
