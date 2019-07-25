using System;
namespace Projects
{
    public class User
    {
        public static void UserControl()
        {
            do
            {
                Boundries(); // sets the boundries for the user and checks if the enemy made it to the bottom

                ConsoleKey command = Console.ReadKey().Key;
                switch (command)
                {
                    case ConsoleKey.LeftArrow:
                        Console.SetCursorPosition(FieldDisplay.xPos, FieldDisplay.yPos);
                        Console.Write(" ");
                        FieldDisplay.xPos--;
                        Console.SetCursorPosition(Enemy.xPosEn, Enemy.yPosEn);
                        Console.Write(" ");
                        Enemy.yPosEn++;
                        break;
                    case ConsoleKey.RightArrow:
                        Console.SetCursorPosition(FieldDisplay.xPos, FieldDisplay.yPos);
                        Console.Write(" ");
                        FieldDisplay.xPos++;
                        Console.SetCursorPosition(Enemy.xPosEn, Enemy.yPosEn);
                        Console.Write(" ");
                        Enemy.yPosEn++;
                        break;
                    case ConsoleKey.Spacebar:

                        break;
                    case ConsoleKey.Escape:
                        FieldDisplay.truther = false;
                        break;
                }

                Enemy.EnemyMaker();



                Console.SetCursorPosition(FieldDisplay.xPos, FieldDisplay.yPos);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("^");

                Console.SetCursorPosition(bullXpos, bullYpos);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("^");

            } while (FieldDisplay.truther);

        }




        //public static void UserControl()
        //{
        //    while (truther)
        //    {
        //        userKey = Console.ReadKey();

        //        Console.WriteLine(userKey.Key.ToString());
        //        userMove = userKey.Key.ToString();

        //        switch (userMove)
        //        {
        //            case "RightArrow":
        //                Console.WriteLine("User hit the right arrow");
        //                SpaceShip.moveRight();
        //                break;
        //            case "LeftArrow":
        //                Console.WriteLine("User hit the left arrow");
        //                SpaceShip.moveLeft();
        //                break;
        //            case "SpaceBar":
        //                Console.WriteLine("User hit the SpaceBar");
        //                SpaceShip.shoot();
        //                break;
        //            case "Escape":
        //                Console.WriteLine("User Quit");
        //                truther = false;
        //                break;
        //            default:
        //                Console.WriteLine("Unrecognized key press");
        //                break;
        //        }
        //    }
        //}
    }
}
