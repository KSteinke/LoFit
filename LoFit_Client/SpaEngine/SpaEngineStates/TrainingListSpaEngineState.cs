using LoFit_Models.MockupData;

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
        //this.spaEngineService.TrainingSetDetailsDto = await MockupData.GetTrainingSetDetailsDto();
        this.spaEngineService.TransitionTo(new TrainingSpaEngineState());
    }
}