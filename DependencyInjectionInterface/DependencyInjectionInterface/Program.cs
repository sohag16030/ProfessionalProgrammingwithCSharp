using System;

namespace DependencyInjectionInterface
{
    class Program
    {
        static void Main(string[] args)
        {

            CourseModel model = new CourseModel();
            model.Show(new OnetoOnecourse());
        }
    }
}