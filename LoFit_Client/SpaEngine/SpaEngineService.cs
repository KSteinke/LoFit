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
    public void StartTraining()
    {
        spaState.StartTraining();
    }

    public void AddNewTrainingSet()
    {
        spaState.AddNewTrainingSet();
    }

    public void SaveNewTraining(TrainingSetDto newTrainingSetDto)
    {
        spaState.SaveNewTraining(newTrainingSetDto);
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