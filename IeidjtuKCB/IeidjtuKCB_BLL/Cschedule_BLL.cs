using System.Collections.Generic;
using IeidjtuKCB_Model;
using IeidjtuKCB_Common;

namespace IeidjtuKCB_BLL
{
    public class Cschedule_BLL
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
