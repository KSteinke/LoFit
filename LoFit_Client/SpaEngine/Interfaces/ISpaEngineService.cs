namespace LoFit_Client.SpaEngine.Interfaces;

public interface ISpaEngineService
{
    void TransitionTo(SpaEngineState newSpaState);
    SpaEngineStatesEnum GetCurrentStateName();
    void StartTraining();
    void AddNewTrainingSet();
    void SaveNewTraining();
    void StartTrainingSet();
    void FinishTraining();
    void ReturnToInit();
}