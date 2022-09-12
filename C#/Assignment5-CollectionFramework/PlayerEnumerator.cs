using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_CollectionFramework
{
    public class PlayerEnumerator : IEnumerator
    {
        private Team _team;
        private int _idx;

        public PlayerEnumerator(Team team)
        {
            _team = team;
            _idx = -1;
        }

        public Player Current => _team[_idx];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            return (++_idx < _team.Count);
        }

        public void Reset()
        {
            _idx = -1;
        }
    }
}
