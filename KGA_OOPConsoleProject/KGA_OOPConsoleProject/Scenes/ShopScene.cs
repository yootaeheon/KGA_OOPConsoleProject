using MineSlave.Inventorys;
using MineSlave.Items;
using MineSlave.Monsters;
using MineSlave.Players;
using System.Runtime.CompilerServices;

namespace MineSlave.Scenes
{

    public class ShopScene : Scene
    {
        public enum State { Enter, ShopStory, Buy, Sell, Back = 9 }

        private State curState;
        private string input;

        private Item item;
        public items items;
        public ItemFactory ItemFactory;
        private Inventory inventory;
        
        public ShopScene(Game game) : base(game)
        {
        }

        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine("상점에 들어갑니다...");
            Thread.Sleep(1000);

            curState = State.Enter;
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

        public override void Render()
        {
            if (curState == State.Enter)
            {
                Console.Clear();
                Console.WriteLine("상점에 들어왔습니다.");
                Thread.Sleep(1000);
                Console.WriteLine("1. 구매");
                Thread.Sleep(1000);
                Console.WriteLine("2. 판매");
                Thread.Sleep(1000);
                Console.WriteLine("9. 나가기");
                Thread.Sleep(1000);
                Input();
            }
            else if (curState == State.Buy)
            {
                
                Console.WriteLine("아이템 번호를 눌러 구매하세요");
                for (int i = 0; i < 12; i++)
                {
                   Console.WriteLine($"{item}"); // 수정 필요
                }
            }
            else if (curState == State.Sell)
            {
                Console.WriteLine("아이템 번호를 눌러 판매하세요");
                for (int i = 0; i < inventory.inven.Count; i++)
                {
                    Console.WriteLine($"{item}"); // 수정 필요
                }
            }
            else if (curState == State.Back)
            {

            }
        }

        public override void Update()
        {
            if (curState == State.Enter)
            {
                switch (input)
                {
                    case "1":
                        curState = State.Buy;
                        break;
                    case "2":
                        curState = State.Sell;
                        break;
                    case "9":
                        game.ChangeScene(SceneType.Town);
                        break;
                }
            }
            else if (curState == State.Buy)
            {
                if (Player.gold >= item.price)
                {
                    inventory.inven.Add(item);
                    Players.Player.gold -= item.price;
                    Console.WriteLine($"{item} 구매 완료");
                }
                else
                {
                    Console.WriteLine("골드가 부족합니다");
                    return;
                }
            }
            else if (curState == State.Sell)
            {
                inventory.inven.Remove(item);
                Players.Player.gold += item.price;
            }
            else if (curState == State.Back)
            {
                Exit();
            }
        }
    }
}

