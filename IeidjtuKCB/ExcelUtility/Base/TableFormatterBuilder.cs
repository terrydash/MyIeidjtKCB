using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExcelReport;

namespace ExcelUtility.Base
{
    /// <summary>
    /// EXCEL模板指定区域表格数据格式化器创建者类（独立使用）
    /// 作者：Zuowenjun
    /// 日期：2016-1-7
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class TableFormatterBuilder<T> : FormatterBuilder<Func<T, object>>
    {
        protected string startParamName = null;
        protected SheetParameterContainer paramContainer = null;
        private List<IEmbeddedFormatterBuilder> otherFormatterBuilders;

        public IEnumerable<T> DataSource { get; set; }

        public TableFormatterBuilder(IEnumerable<T> dataSource, string startParamName)
        {
            this.DataSource = dataSource;
            this.startParamName = startParamName;
            this.otherFormatterBuilders = new List<IEmbeddedFormatterBuilder>();
        }

        public void AppendFormatterBuilder(IFormatterBuilder formatterBuilder)
        {
            if (formatterBuilder is IEmbeddedFormatterBuilder)
            {
                otherFormatterBuilders.Add(formatterBuilder as IEmbeddedFormatterBuilder);
            }
            else
            {
                throw new ArgumentException("传入的formatterBuilder必须实现IEmbeddedFormatterBuilder接口", "formatterBuilder");
            }
        }

        internal override IEnumerable<ElementFormatter> GetFormatters(SheetParameterContainer paramContainer)
        {
            this.paramContainer = paramContainer;
            List<EmbeddedFormatter<T>> cellFormatters = new List<EmbeddedFormatter<T>>();
            foreach (var kv in formatters)
            {
                cellFormatters.Add(new CellFormatter<T>(paramContainer[kv.Key], kv.Value));
            }
            if (otherFormatterBuilders.Count > 0)
            {
                foreach (var item in otherFormatterBuilders)
                {
                    cellFormatters.AddRange(item.GetEmbeddedFormatters(paramContainer) as IEnumerable<EmbeddedFormatter<T>>);
                }
            }
            return new[] { CreateElementFormatter(paramContainer[startParamName], cellFormatters.ToArray()) };
        }

        protected virtual ElementFormatter CreateElementFormatter(Parameter param, params EmbeddedFormatter<T>[] cellFormatters)
        {
            return new TableFormatter<T>(param, DataSource, cellFormatters);
        }

        protected override ElementFormatter CreateElementFormatter(Parameter param, Func<T, object> value)
        {
            throw new NotImplementedException();
        }
    }




    /// <summary>
    ///  EXCEL模板指定区域表格数据格式化器创建者类（嵌套使用）
    /// 作者：Zuowenjun
    /// 日期：2016-1-23
    /// </summary>
    /// <typeparam name="TParent"></typeparam>
    /// <typeparam name="TItem"></typeparam>
    public class TableFormatterBuilder<TParent, TItem> : FormatterBuilder<TParent, Func<TItem, object>>
    {
        protected Func<TParent, IEnumerable<TItem>> dataSource = null;
        protected string startParamName = null;
        protected SheetParameterContainer paramContainer = null;
        private List<IEmbeddedFormatterBuilder> otherFormatterBuilders;

        public TableFormatterBuilder(Func<TParent, IEnumerable<TItem>> dataSource, string startParamName)
        {
            this.dataSource = dataSource;
            this.startParamName = startParamName;
            this.otherFormatterBuilders = new List<IEmbeddedFormatterBuilder>();
        }

        public void AppendFormatterBuilder(IFormatterBuilder formatterBuilder)
        {
            if (formatterBuilder is IEmbeddedFormatterBuilder)
            {
                otherFormatterBuilders.Add(formatterBuilder as IEmbeddedFormatterBuilder);
            }
            else
            {
                throw new ArgumentException("传入的formatterBuilder必须实现IEmbeddedFormatterBuilder接口", "formatterBuilder");
            }
        }


        internal override IEnumerable<EmbeddedFormatter<TParent>> GetFormatters(SheetParameterContainer paramContainer)
        {
            this.paramContainer = paramContainer;
            List<EmbeddedFormatter<TItem>> cellFormatters = new List<EmbeddedFormatter<TItem>>();
            foreach (var kv in formatters)
            {
                cellFormatters.Add(new CellFormatter<TItem>(paramContainer[kv.Key], kv.Value));
            }
            var embeddedFormatters = new List<EmbeddedFormatter<TParent>>();
            embeddedFormatters.Add(CreateElementFormatter(paramContainer[startParamName], cellFormatters.ToArray()));

            if (otherFormatterBuilders.Count > 0)
            {
                foreach (var item in otherFormatterBuilders)
                {
                    embeddedFormatters.AddRange(item.GetEmbeddedFormatters(paramContainer) as IEnumerable<EmbeddedFormatter<TParent>>);
                }
            }
            return embeddedFormatters;
        }

        protected virtual EmbeddedFormatter<TParent> CreateElementFormatter(Parameter param, params EmbeddedFormatter<TItem>[] cellFormatters)
        {
            return new TableFormatter<TItem, TParent>(param, dataSource, cellFormatters);
        }


        protected override EmbeddedFormatter<TParent> CreateElementFormatter(Parameter param, Func<TItem, object> value)
        {
            throw new NotImplementedException();
        }
    }
}
