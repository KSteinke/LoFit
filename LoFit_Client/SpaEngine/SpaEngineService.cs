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
    public TrainingSetDto TrainingSetDto { get; set; }


    public TrainingSetDetailsDto PrevTrainingSetDetailsDto{get; set;}
    public TrainingSetDetailsDto NewTrainingSetDetailsDto {get; set;}


    
    public SpaEngineService()
    {
        this.TransitionTo(new InitSpaEngineState());
    }
    public void TransitionTo(SpaEngineState newSpaState)
    {
        this.spaState = newSpaState;
        this.spaState.SetSpaEngineService(this);
    }
    public void StartTraining()
    {
        spaState.StartTraining();
    }

    public void AddNewTrainingSet()
    {
        spaState.AddNewTrainingSet();
    }

    public void SaveNewTraining()
    {
        spaState.SaveNewTraining();
    }

    public void StartTrainingSet(TrainingSetDto trainingDto)
    {
        spaState.StartTrainingSet(trainingDto);
    }

    public void SetPrevTrainingSetDetailsDto(TrainingSetDetailsDto prevTrainingSetDetailsDto)
    {
        spaState.SetPrevTrainingSetDetailsDto(prevTrainingSetDetailsDto);
    }

    public void FinishTraining(TrainingSetDetailsDto newTrainingSetDetailsDto)
    {
        spaState.FinishTraining(newTrainingSetDetailsDto);
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