using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IeidjtuKCB.DAL;
using IeidjtuKCB.Model;

namespace IeidjtuKCB_BLL
{
    public class Department_BLL
    {
        public List<Vw_DeptMent> GetAllVw_Deptment()
        {
            Department_DAL D_DAL = new Department_DAL();
            return D_DAL.GetAllDepartment();
        }
    }
}
