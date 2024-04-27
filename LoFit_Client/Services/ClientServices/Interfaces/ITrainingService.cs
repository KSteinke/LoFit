using LoFit_Models.Dtos;

namespace LoFit_Client.Services.ClientServices.Interfaces;

public interface ITrainingService
{
    Task<IEnumerable<TrainingSetDto>> ListTrainingsAsync();
}