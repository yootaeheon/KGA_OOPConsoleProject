using MineSlave.Inventorys;
using MineSlave.Items;
using MineSlave.Players;

namespace MineSlave.Scenes
{
    public class InventoryScene : Scene
    {
        public enum State { UseItem, CloseInventory }
        private State curState;
        public ConsoleKey inputKey;
        public Inventory Inventory;

        public InventoryScene(Game game) : base(game)
        {
        }

        public override void Enter()
        {
            Console.Clear();
            Inventory.ShowAllItem();
        }

        public override void Exit()
        {

            
        }

        public override void Input()
        {
            inputKey = Console.ReadKey(true).Key;
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
   //             if (inputKey == Array.IndexOf(Inventory.inven, ))  //수정 필요
                {
                //    Player.Equip(); //수정 필요
                }
            }
            else if (curState == State.CloseInventory)
            {
                if (inputKey == ConsoleKey.Tab)
                {
                    game.ChangeScene(SceneType.Town);
                }
            }
        }
    }
}

