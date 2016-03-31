using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IeidjtuKCB.Common;
using System.IO;
using IeidjtuKCB.BLL;
using IeidjtuKCB.Model;


namespace IeidjtuKCB.UI.Common
{
    public static class MakeKCBShowinBrowers
    {
        public static bool MakeTeacherKCBShowinBrowers(int AtyID, int PSID,string writefilename)
        {   if (AtyID<=0)
            {
                return false;
            }
            StringBuilder filecontent = new StringBuilder();
            string filefullname = System.Environment.CurrentDirectory + @"\ShowKCBForTeacher.html";            
            if (File.Exists(filefullname))
            {
                try
                {
                    filecontent = FileHelper.ReadFile(filefullname);
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("读取模板失败");
                    return false;
                }
                
            
            List<ReplaceTagModel> RTMList = new List<ReplaceTagModel>();
            Cschedule_BLL C_BLL = new Cschedule_BLL();
            ActiveYear_BLL A_BLL = new ActiveYear_BLL();
            var actyearname = A_BLL.GetAllEntityFromDAL().Find(d => d.ATID == AtyID).ATName;
            Vw_Teacher_BLL VT_BLL = new Vw_Teacher_BLL();
            Teacher_BLL T_BLL = new Teacher_BLL();
            var Teacher = T_BLL.GetAllEntityFromDAL().Find(d=>d.PSID==PSID);
            Department_BLL D_BLL = new Department_BLL();
            var KCBList = C_BLL.GetKCBFormvw_Cschedule_ForAtyIandPSID(AtyID, PSID);
            RTMList.Add(new ReplaceTagModel { TagName =KCBForTeaecherHTMLTag.ActYear(),TagValue =  actyearname});
            RTMList.Add(new ReplaceTagModel { TagName = KCBForTeaecherHTMLTag.TeacherName(), TagValue = Teacher.PsName }    );
            RTMList.Add(new ReplaceTagModel { TagName = KCBForTeaecherHTMLTag.TeacherCoder(), TagValue = Teacher.StandCode});
            RTMList.Add(new ReplaceTagModel { TagName = KCBForTeaecherHTMLTag.DeptName(), TagValue = D_BLL.GetAllEntityFromDAL().Find(d => d.DeptID ==Teacher.DeptId).DeptName });
            RTMList.Add(new ReplaceTagModel { TagName = KCBForTeaecherHTMLTag.TITLE(), TagValue = actyearname + Teacher.PsName + "的课程表" });
                var kcblist = KCBList.OrderBy(d => d.Week).ThenBy(d => d.Section).ThenBy(d => d.StartWeek);
                if (kcblist!=null)
                { 
                    foreach (var kCB in kcblist)
                    {
                         var rtm=RTMList.Find(d => d.TagName == KCBForTeaecherHTMLTag.KCBDayAndSection(kCB.Week, kCB.Section));
                         if (rtm!=null)
                            {
                                if (!string.IsNullOrWhiteSpace(rtm.TagValue))
                                    {
                                        rtm.TagValue = rtm.TagValue + "<br>" + kCB.CourseName + "→" + kCB.TCName + "&nbsp第" + kCB.StartWeek.ToString() + "-" + kCB.EndWeek.ToString() + "周&nbsp" + kCB.RoomName;
                                     }
                            }
                            else
                            {
                                RTMList.Add(new ReplaceTagModel { TagName = KCBForTeaecherHTMLTag.KCBDayAndSection(kCB.Week, kCB.Section), TagValue = kCB.CourseName + "→" + kCB.TCName + "&nbsp第" + kCB.StartWeek.ToString() + "-" + kCB.EndWeek.ToString() + "周&nbsp" +kCB.RoomName } )  ; 
                             }
                       }
                }       
                foreach (var item in RTMList)
            {
                    filecontent.Replace(item.TagName, item.TagValue);
                    
                    
             }
             
            foreach (var item in KCBForTeaecherHTMLTag.KCBDayAndSection())
                {
                    filecontent.Replace(item, string.Empty);
                }
            try
            {
                FileHelper.WriteFile(writefilename , filecontent);
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("写入文件失败");
                return false;
            }
            return true;
            }
            else {
                System.Windows.Forms.MessageBox.Show("模板文件"+ filefullname + "不存在");
                return false;
            }
            


        }
    }
}
