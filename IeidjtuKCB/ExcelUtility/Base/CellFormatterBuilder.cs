using ExcelReport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExcelUtility.Base
{
    /// EXCEL模板单元格数据格式化器创建者类（独立使用）
    /// 作者：Zuowenjun
    /// 日期：2016-1-7
    public class CellFormatterBuilder : FormatterBuilder<object>
    {
        protected override ExcelReport.ElementFormatter CreateElementFormatter(ExcelReport.Parameter param, object value)
        {
            return new CellFormatter(param, value);
        }
    }

    /// EXCEL模板单元格数据格式化器创建者类（嵌套使用）
    /// 作者：Zuowenjun
    /// 日期：2016-1-7
    public class CellFormatterBuilder<T> : FormatterBuilder<T, Func<T, object>>
    {

        protected override EmbeddedFormatter<T> CreateElementFormatter(Parameter param, Func<T, object> value)
        {
            return new CellFormatter<T>(param, value);
        }
    }
}
