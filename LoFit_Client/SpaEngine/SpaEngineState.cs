using LoFit_Client.SpaEngine.Interfaces;
using Microsoft.AspNetCore.Components;
using LoFit_Client.Pages;
using LoFit_Client.SpaEngine.SpaEngineStates;
using LoFit_Models.Dtos;


namespace LoFit_Client.SpaEngine;

public abstract class SpaEngineState
{
    protected ISpaEngineService spaEngineService = new SpaEngineService();
    public SpaEngineStatesEnum spaEngineStateName;
    public SpaEngineStatesEnum SpaEngineStateName 
    {
        get{return spaEngineStateName;} 
        set{spaEngineStateName = value;}
    }
    public void SetSpaEngineService(ISpaEngineService spaEngineService)
    {
        this.spaEngineService = spaEngineService;
    }   

    public virtual async Task StartTraining()
    { 
        /* Empty Default Implementation */ 
        await Task.CompletedTask;
    }                     

    public virtual void AddNewTrainingSet()
    { /* Empty Default Implementation */ }
    
    public virtual async Task SaveNewTraining(TrainingSetDto newTrainingSetDto)
    { 
        /* Empty Default Implementation */
        await Task.CompletedTask; 
    }
    
    public virtual async Task StartTrainingSet()
    { 
        /* Empty Default Implementation */ 
        await Task.CompletedTask;
    }
    public virtual async Task FinishTraining()
    { 
        /* Empty Default Implementation */ 
        await Task.CompletedTask;
    }
    public virtual void ReturnToInit()
    { /* Empty Default Implementation */ }
    
    public SpaEngineStatesEnum GetCurrentStateName()
    {
        return this.spaEngineStateName;
    }
}

public enum SpaEngineStatesEnum
{
    Init,
    ListTrainings,
    Training,
    AddTraining,
    Summary
}