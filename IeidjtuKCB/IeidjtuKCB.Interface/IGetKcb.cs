using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Data;
namespace IeidjtuKCB.Interface
{/// <summary>
/// 获得课程表的接口
/// </summary>
/// <typeparam name="T"></typeparam>
    public interface IGetKcb<T> where T :class
    {
       DataTable GetKCBFormVw_Cschedule_ForAtyID(int AtyID);
       DataTable GetKCBFormVw_Cschedule_ForTCID(int TCID);
       List<Object> GetKCBFormVw_Cschedule_ForAtyID_ToList(int AtyID);



    }
}
