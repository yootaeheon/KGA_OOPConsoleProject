using MineSlave.Inventorys;
using MineSlave.Items;
using System.ComponentModel.Design;

namespace MineSlave.Scenes
{
    internal class MineScene : Scene
    {
        public enum State { Enter, Mine, GetItem, Battle, Back = 9 }
        private State curState;
        public ConsoleKey inputKey;
        public string input;

        public Item item;
        public Inventory inventory;


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
                Console.Clear();
                Players.Player.ShowInfo2();
                Console.WriteLine();
                Console.WriteLine("깡!...");
                Thread.Sleep(2000);
                Console.WriteLine("깡!!...");
                Thread.Sleep(2000);
                Console.WriteLine("깡!!!...");
                Thread.Sleep(2000);
                Console.WriteLine("(스페이스바를 이용하여 채굴)");
                Thread.Sleep(1000);
            }
            else if (curState == State.GetItem)
            {

            }
            else if (curState == State.Back)
            {
               
            }
        }

        public override void Update()
        {
            if (curState == State.Enter)
            {
               if (inputKey == ConsoleKey.Spacebar)
               {
                    curState = State.Mine;
               }
            }
            else if (curState == State.Mine)
            {
                
            }
            else if (curState == State.GetItem)
            {
                if (inputKey == ConsoleKey.Spacebar)
                {
                    Random random = new Random();
                    int percent = random.Next(1, 100);

                    do
                    {
                        if (percent > 95)
                        {
                            game.ChangeScene(SceneType.Battle);
                        }
                        else if (percent > 80)
                        {
                            Console.WriteLine("다이아몬드 채굴!");
                            Diamond diamond = ItemFactory.Create<Diamond>("다이아몬드");
                            inventory.AddItem(diamond);
                        }
                        else if (percent > 50)
                        {
                            Console.WriteLine("금 채굴!");
                            Gold gold = ItemFactory.Create<Gold>("금");
                            inventory.AddItem(gold);
                        }
                        else
                        {
                            Console.WriteLine("석탄 채굴!");
                            Coal coal = ItemFactory.Create<Coal>("석탄");
                            inventory.AddItem(coal);
                        }
                    } while (percent > 95 || inputKey == ConsoleKey.D9);
                }
                else if (inputKey == ConsoleKey.D9)
                {
                    curState = State.Back;
                }
            }
            else if (curState == State.Back)
            {
                Exit();
            }
        }
    }
}
