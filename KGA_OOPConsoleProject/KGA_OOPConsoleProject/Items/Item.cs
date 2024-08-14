using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MineSlave.Items
{
    public enum ItemType { Potion, Weapon, Armor, Equipment, Water, Bag }
    public class Item
    {
        public string name;
        public int price;
        public int weight;
        public ItemType type;

        public Item()
        {
            this.name = "아이템";
            this.price = 100;
            this.weight = 1;
        }
    }

    public interface IDringkable
    {
        public void Drink(Item item);
    }

    public interface Iwearable
    {
        public void wear(Item item);
    }

    public class Potion : Item
    {
        public int hp;
        public int maxHP;
    }
    public class Weapon : Item
    {
        public int str;
    }

    public class Armor : Item
    {
        public int defense;
    }

    public class Water : Item
    {
        public int hp;
        public int exhaustion; // 낮을 수록 탈진 증세 하락
    }

    public class Bag : Item
    {
        public int amount;
    }

    public class Equipment : Item
    {
        public int str;
    }
}
