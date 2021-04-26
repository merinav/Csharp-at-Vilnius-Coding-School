using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson12.LessonTaskInterface.Interfaces
{
    interface ISpeaks
    {
        string Text { get; set; }

        void Speaks();

    }
}
