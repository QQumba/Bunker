using System.Collections.Generic;

namespace Bunker.Environment.Events
{
    public class EventProvider
    {
        private readonly List<Action> _availableActions;

        public EventProvider(List<Action> availableActions)
        {
            _availableActions = availableActions;
        }
        
        
    }
}