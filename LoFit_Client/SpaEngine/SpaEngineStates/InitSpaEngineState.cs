namespace LoFit_Client.SpaEngine.SpaEngineStates;

public class InitSpaEngineState : SpaEngineState
{
    public InitSpaEngineState()
    {
        SpaEngineStateName = SpaEngineStatesEnum.Init;
    }
    public override void StartTraining()
    {
        this.spaEngineService.TransitionTo(new ListTrainingsSpaEngineState());
    }
    
}