using LearningApp.Lesson13.LessonTask;
using LearningApp.Lesson13.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson13
{
    class Program13
    {
        public static object BuildConstructor { get; private set; }

        static void Main() {

            //string data = "helo world hi hello";
            //string[] dataSplit = StringUtils.SplitTextToWords(data);

            //foreach (var item in dataSplit)
            //{
            //    Console.WriteLine(item);
            //}

            StaticClass staticClass = new StaticClass();
            NonStaticClass nonStaticClass = new NonStaticClass();
            MixedClass mixedClass = new MixedClass();

            Console.WriteLine(nonStaticClass.GetData());
            Console.WriteLine(nonStaticClass.nonStaticMessage);

            Console.WriteLine(mixedClass.GetText());
            Console.WriteLine(mixedClass.GetNumber());
            Console.WriteLine(MixedClass.GetMessage());
            Console.WriteLine(MixedClass.mixedData);

            Console.WriteLine(StaticClass.staticData);
            Console.WriteLine(StaticClass.GetMessage());



            //PrivateConstructor.BuildConstructor();

            Animal animal = new Animal(12);
            Animal animal2 = new Animal(12, true, "animal2");
            Animal animal3 = new Animal("animal3", "lion");

            animal.Move();
            animal.Move(5);

            animal2.Print();
            animal2.Print(8);
        }

        
    }
}
