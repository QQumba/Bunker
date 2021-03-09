namespace Bunker.Environment.Stats
{
    public abstract class Stat
    {
        private readonly int _maxValue;
        private readonly int _minValue;
        
        private int _value;
        private int _currentMinValue;
        private int _currentMaxValue;
        private int _changeRate;

        public Stat(int value ,int minValue, int maxValue, int changeRate)
        {
            if (value < minValue)
            {
                throw new StatArgumentException(
                    $"Stat value cannot be below min value. Current value: {value}, min value: {minValue}");
            }

            if (value > maxValue)
            {
                throw new StatArgumentException(
                    $"Stat value cannot be above max value. Current value: {value}, max value: {maxValue}");
            }
            _minValue = minValue;
            _maxValue = maxValue;
            
            _value = value;
            _currentMinValue = minValue;
            _currentMaxValue = maxValue;
            _changeRate = changeRate;
        }
        
        public int MinValue => _minValue;
        public int MaxValue => _maxValue;

        public int Value
        {
            get => _value;
            set => _value = SetBoundedValue(_value + value, _minValue, _maxValue);
        }

        public int CurrentMaxValue
        {
            get => _currentMaxValue;
            set
            {
                _currentMaxValue = SetBoundedValue(value, _minValue, _maxValue);
                if (_currentMinValue > _currentMaxValue)
                {
                    _currentMinValue = _currentMaxValue;
                }
            }
        }
        
        public int CurrentMinValue
        {
            get => _currentMinValue;
            set
            {
                _currentMinValue = SetBoundedValue(value, _minValue, _currentMaxValue);
                if (_currentMaxValue < _currentMinValue)
                {
                    _currentMaxValue = _currentMinValue;
                }
            }
        }

        public int ChangeRate
        {
            get => _changeRate;
            set => _changeRate = value;
        }
        
        
        public void Update()
        {
            Value += _changeRate;
        }

        private int SetBoundedValue(int value, int minValue, int maxValue)
        {
            if(value < minValue)
            {
                return minValue;
            }
            if(value > maxValue)
            {
                return maxValue;
            }
            return value;
        }
    }
}