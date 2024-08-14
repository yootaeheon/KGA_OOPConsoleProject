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
            if (type == ItemType.Potion)
            {
                Potion potion = new Potion();
                potion.name = "비타400";
                potion.weight = 5;
                potion.price = 70;
                potion.hp = 30;
                potion.type = ItemType.Potion;
                return potion as T;
            }
            else if (type == ItemType.Potion)
            {
                Potion potion = new Potion();
                potion.name = "MaxHP 포션";
                potion.weight = 5;
                potion.price = 100;
                potion.maxHP = 20;
                potion.type = ItemType.Potion;
                return potion as T;
            }
            else if (type == ItemType.Armor)
            {
                Armor armor = new Armor();
                armor.name = "반코팅 목장갑";
                armor.weight = 10;
                armor.price = 200;
                armor.defense = 7;
                armor.type = ItemType.Armor;
                return armor as T;
            }
            else if (type == ItemType.Armor)
            {
                Armor armor = new Armor();
                armor.name = "3M 장갑";
                armor.weight = 10;
                armor.price = 300;
                armor.defense = 10;
                armor.type = ItemType.Armor;
                return armor as T;
            }
            else if (type == ItemType.Armor)
            {
                Armor armor = new Armor();
                armor.name = "안전모";
                armor.weight = 20;
                armor.price = 300;
                armor.defense = 15;
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
            else if (type == ItemType.Weapon)
            {
                Weapon weapon = new Weapon();
                weapon.name = "너클";
                weapon.weight = 10;
                weapon.price = 300;
                weapon.str = 15;
                weapon.type = ItemType.Weapon;
                return weapon as T;
            }
            else if (type == ItemType.Equipment)
            {
                Equipment equipment = new Equipment();
                equipment.name = "묵직한 곡괭이";
                equipment.weight = 30;
                equipment.price = 300;
                equipment.str = 30;
                equipment.type = ItemType.Equipment;
                return equipment as T;
            }
            else if (type == ItemType.Equipment)
            {
                Equipment equipment = new Equipment();
                equipment.name = "녹슨 곡괭이";
                equipment.weight = 40;
                equipment.price = 170;
                equipment.str = 17;
                equipment.type = ItemType.Equipment;
                return equipment as T;
            }
            else if (type == ItemType.Water)
            {
                Water water = new Water();
                water.name = "물병";
                water.weight = 5;
                water.price = 50;
                water.exhaustion = 2; // 탈진게이지 -2/10
                water.type = ItemType.Water;
                return water as T;
            }
            else if (type == ItemType.Water)
            {
                Water water = new Water();
                water.name = "스탠리 텀블러";
                water.weight = 15;
                water.price = 150;
                water.exhaustion = 6; // 탈진게이지 -2/10
                water.type = ItemType.Water;
                return water as T;
            }


            else
            {
                return null;
            }
        }
    }
}
