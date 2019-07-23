using System;

namespace Projects
{
    class MainClass
    {
        static char[,] screen = new char[9, 9];
        static string display = "";
        static int critterX = 4;
        static int shipX = 4;


        static void ViewDisplay()
        {

            Console.Clear();
        }



        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
