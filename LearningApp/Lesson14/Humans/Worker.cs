using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson14.Humans
{
    sealed class Worker : Human
    {
        private int salary;

        public Worker(string name, int salary) : base(name)
        {
            this.salary = salary;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Worker class. Salary is {salary}.");
          
        }

        public int GetSalary() 
        {
            return salary;
        }

        public void SetSalary(int salary)
        {
            this.salary = salary;
        }
    }
}
