using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IeidjtuKCB.UI.Common
{ 
    #region    传递参数的类
    public class BindArgumentEntity 
    {
        
        public List<ArgumentValueType> _ArgumentValueType;
        public List<string> ArgumentValue { get; set; }
        /// <summary>
        /// 默认的构造函数
        /// </summary>
        /*
        public BindArgumentEntity()
        {
            _ArgumentValueType.Add(ArgumentValueType.String);
            ArgumentName.Add("");
            ArgumentValue.Add( "");
        }
        */

        public List<string>ArgumentName { get; set; }
        


        public enum ArgumentValueType
        {
           Int=1,
           String=2,
           Double=3,
           Long=4,

        }
    }
    #endregion 
}
