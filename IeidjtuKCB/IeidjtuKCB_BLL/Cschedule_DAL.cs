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
    public class Cschedule_DAL:IBaseDAL<vw_Cschedule>

    {
        public List<vw_Cschedule> GetEntityFromDB(int Atyid) 
        {

            return Atyid <= 0 ? DataBase.Context.From<vw_Cschedule>()
                           
                            
                            .ToList() : 
                            DataBase.Context.From<vw_Cschedule>()
                            
                            .Where(d => d.AtyID == Atyid)
                            
                            .ToList();
        }

      

        public List<vw_Cschedule> GetAllEntityFromDB()
        {
            return GetEntityFromDB(0);
        }

        public DataTable GetKCBFormVw_Cschedule_ForAtyID(int AtyID)
        {
            throw new NotImplementedException();
        }

       
    }
}
