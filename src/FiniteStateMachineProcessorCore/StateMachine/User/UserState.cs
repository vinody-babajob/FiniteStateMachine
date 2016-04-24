using System.Collections.Generic;

namespace FiniteStateMachineProcessorCore.StateMachine.User
{
    public class UserState
    {
        public string StateName { get; set; }
        public bool Completed { get; set; }
        public Dictionary<string, dynamic> Constants { get; set; }
        public Dictionary<string, EventConfig> Events { get; set; }
        public dynamic input;

        public dynamic GetConstant()
        {
            return null;
        }

        public EventConfig GetEventConfig(string eventName)
        {
            return null;
        }
    }
}