namespace FiniteStateMachineProcessorCore.StateMachine
{
    public class StateMachineAction
    {
        public string ActionName { get; set; }
        public string ActionType { get; set; }
        public string ActionData { get; set; }
        public string ReturnType { get; set; }
        public StateMachineActionResult result;

        public StateMachineActionResult GetResult()
        {
            return null;
        }
    }
}