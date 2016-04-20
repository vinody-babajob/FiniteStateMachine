using System;
using System.Collections.Generic;

namespace FiniteStateMachineProcessorCore.StateMachine
{
    public class StateMachine
    {
        public List<State> States { get; set; }
        public Dictionary<string, ProcessEventConfig> ProcessEvents { get; set; }
        public Dictionary<string, StateMachineAction> Actions { get; set; } 
        public Dictionary<string, dynamic> Constants { get; set; }
        public State currentState;
        public List<State> stateflow;
        public State prevState;

        public StateMachine()
        {
            stateflow = new List<State>();
        }

        public StateMachineEventResult TriggerEvent(string eventName)
        {
            return null;
        }

        public void InputReceived(dynamic input)
        {
            
        }

        public StateMachineEventResult TriggerProcessEvent(string eventName)
        {
            StateMachineEventResult result = null;

            switch (eventName)
            {
                case ProcessEvent.start:
                    result = ProcessStartEvent();
                    break;
                case ProcessEvent.resume:
                    result = ProcessResumeEvent();
                    break;
                case ProcessEvent.pause:
                    result = ProcessPauseEvent();
                    break;
                case ProcessEvent.finish:
                    result = ProcessFinishEvent();
                    break;
                case ProcessEvent.error:
                    result = ProcessErrorEvent();
                    break;
            }

            return result;
        }

        private StateMachineActionResult TriggerAction(string actionName)
        {
            return null;
        }

        private StateMachineEventResult ProcessStartEvent()
        {
            return null;
        }

        private StateMachineEventResult ProcessPauseEvent()
        {
            return null;
        }

        private StateMachineEventResult ProcessResumeEvent()
        {
            return null;
        }

        private StateMachineEventResult ProcessFinishEvent()
        {
            return null;
        }

        private StateMachineEventResult ProcessErrorEvent()
        {
            return null;
        }
    }
}