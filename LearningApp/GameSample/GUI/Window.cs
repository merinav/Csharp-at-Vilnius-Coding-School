using System;
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

        public Window (int x, int y, int width, int height, string title, char frameChar)
            : base (x, y, width, height)
        {
            border = new Frame(x, y, width, height, frameChar);
            titleText = new TextLine(x, y, width, title);
        }
        public void Render()
        {
            border.Render();
        }
    }
}
