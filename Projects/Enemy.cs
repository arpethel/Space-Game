using System;
namespace Projects
{
    public class Enemy
    {
        public static int xPosEn;
        public static int yPosEn = 2;

        public static void EnemyMaker()
        {
            Console.SetCursorPosition(xPosEn, yPosEn);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("V");
        }
    }
}
