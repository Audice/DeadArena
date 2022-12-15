using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadArena
{
    public class Wizard : AbstractPlayer
    {
        public Wizard(double mana, double armor) : base(mana, armor)
        {
            _weapon.TypeWeapon = TypeWeapon.Magic;
        }

        public override void Attack(AbstractPlayer enemy)
        {
            enemy.Defense(5);
        }

        public override void Defense(double damage)
        {
            this.Health -= damage / this.Armor 
                - this.Mana * (_luckyLevel / MAX_LUCKY_LEVEL);
        }

        public override void Info()
        {
            Console.WriteLine("Маг");
            Console.WriteLine($"Здоровье: {this.Health}\n" +
    $"Мана: {this.Mana}\nЗащита: {this.Armor}");
        }

        public override void MagicAttack(AbstractPlayer enemy)
        {
            enemy.Defense(Mana * _weapon.LevelAtack);
        }
    }
}
