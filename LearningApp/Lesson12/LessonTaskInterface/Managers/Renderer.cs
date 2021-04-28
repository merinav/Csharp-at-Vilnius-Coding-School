using LearningApp.Lesson12.LessonTaskInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson12.LessonTaskInterface
{
    class Renderer
    {
        private IRenderable[] renderItems = new IRenderable[10];

        public void AddRenderItem(IRenderable[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = renderItems[i];
            }

        }

        public void RenderAll(IRenderable[] items)
        {
            foreach (var item in items)
            {
                item.Render();
            }
        }

    }
}
