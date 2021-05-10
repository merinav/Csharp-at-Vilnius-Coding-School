using LearningApp.Lesson18.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson18
{
    class Program18
    {


        static void Main() {

            /*
            List<int> data = new List<int>() { 0, 1, 2, 3, 56, 67};

            data.RemoveAll(testNr => testNr % 2 == 1);

            List<int> answer = data.FindAll(testData => testData > 5);

            Func<string> myFunction = data.ToString;
            //Func padengia funkcijas kuri grazina duomenis
            // Action - atlieka veiksma bet negrazina nieko

            Action<int, int> myFunct = TestOperation;

            //Func ir Action tinka viskam. Predicate galima irgi naudot jei reikia duot konteksta
            */

            List<Student> students = new List<Student>
            {
                new Student(){Id = 0, Name = "Kestas", Age = 30, AverageMark = 4.2, IsGettingTuition = true},
                new Student(){Id = 1, Name = "Ona", Age = 25, AverageMark = 4.2, IsGettingTuition = false},
                new Student(){Id = 2, Name = "Petras", Age = 21, AverageMark = 4.2, IsGettingTuition = true},
                new Student(){Id = 3, Name = "Gabija", Age = 19, AverageMark = 4.2, IsGettingTuition = false},
                new Student(){Id = 4, Name = "Jonas", Age = 17, AverageMark = 4.2, IsGettingTuition = true},
                new Student(){Id = 5, Name = "Biata", Age = 15, AverageMark = 4.2, IsGettingTuition = false}
            };



            List<Student> dringkingAge = students.FindAll(s => s.Age > 20);
            List<Student> tuitionAndMark = students.FindAll(s =>  s.IsGettingTuition == true && s.AverageMark > 8);
            List<Student> markAndName = students.FindAll(s => s.AverageMark < 4 && s.Name.Length <= 8);

            foreach (var item in markAndName)
            {
                Console.WriteLine($"{item.Name}, {item.Age}, {item.IsGettingTuition}");
            }

            string text = "erwtwkjkjuiuyet";

            var words = text.CutToWords();

            int a = 15;

            Console.WriteLine(a.PowerTwo());


        }

        private static void TestOperation(int arg1, int arg2)
        {
            Console.WriteLine(arg1 + arg2);
        }
    }
}
