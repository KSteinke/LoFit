namespace LoFit_Client.SpaEngine;
using LoFit_Client.SpaEngine.Interfaces;
using LoFit_Client.SpaEngine.SpaEngineStates;
using LoFit_Models.Dtos;


public class SpaEngineService : ISpaEngineService
{
    private SpaEngineState spaState;
    private IEnumerable<TrainingSetDto> trainingSetDtos;
    public IEnumerable<TrainingSetDto> TrainingSetDtos
    {
        get { return this.trainingSetDtos; }
        set { this.trainingSetDtos = value; }
    }
    public TrainingSetDetailsDto TrainingSetDetailsDto{get; set;}
    public TrainingSetDetailsDto TrainingSetDetailsDtoUpdated {get; set;}
    
    public SpaEngineService()
    {
        this.TransitionTo(new InitSpaEngineState());
    }
    public void TransitionTo(SpaEngineState newSpaState)
    {
        this.spaState = newSpaState;
        this.spaState.SetSpaEngineService(this);
    }
    public async Task StartTraining()
    {
        await spaState.StartTraining();
    }

    public void AddNewTrainingSet()
    {
        spaState.AddNewTrainingSet();
    }

    public async Task SaveNewTraining(TrainingSetDto newTrainingSetDto)
    {
        await spaState.SaveNewTraining(newTrainingSetDto);
    }

    public async Task StartTrainingSet()
    {
        await spaState.StartTrainingSet();
    }

    public async Task FinishTraining(TrainingSetDetailsDto trainingSetDetailsDtoUpdated)
    {
        await spaState.FinishTraining(trainingSetDetailsDtoUpdated);
    }

    public void ReturnToInit()
    {
        spaState.ReturnToInit();
    }

    public SpaEngineStatesEnum GetCurrentStateName()
    {
        return this.spaState.GetCurrentStateName();
    }
    
}