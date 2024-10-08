﻿using MineSlave.Inventorys;
using MineSlave.Items;
using MineSlave.Monsters;
using MineSlave.Players;
using MineSlave.Scenes;
using System.ComponentModel.Design;
using static System.Runtime.InteropServices.JavaScript.JSType;



namespace MineSlave
{
    public class Game
    {
        private bool isRunning;

        private Scene[] scenes;
        private Scene curScene;
        public Scene scene { get { return curScene; } }

        public Player player;
        public Player Player { get { return player; } set { player = value; } }

        public Inventory inventory = new Inventory();
        public Item item = new Item();
        public Monster monster = new Monster();
        public Inventory[] itemSlot = new Inventory[10];
        public items items;
        public void Run()
        {
            Start();
            while (isRunning)
            {
                Render();
                Input();
                Update();
            }
            End();
        }

        public void ChangeScene(SceneType sceneType)
        {
            curScene.Exit();
            TownMap.data.playerPos = new TownMap.Point() { x = 7, y = 5 };
            curScene = scenes[(int)sceneType];
            curScene.Enter();
        }

        public void StartBattle(SceneType sceneType)
        {
            curScene.Exit2();
            TownMap.data.playerPos = new TownMap.Point() { x = 7, y = 5 };
            curScene = scenes[(int)sceneType];
            curScene.Enter();
        }

        public void Over()
        {
            isRunning = false;
        }

        private void Start()
        {
            isRunning = true;

            player = new();

            scenes = new Scene[(int)SceneType.Size];
            scenes[(int)SceneType.Title] = new TitleScene(this);
            scenes[(int)SceneType.Select] = new SelectScene(this);
            scenes[(int)SceneType.Town] = new TownScene(this);
            scenes[(int)SceneType.Camp] = new CampScene(this);
            scenes[(int)SceneType.Mine] = new MineScene(this);
            scenes[(int)SceneType.Battle] = new BattleScene(this);
            scenes[(int)SceneType.Gambling] = new GamblingScene(this);
            scenes[(int)SceneType.Inventory] = new InventoryScene(this);
            scenes[(int)SceneType.Shop] = new ShopScene(this);

            curScene = scenes[(int)SceneType.Title];
            curScene.Enter();

            TownMap.data.map = new bool[,]
            {            //숙소                       //상점                             //도박장                 13
                { false,  true, false, false, false,  true, false, false, false, false,  true, false, false, false},
                { false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true, false},
                { false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true, false},
                { false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true, false},
                { false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true}, //광산
                { false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true, false},
                { false, false, false, false, false, false, false, false, false, false, false, false, false, false},
              
            };

            TownMap.data.playerPos = new TownMap.Point() { x = 7, y = 5 };
            TownMap.data.minePos = new TownMap.Point() { x = 13, y = 4 };
            TownMap.data.shopPos = new TownMap.Point() { x = 5, y = 0 };
            TownMap.data.campPos = new TownMap.Point() { x = 1, y = 0 };
            TownMap.data.gamblingPos = new TownMap.Point() { x = 10, y = 0 };
        }

        private void End()
        {
            curScene.Exit();
        }

        private void Render()
        {
            curScene.Render();
        }

        private void Input()
        {
            curScene.Input();
        }

        private void Update()
        {
            curScene.Update();
        }
    }
}
