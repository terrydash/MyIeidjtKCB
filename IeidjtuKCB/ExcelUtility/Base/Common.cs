using ExcelReport;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ExcelUtility.Base
{
    /// <summary>
    /// ExcelUtility类库内部通用功能类
    /// 作者：Zuowenjun
    /// 日期：2016/1/15
    /// </summary>
    internal static class Common
    {
        public static string DesktopDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        public static string TempDirectory = null;

        static Common()
        {
            string temp = System.Environment.GetEnvironmentVariable("TEMP");
            DirectoryInfo info = new DirectoryInfo(temp);
            TempDirectory = info.FullName;
        }

        /// <summary>
        /// 获取要保存的文件名称（含完整路径）
        /// </summary>
        /// <returns></returns>
        public static string GetSaveFilePath(bool isCompatible = false)
        {
            string filter = "Excel Office97-2003(*.xls)|*.xls|Excel Office2007及以上(*.xlsx)|*.xlsx";
            if (isCompatible)
            {
                filter = "Excel Office97-2003(*.xls)|*.xls";
            }

            SaveFileDialog saveFileDig = new SaveFileDialog();
            saveFileDig.Filter = filter;
            saveFileDig.FilterIndex = 0;
            saveFileDig.Title = "导出到";
            saveFileDig.OverwritePrompt = true;
            saveFileDig.InitialDirectory = DesktopDirectory;
            string filePath = null;
            if (saveFileDig.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDig.FileName;
            }

            return filePath;
        }

        /// <summary>
        /// 获取要打开要导入的文件名称（含完整路径）
        /// </summary>
        /// <returns></returns>
        public static string GetOpenFilePath()
        {
            OpenFileDialog openFileDig = new OpenFileDialog();
            openFileDig.Filter = "Excel Office97-2003(*.xls)|*.xls|Excel Office2007及以上(*.xlsx)|*.xlsx";
            openFileDig.FilterIndex = 0;
            openFileDig.Title = "打开";
            openFileDig.CheckFileExists = true;
            openFileDig.CheckPathExists = true;
            openFileDig.InitialDirectory = Common.DesktopDirectory;
            string filePath = null;
            if (openFileDig.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDig.FileName;
            }

            return filePath;
        }

        /// <summary>
        /// 判断是否为兼容模式
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static bool GetIsCompatible(string filePath)
        {
            string ext = Path.GetExtension(filePath);
            return new[] { ".xls", ".xlt" }.Count(e => e.Equals(ext, StringComparison.OrdinalIgnoreCase)) > 0;
        }



        /// <summary>
        /// 创建工作薄
        /// </summary>
        /// <param name="isCompatible"></param>
        /// <returns></returns>
        public static IWorkbook CreateWorkbook(bool isCompatible)
        {
            if (isCompatible)
            {
                return new HSSFWorkbook();
            }
            else
            {
                return new XSSFWorkbook();
            }
        }

        /// <summary>
        /// 创建工作薄(依据文件流)
        /// </summary>
        /// <param name="isCompatible"></param>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static IWorkbook CreateWorkbook(bool isCompatible, dynamic stream)
        {
            if (isCompatible)
            {
                return new HSSFWorkbook(stream);
            }
            else
            {
                return new XSSFWorkbook(stream);
            }
        }

        /// <summary>
        /// 创建单元格样式
        /// </summary>
        /// <param name="workbook">workbook</param>
        /// <param name="isHeaderRow">是否获取头部样式</param>
        /// <returns></returns>
        public static ICellStyle GetCellStyle(IWorkbook workbook, bool isHeaderRow = false)
        {
            ICellStyle style = workbook.CreateCellStyle();

            if (isHeaderRow)
            {
                style.FillPattern = FillPattern.SolidForeground;
                style.FillForegroundColor = NPOI.HSSF.Util.HSSFColor.Grey25Percent.Index;
                IFont f = workbook.CreateFont();
                f.Boldweight = (short)FontBoldWeight.Bold;
                style.SetFont(f);
            }

            style.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
            style.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
            style.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;
            style.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;
            return style;
        }


        /// <summary>
        /// 根据单元格内容重新设置列宽
        /// </summary>
        /// <param name="sheet"></param>
        /// <param name="cell"></param>
        public static void ReSizeColumnWidth(ISheet sheet, ICell cell)
        {
            int cellLength = (Encoding.Default.GetBytes(cell.ToString()).Length + 2) * 256;
            const int maxLength = 60 * 256; //255 * 256;
            if (cellLength > maxLength) //当单元格内容超过30个中文字符（英语60个字符）宽度，则强制换行
            {
                cellLength = maxLength;
                cell.CellStyle.WrapText = true;
            }
            int colWidth = sheet.GetColumnWidth(cell.ColumnIndex);
            if (colWidth < cellLength)
            {
                sheet.SetColumnWidth(cell.ColumnIndex, cellLength);
            }
        }

        /// <summary>
        /// 创建单元格样式并设置数据格式化规则
        /// </summary>
        /// <param name="workbook">workbook</param>
        /// <param name="format">格式化字符串</param>
        public static ICellStyle GetCellStyleWithDataFormat(IWorkbook workbook, string format)
        {
            var style = GetCellStyle(workbook);
            var dataFormat = workbook.CreateDataFormat();
            short formatId = -1;
            if (dataFormat is HSSFDataFormat)
            {
                formatId = HSSFDataFormat.GetBuiltinFormat(format);
            }
            if (formatId != -1)
            {
                style.DataFormat = formatId;
            }
            else
            {
                style.DataFormat = dataFormat.GetFormat(format);
            }
            return style;
        }

        /// <summary>
        /// 依据值类型为单元格设置值
        /// </summary>
        /// <param name="cell"></param>
        /// <param name="value"></param>
        /// <param name="colType"></param>
        /// <param name="colStyles"></param>
        public static void SetCellValue(ICell cell, string value, Type colType, IDictionary<int, ICellStyle> colStyles)
        {
            string dataFormatStr = null;
            switch (colType.ToString())
            {
                case "System.String": //字符串类型
                    cell.SetCellType(CellType.String);
                    cell.SetCellValue(value);
                    break;
                case "System.DateTime": //日期类型
                    DateTime dateV;
                    if (DateTime.TryParse(value, out dateV))
                    {
                        cell.SetCellValue(dateV);
                    }
                    dataFormatStr = "yyyy/mm/dd hh:mm:ss";
                    break;
                case "System.Boolean": //布尔型
                    bool boolV = false;
                    if (bool.TryParse(value, out boolV))
                    {
                        cell.SetCellType(CellType.Boolean);
                        cell.SetCellValue(boolV);
                    }
                    break;
                case "System.Int16": //整型
                case "System.Int32":
                case "System.Int64":
                case "System.Byte":
                    int intV = 0;
                    if (int.TryParse(value, out intV))
                    {
                        cell.SetCellType(CellType.Numeric);
                        cell.SetCellValue(intV);
                    }
                    dataFormatStr = "0";
                    break;
                case "System.Decimal": //浮点型
                case "System.Double":
                    double doubV = 0;
                    if (double.TryParse(value, out doubV))
                    {
                        cell.SetCellType(CellType.Numeric);
                        cell.SetCellValue(doubV);
                    }
                    dataFormatStr = "0.00";
                    break;
                case "System.DBNull": //空值处理
                    cell.SetCellType(CellType.Blank);
                    cell.SetCellValue("");
                    break;
                default:
                    cell.SetCellType(CellType.Unknown);
                    cell.SetCellValue(value);
                    break;
            }

            if (!string.IsNullOrEmpty(dataFormatStr) && colStyles[cell.ColumnIndex].DataFormat <= 0) //没有设置，则采用默认类型格式
            {
                colStyles[cell.ColumnIndex] = GetCellStyleWithDataFormat(cell.Sheet.Workbook, dataFormatStr);
            }
            cell.CellStyle = colStyles[cell.ColumnIndex];
        }


        /// <summary>
        /// 从工作表中生成DataTable
        /// </summary>
        /// <param name="sheet"></param>
        /// <param name="headerRowIndex"></param>
        /// <returns></returns>
        public static DataTable GetDataTableFromSheet(ISheet sheet, int headerRowIndex)
        {
            DataTable table = new DataTable();

            IRow headerRow = sheet.GetRow(headerRowIndex);
            int cellCount = headerRow.LastCellNum;

            for (int i = headerRow.FirstCellNum; i < cellCount; i++)
            {
                if (headerRow.GetCell(i) == null || headerRow.GetCell(i).StringCellValue.Trim() == "")
                {
                    // 如果遇到第一个空列，则不再继续向后读取
                    cellCount = i;
                    break;
                }
                DataColumn column = new DataColumn(headerRow.GetCell(i).StringCellValue);
                table.Columns.Add(column);
            }

            for (int i = (headerRowIndex + 1); i <= sheet.LastRowNum; i++)
            {
                IRow row = sheet.GetRow(i);
                //如果遇到某行的第一个单元格的值为空，则不再继续向下读取
                if (row != null && !string.IsNullOrEmpty(row.GetCell(0).ToString()))
                {
                    DataRow dataRow = table.NewRow();

                    for (int j = row.FirstCellNum; j < cellCount; j++)
                    {
                        dataRow[j] = row.GetCell(j).ToString();
                    }

                    table.Rows.Add(dataRow);
                }
            }

            return table;
        }

        /// <summary>
        /// 获取模板文件对应的模板格式配置XML文件路径（当不存在或较旧时，将会重新生成）
        /// </summary>
        /// <param name="templatePath"></param>
        /// <param name="newGenerate"></param>
        /// <returns></returns>
        public static string GetTemplateConfigFilePath(string templatePath, bool newGenerate = false)
        {
            string templateConfigFilePath = Path.ChangeExtension(templatePath, ".xml");
            if (newGenerate || !File.Exists(templateConfigFilePath) || File.GetLastWriteTime(templatePath) > File.GetLastWriteTime(templateConfigFilePath))
            {
                WorkbookParameterContainer workbookParameter = ParseTemplate.Parse(templatePath);
                workbookParameter.Save(templateConfigFilePath);
            }

            return templateConfigFilePath;
        }


        /// <summary>
        /// 从工作薄中获取指定范围的图形对象列表
        /// </summary>
        /// <param name="sheet"></param>
        /// <param name="rangeMinRow"></param>
        /// <param name="rangeMaxRow"></param>
        /// <param name="rangeMinCol"></param>
        /// <param name="rangeMaxCol"></param>
        /// <returns></returns>
        public static List<object> GetShapesFromSheet(ISheet sheet, int? rangeMinRow = null, int? rangeMaxRow = null, int? rangeMinCol = null, int? rangeMaxCol = null)
        {
            List<object> shapeAllList = new List<object>();
            var shapeContainer = sheet.DrawingPatriarch;
            if (sheet is HSSFSheet)
            {
                var shapeContainerHSSF = sheet.DrawingPatriarch as HSSFShapeContainer;
                if (null != shapeContainer)
                {
                    var shapeList = shapeContainerHSSF.Children;
                    foreach (var shape in shapeList)
                    {
                        if (shape is HSSFShape && shape.Anchor is HSSFClientAnchor)
                        {
                            var anchor = shape.Anchor as HSSFClientAnchor;
                            if (IsInternalOrIntersect(rangeMinRow, rangeMaxRow, rangeMinCol, rangeMaxCol, anchor.Row1, anchor.Row2, anchor.Col1, anchor.Col2, true))
                            {
                                shapeAllList.Add(shape);
                            }
                        }
                    }
                }
            }
            else
            {
                var documentPartList = (sheet as XSSFSheet).GetRelations();
                foreach (var documentPart in documentPartList)
                {
                    if (documentPart is XSSFDrawing)
                    {
                        var drawing = (XSSFDrawing)documentPart;
                        var shapeList = drawing.GetShapes();
                        foreach (var shape in shapeList)
                        {
                            var anchorResult = shape.GetAnchor();
                            if (shape is XSSFShape && anchorResult is XSSFClientAnchor)
                            {
                                var anchor = anchorResult as XSSFClientAnchor;
                                if (IsInternalOrIntersect(rangeMinRow, rangeMaxRow, rangeMinCol, rangeMaxCol, anchor.Row1, anchor.Row2, anchor.Col1, anchor.Col2, true))
                                {
                                    shapeAllList.Add(shape);
                                }
                            }
                        }
                    }
                }
            }

            return shapeAllList;
        }


        /// <summary>
        /// 创建临时模板文件
        /// </summary>
        /// <param name="templatePath"></param>
        /// <param name="sheetName"></param>
        /// <param name="sheetCount"></param>
        /// <returns></returns>
        public static string CreateTempFileByTemplate(string templatePath, string sheetName, int sheetCount)
        {
            using (var fs = File.OpenRead(templatePath))
            {
                bool isCompatible = GetIsCompatible(templatePath);
                var workbook = CreateWorkbook(isCompatible, fs);
                var sheet = workbook.GetSheet(sheetName);

                CloneOneToManySheet(workbook, sheet, sheetCount);

                string tempTemplatePath = TempDirectory + string.Format("\\{0}-{1}-{2}", Guid.NewGuid().ToString("N"), sheetCount, Path.GetFileName(templatePath));

                using (var fs2 = File.Create(tempTemplatePath))
                {
                    workbook.Write(fs2);
                }

                return tempTemplatePath;
            }

        }

        /// <summary>
        /// 删除临时模板文件
        /// </summary>
        /// <param name="temp_templatePath"></param>
        public static void DeleteTempTemplateFile(string temp_templatePath)
        {
            if (!string.IsNullOrEmpty(temp_templatePath) && File.Exists(temp_templatePath))
            {
                File.Delete(temp_templatePath);
            }
            string temp_templateConfigFilePath = Path.ChangeExtension(temp_templatePath, ".xml");
            if (File.Exists(temp_templateConfigFilePath))
            {
                File.Delete(temp_templateConfigFilePath);
            }
        }


        /// <summary>
        /// 检查模板与导出路径合法性
        /// </summary>
        /// <param name="templatePath"></param>
        /// <param name="filePath"></param>
        public static void CheckTemplateAndExportPath(string templatePath,ref string filePath)
        {
            if (!File.Exists(templatePath))
            {
                throw new FileNotFoundException(templatePath + "文件不存在！");
            }

            bool isCompatible = Common.GetIsCompatible(templatePath);

            if (string.IsNullOrEmpty(filePath))
            {
                filePath = Common.GetSaveFilePath(isCompatible);
            }
            else if (isCompatible && !Path.GetExtension(filePath).Equals(".xls", StringComparison.OrdinalIgnoreCase))
            {
                throw new ArgumentException("当模板采用兼容模式时（低版本格式，如：xls,xlt），则指定的导出文件格式必需为xls。");
            }
        }

        /// <summary>
        /// 将一个工作薄克隆出多个工作薄
        /// </summary>
        /// <param name="workbook"></param>
        /// <param name="sheet"></param>
        /// <param name="sheetCount"></param>
        public static void CloneOneToManySheet(IWorkbook workbook, ISheet sheet, int sheetCount)
        {
            int sheetIndex = workbook.GetSheetIndex(sheet);
            for (int i = 1; i <= sheetCount - 1; i++)
            {
                workbook.CloneSheet(sheetIndex);
                workbook.SetSheetName(sheetIndex + i, sheet.SheetName + (i + 1).ToString());
            }
        }

        /// <summary>
        /// 判断是否在指定的区域范围内
        /// </summary>
        /// <param name="rangeMinRow"></param>
        /// <param name="rangeMaxRow"></param>
        /// <param name="rangeMinCol"></param>
        /// <param name="rangeMaxCol"></param>
        /// <param name="pictureMinRow"></param>
        /// <param name="pictureMaxRow"></param>
        /// <param name="pictureMinCol"></param>
        /// <param name="pictureMaxCol"></param>
        /// <param name="onlyInternal"></param>
        /// <returns></returns>

        private static bool IsInternalOrIntersect(int? rangeMinRow, int? rangeMaxRow, int? rangeMinCol, int? rangeMaxCol,
                                                int pictureMinRow, int pictureMaxRow, int pictureMinCol, int pictureMaxCol, bool onlyInternal)
        {
            int _rangeMinRow = rangeMinRow ?? pictureMinRow;
            int _rangeMaxRow = rangeMaxRow ?? pictureMaxRow;
            int _rangeMinCol = rangeMinCol ?? pictureMinCol;
            int _rangeMaxCol = rangeMaxCol ?? pictureMaxCol;

            if (onlyInternal)
            {
                return (_rangeMinRow <= pictureMinRow && _rangeMaxRow >= pictureMaxRow &&
                        _rangeMinCol <= pictureMinCol && _rangeMaxCol >= pictureMaxCol);
            }
            else
            {
                return ((Math.Abs(_rangeMaxRow - _rangeMinRow) + Math.Abs(pictureMaxRow - pictureMinRow) >= Math.Abs(_rangeMaxRow + _rangeMinRow - pictureMaxRow - pictureMinRow)) &&
                (Math.Abs(_rangeMaxCol - _rangeMinCol) + Math.Abs(pictureMaxCol - pictureMinCol) >= Math.Abs(_rangeMaxCol + _rangeMinCol - pictureMaxCol - pictureMinCol)));
            }
        }

    }
}
