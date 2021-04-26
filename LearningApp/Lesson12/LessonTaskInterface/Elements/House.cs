using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningApp.Lesson12.LessonTaskInterface.Interfaces;

namespace LearningApp.Lesson12.LessonTaskInterface.Elements
{
    class House : IPrintable, IRenderable
    {
        private string houseColor;
        private int houseFloorNo;

        public string HouseColor { get; set; }
        public int HouseFloorNo { get; set; }

        public House(string color, int no)
        {
            houseColor = color;
            houseFloorNo = no;
        }

        public void Print()
        {
            Console.WriteLine($"House color: {houseColor}, house has {houseFloorNo} floors.");
        }

        public void Render()
        {
            throw new NotImplementedException();
        }
    }
}
