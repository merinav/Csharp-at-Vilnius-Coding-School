using LearningApp.Lesson14.Humans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson14
{
    class Company
    {
        private Human boss;
        private readonly string name;
        private List<Client> clientList = new List<Client>();
        private List<Worker> workerList = new List<Worker>();

        public Company(Human boss, string name) 
        {
            this.boss = boss;
            this.name = name;
        }

        public Pet OfficePet { get; set; }

        public void HireWorker(Worker worker)
        {
            workerList.Add(worker);
        }

        public void FireWorker(Worker worker) 
        {
            workerList.Remove(worker);
        }

        public void AddClient(Client client)
        {
            clientList.Add(client);
        }

        public void PrintAllClients() 
        {
            foreach (var client in clientList)
            {
                Console.WriteLine($"Client ID is {client.ClientID}");
                Console.WriteLine($"Client Count is {Client.clientCount}");                
            }
        }

        public void PrintAllWorkers()
        {
            foreach (var worker in workerList)
            {
                Console.WriteLine($"Worker salary is {worker.GetSalary()}");
                Console.WriteLine($"Worker life Span is {worker.GetLifeSpan()}");
            }
        }


        public void PrintInfo()
        {
            Console.WriteLine($"this is Company class");
        }

    }
}
