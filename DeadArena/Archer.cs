using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadArena
{
    public class Archer : AbstractPlayer
    {
        public Archer(double mana, double armor) : base(mana, armor)
        {
            _weapon.TypeWeapon = TypeWeapon.Bow;
        }

        public override void Attack(AbstractPlayer enemy)
        {
            enemy.Defense(_weapon.LevelAtack * (_weapon.LevelAtack / 100));
        }

        public override void Defense(double damage)
        {
            this.Health -= damage / this.Armor;
        }

        public override void Info()
        {
            Console.WriteLine("Лучник");
            Console.WriteLine($"Здоровье: {this.Health}\n" +
    $"Мана: {this.Mana}\nЗащита: {this.Armor}");
        }

        public override void MagicAttack(AbstractPlayer enemy)
        {
            enemy.Defense(Mana * 0.1 * _weapon.LevelAtack);
        }
    }
}
