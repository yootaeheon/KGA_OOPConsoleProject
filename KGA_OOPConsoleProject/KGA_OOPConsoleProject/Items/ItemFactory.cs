using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSlave.Items
{
    public class ItemFactory
    {
        public static T Create<T>(ItemType type) where T : Item
        {
            if (type == ItemType.Potion)
            {
                Potion potion = new Potion();
                potion.name = "HP 포션";
                potion.weight = 5;
                potion.price = 50;
                potion.hp = 20;
                potion.type = ItemType.Potion;
                return potion as T;
            }
            else if (type == ItemType.Armor)
            {
                Armor armor = new Armor();
                armor.name = "3M장갑";
                armor.weight = 10;
                armor.price = 300;
                armor.defense = 10;
                armor.type = ItemType.Armor;
                return armor as T;
            }
            else if (type == ItemType.Weapon)
            {
                Weapon weapon = new Weapon();
                weapon.name = "나이프";
                weapon.weight = 30;
                weapon.price = 500;
                weapon.str = 30;
                weapon.type = ItemType.Weapon;
                return weapon as T;
            }
            else if (type == ItemType.Equipment)
            {
                Equipment equipment = new Equipment();
                equipment.name = "묵직한곡괭이";
                equipment.weight = 30;
                equipment.price = 300;
                equipment.str = 30;
                equipment.type = ItemType.Equipment;
                return equipment as T;
            }
            else if (type == ItemType.Food)
            {
                Food food = new Food();
                food.name = "물병";
                food.weight = 5;
                food.price = 50;
                food.exhaustion = 2; // 탈진게이지 -2/10
                food.type = ItemType.Food;
                return food as T;
            }
        }
    }
}
