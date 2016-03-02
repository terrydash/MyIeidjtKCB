using ExcelReport;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExcelUtility.Base
{
    /// <summary>
    /// EXCEL工作薄内部格式化器容器类
    /// 作者：Zuowenjun
    /// 日期：2016-1-7
    /// </summary>
    /// <typeparam name="TDataSource"></typeparam>
    public class SheetFormatterContainer<TDataSource>
    {
        private List<IFormatterBuilder> formatterBuilders;

        public SheetFormatterContainer()
        {
            formatterBuilders = new List<IFormatterBuilder>();
        }

        public void AppendFormatterBuilder(IFormatterBuilder formatterBuilder)
        {
            formatterBuilders.Add(formatterBuilder);
        }

        internal ElementFormatter[] GetFormatters(SheetParameterContainer paramContainer)
        {
            List<ElementFormatter> formatters = new List<ElementFormatter>();
            for (int i = 0; i < formatterBuilders.Count; i++)
            {
                var builder = formatterBuilders[i];
                if (builder is PartFormatterBuilder)
                {
                    formatters.AddRange((builder as PartFormatterBuilder).GetFormatters(paramContainer));
                }
                else if (builder is CellFormatterBuilder)
                {
                    formatters.AddRange((builder as CellFormatterBuilder).GetFormatters(paramContainer));
                }
                else if (builder is TableFormatterBuilder<TDataSource>)
                {
                    formatters.AddRange((builder as TableFormatterBuilder<TDataSource>).GetFormatters(paramContainer));
                }
                else if (builder is RepeaterFormatterBuilder<TDataSource>)
                {
                    formatters.AddRange((builder as RepeaterFormatterBuilder<TDataSource>).GetFormatters(paramContainer));
                }
            }
            return formatters.ToArray();
        }

    }

}
