using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype
{
    public class Monster : IPrototype<Monster>
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public MonsterStats Stats { get; set; }
        
        public Monster(string name, string color, MonsterStats stats)
        {
            Name = name;
            Color = color;
            Stats = stats;
        }

        public Monster Clone()
        {
            return (Monster)this.MemberwiseClone();
        }

        public Monster DeepClone()
        {
            Monster cloneMonster = (Monster)this.MemberwiseClone();
            cloneMonster.Stats = new MonsterStats(this.Stats.Health, this.Stats.Attack);

            return cloneMonster;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"[{Name}] Color: {Color} | Health: {Stats.Health} | Attack: {Stats.Attack}");
        }
    }
}
