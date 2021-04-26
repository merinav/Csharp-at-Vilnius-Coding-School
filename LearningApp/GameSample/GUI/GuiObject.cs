using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.GameSample.GUI
{
     abstract class GuiObject
    {
        private int x;
        private int y;
        private int width;
        private int height;

        protected int X { get; set; }

        protected int Y { get; set; }
        
        protected int Width { get; set; }
       
        protected int Height { get; set; }
        

        public GuiObject(int x, int y, int width, int height) 
        {
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
        }

        //abstract public void Render();
        
    }   
}
