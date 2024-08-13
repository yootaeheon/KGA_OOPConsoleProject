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
        public int day;
        public int Day { get{ return day; } }

        public int exhaustion;
        public int Exhaustion {  get{ return exhaustion; } }

        public int maxExhaustion;
        public int MaxExhaustion { get { return maxExhaustion; } }

        protected string name;
        public string Name { get { return name; } }

        protected int curHP;
        public int CurHp { get { return curHP; } }

        public int maxHP;
        public int MaxHP { get { return maxHP; } }

        public int str;
        public int Str {  get { return str; } }

        public int level;
        public int Level { get { return level; } }

        public int defense;
        public int Defense { get { return defense; } }

        public int gold;
        public int Gold { get { return gold; } }

        public int exp;
        public int Exp { get { return exp; } }

        public int maxExp;
        public int MaxExp { get { return maxExp; } }

        public int duty;
        public int Duty { get { return duty; } }

        public int deadLine;
        public int DeadLine { get { return deadLine; } }

        public void Skill(Monster monster)
        {
            if (level > 15)
            {
                //이벤트로 15렙 달성시 스킬 획득
                //스킬리스트에 등록
            }
        }

        public void ShowInfo() //static 으로 해줘야하는가?
        {
            Console.SetCursorPosition(0, 20);
            Console.WriteLine($"============ Day : {day} =================");
            Console.WriteLine($" 체력 : {curHP,+3} / {maxHP,-3}           ");
            Console.WriteLine($" 탈진 : {exhaustion, +3} / {maxExhaustion,-3}");
            Console.WriteLine($" 이름 : {name,-6} 직업 : 광부-노예       ");
            Console.WriteLine($" 소지금 : {gold,-3} 힘 : {str} 방어력 : {defense}");
            Console.WriteLine($" 레벨 : {level,-3} 경험치 : {exp} / {maxExp}");
            Console.WriteLine("===========================================");
            Console.WriteLine($" 세금 : {duty,-3} 납부 기한 : {DeadLine,-6} ");
            Console.WriteLine("===========================================");
        }




    }
}
