using System;
namespace Projects
{
    public class SpaceShip
    {

        public static int xAxis = 9;
        public static string name = "Maverick";
        public static string[,] shipLocation = new string[24, xAxis];

        public static void view()
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

        // SHIP MOVEMENT

        public void moveRight()
        {
            ++xAxis;
        }

        public void moveLeft()
        {
            --xAxis;
        }
    }
}
