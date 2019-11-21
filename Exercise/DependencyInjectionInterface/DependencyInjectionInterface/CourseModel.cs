using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionInterface
{
    public class CourseModel 
    {
        public void Show(ICourseModel course)
        {
            course.Display();
        }
    }
}
