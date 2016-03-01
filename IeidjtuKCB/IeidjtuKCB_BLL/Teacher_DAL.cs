using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IeidjtuKCB.Model;
using IeidjtuKCB.DBSession;
using IeidjtuKCB.Interface;
namespace IeidjtuKCB.DAL
{
    public class Teacher_DAL : IBaseDAL<RSDA>
    {
        public List<RSDA> GetAllEntityFromDB()
        {
            return GetEntityFromDB(0);
        }

        public List<RSDA> GetEntityFromDB(int id)
        {
            return id <= 0 ? DB.Context.From<RSDA>()
                           .Select(d => new { d.PSID, d.PsName, d.Password, d.StandCode, d.DeptId,d.Sex })
                           .OrderBy(RSDA._.PSID.Asc)
                           .ToList() : DB.Context.From<RSDA>()
                           .Select(d => new { d.PSID, d.PsName, d.Password, d.StandCode, d.DeptId,d.Sex })
                           .Where(d => d.PSID == id)
                           .OrderBy(RSDA._.PSID.Asc)
                           .ToList();
        }
        public List<RSDA> GetTeacherEntityFromDBByDeptID(int DeptID,string TeacherName)
        {   if (TeacherName.Length == 0)
            {
                return DeptID <= 0 ? DB.Context.From<RSDA>()
                           .Select(d => new { d.PSID, d.PsName, d.Password, d.StandCode, d.DeptId, d.Sex })
                           .OrderBy(RSDA._.PSID.Asc)
                           .ToList() : DB.Context.From<RSDA>()
                           .Select(d => new { d.PSID, d.PsName, d.Password, d.StandCode, d.DeptId, d.Sex })
                           .Where(d => d.DeptId == DeptID)
                           .OrderBy(RSDA._.PSID.Asc)
                           .ToList();
            }
            else
            {
                return DB.Context.From<RSDA>()
                           .Select(d => new { d.PSID, d.PsName, d.Password, d.StandCode, d.DeptId, d.Sex })
                           .Where(d => d.DeptId == DeptID && d.PsName.Contains(TeacherName))
                           .OrderBy(RSDA._.PSID.Asc)
                           .ToList();
            }


            
        }
    }
}
