using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IeidjtuKCB.DAL;
using IeidjtuKCB.Model;

namespace IeidjtuKCB.BLL
{
    public class Cschedule_BLL
    {
        public List<Vw_Cschedule> GetAllVw_CscheduleList(int Atyid)
        {
            Cschedule_DAL Cs_DAL = new Cschedule_DAL();
            return Cs_DAL.GetAllVw_CscheduleListFromAtyid(Atyid);

        }
    }
}
