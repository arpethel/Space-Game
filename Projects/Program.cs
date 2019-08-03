using System;

namespace SpaceGame
{
    public enum SpaceObjectType { SpaceShip, Enemy, Bullet }

    class Program
    {

        static void Main(string[] args)
        {
            Console.WindowHeight = 52;
            Console.WindowWidth = 75;

            Display.AddSpaceObject(new SpaceShip());
            Display.AddSpaceObject(new Enemy());
            Display.InitializeDisplay();
            Display.PrintDisplay();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    switch (Console.ReadKey(true).Key)
                    {
                        case (ConsoleKey.LeftArrow):
                            Display.GetSpaceShip().MoveLeft();
                            break;
                        case (ConsoleKey.RightArrow):
                            Display.GetSpaceShip().MoveRight(); ;
                            break;
                        case (ConsoleKey.Spacebar):
                            Display.GetSpaceShip().Shoot();
                            break;
                        case (ConsoleKey.Y):
                            Display.Lives = 3;
                            Display.Score = 0;
                            Display.spaceObjects.Clear();
                            Display.AddSpaceObject(new SpaceShip());
                            break;
                        case (ConsoleKey.Escape):
                            return;
                        default:
                            break;
                    }
                    if (Display.Lives > 0)
                    {
                        Display.IncrementSpaceObjects();
                        Display.InitializeDisplay();
                        Display.PrintDisplay();
                    }
                }
            }
        }
    }
}
