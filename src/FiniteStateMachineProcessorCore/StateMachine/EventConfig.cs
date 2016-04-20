using System.Collections.Generic;

namespace FiniteStateMachineProcessorCore.StateMachine
{
    public class EventConfig
    {
        public List<string> Actions { get; set; }
        public bool TriggerOnEvent { get; set; }
        public string EventName { get; set; }
    }
}