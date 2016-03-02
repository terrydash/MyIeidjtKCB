using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IeidjtuKCB.BLL;
using IeidjtuKCB.Model;
namespace IeidjtuKCB.UI.Common
{/// <summary>
/// 主界面 控件绑定 方法 封装
/// </summary>
    public static class MainFormUIBind
    {   /// <summary>
        /// 针对DataGridView绑定的封装
        /// </summary>
        public static class DataGridViewBind
        {
            public static void BindTeacherEntityToDataGridView(DataGridView dGV,int DeptID,string TeacherName)
            {       try
                {
                    Teacher_BLL T_Bll = new Teacher_BLL();              
                    UICommonDataBind.BindDataGridView(dGV, T_Bll.GetTeacherEntityFromDAL(DeptID,TeacherName));
                }
                    catch
                {

                }
            }


        }
        /// <summary>
        /// 针对ComboBox绑定的封装
        /// </summary>
        public static class ComboBoxBind
        {

            public static void BindActiveYearEntitytoCombobox (ComboBox comboBox)
            {
                try
                {
                    ActiveYear_BLL ActiveYearBLL = new ActiveYear_BLL();
                    var AllActiveYearList = ActiveYearBLL.GetActiveYearForComboBox();
                    UICommonDataBind.BindComboBox(comboBox, AllActiveYearList, "ATName", "ATID", "--所有学期--");
                    comboBox.SelectedValue = AllActiveYearList.Find(d => d.State == "当前").ATID;
                    ActiveYearBLL = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("程序发生错误,信息: " + ex.Message);
                }

            }
            public static void BindDepartmentEntitytoCombobox(ComboBox comboBox)
            {
                try
                {
                   Department_BLL D_Dal = new Department_BLL();
                    var DepartmentList = D_Dal.GetAllEntityFromDAL() ;
                    UICommonDataBind.BindComboBox(comboBox, DepartmentList, "DeptName", "DeptID", "--所有部门--");
                    //comboBox.SelectedValue = DepartmentList.Find(d => d.DeptID == "0").DeptID;
                    D_Dal = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("程序发生错误,信息: " + ex.Message);
                }

            }
            

        }
    }
}
