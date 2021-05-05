using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.GameSample.Units
{
    class Enemy : Unit
    {
        //private fields
        private int id;

        //constructor
        public Enemy(int id, int x, int y, string name) : base(x, y, name)
        {
            this.id = id;
        }

        //methods
        public void MoveDown() 
        {
            Y++;
        }

        public int GetId()
        {
            return id;
        }
    }
}
