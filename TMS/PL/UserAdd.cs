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
    public partial class UserAdd : Form
    {
        TB_Users user;
        DBTMSEntities db;
        public int id;
        public string userstate;
        public FRM_USER fRM_USER;
        public UserAdd(FRM_USER fRM_USER)
        {
            InitializeComponent();
            this.fRM_USER = fRM_USER;
        }

        private void UserAdd_Load(object sender, EventArgs e)
        {

        }
        //save UserData
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text == "" || txtFullName.Text == "" || txtPassword.Text == "" || txtRole.SelectedItem == null)
            {
                MessageBox.Show("ادخل كل الحقول ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Add Or Edit using if by the id 
                if (id == 0)
                {
                    //Add
                    AddData();
                    this.fRM_USER.UserDataUpdate();
                    this.Close();
                }
                else
                {
                    //edit

                    Editdata();
                    this.fRM_USER.UserDataUpdate();

                    this.Close();

                }
            }
        }
        public void AddData()
        {
            try
            {
                db = new DBTMSEntities();

                user = new TB_Users()
                {
                    FullName = txtFullName.Text,
                    UserName = txtUserName.Text
               ,
                    Password = txtPassword.Text,
                    Role = txtRole.SelectedItem.ToString(),
                    State = "Off"
                };
                bool result = checkExistUserName(txtUserName.Text,"Add");
                if (result)
                {
                    db.Entry(user).State = System.Data.Entity.EntityState.Added;
                    db.SaveChanges();
                    MessageBox.Show("تمت الاضافة");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("يوجد اسم مستخدم بالفعل كهذا");
                    return;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا في اتصال قاعدة البيانات", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }



        public void Editdata()
        {
            try
            {
                db = new DBTMSEntities();
                user = new TB_Users()
                {
                    ID = id,
                    FullName = txtFullName.Text,
                    UserName = txtUserName.Text
               ,
                    Password = txtPassword.Text,
                    Role = txtRole.SelectedItem.ToString(),
                    State = userstate,
                };
                bool result = checkExistUserName(txtUserName.Text,"Edit");
                if (result)
                {
                    db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("تمت التعديل");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("يوجد اسم مستخدم بالفعل كهذا");
                    return;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا في اتصال قاعدة البيانات", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public bool checkExistUserName(string UserName,string state)
        {
            List<TB_Users> data;
            if (state == "Add")
            {
                 data = db.TB_Users.Where(x => x.UserName == UserName).ToList();

            }
            else
            {
                 data = db.TB_Users.Where(x => x.UserName == UserName && x.ID!= id).ToList();

            }
            if (data.Count == 0)
                return true;
            else
                return false;
        }
    }
}
    

