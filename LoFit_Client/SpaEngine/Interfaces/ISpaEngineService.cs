namespace LoFit_Client.SpaEngine.Interfaces;

public interface ISpaEngineService
{
    void TransitionTo(SpaEngineState newSpaState);
    SpaEngineStatesEnum GetCurrentStateName();
    public void StartTraining();
}