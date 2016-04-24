using System;
using System.Collections.Generic;

namespace FiniteStateMachineProcessorCore.StateMachine.User
{
    public class UserContext
    {
        public Dictionary<string, UserState> States { get; set; }
        public Dictionary<string, dynamic> Constants { get; set; }
        public Dictionary<string, ProcessEventConfig> ProcessEvents { get; set; }
        public List<UserState> stateflow;
        public UserState currentState;

        public static void Intialize()
        {

        }

        public UserContext()
        {
            stateflow = new List<UserState>();
        }

        public bool IsStateCompleted(string stateName)
        {
            return false;
        }

        public string GetCurrentStateName()
        {
            return "";
        }

        public void SetInput(string stateName, dynamic input)
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

        public void SetGlobalConstant(string key, dynamic value)
        {
            
        }

        public EventConfig GetStateEventConfig(string stateName, string eventName)
        {
            return null;
        }

        public ProcessEventConfig GetProccessEventConfig(string eventName)
        {
            return null;
        }

        public dynamic GetInput(string stateName)
        {
            return null;
        }

        public void SetStateEventOutput(string stateName, StateMachineEventResult eventResult)
        {
            
        }

        public void SetProcessEventOutput(StateMachineEventResult eventResult)
        {

        }

        public StateMachineEventResult GetStateEventOutput(string stateName, string eventName)
        {
            return null;
        }

        public StateMachineEventResult GetProcessEventOutput(string eventName)
        {
            return null;
        }
    }
}