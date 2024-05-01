namespace LoFit_Models.Dtos;

public record TrainingSetDetailsDto
{
    public Guid Id {get; set;}
    public string Name {get; set;}
    public IEnumerable<ExerciseDetailsDto> ExerciseDetailsDtos {get; set;}
}