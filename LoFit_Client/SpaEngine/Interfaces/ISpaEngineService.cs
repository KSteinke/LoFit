using LoFit_Client.Pages;
using LoFit_Models.Dtos;

namespace LoFit_Client.SpaEngine.Interfaces;

public interface ISpaEngineService
{
    IEnumerable<TrainingSetDto> TrainingSetDtos {get; set;}
    TrainingSetDetailsDto TrainingSetDetailsDto{get; set;}
    void TransitionTo(SpaEngineState newSpaState);
    SpaEngineStatesEnum GetCurrentStateName();
    Task StartTraining();
    void AddNewTrainingSet();
    Task SaveNewTraining(TrainingSetDto newTrainingSetDto);
    Task StartTrainingSet();
    void FinishTraining();
    void ReturnToInit();
}