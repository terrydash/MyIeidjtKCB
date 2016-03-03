using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using IeidjtuKCB.Common;
using IeidjtuKCB.BLL;
using System.Windows.Forms;
using IeidjtuKCB.UI.Common;
using System.Threading;

namespace IeidjtuKCB.UI
{
   
    public partial class MainForm : Form
    {
        /// <summary>
        /// 用作多线程读取数据库更新用用的委托
        /// </summary>
        /// <param name="Atyid"></param>
        private MainFormEnum.BindDataBaseToUI TaskId = MainFormEnum.BindDataBaseToUI.NothingToDo;
        private DataTable dt=null;
        private delegate DataTable BindVw_CscheduleToGridViewCallBack(int actyear);
        private delegate void BindEntityToComboBoxCallBack(ComboBox combobox);
        private delegate void BindEntityToGridViewCallBack(DataGridView dGV);
        private delegate void DisplayDataGridViewDelegate(DataTable myTable);
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindEntityToComboBoxCallBack d = new BindEntityToComboBoxCallBack(MainFormUIBind.ComboBoxBind.BindActiveYearEntitytoCombobox);
            BindEntityToComboBoxCallBack c = new BindEntityToComboBoxCallBack(MainFormUIBind.ComboBoxBind.BindDepartmentEntitytoCombobox);
            this.BeginInvoke(d, new object[] { comboBox_Activeyear });
            this.BeginInvoke(c, new object[] { comboBox_Department_For_Teacher });
            

        }
        private void comboBox_Activeyear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Activeyear.Items.Count>0)
            {
                TaskId = MainFormEnum.BindDataBaseToUI.BindVwCscheduleEntityToGridview;
                    if (!backgroundWorker.IsBusy)
                    { 
                            backgroundWorker.RunWorkerAsync((int)ConvertMethod.ConvertStringToInt(comboBox_Activeyear.SelectedValue.ToString()));
                    }
            }
        }

        private void  BindVw_CscheduleToGridView(int Atyid)
        { try
                { 
                    Cschedule_BLL Cs_BLL = new Cschedule_BLL();
                    dt = ListMethod.ListToDataTable(Cs_BLL.GetAllVw_CscheduleList(Atyid));                   
                    Cs_BLL = null; }
                catch (Exception ex)
                {
                    MessageBox.Show("程序发生错误,信息: " + ex.Message);
                }
        }
        private void Btn_FindTeacher_Click(object sender, EventArgs e)
        {
            int SelectItemID = 0;
            if (comboBox_Department_For_Teacher.Items.Count > 0)
            {
                SelectItemID = (int)ConvertMethod.ConvertStringToInt(comboBox_Department_For_Teacher.SelectedValue.ToString());
                TaskId = MainFormEnum.BindDataBaseToUI.BindTeacherEntityToGridview;
                ArgumentsModelForUI.FindTeacher findT = new ArgumentsModelForUI.FindTeacher();
                findT.FindTeacher_ID = SelectItemID;
                findT.FindTeacher_Name = textBox_TeacherNameToFind.Text;
                backgroundWorker.RunWorkerAsync(findT);

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
                        ArgumentsModelForUI.FindTeacher findT = (ArgumentsModelForUI.FindTeacher)e.Argument;
                        Teacher_BLL T_BLL = new Teacher_BLL();
                        
                       dt = ListMethod.ListToDataTable(T_BLL.GetTeacherEntityFromDAL(findT.FindTeacher_ID,findT.FindTeacher_Name));

                       
                    }
                    break;
                case MainFormEnum.BindDataBaseToUI.BindActiveYearEntityToComboBox:
                    break;
                case MainFormEnum.BindDataBaseToUI.BindVwCscheduleEntityToGridview:
                    if (e.Argument != null)
                    {
                        int id = (int)e.Argument;

                        BindVw_CscheduleToGridView(id);
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
    }
}
