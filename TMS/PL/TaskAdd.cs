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
    public partial class TaskAdd : Form
    {
        TB_Tasks Tasks;
        DBTMSEntities db;
        public int id;
        public string TaskState;
        public FRM_Task fRM_Task;
        public TaskAdd(FRM_Task fRM_Task)
        {
            InitializeComponent();
            this.fRM_Task = fRM_Task;
            db = new DBTMSEntities();
        }

        private void UserAdd_Load(object sender, EventArgs e)
        {

        }
        //save UserData
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txttaskName.Text == "" || comboAdmin.SelectedIndex == -1 || comboProject.SelectedIndex == -1 || comboUser.SelectedIndex == -1 || txtTaskDuration.Text == "")
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
                    AddNote();
                    MessageBox.Show("تمت الاضافة");

                    this.fRM_Task.UserDataUpdate();
                    this.Close();
                }
                else
                {
                    //edit

                    Editdata();
                    EditNote();
                    MessageBox.Show("تمت التعديل");

                    this.fRM_Task.UserDataUpdate();

                    this.Close();

                }
            }
        }

        public void AddData()
        {
            try
            {
                db = new DBTMSEntities();
                var user = db.TB_Users.Where(x => x.FullName == comboUser.Text).FirstOrDefault();
                var project = db.TB_Projects.Where(x => x.ProjectName == comboProject.Text).FirstOrDefault();

                Tasks = new TB_Tasks()
                {
                    ID_project = project.ID,
                    ID_User = user.ID,

                    Task_Name = txttaskName.Text,
                    Task_Admin = comboAdmin.Text,
                    Task_User = comboUser.Text,
                    Task_Project = comboProject.Text,
                    Task_Des = txtTaskDes.Text,
                    Task_Start = TaskStart.Value,
                    Task_End = TaskEnd.Value,
                    Task_Duration = Int32.Parse(txtTaskDuration.Text),
                    Task_State = TaskState,


                };
                bool result = checkExistUserName(txttaskName.Text, "Add");
                if (result)
                {
                    db.Entry(Tasks).State = System.Data.Entity.EntityState.Added;
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("يوجد اسم مشروع بالفعل كهذا");
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
                Tasks = new TB_Tasks()
                {
                    ID = id,
                    Task_Name = txttaskName.Text,
                    Task_Admin = comboAdmin.Text,
                    Task_User = comboUser.Text,
                    Task_Project = comboProject.Text,
                    Task_Des = txtTaskDes.Text,
                    Task_Start = TaskStart.Value,
                    Task_End = TaskEnd.Value,
                    Task_Duration = Int32.Parse(txtTaskDuration.Text),
                    Task_State = TaskState,


                };
                bool result = checkExistUserName(txttaskName.Text, "Edit");
                if (result)
                {
                    db.Entry(Tasks).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("يوجد اسم مشروع بالفعل كهذا");
                    return;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا في اتصال قاعدة البيانات", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void AddNote()
        {

            try
            {
                db = new DBTMSEntities();
    

                TB_Note Note = new TB_Note()
                {

                    Note_Manger = comboAdmin.SelectedItem.ToString(),
                    Note_User = comboUser.SelectedItem.ToString(),
                    NoteDes =  "  الى المستخدم" + comboUser.SelectedItem.ToString()+ txttaskName.Text + " تمت اضافة الفعالية "

                };



                db.Entry(Note).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();







            }
            catch
            {
                MessageBox.Show("خطا في الاتصال بقاعدة البيانات");

            }

        }
        private void EditNote()
        {

            try
            {
                db = new DBTMSEntities();


                TB_Note Note = new TB_Note()
                {

                    Note_Manger = comboAdmin.SelectedItem.ToString(),
                    Note_User = comboUser.SelectedItem.ToString(),
                    NoteDes = "  الى المستخدم" + comboUser.SelectedItem.ToString() + txtTaskDes.Text + " تمت تعديل الفعالية "

                };



                db.Entry(Note).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();







            }
            catch
            {
                MessageBox.Show("خطا في الاتصال بقاعدة البيانات");

            }

        }
        public bool checkExistUserName(string Task_Name, string state)
            {
                List<TB_Tasks> data;
                if (state == "Add")
                {
                    data = db.TB_Tasks.Where(x => x.Task_Name == Task_Name).ToList();

                }
                else
                {
                    data = db.TB_Tasks.Where(x => x.Task_Name == Task_Name && x.ID != id).ToList();

                }
                if (data.Count == 0)
                    return true;
                else
                    return false;
            }

            private void TaskAdd_Activated(object sender, EventArgs e)
            {

                comboAdmin.DataSource = db.TB_Users.Select(x => x.FullName).ToList();
                comboProject.DataSource = db.TB_Projects.Select(x => x.ProjectName).ToList();
                comboUser.DataSource = db.TB_Users.Select(x => x.FullName).ToList();
            }

            private void groupBox2_Enter(object sender, EventArgs e)
            {

            }

            private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
                PL.ProjectAdd projectAdd = new ProjectAdd();
                projectAdd.Show();

            }

            private void TaskStart_ValueChanged(object sender, EventArgs e)
            {
                CalaculateDuration();
            }

            private void TaskEnd_ValueChanged(object sender, EventArgs e)
            {
                CalaculateDuration();
            }

            public void CalaculateDuration()
            {
                var data = (TaskEnd.Value - TaskStart.Value).Days;
                txtTaskDuration.Text = data.ToString();
                if (data == 0)
                {
                    TaskState = "اليوم";
                }
                else if (data == 1)
                {
                    TaskState = "غدا";
                }
                else if (data > 1)
                {
                    TaskState = "باقي " + data.ToString() + "ايام";

                }
                else if (data < 1)
                {
                    TaskState = "غير مكتمل";

                }

            }

            private void checkbox_Done_CheckedChanged(object sender, EventArgs e)
            {
                if (checkbox_Done.Checked)
                {
                    TaskState = "مكتمل";

                }
            }
        }
    }
    

