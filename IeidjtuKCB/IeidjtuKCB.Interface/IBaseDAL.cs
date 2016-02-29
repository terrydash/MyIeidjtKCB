using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IeidjtuKCB.DAL;
namespace IeidjtuKCB.Interface
{   /// <summary>
    /// 与DAL交互的接口
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IBaseDAL<T> where T : class, new()
    {


    }
}
