using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IeidjtuKCB.Common;
using IeidjtuKCB.DBSession;
using IeidjtuKCB.Model;
using IeidjtuKCB.Interface;
namespace IeidjtuKCB.DAL
{
    public class Department_DAL:IBaseDAL<Vw_DeptMent>
    {
        

        public List<Vw_DeptMent> GetAllEntityFromDB()
        {
            return GetEntityFromDB(0);
        }

        public List<Vw_DeptMent> GetEntityFromDB(int id)
        {
            return id <= 0 ? DB.Context.From<Vw_DeptMent>()
                            .Select(d => new { d.DeptID, d.DeptName, d.DeptCode, d.Tel })
                            .OrderBy(Vw_DeptMent._.DeptID.Asc)
                            .ToList() : DB.Context.From<Vw_DeptMent>()
                            .Select(d => new { d.DeptID, d.DeptName, d.DeptCode, d.Tel })
                            .Where(d => d.DeptID == id)
                            .OrderBy(Vw_DeptMent._.DeptID.Asc)
                            .ToList();
        }
    }
}
