using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadArena
{
    /// <summary>
    /// Абстрактный класс для создания игроков
    /// </summary>
    public abstract class AbstractPlayer
    {
        protected Weapon _weapon;
        protected const double MAX_HEALTH = 100.0;
        public double Health { get; protected set; }
        public double Mana { get; private set; }
        public double Armor { get; private set; }

        protected const double MAX_LUCKY_LEVEL = 100.0;
        protected double _luckyLevel;

        public AbstractPlayer(double mana, double armor)
        {
            _luckyLevel = (new Random().NextDouble()) * MAX_LUCKY_LEVEL;
            this.Mana = mana;
            this.Health = MAX_HEALTH;
            this.Armor = armor;
            this._weapon = new Weapon(_luckyLevel);
        }

        public abstract void Info();
        public abstract void Attack(AbstractPlayer enemy);
        public abstract void MagicAttack(AbstractPlayer enemy);
        public abstract void Defense(double damage);

    }
}
