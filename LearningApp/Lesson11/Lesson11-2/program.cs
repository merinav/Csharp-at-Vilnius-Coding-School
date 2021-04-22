using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson11.Lesson11_2
{
    class program
    {
        static void Main() 
        {
            //Class1 klase1 = new Class1();
            //klase1.PrintInfo();
            //Class2 klase2 = new Class2();
            //klase2.PrintInfo();
            //Class3 klase3 = new Class3();
            //klase3.PrintInfo();

            //Student studentas = new Student("meri");
            //Console.WriteLine(studentas.Name);
            //studentas.Name = "nemeri";
            //Console.WriteLine(studentas.Name);

            //Console.WriteLine(studentas.Age);

            Student student = new Student("declaredName", "declaredColor", "declaredCity",
                "declaredValue");
            //Console.WriteLine(student.name);
            //Console.WriteLine(student.color);
            //Console.WriteLine(student.city);
            //Console.WriteLine(student.value);

            //student.name = "Pranas";
            //student.color = "white";
            //student.city = "Kaunas";
            //student.value = "100000";

            //Console.WriteLine(student.name);
            //Console.WriteLine(student.color);
            //Console.WriteLine(student.city);
            //Console.WriteLine(student.value);

            student.Name = "changedName";
            Console.WriteLine(student.Name);


            student.City = "changedCity";
            //Console.WriteLine(student.City);

            //student.Color = "changedColor";
            Console.WriteLine(student.Color);

            //student.Value = "changedValue";
            Console.WriteLine(student.Value);

            //implement Window
            //implement properties

        }


    }
}
