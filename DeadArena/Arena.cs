using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadArena
{
    public class Arena
    {
        Team _first;
        Team _second;
        public Arena(Team first, Team second) { 
            _first = first;
            _second = second;
        }

        public void Fight()
        {
            while (_first.TeamHealth > 0 && _second.TeamHealth > 0)
            {
                _first.Fight(_second);
                _second.Fight(_first);
            }

            if (_first.TeamHealth > 0)
                Console.WriteLine("Выйграла первая команда!");
            else
                Console.WriteLine("Выйграла вторая команда!");

        }
    }
}
