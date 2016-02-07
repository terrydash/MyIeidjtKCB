using ExcelReport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExcelUtility.Base
{
    /// <summary>
    /// EXCEL模板指定区域多表格（每个表格之间存在间隔行,每个表格数据模板与布局相同）数据格式化器创建者类（独立使用）
    /// 作者：Zuowenjun
    /// 日期：2016-1-7
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class RepeaterFormatterBuilder<T> : TableFormatterBuilder<T>
    {
        protected string endParamName = null;
        public RepeaterFormatterBuilder(IEnumerable<T> dataSource, string startParamName, string endParamName)
            : base(dataSource, startParamName)
        {
            this.endParamName = endParamName;
        }

        protected override ElementFormatter CreateElementFormatter(Parameter param, params EmbeddedFormatter<T>[] cellFormatters)
        {
            return new RepeaterFormatter<T>(param, paramContainer[endParamName], DataSource, cellFormatters);
        }
    }



    /// <summary>
    /// EXCEL模板指定区域多表格（每个表格之间存在间隔行,每个表格数据模板与布局相同）数据格式化器创建者类（嵌套使用）
    /// 作者：Zuowenjun
    /// 日期：2016-1-23
    /// </summary>
    /// <typeparam name="TParent"></typeparam>
    /// <typeparam name="TItem"></typeparam>
    public class RepeaterFormatterBuilder<TParent, TItem> : TableFormatterBuilder<TParent, TItem>
    {
        protected string endParamName = null;
        public RepeaterFormatterBuilder(Func<TParent, IEnumerable<TItem>> dataSource, string startParamName, string endParamName)
            : base(dataSource, startParamName)
        {
            this.endParamName = endParamName;
        }

        protected override EmbeddedFormatter<TParent> CreateElementFormatter(Parameter param, params EmbeddedFormatter<TItem>[] cellFormatters)
        {
            return new RepeaterFormatter<TItem, TParent>(param, paramContainer[endParamName], dataSource, cellFormatters);
        }

    }
}
