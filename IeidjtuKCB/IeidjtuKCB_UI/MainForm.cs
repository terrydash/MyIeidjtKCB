using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using IeidjtuKCB.Common;
using IeidjtuKCB.BLL;
using System.Windows.Forms;
using IeidjtuKCB.UI.Common;


namespace IeidjtuKCB.UI
{
   /// <summary>
   /// 主页面
   /// </summary>
    public partial class MainForm : Form
    {
        #region 变量声明
        /// <summary>
        /// 为便于异步读取执行操作设置的要操作的ID
        /// </summary>
        private MainFormEnum.BindDataBaseToUI TaskId = MainFormEnum.BindDataBaseToUI.NothingToDo;
        /// <summary>
        /// 绑定用的空DataTable
        /// </summary>
        private DataTable dt=null;

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

            if (comboBox_Department_For_Teacher.SelectedValue !=null)
            {
                int deptid =ConvertHelper.ConvertStringToInt( comboBox_Department_For_Teacher.SelectedValue.ToString());
                string teachername = textBox_TeacherNameToFind.Text.Trim();
                Teacher_BLL T_BLL = new Teacher_BLL();

                dt = ListHelper.ListToDataTable(T_BLL.GetTeacherEntityFromDAL(deptid, teachername));
                CommonUIDataBindMethod.BindDataGridView(dataGridView_Teacher, dt, ColumnHeaderTextModel.Teacher.TeacherForDataGridView.ColumnsNames(), ColumnHeaderTextModel.Teacher.TeacherForDataGridView.DisplayNames());
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
                        int id = (int)e.Argument;

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
                    if (dt!=null)
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
            if (comboBox_Activeyear.Items.Count>0)
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
                string title="大连科技学院" + A_BLL.GetAllEntityFromDAL().Find(d => d.ATID == atyid).ATName + "课程表";
                string filefullname = System.Environment.CurrentDirectory  +@"\"+title+".xlsx";
                
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
                    MEM.dataTable = C_BLL.GetKCBFormVw_Cschedule_ForAtyID(atyid);
                    MEM.HeaderText = new List<string> { "课程代码", "课程名称", "教学班级名称", "人数", "任课教师", "起始周", "结束周", "单双周", "星期", "节数", "教学楼", "教室", "教室容纳人数" };
                    ExcelHelper.SaveToExcel(MEM);
                }
                catch
                {
                    finderr = true;
                    MessageBox.Show("文件占用中无法生成！");

                }
                    if (System.IO.File.Exists(filefullname) & finderr==false)
                    {
                       System.Diagnostics.Process.Start(filefullname);
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
                    backgroundWorker.RunWorkerAsync((int)ConvertHelper.ConvertStringToInt(comboBox_Activeyear.SelectedValue.ToString()));
                }
            }
        }

        private void dataGridView_Teacher_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void buttonToTeacherKCB_Click(object sender, EventArgs e)
        {
            if (dataGridView_Teacher.Rows.Count > 0)
            {
                if (dataGridView_Teacher.SelectedRows.Count>0 & dataGridView_Teacher.SelectedCells[0]!=null)
                { 
                    MessageBox.Show(dataGridView_Teacher.SelectedCells[0].Value.ToString());
                }
            }
        }
    }
}
