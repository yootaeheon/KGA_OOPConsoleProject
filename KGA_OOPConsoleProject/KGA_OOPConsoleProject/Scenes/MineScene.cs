namespace MineSlave.Scenes
{
    internal class MineScene : Scene
    {
        public enum State { Enter, Mine, GetItem, Battle, Back = 9 }
        private State curState;
        public ConsoleKey inputKey;
        private string input;


        public MineScene(Game game) : base(game)
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

            inputKey = Console.ReadKey(true).Key;
        }

        public override void Render()
        {
            if (curState == State.Enter)
            {
                Console.Clear();
                Console.WriteLine("광산에 들어왔습니다.");
                Thread.Sleep(1000);
                Console.WriteLine("석탄을 채굴하여 돈을 벌 수 있습니다.");
                Thread.Sleep(1000);
                Console.WriteLine("스페이스바를 눌러 채굴을 시작하세요.");
                Thread.Sleep(1000);
            }
            else if (curState == State.Mine)
            {
                Console.WriteLine();
                
            }



            Exit();
        }

        public override void Update()
        {
            if (curState == State.Enter)
            {
               if (inputKey == ConsoleKey.Spacebar)
               {
                    curState = State.GetItem;
               }
            }
            else if (curState == State.Mine)
            {

            }
            else if (curState == State.GetItem)
            {

            }
            else if (curState == State.Mine)
            {

            }

        }

    }



}
