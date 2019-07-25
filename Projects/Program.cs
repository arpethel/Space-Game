using System;

namespace Projects
{
    class MainClass
    {
        // Game Loop variable
        //public static bool truther = true;

        // User position on screen
        //public static int xPos = 35;
        //public static int yPos = 39;

        // Used to create random x position for the enemies
        public static Random rand = new Random();


        //public static int xPosEn;
        //public static int yPosEn = 2;

        public static int bullXpos;
        public static int bullYpos;

        public static void Main(string[] args)
        {
            //Sets the default console window height and width
            Console.WindowHeight = 42;
            Console.WindowWidth = 75;

            //game loop for all methods needed in this program
            do
            {

                Enemy.xPosEn = rand.Next(69);  //gets random number for position of the enemy
                FieldDisplay.DisplaySetup(); // sets up the screen for the player
                Enemy.EnemyMaker();
                User.UserControl(); // gets the users input and prints the users character and the enemy
                Shooter();

            } while (FieldDisplay.truther);



            //SpaceShip.shipLocation = new string[24, 9];
            //SpaceShip.view();
            //User.UserControl();

        }
    }
}
