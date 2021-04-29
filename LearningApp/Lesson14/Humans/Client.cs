using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson14
{
    sealed class Client : Human
    {
        public static int clientCount = 0;

        
        public Client(string name) : base (name)
        {
            clientCount++;
        }

        public int ClientID { get; private set; } = 1;

        public override void PrintInfo() 
        {
            Console.WriteLine($"Client class. ClientCount is {clientCount}, ClientID is {ClientID}");
        }
    }
}
