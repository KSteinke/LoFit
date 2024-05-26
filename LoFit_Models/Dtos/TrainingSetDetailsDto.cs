namespace LoFit_Models.Dtos;

public class TrainingSetDetailsDto
{
    public Guid Id {get; set;}
    public string Name {get; set;}
    public List<ExerciseDetailsDto> ExerciseDetailsDtos {get; set;} 

    public TrainingSetDetailsDto DeepClone()
    {
        TrainingSetDetailsDto Clone = new TrainingSetDetailsDto();
        Clone.Id = Id;
        Clone.Name = Name;
        Clone.ExerciseDetailsDtos = new List<ExerciseDetailsDto>();
        foreach(var exerciseDetails in ExerciseDetailsDtos)
        {
            ExerciseDetailsDto excerciseClone = new ExerciseDetailsDto{ 
                Id = exerciseDetails.Id, 
                Name = exerciseDetails.Name, 
                PrevWeight = exerciseDetails.PrevWeight,
                PrevRepetitions = exerciseDetails.PrevRepetitions,
                PrevExerciseTime = exerciseDetails.PrevExerciseTime 
                };
            Clone.ExerciseDetailsDtos.Add(excerciseClone);
        }

        return Clone;
    }

}