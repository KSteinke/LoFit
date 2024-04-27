namespace LoFit_Client.SpaEngine.SpaEngineStates;

public class TrainingSpaEngineState:SpaEngineState
{
    public TrainingSpaEngineState()
    {
        SpaEngineStateName = SpaEngineStatesEnum.Training;
    }

    public override void FinishTraining()
    {
        this.spaEngineService.TransitionTo(new SummarySpaEngineState());
    }
}