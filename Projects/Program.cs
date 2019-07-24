using System;

namespace Projects
{
    class MainClass
    {
        //public static int BufferHeight { get; set; }
        //public static int BufferWidth { get; set; } DO WE NEED THIS ONE?

        public static void Main(string[] args)
        {
            FieldDisplay.DisplaySetUp();
            FieldDisplay.DisplayOutput();

            SpaceShip.shipLocation = new string[24, 9];
            SpaceShip.view();
            

            //Console.WriteLine("The current buffer height is {0} rows.", Console.BufferHeight);
            //Console.WriteLine("The current buffer width is {0} columns.", Console.BufferWidth);
        }
    }
}





// Define the location of the field display
// Set the location of the spaceship at half the field display's length