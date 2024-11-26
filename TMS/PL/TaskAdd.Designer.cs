namespace TMS.PL
{
    partial class TaskAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskAdd));
            this.label1 = new System.Windows.Forms.Label();
            this.txttaskName = new System.Windows.Forms.TextBox();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.comboProject = new System.Windows.Forms.ComboBox();
            this.comboUser = new System.Windows.Forms.ComboBox();
            this.comboAdmin = new System.Windows.Forms.ComboBox();
            this.txtTaskDes = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkbox_Done = new System.Windows.Forms.CheckBox();
            this.txtTaskDuration = new System.Windows.Forms.TextBox();
            this.TaskEnd = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TaskStart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(326, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "اسم الفعالية";
            // 
            // txttaskName
            // 
            this.txttaskName.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttaskName.Location = new System.Drawing.Point(36, 66);
            this.txttaskName.Name = "txttaskName";
            this.txttaskName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txttaskName.Size = new System.Drawing.Size(378, 29);
            this.txttaskName.TabIndex = 3;
            this.txttaskName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSave.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSave.ImageOptions.SvgImage")));
            this.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSave.Location = new System.Drawing.Point(0, 497);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(879, 41);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "حفظ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.comboProject);
            this.groupBox1.Controls.Add(this.comboUser);
            this.groupBox1.Controls.Add(this.comboAdmin);
            this.groupBox1.Controls.Add(this.txtTaskDes);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txttaskName);
            this.groupBox1.Font = new System.Drawing.Font("Simplified Arabic Fixed", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(458, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(420, 478);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "عـــــــام";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Simplified Arabic Fixed", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(23, 285);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(54, 19);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "إضافة";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // comboProject
            // 
            this.comboProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProject.FormattingEnabled = true;
            this.comboProject.Location = new System.Drawing.Point(36, 323);
            this.comboProject.Name = "comboProject";
            this.comboProject.Size = new System.Drawing.Size(378, 36);
            this.comboProject.TabIndex = 5;
            // 
            // comboUser
            // 
            this.comboUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboUser.FormattingEnabled = true;
            this.comboUser.Location = new System.Drawing.Point(36, 233);
            this.comboUser.Name = "comboUser";
            this.comboUser.Size = new System.Drawing.Size(378, 36);
            this.comboUser.TabIndex = 5;
            // 
            // comboAdmin
            // 
            this.comboAdmin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAdmin.FormattingEnabled = true;
            this.comboAdmin.Location = new System.Drawing.Point(36, 149);
            this.comboAdmin.Name = "comboAdmin";
            this.comboAdmin.Size = new System.Drawing.Size(378, 36);
            this.comboAdmin.TabIndex = 5;
            // 
            // txtTaskDes
            // 
            this.txtTaskDes.Location = new System.Drawing.Point(36, 388);
            this.txtTaskDes.Name = "txtTaskDes";
            this.txtTaskDes.Size = new System.Drawing.Size(378, 84);
            this.txtTaskDes.TabIndex = 4;
            this.txtTaskDes.Text = "";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(304, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "وصف الفعالية";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(313, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "اسم المشروع";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(340, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "المستخدم";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(359, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "المدير";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkbox_Done);
            this.groupBox2.Controls.Add(this.txtTaskDuration);
            this.groupBox2.Controls.Add(this.TaskEnd);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TaskStart);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Simplified Arabic Fixed", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(420, 478);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "الوقـــــــــــــــت";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // checkbox_Done
            // 
            this.checkbox_Done.AutoSize = true;
            this.checkbox_Done.Location = new System.Drawing.Point(15, 210);
            this.checkbox_Done.Name = "checkbox_Done";
            this.checkbox_Done.Size = new System.Drawing.Size(106, 32);
            this.checkbox_Done.TabIndex = 6;
            this.checkbox_Done.Text = "مكتمل";
            this.checkbox_Done.UseVisualStyleBackColor = true;
            this.checkbox_Done.CheckedChanged += new System.EventHandler(this.checkbox_Done_CheckedChanged);
            // 
            // txtTaskDuration
            // 
            this.txtTaskDuration.Location = new System.Drawing.Point(131, 252);
            this.txtTaskDuration.Name = "txtTaskDuration";
            this.txtTaskDuration.Size = new System.Drawing.Size(145, 34);
            this.txtTaskDuration.TabIndex = 5;
            // 
            // TaskEnd
            // 
            this.TaskEnd.Location = new System.Drawing.Point(6, 149);
            this.TaskEnd.Name = "TaskEnd";
            this.TaskEnd.Size = new System.Drawing.Size(404, 34);
            this.TaskEnd.TabIndex = 4;
            this.TaskEnd.ValueChanged += new System.EventHandler(this.TaskEnd_ValueChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(71, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 31);
            this.label9.TabIndex = 2;
            this.label9.Text = "يوم";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(180, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 31);
            this.label8.TabIndex = 2;
            this.label8.Text = "المدة";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(326, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "نهاية الفعالية";
            // 
            // TaskStart
            // 
            this.TaskStart.Location = new System.Drawing.Point(6, 60);
            this.TaskStart.Name = "TaskStart";
            this.TaskStart.Size = new System.Drawing.Size(404, 34);
            this.TaskStart.TabIndex = 4;
            this.TaskStart.ValueChanged += new System.EventHandler(this.TaskStart_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(326, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "بداية الفعالية";
            // 
            // TaskAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 538);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TaskAdd";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة مشروع";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.TaskAdd_Activated);
            this.Load += new System.EventHandler(this.UserAdd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txttaskName;
        public DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.RichTextBox txtTaskDes;
        public System.Windows.Forms.TextBox txtTaskDuration;
        public System.Windows.Forms.DateTimePicker TaskEnd;
        public System.Windows.Forms.DateTimePicker TaskStart;
        public System.Windows.Forms.CheckBox checkbox_Done;
        public System.Windows.Forms.ComboBox comboProject;
        public System.Windows.Forms.ComboBox comboUser;
        public System.Windows.Forms.ComboBox comboAdmin;
    }
}