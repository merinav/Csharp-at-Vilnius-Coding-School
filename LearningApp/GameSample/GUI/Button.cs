using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.GameSample.GUI
{
    class Button : GuiObject
    {
        private Frame activeFrame;
        private bool isActive = false;
        private Frame notActiveFrame;
        private TextLine textLine;

        public bool IsActive { get; set; }
       

        public Button(int x, int y, int width, int height, string name) 
            : base (x, y, width, height)
        {
            textLine = new TextLine(x+1, y+1, width -2, name);
            activeFrame = new Frame(x, y, width, height, '*');
            notActiveFrame = new Frame(x, y, width, height, '/');
        }

        public void Render() 
        {
            if (isActive)
            {
                activeFrame.Render();
            }
            else
            {
                notActiveFrame.Render();
            }
            textLine.Render();
        }

        public void SetActive(bool isActive)
        {
            this.isActive = isActive;
            Render();           
        }
    }
}