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
        //private Button endButton;
        //private TextBlock endtTextBlock;
        private TextLine endTextLine;

        public EndGameWindow() : base(28, 10, 60, 18, "THE END", '@')
        {

            //endtTextBlock = new TextBlock(28 + 1, 10 + 1, 60 - 1, creditData);
            endTextLine = new TextLine(28 + 1, 10 + 1, 60 - 1, "End of the Game! Good luck!");
        }

        public override void Render()
        {
            base.Render();
            endTextLine.Render();
            //endButton.Render();
        }
    }
}
