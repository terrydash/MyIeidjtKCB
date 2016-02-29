using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IeidjtuKCB.Model
{/// <summary>
/// 课程表抽象实体 便于生成课程用
/// </summary>
/// <typeparam name="T"></typeparam>
    public  partial class KCB<T>
    {   /// <summary>
    /// 
    /// </summary>
        private string CourseName
        { get; set; }         //课程名称
        private string TeacherName
        { get; set; }         //任课教师姓名
        private int Week { get; set; }                  //上课星期
        private int? StartWeek { get; set; }           //起始周
        private int? EndWeek { get; set; }             //结束周
        private string SingleOrDouble { get; set; }     //单双周
        private string RoomName { get; set; }       //上课教室
        private int? TCID { get; set; }              //TeachAndClass(聘课表)的ID
        private int? PSID { get; set; }              //RSDA(教师表) 的ID
        private int? CCID { get; set; }              //Curricula (课程库表)的ID
        private int? CSID { get; set; }              //Cshe (课程库表)的ID

    }
    

}
