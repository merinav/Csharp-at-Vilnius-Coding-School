using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson13.LessonTask
{
    class NonStaticClass
    {
        private int nonStaticData = 0;
        public string nonStaticMessage = "nonStaticData";

        public int GetData()
        {
            return nonStaticData;
        }

        private  string GetMessage()
        {
            return nonStaticMessage;
        }

        public NonStaticClass()
        {
        }

    }

}
