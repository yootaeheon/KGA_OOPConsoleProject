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

            TownMap.data.map = new bool[,]
            {            //숙소        //상점        //도박장
                { false,  true, false,  true, false,  true, false},
                { false,  true,  true,  true,  true,  true, false},
                { false,  true,  true,  true,  true,  true, false},
                { false,  true,  true,  true,  true,  true, false},
                { false,  true,  true,  true,  true,  true,  true}, //광산
                { false,  true,  true,  true,  true,  true, false},
                { false, false, false, false, false, false, false},
              
            };

            TownMap.data.playerPos = new TownMap.Point() { x = 6, y = 3 };
            TownMap.data.minePos = new TownMap.Point() { x = 4, y = 7 };
            TownMap.data.shopPos = new TownMap.Point() { x = 0, y = 4 };
            TownMap.data.campPos = new TownMap.Point() { x = 0, y = 1 };
            TownMap.data.gamblingPos = new TownMap.Point() { x = 0, y = 6 };
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
