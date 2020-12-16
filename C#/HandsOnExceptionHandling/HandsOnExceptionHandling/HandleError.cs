using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace HandsOnExceptionHandling
{
    class HandleError
    {
        public static void WriteError(CustomException ex)
        {
            string err_content = @"Message: "+ex.Exception.Message+
                "ClassName: "+ex.ClassName+
                "MethodName: "+ex.MethodName+
                "Date: "+DateTime.Now+Environment.NewLine;
            using(StreamWriter writer=new StreamWriter("errinfo.txt",true))
            {
                writer.WriteLine(err_content);
            }
        }
    }
}
