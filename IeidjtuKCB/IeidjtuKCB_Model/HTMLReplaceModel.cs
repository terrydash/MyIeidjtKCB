using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IeidjtuKCB.Model
{       /// <summary>
        /// 用于替换HTML文件里的标签类
        /// </summary>
        public static class KCBForTeaecherHTMLTag
        {
        public static string TITLE()
        { return "[TITLE]".ToUpper(); }         //HTML的标题
        public static string TeacherName()
        { return "[TEACHERNAME]".ToUpper();}         //教师名字
        public static string ActYear()
        { return "[ACTYEAR]".ToUpper();}        //当前学年
        public static string TeacherCoder()
        { return "[TEACHERCODE]".ToUpper(); }   //教师编号
        public static string DeptName()
        { return "[DEPTNAME]".ToUpper(); }
        public static List<string> Section()
        {
            return new List<string> { "1-2节", "3-4节", "5-6节","7-8节","9-10节","11-12节","13-14节" };
        }
        public static List<string> KCBDayAndSection()     //用于清空没有课程表的空白标记
        {
            List<string> StrList = new List<string>();
            for (int i = 1; i <= 7; i++)
            {
                foreach (var item in Section())
                {
                    StrList.Add(("[DAY" + i.ToString() + "_" + item + "]").ToUpper());

                }
            }
            return StrList;
        }
        /// <summary>
        /// 课程表具体在哪节
        /// </summary>
        /// <param name="dayofweek">星期几</param>
        /// <param name="section">哪节课</param>
        /// <returns>在HTML里的标记</returns>
        public static string KCBDayAndSection(int? dayofweek,string section)     //课程表具体再
        { return ("[DAY" + dayofweek.ToString() + "_" + section + "]").ToUpper();        }

    }/// <summary>
     /// 课程表抽象实体 便于生成课程用
     /// </summary>
     /// <typeparam name="T"></typeparam>
    public partial class KCB
    {  
     
        public string CourseName
        { get; set; }         //课程名称
        public string TeacherName
        { get; set; }         //任课教师姓名
        public int? Week { get; set; }                  //上课星期
        public int? StartWeek { get; set; }           //起始周
        public int? EndWeek { get; set; }             //结束周
        public string SingleOrDouble { get; set; }     //单双周
        public string RoomName { get; set; }       //上课教室
        public int? TCID { get; set; }              //TeachAndClass(聘课表)的ID
        public int? PSID { get; set; }              //RSDA(教师表) 的ID
        public int? CCID { get; set; }              //Curricula (课程库表)的ID
        public int? CSID { get; set; }              //Cshe (课程库表)的ID
        public string Section { get; set; }              //上课的节数
        public string TCName { get; set; }              //教学班级名称
    }
   
    

}
