using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionInterface
{
    public class OnlineCourse : ICourseModel
    {
        public void Display()
        {
            Console.WriteLine("this is online course");
        }
    }
}
