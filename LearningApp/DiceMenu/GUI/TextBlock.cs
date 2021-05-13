using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.DiceMenu.GUI
{
    class TextBlock : GuiObject
    {

        //private fields
        private List<TextLine> textBlocks = new List<TextLine>();

        //constructor
        public TextBlock(int x, int y, int width, List<string> textList) : base(x, y, width, 0)
        {
            for (int i = 0; i < textList.Count; i++)
            {
                textBlocks.Add(new TextLine(x, y + i, width, textList[i]));
            }
        }

        //methods
        public override void Render()
        {
            for (int i = 0; i < textBlocks.Count; i++)
            {
                textBlocks[i].Render();
            }
        }
    }
}
