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
    public partial class LoginForm : Form
    {
        EsemkaSchoolDataClassesDataContext db = new EsemkaSchoolDataClassesDataContext();
        Control[] _inputFields;
        public User loggedUser;
        public LoginForm()
        {
            InitializeComponent();
            _inputFields = new Control[] {txtEmail, txtPassword};
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!Helper.IsFilled(_inputFields))
            {
                MessageBox.Show("Please Fill All Fields");
                return;
            }

            var q = (from user in db.Users
                    where user.Email == txtEmail.Text && user.Password == txtPassword.Text
                    select user).FirstOrDefault();

            loggedUser = q;

            if (q == null)
            {
                MessageBox.Show("User Not Found or Wrong Password!");
            } else
            {
                if (q.RoleId == 1)
                {
                    var f = new AdminMainForm(this);
                    f.ShowDialog();
                }
                else if (q.RoleId == 2)
                {
                    var f = new SiswaMainForm(this, loggedUser);
                    f.ShowDialog();
                }
            }
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var f = new RegisterForm(this, loggedUser);
            f.ShowDialog();
        }
    }
}
