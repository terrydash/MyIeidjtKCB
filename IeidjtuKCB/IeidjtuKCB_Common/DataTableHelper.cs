using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;

namespace IeidjtuKCB.Common
{
    public static class DataTableHelper
    {   /// <summary>
        /// 获取DATATABLE的列名
        /// </summary>
        /// <param name="dt">要获取的DATATABLE</param>
        /// <returns>列名的泛型集合</returns>
        static List<string >GetDataTableColumns(System.Data.DataTable dt)
        {
            if (dt != null)
            {

                if (dt.Columns.Count > 0)
                {
                    List<string> strList = new List<string>();

                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        strList.Add(dt.Columns[i].ColumnName);
                    }
                    return strList;
                }


            }
                return null;

           

        }

    }
}
