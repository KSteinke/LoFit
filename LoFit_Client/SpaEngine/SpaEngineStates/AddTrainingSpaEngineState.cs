using LoFit_Models.Dtos;

namespace LoFit_Client.SpaEngine.SpaEngineStates;

public class AddTrainingSpaEngineState:SpaEngineState
{
    public AddTrainingSpaEngineState()
    {
        SpaEngineStateName = SpaEngineStatesEnum.AddTraining;
    }

    public override void SaveNewTraining(TrainingSetDto newTrainingSetDto)
    {
        //TODO - Add patch operation with new item response validation and coherency check
        //Get current List of training sets, add new item to list, update List of training sets.
        var currTrainingSetDtos = this.spaEngineService.TrainingSetDtos;
        List<TrainingSetDto> newTrainingSetDtosList = currTrainingSetDtos.ToList();
        newTrainingSetDtosList.Add(newTrainingSetDto);
        this.spaEngineService.TrainingSetDtos = newTrainingSetDtosList;
        

        this.spaEngineService.TransitionTo(new ListTrainingsSpaEngineState());
    }
}