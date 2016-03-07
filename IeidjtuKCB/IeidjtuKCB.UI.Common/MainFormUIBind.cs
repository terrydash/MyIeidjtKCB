using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IeidjtuKCB.BLL;
using System.Data;


namespace IeidjtuKCB.UI.Common
{
    #region 主界面 控件绑定 方法 封装
    /// <summary>
    /// 主界面 控件绑定 方法 封装
    /// </summary>
    public static class MainFormUIBind
    {
        #region 控件通用的绑定方法
        /// <summary>
        /// 控件通用的绑定方法
        /// </summary>
        /// <typeparam name="BindArgumentEntity">用于绑定的参数</typeparam>
        /// <param name="C">控件</param>
        /// <param name="dt">要绑定的数据源</param>
        /// <param name="ArgumentEntitys">绑定的参数集合</param>
        #region  控件绑定公用程序
        public static void DataTableBindContorl<BindArgumentEntity>(Control C,DataTable dt,List<BindArgumentEntity> ArgumentEntitys)
        { if (dt!=null)
            { 
                
                if (C is ComboBox)
                {
                   
                }
                else if(C is DataGridView)
                {
                    DataGridViewBind.GetTeacherEntityToDataGridView((DataGridView)C,dt);
                }
            }


        }
        #endregion



        #endregion
        #region 针对DataGridView绑定的封装
        /// <summary>
        /// 针对DataGridView绑定的封装
        /// </summary>
        public static class DataGridViewBind
        {
            #region 绑定教师信息到GridView public static void GetTeacherEntityToDataGridView(DataGridView dGV,DataTable dt)
            /// <summary>
            /// 绑定教师信息到GridView
            /// </summary>
            /// <param name="dGV">要绑定的GridView</param>
            /// <param name="dt">绑定的DataTable</param>
            public static void GetTeacherEntityToDataGridView(DataGridView dGV,DataTable dt)
            {       try
                {
                    CommonUIDataBindMethod.BindDataGridView(dGV, dt, ColumnHeaderTextModel.Teacher.TeacherForDataGridView.ColumnsNames(), ColumnHeaderTextModel.Teacher.TeacherForDataGridView.DisplayNames());

                }
                    catch
                {

                }
            }
            #endregion
        }
        #endregion
        #region 针对ComboBox绑定的封装
        /// <summary>
        /// 针对ComboBox绑定的封装
        /// </summary>
        public static class ComboBoxBind
        {
            /// <summary>
            /// 绑定全部学年信息到ComboBox
            /// </summary>
            /// <param name="comboBox"></param>
            public static void BindActiveYearEntitytoCombobox (ComboBox comboBox)
            {
                try
                {
                    ActiveYear_BLL ActiveYearBLL = new ActiveYear_BLL();
                    var AllActiveYearList = ActiveYearBLL.GetActiveYearForComboBox();
                    CommonUIDataBindMethod.BindComboBox(comboBox, AllActiveYearList, "ATName", "ATID", "--所有学期--");
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
                    CommonUIDataBindMethod.BindComboBox(comboBox, DepartmentList, "DeptName", "DeptID", "--所有部门--");
                    //comboBox.SelectedValue = DepartmentList.Find(d => d.DeptID == "0").DeptID;
                    D_Dal = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("程序发生错误,信息: " + ex.Message);
                }

            }
            

        }
        #endregion
    }

    #endregion
}
