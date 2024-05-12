using LoFit_Client.SpaEngine.Interfaces;
using Microsoft.AspNetCore.Components;
using LoFit_Client.Pages;
using LoFit_Client.SpaEngine.SpaEngineStates;
using LoFit_Models.Dtos;


namespace LoFit_Client.SpaEngine;

public abstract class SpaEngineState
{
    protected ISpaEngineService spaEngineService;
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

    public virtual void StartTraining()
    { /* Empty Default Implementation */ }                     

    public virtual void AddNewTrainingSet()
    { /* Empty Default Implementation */ }
    
    public virtual void SaveNewTraining(TrainingSetDto newTrainingSetDto)
    { /* Empty Default Implementation */ }
    
    public virtual void StartTrainingSet()
    { /* Empty Default Implementation */ }
    public virtual void FinishTraining()
    { /* Empty Default Implementation */ }
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