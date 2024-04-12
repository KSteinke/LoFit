namespace LoFit_Client.SpaEngine.SpaEngineStates;

public class InitSpaEngineState : SpaEngineState
{
    public InitSpaEngineState()
    {
        SpaEngineStateName = SpaEngineStatesEnum.Init;
    }
    public override void StartTraining()
    {
        this._spaEngineService.TransitionTo(new ListTrainingsSpaEngineState());
    }
    
}