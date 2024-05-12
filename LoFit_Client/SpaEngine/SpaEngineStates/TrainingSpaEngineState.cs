using LoFit_Models.Dtos;

namespace LoFit_Client.SpaEngine.SpaEngineStates;

public class TrainingSpaEngineState:SpaEngineState
{
    public TrainingSpaEngineState()
    {
        SpaEngineStateName = SpaEngineStatesEnum.Training;
    }

    public override async Task FinishTraining(TrainingSetDetailsDto trainingSetDetailsDtoUpdated)
    {
        //TODO - POST action to store updated data
        this.spaEngineService.TrainingSetDetailsDtoUpdated = trainingSetDetailsDtoUpdated;
        this.spaEngineService.TransitionTo(new SummarySpaEngineState());
        await Task.CompletedTask;
    }
}