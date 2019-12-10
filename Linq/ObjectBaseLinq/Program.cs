using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ObjectBaseLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = new Student(){ Name = "shohag",Roll = 101,};
            var s2 = new Student(){ Name = "Mushfiq",Roll = 102,};
            var s3 = new Student(){ Name = "Tusar", Roll = 103,};
            var StudentList = new List<Student>() { s1, s2, s3 };

            var c1 = new Course() { Name = "C#", Code = "DST1", Fee = 600, };
            var c2 = new Course() { Name = "ASP.NET", Code = "DST2", Fee = 30000, };
            var c3 = new Course() { Name = "Python", Code = "DST3", Fee = 15000, };
            var CourseList = new List<Course>() { c1, c2, c3 };

            c1.Students = new List<Student>() {s1};
            c2.Students = new List<Student>() {s1,s3 };

            //s1.Courses = new List<Course>() { c1, c2 };
            //s3.Courses = new List<Course>() { c3 };

            //s2.Courses = new List<Course>() { c2 };

            //var result = StudentList.Count();
            //var result = CourseList.Sum(x => x.Fee);
            //var result = CourseList.Where(x => x.Fee > 6000);
            //Console.WriteLine(result.Count());
            //var result = CourseList;
            //foreach (var item in result)
            //{
            //    Console.WriteLine("Course Name " + item.Name);
            //    if (item.Students != null)
            //        foreach (var stu in item.Students)
            //        {
            //            Console.Write($"Student Name : {stu.Name} ");
            //            Console.WriteLine($"Student Roll: {stu.Roll}");
            //        }
            //    else
            //        Console.WriteLine("No student enroll in this course");
            //}
            //var result = CourseList.Where(x=>x.Students?.Count>=2);
            //foreach (var item in result)
            //{
            //    Console.WriteLine("Course Name " + item.Name);

            //        foreach (var stu in item.Students)
            //        {
            //            Console.Write($"Student Name : {stu.Name} ");
            //            Console.WriteLine($"Student Roll: {stu.Roll}");
            //        }

            //}
            //var result = CourseList.Where(x => x.Students != null);
            //foreach (var item in result)
            //{
            //    foreach (var stu in item.Students)
            //    {
            //        if (stu.Roll == 101)
            //            Console.WriteLine(item.Name);
            //    }

            //}

            //var result = CourseList.Where(x =>x.Name=="ASP.NET");

            //foreach (var item in result)
            //{
            //    foreach (var stu in item.Students)
            //    {
            //        Console.WriteLine(stu.Name);
            //    }
            //}
            var CSharp = CourseList.Where(x => x.Name == "C#").ToList();
            var ASP = CourseList.Where(x => x.Name == "ASP.NET").ToList();
            var fullList = new List<Course>();
            fullList.AddRange(CSharp);
            fullList.AddRange(ASP);
            var StuList = new HashSet<string>();
            foreach (var item in fullList)
            {
                foreach (var stu in item.Students)
                {
                    StuList.Add(stu.Name);
                }
            }
            foreach (var item in StuList)
                Console.WriteLine(item);
            



        }
    }
}
