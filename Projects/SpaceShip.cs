using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceGame
{
    class SpaceShip : SpaceObject
    {
        public SpaceShip()
        {
            this.XPos = Display.xSize / 2;
            this.YPos = Display.ySize - 1;
            this.XVel = 0;
            this.YVel = 0;
            this.Symbol = '^';
            this.ObjectType = SpaceObjectType.SpaceShip;
            this.DisposeFlag = false;
        }

        public void Shoot()
        {
            Display.AddSpaceObject(new Bullet());
        }

        public void MoveRight()
        {
            XVel = +1;
        }

        public void MoveLeft()
        {
            XVel = -1;
        }

        public new void Increment()
        {
            XPos += XVel;
            if (XPos == 0)
                XPos++;
            if (XPos == Display.xSize - 1)
                XPos--;
            XVel = 0;

            List<SpaceObject> enemies = Display.GetSpaceObjects(SpaceObjectType.Enemy);
            if (enemies == null)
                return;
            foreach (Enemy e in enemies)
            {
                if (this.XPos == e.XPos && this.YPos == e.YPos)
                {
                    this.DisposeFlag = true;
                    e.DisposeFlag = true;
                }
            }
        }
    }
}
