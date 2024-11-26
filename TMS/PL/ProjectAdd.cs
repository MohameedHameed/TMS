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
    public partial class ProjectAdd : Form
    {
        TB_Projects projects;
        DBTMSEntities db;
        public int id;
        public FRM_Projects fRM_Projects;
        public ProjectAdd(FRM_Projects fRM_Projects)
        {
            InitializeComponent();
            this.fRM_Projects = fRM_Projects;
        }
        public ProjectAdd()
        {
            InitializeComponent();
        }

        private void UserAdd_Load(object sender, EventArgs e)
        {

        }
        //save UserData
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtprojectName.Text == "")
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
                    if(this.fRM_Projects!=null)
                    this.fRM_Projects.UserDataUpdate();
                    this.Close();
                }
                else
                {
                    //edit

                    Editdata();
                    if (this.fRM_Projects != null)
                        this.fRM_Projects.UserDataUpdate();

                    this.Close();

                }
            }
        }
        public void AddData()
        {
            try
            {
                db = new DBTMSEntities();

                projects = new TB_Projects()
                {
                    ProjectName = txtprojectName.Text,
                    ProjectDes = txtprojectDes.Text
               ,
                    
                };
                bool result = checkExistUserName(txtprojectName.Text,"Add");
                if (result)
                {
                    db.Entry(projects).State = System.Data.Entity.EntityState.Added;
                    db.SaveChanges();
                    MessageBox.Show("تمت الاضافة");
                    this.Close();
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
                db = new DBTMSEntities();
                projects = new TB_Projects()
                {
                    ID=id,
                    ProjectName = txtprojectName.Text,
                    ProjectDes = txtprojectDes.Text
                };
                bool result = checkExistUserName(txtprojectName.Text,"Edit");
                if (result)
                {
                    db.Entry(projects).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("تمت التعديل");
                    this.Close();
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

        public bool checkExistUserName(string projectName,string state)
        {
            List<TB_Projects> data;
            if (state == "Add")
            {
                 data = db.TB_Projects.Where(x => x.ProjectName == projectName).ToList();

            }
            else
            {
                 data = db.TB_Projects.Where(x => x.ProjectName == projectName && x.ID!= id).ToList();

            }
            if (data.Count == 0)
                return true;
            else
                return false;
        }
    }
}
    

