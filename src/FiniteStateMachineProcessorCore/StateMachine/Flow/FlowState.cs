using System.Collections.Generic;

namespace FiniteStateMachineProcessorCore.StateMachine.Flow
{
    public class FlowState
    {
        public Dictionary<string, dynamic> Constants { get; set; }
        public Dictionary<string, EventConfig> Events { get; set; }
        public string StateName { get; set; }

        public dynamic GetConstant(string key)
        {
            return null;
        }

        public EventConfig GetEventConfig(string eventName)
        {
            return null;
        }
    }
}