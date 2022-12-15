using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DeadArena
{
    public class Warrior : AbstractPlayer
    {
        public Warrior(double mana, double armor) : base(mana, armor)
        {
            _weapon.TypeWeapon = TypeWeapon.Heavy;
        }

        public override void Attack(AbstractPlayer enemy)
        {
            enemy.Defense(_weapon.LevelAtack);
        }

        public override void Defense(double damage)
        {
            this.Health -= damage / this.Armor;
        }

        public override void Info()
        {
            Console.WriteLine("Воин");
            Console.WriteLine($"Здоровье: {this.Health}\n" +
    $"Мана: {this.Mana}\nЗащита: {this.Armor}");
        }

        public override void MagicAttack(AbstractPlayer enemy)
        {
            enemy.Defense(Mana * 0.1);
        }
    }
}
