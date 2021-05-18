using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson21
{
    class Proxy : IStuffDoer
    {
        private readonly RealObject realObject;

        public Proxy(RealObject realObject) {
            this.realObject = realObject;
        }
        public void DoStuff() { }
    }
}
