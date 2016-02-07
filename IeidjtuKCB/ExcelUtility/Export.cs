using ExcelReport;
using ExcelUtility.Base;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NPOI.Extend;

namespace ExcelUtility
{
    /// <summary>
    /// EXCEL导出功能集合类
    /// 作者：Zuowenjun
    /// 日期：2016/1/15
    /// </summary>
    public sealed class Export
    {
        /// <summary>
        /// 由DataSet导出Excel
        /// </summary>
        /// <param name="sourceDs">要导出数据的DataSet</param>
        /// <param name="filePath">导出路径，可选</param>
        /// <returns></returns>
        public static string ToExcel(DataSet sourceDs, string filePath = null)
        {

            if (string.IsNullOrEmpty(filePath))
            {
                filePath = Common.GetSaveFilePath();
            }

            if (string.IsNullOrEmpty(filePath)) return null;

            bool isCompatible = Common.GetIsCompatible(filePath);

            IWorkbook workbook = Common.CreateWorkbook(isCompatible);
            ICellStyle headerCellStyle = Common.GetCellStyle(workbook, true);
            //ICellStyle cellStyle = Common.GetCellStyle(workbook);

            for (int i = 0; i < sourceDs.Tables.Count; i++)
            {
                DataTable table = sourceDs.Tables[i];
                string sheetName = string.IsNullOrEmpty(table.TableName) ? "result" + i.ToString() : table.TableName;
                ISheet sheet = workbook.CreateSheet(sheetName);
                IRow headerRow = sheet.CreateRow(0);
                Dictionary<int, ICellStyle> colStyles = new Dictionary<int, ICellStyle>();
                // handling header.
                foreach (DataColumn column in table.Columns)
                {
                    ICell headerCell = headerRow.CreateCell(column.Ordinal);
                    headerCell.SetCellValue(column.ColumnName);
                    headerCell.CellStyle = headerCellStyle;
                    sheet.AutoSizeColumn(headerCell.ColumnIndex);
                    colStyles[headerCell.ColumnIndex] = Common.GetCellStyle(workbook);
                }

                // handling value.
                int rowIndex = 1;

                foreach (DataRow row in table.Rows)
                {
                    IRow dataRow = sheet.CreateRow(rowIndex);

                    foreach (DataColumn column in table.Columns)
                    {
                        ICell cell = dataRow.CreateCell(column.Ordinal);
                        //cell.SetCellValue((row[column] ?? "").ToString());
                        //cell.CellStyle = cellStyle;
                        Common.SetCellValue(cell, (row[column] ?? "").ToString(), column.DataType, colStyles);
                        Common.ReSizeColumnWidth(sheet, cell);
                    }

                    rowIndex++;
                }
                sheet.ForceFormulaRecalculation = true;
            }

            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            workbook.Write(fs);
            fs.Dispose();
            workbook = null;

            return filePath;

        }

        /// <summary>
        /// 由DataTable导出Excel
        /// </summary>
        /// <param name="sourceTable">要导出数据的DataTable</param>
        /// <param name="colAliasNames">导出的列名重命名数组</param>
        /// <param name="sheetName">工作薄名称，可选</param>
        /// <param name="filePath">导出路径，可选</param>
        /// <param name="colDataFormats">列格式化集合，可选</param>
        /// <returns></returns>
        public static string ToExcel(DataTable sourceTable, string[] colAliasNames, string sheetName = "result", string filePath = null, IDictionary<string, string> colDataFormats = null)
        {
            if (sourceTable.Rows.Count <= 0) return null;

            if (string.IsNullOrEmpty(filePath))
            {
                filePath = Common.GetSaveFilePath();
            }

            if (string.IsNullOrEmpty(filePath)) return null;

            if (colAliasNames == null || sourceTable.Columns.Count != colAliasNames.Length)
            {
                throw new ArgumentException("列名重命名数组与DataTable列集合不匹配。", "colAliasNames");
            }

            bool isCompatible = Common.GetIsCompatible(filePath);

            IWorkbook workbook = Common.CreateWorkbook(isCompatible);
            ICellStyle headerCellStyle = Common.GetCellStyle(workbook, true);
            //ICellStyle cellStyle = Common.GetCellStyle(workbook);
            Dictionary<int, ICellStyle> colStyles = new Dictionary<int, ICellStyle>();

            ISheet sheet = workbook.CreateSheet(sheetName);
            IRow headerRow = sheet.CreateRow(0);
            // handling header.
            foreach (DataColumn column in sourceTable.Columns)
            {
                ICell headerCell = headerRow.CreateCell(column.Ordinal);
                headerCell.SetCellValue(colAliasNames[column.Ordinal]);
                headerCell.CellStyle = headerCellStyle;
                sheet.AutoSizeColumn(headerCell.ColumnIndex);
                if (colDataFormats != null && colDataFormats.ContainsKey(column.ColumnName))
                {
                    colStyles[headerCell.ColumnIndex] = Common.GetCellStyleWithDataFormat(workbook, colDataFormats[column.ColumnName]);
                }
                else
                {
                    colStyles[headerCell.ColumnIndex] = Common.GetCellStyle(workbook);
                }
            }

            // handling value.
            int rowIndex = 1;

            foreach (DataRow row in sourceTable.Rows)
            {
                IRow dataRow = sheet.CreateRow(rowIndex);

                foreach (DataColumn column in sourceTable.Columns)
                {
                    ICell cell = dataRow.CreateCell(column.Ordinal);
                    //cell.SetCellValue((row[column] ?? "").ToString());
                    //cell.CellStyle = cellStyle;
                    Common.SetCellValue(cell, (row[column] ?? "").ToString(), column.DataType, colStyles);
                    Common.ReSizeColumnWidth(sheet, cell);
                }

                rowIndex++;
            }
            sheet.ForceFormulaRecalculation = true;

            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            workbook.Write(fs);
            fs.Dispose();

            sheet = null;
            headerRow = null;
            workbook = null;

            return filePath;
        }

        /// <summary>
        /// 由DataGridView导出
        /// </summary>
        /// <param name="grid">要导出的DataGridView对象</param>
        /// <param name="sheetName">工作薄名称，可选</param>
        /// <param name="filePath">导出路径，可选</param>
        /// <param name="includeHiddenCol">导出时是否包含隐藏列，可选</param>
        /// <param name="colHeaderTexts">指定导出DataGridView的列标题名数组，可选</param>
        /// <param name="colDataFormats">列格式化集合，可选</param>
        /// <returns></returns>
        public static string ToExcel(DataGridView grid, string sheetName = "result", string filePath = null, bool includeHiddenCol = false, string[] colHeaderTexts = null, IDictionary<string, string> colDataFormats = null)
        {
            if (grid.Rows.Count <= 0) return null;

            if (string.IsNullOrEmpty(filePath))
            {
                filePath = Common.GetSaveFilePath();
            }

            if (string.IsNullOrEmpty(filePath)) return null;

            bool isCompatible = Common.GetIsCompatible(filePath);

            DataGridViewColumn[] expCols = null;
            expCols = grid.Columns.Cast<DataGridViewColumn>().OrderBy(c => c.DisplayIndex).ToArray();
            if (!includeHiddenCol)
            {
                expCols = expCols.Where(c => c.Visible).ToArray();
            }

            if (colHeaderTexts != null && colHeaderTexts.Length > 0)
            {
                expCols = expCols.Where(c => colHeaderTexts.Contains(c.HeaderText)).ToArray();
            }


            IWorkbook workbook = Common.CreateWorkbook(isCompatible);
            ICellStyle headerCellStyle = Common.GetCellStyle(workbook, true);
            //ICellStyle cellStyle = Common.GetCellStyle(workbook);
            ISheet sheet = workbook.CreateSheet(sheetName);

            IRow headerRow = sheet.CreateRow(0);

            Dictionary<int, ICellStyle> colStyles = new Dictionary<int, ICellStyle>();
            for (int i = 0; i < expCols.Length; i++)
            {
                ICell headerCell = headerRow.CreateCell(i);
                headerCell.SetCellValue(expCols[i].HeaderText);
                headerCell.CellStyle = headerCellStyle;
                sheet.AutoSizeColumn(headerCell.ColumnIndex);
                if (colDataFormats != null && colDataFormats.ContainsKey(expCols[i].HeaderText))
                {
                    colStyles[headerCell.ColumnIndex] = Common.GetCellStyleWithDataFormat(workbook, colDataFormats[expCols[i].HeaderText]);
                }
                else
                {
                    colStyles[headerCell.ColumnIndex] = Common.GetCellStyle(workbook);
                }
            }

            int rowIndex = 1;
            foreach (DataGridViewRow row in grid.Rows)
            {
                IRow dataRow = sheet.CreateRow(rowIndex);
                for (int n = 0; n < expCols.Length; n++)
                {
                    ICell cell = dataRow.CreateCell(n);
                    //cell.SetCellValue((row.Cells[expCols[n].Index].Value ?? "").ToString());
                    //cell.CellStyle = cellStyle;
                    Common.SetCellValue(cell, (row.Cells[expCols[n].Index].Value ?? "").ToString(), expCols[n].ValueType, colStyles);
                    Common.ReSizeColumnWidth(sheet, cell);
                }
                rowIndex++;
            }
            sheet.ForceFormulaRecalculation = true;

            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            workbook.Write(fs);
            fs.Dispose();

            sheet = null;
            headerRow = null;
            workbook = null;

            return filePath;
        }

        /// <summary>
        /// 由DataTable导出Excel
        /// </summary>
        /// <param name="sourceTable">要导出数据的DataTable</param>
        /// <param name="sheetName">工作薄名称，可选</param>
        /// <param name="filePath">导出路径，可选</param>
        /// <param name="colNames">需要导出的列名,可选</param>
        /// <param name="colAliasNames">导出的列名重命名，可选</param>
        /// <param name="colDataFormats">列格式化集合，可选</param>
        /// <param name="sheetSize">指定每个工作薄显示的记录数，可选（不指定或指定小于0，则表示只生成一个工作薄）</param>
        /// <returns></returns>
        public static string ToExcel(DataTable sourceTable, string sheetName = "result", string filePath = null, string[] colNames = null, IDictionary<string, string> colAliasNames = null, IDictionary<string, string> colDataFormats = null, int sheetSize = 0)
        {
            if (sourceTable.Rows.Count <= 0) return null;

            if (string.IsNullOrEmpty(filePath))
            {
                filePath = Common.GetSaveFilePath();
            }

            if (string.IsNullOrEmpty(filePath)) return null;

            bool isCompatible = Common.GetIsCompatible(filePath);

            IWorkbook workbook = Common.CreateWorkbook(isCompatible);
            ICellStyle headerCellStyle = Common.GetCellStyle(workbook, true);
            //ICellStyle cellStyle = Common.GetCellStyle(workbook);

            if (colNames == null || colNames.Length <= 0)
            {
                colNames = sourceTable.Columns.Cast<DataColumn>().OrderBy(c => c.Ordinal).Select(c => c.ColumnName).ToArray();
            }

            IEnumerable<DataRow> batchDataRows, dataRows = sourceTable.Rows.Cast<DataRow>();
            int sheetCount = 0;
            if (sheetSize <= 0)
            {
                sheetSize = sourceTable.Rows.Count;
            }
            while ((batchDataRows = dataRows.Take(sheetSize)).Count() > 0)
            {

                Dictionary<int, ICellStyle> colStyles = new Dictionary<int, ICellStyle>();

                ISheet sheet = workbook.CreateSheet(sheetName + (++sheetCount).ToString());
                IRow headerRow = sheet.CreateRow(0);

                // handling header.
                for (int i = 0; i < colNames.Length; i++)
                {
                    ICell headerCell = headerRow.CreateCell(i);
                    if (colAliasNames != null && colAliasNames.ContainsKey(colNames[i]))
                    {
                        headerCell.SetCellValue(colAliasNames[colNames[i]]);
                    }
                    else
                    {
                        headerCell.SetCellValue(colNames[i]);
                    }
                    headerCell.CellStyle = headerCellStyle;
                    sheet.AutoSizeColumn(headerCell.ColumnIndex);
                    if (colDataFormats != null && colDataFormats.ContainsKey(colNames[i]))
                    {
                        colStyles[headerCell.ColumnIndex] = Common.GetCellStyleWithDataFormat(workbook, colDataFormats[colNames[i]]);
                    }
                    else
                    {
                        colStyles[headerCell.ColumnIndex] = Common.GetCellStyle(workbook);
                    }
                }

                // handling value.
                int rowIndex = 1;

                foreach (DataRow row in batchDataRows)
                {
                    IRow dataRow = sheet.CreateRow(rowIndex);

                    for (int i = 0; i < colNames.Length; i++)
                    {
                        ICell cell = dataRow.CreateCell(i);
                        //cell.SetCellValue((row[colNames[i]] ?? "").ToString());
                        //cell.CellStyle = cellStyle;
                        Common.SetCellValue(cell, (row[colNames[i]] ?? "").ToString(), sourceTable.Columns[colNames[i]].DataType, colStyles);
                        Common.ReSizeColumnWidth(sheet, cell);
                    }

                    rowIndex++;
                }
                sheet.ForceFormulaRecalculation = true;

                dataRows = dataRows.Skip(sheetSize);
            }

            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            workbook.Write(fs);
            fs.Dispose();
            workbook = null;

            return filePath;
        }


        /// <summary>
        ///由SheetFormatterContainer导出基于EXCEL模板的文件
        /// </summary>
        /// <param name="templatePath">模板路径</param>
        /// <param name="sheetName">模板中使用的工作薄名称</param>
        /// <param name="formatterContainer">模板数据格式化容器</param>
        /// <param name="filePath">导出路径，可选</param>
        /// <returns></returns>

        public static string ToExcelWithTemplate(string templatePath, string sheetName, SheetFormatterContainer formatterContainer, string filePath = null)
        {

            Common.CheckTemplateAndExportPath(templatePath, ref filePath);

            if (string.IsNullOrEmpty(filePath)) return null;

            string templateConfigFilePath = Common.GetTemplateConfigFilePath(templatePath, false);

            var workbookParameterContainer = new WorkbookParameterContainer();
            workbookParameterContainer.Load(templateConfigFilePath);
            SheetParameterContainer sheetParameterContainer = workbookParameterContainer[sheetName];
            ExportHelper.ExportToLocal(templatePath, filePath, new SheetFormatter(sheetName, formatterContainer.GetFormatters(sheetParameterContainer)));

            return filePath;
        }


        /// <summary>
        /// 由SheetFormatterContainer集合导出基于多工作薄的EXCEL模板的文件
        /// </summary>
        /// <param name="templatePath">模板路径</param>
        /// <param name="formatterContainers">模板数据格式化容器字典（Key:Sheet名称，Value:模板数据格式化容器对象）</param>
        /// <param name="filePath">导出路径，可选</param>
        /// <returns></returns>
        public static string ToExcelWithTemplate(string templatePath, IDictionary<string, SheetFormatterContainer> formatterContainers, string filePath = null)
        {
            Common.CheckTemplateAndExportPath(templatePath, ref filePath);

            if (string.IsNullOrEmpty(filePath)) return null;

            string templateConfigFilePath = Common.GetTemplateConfigFilePath(templatePath, false);

            var workbookParameterContainer = new WorkbookParameterContainer();
            workbookParameterContainer.Load(templateConfigFilePath);
            List<SheetFormatter> sheetFormatterList = new List<SheetFormatter>();
            foreach (var item in formatterContainers)
            {
                SheetParameterContainer sheetParameterContainer = workbookParameterContainer[item.Key];
                sheetFormatterList.Add(new SheetFormatter(item.Key, item.Value.GetFormatters(sheetParameterContainer)));
            }
            ExportHelper.ExportToLocal(templatePath, filePath, sheetFormatterList.ToArray());

            return filePath;
        }



        /// <summary>
        /// 由GetFormatterContainer Func委托导出基于EXCEL模板的多工作薄文件
        /// </summary>
        /// <typeparam name="T">数据源可枚举项类型</typeparam>
        /// <param name="templatePath">模板路径</param>
        /// <param name="sheetName">模板中使用的工作薄名称</param>
        /// <param name="dataSource">数据源</param>
        /// <param name="getFormatterContainer">生成模板数据格式化容器（SheetFormatterContainer）委托,在委托方法中实现模板的格式化过程</param>
        /// <param name="sheetSize">每个工作薄显示的数据记录数</param>
        /// <param name="filePath">导出路径，可选</param>
        /// <returns></returns>
        public static string ToExcelWithTemplate<T>(string templatePath, string sheetName, IEnumerable<T> dataSource, Func<IEnumerable<T>, SheetFormatterContainer> getFormatterContainer, int sheetSize, string filePath = null)
        {

            Common.CheckTemplateAndExportPath(templatePath, ref filePath);

            if (string.IsNullOrEmpty(filePath)) return null;

            int sheetCount = 0;
            var formatterContainers = new Dictionary<string, SheetFormatterContainer>();
            IEnumerable<T> data = null;
            while ((data = dataSource.Take(sheetSize)).Count() > 0)
            {
                var sheetFormatterContainer = getFormatterContainer(data);
                sheetCount++;
                if (sheetCount == 1)
                {
                    formatterContainers.Add(sheetName, sheetFormatterContainer);
                }
                else
                {
                    formatterContainers.Add(sheetName + sheetCount.ToString(), sheetFormatterContainer);
                }
                dataSource = dataSource.Skip(sheetSize);
            }
            string temp_templatePath = null;
            try
            {
                temp_templatePath = Common.CreateTempFileByTemplate(templatePath, sheetName, sheetCount);
                filePath = ToExcelWithTemplate(temp_templatePath, formatterContainers, filePath);
            }
            finally
            {
                Common.DeleteTempTemplateFile(temp_templatePath);
            }

            return filePath;
        }


        /// <summary>
        /// 由SheetFormatterContainer集合导出基于EXCEL模板的多工作薄文件
        /// </summary>
        /// <param name="templatePath">模板路径</param>
        /// <param name="sheetName">模板中使用的工作薄名称</param>
        /// <param name="formatterContainers">模板数据格式化容器列表</param>
        /// <param name="filePath">导出路径，可选</param>
        /// <returns></returns>
        public static string ToExcelWithTemplate(string templatePath, string sheetName, List<SheetFormatterContainer> formatterContainers, string filePath = null)
        {
            Common.CheckTemplateAndExportPath(templatePath, ref filePath);

            if (string.IsNullOrEmpty(filePath)) return null;

            string temp_templatePath = null;
            try
            {
                int sheetCount = 0;
                var formatterContainerDic = new Dictionary<string, SheetFormatterContainer>();
                for (int i = 0; i < formatterContainers.Count; i++)
                {
                    sheetCount++;
                    if (sheetCount == 1)
                    {
                        formatterContainerDic.Add(sheetName, formatterContainers[i]);
                    }
                    else
                    {
                        formatterContainerDic.Add(sheetName + sheetCount.ToString(), formatterContainers[i]);
                    }
                }
                temp_templatePath = Common.CreateTempFileByTemplate(templatePath, sheetName, sheetCount);

                filePath = ToExcelWithTemplate(temp_templatePath, formatterContainerDic, filePath);
            }
            finally
            {
                Common.DeleteTempTemplateFile(temp_templatePath);
            }

            return filePath;
        }

    }
}
