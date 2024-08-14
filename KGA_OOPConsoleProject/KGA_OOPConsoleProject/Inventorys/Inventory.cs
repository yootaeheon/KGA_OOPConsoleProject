﻿using MineSlave.Items;


namespace MineSlave.Inventorys
{
    internal class Inventory
    {
        private List<Item> inven;
        public int itemCount => inven.Count;

        public Inventory()
        {
            inven = new List<Item>();
        }

        public void AddItem(Item item)
        {
            inven.Add(item);
        }

        public void RemoveItem(int index)
        {
            inven.RemoveAt(index);
        }

        public void ShowAllItem()
        {
            Console.WriteLine();
            Console.WriteLine("======= 가방 ========== ");
            if (inven.Count == 0)
            {
                Console.WriteLine("텅 비어있다.");
            }
            else
            {
                foreach (Item item in inven)
                {
                    Console.WriteLine(item.name);
                }
            }
            Console.WriteLine("======= 가방 ========== ");
        }
    }
}
