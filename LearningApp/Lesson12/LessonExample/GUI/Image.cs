using LearningApp.Lesson12.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson12.GUI
{
    class Image : GuiElement, IRenderable

    {
        public void Render()
        {
            Console.WriteLine("OOOOOOOOOOOOO"); ;
        }
    }
}
