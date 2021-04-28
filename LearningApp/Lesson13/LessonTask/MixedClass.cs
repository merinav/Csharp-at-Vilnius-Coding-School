using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson13.LessonTask
{
    class MixedClass
    {
        public MixedClass()
        {
        }

        public static int mixedData;
        private static string mixedMessage = "this is mixed message";
        private int number = 100;
        private string text = "mixed text";

        private static int GetData()
        {
            return mixedData;
        }

        public static string GetMessage()
        {
            return mixedMessage;
        }

        public int GetNumber()
        {
            return number;
        }

        public string GetText()
        {
            return text;
        }

    }
}
