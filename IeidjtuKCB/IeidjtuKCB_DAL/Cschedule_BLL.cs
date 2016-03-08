using System.Collections.Generic;
using System.Linq;
using IeidjtuKCB.DAL;
using IeidjtuKCB.Model;
using System.Data;
using IeidjtuKCB.Interface;
using IeidjtuKCB.Common;

namespace IeidjtuKCB.BLL
{
    public class Cschedule_BLL :IBaseBLL<Vw_Cschedule> 
    {
        public List<Vw_Cschedule> GetAllEntityFromDAL()
        {
            return GetEntityFromDAL(0);
        }

        public List<Vw_Cschedule> GetEntityFromDAL(int Atyid)
        {
            
            Cschedule_DAL Cs_DAL = new Cschedule_DAL();
            return Cs_DAL.GetEntityFromDB(Atyid);

        }

        public DataTable GetKCBFormVw_Cschedule_ForAtyID(int AtyID)
        {
            
            return ListHelper.ListToDataTable(GetEntityFromDAL(AtyID).Where(d=>d.TCID!=null).Select(d => new { d.CCode, d.CCname,d.TCName,d.Havenum,d.PsName,d.StartW,d.EndW,d.DSZ,d.DayOfWeek,d.SectionTH,d.BuildName,d.CRname,d.PsNumber}).ToList());
        }

       
    }
}
