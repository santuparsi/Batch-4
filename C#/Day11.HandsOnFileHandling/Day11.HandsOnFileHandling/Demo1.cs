using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Day11.HandsOnFileHandling
{
    class Demo1
    {
        public static void Read(string path)
        {
            try
            {
                using(StreamReader sr=new StreamReader(path))
                {
                    string content = sr.ReadToEnd();
                    Console.WriteLine(content);
                }
            }
            catch(IOException ex)
            {
                throw ex;
            }
        }
        public static void Write(string path)
        {
           try
            {
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    string content = @"Classes like:
                                            StreamReader
                                            StreamWrite
                                            FileInfo
                                            FileStream";
                    sw.WriteLine(content);
                }
            }
            catch(IOException ex)
            {
                throw ex;
            }
        }
        static void Main()
        {
            try
            {

                Write("D:\\1.pdf");
                Read("D:\\1.pdf");

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
