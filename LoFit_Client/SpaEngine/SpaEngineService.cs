namespace LoFit_Client.SpaEngine;
using LoFit_Client.SpaEngine.Interfaces;
using LoFit_Client.SpaEngine.SpaEngineStates;
using Microsoft.AspNetCore.Components;
using LoFit_Client.Pages;
using LoFit_Models.Dtos;

public class SpaEngineService : ISpaEngineService
{
    private SpaEngineState spaState = null;
    private List<ListTrainingsDto> listTrainingsDtos;
    public List<ListTrainingsDto> ListTrainingsDtos
    {
        get { return this.listTrainingsDtos;}
        set { this.listTrainingsDtos = value;}
    }

    
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