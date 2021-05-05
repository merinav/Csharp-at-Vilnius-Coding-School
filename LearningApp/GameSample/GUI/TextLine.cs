using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.GameSample.GUI
{
    class TextLine : GuiObject
    {
        //private fields
        private string data;

        //constructor
        public TextLine(int x, int y, int width, string data)
            : base(x, y, width, 1)
        {
            this.data = data;
        }

        //methods
        public override void Render()
        {
            if (data.Length >= Width)
            {
                data = data.Substring(0, Width);
                Console.SetCursorPosition(X, Y);
            }
            else
            {
                Console.SetCursorPosition(X + (Width - data.Length) / 2, Y);
            }
            Console.Write(data);
        }

    }

}
