using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnMVCCoreUsingControllerAndModelswithViews.Controllers
{
    public class DemoController : Controller
    {
        public string Index()
        {
            return "I am action a method in mvc controller..";
        }
        public string Greet(string name)
        {
            return "Hello " + name;
        }
        public int Sum(int a,int b)
        {
            return a + b;
        }
    }
}
