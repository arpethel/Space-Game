using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceGame
{
    class Bullet : SpaceObject
    {
        public Bullet()
        {
            this.XPos = Display.GetSpaceShip().XPos;
            this.YPos = Display.ySize - 1;
            this.XVel = 0;
            this.YVel = -1;
            this.Symbol = ':';
            this.ObjectType = SpaceObjectType.Bullet;
            this.DisposeFlag = false;
        }

        public new void Increment()
        {
            YPos += YVel;
            if (YPos < 1)
            {
                DisposeFlag = true;
            }

            List<SpaceObject> enemies = Display.GetSpaceObjects(SpaceObjectType.Enemy);
            if (enemies == null)
                return;
            foreach (Enemy e in enemies)
            {
                if (this.XPos == e.XPos && this.YPos == e.YPos)
                {
                    this.DisposeFlag = true;
                    e.DisposeFlag = true;
                    Display.Score++;
                }
            }
        }
    }
}
