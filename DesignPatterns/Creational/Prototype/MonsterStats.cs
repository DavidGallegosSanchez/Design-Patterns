using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype
{
    public class MonsterStats
    {
        public int Health { get; set; }
        public int Attack { get; set; }

        public MonsterStats(int health, int attack)
        {
            this.Health = health;
            this.Attack = attack;
        }
    }
}
