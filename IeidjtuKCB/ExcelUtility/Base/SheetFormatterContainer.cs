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
    public class SheetFormatterContainer
    {
        private List<IElementFormatterBuilder> FormatterBuilders = null;

        public SheetFormatterContainer()
        {
            FormatterBuilders = new List<IElementFormatterBuilder>();
        }

        public void AppendFormatterBuilder(IFormatterBuilder formatterBuilder)
        {
            if (formatterBuilder is IElementFormatterBuilder)
            {
                FormatterBuilders.Add((IElementFormatterBuilder)formatterBuilder);
            }
            else
            {
                throw new ArgumentException("传入的formatterBuilder必须实现IElementFormatterBuilder接口", "formatterBuilder");
            }
        }

        internal ElementFormatter[] GetFormatters(SheetParameterContainer paramContainer)
        {
            List<ElementFormatter> formatters = new List<ElementFormatter>();
            for (int i = 0; i < FormatterBuilders.Count; i++)
            {
                var builder = FormatterBuilders[i];
                formatters.AddRange(builder.GetElementFormatters(paramContainer));
            }
            return formatters.ToArray();
        }

    }

}
