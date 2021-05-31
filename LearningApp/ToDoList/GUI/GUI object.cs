using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.ToDoList.GUI
{
    abstract class GuiObject
    {
        
        public GuiObject(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            Width = width;
            Heigth = height;
        }

        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Heigth { get; set; }


        abstract public void Render();
    }
}
