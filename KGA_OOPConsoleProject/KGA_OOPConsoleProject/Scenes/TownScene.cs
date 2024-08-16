using MineSlave.Players;

namespace MineSlave.Scenes
{
    public class TownScene : Scene
    {
        TownMap map;
        CampScene campScene;
        BattleScene battleScene;
        InventoryScene inventoryScene;
        MineScene mineScene;
        ShopScene shopScene;
        public TownScene(Game game) : base(game)
        {
        }

        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine("마을로 진입합니다...");
            Thread.Sleep(2000);

            
            Console.CursorVisible = false;
        }

        public override void Exit()
        {
            Console.CursorVisible = true;
        }

        public override void Input()
        {
            TownMap.data.inputKey = Console.ReadKey(true).Key;
        }

        public override void Render()
        {
            Console.Clear();
            TownMap.PrintMap();
            TownMap.PrintPlayer();
            TownMap.PrintMine();
            TownMap.PrintShop();
            TownMap.PrintCamp();
            TownMap.PrintGambling();

            Player.ShowInfo();
        }

        public override void Update()
        {
            TownMap.Move();

            if (TownMap.data.playerPos.x == TownMap.data.minePos.x &&
                TownMap.data.playerPos.y == TownMap.data.minePos.y)
            {
                game.ChangeScene(SceneType.Mine);
            }
            else if (TownMap.data.playerPos.x == TownMap.data.shopPos.x &&
               TownMap.data.playerPos.y == TownMap.data.shopPos.y)
            {
                game.ChangeScene(SceneType.Shop);
            }
            else if (TownMap.data.playerPos.x == TownMap.data.campPos.x &&
               TownMap.data.playerPos.y == TownMap.data.campPos.y)
            {
                game.ChangeScene(SceneType.Camp);
            }
            else if (TownMap.data.playerPos.x == TownMap.data.gamblingPos.x &&
               TownMap.data.playerPos.y == TownMap.data.gamblingPos.y)
            {
                game.ChangeScene(SceneType.Gambling);
            }
           
            if (TownMap.data.inputKey == ConsoleKey.Tab)
            {
                game.ChangeScene(SceneType.Inventory);
            }
        }
    }
}
