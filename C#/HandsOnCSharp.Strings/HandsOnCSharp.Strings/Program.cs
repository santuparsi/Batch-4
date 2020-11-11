using System;

namespace HandsOnCSharp.Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string s = "David";
            string path = "D:\\OnlineBatch\\Dotnet-Batch-4\\C#\\HandsOnCSharp.Strings";
            string path1 = @"D:\OnlineBatch\Dotnet-Batch-4\C#\HandsOnCSharp.Strings";
            Console.WriteLine(path);
            Console.WriteLine(path1);
            string content = @"Dotnet is the product of Microsoft
Dotnet 5.0 is releasing in the month Nov 2020";
            string connecion = @"Data Source=SANTU\MSSQLSERVER2019;Initial Catalog=ProductDB;User ID=sa;Password=***********";
        }
    }
}
