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
        delegate void BindVw_CscheduleToGridViewCallBack(int Atyid);
        delegate void BindEntityToComboBoxCallBack(ComboBox combobox);
        delegate void BindEntityToGridViewCallBack(DataGridView dGV);
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
            this.Invoke(d, new object[] { comboBox_Activeyear });
            this.Invoke(c, new object[] { comboBox_Department_For_Teacher });


        }

        private void comboBox_Activeyear_SelectedIndexChanged(object sender, EventArgs e)
        {  int SelectItemID = 0;
            try
            {
                int.TryParse(comboBox_Activeyear.SelectedValue.ToString(),out SelectItemID);

            }

            catch (Exception ex)
            {
                MessageBox.Show("程序发生错误,信息: " + ex.Message);
            }
            if (SelectItemID > 0)
            {
                BindVw_CscheduleToGridViewCallBack d = new BindVw_CscheduleToGridViewCallBack(BindVw_CscheduleToGridView);
                this.Invoke(d, new object[] { SelectItemID });
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
            int SelectItemID = 0;
            if (comboBox_Department_For_Teacher.Items.Count > 0)
            {
                try
                {
                    int.TryParse(comboBox_Department_For_Teacher.SelectedValue.ToString(), out SelectItemID);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("程序发生错误,信息: " + ex.Message);
                }
                MainFormUIBind.DataGridViewBind.BindTeacherEntityToDataGridView(dataGridView_Teacher, SelectItemID,textBox_TeacherNameToFind.Text);

            }
        }
    }
}
