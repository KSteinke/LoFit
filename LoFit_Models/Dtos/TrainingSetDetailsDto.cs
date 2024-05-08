namespace LoFit_Models.Dtos;

public record TrainingSetDetailsDto
{
    public Guid Id {get; set;}
    public string Name {get; set;}
    public List<ExerciseDetailsDto> ExerciseDetailsDtos {get; set;}
}