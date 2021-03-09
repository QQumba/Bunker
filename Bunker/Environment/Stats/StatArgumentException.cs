using System;

namespace Bunker.Environment.Stats
{
    public class StatArgumentException : Exception
    {
        public StatArgumentException(string message)
            :base(message) { }
    }
}