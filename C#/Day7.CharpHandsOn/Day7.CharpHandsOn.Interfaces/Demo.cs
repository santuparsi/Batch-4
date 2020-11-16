using System;
using System.Collections.Generic;
using System.Text;

namespace Day7.CharpHandsOn.Interfaces
{
    interface IA
    {
        void M1();
    }
    interface IB : IA
    {
        void M2();
    }


    class Demo : IB
    {
        public void M1()
        {
            throw new NotImplementedException();
        }

        public void M2()
        {
            throw new NotImplementedException();
        }
    }
}
