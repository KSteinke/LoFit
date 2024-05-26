using LoFit_Client.Pages;
using LoFit_Models.Dtos;

namespace LoFit_Client.SpaEngine.SpaEngineStates;

public class TrainingSpaEngineState:SpaEngineState
{
    public TrainingSpaEngineState()
    {
        SpaEngineStateName = SpaEngineStatesEnum.Training;
    }

    public override void FinishTraining(TrainingSetDetailsDto newTrainingSetDetailsDto)
    {
        this.spaEngineService.NewTrainingSetDetailsDto = newTrainingSetDetailsDto;
        this.spaEngineService.TransitionTo(new SummarySpaEngineState());
        //TODO - Delete debuging part
        Console.WriteLine("Old:");
        foreach(var x in this.spaEngineService.PrevTrainingSetDetailsDto.ExerciseDetailsDtos)
        {
            Console.WriteLine(x.Name + " " + x.PrevWeight + "kg " + "Repets:" + x.PrevRepetitions + "Time:" + x.PrevExerciseTime);
        }
        Console.WriteLine("New:");
        foreach(var x in this.spaEngineService.NewTrainingSetDetailsDto.ExerciseDetailsDtos)
        {
            Console.WriteLine(x.Name + " " + x.PrevWeight + "kg " + "Repets:" + x.PrevRepetitions + "Time:" + x.PrevExerciseTime);
        }
    }
}