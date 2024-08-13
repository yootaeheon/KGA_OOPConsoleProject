using MineSlave.Inventorys;
using MineSlave.Items;
using MineSlave.Monsters;
using MineSlave.Players;
using MineSlave.Scenes;

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

            scenes = new Scene[(int)SceneType.Size];
            scenes[(int)SceneType.Title] = new TitleScene(this);
            scenes[(int)SceneType.Select] = new SelectScene(this);
            scenes[(int)SceneType.Town] = new TownScene(this);

            curScene = scenes[(int)SceneType.Title];
            curScene.Enter();

            // [Feat] 추가된 기능들
            Inventory inventory = new Inventory();
            Item[] items = new Item[5];
            MonsterBuilder mineWorkerBuilder = new MonsterBuilder();
            MonsterBuilder beastBuilder = new MonsterBuilder();
            MonsterBuilder monsterBuilder = new MonsterBuilder();

            data.map = new bool[,]
            {            //숙소        //상점        //도박장
                { false,  true, false,  true, false,  true, false},
                { false,  true,  true,  true,  true,  true, false},
                { false,  true,  true,  true,  true,  true, false},
                { false,  true,  true,  true,  true,  true, false},
                { false,  true,  true,  true,  true,  true,  true}, //광산
                { false,  true,  true,  true,  true,  true, false},
                { false,  true,  true,  true,  true,  true, false},
                { false, false, false, false, false, false, false},
            };
            data.playerPos = new Point() { x = 6, y = 1 };
            data.minePos = new Point() { x = 4, y = 7 };
            data.shopPos = new Point() { x = 0, y = 4 };
            data.campPos = new Point() { x = 0, y = 1 };
            data.gamblingPos = new Point() { x = 0, y = 6 };
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


        // Town에서 맵 이동
        public class GameData
        {
            public bool[,] map;
            public ConsoleKey inputKey;
            public Point playerPos;
            public Point minePos;
            public Point shopPos;
            public Point campPos;
            public Point gamblingPos;
        }
        public static GameData data;

        static void PrintMap()
        {
            for (int y = 0; y < data.map.GetLength(0); y++)
            {
                for (int x = 0; x < data.map.GetLength(1); x++)
                {
                    if (data.map[y, x])
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("■");
                    }
                }
                Console.WriteLine();
            }
        }

        static void PrintPlayer()
        {
            Console.SetCursorPosition(data.playerPos.x, data.playerPos.y);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("P");
            Console.ResetColor();
        }

        static void PrintMine()
        {
            Console.SetCursorPosition(data.minePos.x, data.minePos.y);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("광산");
            Console.ResetColor();
        }

        static void PrintShop()
        {
            Console.SetCursorPosition(data.shopPos.x, data.shopPos.y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("상점");
            Console.ResetColor();
        }
        static void PrintDormitory()
        {
            Console.SetCursorPosition(data.campPos.x, data.campPos.y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("수용소");
            Console.ResetColor();
        }

        public class Point
        {
            public int x;
            public int y;
        }


        static void Move()
        {
            switch (data.inputKey)
            {
                case ConsoleKey.W:
                case ConsoleKey.UpArrow:
                    MoveUp();
                    break;
                case ConsoleKey.S:
                case ConsoleKey.DownArrow:
                    MoveDown();
                    break;
                case ConsoleKey.A:
                case ConsoleKey.LeftArrow:
                    MoveLeft();
                    break;
                case ConsoleKey.D:
                case ConsoleKey.RightArrow:
                    MoveRight();
                    break;
            }
        }

        static void MoveUp()
        {
            Point next = new Point() { x = data.playerPos.x, y = data.playerPos.y - 1 };
            if (data.map[next.y, next.x])
            {
                data.playerPos = next;
            }
        }

        static void MoveDown()
        {
            Point next = new Point() { x = data.playerPos.x, y = data.playerPos.y + 1 };
            if (data.map[next.y, next.x])
            {
                data.playerPos = next;
            }
        }

        static void MoveLeft()
        {
            Point next = new Point() { x = data.playerPos.x - 1, y = data.playerPos.y };
            if (data.map[next.y, next.x])
            {
                data.playerPos = next;
            }
        }

        static void MoveRight()
        {
            Point next = new Point() { x = data.playerPos.x + 1, y = data.playerPos.y };
            if (data.map[next.y, next.x])
            {
                data.playerPos = next;
            }
        }


    }
}
