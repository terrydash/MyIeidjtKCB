using System;
using System.Collections.Generic;
using IeidjtuKCB_BLL;
using IeidjtuKCB_Model;



namespace IeidjtuKCB_DAL
{
    public class ActiveYear_DAL
    {
        public List<Activeyear> GetAllActvieYear()
        {
            return GetActvieYearById(0);
        }
        public List<Activeyear> GetActvieYearById(int id)
        {
            Activeyear_BLL Ay_Bll = new Activeyear_BLL();

            return Ay_Bll.GetActiveYearList(id);
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
            Activeyear_BLL Ay_Bll = new Activeyear_BLL();

            return Ay_Bll.GetActiveYearList(0).Find(d => d.State == "当前").ATID; 
        }
       
    }
}
