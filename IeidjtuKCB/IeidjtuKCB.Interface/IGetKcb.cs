using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IeidjtuKCB.Interface
{/// <summary>
/// 获得课程表的接口
/// </summary>
/// <typeparam name="T"></typeparam>
    public interface IGetKcb<T> where T :class,new ()
    {
        List<T> GetKCBFormVw_Cschedule_ForAtyID(int AtyID);
        List<T> GetKCBFormVw_Cschedule_ForTCID(int TCID);



    }
}
