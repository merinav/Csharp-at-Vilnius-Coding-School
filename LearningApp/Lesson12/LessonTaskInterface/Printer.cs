using LearningApp.Lesson12.LessonTaskInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson12.LessonTaskInterface
{
    class Printer
    {
        private List<IPrintable> printableItems = new List<IPrintable>();

        

        public void AddPrintableItem(IPrintable printable)
        {
            printableItems.Add(printable);

        }

        public void PrintAll()
        {
            foreach (var item in printableItems)
            {
                item.Print();
            }
        }
    }
}
