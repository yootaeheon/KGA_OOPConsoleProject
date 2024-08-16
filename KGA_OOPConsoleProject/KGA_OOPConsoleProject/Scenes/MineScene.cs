using MineSlave.Inventorys;
using MineSlave.Items;
using MineSlave.Players;
using System.ComponentModel.Design;

namespace MineSlave.Scenes
{
    internal class MineScene : Scene
    {
        public enum State { Enter, Mine, GetItem, Battle, Back = 9 }
        private State curState;
        public ConsoleKey inputKey;
        public string input;
        public Player player;
        public Item item;
       
        public ItemFactory ItemFactory;
        public Diamond diamond;
        public Coal coal;
        public Gold gold;
        public Inventory inven;

        public MineScene(Game game) : base(game)
        {
            
        }
        
        public class Init()
        {
            
        }

        public override void Enter()
        {
            curState = State.Enter;
            Console.CursorVisible = false;
        }

        public override void Exit()
        {
            Console.Clear();
            Console.WriteLine("마을로 돌아갑니다...");
            Console.CursorVisible = true;
        }

        public override void Exit2() // Start Battle 전용 Exit
        {
            Console.WriteLine("몬스터 출현!!");
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
            }
            else if (curState == State.Mine)
            {
                Console.Clear();
                Player.ShowInfo2();
                Console.WriteLine("깡!...");
                Thread.Sleep(1000);
                Console.WriteLine("깡!!...");
                Thread.Sleep(1000);
                Console.WriteLine("깡!!!...");
                Thread.Sleep(1000);
                Console.WriteLine("(스페이스바를 이용하여 채굴)");
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
                curState = State.GetItem;
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
                            
                            game.StartBattle(SceneType.Battle);
                            break;
                        }
                        else if (percent > 80)
                        {
                            Console.WriteLine("다이아몬드 채굴!");
                            Diamond diamond = ItemFactory.Create<Diamond>("다이아몬드");
                            game.inventory.AddItem(diamond);
                            game.player.CurHP -= 1;
                            if (game.player.CurHP <= 0)
                            {
                                game.Over();
                            }
                        }
                        else if (percent > 50)
                        {
                            Console.WriteLine("금 채굴!");
                            Gold gold = ItemFactory.Create<Gold>("금");
                            game.inventory.AddItem(gold);
                            game.player.CurHP -= 1;
                            if (game.player.CurHP <= 0)
                            {
                                game.Over();
                            }
                        }
                        else
                        {
                            Console.WriteLine("석탄 채굴!");
                            Coal coal = ItemFactory.Create<Coal>("석탄");
                            game.inventory.AddItem(coal);
                            game.player.CurHP -= 1;
                            if (game.player.CurHP <= 0)
                            {
                                game.Over();
                            }
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
                game.ChangeScene(SceneType.Town);
            }
        }
    }
}
