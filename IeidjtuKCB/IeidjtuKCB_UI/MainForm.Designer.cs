namespace IeidjtuKCB.UI
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Bind = new System.Windows.Forms.Button();
            this.comboBox_Activeyear = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.课表查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生课表查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.教师课表查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.教室课表查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.班级课程查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.课程课表查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Btn_FindTeacher = new System.Windows.Forms.Button();
            this.dataGridView_Teacher = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_TeacherNameToFind = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Department_For_Teacher = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BackgroudWorkerForDataBase = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Teacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Bind
            // 
            this.Btn_Bind.Location = new System.Drawing.Point(445, 382);
            this.Btn_Bind.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Bind.Name = "Btn_Bind";
            this.Btn_Bind.Size = new System.Drawing.Size(100, 29);
            this.Btn_Bind.TabIndex = 1;
            this.Btn_Bind.Text = "button1";
            this.Btn_Bind.UseVisualStyleBackColor = true;
            this.Btn_Bind.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_Activeyear
            // 
            this.comboBox_Activeyear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Activeyear.FormattingEnabled = true;
            this.comboBox_Activeyear.Location = new System.Drawing.Point(95, 31);
            this.comboBox_Activeyear.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Activeyear.Name = "comboBox_Activeyear";
            this.comboBox_Activeyear.Size = new System.Drawing.Size(160, 23);
            this.comboBox_Activeyear.TabIndex = 2;
            this.comboBox_Activeyear.SelectedIndexChanged += new System.EventHandler(this.comboBox_Activeyear_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.课表查询ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1355, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 课表查询ToolStripMenuItem
            // 
            this.课表查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.学生课表查询ToolStripMenuItem,
            this.教师课表查询ToolStripMenuItem,
            this.教室课表查询ToolStripMenuItem,
            this.班级课程查询ToolStripMenuItem,
            this.课程课表查询ToolStripMenuItem});
            this.课表查询ToolStripMenuItem.Name = "课表查询ToolStripMenuItem";
            this.课表查询ToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.课表查询ToolStripMenuItem.Text = "课表查询(&F)";
            // 
            // 学生课表查询ToolStripMenuItem
            // 
            this.学生课表查询ToolStripMenuItem.Name = "学生课表查询ToolStripMenuItem";
            this.学生课表查询ToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.学生课表查询ToolStripMenuItem.Text = "学生课表查询(&S)";
            // 
            // 教师课表查询ToolStripMenuItem
            // 
            this.教师课表查询ToolStripMenuItem.Name = "教师课表查询ToolStripMenuItem";
            this.教师课表查询ToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.教师课表查询ToolStripMenuItem.Text = "教师课表查询";
            // 
            // 教室课表查询ToolStripMenuItem
            // 
            this.教室课表查询ToolStripMenuItem.Name = "教室课表查询ToolStripMenuItem";
            this.教室课表查询ToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.教室课表查询ToolStripMenuItem.Text = "教室课表查询";
            // 
            // 班级课程查询ToolStripMenuItem
            // 
            this.班级课程查询ToolStripMenuItem.Name = "班级课程查询ToolStripMenuItem";
            this.班级课程查询ToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.班级课程查询ToolStripMenuItem.Text = "班级课程查询";
            // 
            // 课程课表查询ToolStripMenuItem
            // 
            this.课程课表查询ToolStripMenuItem.Name = "课程课表查询ToolStripMenuItem";
            this.课程课表查询ToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.课程课表查询ToolStripMenuItem.Text = "课程课表查询";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 74);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1117, 282);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Btn_FindTeacher);
            this.tabPage1.Controls.Add(this.dataGridView_Teacher);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBox_TeacherNameToFind);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.comboBox_Department_For_Teacher);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1109, 253);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "教师课表查询";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Btn_FindTeacher
            // 
            this.Btn_FindTeacher.Location = new System.Drawing.Point(401, 17);
            this.Btn_FindTeacher.Name = "Btn_FindTeacher";
            this.Btn_FindTeacher.Size = new System.Drawing.Size(75, 23);
            this.Btn_FindTeacher.TabIndex = 7;
            this.Btn_FindTeacher.Text = "查询";
            this.Btn_FindTeacher.UseVisualStyleBackColor = true;
            this.Btn_FindTeacher.Click += new System.EventHandler(this.Btn_FindTeacher_Click);
            // 
            // dataGridView_Teacher
            // 
            this.dataGridView_Teacher.AllowUserToOrderColumns = true;
            this.dataGridView_Teacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Teacher.Location = new System.Drawing.Point(15, 64);
            this.dataGridView_Teacher.Name = "dataGridView_Teacher";
            this.dataGridView_Teacher.RowTemplate.Height = 27;
            this.dataGridView_Teacher.Size = new System.Drawing.Size(575, 150);
            this.dataGridView_Teacher.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "教师";
            // 
            // textBox_TeacherNameToFind
            // 
            this.textBox_TeacherNameToFind.Location = new System.Drawing.Point(232, 17);
            this.textBox_TeacherNameToFind.Name = "textBox_TeacherNameToFind";
            this.textBox_TeacherNameToFind.Size = new System.Drawing.Size(134, 25);
            this.textBox_TeacherNameToFind.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "部门";
            // 
            // comboBox_Department_For_Teacher
            // 
            this.comboBox_Department_For_Teacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Department_For_Teacher.FormattingEnabled = true;
            this.comboBox_Department_For_Teacher.Location = new System.Drawing.Point(50, 17);
            this.comboBox_Department_For_Teacher.Name = "comboBox_Department_For_Teacher";
            this.comboBox_Department_For_Teacher.Size = new System.Drawing.Size(121, 23);
            this.comboBox_Department_For_Teacher.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1109, 253);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "教室课表查询";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "查询学期";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 382);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(320, 188);
            this.dataGridView1.TabIndex = 1;
            // 
            // BackgroudWorkerForDataBase
            // 
            this.BackgroudWorkerForDataBase.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroudWorker_DoWork);
            this.BackgroudWorkerForDataBase.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroudWorkerForDataBase_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 880);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.comboBox_Activeyear);
            this.Controls.Add(this.Btn_Bind);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1363, 952);
            this.MinimumSize = new System.Drawing.Size(1363, 860);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "徐国旭的排课系统";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Teacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_Bind;
        private System.Windows.Forms.ComboBox comboBox_Activeyear;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 课表查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生课表查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 教师课表查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 教室课表查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 班级课程查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 课程课表查询ToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox_Department_For_Teacher;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_TeacherNameToFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_Teacher;
        private System.Windows.Forms.Button Btn_FindTeacher;
        private System.ComponentModel.BackgroundWorker BackgroudWorkerForDataBase;
    }
}

