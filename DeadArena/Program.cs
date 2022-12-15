
using DeadArena;
class Program
{
    static void Main()
    {
        AbstractPlayer player11 = new Warrior(10, 50);
        AbstractPlayer player12 = new Archer(30, 30);
        AbstractPlayer player13 = new Warrior(50, 10);
        Team first = new Team(player11, player12, player13);

        AbstractPlayer player21 = new Warrior(10, 50);
        AbstractPlayer player22 = new Archer(30, 30);
        AbstractPlayer player23 = new Wizard(50, 10);
        Team second = new Team(player21, player22, player23);

        Arena arena = new Arena(first, second);
        arena.Fight();


    }
}