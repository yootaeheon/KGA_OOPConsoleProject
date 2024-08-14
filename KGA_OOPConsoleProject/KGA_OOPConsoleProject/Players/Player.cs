using MineSlave.Monsters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace MineSlave.Players
{
    public class Player
    {
        public static int day;
        public int Day { get{ return day; } }

        public static int exhaustion;
        public int Exhaustion {  get{ return exhaustion; } }

        public static int maxExhaustion;
        public int MaxExhaustion { get { return maxExhaustion; } }

        protected static string name;
        public string Name { get { return name; } }

        public static int curHP;
        public int CurHp { get { return curHP; } }

        public static int maxHP;
        public int MaxHP { get { return maxHP; } }

        public static int str;
        public int Str {  get { return str; } }

        public static int level;
        public int Level { get { return level; } }

        public static int defense;
        public int Defense { get { return defense; } }

        public static int gold;
        public int Gold { get { return gold; } }

        public static int exp;
        public int Exp { get { return exp; } }

        public static int maxExp;
        public int MaxExp { get { return maxExp; } }

        public static int duty;
        public int Duty { get { return duty; } }

        public static int deadLine;
        public int DeadLine { get { return deadLine; } }

        public void Skill(Monster monster)
        {
            if (level > 15)
            {
                //이벤트로 15렙 달성시 스킬 획득
                //스킬리스트에 등록
            }
        }

        public static void ShowInfo() 
        {
            Console.SetCursorPosition(0, 20);
            Console.WriteLine($"============ Day : {day} =================");
            Console.WriteLine($" 체력 : {curHP,+3} / {maxHP,-3}           ");
            Console.WriteLine($" 탈진 : {exhaustion, +3} / {maxExhaustion,-3}");
            Console.WriteLine($" 이름 : {name,-6} 직업 : 광부-노예       ");
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
