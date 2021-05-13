using LearningApp.Lesson18;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson19
{
    class Program19
    {
        static void Main19()
        {

            List<Student> students = new List<Student>
            {
                new Student(){Id = 0, Name = "Kestas", Age = 30, AverageMark = 3, IsGettingTuition = true},
                new Student(){Id = 1, Name = "Ona", Age = 25, AverageMark = 4.2, IsGettingTuition = false},
                new Student(){Id = 2, Name = "Petras", Age = 21, AverageMark = 4.2, IsGettingTuition = true},
                new Student(){Id = 3, Name = "Gabija", Age = 19, AverageMark = 6.8, IsGettingTuition = false},
                new Student(){Id = 4, Name = "Jonas", Age = 17, AverageMark = 4.2, IsGettingTuition = true},
                new Student(){Id = 5, Name = "Biata", Age = 15, AverageMark = 5, IsGettingTuition = false}
            };

            var resultQ = from s in students
                         orderby s.AverageMark ascending
                         select s;

            var resultF = students.OrderByDescending(s => s.AverageMark);


            var resultQ2 = from s in students
                           orderby s.Age descending
                           select s;

            var resultF2 = students.OrderByDescending(s => s.Age);


            var resultQ3 = from s in students
                           orderby s.AverageMark descending, s.Age  
                           select s;

            var resultF3 = students.OrderByDescending(s => s.Age).ThenBy(s => s.AverageMark);

            //var resultS = from s in students
            //              orderby s
            //              select students;

            //foreach (var item in resultQ3)
            //{
            //    Console.WriteLine($"{item.Age} and {item.AverageMark}");
            //}

            var groupByAge = from s in students
                             group s by s.Age into ageGroup
                             orderby ageGroup.Key
                             select ageGroup;


            
            foreach (var item in groupByAge)
            {
                Console.WriteLine($"key: {item.Key}");
                foreach (var student in item)
                {
                    Console.WriteLine(student.Name);
                }
            }

            Console.WriteLine();

            var groupbyTuition = from s in students
                                 group s by s.IsGettingTuition into tuitionGroup
                                 orderby tuitionGroup.Key
                                 select tuitionGroup;

            foreach (var item in groupbyTuition)
            {
                Console.WriteLine($"key: {item.Key}");
                foreach (var student in item)
                {
                    Console.WriteLine(student.Name);
                }
            }
            Console.WriteLine();



            var groups = from s in students
                         group s by s.Age / 10;

            foreach (IGrouping<int, Student> group in groups)
            {
                Console.WriteLine(" desimtmetis : "  + group.Key);

            }




        }

    }
}
