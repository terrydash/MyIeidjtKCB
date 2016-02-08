using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using IeidjtuKCB_Common;
using IeidjtuKCB_DAL;
using System.Windows.Forms;
using System.Threading;

namespace IeidjtuKCB_UI
{
   
    public partial class MainForm : Form
    {
        /// <summary>
        /// 用作多线程读取数据库更新用用的委托
        /// </summary>
        /// <param name="Atyid"></param>
        delegate void BindVw_CscheduleToGridViewCallBack(int Atyid);

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Invoke(new MethodInvoker(BindActiveYearEntitytoCombobox));
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
                    Cschedule_DAL Cs_DAL = new Cschedule_DAL();
                    var ALLVw_CscheduleList = Cs_DAL.GetAllVw_CscheduleList(Atyid);
                    dataGridView1.DataSource = ALLVw_CscheduleList;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("程序发生错误,信息: " + ex.Message);
                }
            }
        }
       

        private void BindActiveYearEntitytoCombobox()
        {
            try
            {
                ActiveYear_DAL ActiveYearDal = new ActiveYear_DAL();
                var AllActiveYearList = ActiveYearDal.GetActiveYearForComboBox();
                DataBindingControl.BindComboBox(comboBox_Activeyear, AllActiveYearList, "ATName", "ATID", "--所有学期--");
                comboBox_Activeyear.SelectedValue = AllActiveYearList.Find(d => d.State == "当前").ATID;
                ActiveYearDal = null;
            }
            catch(Exception ex)
            {
                MessageBox.Show("程序发生错误,信息: " + ex.Message);
            }

         }
    }
}
