using System;
using System.IO;
namespace Day11.HandsOnFileHandling
{
    class Program
    {
        static void GetFileInfo(string path)
        {
           try
            {
                FileInfo obj = new FileInfo(path);
                Console.WriteLine("Length: " + obj.Length);
                Console.WriteLine("Name: " + obj.Name);
                Console.WriteLine("Path: " + obj.FullName);
            }
            catch(IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            GetFileInfo(@"D:\IDGLog.txt");
        }
    }
}
