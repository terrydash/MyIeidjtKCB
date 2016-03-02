using System;
using System.Collections.Generic;
using IeidjtuKCB.DAL;
using IeidjtuKCB.Model;
using IeidjtuKCB.Interface;
using System.Data;


namespace IeidjtuKCB.BLL 
{
    public class ActiveYear_BLL : IBaseBLL<Activeyear>
    {
        private Activeyear_DAL Ay_DAL = new Activeyear_DAL();
        /// <summary>
        /// 为ActiveYear实体增加当前学期的提示
        /// </summary>
        /// <returns></returns>
        public List<Activeyear> GetActiveYearForComboBox()
        {
            var ActiveYearList = GetAllEntityFromDAL();

            if (ActiveYearList.Count != 0)
            {
                ActiveYearList.Find(d => d.State == "当前").ATName += "=>当前";             
            }            
            return ActiveYearList;

        }
      
          public int GetNowActvieYearID()
        {            

            return GetAllEntityFromDAL().Find(d => d.State == "当前").ATID; 
        }
       

        public List<Activeyear> GetEntityFromDAL(int ID)
        {
            

            return Ay_DAL.GetEntityFromDB(ID);
        }

        public List<Activeyear> GetAllEntityFromDAL()
        {
            return GetEntityFromDAL(0);
        }
    }
}
