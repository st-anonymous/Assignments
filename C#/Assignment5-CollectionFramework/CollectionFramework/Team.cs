using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_CollectionFramework
{
    public class Team : IEnumerable
    {
        private List<Player> _players = new List<Player>();
        public void Add(Player player)
        {
            _players.Add(player);
        }
        public int Count
        {
            get{ return _players.Count; }
        }
        public Player this[int index]
        {
            get
            {
                return _players[index];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return new PlayerEnumerator(this);
        }
    }
}
