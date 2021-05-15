using LearningApp.Lesson18;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson20
{
    class Program20
    {

        static void Main20()
        {

            List<Student> students = new List<Student>
            {
                new Student(){Id = 0, Name = "Kestas", Age = 30, AverageMark = 9, IsGettingTuition = true},
                new Student(){Id = 1, Name = "Petr", Age = 25, AverageMark = 4.2, IsGettingTuition = false},
                new Student(){Id = 2, Name = "Ona", Age = 21, AverageMark = 4.2, IsGettingTuition = true},
                new Student(){Id = 3, Name = "Gabija", Age = 19, AverageMark = 6.8, IsGettingTuition = false},
                new Student(){Id = 4, Name = "Jonas", Age = 17, AverageMark = 4.2, IsGettingTuition = true},
                new Student(){Id = 5, Name = "Biata", Age = 15, AverageMark = 5.5, IsGettingTuition = false}
            };


            /*
            //-------------
            var names = from s in students
                           select s.Name;

            List<string> nameList = new List<string>();
            nameList = names.ToList();

            //----------------

            var filter1 = from s in students
                          where s.Age > 20 && s.Age < 35
                          select s;
            //--------------

            var filter2 = from s in students
                          where s.AverageMark > 5 && s.IsGettingTuition == false
                          orderby s.Age ascending
                          select s;

            foreach (var item in filter2)
            {
                Console.WriteLine(item.Age);
                Console.WriteLine(item.Name);
                Console.WriteLine();
            }

            */

            //-----------------------
            var studentsOver20 = from s in students
                                 where s.Age > 20
                                 orderby s.Name
                                 select new { Id = s.Id, Name = s.Name };

            //-----------------------

            var goodStudents = from s in students
                               where s.IsGettingTuition == true
                               select new { Name = s.Name, GoodStudent = s.AverageMark > 8 };



            foreach (var item in goodStudents)
            {
                Console.WriteLine($"Name: {item.Name}");
                Console.WriteLine($"Goodstudent: {item.GoodStudent}");
                Console.WriteLine();
            }

            //------------------------

            //---------UZBAIGTI PAGAL PVZ VIDEO

            /*
            var longNameList = from s in students
                               where s.Name.Length > 5
                               select new
                               {
                                   Id = s.Id,
                                   Name = s.Name,
                                   Status = GetStatusFromMark(s.AverageMark)
                               }
                                   into sStatusObject
                                   group sStatusObject by sStatusObject.Status;




            foreach (var item in longNameList)
            {
                Console.WriteLine($"id: {item.Id}");
                Console.WriteLine($"name: {item.Name}");
                Console.WriteLine($"status: {item.Bad}");

                //foreach (var student in item)
                //{
                //    Console.WriteLine(student.Name);
                //}
            }



        }

        private static sStatus GetStatusFromMark(double averageMark)
        {
            if (averageMark > 5)
            {
                return s.Status.
            }
        }
            */

        }
    }
}
