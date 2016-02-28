using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IeidjtuKCB_Common;
using IeidjtuKCB_Model;

namespace IeidjtuKCB_BLL
{
    public class Department_BLL
    {
        public List<Vw_DeptMent> GetAllDepartment()
        {

            return DB.Context.From<Vw_DeptMent>().ToList();
        }
    }
}
