using MineSlave.Items;


namespace MineSlave.Inventorys
{
    internal class Inventory
    {
        private List<Item> items;
        public int itemCount => items.Count;

        public Inventory()
        {
            items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public void RemoveItem(int index)
        {
            items.RemoveAt(index);
        }

        public void ShowAllItem()
        {
            Console.WriteLine();
            Console.WriteLine("======= 가방 ========== ");
            if (items.Count == 0)
            {
                Console.WriteLine("텅 비어있다.");
            }
            else
            {
                foreach (Item item in items)
                {
                    Console.WriteLine(item.name);
                }
            }
            Console.WriteLine("======= 가방 ========== ");
        }
    }
}
