using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceGame
{
    class Enemy : SpaceObject
    {
        public Enemy()
        {
            this.XPos = Display.rand.Next(Display.xSize - 2) + 1;
            this.YPos = 1;
            this.XVel = 0;
            this.YVel = 1;
            this.Symbol = 'V';
            this.ObjectType = SpaceObjectType.Enemy;
            this.DisposeFlag = false;
        }


        public new void Increment()
        {
            XPos += XVel;
            YPos += YVel;
            if (YPos > Display.ySize - 1)
            {
                DisposeFlag = true;
                Display.GetSpaceShip().DisposeFlag = true;
            }

            List<SpaceObject> bullets = Display.GetSpaceObjects(SpaceObjectType.Bullet);
            if (bullets == null)
                return;
            foreach (Bullet b in bullets)
            {
                if (this.XPos == b.XPos && this.YPos == b.YPos)
                {
                    this.DisposeFlag = true;
                    b.DisposeFlag = true;
                    Display.Score++;
                }
            }
        }
    }
}
