using Bunker.Environment.Commands.Base;
using Bunker.Environment.Stats;

namespace Bunker.Environment.Commands
{
    public class ChangeStatValueCommand : Command
    {
        private readonly int _value;
        private readonly Person _person;
        private readonly StatType _type;

        public ChangeStatValueCommand(Person person, StatType type, int value)
        {
            _person = person;
            _type = type;
            _value = value;
        }
        
        public override void Execute()
        {
            _person.GetStat(_type).Value += _value;
        }
    }
}