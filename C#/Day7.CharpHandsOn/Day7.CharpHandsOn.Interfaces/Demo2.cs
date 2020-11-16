using System;
using System.Collections.Generic;
using System.Text;

namespace Day7.CharpHandsOn.Interfaces
{
    interface ICompute <T>
    {
        T Add(T a, T b);
        T Div(T a, T b);
    }
    class Compute : ICompute<int>
    {
        public int Add(int a, int b)
        {
            throw new NotImplementedException();
        }

        public int Div(int a, int b)
        {
            throw new NotImplementedException();
        }
    }
    class Compute1 : ICompute<double>
    {
        public double Add(double a, double b)
        {
            throw new NotImplementedException();
        }

        public double Div(double a, double b)
        {
            throw new NotImplementedException();
        }
    }
    class Demo2
    {
    }
}
