using System;
using System.Collections.Generic;
using FiniteStateMachineProcessorCore.StateMachine.Flow;
using FiniteStateMachineProcessorCore.StateMachine.User;

namespace FiniteStateMachineProcessorCore.StateMachine
{
    public class StateMachine
    {
        // this system defined config for state machine
        public readonly FlowContext flowContext;

        // this will give current state of user
        public UserContext userContext;

        public static void Intialize()
        {
            
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