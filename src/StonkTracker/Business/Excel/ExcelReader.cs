using OfficeOpenXml;
using StonkTracker.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace StonkTracker.Business.Excel
{
    public static class ExcelReader
    {
        public static List<SuggestionModel> ReadSuggestionsInputFile(string fileName)
        {

            var models = new List<SuggestionModel>();

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            FileInfo info = new FileInfo(fileName);

            var package = new ExcelPackage(info);
            var worksheet = package.Workbook.Worksheets.FirstOrDefault();

            for (int i = 1; i < worksheet.Dimension.Rows; i++)
            {
                if (worksheet.Cells[i, 1].Value != null)
                {
                    models.Add(new SuggestionModel(
                        worksheet.Cells[i, 1].Value.ToString(),
                        worksheet.Cells[i, 2].Value.ToString(),
                        worksheet.Cells[i, 3].Value.ToString(),
                        worksheet.Cells[i, 4].Value.ToString(),
                        worksheet.Cells[i, 5].Value.ToString(),
                        worksheet.Cells[i, 6].Value.ToString()));
                }
            }

            return models;
        }
    }
}
