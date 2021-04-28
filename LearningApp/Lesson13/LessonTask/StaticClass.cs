using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson13.LessonTask
{
    class StaticClass
    {
        public StaticClass()
        {
        }

        public static int staticData;
        private static string staticMessage = "this is static dataFirst";

        private static int GetData()
            {
            return staticData;
            }

        public static string GetMessage() 
        {
            return staticMessage;
        }

        

    }
}
