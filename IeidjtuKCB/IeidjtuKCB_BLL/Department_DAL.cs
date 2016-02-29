using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IeidjtuKCB.Common;
using IeidjtuKCB.DBSession;
using IeidjtuKCB.Model;
namespace IeidjtuKCB.DAL
{
    public class Department_DAL
    {
        public List<Vw_DeptMent> GetAllDepartment()
        {

            return DB.Context.From<Vw_DeptMent>().ToList();
        }
    }
}
