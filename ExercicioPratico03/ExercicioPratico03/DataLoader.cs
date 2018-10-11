using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExercicioPratico03
{
    static class DataLoader
    {
        public static List<AppSalesData> Load()
        {
            Excel.Application app = new Excel.Application();
            List<AppSalesData> data = new List<AppSalesData>();
            Excel.Workbook wb = null;

            try
            {
                wb = app.Workbooks.Open(Environment.CurrentDirectory + "\\" + "data.xls");
                Excel._Worksheet ws = wb.Sheets[1];
                Excel.Range rg = ws.UsedRange;

                int entradas = rg.Rows.Count;

                for (int i = 2; i <= entradas; i++)
                {
                    long appCode; long.TryParse(rg.Cells[i, 1].Value2.ToString(), out appCode);
                    long companyId; long.TryParse(rg.Cells[i, 5].Value2.ToString(), out companyId);
                    long downloads; long.TryParse(rg.Cells[i, 4].Value2.ToString(), out downloads);
                    string appName = rg.Cells[i, 2].Value2.ToString();
                    string companyName = rg.Cells[i, 6].Value2.ToString();
                    string companyCountry = rg.Cells[i, 7].Value2.ToString();
                    double price; double.TryParse(rg.Cells[i, 3].Value2.ToString(), out price);
                    data.Add(new AppSalesData(appCode, companyId, downloads, appName, companyName, companyCountry, price));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                if (wb != null)
                    wb.Close(true, System.Reflection.Missing.Value, System.Reflection.Missing.Value);
                app.Quit();
            }
            return data;
        }
    }
}
