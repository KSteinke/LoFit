namespace LoFit_Client.SpaEngine.SpaEngineStates;

public class ListTrainingsSpaEngineState : SpaEngineState
{
    public ListTrainingsSpaEngineState()
    {
        SpaEngineStateName = SpaEngineStatesEnum.ListTrainings;
    }

    public override void AddNewTrainingSet()
    {
        this.spaEngineService.TransitionTo(new AddTrainingSpaEngineState());
    }

    public override void StartTrainingSet()
    {
        this.spaEngineService.TransitionTo(new TrainingSpaEngineState());
    }
}