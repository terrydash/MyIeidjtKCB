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
    public interface IGetKcb<T>
    {
        /// <summary>
        /// 获取制定学年的全部课表
        /// </summary>
        /// <param name="AtyID">学年ID</param>
        /// <returns></returns>
        DataTable GetKCBFormvw_Cschedule_ForAtyID(int AtyID);
        /// <summary>
        /// 获取指定学年 值
        /// </summary>
        /// <param name="AtyID"></param>
        /// <param name="TCID"></param>
        /// <returns></returns>
        List<T> GetKCBFormvw_Cschedule_ForAtyIandTCID(int AtyID,int TCID);
        List<T> GetKCBFormvw_Cschedule_ForAtyIandPSID(int AtyID,int PSID);



    }
}
