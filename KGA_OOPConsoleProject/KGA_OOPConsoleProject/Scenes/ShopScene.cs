using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSlave.Scenes
{
    public class ShopScene : Scene
    {
        public ShopScene(Game game) : base(game)
        {
        }

        public override void Enter()
        {
            // TODO : 아이템 설정

            Console.Clear();
            Console.WriteLine("상점에 들어갑니다...");
            Thread.Sleep(2000);
        }

        public override void Exit()
        {

        }

        public override void Input()
        {
            // TODO : 상점 입력
        }

        public override void Render()
        {
            // TODO : 상점 상황 출력
        }

        public override void Update()
        {
            // TODO : 상점 처리

            Thread.Sleep(2000);
        }
    }
}

