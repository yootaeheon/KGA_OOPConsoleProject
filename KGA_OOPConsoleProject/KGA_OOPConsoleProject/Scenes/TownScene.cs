using MineSlave.Players;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MineSlave.Scenes
{
    public class TownScene : Scene
    {
        //tab 누르면 인벤토리

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

            Player.ShowInfo(); // ? 
            Console.WriteLine();

            TownMap.PrintMap();
            TownMap.PrintPlayer();
            TownMap.PrintMine();
            TownMap.PrintShop();
            TownMap.PrintCamp();
            TownMap.PrintGambling();
        }

        public override void Update()
        {
            switch (TownMap.data.playerPos)
            {
                case (x = 4 &&y = 7):
                    game.ChangeScene(SceneType.Mine);
                    break;
                case TownMap.data.shopPos:
                    game.ChangeScene(SceneType.Shop);
                    break;
                case TownMap.data.campPos:
                    game.ChangeScene(SceneType.Camp);
                    break;
                case TownMap.data.gamblingPos:
                    game.ChangeScene(SceneType.Gambling);
                    break;
            }
        }
    }
}
