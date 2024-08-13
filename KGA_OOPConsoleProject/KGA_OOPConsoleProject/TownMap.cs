using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSlave
{
    public class TownMap
    {
        public class moveData
        {
            public bool[,] map;
            public ConsoleKey inputKey;
            public Point playerPos;
            public Point minePos;
            public Point shopPos;
            public Point campPos;
            public Point gamblingPos;
        }
        public static moveData data;

        public static void PrintMap()
        {
            for (int y = 0; y < data.map.GetLength(0); y++)
            {
                for (int x = 0; x < data.map.GetLength(1); x++)
                {
                    if (data.map[y, x])
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("■■■");
                    }
                }
                Console.WriteLine();
            }
        }

        public static void PrintPlayer()
        {
            Console.SetCursorPosition(data.playerPos.x, data.playerPos.y);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("P");
            Console.ResetColor();
        }

        public static void PrintMine()
        {
            Console.SetCursorPosition(data.minePos.x, data.minePos.y);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("광  산");
            Console.ResetColor();
        }

        public static void PrintShop()
        {
            Console.SetCursorPosition(data.shopPos.x, data.shopPos.y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("상  점");
            Console.ResetColor();
        }

        public static void PrintCamp()
        {
            Console.SetCursorPosition(data.campPos.x, data.campPos.y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("캠  프");
            Console.ResetColor();
        }

        public static void PrintGambling()
        {
            Console.SetCursorPosition(data.gamblingPos.x, data.gamblingPos.y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("도박장");
            Console.ResetColor();
        }

        public class Point
        {
            public int x;
            public int y;
        }

        static void Move()
        {
            switch (data.inputKey)
            {
                case ConsoleKey.W:
                case ConsoleKey.UpArrow:
                    MoveUp();
                    break;
                case ConsoleKey.S:
                case ConsoleKey.DownArrow:
                    MoveDown();
                    break;
                case ConsoleKey.A:
                case ConsoleKey.LeftArrow:
                    MoveLeft();
                    break;
                case ConsoleKey.D:
                case ConsoleKey.RightArrow:
                    MoveRight();
                    break;
            }
        }

        static void MoveUp()
        {
            Point next = new Point() { x = data.playerPos.x, y = data.playerPos.y - 2 };
            if (data.map[next.y, next.x])
            {
                data.playerPos = next;
            }
        }

        static void MoveDown()
        {
            Point next = new Point() { x = data.playerPos.x, y = data.playerPos.y + 2 };
            if (data.map[next.y, next.x])
            {
                data.playerPos = next;
            }
        }

        static void MoveLeft()
        {
            Point next = new Point() { x = data.playerPos.x - 2, y = data.playerPos.y };
            if (data.map[next.y, next.x])
            {
                data.playerPos = next;
            }
        }

        static void MoveRight()
        {
            Point next = new Point() { x = data.playerPos.x + 2, y = data.playerPos.y };
            if (data.map[next.y, next.x])
            {
                data.playerPos = next;
            }
        }
    }
}
