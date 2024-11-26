using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using System.Windows.Forms;
using TMS.PL;

namespace TMS
{
    public partial class FRM_Start : SplashScreen
    {
        public FRM_Start()
        {
            InitializeComponent();
            this.labelCopyright.Text = "Copyright ©1999-" + DateTime.Now.Year.ToString();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        private void peImage_EditValueChanged(object sender, EventArgs e)
        {

        }
        private bool checkconnection()
        {
            try
            {
                DBTMSEntities db = new DBTMSEntities();
                var list = db.TB_Users.ToList();
                if (list!=null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        private  async void FRM_Start_Load(object sender, EventArgs e)
        {
            await Task.Run(() => Thread.Sleep(3000));

           bool state= await Task.Run(() => checkconnection());
            if (state)
            {
                LoginUser loginUser = new LoginUser();
                loginUser.Show();
            }
            else
            {
                MessageBox.Show("خطا في الاتصال في قاعدة البيانات حاول مرة اخرى");
            }
        }

        private void FRM_Start_Deactivate(object sender, EventArgs e)
        {
            Hide();
        }
    }
}