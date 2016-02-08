using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IeidjtuKCB_BLL;
using IeidjtuKCB_Model;

namespace IeidjtuKCB_DAL
{
    public class Cschedule_DAL
    {
        public List<Vw_Cschedule> GetAllVw_CscheduleList(int Atyid)
        {
            Cschedule_BLL Cs_BLL = new Cschedule_BLL();
            return Cs_BLL.GetAllVw_CscheduleListFromAtyid(Atyid);

        }
    }
}
