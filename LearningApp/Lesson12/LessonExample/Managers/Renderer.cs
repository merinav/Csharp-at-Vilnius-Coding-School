using LearningApp.Lesson12.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson12
{
    class Renderer
    {

        private List<IRenderable> renderItems = new List<IRenderable>();

        public void AddRenderItem(IRenderable renderable)
        {
            renderItems.Add(renderable);

        }

        public void RenderAll(List<IRenderable> renderItems)
        {
            foreach (var item in renderItems)
	            {
                    item.Render();
	            }
        }

    }
}
