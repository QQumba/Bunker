using Bunker.Environment.Commands.Base;
using Bunker.Environment.Stats;

namespace Bunker.Environment.Commands
{
    public class SetStatChangeRateCommand : Command
    {
        private readonly int _value;
        private readonly Person _person;
        private readonly StatType _type;

        public SetStatChangeRateCommand(Person person, StatType type, int value)
        {
            _person = person;
            _type = type;
            _value = value;
        }


        public override void Execute()
        {
            _person.GetStat(_type).ChangeRate = _value;
        }
    }
}