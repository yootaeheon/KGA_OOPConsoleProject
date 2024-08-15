using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSlave.Scenes
{
    public class TitleScene : Scene
    {
        public TitleScene(Game game) : base(game)
        {
        }
        
        public override void Enter() 
        {
            Console.WriteLine("당신은 낯선 곳에서 원주민들에게 끌려왔습니다..");
            Thread.Sleep(1); //1000으로 수정
            Console.WriteLine("이 곳에서 노예로 새로운 삶을 살게 되었습니다");
            Thread.Sleep(1);
            Console.WriteLine("당신은 하루마다 세금을 내야하며 \n미납시 즉결 처분 당합니다");
            Thread.Sleep(1);
            Console.WriteLine("건강(체력, 탈진)관리에 유념하여 이 곳에서 살아남으십시오..");
            Thread.Sleep(1);

            Console.CursorVisible = false;
        }

        public override void Exit( ) 
        {
            Console.CursorVisible = true;
        }

        public override void Input() 
        {
           Console.ReadKey();
        }
        public override void Render() 
        {
            Console.Clear();
            Console.WriteLine("==================================");
            Console.WriteLine("=                                =");
            Console.WriteLine("=            채굴 노예           =");
            Console.WriteLine("=                                =");
            Console.WriteLine("==================================");
            Console.WriteLine();
            Console.WriteLine("    계속 하려면 아무키나 누르시오   ");
            Console.ReadKey();
        }
        public override void Update()
        {
            game.ChangeScene(SceneType.Select);
        }
    }
}
