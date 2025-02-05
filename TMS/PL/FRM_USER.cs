﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace TMS.PL
{
    public partial class FRM_USER : DevExpress.XtraEditors.XtraUserControl
    {
        DBTMSEntities dBTMSEntities;
        TB_Users users;
        UserAdd useradd;
        public FRM_USER()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            TMS.DBTMSEntities dbContext = new TMS.DBTMSEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.TB_Users.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                gridControl1.DataSource = dbContext.TB_Users.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            UserDataUpdate();
        }
        public void UserDataUpdate()
        {
            try {
                users = new TB_Users();
                dBTMSEntities = new DBTMSEntities();
                gridControl1.DataSource = dBTMSEntities.TB_Users.ToList();
            }catch(Exception ex)
            {
                MessageBox.Show("خطا في اتصال قاعدة البيانات", "خطا",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            }

        private void FRM_USER_Load(object sender, EventArgs e)
        {
            UserDataUpdate();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            useradd = new UserAdd(this);
            useradd.id = 0;
            useradd.Show();

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
            TB_Users user1 = new TB_Users();
            user1 = dBTMSEntities.TB_Users.Where(x => x.ID == id).FirstOrDefault();
            useradd = new UserAdd(this);
            useradd.id = user1.ID;
            useradd.txtFullName.Text = user1.FullName;
            useradd.txtUserName.Text = user1.UserName;
            useradd.txtPassword.Text = user1.Password;
            useradd.txtRole.Text = user1.Role;
            useradd.btnSave.Text = "تعديل";
            useradd.userstate = user1.State;
            useradd.Show();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("هل انت متاكد","تحذير",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
                if (id == 0)
                {
                    MessageBox.Show("لايوجد بيانات لحذفها");

                }
                else
                {
                    TB_Users user1 = new TB_Users();
                    user1 = dBTMSEntities.TB_Users.Where(x => x.ID == id).FirstOrDefault();
                    dBTMSEntities.Entry(user1).State = EntityState.Deleted;
                    dBTMSEntities.SaveChanges();

                    MessageBox.Show("تم الحذف بنجاح");

                    UserDataUpdate();
                }
            }
           
        }
    }
}
