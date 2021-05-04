using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson15
{
    class Program
    {
        static void Main15() 
        {

            //List<int> testList = new List<int> {1, 1, 1 };
            //MyClass myTestClass = new MyClass("klase", 543, testList);
            //MyStruct myTestStruct = new MyStruct("struktura");

            //myTestClass.Print();
            //myTestStruct.Print();

            //Console.ReadLine();

            //myTestClass.Name = "pakeistas klases vardas";
            //myTestStruct.Number = 999;

            //myTestClass.Print();
            //myTestStruct.Print();

            //Console.ReadLine();

            ////myTestClass.ChangeInt(myTestClass.Number);

            //ChangeData(myTestClass, myTestStruct);

            //Console.ReadLine();

            //myTestClass.Print();
            //myTestStruct.Print();


            //static void ChangeData(MyClass className, MyStruct structName) 
            //{
            //    className.Number = 666;
            //    className.Name = "className changeData";
            //    className.ListOfNumbers.Add(5);

            //    structName.Number = 777;
            //    structName.Name = "structName ChangedData";
            //    structName.ListOfNumbers.Add(65765);

            //    className.Print();
            //    structName.Print();
            //}


            //myTestClass.EnumFunction(EducationLevel.Aukstasis);

            ErrorThrow error = new ErrorThrow();
            error.DoBad();


            int[] masyvas = new int[3];

            try
            {
                int test = Convert.ToInt32(Console.ReadLine());
                masyvas[5] = test;
            }
            catch (FormatException exception1)
            {

                Console.WriteLine(exception1.Message);
            }
            catch (IndexOutOfRangeException exception2)
            {
                Console.WriteLine(exception2.Message);
                Console.WriteLine("blogai ivestas masyvas");
            }
            catch (Exception allExceptions)
            {
                Console.WriteLine("blogai");
            }
            finally 
            {
                Console.WriteLine("do this");
            }


            //galiu rasyt catch Exception exception- apims visus exceptionus
            //daznai - konkreti klaida x, konkreti x, tada toliau visas kitas




        }


    }
}
