﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.GameSample.GUI
{
    class Button : GuiObject

    {
        private Frame activeFrame;
        private Frame notActiveFrame;
        private TextLine textLine;
        private bool isActive = false;

        private const char activeChar = '#';
        private const char notActiveChar = '+';

        public Button(int x, int y, int width, int height, string label) : base(x, y, width, height)
        {
            activeFrame = new Frame(x, y, width, height, activeChar);
            notActiveFrame = new Frame(x, y, width, height, notActiveChar);
            textLine = new TextLine(x + 1, y + height / 2, width - 2, label);
        }

        public bool IsActive { get; set; }

        public void SetActive()
        {
            isActive = true;
        }

        public override void Render()
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
    }

}