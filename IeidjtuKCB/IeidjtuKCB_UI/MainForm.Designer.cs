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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBox_Grade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonToTeacherKCB = new System.Windows.Forms.Button();
            this.Btn_FindTeacher = new System.Windows.Forms.Button();
            this.dataGridView_Teacher = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_TeacherNameToFind = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Department_For_Teacher = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.buttonKCB2Excel = new System.Windows.Forms.Button();
            this.buttonKCBtoGridView = new System.Windows.Forms.Button();
            this.backgroundWorkerForShowKCB = new System.ComponentModel.BackgroundWorker();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1345, 28);
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
            this.课表查询ToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.课表查询ToolStripMenuItem.Text = "课表查询(&F)";
            // 
            // 学生课表查询ToolStripMenuItem
            // 
            this.学生课表查询ToolStripMenuItem.Name = "学生课表查询ToolStripMenuItem";
            this.学生课表查询ToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.学生课表查询ToolStripMenuItem.Text = "学生课表查询(&S)";
            // 
            // 教师课表查询ToolStripMenuItem
            // 
            this.教师课表查询ToolStripMenuItem.Name = "教师课表查询ToolStripMenuItem";
            this.教师课表查询ToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.教师课表查询ToolStripMenuItem.Text = "教师课表查询";
            // 
            // 教室课表查询ToolStripMenuItem
            // 
            this.教室课表查询ToolStripMenuItem.Name = "教室课表查询ToolStripMenuItem";
            this.教室课表查询ToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.教室课表查询ToolStripMenuItem.Text = "教室课表查询";
            // 
            // 班级课程查询ToolStripMenuItem
            // 
            this.班级课程查询ToolStripMenuItem.Name = "班级课程查询ToolStripMenuItem";
            this.班级课程查询ToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.班级课程查询ToolStripMenuItem.Text = "班级课程查询";
            // 
            // 课程课表查询ToolStripMenuItem
            // 
            this.课程课表查询ToolStripMenuItem.Name = "课程课表查询ToolStripMenuItem";
            this.课程课表查询ToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.课程课表查询ToolStripMenuItem.Text = "课程课表查询";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 74);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1117, 282);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.checkBox1);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.progressBar1);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.TextBox_Grade);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1109, 253);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "毕业生";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(73, 80);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(101, 19);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(639, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "11,12";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(536, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "排除学号开头";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(632, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(632, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "label8";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(292, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "label6";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(42, 119);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(935, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(462, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "label5";
            // 
            // TextBox_Grade
            // 
            this.TextBox_Grade.Location = new System.Drawing.Point(170, 25);
            this.TextBox_Grade.MaxLength = 4;
            this.TextBox_Grade.Name = "TextBox_Grade";
            this.TextBox_Grade.Size = new System.Drawing.Size(100, 25);
            this.TextBox_Grade.TabIndex = 10;
            this.TextBox_Grade.Text = "2013";
            this.TextBox_Grade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_Grade_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "毕业生所在年级4位";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(276, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "导出毕业生";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonToTeacherKCB);
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
            // buttonToTeacherKCB
            // 
            this.buttonToTeacherKCB.Location = new System.Drawing.Point(504, 16);
            this.buttonToTeacherKCB.Name = "buttonToTeacherKCB";
            this.buttonToTeacherKCB.Size = new System.Drawing.Size(75, 23);
            this.buttonToTeacherKCB.TabIndex = 8;
            this.buttonToTeacherKCB.Text = "教师课表";
            this.buttonToTeacherKCB.UseVisualStyleBackColor = true;
            this.buttonToTeacherKCB.Click += new System.EventHandler(this.buttonToTeacherKCB_Click);
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
            this.dataGridView_Teacher.AllowUserToAddRows = false;
            this.dataGridView_Teacher.AllowUserToDeleteRows = false;
            this.dataGridView_Teacher.AllowUserToOrderColumns = true;
            this.dataGridView_Teacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Teacher.Location = new System.Drawing.Point(15, 64);
            this.dataGridView_Teacher.MultiSelect = false;
            this.dataGridView_Teacher.Name = "dataGridView_Teacher";
            this.dataGridView_Teacher.RowTemplate.Height = 27;
            this.dataGridView_Teacher.RowTemplate.ReadOnly = true;
            this.dataGridView_Teacher.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Teacher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Teacher.Size = new System.Drawing.Size(929, 150);
            this.dataGridView_Teacher.TabIndex = 6;
            this.dataGridView_Teacher.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Teacher_CellContentDoubleClick);
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
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 382);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(320, 188);
            this.dataGridView1.TabIndex = 1;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // buttonKCB2Excel
            // 
            this.buttonKCB2Excel.Location = new System.Drawing.Point(431, 31);
            this.buttonKCB2Excel.Name = "buttonKCB2Excel";
            this.buttonKCB2Excel.Size = new System.Drawing.Size(113, 23);
            this.buttonKCB2Excel.TabIndex = 6;
            this.buttonKCB2Excel.Text = "导出Excel";
            this.buttonKCB2Excel.UseVisualStyleBackColor = true;
            this.buttonKCB2Excel.Click += new System.EventHandler(this.buttonKCB2Excel_Click);
            // 
            // buttonKCBtoGridView
            // 
            this.buttonKCBtoGridView.Location = new System.Drawing.Point(262, 31);
            this.buttonKCBtoGridView.Name = "buttonKCBtoGridView";
            this.buttonKCBtoGridView.Size = new System.Drawing.Size(163, 23);
            this.buttonKCBtoGridView.TabIndex = 7;
            this.buttonKCBtoGridView.Text = "学期课表toGridView";
            this.buttonKCBtoGridView.UseVisualStyleBackColor = true;
            this.buttonKCBtoGridView.Click += new System.EventHandler(this.buttonKCBtoGridView_Click);
            // 
            // backgroundWorkerForShowKCB
            // 
            this.backgroundWorkerForShowKCB.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerForShowKCB_DoWork);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(343, 453);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(400, 272);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(773, 453);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(428, 272);
            this.richTextBox2.TabIndex = 9;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(414, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "停止并导出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 880);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonKCBtoGridView);
            this.Controls.Add(this.buttonKCB2Excel);
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
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
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
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Button buttonKCB2Excel;
        private System.Windows.Forms.Button buttonKCBtoGridView;
        private System.Windows.Forms.Button buttonToTeacherKCB;
        private System.ComponentModel.BackgroundWorker backgroundWorkerForShowKCB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox TextBox_Grade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button2;
    }
}

