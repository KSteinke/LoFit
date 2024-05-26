namespace LoFit_Models.Dtos;

public record ExerciseDetailsDto
{
    public Guid Id {get; set;}
    public string? Name {get; set;} 
    
    public int PrevWeight {get; set;}

    public int PrevRepetitions {get; set;}

    public TimeSpan PrevExerciseTime {get; set;}

}