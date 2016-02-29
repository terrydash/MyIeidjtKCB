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
    {
        /// <summary>
        /// 针对ComboBox绑定的封装
        /// </summary>
        public static class ComboBoxBind
        {

            public static void BindActiveYearEntitytoCombobox(ComboBox comboBox_Activeyear)
            {
                try
                {
                    ActiveYear_BLL ActiveYearDal = new ActiveYear_BLL();
                    var AllActiveYearList = ActiveYearDal.GetActiveYearForComboBox();
                    UICommonDataBind.BindComboBox(comboBox_Activeyear, AllActiveYearList, "ATName", "ATID", "--所有学期--");
                    comboBox_Activeyear.SelectedValue = AllActiveYearList.Find(d => d.State == "当前").ATID;
                    ActiveYearDal = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("程序发生错误,信息: " + ex.Message);
                }

            }

        }
    }
}
