using MineSlave.Monsters;
using MineSlave.Players;

namespace MineSlave.Scenes
{

    public class BattleScene : Scene
    {
        private Monster monster;
        public enum State { Enter, Encounter, Attack, Defense, Kill, Back  }
        private State curState;
        public ConsoleKey inputKey;
        public BattleScene(Game game) : base(game)
        {
        }

        public override void Enter()
        {
            // Random random = new Random();
            // int randomMonsterIndex = random.Next(0, 10); 
            // 랜덤 숫자의 인데스에 있는 몬스터 출현 연구


            MonsterBuilder mineWorkerBuilder = new MonsterBuilder();
            mineWorkerBuilder.SetApperance("흉터로 뒤덮힌")
                             .SetName("실세 광부")
                             .SetHp(400)
                             .SetGold(200)
                             .SetExp(100)
                             .SetDefense(10)
                             .SetType(MonsterType.MineWorker);

            Monster[] monsters = new Monster[10];

            monsters[0] = mineWorkerBuilder.Build();
            Console.WriteLine($"{monsters[0].apperance} {monsters[0].name}");

            curState = State.Encounter;
        }

        public override void Exit()
        {
            Console.Clear();
            Console.WriteLine("마을로 돌아갑니다...");
            Thread.Sleep(1000);

            game.ChangeScene(SceneType.Town);
        }

        public override void Input()
        {
             inputKey = Console.ReadKey(true).Key;
        }

        public override void Render()
        {
            if (curState == State.Encounter)
            {
                Console.WriteLine("스페이스바를 연타하여 공격하세요.");
                Console.WriteLine();
            }
            else if (curState == State.Attack)
            {
                Console.Clear() ;
                Console.WriteLine($"{monster.apperance} {monster[0].name}의 체력 : {monster.hp}"); // 둘중 뭐가 맞느가
                Console.WriteLine();
            }
            else if (curState == State.Kill)
            {
                Console.WriteLine($"{monster.apperance} {monster[0].name}를 잡았다!!");
                Console.WriteLine("엄청난 보상을 얻었다.");
                Console.WriteLine($"{monster.exp}");
                Console.WriteLine($"{monster.gold}");
            }
        }

        public override void Update()
        {
            if (curState == State.Encounter)
            {
                curState = State.Attack;
            }
            else if (curState == State.Attack)
            {
                int totalDamage = monster.hp - (Player.str - monster.defense);
                do
                {
                    if (inputKey == ConsoleKey.Spacebar)
                    {
                        monster.hp -= totalDamage;
                        Console.WriteLine($"몬스터 남은 체력 : {monster.hp - totalDamage}");
                    }
                }while (monster.hp <= 0);
            }
            else if (curState == State.Kill)
            {
                Player.exp += monster.exp;
                Player.gold += monster.gold;

                Exit();
            }
        }
    }
}

