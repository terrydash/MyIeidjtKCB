using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IeidjtuKCB_Model;
using IeidjtuKCB_Common;


namespace IeidjtuKCB_BLL
{/// <summary>
/// 
/// </summary>
    public class Activeyear_BLL
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
