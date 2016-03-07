using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IeidjtuKCB.UI.Common
{ 
    #region    传递参数的类
    public class BindArgumentEntity
    {
        
        public _ArgumentValueDataType ArgumentValueDataType;
        public _ArgumentValueType ArgumentValueType;
        /// <summary>
        /// 字段的值
        /// </summary>
        public string ArgumentValue { get; set; }
       
        /// <summary>
        /// 字段名
        /// </summary>
        public string ArgumentName { get; set; }
        /// <summary>
        /// 字段描述
        /// </summary>
        public string ArgumentDesdescribe { get; set; }

        /// <summary>
        /// 字段的数据类型
        /// </summary>
        public enum _ArgumentValueDataType
        {
           Nothing=0,
           Int=1,
           String=2,
           Double=3,
           Long=4,

        }
        public enum _ArgumentValueType
        {
            Nothing=0,
            ComboBoxDisplayMember=1,
            ComboBoxValueMember=2,
            DataGridViewValueMember=3,
            DataGridViewColumnHeaderText=4,
        }
    }
    #endregion 
}
