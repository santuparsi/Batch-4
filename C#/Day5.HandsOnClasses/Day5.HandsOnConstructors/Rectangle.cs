using System;
using System.Collections.Generic;
using System.Text;

namespace Day5.HandsOnConstructors
{
    class Rectangle
    {
        private int _lenght;
        private int _width;
        public Rectangle() //default constructor
        {
            _lenght = 10;
            _width = 20;
        }
        public Rectangle(int l,int w) //parametarized consturctor
        {
            _lenght = l;
            _width = w;
        }
        public Rectangle(Rectangle r) //copy construnctor
        {
            _lenght = r._lenght;
            _width = r._width;
        }
        public int Area()
        {
            int res; //local variable
            res = _lenght * _width;
            return res;
        }
    }
  
}
