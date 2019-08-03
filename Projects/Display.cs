using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceGame
{
    static class Display
    {
        public const int xSize = 73, ySize = 45;

        public static char[,] charDisplay = new char[ySize, xSize];
        private static string display = "";
        public static List<SpaceObject> spaceObjects = new List<SpaceObject>();
        public static List<SpaceObject> spaceObjectsToRemove = new List<SpaceObject>();
        public static Random rand = new Random();
        public static int Score = 0;
        public static int Lives = 0;

        public static void AddSpaceObject(SpaceObject spaceObj)
        {
            spaceObjects.Insert(0, spaceObj);
        }

        public static List<SpaceObject> GetSpaceObjects(SpaceObjectType objectType)
        {
            return spaceObjects.Where(spaceObj => spaceObj.ObjectType == objectType).ToList();
        }


        public static SpaceShip GetSpaceShip()
        {
            return spaceObjects.Where(spaceObj => spaceObj.ObjectType == SpaceObjectType.SpaceShip).First() as SpaceShip;
        }

        public static void IncrementSpaceObjects()
        {
            foreach (SpaceObject spaceObj in spaceObjects)
            {
                switch (spaceObj.ObjectType)
                {
                    default:
                        spaceObj.Increment();
                        break;
                    case SpaceObjectType.Enemy:
                        ((Enemy)spaceObj).Increment();
                        break;
                    case SpaceObjectType.Bullet:
                        ((Bullet)spaceObj).Increment();
                        break;
                    case SpaceObjectType.SpaceShip:
                        ((SpaceShip)spaceObj).Increment();
                        break;
                }
            }

            if (rand.NextDouble() > 0.7)
            {
                AddSpaceObject(new Enemy());
            }
        }

        public static void InitializeDisplay()
        {
            for (int i = 0; i < ySize; i++)
            {
                for (int j = 0; j < xSize; j++)
                {
                    charDisplay[i, j] = ' ';
                }
            }
            for (int i = 0; i < ySize; i++)
            {
                charDisplay[i, 0] = '|';
                charDisplay[i, xSize - 1] = '|';
            }
            for (int i = 0; i < xSize; i++)
            {
                charDisplay[0, i] = '-';
            }

            if (GetSpaceShip().DisposeFlag == true)
            {
                Display.Lives--;
                spaceObjects.Clear();
                AddSpaceObject(new SpaceShip());
                AddSpaceObject(new Enemy());
            }

            foreach (SpaceObject spaceObj in spaceObjects)
            {
                if (spaceObj.DisposeFlag == true)
                {
                    spaceObjectsToRemove.Add(spaceObj);
                    continue;
                }
                charDisplay[spaceObj.YPos, spaceObj.XPos] = spaceObj.Symbol;
            }



            foreach (SpaceObject spaceObj in spaceObjectsToRemove)
            {
                spaceObjects.Remove(spaceObj);
            }

            spaceObjectsToRemove.Clear();
        }

        public static void PrintGameOver()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n                                  GAME OVER");
            Console.WriteLine("                 Click ESC to exit or Y to play again");
        }

        public static void PrintDisplay()
        {
            Console.ForegroundColor = ConsoleColor.White;

            display = "\n";
            for (int i = 0; i < ySize; i++)
            {
                for (int j = 0; j < xSize; j++)
                {
                    display += charDisplay[i, j];
                }
                display += "\n";
            }
            display += "\n\n";
            display += "                          SCORE     |     LIVES\n";
            display += "                            " + Score + "               " + Lives;

            if (Lives == 0)
            {
                PrintGameOver();
            }
            Console.Clear();
            Console.WriteLine(display);
        }
    }
}
