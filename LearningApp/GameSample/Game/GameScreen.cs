﻿using LearningApp.GameSample.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.GameSample.Game
{
    class GameScreen

    {
        private int width;
        private int height;

        private Hero hero;
        private List<Enemy> enemies = new List<Enemy>();

        public GameScreen(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public void SetHero(Hero hero)
        {
            this.hero = hero;
        }

        public void AddEnemy(Enemy enemy)
        {
            enemies.Add(enemy);
        }

        public void Render()
        {
            hero.PrintInfo();
            foreach (var enemy in enemies)
            {
                enemy.PrintInfo();
            }
        }

        public void MoveHeroLeft()
        {
            hero.MoveLeft();
        }

        public void MoveHeroRight()
        {
            hero.MoveRight();
        }

        public Enemy GetEnemyById(int id)
        {
            foreach (var enemy in enemies)
            {
                if (enemy.GetId() == id)
                {
                    return enemy;
                }
            }
            return null;
        }

        public void MoveAllEnemiesDown()
        {
            foreach (var enemy in enemies)
            {
                enemy.MoveDown();
            }
        }
    }
}
