namespace LoFit_Client.SpaEngine.SpaEngineStates;

public class TrainingSpaEngineState:SpaEngineState
{
    public TrainingSpaEngineState()
    {
        SpaEngineStateName = SpaEngineStatesEnum.Training;
    }

    public override async Task FinishTraining()
    {
        this.spaEngineService.TransitionTo(new SummarySpaEngineState());
        await Task.CompletedTask;
    }
}