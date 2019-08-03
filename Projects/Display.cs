using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceGame
{
    static class Display
    {
        public const int xSize = 10, ySize = 20;

        public static char[,] charDisplay = new char[ySize, xSize];
        private static string display = "";
        public static List<SpaceObject> spaceObjects = new List<SpaceObject>();
        public static List<SpaceObject> spaceObjectsToRemove = new List<SpaceObject>();
        public static Random r = new Random();
        public static int Score = 0;
        public static int Lives = 0;

        public static void AddSpaceObject(SpaceObject so)
        {
            spaceObjects.Insert(0, so);
        }

        public static List<SpaceObject> GetSpaceObjects(SpaceObjectType objectType)
        {
            return spaceObjects.Where(so => so.ObjectType == objectType).ToList();
        }


        public static SpaceShip GetSpaceShip()
        {
            return spaceObjects.Where(so => so.ObjectType == SpaceObjectType.SpaceShip).First() as SpaceShip;
        }

        public static void IncrementSpaceObjects()
        {
            foreach (SpaceObject so in spaceObjects)
            {
                switch (so.ObjectType)
                {
                    default:
                        so.Increment();
                        break;
                    case SpaceObjectType.Enemy:
                        ((Enemy)so).Increment();
                        break;
                    case SpaceObjectType.Bullet:
                        ((Bullet)so).Increment();
                        break;
                    case SpaceObjectType.SpaceShip:
                        ((SpaceShip)so).Increment();
                        break;
                }
            }

            if (r.NextDouble() > 0.7)
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

            foreach (SpaceObject so in spaceObjects)
            {
                if (so.DisposeFlag == true)
                {
                    spaceObjectsToRemove.Add(so);
                    continue;
                }
                charDisplay[so.YPos, so.XPos] = so.Symbol;
            }



            foreach (SpaceObject so in spaceObjectsToRemove)
            {
                spaceObjects.Remove(so);
            }

            spaceObjectsToRemove.Clear();
        }

        public static void PrintDisplay()
        {
            display = "\n";
            for (int i = 0; i < ySize; i++)
            {
                for (int j = 0; j < xSize; j++)
                {
                    display += charDisplay[i, j];
                }
                display += "\n";
            }
            display += "\n";
            display += "Score: " + Score;
            display += "\n";
            display += "Lives: " + Lives;
            if (Lives == 0)
            {
                display += "\n";
                display += "GAME OVER\nPress n to play again";
            }
            Console.Clear();
            Console.WriteLine(display);
        }
    }
}
