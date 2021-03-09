using System.Collections.Generic;
using System.Linq;
using Bunker.Environment.Stats;

namespace Bunker.Environment
{
    public class PersonStats
    {
        private readonly List<Stat> _stats;

        public PersonStats(List<Stat> stats)
        {
            _stats = stats;
        }

        public Stat GetStat(StatType type)
        {
            return _stats.First(s => s.Info.StatType == type);
        }

        public void Update()
        {
            foreach (var stat in _stats)
            {
                stat.Update();
            }
        }
    }
}