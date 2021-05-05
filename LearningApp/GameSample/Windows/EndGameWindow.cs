using LearningApp.GameSample.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.GameSample.Windows
{
    sealed class EndGameWindow : Window
    {
        //private fields
        private TextLine endTextLine;

        //constructor
        public EndGameWindow() : base(28, 10, 60, 18, "THE END", '@')
        {
            endTextLine = new TextLine(28 + 1, 10 + 1, 60 - 1, "End of the Game! Good luck!");
        }
        
        //methods
        public override void Render()
        {
            base.Render();
            endTextLine.Render();
        }
    }
}
