
using System.Collections.Generic;
using IeidjtuKCB.Model;
using IeidjtuKCB.Common;
using IeidjtuKCB.DBSession;
using IeidjtuKCB.Interface;
using System;

namespace IeidjtuKCB.DAL
{/// <summary>
/// 
/// </summary>
    public class Activeyear_DAL:IBaseDAL<Activeyear>
    {
       

        public List<Activeyear> GetAllEntityFromDB()
        {
            return DataBase.Context.From<Activeyear>()
                            .Select(d => new { d.ATID, d.ATName, d.PKstate, d.State })
                            .OrderBy(Activeyear._.ATID.Desc)
                            .ToList();
        }

        public List<Activeyear> GetEntityFromDB(int id)
        {
                return id <= 0 ? DataBase.Context.From<Activeyear>()
                            .Select(d => new { d.ATID, d.ATName, d.PKstate, d.State })
                            .OrderBy(Activeyear._.ATID.Desc)
                            .ToList() : DataBase.Context.From<Activeyear>()
                            .Select(d => new { d.ATID, d.ATName, d.PKstate, d.State })
                            .Where(d => d.ATID == id)
                            .OrderBy(Activeyear._.ATID.Desc)
                            .ToList();
        }
    }
}
