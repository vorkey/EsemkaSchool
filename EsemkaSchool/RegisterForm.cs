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
    public partial class RegisterForm : Form
    {
        LoginForm parent;
        EsemkaSchoolDataClassesDataContext db = new EsemkaSchoolDataClassesDataContext();
        Control[] inputFields;
        // Gender is Male if true, female if False
        bool gender = true;
        public RegisterForm(LoginForm parent, User user)
        {
            InitializeComponent();
            this.parent = parent;
            parent.Hide();

            fillComboBox();

            inputFields = new Control[] {txtName, txtEmail, txtAddress, txtHandphone, txtPlaceofBirth, txtPassword, txtRetypePassword, txtFatherHandphone, txtFatherName, txtMotherHandphone, txtHandphone};
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }

        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void btnConfirmRegister_Click(object sender, EventArgs e)
        {
            // Max umur 21 tahun
            if ((DateTime.Now.Year - dtpDateofBirth.Value.Year) > 21)
            {
                MessageBox.Show("Sorry, maximum age allowed is 21 years old");
                return;
            }

            var q = (from siswa in db.Students
                    join user in db.Users on siswa.UserId equals user.Id
                    where user.Email == txtEmail.Text
                    select siswa).FirstOrDefault();
            if (!Helper.IsFilled(inputFields))
            {
                MessageBox.Show("Please Fill All Fields!");
                return;
            }
            if (!(q == null))
            {
                MessageBox.Show("Email Already Exist!");
                return;
            }
            else if (!Helper.IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Email Is Not Valid!");
                return;
            }
            else if (txtPassword.Text.Length < 6)
            {
                MessageBox.Show("Password Must  Be Longer Than 6 Characters!");
                return;
            }
            else if (txtPassword.Text != txtRetypePassword.Text)
            {
                MessageBox.Show("Please Retype the Password Correctly!");
                return;
            }
            else
            {
                try
                {
                    var user = new User
                    {
                        Name = txtName.Text,
                        Email = txtEmail.Text,
                        Password = txtPassword.Text,
                        NoHandphone = txtHandphone.Text,
                        RoleId = 2
                    };

                    db.Users.InsertOnSubmit(user);
                    db.SubmitChanges();

                    var u = (from us in db.Users
                            where us.Email == txtEmail.Text
                            select us).FirstOrDefault();

                    var student = new Student
                    {
                        UserId = u.Id,
                        MajorId = Convert.ToInt32(cmbMajor.SelectedValue),
                        DateOfBirth = dtpDateofBirth.Value,
                        PlaceOfBirth = txtPlaceofBirth.Text,
                        Gender = gender,
                        Address = txtAddress.Text,
                        FatherName = txtFatherName.Text,
                        FatherNoHandphone = txtFatherHandphone.Text,
                        MotherName = txtMotherName.Text,
                        MotherNoHandphone = txtMotherHandphone.Text
                    };
                    
                    db.Students.InsertOnSubmit(student);
                    db.SubmitChanges();

                    MessageBox.Show("Register Success!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            Helper.Clear(inputFields);
        }

        private void fillComboBox()
        {
            var q = from major in db.Majors
                    select major;

            cmbMajor.DataSource = q;
            cmbMajor.ValueMember = "Id";
            cmbMajor.DisplayMember = "Name";
        }

        private void rbtnMale_Click(object sender, EventArgs e)
        {
            if (rbtnMale.Checked)
            {
                gender = true;
                rbtnFemale.Checked = false;
            }
        }

        private void rbtnFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnFemale.Checked)
            {
                gender = false;
                rbtnMale.Checked = false;
            }
        }
    }
}
