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
    public class Department_DAL:IBaseDAL<vw_DeptMent>
    {
        

        public List<vw_DeptMent> GetAllEntityFromDB()
        {
            return GetEntityFromDB(0);
        }

        public List<vw_DeptMent> GetEntityFromDB(int id)
        {
            return id <= 0 ? DataBase.Context.From<vw_DeptMent>()
                            .Select(d => new { d.DeptID, d.DeptName, d.DeptCode, d.Tel })
                            .OrderBy(vw_DeptMent._.DeptID.Asc)
                            .ToList() : DataBase.Context.From<vw_DeptMent>()
                            .Select(d => new { d.DeptID, d.DeptName, d.DeptCode, d.Tel })
                            .Where(d => d.DeptID == id)
                            .OrderBy(vw_DeptMent._.DeptID.Asc)
                            .ToList();
        }
    }
}
