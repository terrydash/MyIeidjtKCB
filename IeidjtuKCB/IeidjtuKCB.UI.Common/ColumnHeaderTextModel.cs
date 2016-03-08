using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IeidjtuKCB.Model;

namespace IeidjtuKCB.UI.Common
{   /// <summary>
/// 为绑定控件提供 题头对应关系的类
/// </summary>
    public static class ColumnHeaderTextModel
    {
        
        public static class Teacher
        {   
            /// <summary>
            /// 教师绑定到GridView所需的列表头和字段的对应关系
            /// </summary>
            public static class TeacherForDataGridView
            {   
               
                public static List<string> ColumnsNames ()
                {
                    List<string> ColumnsName = new List<string> ();
                ColumnsName.Add("PSID");
                ColumnsName.Add("StandCode"); 
                ColumnsName.Add("PsName"); 
                ColumnsName.Add("Password"); 
                ColumnsName.Add("Sex"); 
                return ColumnsName;
            }
                public static List<string>  DisplayNames ()
                {
                    List<string> DisplayName = new List<string>();
                     DisplayName.Add("ID");
                     DisplayName.Add("编码");
                     DisplayName.Add("教师姓名");
                     DisplayName.Add("密码");
                     DisplayName.Add("性别");
                     return DisplayName;


                }
            }
        }
    }
}
