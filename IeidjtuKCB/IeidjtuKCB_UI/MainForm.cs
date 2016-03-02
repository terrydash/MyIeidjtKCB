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


namespace IeidjtuKCB.UI
{

    public partial class MainForm : Form
    {
        
        DataTable EntityModelToDataTable = null;
        MainFormEnum.BindDataBaseToUI DoWorkState=MainFormEnum.BindDataBaseToUI.NothingToDo;
        /// <summary>       
        /// 用作多线程读取数据库更新用用的委托
        /// </summary>
        /// <param name="Atyid"></param>
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

            DoWorkState = MainFormEnum.BindDataBaseToUI.BindTeacherEntityToGridview;
            BackgroudWorkerForDataBase.RunWorkerAsync();
        }

        private void comboBox_Activeyear_SelectedIndexChanged(object sender, EventArgs e)
        {          
            if (comboBox_Activeyear.SelectedValue.ToString().Length!=0)
            {
                DoWorkState = MainFormEnum.BindDataBaseToUI.BindTeacherEntityToGridview;
                BackgroudWorkerForDataBase.RunWorkerAsync();
            }
            else
            {

            }
        }

        private void BindVw_CscheduleToGridView(int Atyid)
        {
            {
                try
                {
                    Cschedule_BLL Cs_BLL = new Cschedule_BLL();
                    var ALLVw_CscheduleList = Cs_BLL.GetAllVw_CscheduleList(Atyid);
                    dataGridView1.DataSource = ALLVw_CscheduleList;
                    Cs_BLL = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("程序发生错误,信息: " + ex.Message);
                }
            }
        }

        private void Btn_FindTeacher_Click(object sender, EventArgs e)
        {
           
            if (comboBox_Department_For_Teacher.Items.Count > 0)
            {

                //MainFormUIBind.DataGridViewBind.BindTeacherEntityToDataGridView(dataGridView_Teacher, SelectItemID,textBox_TeacherNameToFind.Text);
                
                
            }
        }
        /// <summary>
        /// 异步读取数据库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackgroudWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            switch (DoWorkState)
            {
                case MainFormEnum.BindDataBaseToUI.BindTeacherEntityToGridview:
                    if (BackgroudWorkerForDataBase.CancellationPending) { e.Cancel = true;break; }
                    int SelectItemID = 0;
                    ConvertMethod cm = new ConvertMethod();
                    cm.ConvertStringToInt(SelectItemID.ToString());
                    Cschedule_BLL Cs_BLL = new Cschedule_BLL();
                    EntityModelToDataTable = ListMethod.ListToDataTable(Cs_BLL.GetAllVw_CscheduleList(SelectItemID));                    
                    break;
                case MainFormEnum.BindDataBaseToUI.BindActiveYearEntityToComboBox:
                    ActiveYear_BLL Ay_BLL = new ActiveYear_BLL();
                    var EntityModel = Ay_BLL.GetActiveYearForComboBox();
                    break;
                default:
                    break;
            }
        }

        private void BackgroudWorkerForDataBase_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (((e.Cancelled == false )|( e.Error == null)) &&(EntityModelToDataTable !=null))
            {
                switch (DoWorkState)
                {
                    case MainFormEnum.BindDataBaseToUI.BindTeacherEntityToGridview:
                        
                            try
                            {
                                UICommonDataBind.BindDataGridView(dataGridView1, EntityModelToDataTable);                                
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("程序发生错误,信息: " + ex.Message);
                            }
                           finally
                            {
                                EntityModelToDataTable = null;
                                DoWorkState = MainFormEnum.BindDataBaseToUI.NothingToDo;
                            }
                    case MainFormEnum.BindDataBaseToUI.BindActiveYearEntityToComboBox:
                        try
                        {
                           // UICommonDataBind.BindComboBox(combo)
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("程序发生错误,信息: " + ex.Message);
                        }
                        finally
                        {
                            EntityModelToDataTable = null;
                            DoWorkState = MainFormEnum.BindDataBaseToUI.NothingToDo;
                        }

                        break;
                    default:
                        break;
                }

            }
        }
    }
}
