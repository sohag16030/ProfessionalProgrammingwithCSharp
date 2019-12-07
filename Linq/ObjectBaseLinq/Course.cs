using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectBaseLinq
{
    class Course
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public double Fee { get; set; }
        public List<Student> Students { get; set; }

    }
}
