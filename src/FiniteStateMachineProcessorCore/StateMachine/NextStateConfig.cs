namespace FiniteStateMachineProcessorCore.StateMachine
{
    public class NextStateConfig
    {
        public bool onEvent { get; set; }
        public string eventName { get; set; }
        public string actionName { get; set; }
     }
}