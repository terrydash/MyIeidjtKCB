using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IeidjtuKCB.UI.Common
{
    
    public static class MainFormEnum
    {
        public enum BindDataBaseToUI
        {   NothingToDo=0,
            /// <summary>
            /// 根据所选系部查找认可教师
            /// </summary>
            BindTeacherEntityToGridview = 1,
            /// <summary>
            /// 将学年信息绑定到下拉框
            /// </summary>
            BindActiveYearEntityToComboBox=2,
            /// <summary>
            /// 根据所选学期信息绑定课程表到Gridview
            /// </summary>
            BindVwCscheduleEntityToGridview = 3,
        }
    }
}
