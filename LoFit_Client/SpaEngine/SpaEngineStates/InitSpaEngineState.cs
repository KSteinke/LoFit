using LoFit_Models.MockupData;

namespace LoFit_Client.SpaEngine.SpaEngineStates;

public class InitSpaEngineState : SpaEngineState
{
    public InitSpaEngineState()
    {
        SpaEngineStateName = SpaEngineStatesEnum.Init;
    }
    public override async Task StartTraining()
    {
        this.spaEngineService.TrainingSetDtos = await MockupData.MockUpListTrainingsAsync();
        this.spaEngineService.TransitionTo(new ListTrainingsSpaEngineState());
        await Task.CompletedTask;
    }
    
}