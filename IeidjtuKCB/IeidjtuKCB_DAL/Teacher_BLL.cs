using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IeidjtuKCB.DAL;
using IeidjtuKCB.Interface;
using IeidjtuKCB.Model;
namespace IeidjtuKCB.BLL
{
    public class Teacher_BLL : IBaseBLL<RSDA> 
    {
        private Teacher_DAL T_DAL = new Teacher_DAL();
        public List<RSDA> GetAllEntityFromDAL() 
        {
            return T_DAL.GetAllEntityFromDB();
        }

        public List<RSDA> GetEntityFromDAL(int ID)
        {
            return T_DAL.GetEntityFromDB(ID);
        }
        public List<RSDA> GetTeacherEntityFromDAL(int DeptID,string TeacherName)
        {
            return T_DAL.GetTeacherEntityFromDBByDeptID(DeptID,TeacherName);
        }
    }
}
