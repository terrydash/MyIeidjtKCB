namespace IeidjtuKCB_UI
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
            this.button1 = new System.Windows.Forms.Button();
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_Activeyear
            // 
            this.comboBox_Activeyear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Activeyear.FormattingEnabled = true;
            this.comboBox_Activeyear.Location = new System.Drawing.Point(71, 25);
            this.comboBox_Activeyear.Name = "comboBox_Activeyear";
            this.comboBox_Activeyear.Size = new System.Drawing.Size(121, 20);
            this.comboBox_Activeyear.TabIndex = 2;
            this.comboBox_Activeyear.SelectedIndexChanged += new System.EventHandler(this.comboBox_Activeyear_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.课表查询ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 25);
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
            this.课表查询ToolStripMenuItem.Size = new System.Drawing.Size(82, 21);
            this.课表查询ToolStripMenuItem.Text = "课表查询(&F)";
            // 
            // 学生课表查询ToolStripMenuItem
            // 
            this.学生课表查询ToolStripMenuItem.Name = "学生课表查询ToolStripMenuItem";
            this.学生课表查询ToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.学生课表查询ToolStripMenuItem.Text = "学生课表查询(&S)";
            // 
            // 教师课表查询ToolStripMenuItem
            // 
            this.教师课表查询ToolStripMenuItem.Name = "教师课表查询ToolStripMenuItem";
            this.教师课表查询ToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.教师课表查询ToolStripMenuItem.Text = "教师课表查询";
            // 
            // 教室课表查询ToolStripMenuItem
            // 
            this.教室课表查询ToolStripMenuItem.Name = "教室课表查询ToolStripMenuItem";
            this.教室课表查询ToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.教室课表查询ToolStripMenuItem.Text = "教室课表查询";
            // 
            // 班级课程查询ToolStripMenuItem
            // 
            this.班级课程查询ToolStripMenuItem.Name = "班级课程查询ToolStripMenuItem";
            this.班级课程查询ToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.班级课程查询ToolStripMenuItem.Text = "班级课程查询";
            // 
            // 课程课表查询ToolStripMenuItem
            // 
            this.课程课表查询ToolStripMenuItem.Name = "课程课表查询ToolStripMenuItem";
            this.课程课表查询ToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.课程课表查询ToolStripMenuItem.Text = "课程课表查询";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 59);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(838, 226);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(830, 200);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "教师课表查询";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(537, 168);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "教室课表查询";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "查询学期";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.comboBox_Activeyear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "徐国旭的排课系统";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
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
    }
}

