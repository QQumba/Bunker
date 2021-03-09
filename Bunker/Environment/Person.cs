using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using Bunker.Environment.Stats;

namespace Bunker.Environment
{
    public class Person
    {
        private readonly List<Stat> _stats;
        
        public Person(string name)
        {
            Name = name;
            Health = new Health(Health.MaxValue);
            Hunger = new Hunger(Hunger.MaxValue);
            Thirst = new Thirst(Thirst.MaxValue);

            _stats = new List<Stat> { Health, Hunger, Thirst };
        }
        
        public Stat Health { get; set; }
        public Stat Hunger { get; set; }
        public Stat Thirst { get; set; }
        public string Name { get; }
        
        
        public void Update()
        {
            foreach (var stat in _stats)
            {
                stat.Update();
            }
        }
    }
}