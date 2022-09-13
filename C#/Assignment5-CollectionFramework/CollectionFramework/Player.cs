using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_CollectionFramework
{
    public class Player
    {
        private string Name { get; set; }
        private int Run { get; set; }
        public Player(string name, int run)
        {
            Name = name;
            Run = run;
        }
        public string Show()
        {
            return $"\n\t {this.Name}\t\t {this.Run}";
        }
    }
}
