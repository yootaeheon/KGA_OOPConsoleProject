using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSlave.Monsters
{
    public class MakeMonsterBilder
    {
        public MonsterBuilder mineWorkerBuilder = new MonsterBuilder();
        public MonsterBuilder beastBuilder = new MonsterBuilder();
        public MonsterBuilder monsterBuilder = new MonsterBuilder();

    }

    public class MonsterBuilder
    {
        public string name;
        public int hp;
        public int str;
        public int defense;
        public string apperance;
        public int exp;
        public int gold;
        public MonsterType type;

        public MonsterBuilder()
        {
            name = "몬스터";
            hp = 100;
            str = 20;
            defense = 5;
            apperance = "덩치 큰";
            exp = 50;
            gold = 100;
        }

        public Monster Build()
        {
            Monster monster = new Monster();
            monster.name = name;
            monster.hp = hp;
            monster.str = str;
            monster.defense = defense;
            monster.apperance = apperance;
            monster.exp = exp;
            monster.gold = gold;
            monster.type = type;
            return monster;
        }

        public MonsterBuilder SetName(string name)
        { this.name = name; return this; }

        public MonsterBuilder SetHp(int hp)
        { this.hp = hp; return this; }

        public MonsterBuilder SetStr(int str)
        { this.str = str; return this; }

        public MonsterBuilder SetDefense(int defense)
        { this.defense = defense; return this; }

        public MonsterBuilder SetApperance(string apperance)
        { this.apperance = apperance; return this; }

        public MonsterBuilder SetExp(int exp)
        { this.exp = exp; return this; }

        public MonsterBuilder SetGold(int gold)
        { this.gold = gold; return this; }

        public MonsterBuilder SetType(MonsterType type)
        { this.type = type; return this; }
    }
}
