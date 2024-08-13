using MineSlave.Players;

namespace MineSlave.Scenes
{
    public class CampScene : Scene
    {
        private string input;

        public CampScene(Game game) : base(game)
        {
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

            game.ChangeScene(SceneType.Town);
        }

        public override void Input()
        {
            input = Console.ReadLine();
            
        }

        public override void Render() //콘솔 출력
        {

        }

        public override void Update()
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

                        Player.curHP += 80;
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

                        Player.curHP = Player.maxHP;
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

                        Player.curHP += 70;
                        break;
                    }
            }
        }
    }
}
