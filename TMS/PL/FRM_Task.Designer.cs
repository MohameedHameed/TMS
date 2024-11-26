namespace TMS.PL
{
    partial class FRM_Task
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Task));
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnupdate = new DevExpress.XtraEditors.SimpleButton();
            this.btndelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnedit = new DevExpress.XtraEditors.SimpleButton();
            this.btnadd = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTask_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTask_Des = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTask_User = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTask_Project = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTask_Start = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTask_End = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTask_Duration = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTask_State = new DevExpress.XtraGrid.Columns.GridColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.btnedit);
            this.panel1.Controls.Add(this.btnadd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(0, 476);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 72);
            this.panel1.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.simpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.simpleButton1.Location = new System.Drawing.Point(656, 0);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(69, 72);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "تم";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnupdate.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnupdate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnupdate.ImageOptions.SvgImage")));
            this.btnupdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnupdate.Location = new System.Drawing.Point(579, 0);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(69, 72);
            this.btnupdate.TabIndex = 1;
            this.btnupdate.Text = "تحديث";
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btndelete.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btndelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btndelete.ImageOptions.SvgImage")));
            this.btndelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btndelete.Location = new System.Drawing.Point(502, 0);
            this.btndelete.Margin = new System.Windows.Forms.Padding(4);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(69, 72);
            this.btndelete.TabIndex = 1;
            this.btndelete.Text = "حذف";
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnedit
            // 
            this.btnedit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnedit.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnedit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnedit.ImageOptions.SvgImage")));
            this.btnedit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnedit.Location = new System.Drawing.Point(425, 0);
            this.btnedit.Margin = new System.Windows.Forms.Padding(4);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(69, 72);
            this.btnedit.TabIndex = 1;
            this.btnedit.Text = "تعديل";
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnadd
            // 
            this.btnadd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnadd.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnadd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnadd.ImageOptions.SvgImage")));
            this.btnadd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnadd.Location = new System.Drawing.Point(333, 0);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(69, 72);
            this.btnadd.TabIndex = 1;
            this.btnadd.Text = " اضافة";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(TMS.TB_Tasks);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControl1.Size = new System.Drawing.Size(1064, 476);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTask_Name,
            this.colTask_Des,
            this.colTask_User,
            this.colTask_Project,
            this.colTask_Start,
            this.colTask_End,
            this.colTask_Duration,
            this.colTask_State});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colTask_Name
            // 
            this.colTask_Name.Caption = "الفعالية";
            this.colTask_Name.FieldName = "Task_Name";
            this.colTask_Name.Name = "colTask_Name";
            this.colTask_Name.OptionsColumn.AllowEdit = false;
            this.colTask_Name.OptionsColumn.ReadOnly = true;
            this.colTask_Name.Visible = true;
            this.colTask_Name.VisibleIndex = 0;
            // 
            // colTask_Des
            // 
            this.colTask_Des.Caption = "الوصف";
            this.colTask_Des.FieldName = "Task_Des";
            this.colTask_Des.Name = "colTask_Des";
            this.colTask_Des.OptionsColumn.AllowEdit = false;
            this.colTask_Des.OptionsColumn.ReadOnly = true;
            this.colTask_Des.Visible = true;
            this.colTask_Des.VisibleIndex = 1;
            // 
            // colTask_User
            // 
            this.colTask_User.Caption = "المستخدم";
            this.colTask_User.FieldName = "Task_User";
            this.colTask_User.Name = "colTask_User";
            this.colTask_User.OptionsColumn.AllowEdit = false;
            this.colTask_User.OptionsColumn.ReadOnly = true;
            this.colTask_User.Visible = true;
            this.colTask_User.VisibleIndex = 2;
            // 
            // colTask_Project
            // 
            this.colTask_Project.Caption = "المشروع";
            this.colTask_Project.FieldName = "Task_Project";
            this.colTask_Project.Name = "colTask_Project";
            this.colTask_Project.OptionsColumn.AllowEdit = false;
            this.colTask_Project.OptionsColumn.ReadOnly = true;
            this.colTask_Project.Visible = true;
            this.colTask_Project.VisibleIndex = 3;
            // 
            // colTask_Start
            // 
            this.colTask_Start.Caption = "بداية";
            this.colTask_Start.FieldName = "Task_Start";
            this.colTask_Start.Name = "colTask_Start";
            this.colTask_Start.OptionsColumn.AllowEdit = false;
            this.colTask_Start.OptionsColumn.ReadOnly = true;
            this.colTask_Start.Visible = true;
            this.colTask_Start.VisibleIndex = 4;
            // 
            // colTask_End
            // 
            this.colTask_End.Caption = "نهائية";
            this.colTask_End.FieldName = "Task_End";
            this.colTask_End.Name = "colTask_End";
            this.colTask_End.OptionsColumn.AllowEdit = false;
            this.colTask_End.OptionsColumn.ReadOnly = true;
            this.colTask_End.Visible = true;
            this.colTask_End.VisibleIndex = 5;
            // 
            // colTask_Duration
            // 
            this.colTask_Duration.Caption = "الفترة (يوم)";
            this.colTask_Duration.FieldName = "Task_Duration";
            this.colTask_Duration.Name = "colTask_Duration";
            this.colTask_Duration.OptionsColumn.AllowEdit = false;
            this.colTask_Duration.OptionsColumn.ReadOnly = true;
            this.colTask_Duration.Visible = true;
            this.colTask_Duration.VisibleIndex = 6;
            // 
            // colTask_State
            // 
            this.colTask_State.Caption = "الحالة";
            this.colTask_State.FieldName = "Task_State";
            this.colTask_State.Name = "colTask_State";
            this.colTask_State.OptionsColumn.AllowEdit = false;
            this.colTask_State.OptionsColumn.ReadOnly = true;
            this.colTask_State.Visible = true;
            this.colTask_State.VisibleIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = global::TMS.Properties.Settings.Default.StateTime;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = Properties.Settings.Default.UpdateDataTimer;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // FRM_Task
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Name = "FRM_Task";
            this.Size = new System.Drawing.Size(1064, 548);
            this.Load += new System.EventHandler(this.FRM_USER_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnadd;
        private DevExpress.XtraEditors.SimpleButton btndelete;
        private DevExpress.XtraEditors.SimpleButton btnedit;
        private DevExpress.XtraEditors.SimpleButton btnupdate;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.Columns.GridColumn colTask_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colTask_Des;
        private DevExpress.XtraGrid.Columns.GridColumn colTask_User;
        private DevExpress.XtraGrid.Columns.GridColumn colTask_Project;
        private DevExpress.XtraGrid.Columns.GridColumn colTask_Start;
        private DevExpress.XtraGrid.Columns.GridColumn colTask_End;
        private DevExpress.XtraGrid.Columns.GridColumn colTask_Duration;
        private DevExpress.XtraGrid.Columns.GridColumn colTask_State;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}
