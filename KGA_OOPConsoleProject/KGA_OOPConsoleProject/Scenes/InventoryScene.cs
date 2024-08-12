using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSlave.Scenes
{
    public class InventoryScene : Scene
    {
        public InventoryScene(Game game) : base(game)
        {
        }

        public override void Enter()
        {
            // TODO : 인벤토리 설정

            Console.Clear();
            Console.WriteLine("인벤토리를 엽니다...");
            Thread.Sleep(1000);
        }

        public override void Exit()
        {

        }

        public override void Input()
        {
            // TODO : 인벤토리 입력
        }

        public override void Render()
        {
            // TODO : 인벤토리 상황 출력
        }

        public override void Update()
        {
            // TODO : 인벤토리 처리

            game.ChangeScene(SceneType.Town);
        }
    }
}

