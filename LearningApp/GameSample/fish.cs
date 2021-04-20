using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.GameSample
{
    class Fish :Animal
    {

        int data;
        public Fish(int lifeSpan, int data) : base (lifeSpan)
        {
            this.data = data;
        }
        public void Swim() 
        {
            
        }

    }
}
