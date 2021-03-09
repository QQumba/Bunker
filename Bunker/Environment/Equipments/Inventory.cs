using System.Collections.Generic;

namespace Bunker.Environment.Equipments
{
    public class Inventory
    {
        private readonly List<Equipment> _equipments;

        public Inventory(List<Equipment> equipments)
        {
            _equipments = equipments;
        }
    }
}