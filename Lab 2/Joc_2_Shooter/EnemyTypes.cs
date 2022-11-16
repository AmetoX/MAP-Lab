using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joc_2_Shooter
{
    public class NormalZombie : Enemy
    {
        public static Image normalZombie = Image.FromFile("../../../Images/NormalZombie.png");

        public NormalZombie(int spawnTime) : base(100, 5, 20, 50, 100, spawnTime, normalZombie)
        { }

        protected override bool IsHeadShot(Point click)
        {
            return click.Y - position.Y < sizeY / 6;
        }
    }

    public class FatZombie : Enemy
    {
        public static Image fatZombie = Image.FromFile("../../../Images/FatZombie.png");

        public FatZombie(int spawnTime) : base(250, 2, 50, 100, 100, spawnTime, fatZombie)
        { }

        protected override bool IsHeadShot(Point click)
        {
            return click.Y - position.Y < sizeY / 4.62;
        }
    }
}
