using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceGame
{
    class SpaceObject
    {
        public int XPos { get; set; }
        public int YPos { get; set; }
        public int XVel { get; set; }
        public int YVel { get; set; }
        public char Symbol { get; set; }
        public SpaceObjectType ObjectType { get; set; }
        public bool DisposeFlag { get; set; }

        public void Increment()
        {
            XPos += XVel;
            YPos += YVel;
        }
    }
}
