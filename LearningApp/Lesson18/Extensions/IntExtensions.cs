using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson18.Extensions
{
    static class IntExtensions
    {
        public static int PowerTwo(this int data)
        {
            return data * data;
        }
    }
}
