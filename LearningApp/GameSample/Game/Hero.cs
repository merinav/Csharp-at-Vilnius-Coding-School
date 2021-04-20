using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.GameSample.Game
{
    class Hero
    {
        private int x;
        private int y;
        private string name;


        public Hero(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }

        public  void MoveRight()
        {
            x++;
        }

        public  void MoveLeft()
        {
            x--;

        }   

        public  void PrintInfo()
        {
            Console.WriteLine($"hero name {name}, located at {x} * {y}");
        }

    }
}
