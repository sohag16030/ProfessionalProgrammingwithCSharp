using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }

       public void Display()
        {
            Console.WriteLine("Name :"+Name);
            Console.WriteLine("Age :" +Age);

        }
    }
}
