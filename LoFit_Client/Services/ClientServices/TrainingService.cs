namespace LoFit_Client.Services.ClientServices;

using System.Net;
using System.Net.Http.Json;
using LoFit_Client.Services.ClientServices.Interfaces;
using LoFit_Models.Dtos;
using LoFit_Models.MockupData;

public class TrainingService:ITrainingService
{
    private readonly HttpClient httpClient;
    public TrainingService(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }

    public async Task<IEnumerable<TrainingSetDto>> ListTrainingsAsync()
    {
        return await MockupData.MockUpListTrainingsAsync();
        /*
        try
        {
            var responese = await this.httpClient.GetAsync($"api/v1/Trainings/ListTrainings");
            if(responese.IsSuccessStatusCode)
            {
                if(responese.StatusCode == HttpStatusCode.NoContent)
                {
                    throw new Exception("Error when recieving trainings list! HttpStatusCode: NoContnent");
                }

                if(responese.StatusCode == HttpStatusCode.OK)
                {
                    var content = await responese.Content.ReadFromJsonAsync<IEnumerable<TrainingSetDto>>();
                    return content;
                }
                else
                {
                    var message = await responese.Content.ReadAsStringAsync();
                    throw new Exception(message);
                }                
            }
            else
            {
                var message = await responese.Content.ReadAsStringAsync();
                throw new Exception(message);
            }
        }  
        catch (Exception)
        {
            throw;
        }
        */
    }
    
    public async Task<TrainingSetDetailsDto> GetTrainingSetDetailsAsync(TrainingSetDto trainingSetDto)
    {
        return  await MockupData.GetTrainingSetDetailsDto();
    }
}