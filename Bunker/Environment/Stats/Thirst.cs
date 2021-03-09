namespace Bunker.Environment.Stats
{
    public class Thirst : Stat
    {
        public const int BaseMinThirst = 0;
        public const int BaseMaxThirst = 100;
        public const int BaseThirstChangeRate = 0;
        
        public Thirst(int currentThirst,
            int minThirst = BaseMinThirst,
            int maxThirst = BaseMaxThirst,
            int thirstChangeRate = BaseThirstChangeRate) 
            : base(currentThirst, minThirst, maxThirst, thirstChangeRate) { } 
    }
}