using LoFit_Client.Pages;
using LoFit_Models.Dtos;

namespace LoFit_Client.SpaEngine.Interfaces;

public interface ISpaEngineService
{
    TrainingSetDto TrainingSetDto { get; set;}
    TrainingSetDetailsDto PrevTrainingSetDetailsDto{get; set;}
    TrainingSetDetailsDto NewTrainingSetDetailsDto{get; set;}
    void TransitionTo(SpaEngineState newSpaState);
    SpaEngineStatesEnum GetCurrentStateName();
    void StartTraining();
    void AddNewTrainingSet();
    void SaveNewTraining();
    void StartTrainingSet(TrainingSetDto trainingDto);
    void SetPrevTrainingSetDetailsDto(TrainingSetDetailsDto prevTrainingSetDetailsDto);
    void FinishTraining(TrainingSetDetailsDto newTrainingSetDetailsDto);
    void ReturnToInit();
}