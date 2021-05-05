using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.GameSample.GUI
{
    class Frame : GuiObject

    {
        //private fields
        private char renderChar;

        //constructor
        public Frame(int x, int y, int width, int height, char renderChar)
            : base(x, y, width, height)
        {
            this.renderChar = renderChar;
        }

        //properties
        public char RenderChar { get; set; }

        //methods
        public override void Render()
        {
            for (int i = 0; i < Heigth; i++)
            {
                Console.SetCursorPosition(X, Y + i);
                if (i == 0 || i == Heigth - 1)
                {
                    for (int j = 0; j < Width; j++)
                    {
                        Console.Write(renderChar);
                    }
                }
                else
                {
                    Console.Write(renderChar);
                    for (int j = 0; j < Width - 2; j++)
                    {
                        Console.Write(' ');
                    }
                    Console.Write(renderChar);
                }

            }
        }
    }


}
