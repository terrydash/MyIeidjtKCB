using System.Collections.Generic;
using IeidjtuKCB.Model;
using IeidjtuKCB.Common;
using IeidjtuKCB.DBSession;

namespace IeidjtuKCB.DAL
{
    public class Cschedule_DAL

    {
        public List<Vw_Cschedule> GetAllVw_CscheduleListFromAtyid(int Atyid)
        {

            return Atyid <= 0 ? DB.Context.From<Vw_Cschedule>()
                            
                            
                            .ToList() : DB.Context.From<Vw_Cschedule>()
                            
                            .Where(d => d.AtyID == Atyid)
                            
                            .ToList();
        }
    }
}
