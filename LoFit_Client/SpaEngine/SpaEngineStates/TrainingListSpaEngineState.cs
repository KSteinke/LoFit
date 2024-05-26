using LoFit_Models.Dtos;

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

    public override void StartTrainingSet(TrainingSetDto trainingDto)
    {
        //TODO - add null handling
        this.spaEngineService.TrainingSetDto = trainingDto;
        this.spaEngineService.TransitionTo(new TrainingSpaEngineState());
    }
}