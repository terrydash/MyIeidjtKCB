using System;
using System.Collections.Generic;
using System.IO;
using OfficeOpenXml;
using OfficeOpenXml.Table;
using System.Reflection;
using OfficeOpenXml.Style;

namespace IeidjtuKCB.Common
{
    public class ExcelHelper
    {

        #region 保存数据列表到Excel（泛型）+void SaveToExcel<T>(IEnumerable<T> data, string FileName, string OpenPassword = "")
        /// <summary>
        /// 保存数据列表到Excel（泛型）
        /// </summary>
        /// <typeparam name="T">集合数据类型</typeparam>
        /// <param name="data">数据列表</param>
        /// <param name="FileName">Excel文件</param>
        /// <param name="OpenPassword">Excel打开密码</param>
        public static void SaveToExcel<T>(IEnumerable<T> data, string FileName, bool IsprintHeaders, string OpenPassword = "")
        {
            FileInfo file = new FileInfo(FileName);
            try
            {
                using (ExcelPackage ep = new ExcelPackage(file, OpenPassword))
                {
                    ExcelWorksheet ws = ep.Workbook.Worksheets.Add(typeof(T).Name);
                    ws.Cells["A1"].LoadFromCollection(data, IsprintHeaders, TableStyles.Medium10);
                    
                    ep.Save(OpenPassword);
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
        public static void SaveToExcel(IeidjtuKCB.Common.MakeExcelModel MEM)
        {if (MEM!=null)
            {  if (!string.IsNullOrWhiteSpace(MEM.Filename))
                { 


                FileInfo file = new FileInfo(MEM.Filename);
                    try
                    {
                        using (ExcelPackage ep = new ExcelPackage(file, MEM.PassWord))
                            {
                                ExcelWorksheet ws = ep.Workbook.Worksheets.Add(MEM.TitleName);
                                ws.Cells["A1"].Value = MEM.TitleName;
                            ws.Cells["A1"].Style.Font.Bold = true;
                            ws.Cells["A1"].Style.Font.Name= "微软雅黑";
                            ws.Cells["A1"].Style.Font.Size = 24;
                            
                            ws.Cells[1, 1, 1, MEM.HeaderText.Count].Merge = true;
                            
                            for (int i = 1; i <= MEM.HeaderText.Count; i++)
                            {
                                ws.Cells[2, i].Value = MEM.HeaderText[i - 1];
                                ws.Cells[2, i].Style.Font.Bold = true;
                                ws.Cells[2, i].Style.Font.Name = "微软雅黑";
                                ws.Cells[2, i].Style.Font.Size = 11;
                                
                            }                            
                            
                            
                            ws.Cells[3,1].LoadFromDataTable(MEM.dataTable, false, TableStyles.Medium13);
                            string rng = ws.Dimension.Address.ToUpper();
                            ws.Cells[rng].Style.HorizontalAlignment= ExcelHorizontalAlignment.Center;
                            ws.Cells[rng].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                            ws.Cells[rng].Style.Numberformat.Format = "@";
                            ws.Cells[rng].AutoFitColumns();
                            ws.View.FreezePanes(3,1);
                            ep.Save(MEM.PassWord);
                            }
                        
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine(ex.Message);
                 }
                }
            }
        }

        #region 从Excel中加载数据（泛型）+IEnumerable<T> LoadFromExcel<T>(string FileName) where T : new()
        /// <summary>
        /// 从Excel中加载数据（泛型）
        /// </summary>
        /// <typeparam name="T">每行数据的类型</typeparam>
        /// <param name="FileName">Excel文件名</param>
        /// <returns>泛型列表</returns>
        private static IEnumerable<T> LoadFromExcel<T>(string FileName) where T : new()
        {
            FileInfo existingFile = new FileInfo(FileName);
            List<T> resultList = new List<T>();
            Dictionary<string, int> dictHeader = new Dictionary<string, int>();

            using (ExcelPackage package = new ExcelPackage(existingFile))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[1];

                int colStart = worksheet.Dimension.Start.Column;  //工作区开始列
                int colEnd = worksheet.Dimension.End.Column;       //工作区结束列
                int rowStart = worksheet.Dimension.Start.Row;       //工作区开始行号
                int rowEnd = worksheet.Dimension.End.Row;       //工作区结束行号

                //将每列标题添加到字典中
                for (int i = colStart; i <= colEnd; i++)
                {
                    dictHeader[worksheet.Cells[rowStart, i].Value.ToString()] = i;
                }

                List<PropertyInfo> propertyInfoList = new List<PropertyInfo>(typeof(T).GetProperties());

                for (int row = rowStart + 1; row < rowEnd; row++)
                {
                    T result = new T();

                    //为对象T的各属性赋值
                    foreach (PropertyInfo p in propertyInfoList)
                    {
                        try
                        {
                            ExcelRange cell = worksheet.Cells[row, dictHeader[p.Name]]; //与属性名对应的单元格

                            if (cell.Value == null)
                                continue;
                            switch (p.PropertyType.Name.ToLower())
                            {
                                case "string":
                                    
                                    p.SetValue(result, cell.GetValue<String>(),null);
                                    break;
                                case "int16":
                                    p.SetValue(result, cell.GetValue<Int16>(), null);
                                    break;
                                case "int32":
                                    p.SetValue(result, cell.GetValue<Int32>(), null);
                                    break;
                                case "int64":
                                    p.SetValue(result, cell.GetValue<Int64>(), null);
                                    break;
                                case "decimal":
                                    p.SetValue(result, cell.GetValue<Decimal>(), null);
                                    break;
                                case "double":
                                    p.SetValue(result, cell.GetValue<Double>(), null);
                                    break;
                                case "datetime":
                                    p.SetValue(result, cell.GetValue<DateTime>(), null);
                                    break;
                                case "boolean":
                                    p.SetValue(result, cell.GetValue<Boolean>(), null);
                                    break;
                                case "byte":
                                    p.SetValue(result, cell.GetValue<Byte>(), null);
                                    break;
                                case "char":
                                    p.SetValue(result, cell.GetValue<Char>(), null);
                                    break;
                                case "single":
                                    p.SetValue(result, cell.GetValue<Single>(), null);
                                    break;
                                default:
                                    break;
                            }
                        }
                        catch 
                        { }
                    }
                    resultList.Add(result);
                }
            }
            return resultList;
        }
        #endregion
    }
}
