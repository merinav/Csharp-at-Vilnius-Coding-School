using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson21
{
    class Program21
    {
        static void Main21() 
        {

            Singleton singleton1 = Singleton.Instance();
            Singleton singleton2 = Singleton.Instance();

            if (singleton1 == singleton2 && singleton1 != null)
            {
                Console.WriteLine("good");
            }
            else
            {
                Console.WriteLine("bad");
            }


            Proxy myProxy = new Proxy(new RealObject());
            myProxy.DoStuff();
            Console.ReadKey();

        }

       




    }
}
