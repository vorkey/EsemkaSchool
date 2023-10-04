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
    public partial class SiswaMainForm : Form
    {
        LoginForm parent;
        User _user;
        EsemkaSchoolDataClassesDataContext db = new EsemkaSchoolDataClassesDataContext();
        public SiswaMainForm(LoginForm parent, User user)
        {
            InitializeComponent();
            this.parent = parent;
            parent.Hide();
            this._user = user;

            var q = (from student in db.Students
                     where student.UserId == _user.Id
                     join major in db.Majors on student.MajorId equals major.Id
                     //join doc in db.UploadedDocuments on student.Id equals doc.StudentId
                     select new {
                        major.Name,
                        student.DateOfBirth,
                        student.PlaceOfBirth,
                        student.Gender,
                        student.FatherName,
                        student.MotherName,
                        student.Address,
                        //doc.RequiredDocumentId,
                        //doc.ApprovalStatus
                     }).FirstOrDefault();


            if (q == null)
            {
                MessageBox.Show($"Id Not Found: {_user.Id}");
            }
            else
            {
                lblUsername.Text = $"Hello, {_user.Name}";
                lblEmail.Text = _user.Email;
                lblMajor.Text = q.Name;
                lblDateofBirth.Text = q.DateOfBirth.ToString("d MMMM yyyy");
                lblPlaceofBirth.Text = q.PlaceOfBirth;
                if (q.Gender == true)
                {
                    lblGender.Text = "Male";
                }
                else
                {
                    lblGender.Text = "Female";
                }
                lblFather.Text = q.FatherName;
                lblMother.Text = q.MotherName;
                lblAddress.Text = q.Address;
            }

            //var q2 = (from doc in db.RequiredDocuments
            //          select doc).ToList();

            //dgvRegistrationDocuments.DataSource = q2;
        }

        private void SiswaMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            var f = new SelectTestScheduleForm(this);
            f.ShowDialog();
        }
    }
}
