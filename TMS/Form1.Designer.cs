namespace TMS
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DevExpress.Utils.Animation.Transition transition1 = new DevExpress.Utils.Animation.Transition();
            DevExpress.Utils.Animation.PushFadeTransition pushFadeTransition1 = new DevExpress.Utils.Animation.PushFadeTransition();
            this.colNoteDes = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tileView1 = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.colNote_Manger = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colNote_User = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.pn_navbar = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnhome = new DevExpress.XtraEditors.SimpleButton();
            this.btntask = new DevExpress.XtraEditors.SimpleButton();
            this.btnproject = new DevExpress.XtraEditors.SimpleButton();
            this.btnuser = new DevExpress.XtraEditors.SimpleButton();
            this.btnabout = new DevExpress.XtraEditors.SimpleButton();
            this.pn_state = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lNotesCount = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.lbusername = new System.Windows.Forms.Label();
            this.lbjob = new System.Windows.Forms.Label();
            this.lbstate = new System.Windows.Forms.Label();
            this.pn_content = new System.Windows.Forms.Panel();
            this.transitionManager1 = new DevExpress.Utils.Animation.TransitionManager(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).BeginInit();
            this.pn_navbar.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pn_state.SuspendLayout();
            this.SuspendLayout();
            // 
            // colNoteDes
            // 
            this.colNoteDes.FieldName = "NoteDes";
            this.colNoteDes.Name = "colNoteDes";
            this.colNoteDes.Visible = true;
            this.colNoteDes.VisibleIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridControl1.DataSource = typeof(TMS.TB_Note);
            gridLevelNode1.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.tileView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(400, 622);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileView1});
            this.gridControl1.Visible = false;
            this.gridControl1.MouseLeave += new System.EventHandler(this.gridControl1_MouseLeave);
            // 
            // tileView1
            // 
            this.tileView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNote_Manger,
            this.colNote_User,
            this.colNoteDes});
            this.tileView1.GridControl = this.gridControl1;
            this.tileView1.Name = "tileView1";
            this.tileView1.OptionsTiles.GroupTextPadding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.tileView1.OptionsTiles.IndentBetweenGroups = 0;
            this.tileView1.OptionsTiles.IndentBetweenItems = 0;
            this.tileView1.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.List;
            this.tileView1.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tileView1.OptionsTiles.Padding = new System.Windows.Forms.Padding(0);
            this.tileView1.OptionsTiles.RowCount = 0;
            this.tileView1.TileColumns.Add(tableColumnDefinition1);
            this.tileView1.TileRows.Add(tableRowDefinition1);
            tileViewItemElement1.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileViewItemElement1.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement1.Appearance.Pressed.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileViewItemElement1.Appearance.Pressed.Options.UseFont = true;
            tileViewItemElement1.Appearance.Selected.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileViewItemElement1.Appearance.Selected.Options.UseFont = true;
            tileViewItemElement1.Column = this.colNoteDes;
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement1.Text = "colNoteDes";
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileView1.TileTemplate.Add(tileViewItemElement1);
            this.tileView1.DoubleClick += new System.EventHandler(this.tileView1_DoubleClick);
            // 
            // colNote_Manger
            // 
            this.colNote_Manger.FieldName = "Note_Manger";
            this.colNote_Manger.Name = "colNote_Manger";
            this.colNote_Manger.Visible = true;
            this.colNote_Manger.VisibleIndex = 0;
            // 
            // colNote_User
            // 
            this.colNote_User.FieldName = "Note_User";
            this.colNote_User.Name = "colNote_User";
            this.colNote_User.Visible = true;
            this.colNote_User.VisibleIndex = 1;
            // 
            // pn_navbar
            // 
            this.pn_navbar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pn_navbar.Controls.Add(this.flowLayoutPanel1);
            this.pn_navbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_navbar.Location = new System.Drawing.Point(0, 0);
            this.pn_navbar.Margin = new System.Windows.Forms.Padding(4);
            this.pn_navbar.Name = "pn_navbar";
            this.pn_navbar.Size = new System.Drawing.Size(1064, 77);
            this.pn_navbar.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnhome);
            this.flowLayoutPanel1.Controls.Add(this.btntask);
            this.flowLayoutPanel1.Controls.Add(this.btnproject);
            this.flowLayoutPanel1.Controls.Add(this.btnuser);
            this.flowLayoutPanel1.Controls.Add(this.btnabout);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1064, 77);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnhome
            // 
            this.btnhome.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnhome.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnhome.ImageOptions.SvgImage")));
            this.btnhome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnhome.Location = new System.Drawing.Point(860, 4);
            this.btnhome.Margin = new System.Windows.Forms.Padding(4);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(200, 84);
            this.btnhome.TabIndex = 0;
            this.btnhome.Text = "الرئيسية";
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // btntask
            // 
            this.btntask.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btntask.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btntask.ImageOptions.SvgImage")));
            this.btntask.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btntask.Location = new System.Drawing.Point(652, 4);
            this.btntask.Margin = new System.Windows.Forms.Padding(4);
            this.btntask.Name = "btntask";
            this.btntask.Size = new System.Drawing.Size(200, 73);
            this.btntask.TabIndex = 0;
            this.btntask.Text = "المهام";
            this.btntask.Click += new System.EventHandler(this.btntask_Click);
            // 
            // btnproject
            // 
            this.btnproject.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnproject.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnproject.ImageOptions.SvgImage")));
            this.btnproject.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnproject.Location = new System.Drawing.Point(444, 4);
            this.btnproject.Margin = new System.Windows.Forms.Padding(4);
            this.btnproject.Name = "btnproject";
            this.btnproject.Size = new System.Drawing.Size(200, 89);
            this.btnproject.TabIndex = 1;
            this.btnproject.Text = "المشاريع";
            this.btnproject.Click += new System.EventHandler(this.btnproject_Click);
            // 
            // btnuser
            // 
            this.btnuser.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnuser.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnuser.ImageOptions.SvgImage")));
            this.btnuser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnuser.Location = new System.Drawing.Point(236, 4);
            this.btnuser.Margin = new System.Windows.Forms.Padding(4);
            this.btnuser.Name = "btnuser";
            this.btnuser.Size = new System.Drawing.Size(200, 89);
            this.btnuser.TabIndex = 2;
            this.btnuser.Text = "المستخدمين";
            this.btnuser.Click += new System.EventHandler(this.btnuser_Click);
            // 
            // btnabout
            // 
            this.btnabout.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnabout.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnabout.ImageOptions.SvgImage")));
            this.btnabout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnabout.Location = new System.Drawing.Point(28, 4);
            this.btnabout.Margin = new System.Windows.Forms.Padding(4);
            this.btnabout.Name = "btnabout";
            this.btnabout.Size = new System.Drawing.Size(200, 89);
            this.btnabout.TabIndex = 3;
            this.btnabout.Text = "الاعدادات";
            this.btnabout.Click += new System.EventHandler(this.btnabout_Click);
            // 
            // pn_state
            // 
            this.pn_state.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pn_state.Controls.Add(this.label1);
            this.pn_state.Controls.Add(this.lNotesCount);
            this.pn_state.Controls.Add(this.simpleButton6);
            this.pn_state.Controls.Add(this.lbusername);
            this.pn_state.Controls.Add(this.lbjob);
            this.pn_state.Controls.Add(this.lbstate);
            this.pn_state.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_state.Location = new System.Drawing.Point(0, 625);
            this.pn_state.Margin = new System.Windows.Forms.Padding(4);
            this.pn_state.Name = "pn_state";
            this.pn_state.Size = new System.Drawing.Size(1064, 56);
            this.pn_state.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "by Eng/Mohammed Hameed";
            // 
            // lNotesCount
            // 
            this.lNotesCount.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNotesCount.Appearance.Options.UseFont = true;
            this.lNotesCount.Location = new System.Drawing.Point(49, 16);
            this.lNotesCount.Name = "lNotesCount";
            this.lNotesCount.Size = new System.Drawing.Size(10, 19);
            this.lNotesCount.TabIndex = 4;
            this.lNotesCount.Text = "0";
            this.lNotesCount.Click += new System.EventHandler(this.lNotesCount_Click);
            // 
            // simpleButton6
            // 
            this.simpleButton6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.simpleButton6.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.simpleButton6.Appearance.Options.UseForeColor = true;
            this.simpleButton6.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.simpleButton6.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton6.ImageOptions.SvgImage")));
            this.simpleButton6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.simpleButton6.Location = new System.Drawing.Point(0, 0);
            this.simpleButton6.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(42, 56);
            this.simpleButton6.TabIndex = 3;
            this.simpleButton6.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // lbusername
            // 
            this.lbusername.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbusername.AutoSize = true;
            this.lbusername.Location = new System.Drawing.Point(557, 15);
            this.lbusername.Name = "lbusername";
            this.lbusername.Size = new System.Drawing.Size(47, 19);
            this.lbusername.TabIndex = 0;
            this.lbusername.Text = "محمد";
            this.lbusername.Click += new System.EventHandler(this.lbusername_Click);
            // 
            // lbjob
            // 
            this.lbjob.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbjob.AutoSize = true;
            this.lbjob.Location = new System.Drawing.Point(465, 15);
            this.lbjob.Name = "lbjob";
            this.lbjob.Size = new System.Drawing.Size(37, 19);
            this.lbjob.TabIndex = 0;
            this.lbjob.Text = "مدير";
            // 
            // lbstate
            // 
            this.lbstate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbstate.AutoSize = true;
            this.lbstate.Location = new System.Drawing.Point(995, 15);
            this.lbstate.Name = "lbstate";
            this.lbstate.Size = new System.Drawing.Size(57, 19);
            this.lbstate.TabIndex = 0;
            this.lbstate.Text = "مستعد";
            // 
            // pn_content
            // 
            this.pn_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_content.Location = new System.Drawing.Point(0, 77);
            this.pn_content.Margin = new System.Windows.Forms.Padding(4);
            this.pn_content.Name = "pn_content";
            this.pn_content.Size = new System.Drawing.Size(1064, 548);
            this.pn_content.TabIndex = 2;
            this.pn_content.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_content_Paint);
            // 
            // transitionManager1
            // 
            this.transitionManager1.FrameInterval = 3000;
            this.transitionManager1.ShowWaitingIndicator = false;
            transition1.BarWaitingIndicatorProperties.Caption = "";
            transition1.BarWaitingIndicatorProperties.Description = "";
            transition1.Control = this.gridControl1;
            transition1.EasingMode = DevExpress.Data.Utils.EasingMode.EaseInOut;
            transition1.LineWaitingIndicatorProperties.AnimationElementCount = 5;
            transition1.LineWaitingIndicatorProperties.Caption = "";
            transition1.LineWaitingIndicatorProperties.Description = "";
            transition1.RingWaitingIndicatorProperties.AnimationElementCount = 5;
            transition1.RingWaitingIndicatorProperties.Caption = "";
            transition1.RingWaitingIndicatorProperties.Description = "";
            transition1.ShowWaitingIndicator = DevExpress.Utils.DefaultBoolean.False;
            transition1.TransitionType = pushFadeTransition1;
            transition1.WaitingIndicatorProperties.Caption = "";
            transition1.WaitingIndicatorProperties.Description = "";
            this.transitionManager1.Transitions.Add(transition1);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = global::TMS.Properties.Settings.Default.GetNoteTimer;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.pn_content);
            this.Controls.Add(this.pn_state);
            this.Controls.Add(this.pn_navbar);
            this.Controls.Add(this.gridControl1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).EndInit();
            this.pn_navbar.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pn_state.ResumeLayout(false);
            this.pn_state.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_navbar;
        private System.Windows.Forms.Panel pn_state;
        private System.Windows.Forms.Panel pn_content;
        private DevExpress.XtraEditors.SimpleButton btnabout;
        private DevExpress.XtraEditors.SimpleButton btnproject;
        private DevExpress.XtraEditors.SimpleButton btntask;
        private DevExpress.XtraEditors.SimpleButton btnhome;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lbstate;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.Utils.Animation.TransitionManager transitionManager1;
        private DevExpress.XtraGrid.Views.Tile.TileView tileView1;
        private DevExpress.XtraGrid.Columns.TileViewColumn colNote_Manger;
        private DevExpress.XtraGrid.Columns.TileViewColumn colNote_User;
        private DevExpress.XtraGrid.Columns.TileViewColumn colNoteDes;
        private DevExpress.XtraEditors.LabelControl lNotesCount;
        private System.Windows.Forms.Timer timer1;
        public DevExpress.XtraEditors.SimpleButton btnuser;
        public System.Windows.Forms.Label lbusername;
        public System.Windows.Forms.Label lbjob;
        private System.Windows.Forms.Label label1;
    }
}

