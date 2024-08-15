using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MineSlave.Scenes
{
    public class SelectScene : Scene
    {
        public enum State { Name, Confirm }
        private State curState;

        private string input;
        public static string nameInput;

        public SelectScene(Game game) : base(game)
        {
        }

        public override void Enter()
        {
            curState = State.Name;
        }

        public override void Exit()
        {
        }

        public override void Input()
        {
            input = Console.ReadLine();
        }

        public override void Render()
        {
            Console.Clear();
            if (curState == State.Name)
            {
                Console.Write("캐릭터의 이름을 입력하세요 : ");
            }
            else if (curState == State.Confirm)
            {
                Console.WriteLine("===================");
                Console.WriteLine($"이름 : {game.Player.Name}");
                Console.WriteLine($"직업 : 광부 - 노예 ");
                Console.WriteLine($"체력 : {game.Player.MaxHP}");
                Console.WriteLine($"힘 : {game.Player.Str}");
                Console.WriteLine($"방어력 : {game.Player.Defense}");
                Console.WriteLine($"소지금 : {game.Player.Gold}");
                Console.WriteLine("===================");
                Console.WriteLine();
                Console.Write("이대로 플레이 하시겠습니까?(y/n)");
            }
        }

        public override void Update()
        {
            if (curState == State.Name)
            {
                if (input == string.Empty)
                    return;

                nameInput = input;
                curState = State.Confirm;
            }
            else if (curState == State.Confirm)
            {
                switch (input)
                {
                    case "Y":
                    case "y":
                        game.ChangeScene(SceneType.Town);
                        break;
                    case "N":
                    case "n":
                        curState = State.Name;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}