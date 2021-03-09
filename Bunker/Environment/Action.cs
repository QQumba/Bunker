using Bunker.Environment.Commands;
using Bunker.Environment.Commands.Base;
using Bunker.Environment.Equipments;

namespace Bunker.Environment
{
    public class Action
    {
        private EquipmentType _equipmentType;
        private int _equipmentAmount;
        private Command _command;

        public Action(EquipmentType equipmentType, int equipmentAmount, Command command)
        {
            _equipmentType = equipmentType;
            _equipmentAmount = equipmentAmount;
            _command = command;
        }
    }
}