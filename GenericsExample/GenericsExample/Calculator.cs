using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsExample
{
    class Calculator<T> where T :Entity
    {
        //public T A { get; set; }
        //public U B { get; set; }
        
        //public Calculator(T a,U b)
        //{
        //    A = a;
        //    B = b;
        //}
        //public U Sum()
        //{
        //    dynamic x = A;
        //    dynamic y = B;
        //    return x + y;
        //}

        public void Display()
        {
            Console.WriteLine("This is display class");
        }

        //public U Sum(T a,U b)
        //{
        //    dynamic x = a;
        //    dynamic y = b;
        //    return x+ y;
        //}
    }
}
