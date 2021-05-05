using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.GameSample.Units
{
    class Unit
    {
        //private fields
        protected int X;
        protected int Y;
        protected string Name;

        //constructor
        public Unit(int x, int y, string name) 
        {
            X = x;
            Y = y;
            Name = name;
        }

        //methods
        public void PrintInfo()
        {
            Console.WriteLine($"Unit {Name}, is at X = {X} * Y = {Y}");
            
        }
    }
}
