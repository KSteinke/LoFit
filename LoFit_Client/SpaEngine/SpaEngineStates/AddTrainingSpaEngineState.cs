namespace LoFit_Client.SpaEngine.SpaEngineStates;

public class AddTrainingSpaEngineState:SpaEngineState
{
    public AddTrainingSpaEngineState()
    {
        SpaEngineStateName = SpaEngineStatesEnum.AddTraining;
    }

    public override void SaveNewTraining()
    {
        this.spaEngineService.TransitionTo(new ListTrainingsSpaEngineState());
    }
}