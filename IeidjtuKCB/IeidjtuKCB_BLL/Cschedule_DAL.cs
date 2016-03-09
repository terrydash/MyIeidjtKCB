using System.Collections.Generic;
using IeidjtuKCB.Model;
using IeidjtuKCB.Common;
using IeidjtuKCB.DBSession;
using IeidjtuKCB.Interface;
using System.Linq.Expressions;
using System.Linq;
using System;
using System.Data;

namespace IeidjtuKCB.DAL
{
    public class Cschedule_DAL:IBaseDAL<Vw_Cschedule>

    {
        public List<Vw_Cschedule> GetEntityFromDB(int Atyid) 
        {

            return Atyid <= 0 ? DB.Context.From<Vw_Cschedule>()
                           
                            
                            .ToList() : 
                            DB.Context.From<Vw_Cschedule>()
                            
                            .Where(d => d.AtyID == Atyid)
                            
                            .ToList();
        }

      

        public List<Vw_Cschedule> GetAllEntityFromDB()
        {
            return GetEntityFromDB(0);
        }

        public DataTable GetKCBFormVw_Cschedule_ForAtyID(int AtyID)
        {
            throw new NotImplementedException();
        }

       
    }
}
