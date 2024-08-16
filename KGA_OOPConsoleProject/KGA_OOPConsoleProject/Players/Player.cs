using MineSlave.Items;
using MineSlave.Scenes;

namespace MineSlave.Players
{
    public class Player
    {
        public static int day = 1;
        public int Day { get { return day; } set { } }

        public static int maxExhaustion = 6;
        public int MaxExhaustion { get { return maxExhaustion; } set { } }

        public static int exhaustion = maxExhaustion; // 탈수게이지
        public int Exhaustion { get { return exhaustion; } set { } }

        public static string name = SelectScene.nameInput;
        public string Name { get { return name; } }

        public static int maxHP = 100;
        public int MaxHP { get { return maxHP; } set { } }

        public static int curHP = maxHP;
        public int CurHP { get { return curHP; } set { } }


        public static int str = 5;
        public int Str { get { return str; } set { } }

        public static int level = 1;
        public int Level { get { return level; } set { } }

        public static int defense = 5;
        public int Defense { get { return defense; } set { } }

        public static int gold = 100;
        public int Gold { get { return gold; } set { } }

        public static int exp = 0;
        public int Exp { get { return exp; } set { } }

        public static int maxExp = 100;
        public int MaxExp { get { return maxExp; } set { } }

        public static int duty = 500; // 세금
        public int Duty { get { return duty; } set { } }


        public static int deadLine = 5; // 납부 기한
        public int DeadLine { get { return deadLine; } set { } }






        // 아이템 장착
        public Armor curArmor;
        public Weapon curWeapon;
        public Equipment curEquipment;

        public void Equip(Armor armor)
        {
            Console.WriteLine($"플레이어가 {armor.name} 을/를 착용합니다.");
            curArmor = armor;
            defense += armor.defense;
        }
        public void Equip(Weapon weapon)
        {
            Console.WriteLine($"플레이어가 {weapon.name} 을/를 착용합니다.");
            curWeapon = weapon;
            str += weapon.str;
        }
        public void Equip(Equipment equipment)
        {
            Console.WriteLine($"플레이어가 {equipment.name} 을/를 착용합니다.");
            curEquipment = equipment;
            str += equipment.str;
        }
        //

        public static void ShowInfo()
        {
            Console.SetCursorPosition(0, 20);
            Console.WriteLine($"============ Day : {day} =================");
            Console.WriteLine($" 체력 : {curHP,+3} / {maxHP,-3}           ");
            Console.WriteLine($" 탈진 : {exhaustion,+3} / {maxExhaustion,-3}");
            Console.WriteLine($" 이름 : {Game.Equals(SceneType.Select, name)} 직업 : 광부-노예       ");  //이름 위치 수정 필요
            Console.WriteLine($" 소지금 : {gold,-3} 힘 : {str} 방어력 : {defense}");
            Console.WriteLine($" 레벨 : {level,-3} 경험치 : {exp} / {maxExp}");
            Console.WriteLine("===========================================");
            Console.WriteLine($" 세금 : {duty,-3} 납부 기한 : {deadLine,-6} ");
            Console.WriteLine("===========================================");
        }

        public static void ShowInfo2()
        {
            Console.SetCursorPosition(0, 20);
            Console.WriteLine($"============ Day : {day} =================");
            Console.WriteLine($" 체력 : {curHP,+3} / {maxHP,-3}           ");
            Console.WriteLine($" 탈진 : {exhaustion,+3} / {maxExhaustion,-3}");
            Console.WriteLine($" 소지금 : {gold,-3} 힘 : {str} 방어력 : {defense}");
            Console.WriteLine($" 레벨 : {level,-3} 경험치 : {exp} / {maxExp}");
            Console.WriteLine("===========================================");
            Console.WriteLine($" 세금 : {duty,-3} 납부 기한 : {deadLine,-6} ");
            Console.WriteLine("===========================================");
            Console.WriteLine("마을로 돌아가기 : 9");
        }



    }
}
