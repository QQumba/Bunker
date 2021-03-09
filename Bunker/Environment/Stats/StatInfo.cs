using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Bunker.Environment.Stats
{
    public class StatInfo
    {
        public StatInfo(StatType statType, int baseMaxValue = 100, int baseMinValue = 0, int baseValueChangeRate = 0)
        {
            StatType = statType;
            BaseMaxValue = baseMaxValue;
            BaseMinValue = baseMinValue;
            BaseValueChangeRate = baseValueChangeRate;
        }

        [JsonConverter(typeof(StringEnumConverter))]
        public StatType StatType { get; }
        public int BaseMaxValue { get; }
        public int BaseMinValue { get; }
        public int BaseValueChangeRate { get; }

        public Stat GetStat()
        {
            return new Stat(BaseMaxValue, BaseMinValue, BaseMaxValue, BaseValueChangeRate, this);
        }
    }
}