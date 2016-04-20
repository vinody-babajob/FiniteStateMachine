using System.Collections.Generic;

namespace FiniteStateMachineProcessorCore.StateMachine
{
    public class ProcessEventConfig
    {
        public string State { get; set; }
        public List<string> Actions { get; set; } 
    }
}