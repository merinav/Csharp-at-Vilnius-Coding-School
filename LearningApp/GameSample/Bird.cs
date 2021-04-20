using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.GameSample
{
    class Bird : Animal
    {
        private string featherColor;

        public Bird(int lifespan, string featherColor) : base(lifespan)
        {
            this.featherColor = featherColor;
        }

        public void Fly() 
        {
        
        }
    }
}
