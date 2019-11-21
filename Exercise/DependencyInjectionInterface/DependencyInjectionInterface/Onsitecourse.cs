using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionInterface
{
    public class Onsitecourse : ICourseModel
    {
        public void Display()
        {
            Console.WriteLine("this is onsitecourse");
        }
    }
}
