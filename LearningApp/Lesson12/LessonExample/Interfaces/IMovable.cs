using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson12.Interfaces
{
    interface IMovable
    {        
        int X { get; set; }
        int Y { get; set; }
        void Move();
        //event EventHandler OnClick; //signalo siuntimas(?)
    }
}
