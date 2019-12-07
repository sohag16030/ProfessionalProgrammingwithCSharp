using System;

namespace GenericsExample
{
    class Program
    {
        static void Main(string[] args)
        {

            //var c1 = new Calculator<int,double>(10, 200.6);
            //var res = c1.Sum();
            //Console.WriteLine("Sum " + res);
            var c2 = new Calculator<Human>();
            c2.Display();
        }
    }
}
 