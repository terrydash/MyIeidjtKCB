using System;
using System.Collections.Generic;
using IeidjtuKCB.DAL;
using IeidjtuKCB.Model;



namespace IeidjtuKCB.BLL
{
    public class ActiveYear_BLL
    {
        public List<Activeyear> GetAllActvieYear()
        {
            return GetActvieYearById(0);
        }
        public List<Activeyear> GetActvieYearById(int id)
        {
            Activeyear_DAL Ay_DAL = new Activeyear_DAL();

            return Ay_DAL.GetActiveYearList(id);
        }
        public List<Activeyear> GetActiveYearForComboBox()
        {
            var ActiveYearList = GetAllActvieYear();

            if (ActiveYearList.Count != 0)
            {
                ActiveYearList.Find(d => d.State == "当前").ATName += "=>当前";             
            }            
            return ActiveYearList;

        }
      
          public int GetNowActvieYearID()
        {
            Activeyear_DAL Ay_DAL = new Activeyear_DAL();

            return Ay_DAL.GetActiveYearList(0).Find(d => d.State == "当前").ATID; 
        }
       
    }
}
