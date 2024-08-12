using MineSlave.Monsters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MineSlave.Scenes
{
    public class BattleScene : Scene
    {
        private Monster monster;

        public BattleScene(Game game) : base(game)
        {
        }

        public override void Enter()
        {
            Random randomMonster = new Random();
            randomMonster.Next();

            monster = new Monster();
            monster.name = "더미 몬스터";
            monster.hp = 100;
            monster.str = 10;
            monster.defense = 10;

            Console.Clear();
            Console.WriteLine($"{monster.name} 이/가 나타났다!!!");
            Thread.Sleep(2000);
        }

        public override void Exit()
        {

        }

        public override void Input()
        {
            // TODO : 전투 입력
        }

        public override void Render()
        {
            // TODO : 전투 상황 출력
        }

        public override void Update()
        {
            // TODO : 전투 진행

            game.ChangeScene(SceneType.Town);
        }
    }
}

