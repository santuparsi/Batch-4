using System;
using System.Collections.Generic;
using System.Text;

namespace Day7.CharpHandsOn.Interfaces
{
    interface IMobile
    {
        void Discount();
    }
    interface ILaptop
    {
        void Discount();
    }

    class Shop:IMobile,ILaptop
    {
        //explicit implementation.
        void ILaptop.Discount()
        {
            Console.WriteLine("ILaptop::Discount");
        }
        void IMobile.Discount()
        {
            Console.WriteLine("IMobile::Discount");
        }
    }
    class Purchase
    {
        static void Main()
        {
            ILaptop lap = new Shop();
            lap.Discount();
            IMobile mobile = new Shop();
            mobile.Discount();
            Shop shop = new Shop();
            
        }
    }

}
