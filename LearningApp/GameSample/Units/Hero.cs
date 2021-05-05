using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.GameSample.Units
{
    class Hero : Unit
    {
        
        //constructor
        public Hero(int x, int y, string name) : base(x, y, name)
        {
           
        }

        //methods
        public  void MoveRight()
        {
            X++;
        }
        public  void MoveLeft()
        {
            X--;

        }   
        
    }
}
