using LearningApp.Lesson14.Humans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson14
{
    class Program
    {
        static void Main() 
        {

            Human boss = new Human("Vytautas");
            Company company = new Company(boss, "MyCompany");

            company.OfficePet = new Dog("Doggo");

            company.OfficePet.PrintInfo();

            company.HireWorker(new Worker("Valytojas Jonas", 460));
            company.HireWorker(new Worker("Programuotojas Zilvinas", 2500));

            //company.HireWorker();

            company.AddClient(new Client("Kestas"));
            company.AddClient(new Client("Ona"));
            company.AddClient(new Client("eiuyweit"));

            company.PrintInfo();

            company.PrintAllClients();
            company.PrintAllWorkers();

            Console.ReadKey();


        }

    }
}
