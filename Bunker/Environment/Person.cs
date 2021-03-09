using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using Bunker.Environment.Stats;

namespace Bunker.Environment
{
    public class Person
    {
        private readonly PersonStats _personStats;

        private int _dayStarving;
        private bool _isDead;

        public Person(string name, PersonStats personStats)
        {
            Name = name;
            _personStats = personStats;
        }
        
        public string Name { get; }

        public int DayStarving => _dayStarving;
        public bool IsDead => _isDead;
        

        public void Update()
        {
            _personStats.Update();
            var health = GetStat(StatType.Health);

            if (GetStat(StatType.Hunger).Value < 20)
            {
                _dayStarving++;
            }
            else
            {
                _dayStarving = 0;
            }

            if (_dayStarving > 5)
            {
                health.Value -= 20;
            }
            
            if (health.Value < health.MinValue)
            {
                _isDead = true;
            }
        }

        public Stat GetStat(StatType type) => _personStats.GetStat(type);
    }
}