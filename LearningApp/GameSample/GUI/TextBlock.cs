using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.GameSample.GUI
{
    class TextBlock : GuiObject
    {
        private List<TextLine> textBlocks = new List<TextLine>();

       
        public TextBlock(int x, int y, int width, List<string> list)
            : base(x, y, width, 1)
        {
            //textBlocks = TextLine(x, y, width, string data);
        }
        public void Render()
        {
            
        }

    }
}
