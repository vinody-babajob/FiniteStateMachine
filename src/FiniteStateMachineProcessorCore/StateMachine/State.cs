using System.Collections.Generic;

namespace FiniteStateMachineProcessorCore.StateMachine
{
    /*** 
    *   Default events available for state
    *   "inputreceived" - trigger when some input is given to state
    *   "gotonextstate" -  will be triggered either based on event trigger
    *                   or when we enter the state and after finsihing start event
    ***/
    public class State
    {
        public Dictionary<string, dynamic> Constants { get; set; }
        public Dictionary<string, EventConfig> Events { get; set; }
        public string StateName { get; set; }
        public string nextStateName;

        public StateMachineEventResult TriggerEvent(string eventName)
        {
            return null;
        }

        public void GetNextState()
        {
            
        }
    }
}