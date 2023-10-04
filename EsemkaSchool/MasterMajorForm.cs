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
    public partial class MasterMajorForm : Form
    {
        AdminMainForm parent;
        EsemkaSchoolDataClassesDataContext db = new EsemkaSchoolDataClassesDataContext();
        public MasterMajorForm(AdminMainForm parent)
        {
            InitializeComponent();
            this.parent = parent;
            parent.Hide();

            var q = (from major in db.Majors
                    select major).ToList();

            //dgvMajors.DataSource = q;
            //dgvMajors.Columns[0].DataPropertyName = "Name";
            //dgvMajors.Columns[1].DataPropertyName = "Description";
            for (int i = 0; i < q.Count(); i++)
            {
                
            }
        }

        private void MasterMajorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
