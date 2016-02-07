using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using ExcelUtility.Base;

namespace ExcelUtility
{
    /// <summary>
    /// EXCEL导入功能集合类
    /// 作者：Zuowenjun
    /// 日期：2016/1/15
    /// </summary>
    public sealed class Import
    {
        /// <summary>
        /// 由Excel导入DataTable
        /// </summary>
        /// <param name="excelFileStream">Excel文件流</param>
        /// <param name="sheetName">Excel工作表名称</param>
        /// <param name="headerRowIndex">Excel表头行索引</param>
        /// <param name="isCompatible">是否为兼容模式</param>
        /// <returns>DataTable</returns>
        public static DataTable ToDataTable(Stream excelFileStream, string sheetName, int headerRowIndex, bool isCompatible)
        {
            IWorkbook workbook = Common.CreateWorkbook(isCompatible, excelFileStream);
            ISheet sheet = null;
            int sheetIndex = -1;
            if (int.TryParse(sheetName, out sheetIndex))
            {
                sheet = workbook.GetSheetAt(sheetIndex);
            }
            else
            {
                sheet = workbook.GetSheet(sheetName);
            }

            DataTable table = Common.GetDataTableFromSheet(sheet, headerRowIndex);

            excelFileStream.Close();
            workbook = null;
            sheet = null;
            return table;
        }

        /// <summary>
        /// 由Excel导入DataTable
        /// </summary>
        /// <param name="excelFilePath">Excel文件路径，为物理路径,可传空值</param>
        /// <param name="sheetName">Excel工作表名称</param>
        /// <param name="headerRowIndex">Excel表头行索引</param>
        /// <returns>DataTable</returns>
        public static DataTable ToDataTable(string excelFilePath, string sheetName, int headerRowIndex)
        {
            if (string.IsNullOrEmpty(excelFilePath))
            {
                excelFilePath = Common.GetOpenFilePath();
            }

            if (string.IsNullOrEmpty(excelFilePath))
            {
                return null;
            }

            using (FileStream stream = System.IO.File.OpenRead(excelFilePath))
            {
                bool isCompatible = Common.GetIsCompatible(excelFilePath);
                return ToDataTable(stream, sheetName, headerRowIndex, isCompatible);
            }
        }

        /// <summary>
        /// 由Excel导入DataSet，如果有多个工作表，则导入多个DataTable
        /// </summary>
        /// <param name="excelFileStream">Excel文件流</param>
        /// <param name="headerRowIndex">Excel表头行索引</param>
        /// <param name="isCompatible">是否为兼容模式</param>
        /// <returns>DataSet</returns>
        public static DataSet ToDataSet(Stream excelFileStream, int headerRowIndex, bool isCompatible)
        {
            DataSet ds = new DataSet();
            IWorkbook workbook = Common.CreateWorkbook(isCompatible, excelFileStream);
            for (int i = 0; i < workbook.NumberOfSheets; i++)
            {
                ISheet sheet = workbook.GetSheetAt(i);
                DataTable table = Common.GetDataTableFromSheet(sheet, headerRowIndex);
                ds.Tables.Add(table);
            }

            excelFileStream.Close();
            workbook = null;

            return ds;
        }

        /// <summary>
        /// 由Excel导入DataSet，如果有多个工作表，则导入多个DataTable
        /// </summary>
        /// <param name="excelFilePath">Excel文件路径，为物理路径。可传空值</param>
        /// <param name="headerRowIndex">Excel表头行索引</param>
        /// <returns>DataSet</returns>
        public static DataSet ToDataSet(string excelFilePath, int headerRowIndex)
        {
            if (string.IsNullOrEmpty(excelFilePath))
            {
                excelFilePath = Common.GetOpenFilePath();
            }

            if (string.IsNullOrEmpty(excelFilePath))
            {
                return null;
            }

            using (FileStream stream = System.IO.File.OpenRead(excelFilePath))
            {
                bool isCompatible = Common.GetIsCompatible(excelFilePath);
                return ToDataSet(stream, headerRowIndex, isCompatible);
            }
        }

    }
}
