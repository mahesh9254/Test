using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Services.Excel
{
   public class ExcelFile
    {
        private string _excelName = "data";
        Microsoft.Office.Interop.Excel.Application excelFile;
        Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
        Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
             

        public async Task<string> CreateWriteExcel()
        {
            try
            {
                await Task.Delay(20000);
                excelFile = new Microsoft.Office.Interop.Excel.Application();
                excelFile.DisplayAlerts = false;
                if (excelFile == null)
                {
                    return "fail";
                }
                xlWorkBook = excelFile.Workbooks.Add(Type.Missing);
                string[] lines = System.IO.File.ReadAllLines(@"C:\Users\mahes\Desktop\Assignment\FirstData.txt");
                xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.ActiveSheet;
                xlWorkSheet.Name = "New Data";
                int i = 1;
                foreach (var line in lines)
                {
                    string[] values = line.Split('/');
                    int j = 1;
                    foreach (var value in values)
                    {
                        xlWorkSheet.Cells[i, j] = value;
                        j++;
                    }
                    i++;

                }
                Random random = new Random();             
                xlWorkBook.SaveAs(_excelName);
                xlWorkBook.Close();
                excelFile.Quit();

            }
            catch
            {
                return "fail";
            }
            finally
            {
                Marshal.ReleaseComObject(xlWorkSheet);
                Marshal.ReleaseComObject(xlWorkBook);
                Marshal.ReleaseComObject(excelFile);
            }
            return  _excelName;
        }
    }
}
