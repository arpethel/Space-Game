using System;

namespace Projects
{
    class MainClass
    {
        public static int BufferHeight { get; set; }

        static void Spaceship()
        {
            String[] Ship;
            Ship = new string[]
            {
                "   _ ^ _   ",
                "<<||ooo||>>",
                "  ||ooo||  ",
                "    ---    ",
                "    VvV    "
            };

            foreach (string shipPart in Ship)
            {
                Console.WriteLine($"{shipPart}");
            }
        }

        

        public static void Main(string[] args)
        {
            Spaceship();

            Console.WriteLine("The current buffer height is {0} rows.", Console.BufferHeight);
            Console.WriteLine("The current buffer width is {0} columns.", Console.BufferWidth);
        }
    }
}
