﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson13.Tools
{
    static class StringUtils
    {

        static public string[] SplitTextToWords(string text) 
        {
            var retVal = text.Split(' ');
            return retVal;
        }

    }
}
