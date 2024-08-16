using MineSlave.Inventorys;
using MineSlave.Items;
using MineSlave.Players;
using System.ComponentModel;

namespace MineSlave.Scenes
{
    public class InventoryScene : Scene
    {

        public enum State { UseItem, CloseInventory }
        private State curState;
        public ConsoleKey inputKey;
        public Inventory Inventory;
        public Player player;
        public Item item;
        private string input;
       
        public InventoryScene(Game game) : base(game)
        {
            player = game.player;
            item = game.item;
        }

        public override void Enter()
        {
            Console.Clear();
            Inventory.ShowAllItem();
        }

        public override void Exit()
        {
            
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
            if (curState == State.UseItem)
            {
                
            }
        }

        public override void Update()
        {
            if (curState == State.UseItem)
            {
               if (input == game.item.name)  
                {
//                    Player.Equip();  추후 개발 예정
                }
            }
            else if (curState == State.CloseInventory)
            {
                if (input == "9")
                {
                    game.ChangeScene(SceneType.Town);
                }
            }
        }
    }
}

