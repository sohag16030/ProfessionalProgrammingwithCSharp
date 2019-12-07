using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //IList a1 = new ArrayList();
            //a1.Add(10);
            //a1.Add("Devskill");
            //foreach( var iteams in a1)
            //{
            //    Console.WriteLine(iteams);
            //}
            //var s1 = new SortedList();
            //s1.Add(16030, "shohag");
            //s1.Add(16013, "mushfiq");

            //foreach(var item in s1.Keys)
            //{
            //    Console.WriteLine("key =" + item);
            //    Console.WriteLine("value =" + s1[item]);
            //}
            //Human h1 = new Human();
            //h1.Name = "shohagShadaf";
            //h1.Age = 25;
            //Human h2 = new Human();
            //h2.Name = "ShohelSuvro";
            //h2.Age = 25;

            //var h1 = new Human()
            //{
            //    Name = "shohagshadaf",
            //  Age = 25,
            //};
            //var h2 = new Human()
            //{
            //    Name = "shohelsuvro",
            //    Age = 25,
            //};
            //var list = new List<Human>();
            //list.Add(h1);
            //list.Add(h2);
            var list = new List<Human>
            {
                new Human(){Name="shohagshadaf",Age=25,},
                 new Human(){Name="shohelsuvro",Age=25,},
            };
            foreach(var item in list)
            {
                item.Display();
            }
        }
    }
}
