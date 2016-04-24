using System.Collections.Generic;

namespace FiniteStateMachineProcessorCore.StateMachine.Flow
{
    public class FlowContext
    {
        public List<FlowState> States { get; set; }
        public Dictionary<string, ProcessEventConfig> ProcessEvents { get; set; }
        public Dictionary<string, FlowAction> Actions { get; set; }
        public Dictionary<string, dynamic> Constants { get; set; }

        public static void Intialize()
        {

        }

        public dynamic GetStateConstant(string stateName, string key)
        {
            return null;
        }

        public dynamic GetGlobalConstant(string key)
        {
            return null;
        }

        public EventConfig GetStateEventConfig(string stateName, string eventName)
        {
            return null;
        }

        public ProcessEventConfig GetProccessEventConfig(string eventName)
        {
            return null;
        }

        public FlowAction GetAction(string actionName)
        {
            return null;
        }
    }
}