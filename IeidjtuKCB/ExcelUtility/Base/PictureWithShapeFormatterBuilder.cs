using ExcelReport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExcelUtility.Base
{
    /// EXCEL模板图片关联图形格式化器创建者类（独立使用）
    /// 作者：Zuowenjun
    /// 日期：2016-1-27
    public class PictureWithShapeFormatterBuilder : IElementFormatterBuilder
    {
        protected List<PictureWithShapeInfo> pictureInfos;

        public PictureWithShapeFormatterBuilder()
        {
            pictureInfos = new List<PictureWithShapeInfo>();
        }

        public void AddFormatter(PictureWithShapeInfo pictureInfo)
        {
            //var range = pictureInfo.ShapeRange;
            //if (range != null && range.MinRow != null && range.MaxRow != null && range.MinColumn != null && range.MaxColumn != null)
            {
                if (pictureInfos.Count(p => p.ShapeRange.Equals(pictureInfo.ShapeRange)) > 0)
                {
                    throw new ArgumentException("该区域已经存在图片信息，同一个区域内只允许指定一张图片信息。", "pictureInfo");
                }
            }
            pictureInfos.Add(pictureInfo);
        }

        public void AddFormatter(string picPath, int? minRow = null, int? maxRow = null, int? minColumn = null, int? maxColumn = null, bool autoSize = false)
        {
            AddFormatter(new PictureWithShapeInfo(picPath, new SheetRange() { MinRow = minRow, MaxRow = maxRow, MinColumn = minColumn, MaxColumn = maxColumn }, autoSize));
        }

        IEnumerable<ElementFormatter> IElementFormatterBuilder.GetElementFormatters(SheetParameterContainer paramContainer)
        {
            foreach (var item in pictureInfos)
            {
                yield return new PictureWithShapeFormatter(item);
            }
        }
    }
}
