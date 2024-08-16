using MineSlave.Monsters;
using MineSlave.Players;

namespace MineSlave.Scenes
{

    public class BattleScene : Scene
    {
        public enum State { Enter, Encounter, Attack, Defense, Kill }
        private State curState;
        public ConsoleKey inputKey;
        public Player player;
        private Monster monster;

        public BattleScene(Game game) : base(game)
        {
            player = game.player;

            game.monster.apperance = "흉터로 뒤덮힌";
            game.monster.name = "실세 광부";
            game.monster.hp = 400;
            game.monster.exp = 100;
            game.monster.gold = 200;
            game.monster.defense = 10;
            game.monster.type = MonsterType.MineWorker;

            monster = game.monster;

        }

        public override void Enter()
        {
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
            Console.WriteLine($"{game.monster.apperance} {game.monster.name} 가 나타났다");

            curState = State.Encounter;
        }

        public override void Exit()
        {
            Console.Clear();
            Console.WriteLine("마을로 돌아갑니다...");
            Thread.Sleep(1000);
        }
        public override void Exit2()
        {

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
                Console.WriteLine($"{monster.apperance} {monster.name}의 체력 : {monster.hp}"); // 둘중 뭐가 맞느가
                Console.WriteLine();
            }
            else if (curState == State.Kill)
            {
                Console.WriteLine($"{monster.apperance} {monster.name}를 잡았다!!");
                Console.WriteLine("엄청난 보상을 얻었다.");
                Console.WriteLine($"경험치 획득 : {monster.exp}");
                Console.WriteLine($"골드 획득 : {monster.gold}");
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
                int totalDamage = monster.hp - (game.player.Str - monster.defense);
                if (inputKey == ConsoleKey.Spacebar)
                {
                    for (int i = 0; 0 >= monster.hp; i++)
                    {
                        monster.hp -= totalDamage;
                        Console.WriteLine($"몬스터 남은 체력 : {monster.hp - totalDamage}");
                    }
                    curState = State.Kill;
                }

            }
            else if (curState == State.Kill)
            {
                game.player.Gold += monster.gold;
                game.player.Exp += monster.exp;
                if (game.player.Exp >= game.player.MaxExp)
                {
                    game.player.Level += 1;
                    game.player.Exp = game.player.Exp - game.player.MaxExp;

                    game.player.MaxHP += 100;
                    game.player.CurHP = game.player.MaxHP;

                    game.player.Str += 5;
                }

                game.ChangeScene(SceneType.Town);
            }
        }
    }
}

