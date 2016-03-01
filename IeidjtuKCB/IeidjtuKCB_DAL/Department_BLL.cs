using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IeidjtuKCB.DAL;
using IeidjtuKCB.Model;
using IeidjtuKCB.Interface;
namespace IeidjtuKCB.BLL
{
    public class Department_BLL  :IBaseBLL<Vw_DeptMent>
    {
        private Department_DAL D_DAL = new Department_DAL();
        public List<Vw_DeptMent> GetAllEntityFromDAL()
        {
           
            return D_DAL.GetAllEntityFromDB();
        }
        

        public List<Vw_DeptMent> GetEntityFromDAL(int ID)
        {
            return D_DAL.GetEntityFromDB(ID);
        }
    }
}
