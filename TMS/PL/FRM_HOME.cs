using DevExpress.XtraEditors;
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
    public partial class FRM_HOME : DevExpress.XtraEditors.XtraUserControl
    {
        DBTMSEntities db;
        public FRM_HOME()
        {
            InitializeComponent();
            db=new DBTMSEntities();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FRM_HOME_Load(object sender, EventArgs e)
        {
            var tasks=db.TB_Tasks.Where(x=>x.Task_State=="اليوم").Select(x=>x.ID).ToList();
            lbltasktoday.Text=tasks.Count.ToString();
            var tasks2 = db.TB_Tasks.Where(x => x.Task_State == "غدا").Select(x => x.ID).ToList();
            lbltasktomowro.Text = tasks2.Count.ToString();
            var tasks3 = db.TB_Tasks.Where(x => x.Task_State == "مكتمل").Select(x => x.ID).ToList();
            lbltaskDone.Text = tasks3.Count.ToString();
            var tasks4 = db.TB_Tasks.Where(x => x.Task_State == "غير مكتمل").Select(x => x.ID).ToList();
            lbltaskNotDone.Text = tasks4.Count.ToString();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
