using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MineSlave.Items
{
    
   public class items
    {
        Potion potion1 = ItemFactory.Create<Potion>("HP 포션");
        Potion potion2 = ItemFactory.Create<Potion>("비타400");
        Potion potion3 = ItemFactory.Create<Potion>("MaxHP 포션");

        Armor armor1 = ItemFactory.Create<Armor>("반코팅 목장갑");
        Armor armor2 = ItemFactory.Create<Armor>("3M 장갑");
        Armor armor3 = ItemFactory.Create<Armor>("안전모");

        Weapon weapon1 = ItemFactory.Create<Weapon>("나이프");
        Weapon weapon2 = ItemFactory.Create<Weapon>("너클");

        Equipment equipment1 = ItemFactory.Create<Equipment>("묵직한 곡괭이");
        Equipment equipment2 = ItemFactory.Create<Equipment>("녹슨 곡괭이");

        Water water1 = ItemFactory.Create<Water>("물병");
        Water water2 = ItemFactory.Create<Water>("스탠리 텀블러");

        Coal coal = ItemFactory.Create<Coal>("석탄");
        Gold gold = ItemFactory.Create<Gold>("금");
        Diamond diamond = ItemFactory.Create<Diamond>("다이아몬드");

        
    }

    public class ItemFactory
    {
        public static T Create<T>(string name) where T : Item
        {
            if (name == "HP 포션")
            {
                Potion potion = new Potion();
                potion.name = "HP 포션";
                potion.weight = 5;
                potion.price = 50;
                potion.hp = 20;
                potion.type = ItemType.Potion;
                return potion as T;
            }
            if (name == "비타400")
            {
                Potion potion = new Potion();
                potion.name = "비타400";
                potion.weight = 5;
                potion.price = 70;
                potion.hp = 30;
                potion.type = ItemType.Potion;
                return potion as T;
            }
            else if (name == "MaxHP 포션")
            {
                Potion potion = new Potion();
                potion.name = "MaxHP 포션";
                potion.weight = 5;
                potion.price = 100;
                potion.maxHP = 20;
                potion.type = ItemType.Potion;
                return potion as T;
            }
            else if (name == "반코팅 목장갑")
            {
                Armor armor = new Armor();
                armor.name = "반코팅 목장갑";
                armor.weight = 10;
                armor.price = 200;
                armor.defense = 7;
                armor.type = ItemType.Armor;
                return armor as T;
            }
            else if (name == "3M 장갑")
            {
                Armor armor = new Armor();
                armor.name = "3M 장갑";
                armor.weight = 10;
                armor.price = 300;
                armor.defense = 10;
                armor.type = ItemType.Armor;
                return armor as T;
            }
            else if (name == "안전모")
            {
                Armor armor = new Armor();
                armor.name = "안전모";
                armor.weight = 20;
                armor.price = 300;
                armor.defense = 15;
                armor.type = ItemType.Armor;
                return armor as T;
            }
            else if (name == "나이프")
            {
                Weapon weapon = new Weapon();
                weapon.name = "나이프";
                weapon.weight = 30;
                weapon.price = 500;
                weapon.str = 30;
                weapon.type = ItemType.Weapon;
                return weapon as T;
            }
            else if (name == "너클")
            {
                Weapon weapon = new Weapon();
                weapon.name = "너클";
                weapon.weight = 10;
                weapon.price = 300;
                weapon.str = 15;
                weapon.type = ItemType.Weapon;
                return weapon as T;
            }
            else if (name == "묵직한 곡괭이")
            {
                Equipment equipment = new Equipment();
                equipment.name = "묵직한 곡괭이";
                equipment.weight = 30;
                equipment.price = 300;
                equipment.str = 30;
                equipment.type = ItemType.Equipment;
                return equipment as T;
            }
            else if (name == "녹슨 곡괭이")
            {
                Equipment equipment = new Equipment();
                equipment.name = "녹슨 곡괭이";
                equipment.weight = 40;
                equipment.price = 170;
                equipment.str = 17;
                equipment.type = ItemType.Equipment;
                return equipment as T;
            }
            else if (name == "물병")
            {
                Water water = new Water();
                water.name = "물병";
                water.weight = 5;
                water.price = 50;
                water.exhaustion = 2; // 탈진게이지 -2/10
                water.type = ItemType.Water;
                return water as T;
            }
            else if (name == "스탠리 텀블러")
            {
                Water water = new Water();
                water.name = "스탠리 텀블러";
                water.weight = 15;
                water.price = 150;
                water.exhaustion = 6; // 탈진게이지 -2/10
                water.type = ItemType.Water;
                return water as T;
            }
            else if (name == "석탄")
            {
                Coal coal = new Coal();
                coal.name = "석탄";
                coal.weight = 2;
                coal.price = 10;
                coal.type = ItemType.Coal;
                return coal as T;
            }
            else if (name == "금")
            {
                Gold gold = new Gold();
                gold.name = "금";
                gold.weight = 3;
                gold.price = 30;
                gold.type = ItemType.Gold;
                return gold as T;
            }
            else if (name == "다이아몬드")
            {
                Diamond diamond = new Diamond();
                diamond.name = "다이아몬드";
                diamond.weight = 8;
                diamond.price = 100;
                diamond.type = ItemType.Diamond;
                return diamond as T;
            }

            else
            {
                return null;
            }
        }
    }
}
