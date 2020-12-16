using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnExceptionHandling
{
    class CustomException
    {
        public string ClassName { get; set; }
        public string MethodName { get; set; }
        public Exception Exception { get; set; }
    }
}
