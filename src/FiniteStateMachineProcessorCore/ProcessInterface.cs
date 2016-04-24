using FiniteStateMachineProcessorCore.StateMachine;

namespace FiniteStateMachineProcessorCore
{
    public interface ProcessInterface
    {
        void Intialize();
        StateMachineEventResult TriggerEvent();
        StateMachineEventResult Start();
        StateMachineEventResult Stop();
        StateMachineEventResult Resume();
        StateMachineEventResult Finish();
        StateMachineEventResult Input(dynamic input);
    }
}