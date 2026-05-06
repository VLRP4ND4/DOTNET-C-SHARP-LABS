using System;
using System.IO;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace LAB_14
{
    internal class Program14
    {
        static void Main(string[] args)
        {
            Excel.Application excelApp = null;
            Excel.Workbook workbook = null;
            Excel.Worksheet worksheet = null;

            try
            {
                excelApp = new Excel.Application();
                excelApp.Visible = true;
                excelApp.DisplayAlerts = false;

                workbook = excelApp.Workbooks.Add();
                worksheet = workbook.ActiveSheet as Excel.Worksheet;
                worksheet.Name = "Почта";

                // Заголовок
                Excel.Range titleRange = worksheet.Range["B1", "D1"];
                titleRange.Merge();
                titleRange.Value = "Почта";
                titleRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                titleRange.Font.Size = 20;
                titleRange.Font.Bold = true;

                // Заголовки таблицы
                worksheet.Cells[3, 2] = "Номер";
                worksheet.Cells[3, 3] = "Наименование";
                worksheet.Cells[3, 4] = "Дата отправки";

                Excel.Range headerRange = worksheet.Range["B3", "D3"];
                headerRange.Font.Bold = true;
                headerRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                // Данные
                worksheet.Cells[4, 2] = 1290;
                worksheet.Cells[4, 3] = "посылка";
                worksheet.Cells[4, 4] = "12.10.2015";

                worksheet.Cells[5, 2] = 764;
                worksheet.Cells[5, 3] = "бандероль";
                worksheet.Cells[5, 4] = "04.11.2012";

                worksheet.Cells[6, 2] = 6526;
                worksheet.Cells[6, 3] = "письмо";
                worksheet.Cells[6, 4] = "05.10.2012";

                // Оформление наименований курсивом
                Excel.Range nameRange = worksheet.Range["C4", "C6"];
                nameRange.Font.Italic = true;

                // Границы таблицы
                Excel.Range tableRange = worksheet.Range["B3", "D6"];
                tableRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                tableRange.Borders.Weight = Excel.XlBorderWeight.xlThin;

                // Выравнивание
                worksheet.Range["B4", "B6"].HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
                worksheet.Range["D4", "D6"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                // Ширина столбцов
                worksheet.Columns["B"].ColumnWidth = 12;
                worksheet.Columns["C"].ColumnWidth = 18;
                worksheet.Columns["D"].ColumnWidth = 18;

                // Сохранение файла
                string filePath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                    "Lab14_Pochta.xlsx"
                );

                workbook.SaveAs(filePath);

                Console.WriteLine("Файл создан:");
                Console.WriteLine(filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            finally
            {
                if (workbook != null)
                {
                    workbook.Close(true);
                    Marshal.ReleaseComObject(workbook);
                }

                if (worksheet != null)
                {
                    Marshal.ReleaseComObject(worksheet);
                }

                if (excelApp != null)
                {
                    excelApp.Quit();
                    Marshal.ReleaseComObject(excelApp);
                }

                GC.Collect();
                GC.WaitForPendingFinalizers();
            }

            Console.ReadKey();
        }
    }
}

