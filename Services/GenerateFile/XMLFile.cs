using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Services.Entities;
using System.Xml.Linq;
using System.IO;
using System.Runtime.InteropServices;

namespace Services.XML
{
    public class XMLFile
    {
        Microsoft.Office.Interop.Excel.Application excelFile;
        Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
        Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
        Microsoft.Office.Interop.Excel.Range range;
        public async Task<string> ReadCreateXML(string name = "Book2.xlsx")
        {
            string name1 = "";
            try
            {

                await Task.Delay(20000);
                excelFile = new Microsoft.Office.Interop.Excel.Application();
                xlWorkBook = excelFile.Workbooks.Open(name);

                List<User> userList = new List<User>();

                xlWorkBook = excelFile.Workbooks.Open(name, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                int rCnt;
                int rw = 0;

                range = xlWorkSheet.UsedRange;
                rw = range.Rows.Count;

                for (rCnt = 2; rCnt <= rw; rCnt++)
                {
                    User user = new User();

                    user.UserID = (string)(range.Cells[rCnt, 1] as Microsoft.Office.Interop.Excel.Range).Value2;
                    user.Password = (string)(range.Cells[rCnt, 2] as Microsoft.Office.Interop.Excel.Range).Value2;
                    user.Button_Label = (string)(range.Cells[rCnt, 3] as Microsoft.Office.Interop.Excel.Range).Value2;
                    user.LinkPath = (string)(range.Cells[rCnt, 4] as Microsoft.Office.Interop.Excel.Range).Value2;
                    user.PageTitle = (string)(range.Cells[rCnt, 5] as Microsoft.Office.Interop.Excel.Range).Value2;
                    user.TagName = (string)(range.Cells[rCnt, 6] as Microsoft.Office.Interop.Excel.Range).Value2;
                    user.LeftString = (string)(range.Cells[rCnt, 7] as Microsoft.Office.Interop.Excel.Range).Value2;
                    user.RightString = (string)(range.Cells[rCnt, 8] as Microsoft.Office.Interop.Excel.Range).Value2;
                    user.OutputColumnName = (string)(range.Cells[rCnt, 9] as Microsoft.Office.Interop.Excel.Range).Value2;

                    userList.Add(user);
                }

                xlWorkBook.Close(true, null, null);
                excelFile.Quit();

                XElement xmlfromlist = new XElement("Users",
                                                 from user in userList
                                                 select
                                                     new XElement("User",
                                                     new XElement("UserID", user.UserID),
                                                     new XElement("Password", user.Password),
                                                     new XElement("Button_Label", user.Button_Label),
                                                     new XElement("LinkPath", user.LinkPath),
                                                     new XElement("PageTitle", user.PageTitle),
                                                     new XElement("TagName", user.TagName),
                                                     new XElement("LeftString", user.LeftString),
                                                     new XElement("RightString", user.RightString),
                                                     new XElement("OutputColumnName", user.OutputColumnName)
                                                     ));
                string path = Path.GetDirectoryName(name);
                name1 = Path.GetFileNameWithoutExtension(name);
                xmlfromlist.Save(path + "//" + name1 + ".xml");

            }
            catch (Exception ex)
            {
                return "Fail";

            }
            finally
            {
                Marshal.ReleaseComObject(xlWorkSheet);
                Marshal.ReleaseComObject(xlWorkBook);
                Marshal.ReleaseComObject(excelFile);
            }
            return name1;
        }
        public async Task<List<User>> ReadXML(string name = "data.xml")
        {
            List<User> userList = new List<User>();
            try
            {
                await Task.Delay(20000);

                XElement xelement = XElement.Load(@name);
                IEnumerable<XElement> employees = xelement.Elements();
                foreach (var employee in employees)
                {
                    User user = new User();
                    user.UserID = employee.Element("UserID").Value;
                    user.Password = employee.Element("Password").Value;
                    user.Button_Label = employee.Element("Button_Label").Value;
                    user.LinkPath = employee.Element("LinkPath").Value;
                    user.PageTitle = employee.Element("PageTitle").Value;
                    user.TagName = employee.Element("TagName").Value;
                    user.LeftString = employee.Element("LeftString").Value;
                    user.RightString = employee.Element("RightString").Value;
                    user.OutputColumnName = employee.Element("OutputColumnName").Value;
                    userList.Add(user);
                }
            }
            catch (Exception ex) { throw ex; }
            return userList;
        }

        public async Task<string> SaveXML(String name, List<User> userList)
        {
            try
            {
                await Task.Delay(20000);
                XElement xmlfromlist = new XElement("Users",
                                                   from user in userList
                                                   select
                                                       new XElement("User",
                                                       new XElement("UserID", user.UserID),
                                                       new XElement("Password", user.Password),
                                                       new XElement("Button_Label", user.Button_Label),
                                                       new XElement("LinkPath", user.LinkPath),
                                                       new XElement("PageTitle", user.PageTitle),
                                                       new XElement("TagName", user.TagName),
                                                       new XElement("LeftString", user.LeftString),
                                                       new XElement("RightString", user.RightString),
                                                       new XElement("OutputColumnName", user.OutputColumnName)
                                                       ));

                xmlfromlist.Save(name);
            }
            catch { return "Fail"; }
            return "Pass";

        }
    }
}
