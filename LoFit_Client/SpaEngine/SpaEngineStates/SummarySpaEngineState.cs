namespace LoFit_Client.SpaEngine.SpaEngineStates;

public class SummarySpaEngineState:SpaEngineState
{
    public SummarySpaEngineState()
    {
        SpaEngineStateName = SpaEngineStatesEnum.Summary;
    }

    public override void ReturnToInit()
    {
        this.spaEngineService.TransitionTo(new InitSpaEngineState());
    }
}