using DevExpress.XtraGrid.EditForm.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMS.PL
{
    public partial class LoginUser : Form
    {
        TB_Users user;
        DBTMSEntities db;
        public LoginUser()
        {
            InitializeComponent();
            db=new DBTMSEntities();
        }

        private void UserAdd_Load(object sender, EventArgs e)
        {

        }
        //save UserData
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("ادخل كل الحقول ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                TB_Users user=db.TB_Users.Where(x=>x.UserName == txtUserName.Text && x.Password==txtPassword.Text).FirstOrDefault();
                if (user != null) {
                Form1 frm=new Form1();
                    if (user.Role=="مستخدم")
                        frm.btnuser.Visible = false;
                    user.State = "on";
                    db.Entry(user).State= System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    frm.lbusername.Text = user.FullName;
                    frm.lbjob.Text = user.Role;
                    frm.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("لايوجد اسم مستخدم او كلمة سر كهذه", "خطا");
                }

            }
        }

        private void LoginUser_Leave(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
    

