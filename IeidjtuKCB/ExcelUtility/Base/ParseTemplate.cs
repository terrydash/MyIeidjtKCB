using ExcelReport;
using NPOI.Extend;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ExcelUtility.Base
{
    internal static class ParseTemplate
    {
        public static WorkbookParameterContainer Parse(string templatePath)
        {
            var workbookParameterContainer = new WorkbookParameterContainer();
            IWorkbook workbook = NPOIHelper.LoadWorkbook(templatePath);
            foreach (ISheet sheet in workbook)
            {
                workbookParameterContainer[sheet.SheetName] = new SheetParameterContainer
                {
                    SheetName = sheet.SheetName
                };
                foreach (IRow row in sheet)
                {
                    foreach (ICell cell in row.Cells)
                    {
                        if (cell.CellType.Equals(CellType.String))
                        {
                            MatchCollection matches = new Regex(@"(?<=\$\[)([\w]*)(?=\])").Matches(cell.StringCellValue);
                            foreach (Match match in matches)
                            {
                                workbookParameterContainer[sheet.SheetName][match.Value] = new Parameter
                                {
                                    Name = match.Value,
                                    RowIndex = cell.RowIndex,
                                    ColumnIndex = cell.ColumnIndex
                                };
                            }
                        }
                    }
                }
            }
            return workbookParameterContainer;
        }
    }
}
