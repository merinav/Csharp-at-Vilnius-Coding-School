﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson12.LessonTaskInterface.Interfaces
{
    interface IGlows
    {
        bool Glows { get; set; }
        void Glow();
    }
}
