﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSlave.Scenes
{
    public enum SceneType { Title, GameOver, Select, Town, Mine, Battle, Camp, Inventory, Shop, Gambling , Size }
    public abstract class Scene
    {
        protected Game game;

        public Scene(Game game)
        {
            this.game = game;
        }

        public abstract void Enter();

        public abstract void Render();

        public abstract void Input();

        public abstract void Update();

        public abstract void Exit();

        public abstract void Exit2();
    }
}
