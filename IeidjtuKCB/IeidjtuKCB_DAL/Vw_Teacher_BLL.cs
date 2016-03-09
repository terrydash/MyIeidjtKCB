using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IeidjtuKCB.DAL;
using IeidjtuKCB.Interface;
using IeidjtuKCB.Model;
namespace IeidjtuKCB.BLL
{
    public class Vw_Teacher_BLL : IBaseBLL<vw_Rsda>
    {
        
        public List<vw_Rsda> GetAllEntityFromDAL()
        { Vw_Teacher_BLL T_BLL = new Vw_Teacher_BLL();
            return T_BLL.GetAllEntityFromDAL();
        }

        public List<vw_Rsda> GetEntityFromDAL(int ID)
        {
            Vw_Teacher_BLL T_BLL = new Vw_Teacher_BLL();
            return T_BLL.GetEntityFromDAL(ID);
        }
    }
}
