namespace Bunker.Environment.Stats
{
    public class Health : Stat
    {
        public const int BaseMinHealth = 0;
        public const int BaseMaxHealth = 100;
        public const int BaseHealthChangeRate = 0;

        public Health(int currentHealth,
            int minHealth = BaseMinHealth,
            int maxHealth = BaseMaxHealth,
            int healthChangeRate = BaseHealthChangeRate) 
            : base(currentHealth, minHealth, maxHealth, healthChangeRate) { }
    }
}