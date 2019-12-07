using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionInterface
{
    public class OnetoOnecourse : ICourseModel
    {
        public void Display()
        {
            Console.WriteLine("This is OneToOnecourse");
        }
    }
}
