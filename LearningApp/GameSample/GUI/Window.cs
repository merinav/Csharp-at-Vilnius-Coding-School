﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.GameSample.GUI
{
    class Window : GuiObject
    {
        private Frame border;
        private TextLine titleText;

        public Window(int x, int y, int width, int height, string title, char borderChar) : base(x, y, width, height)
        {
            border = new Frame(x, y, width, height, borderChar);
            titleText = new TextLine(x + 3, y, title.Length + 2, $" {title} ");
        }

        public virtual void Render()
        {
            border.Render();
            titleText.Render();
        }
    }
}
