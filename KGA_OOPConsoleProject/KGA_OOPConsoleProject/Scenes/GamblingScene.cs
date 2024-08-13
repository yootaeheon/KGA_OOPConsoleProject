using MineSlave.Players;

namespace MineSlave.Scenes
{

    internal class GamblingScene : Scene
    {
        public enum State { Enter, GamblingStory, Pay, Gambling, GetGold, LoseGold, Back = 9 }
        private State curState;

        private string input;


        public GamblingScene(Game game) : base(game)
        {
        }

        public override void Enter()
        {
            curState = State.Enter;
        }

        public override void Exit()
        {
            Console.Clear();
            Console.WriteLine("마을로 돌아갑니다...");
            game.ChangeScene(SceneType.Town);

        }

        public override void Input()
        {
            Console.ReadKey();
        }

        public override void Render()
        {
            if (curState == State.Enter)
            {
                Console.Clear();
                Console.WriteLine("도박장에 들어왔습니다.");
                Thread.Sleep(1000);
                Console.WriteLine("참가비 100골드를 내고 게임 시작.");
                Thread.Sleep(3000);
                Console.WriteLine("참가비를 내주세요. (아무키 누르기)");
                Input();
            }
            else if (curState == State.Gambling)
            {
                Console.Clear();
                Console.WriteLine("주사위를 던져 숫자 1,6이 나오면 200골드를 얻고");
                Console.WriteLine("나머지 숫자가 나오면 50골드를 잃습니다.");
                Thread.Sleep(3000);
                Console.WriteLine();
                Console.WriteLine("주사위를 던져주세요. (아무키를 누르기)");
                Input();

                Console.Clear();
                Console.WriteLine("주사위를 던집니다!");
                Console.WriteLine(".");
                Thread.Sleep(1000);
                Console.WriteLine(".");
                Thread.Sleep(1000);
                Console.WriteLine(".");
                Thread.Sleep(1000);
            }
            else if (curState == State.GetGold)
            {
                Random random = new Random();
                int temp = random.Next(1, 7);

                if (temp == 1 || temp == 6)
                {
                    Console.WriteLine($"{temp}이 나왔습니다.");
                    Thread.Sleep(1000);
                    Console.WriteLine("축하합니다. 200골드를 획득하였습니다");
                    Thread.Sleep(1000);

                }
                else if (curState == State.LoseGold)
                {
                    if (temp == 2 || temp == 3 || temp == 4 || temp == 5)
                    {
                        Console.WriteLine($"{temp}이/가 나왔습니다.");
                        Thread.Sleep(1000);
                        Console.WriteLine("꽝! 다음 기회에 다시 도전하세요.");
                        Thread.Sleep(1000);
                        Console.WriteLine("50골드를 잃었습니다");
                        Thread.Sleep(3000);

                    }
                }
            }
            Exit();
        }

        public override void Update()
        {
            if (curState == State.Enter)
            {
                if (Player.gold >= 100)
                {
                    Player.gold -= 100;
                    Console.WriteLine("-100 G");
                    Thread.Sleep(1000);
                }
                else
                {
                    Console.WriteLine("참가비가 부족해 쫓겨납니다.");
                    Thread.Sleep(1000);
                    Console.WriteLine("마을로 돌아갑니다...");
                    Thread.Sleep(1000);

                    game.ChangeScene(SceneType.Town);
                    return;
                }
            }
            else if (curState == State.GetGold)
            {
                Player.gold += 200;
            }
            else if (curState == State.LoseGold)
            {
                Player.gold -= 50;
            }

        }
    }
}
