using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using IeidjtuKCB.Common;
using IeidjtuKCB.BLL;
using System.Windows.Forms;
using IeidjtuKCB.UI.Common;
using IeidjtuKCB.Model;
using IeidjtuKCB.DBSession;
using Newtonsoft.Json;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using Dos.ORM;

namespace IeidjtuKCB.UI
{
    /// <summary>
    /// 主页面
    /// </summary>
    public partial class MainForm : System.Windows.Forms.Form
    {
        #region 变量声明

        /// <summary>
        /// 为便于异步读取执行操作设置的要操作的ID
        /// </summary>
        private MainFormEnum.BindDataBaseToUI TaskId = MainFormEnum.BindDataBaseToUI.NothingToDo;

        /// <summary>
        /// 绑定用的空DataTable
        /// </summary>
        private DataTable dt = null;

        private List<zuihouchengjidan> studentchengjidan = new List<zuihouchengjidan>();
        private int howmanystudent = 0;
        int currentstunum = 0;
        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainFormUIBind.ComboBoxBind.BindActiveYearEntitytoCombobox(comboBox_Activeyear);
            MainFormUIBind.ComboBoxBind.BindDepartmentEntitytoCombobox(comboBox_Department_For_Teacher);
        }

        private void comboBox_Activeyear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// 点击查询 进行教师查找
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_FindTeacher_Click(object sender, EventArgs e)
        {

            if (comboBox_Department_For_Teacher.SelectedValue != null)
            {
                int deptid = ConvertHelper.ConvertStringToInt(comboBox_Department_For_Teacher.SelectedValue.ToString());
                string teachername = textBox_TeacherNameToFind.Text.Trim();
                Teacher_BLL T_BLL = new Teacher_BLL();

                dt = ListHelper.ListToDataTable(T_BLL.GetTeacherEntityFromDAL(deptid, teachername));
                CommonUIDataBindMethod.BindDataGridView(dataGridView_Teacher, dt,
                    ColumnHeaderTextModel.Teacher.TeacherForDataGridView.ColumnsNames(),
                    ColumnHeaderTextModel.Teacher.TeacherForDataGridView.DisplayNames());
            }


        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {

            switch (TaskId)
            {
                case MainFormEnum.BindDataBaseToUI.NothingToDo:
                    break;
                case MainFormEnum.BindDataBaseToUI.BindTeacherEntityToGridview:
                    if (e.Argument != null)
                    {

                    }

                    break;
                case MainFormEnum.BindDataBaseToUI.BindActiveYearEntityToComboBox:
                    break;
                case MainFormEnum.BindDataBaseToUI.BindVwCscheduleEntityToGridview:
                    if (e.Argument != null)
                    {
                        int id = (int) e.Argument;

                        Cschedule_BLL Cs_BLL = new Cschedule_BLL();
                        dt = ListHelper.ListToDataTable(Cs_BLL.GetEntityFromDAL(id));
                    }
                    break;


            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            switch (TaskId)
            {
                case MainFormEnum.BindDataBaseToUI.NothingToDo:
                    break;
                case MainFormEnum.BindDataBaseToUI.BindTeacherEntityToGridview:
                    if (dt != null)
                    {
                        MainFormUIBind.DataGridViewBind.GetTeacherEntityToDataGridView(dataGridView_Teacher, dt);
                        dt = null;
                        TaskId = MainFormEnum.BindDataBaseToUI.NothingToDo;
                    }
                    break;
                case MainFormEnum.BindDataBaseToUI.BindActiveYearEntityToComboBox:
                    break;
                case MainFormEnum.BindDataBaseToUI.BindVwCscheduleEntityToGridview:
                    if (dt != null)
                    {
                        dataGridView1.DataSource = dt;
                        dt = null;
                        TaskId = MainFormEnum.BindDataBaseToUI.NothingToDo;
                    }
                    break;

            }
        }

        private void buttonKCB2Excel_Click(object sender, EventArgs e)
        {
            if (comboBox_Activeyear.Items.Count > 0)
            {
                bool finderr = false;
                ActiveYear_BLL A_BLL = new ActiveYear_BLL();
                int atyid = A_BLL.GetNowActvieYearID();
                try
                {
                    atyid = ConvertHelper.ConvertStringToInt(comboBox_Activeyear.SelectedValue.ToString());
                }
                catch
                {
                    MessageBox.Show("错误");
                }
                string title = "大连科技学院" + A_BLL.GetAllEntityFromDAL().Find(d => d.ATID == atyid).ATName + "课程表";
                string filefullname = System.Environment.CurrentDirectory + @"\" + title + ".xlsx";
                MessageBox.Show(filefullname);
                if (System.IO.File.Exists(filefullname))
                {
                    try
                    {
                        System.IO.File.Delete(filefullname);

                    }
                    catch
                    {
                        finderr = true;
                        MessageBox.Show("文件占用中无法删除！");
                    }

                }
                Cschedule_BLL C_BLL = new Cschedule_BLL();



                try
                {

                    MakeExcelModel MEM = new MakeExcelModel();
                    MEM.Filename = filefullname;
                    MEM.TitleName = title;
                    MEM.PassWord = "";
                    MEM.dataTable = C_BLL.GetKCBFormvw_Cschedule_ForAtyID(atyid);
                    MEM.HeaderText = new List<string>
                    {
                        "课程代码",
                        "课程名称",
                        "教学班级名称",
                        "人数",
                        "任课教师",
                        "起始周",
                        "结束周",
                        "单双周",
                        "星期",
                        "节数",
                        "教学楼",
                        "教室",
                        "教室容纳人数",
                        "学分",
                        "考核方式",
                        "学时",
                        "课程类型"
                    };
                    ExcelHelper.SaveToExcel(MEM);
                }
                catch
                {
                    finderr = true;
                    MessageBox.Show("文件占用中无法生成！");

                }
                if (System.IO.File.Exists(filefullname) & finderr == false)
                {
                    try
                    {
                        System.Diagnostics.Process.Start(filefullname);
                    }
                    catch
                    {

                        MessageBox.Show("当前系统没有安装EXCEL,或者EXCEL注册信息不全，无法自动打开生成的EXCEL，请手工打开！");
                    }

                }
            }
        }

        private void buttonKCBtoGridView_Click(object sender, EventArgs e)
        {
            if (comboBox_Activeyear.Items.Count > 0)
            {
                TaskId = MainFormEnum.BindDataBaseToUI.BindVwCscheduleEntityToGridview;
                if (!backgroundWorker.IsBusy)
                {
                    backgroundWorker.RunWorkerAsync(
                        (int) ConvertHelper.ConvertStringToInt(comboBox_Activeyear.SelectedValue.ToString()));
                }
            }
        }

        private void dataGridView_Teacher_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonToTeacherKCB_Click(object sender, EventArgs e)
        {
            if (dataGridView_Teacher.Rows.Count > 0 & comboBox_Activeyear.Items.Count > 0)
            {
                if (dataGridView_Teacher.SelectedRows.Count > 0 & dataGridView_Teacher.SelectedCells[0] != null &
                    comboBox_Activeyear.SelectedValue != null)
                {
                    if (ConvertHelper.ConvertStringToInt(comboBox_Activeyear.SelectedValue.ToString()) > 0)
                    {

                        List<BindArgumentEntity> BAEList = new List<BindArgumentEntity>();

                        BAEList.Add(new BindArgumentEntity
                        {
                            ArgumentName = "ActyearID",
                            ArgumentValue = comboBox_Activeyear.SelectedValue.ToString(),
                            ArgumentValueDataType = BindArgumentEntity._ArgumentValueDataType.Int
                        });
                        BAEList.Add(new BindArgumentEntity
                        {
                            ArgumentName = "PSID",
                            ArgumentValue = dataGridView_Teacher.SelectedCells[0].Value.ToString(),
                            ArgumentValueDataType = BindArgumentEntity._ArgumentValueDataType.Int
                        });
                        BAEList.Add(new BindArgumentEntity
                        {
                            ArgumentName = "FileName",
                            ArgumentValue =
                                System.Environment.CurrentDirectory + @"\" + DateTimeHelper.GetTimeStamp() + @".html",
                            ArgumentValueDataType = BindArgumentEntity._ArgumentValueDataType.String
                        });
                        backgroundWorkerForShowKCB.RunWorkerAsync(BAEList);
                    }

                }
            }

        }

        private void backgroundWorkerForShowKCB_DoWork(object sender, DoWorkEventArgs e)
        {
            if (e.Argument != null)
            {
                int actyearid = 0;
                int psid = 0;
                string filename = "";
                List<BindArgumentEntity> BAEList = e.Argument as List<BindArgumentEntity>;
                foreach (var item in BAEList)
                {
                    switch (item.ArgumentName.ToUpper())
                    {
                        case "ACTYEARID":
                            actyearid = ConvertHelper.ConvertStringToInt(item.ArgumentValue);
                            break;
                        case "PSID":
                            psid = ConvertHelper.ConvertStringToInt(item.ArgumentValue);
                            break;
                        case "FILENAME":
                            filename = item.ArgumentValue;
                            break;
                        default:
                            return;
                    }


                }

                if (actyearid != 0 | psid != 0 | filename != string.Empty)
                {

                    if (MakeKCBShowinBrowers.MakeTeacherKCBShowinBrowers(actyearid, psid, filename))
                    {
                        try
                        {
                            System.Diagnostics.Process.Start(filename);
                        }
                        catch
                        {

                            MessageBox.Show("生成文件错误或是当前系统没有默认打开HTML的浏览器！");
                        }

                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void TextBox_Grade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0x20) e.KeyChar = (char) 0; //禁止空格键
            if ((e.KeyChar == 0x2D) && (((TextBox) sender).Text.Length == 0)) return; //处理负数
            if (e.KeyChar > 0x20)
            {
                try
                {
                    double.Parse(((TextBox) sender).Text + e.KeyChar.ToString());
                }
                catch
                {
                    e.KeyChar = (char) 0; //处理非法字符
                }
            }
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public DataTable ToDataTable<TResult>(IEnumerable<TResult> value) where TResult : class

        {

            //创建属性的集合

            List<PropertyInfo> pList = new List<PropertyInfo>();

            //获得反射的入口

            Type type = typeof(TResult);

            DataTable dt = new DataTable();

            //把所有的public属性加入到集合 并添加DataTable的列


            Array.ForEach<PropertyInfo>(type.GetProperties(), p =>
            {
                pList.Add(p);
                dt.Columns.Add(string.IsNullOrEmpty(p.Name) ? "" : p.Name
                    , typeof(string));
            });

            foreach (var item in value)

            {

                //创建一个DataRow实例

                DataRow row = dt.NewRow();

                //给row 赋值

                pList.ForEach(p => row[p.Name] = p.GetValue(item, null));

                //加入到DataTable

                dt.Rows.Add(row);

            }

            return dt;

        }

        public class zuihouchengjidan
        {
            public string 学号 { get; set; }
            public string 姓名 { get; set; }
            public string 学院 { get; set; }
            public string 专业 { get; set; }
            public string 班级 { get; set; }
            public string 最终成绩 { get; set; }

            public string 全过程成绩 { get; set; }
            public string 仍不及格成绩 { get; set; }
            public string 修读的公选课{ get; set; }
            public int 公选课学分 { get; set; }
            public int 仍不及格学分 { get; set; }
        }

        public string zhuanhuanchengji(List<vw_StuReport> stuReports)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var VARIABLE in stuReports)
            {
                sb.Append(VARIABLE.TermName);
                sb.Append(" ");
                sb.Append(VARIABLE.课程名称);
                sb.Append(" ");
                sb.Append(VARIABLE.学分);
                sb.Append(" ");
                sb.Append(VARIABLE.成绩);
                sb.AppendLine();
            }
            return sb.ToString();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int gradeid =
                DataBase.Context.From<Grade>().Where(n => n.GRName.Contains(TextBox_Grade.Text.Trim())).ToFirst().GRDID;
            List<Student> students =
                DataBase.Context.From<Student>()
                    .Where(
                        n =>
                            n.GradeID == gradeid && n.State.Contains("正常") && n.ByState.Contains("在学") &&
                            !n.StdCode.StartsWith("11") && !n.StdCode.StartsWith("12")).OrderBy(n=>n.StdCode)
                    .Page(100, 1).ToList();
            howmanystudent = students.Count;
           
            MessageBox.Show("共有学生" + howmanystudent + "个");
            foreach (var Student in students)
            {
                label8.Text = "学号:" + Student.StdCode + "姓名:" + Student.StdName;
                var stureportsjingchengjidan =
                    DataBase.Context.From<vw_StuReport>()
                        .Where(n => n.StuID == Student.StdID && (n.State.Contains("提交") || n.State.Contains("归档")))
                        .ToList();
                var stureportsall =
                    DataBase.Context.From<vw_StuReport>()
                        .Where(n => n.StuID == Student.StdID && (n.State.Contains("提交") || n.State.Contains("归档")))
                        .ToList();
                List<vw_StuReport> stureportsbujige = new List<vw_StuReport>();
                List<int> yijingguodesrid = new List<int>();
                var howmanychengji = stureportsall.Count;
                var currentchengji = 0;
                foreach (var stureport in stureportsjingchengjidan)
                {
                    label9.Text = "转换成绩到数字格式:" + stureport.SRID + "_课程名" + stureport.考试类型;
                    if (stureport.成绩.Contains("优"))
                    {
                        stureport.成绩 = "-95";
                    }
                    else if (stureport.成绩.Contains("良"))
                    {
                        stureport.成绩 = "-75";
                    }
                    else if (stureport.成绩.Contains("中"))
                    {
                        stureport.成绩 = "-70";
                    }
                    else if (stureport.成绩.Contains("合格") || stureport.成绩.Contains("及格"))
                    {
                        stureport.成绩 = "-61";
                    }
                    else if (stureport.成绩.Contains("不及格"))
                    {
                        stureport.成绩 = "-59";
                    }
                    else if (stureport.成绩.ToUpper().Contains("NULL") || stureport.成绩.Contains("无") ||
                             string.IsNullOrEmpty(stureport.成绩) || stureport.成绩.ToUpper()=="NULL"||stureport.成绩.Length==0)
                    {
                        stureport.成绩 = "-1";
                    }
                    else
                    {

                        try
                        {
                            stureport.成绩 = ((int)float.Parse(stureport.成绩)).ToString();
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("成绩转换错误:" + stureport.成绩 + "srid:" + stureport.SRID);
                        }
                        
                    }
                }
                foreach (var stureport in stureportsjingchengjidan)
                {
                    label9.Text = "判断成绩是否不及格:" + stureport.SRID + "_课程名" + stureport.课程名称;
                    currentchengji = currentchengji + 1;
                    var cj = 0;
                    float fcj = 0;
                    if (int.TryParse(stureport.成绩, out cj))
                    {
                        cj = Math.Abs(cj);
                        if (cj < 60)
                        {
                            stureportsbujige.Add(stureport);
                        }
                    }
                    else if (float.TryParse(stureport.成绩, out fcj))
                    {
                        cj = Math.Abs(Convert.ToInt32(fcj));
                        if (cj < 60)
                        {
                            stureportsbujige.Add(stureport);
                        }
                    }

                    else 

                        MessageBox.Show(stureport.成绩);
                    if (stureport.成绩.Contains("不及格"))
                        {

                            stureportsbujige.Add(stureport);
                        }
                    
                    if (
                        stureportsjingchengjidan.FindAll(
                            n => n.CCID == stureport.CCID && int.Parse(n.成绩) > int.Parse(stureport.成绩)).Count >
                        0)
                    {
                        yijingguodesrid.Add(stureport.SRID);
                    }
                    label6.Text = "寻找不及格成绩:" + howmanychengji + "/" + howmanychengji;
                }
                foreach (var VARIABLE in yijingguodesrid)
                {
                    stureportsjingchengjidan.RemoveAll(n => n.SRID == VARIABLE);
                    stureportsbujige.RemoveAll(n => n.SRID == VARIABLE);
                }
                stureportsbujige.OrderBy(n => n.TermName);
                var chongxiuguode = new List<vw_StuReport>();
                foreach (var VARIABLE in stureportsbujige)
                {
                    label9.Text = "找到已经修过的成绩:" + VARIABLE.SRID + "_课程名" + VARIABLE.课程名称;
                    var findthing = stureportsjingchengjidan.FindAll(n => n.CCID == VARIABLE.CCID);
                    if (findthing.Count > 0)
                    {
                        foreach (var VARIABLE2 in findthing)
                        {
                            float cj = float.Parse(VARIABLE2.成绩);
                            {
                                if (cj >= 60)
                                {
                                    chongxiuguode.Add(VARIABLE2);
                                }
                            }
                            
                        }
                    }
                }

                foreach (var VARIABLE in chongxiuguode)
                {
                    label9.Text = "移除修过的成绩:" + VARIABLE.SRID + "_课程名" + VARIABLE.课程名称;
                    stureportsbujige.RemoveAll(n => n.CCID == VARIABLE.CCID);
                }

                var zzcjd = new zuihouchengjidan();
                var gongxuankeliebiao=stureportsjingchengjidan.FindAll(n => n.Csort == "2" && float.Parse(n.成绩) >= (float) 60).ToList();
                var chongfugongxuanke = new List<vw_StuReport>();
                foreach (var VARIABLE in gongxuankeliebiao)
                {
                    if (
                        gongxuankeliebiao.FindAll(
                            n =>
                                n.CCID == VARIABLE.CCID && n.SRID != VARIABLE.SRID &&
                                float.Parse(n.成绩) > float.Parse(VARIABLE.成绩)).Count > 0)
                    {
                        chongfugongxuanke.Add(VARIABLE);
                    }
                }
                foreach (var VARIABLE in chongfugongxuanke)
                {
                    gongxuankeliebiao.RemoveAll(n => n.SRID == VARIABLE.SRID);
                }

                zzcjd.学号 = Student.StdCode;
                zzcjd.姓名 = Student.StdName;
                zzcjd.全过程成绩 = zhuanhuanchengji(stureportsall.OrderBy(n => n.TermName).ToList());
                zzcjd.最终成绩 = zhuanhuanchengji(stureportsjingchengjidan.OrderBy(n => n.TermName).ToList());
                zzcjd.修读的公选课 = zhuanhuanchengji(gongxuankeliebiao.OrderBy(n => n.TermName).ToList());
                zzcjd.公选课学分 = gongxuankeliebiao.Count*2;
                zzcjd.仍不及格成绩 = zhuanhuanchengji(stureportsbujige.OrderBy(n => n.TermName).ToList());

                var s = DataBase.Context.From<vw_Student>().Where(n => n.StdID == Student.StdID).ToFirst();
                zzcjd.学院 = s.系部;
                zzcjd.专业 = s.专业;
                zzcjd.班级 = s.班级;
                foreach (var VARIABLE in stureportsbujige)
                {
                    if (VARIABLE.学分.HasValue)
                    {
                        zzcjd.仍不及格学分 = zzcjd.仍不及格学分 + Convert.ToInt32(VARIABLE.学分);
                    }
                }
                studentchengjidan.Add(zzcjd);
                currentstunum = currentstunum + 1;
                progressBar1.Value = (int)(((float)currentstunum / (float)howmanystudent) * (float)100);
                backgroundWorker1.ReportProgress(currentstunum);
            }


            label5.Text = "任务完成！正在保存EXCEL";
            bool finderr = false;
            string title = DateTime.Now.ToFileTime().ToString();
            string filefullname = System.Environment.CurrentDirectory + @"\" + title + ".xlsx";
            MessageBox.Show(filefullname);
            if (System.IO.File.Exists(filefullname))
            {
                try
                {
                    System.IO.File.Delete(filefullname);

                }
                catch
                {
                    finderr = true;
                    MessageBox.Show("文件占用中无法删除！");
                }
            }

            try
            {

                MakeExcelModel MEM = new MakeExcelModel();
                MEM.Filename = filefullname;
                MEM.TitleName = title;
                MEM.PassWord = "";
                //MEM.HeaderText = new List<string>();


                MEM.dataTable = ToDataTable(studentchengjidan);
                var l = new List<string>();
                foreach (var VARIABLE in studentchengjidan[0].GetType().GetProperties())
                {
                    l.Add(VARIABLE.Name);
                }

                MEM.HeaderText = l;
                ExcelHelper.SaveToExcel(MEM);
            }
            catch (Exception ef)
            {
                finderr = true;
                MessageBox.Show("文件占用中无法生成！" + ef.ToString());

            }
            if (System.IO.File.Exists(filefullname) & finderr == false)
            {
                try
                {
                    System.Diagnostics.Process.Start(filefullname);
                }
                catch
                {

                    MessageBox.Show("当前系统没有安装EXCEL,或者EXCEL注册信息不全，无法自动打开生成的EXCEL，请手工打开！");
                }

            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var a = (float) e.ProgressPercentage/(float) howmanystudent;
            float b = 100;


            progressBar1.Value = Convert.ToInt32(a*b);
            label5.Text =  e.ProgressPercentage+@"/"+howmanystudent+"完成"+ (((float)e.ProgressPercentage / (float)howmanystudent) * 100).ToString("0.00")+"%";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
            
        }
    }
}
