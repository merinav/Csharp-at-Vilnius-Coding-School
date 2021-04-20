using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.GameSample.Game
{
    class Enemy
    {
        private int id;
        private int x;
        private int y;
        private string name;

        public Enemy(int id, int x, int y, string name)
        {
            this.id = id;
            this.x = x;
            this.y = y;
            this.name = name;
        }

        public void MoveDown() 
        {
            y++;
        }

        public void PrintInfo()
        {
            
            Console.WriteLine($"enemy id {id}, name {name}, located at {x} * {y}");
        }


    }
}
