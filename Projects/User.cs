using System;
namespace Projects
{
    public class User
    {
        public static ConsoleKeyInfo userKey;
        public static string userMove;
        public static bool truther = true;

        public static void UserControl()
        {
            while (truther)
            {
                userKey = Console.ReadKey();

                Console.WriteLine(userKey.Key.ToString());
                userMove = userKey.Key.ToString();

                switch (userMove)
                {
                    case "RightArrow":
                        Console.WriteLine("User hit the right arrow");
                        SpaceShip.moveRight();
                        break;
                    case "LeftArrow":
                        Console.WriteLine("User hit the left arrow");
                        SpaceShip.moveLeft();
                        break;
                    case "SpaceBar":
                        Console.WriteLine("User hit the SpaceBar");
                        SpaceShip.shoot();
                        break;
                    case "Escape":
                        Console.WriteLine("User Quit");
                        truther = false;
                        break;
                    default:
                        Console.WriteLine("Unrecognized key press");
                        break;
                }
            }
        }
    }
}
