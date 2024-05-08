namespace LoFit_Client.SpaEngine;
using LoFit_Client.SpaEngine.Interfaces;
using LoFit_Client.SpaEngine.SpaEngineStates;
using Microsoft.AspNetCore.Components;
using LoFit_Client.Pages;
using LoFit_Models.Dtos;
using LoFit_Models.MockupData;

public class SpaEngineService : ISpaEngineService
{
    private SpaEngineState spaState;
    private IEnumerable<TrainingSetDto> trainingSetDtos;
    public IEnumerable<TrainingSetDto> TrainingSetDtos
    {
        get { return this.trainingSetDtos;}
        set { this.trainingSetDtos = value;}
    }

    public TrainingSetDetailsDto trainingSetDetailsDto { get; set; }
    
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
        TrainingSetDtos = await MockupData.MockUpListTrainingsAsync();
        spaState.StartTraining();
    }

    public void AddNewTrainingSet()
    {
        spaState.AddNewTrainingSet();
    }

    public async Task SaveNewTraining()
    {
        spaState.SaveNewTraining();
        TrainingSetDtos = await MockupData.MockUpListTrainingsAsync();
    }

    public void StartTrainingSet()
    {
        spaState.StartTrainingSet();
    }

    public void FinishTraining()
    {
        spaState.FinishTraining();
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