using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSlave.Monsters
{
    public enum MonsterType { 광부, 짐승, 괴물 }
    public class Monster
    {
        public string name;
        public int hp;
        public int str;
        public int defense;
        public string apperance;
        public int exp;
        public int gold;
        public MonsterType type; // 문제 시 타입 삭제
    }
}
