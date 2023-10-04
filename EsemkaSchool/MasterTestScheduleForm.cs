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
    public partial class MasterTestScheduleForm : Form
    {
        AdminMainForm parent;
        public MasterTestScheduleForm(AdminMainForm parent)
        {
            InitializeComponent();
            this.parent = parent;
            parent.Hide();
        }

        private void MasterTestScheduleForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
