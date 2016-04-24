using FiniteStateMachineProcessorCore.StateMachine.User;

namespace FiniteStateMachineProcessorCore.StateMachine.Flow
{
    public class FlowAction
    {
        public string ActionName { get; set; }
        public string ActionType { get; set; }
        public string ActionData { get; set; }
        public string ReturnType { get; set; }
    }
}