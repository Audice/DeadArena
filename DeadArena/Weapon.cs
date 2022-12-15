using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadArena
{
    public enum TypeWeapon { Magic, Heavy, Bow }
    public enum Quality { New, Shabby, Old }
    public class Weapon
    {
        private const double MAX_ATTACK = 100.0;
        public TypeWeapon TypeWeapon { get; set; }
        private Quality _quality;
        public double LevelAtack { get; private set; }

        public Weapon(double luckylevel)
        {
            if (luckylevel <= 30.0)
                _quality = Quality.Old;
            if (luckylevel <= 60.0 && luckylevel > 30.0)
                _quality = Quality.Shabby;
            if (luckylevel > 60.0)
                _quality = Quality.New;

            switch (_quality)
            {
                case Quality.New:
                    LevelAtack = MAX_ATTACK;
                    break;
                case Quality.Old:
                    LevelAtack = MAX_ATTACK / 5;
                    break;
                case Quality.Shabby:
                    LevelAtack = MAX_ATTACK / 2;
                    break;
            }
        }

    }
}
