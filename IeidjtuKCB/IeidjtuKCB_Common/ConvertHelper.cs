using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IeidjtuKCB.Common
{   /// <summary>
    /// 针对类型转换的方法的封装
    /// </summary>
    public static class ConvertHelper
    {
        #region 字符串转化为int的方法
        /// <summary>
        /// 字符串转化为int
        /// </summary>
        /// <param name="stringToCovert">要转换的字符串</param>
        /// <returns>转换后的int类型</returns>
        public static int ConvertStringToInt(string stringToCovert)
        {
            int outInt;
            try
            {
                int.TryParse(stringToCovert,out outInt);
            }

            catch 
            {
                throw new Exception("字符串不能转化为数值");
                
            }
            return outInt;

        }
    }
    #endregion
}
