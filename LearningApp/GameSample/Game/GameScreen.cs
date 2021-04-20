using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.GameSample.Game
{
    class GameScreen
    {
        private int height;
        private int width;
        private Hero hero;
        private List<Enemy> enemies = new List<Enemy>();

        public GameScreen(int height, int width)
        {
            this.height = height;
            this.width = width;
        }

        public void SetHero(Hero hero)
        {
            this.hero = hero;
        }

        public void MoveHeroRight()
        {
            hero.MoveRight();
        }

        public void MoveHeroLeft()
        {
            hero.MoveLeft();
        }

        public void AddEnemy(Enemy enemy)
        {
            enemies.Add(enemy);
        }

    }
}
