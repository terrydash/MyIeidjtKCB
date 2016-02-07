using ExcelReport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExcelUtility.Base
{
    /// <summary>
    /// EXCEL模板数据格式化器创建者接口（仅作约定）
    /// 作者：Zuowenjun
    /// 日期：2016-1-7
    /// </summary>
    public interface IFormatterBuilder
    {

    }


    /// <summary>
    /// EXCEL模板数据独立元素格式化器创建者接口
    /// 作者：Zuowenjun
    /// 日期：2016-1-22
    /// </summary>
    internal interface IElementFormatterBuilder : IFormatterBuilder
    {
        IEnumerable<ElementFormatter> GetElementFormatters(SheetParameterContainer paramContainer);
    }


    /// <summary>
    /// EXCEL模板数据嵌套元素格式化器创建者接口
    /// 作者：Zuowenjun
    /// 日期：2016-1-22
    /// </summary>
    /// <typeparam name="TSource"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    internal interface IEmbeddedFormatterBuilder: IFormatterBuilder
    {
        IEnumerable<object> GetEmbeddedFormatters(SheetParameterContainer paramContainer);
    }

    /// <summary>
    /// EXCEL模板数据格式化器创建者基类
    /// 作者：Zuowenjun
    /// 日期：2016-1-7
    /// </summary>
    /// <typeparam name="TFormatter"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    public abstract class BaseFormatterBuilder<TFormatter, TValue> : IFormatterBuilder where TFormatter : class
    {
        protected Dictionary<string, TValue> formatters;

        public BaseFormatterBuilder()
        {
            formatters = new Dictionary<string, TValue>();
        }

        public void AddFormatter(string paramName, TValue paramValue)
        {
            formatters[paramName] = paramValue;
        }

        public void AddFormatters(IDictionary<string, TValue> paramNameValues)
        {
            foreach (var kv in paramNameValues)
            {
                formatters[kv.Key] = kv.Value;
            }
        }

        internal virtual IEnumerable<TFormatter> GetFormatters(SheetParameterContainer paramContainer)
        {
            foreach (var kv in formatters)
            {
                yield return CreateElementFormatter(paramContainer[kv.Key], kv.Value);
            }
        }

        protected abstract TFormatter CreateElementFormatter(Parameter param, TValue value);
    }


    /// <summary>
    /// EXCEL模板普通元素数据格式化器创建者基类（独立定位模板的具体位置）
    /// 作者：Zuowenjun
    /// 日期：2016-1-7
    /// </summary>
    /// <typeparam name="TValue"></typeparam>
    public abstract class FormatterBuilder<TValue> : BaseFormatterBuilder<ElementFormatter, TValue>, IElementFormatterBuilder
    {

        IEnumerable<ElementFormatter> IElementFormatterBuilder.GetElementFormatters(SheetParameterContainer paramContainer)
        {
            return this.GetFormatters(paramContainer);
        }
    }

    /// <summary>
    /// EXCEL模板嵌套元素数据格式化器创建者基类（必需包含在普通元素数据格式化器中使用，比如：表格与单元格）
    /// 作者：Zuowenjun
    /// 日期：2016-1-7
    /// </summary>
    /// <typeparam name="TSource"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    public abstract class FormatterBuilder<TSource, TValue> : BaseFormatterBuilder<EmbeddedFormatter<TSource>, TValue>, IEmbeddedFormatterBuilder
    {
        IEnumerable<object> IEmbeddedFormatterBuilder.GetEmbeddedFormatters(SheetParameterContainer paramContainer)
        {
            return this.GetFormatters(paramContainer);
        }
    }

}
