using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using OfficeOpenXml;
using System.Collections;
namespace Day11.HandsOnFileHandling
{
    class Demo2
    {
        public static IList<Content> ImportExcel(string filePath)
        {
          

            FileInfo file = new FileInfo(filePath);
            using (ExcelPackage package = new ExcelPackage(file))
            {
                ExcelWorksheet workSheet = package.Workbook.Worksheets[1];
                int totalRows = workSheet.Dimension.Rows;

                List<Content> contents = new List<Content>();

                for (int i = 2; i <6; i++)
                {
                    contents.Add(new Content
                    {
                        Skills = workSheet.Cells[i, 1].Value.ToString().Trim(),
                        Scope = workSheet.Cells[i, 2].Value.ToString().Trim(),
                        
                    });
                }

               

                return contents;
            }
        }
        static void Main()
        {
            try
            {
                string path = @"C:\Users\SANTHOSH\Desktop\Dontnet Core Contents\NET_TOC.xlsx";
                IList<Content> list = ImportExcel(path);
               // ArrayList ar = ImportExcel(path) as ArrayList;
                foreach (Content content in list)
                {
                    Console.WriteLine("{0} {1} ", content.Skills, content.Scope);
                }
            }
            catch(IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
