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
    public partial class ReviewRegistrationDocumentsForm : Form
    {
        EsemkaSchoolDataClassesDataContext db = new EsemkaSchoolDataClassesDataContext();

        AdminMainForm parent;
        public ReviewRegistrationDocumentsForm(AdminMainForm parent)
        {
            InitializeComponent();
            this.parent = parent;
            parent.Hide();

            var q = from student in db.Students
                    join user in db.Users on student.UserId equals user.Id
                    join major in db.Majors on student.MajorId equals major.Id
                    select new
                    {
                        user.Name,
                        user.Email,
                        user.NoHandphone,
                        Major = major.Name,
                        student.DateOfBirth,
                        student.PlaceOfBirth,
                        student.Gender,
                        student.Address,
                        student.FatherName,
                        student.FatherNoHandphone,
                        student.MotherName,
                        student.MotherNoHandphone
                    };
            dgvStudent.DataSource = q;
            dgvStudent.Columns[2].HeaderText = "No handphone";
            dgvStudent.Columns[4].HeaderText = "Date Of Birth";
            dgvStudent.Columns[5].HeaderText = "Place Of Birth";
            dgvStudent.Columns[8].HeaderText = "Father Name";
            dgvStudent.Columns[9].HeaderText = "Father No Handphone";
            dgvStudent.Columns[10].HeaderText = "Mother Name";
            dgvStudent.Columns[11].HeaderText = "Mother No Handphone";

        }

        private void ReviewRegistrationDocumentsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }
    }
}
