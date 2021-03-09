namespace Bunker.Environment.Equipments
{
    public class Equipment
    {
        public Equipment(EquipmentType equipmentType)
        {
            EquipmentType = equipmentType;
        }

        public EquipmentType EquipmentType { get; }
        public int Amount { get; set; }
    }
}