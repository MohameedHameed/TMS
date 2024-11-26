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
    public partial class FRM_Setting : Form
    {
        public FRM_Setting()
        {
            InitializeComponent();
        }

        private void FRM_Setting_Load(object sender, EventArgs e)
        {
            txtgetnot.Text = ((Properties.Settings.Default.GetNoteTimer) / 60000).ToString();
            txtdataupdate.Text = ((Properties.Settings.Default.UpdateDataTimer) / 60000).ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.GetNoteTimer = Convert.ToInt32(txtgetnot.Text) * 60000;
           Properties.Settings.Default.UpdateDataTimer= Convert.ToInt32(txtdataupdate.Text) * 60000;
            Properties.Settings.Default.Save();
            Close();
        }
    }
}
