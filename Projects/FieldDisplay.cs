using System;
namespace Projects
{
    public class FieldDisplay
    {
        public static int xPos = 35;
        public static int yPos = 39;

        public static void DisplaySetup()
        {
            Console.SetCursorPosition(xPos, yPos);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("^");

            for (int i = 1; i < 41; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(1, i);
                Console.Write("|");
                Console.SetCursorPosition(70, i);
                Console.Write("|");
            }

            for (int i = 1; i < 71; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(i, 1);
                Console.Write("*");
                Console.SetCursorPosition(i, 40);
                Console.Write("*");

            }
        }
                
    }
}
