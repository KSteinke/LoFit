using LoFit_Models.Dtos;

namespace LoFit_Client.SpaEngine.SpaEngineStates;

public class TrainingSpaEngineState:SpaEngineState
{
    public TrainingSpaEngineState()
    {
        SpaEngineStateName = SpaEngineStatesEnum.Training;
    }

    public override void FinishTraining()
    {
        //TODO - POST action to store updated data
        this.spaEngineService.TrainingSetDetailsDtoUpdated = new TrainingSetDetailsDto();
        this.spaEngineService.TransitionTo(new SummarySpaEngineState());

    }
}