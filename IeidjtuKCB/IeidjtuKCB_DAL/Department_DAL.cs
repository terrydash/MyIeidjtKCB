using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IeidjtuKCB_BLL;
using IeidjtuKCB_Model;

namespace IeidjtuKCB_DAL
{
    public class Department_DAL
    {
        public List<Vw_DeptMent> GetAllVw_Deptment()
        {
            Department_BLL D_BLL = new Department_BLL();
            return D_BLL.GetAllDepartment();
        }
    }
}
