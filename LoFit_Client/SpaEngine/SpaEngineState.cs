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
    
    public virtual void SaveNewTraining()
    { /* Empty Default Implementation */ }
    
    public virtual void StartTrainingSet(TrainingSetDto trainingDto)
    { /* Empty Default Implementation */ }

    public virtual void SetPrevTrainingSetDetailsDto(TrainingSetDetailsDto prevTrainingSetDetailsDto)
    {
        //TODO - Null handling 
        this.spaEngineService.PrevTrainingSetDetailsDto = prevTrainingSetDetailsDto;
        /*
        Console.WriteLine("OldFirst:");
        foreach(var x in this.spaEngineService.PrevTrainingSetDetailsDto.ExerciseDetailsDtos)
        {
            Console.WriteLine(x.Name + " " + x.PrevWeight + "kg " + "Repets:" + x.PrevRepetitions + "Time:" + x.PrevExerciseTime);
        }
        Console.WriteLine("-------------------------");
        */
    }
    public virtual void FinishTraining(TrainingSetDetailsDto newTrainingSetDetailsDto)
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