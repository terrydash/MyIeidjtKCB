using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IeidjtuKCB.DBSession;
using IeidjtuKCB.Model;
using IeidjtuKCB.Interface;

namespace IeidjtuKCB.DAL
{
    public class Vw_Teacher_Dal : IBaseDAL<vw_Rsda>

    {
        public List<vw_Rsda> GetAllEntityFromDB()
        {
            return GetEntityFromDB(0);
        }

        public List<vw_Rsda> GetEntityFromDB(int id)
        {
            return id <= 0 ? DB.Context.From<vw_Rsda>()
                            .Select(d => new { d.PSID,d.PsName,d.Password,d.StandCode,d.DeptCode})
                            .OrderBy(vw_Rsda._.PSID.Asc)
                            .ToList() : DB.Context.From<vw_Rsda> ()
                            .Select(d => new { d.PSID, d.PsName, d.Password, d.StandCode, d.DeptCode })
                            .Where(d => d.PSID == id)
                            .OrderBy(vw_Rsda._.PSID.Asc)
                            .ToList();
        }
    }
}
