using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IeidjtuKCB.Interface
{   /// <summary>
    /// DAL的基础实体的接口
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IBaseDAL<T> where T : class, new()
    {
        /// <summary>
        /// 根据ID从数据库中获取指定的实体到LIST
        /// </summary>
        /// <param name="id">实体在数据库中的ID</param>
        /// <returns>返回实体</returns>
        List<T> GetEntityFromDB(int id);
        /// <summary>
        /// 获取全部的实体到LIST
        /// </summary>
        /// <returns></returns>
        List<T> GetAllEntityFromDB();

    }
}
