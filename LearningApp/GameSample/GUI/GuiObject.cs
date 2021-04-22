using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.GameSample.GUI
{
    abstract class GuiObject
    {
        protected int X;
        protected int Y;
        protected int Width;
        protected int Height;

        public GuiObject(int x, int y, int width, int height) 
        {
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
        }

        abstract public void Render() //?????
        {
            
        }
    }   
}
