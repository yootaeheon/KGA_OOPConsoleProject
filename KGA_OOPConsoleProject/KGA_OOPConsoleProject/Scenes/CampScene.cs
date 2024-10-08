﻿using MineSlave.Players;
using System.Numerics;

namespace MineSlave.Scenes
{
    public class CampScene : Scene
    {
        public enum State { CampStory, Result1, Result2, Result3, Back = 9 }
        private State curState;
        public Player player;   
        private string input;
        

        public CampScene(Game game) : base(game)
        {
            player = game.Player;
        }

        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine("캠프에 들어왔습니다");
            Thread.Sleep(1000);

            Console.WriteLine("몇 호에 들어가시겠습니까");
            Console.WriteLine("1. 101호");
            Console.WriteLine("2. 102호");
            Console.WriteLine("3. 103호");
            Console.WriteLine();
            Console.WriteLine("9.돌아간다");
            Console.Write("선택 : ");
        }

        public override void Exit()
        {
            Console.Clear();
            Console.WriteLine("마을로 돌아갑니다...");
            Thread.Sleep(1000);
        }
        public override void Exit2()
        {

        }

        public override void Input()
        {
            input = Console.ReadLine();
        }

        public override void Render() 
        {
            switch (input)
            {
                case "1":
                    {
                        Console.WriteLine("101호로 들어갑니다.");
                        Thread.Sleep(1000);
                        Console.WriteLine("안 씻고 잠든 광부들과 뒤섞여 잡니다.");
                        Thread.Sleep(1000);
                        Console.WriteLine("냄새나서 제대로 된 휴식을 취할 수 없습니다.");
                        Thread.Sleep(1000);
                        Console.WriteLine("피로 회복이 덜 합니다.");
                        Thread.Sleep(1000);

                        curState = State.Result1;
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("102호로 들어갑니다.");
                        Thread.Sleep(1000);
                        Console.WriteLine("꿀잠에 듭니다.");
                        Thread.Sleep(1000);
                        Console.WriteLine("충분한 휴식을 취합니다.");
                        Thread.Sleep(1000);

                        curState = State.Result2;
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("103호로 들어갑니다.");
                        Thread.Sleep(1000);
                        Console.WriteLine("잠에 듭니다.");
                        Thread.Sleep(1000);
                        Console.WriteLine("옆에서 자고 있는 광부가 잠꼬대를 하며 머리르 내려칩니다.");
                        Thread.Sleep(1000);
                        Console.WriteLine("피로 회복이 덜 합니다.");
                        Thread.Sleep(1000);

                        curState = State.Result3;
                        break;
                    }
                case "9":
                    {
                        curState = State.Back;
                        break;
                    }
            }
        }

        public override void Update()
        {
            if (curState == State.Result1)
            {
                Player.curHP += 80;
                if (player.CurHP >= player.MaxHP)
                {
                    player.CurHP = player.MaxHP;
                }
                game.ChangeScene(SceneType.Town);
            }
            else if (curState == State.Result2)
            {
                Player.curHP = Player.maxHP;
                game.ChangeScene(SceneType.Town);
            }
            else if (curState == State.Result3)
            {
                Player.curHP += 70;
                if (player.CurHP >= player.MaxHP)
                {
                    player.CurHP = player.MaxHP;
                }
                game.ChangeScene(SceneType.Town);
            }

            else if (curState == State.Back)
            {
                game.ChangeScene(SceneType.Town);
            }
            else
            {
                return;
            }

        }
    }
}
