using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadArena
{
    public class Team
    {
        private const double AttackDiffensePoints = 200.0;
        private AbstractPlayer[] _players;

        public double TeamHealth { get; private set; }

        public Team(AbstractPlayer first, 
            AbstractPlayer second, 
            AbstractPlayer third)
        {
            _players = new AbstractPlayer[3];
            _players[0] = first;
            _players[1] = second;
            _players[2] = third;
        }

        public void Fight(Team enemysTeam)
        {
            for (int i = 0; i < _players.Length; i++)
            {
                enemysTeam.SoloAttack(_players[i]);
            }
        }

        private void SoloAttack(AbstractPlayer abstractPlayer)
        {
            for (int i = 0; i < _players.Length; i++)
            {
                abstractPlayer.Attack(_players[i]);
            }
        }
    }
}
