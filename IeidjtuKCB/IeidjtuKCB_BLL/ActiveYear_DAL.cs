
using System.Collections.Generic;
using IeidjtuKCB.Model;
using IeidjtuKCB.Common;
using IeidjtuKCB.DBSession;


namespace IeidjtuKCB.DAL
{/// <summary>
/// 
/// </summary>
    public class Activeyear_DAL
    {
        public List<Activeyear> GetActiveYearList(int id)
        {

            return id <= 0 ? DB.Context.From<Activeyear>()
                            .Select(d => new { d.ATID, d.ATName, d.PKstate, d.State })                            
                            .OrderBy(Activeyear._.ATID.Desc)
                            .ToList() : DB.Context.From<Activeyear>()
                            .Select(d => new { d.ATID, d.ATName, d.PKstate, d.State })
                            .Where(d=>d.ATID==id)
                            .OrderBy(Activeyear._.ATID.Desc)
                            .ToList();
        }
       
    }
}
