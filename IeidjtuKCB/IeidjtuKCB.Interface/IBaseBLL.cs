using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IeidjtuKCB.Interface
{   /// <summary>
    ///  BLL层的基础接口
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IBaseBLL<T> where T : class, new()
    {   /// <summary>
        /// 根据ID从DAL获取单个实体
        /// </summary>
        /// <param name="ID"实体的ID></param>
        /// <returns>实体对象</returns>
        List<T> GetEntityFromDAL(int ID);
        /// <summary>
        /// 丛DAL获取全部实体
        /// </summary>
        /// <returns>返回全部实体</returns>
        List<T> GetAllEntityFromDAL();
    }
}
