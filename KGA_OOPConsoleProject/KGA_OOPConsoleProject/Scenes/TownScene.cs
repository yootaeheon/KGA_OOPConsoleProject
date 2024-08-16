using MineSlave.Players;
using System.Numerics;

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
        public Player player;
       
        public TownScene(Game game) : base(game)
        {
        }

        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine("마을로 진입합니다...");
            Thread.Sleep(2000);

            Console.CursorVisible = false;










         //  player.Day += 1;
         //
         //  player.Exhaustion -= 1;
         //  if (player.Exhaustion == 0)
         //  {
         //      Console.WriteLine("탈진하여 사망하였습니다..");
         //      Console.WriteLine("Game Over");
         //  }
         //
         //  player.DeadLine -= 1;
         //  if (player.DeadLine == 0)
         //  {
         //      if (player.Gold >= 500)
         //      {
         //          player.Gold -= 500;
         //          Console.WriteLine("세금 납부일 입니다.");
         //          Console.WriteLine("-500 G");
         //          player.DeadLine = 5;
         //      }
         //      else
         //      {
         //          Console.WriteLine("세금 납부일 입니다..");
         //          Console.WriteLine("세금을 내지 못하여 처형 당하였습니다..");
         //          Console.WriteLine("Game Over");
         //          game.Over();
         //      }
         //  }











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
