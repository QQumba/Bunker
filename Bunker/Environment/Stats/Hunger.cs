namespace Bunker.Environment.Stats
{
    public class Hunger : Stat
    {
        public const int BaseMinHunger = 0;
        public const int BaseMaxHunger = 100;
        public const int BaseHungerChangeRate = 0;

        public Hunger(int currentHunger,
            int minHunger = BaseMinHunger,
            int maxHunger = BaseMaxHunger,
            int hungerChangeRate = BaseHungerChangeRate) 
            : base(currentHunger, minHunger, maxHunger, hungerChangeRate) { }
    }
}