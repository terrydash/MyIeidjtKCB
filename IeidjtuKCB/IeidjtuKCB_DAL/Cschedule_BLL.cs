using System.Collections.Generic;
using System.Linq;
using IeidjtuKCB.DAL;
using IeidjtuKCB.Model;
using System.Data;
using IeidjtuKCB.Interface;
using IeidjtuKCB.Common;
using System;

namespace IeidjtuKCB.BLL
{
    public class Cschedule_BLL :IBaseBLL<vw_Cschedule> ,IGetKcb<KCB>
    {
        public List<vw_Cschedule> GetAllEntityFromDAL()
        {
            return GetEntityFromDAL(0);
        }

        public List<vw_Cschedule> GetEntityFromDAL(int Atyid)
        {
            
            Cschedule_DAL Cs_DAL = new Cschedule_DAL();
            return Cs_DAL.GetEntityFromDB(Atyid);

        }

       

        public List<KCB> GetKCBFormvw_Cschedule_ForAtyIandPSID(int AtyID, int PSID)
        {
            var itemlist = GetEntityFromDAL(AtyID).Where(d => d.TCID != null & d.PSID == PSID).Select(d => new { d.CCode, d.CCname, d.TCName, d.havenum, d.PsName, d.StartW, d.EndW, d.DSZ, d.DayOfWeek, d.SectionTH, d.BuildName, d.CRname, d.PsNumber, d.TCID, d.PSID, d.AtyID, d.CCID, d.CRID, d.CSID }).OrderBy(d => d.StartW).ThenBy(d => d.DayOfWeek).ThenBy(d => d.SectionTH).ToList();

            if (itemlist.Count > 0)
            {
                List<KCB> KCBList = new List<KCB>();
                foreach (var item in itemlist)
                {
                    KCB kcb = new KCB();
                    kcb.CCID = item.CCID;
                    kcb.TCID = item.TCID;
                    kcb.TeacherName = item.PsName;
                    kcb.CourseName = item.CCname;
                    kcb.CSID = item.CSID;
                    kcb.PSID = item.PSID;
                    kcb.SingleOrDouble = item.DSZ;
                    kcb.StartWeek = item.StartW;
                    kcb.EndWeek = item.EndW;
                    kcb.Week = item.DayOfWeek;
                    kcb.Section = item.SectionTH;
                    kcb.TCName = item.TCName;
                    kcb.RoomName = item.CRname;
                    KCBList.Add(kcb);
                    kcb = null;
                }
                return KCBList;
            }
            return null;
        }

      

        public List<KCB> GetKCBFormvw_Cschedule_ForAtyIandTCID(int AtyID, int TCID)
        {
             var itemlist= GetEntityFromDAL(AtyID).Where(d => d.TCID != null & d.TCID == TCID).Select(d => new { d.CCode, d.CCname, d.TCName, d.havenum, d.PsName, d.StartW, d.EndW, d.DSZ, d.DayOfWeek, d.SectionTH, d.BuildName, d.CRname, d.PsNumber, d.TCID, d.PSID, d.AtyID, d.CCID, d.CRID,d.CSID }).OrderBy(d=>d.StartW).ThenBy(d=>d.DayOfWeek).ThenBy(d=>d.SectionTH).ToList();
            
            if (itemlist.Count>0)
            {
                List<KCB> KCBList = new List<KCB>();
                foreach (var item in itemlist )
                {
                    KCB kcb = new KCB();
                    kcb.CCID = item.CCID;
                    kcb.TCID = item.TCID;
                    kcb.TeacherName = item.PsName;
                    kcb.CourseName = item.CCname;
                    kcb.CSID = item.CSID;
                    kcb.PSID = item.PSID;
                    kcb.SingleOrDouble = item.DSZ;
                    kcb.StartWeek = item.StartW;
                    kcb.EndWeek = item.EndW;
                    kcb.Week = item.DayOfWeek;
                    kcb.Section=item.SectionTH;
                    KCBList.Add(kcb);
                    kcb = null;
                }
                return KCBList;
            }
            return null;

        }

       

        public DataTable GetKCBFormvw_Cschedule_ForAtyID(int AtyID)
        {
            
            return ListHelper.ListToDataTable(GetEntityFromDAL(AtyID).Where(d=>d.TCID!=null).Select(d => new { d.CCode, d.CCname,d.TCName,d.havenum, d.PsName,d.StartW,d.EndW,d.DSZ,d.DayOfWeek,d.SectionTH,d.BuildName,d.CRname,d.PsNumber}).ToList());
        }
        public void ShowKCBForTeacher(int AtyID,int PSID)
        {



        }


       
    }
}
