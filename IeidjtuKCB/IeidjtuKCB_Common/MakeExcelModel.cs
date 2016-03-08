using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace IeidjtuKCB.Common
{/// <summary>
/// 用于生成EXCEL的模型
/// </summary>
    public class MakeExcelModel 
        {/// <summary>
        /// 用于绑定的DataTable
        /// </summary>
        public DataTable dataTable { get; set; }
        /// <summary>
        /// 标题文件
        /// </summary>
        public List<string> HeaderText { get; set; }
        /// <summary>
        /// 要生成的EXCEL的大标题
        /// </summary>
        public string TitleName { get; set; }
        /// <summary>
        /// 要生成的EXCEL文件名
        /// </summary>
        public string Filename { get; set; }
        /// <summary>
        /// 要生成的EXCEL的打开密码
        /// </summary>
        public string PassWord { get; set; }
    }
}
