using System.Collections.Generic;

namespace FiniteStateMachineProcessorCore.StateMachine
{
    public class StateMachineEventResult
    {
        public List<StateMachineActionResult> actionResults;
        public bool isSuccessful;
        public dynamic result;
    }
}