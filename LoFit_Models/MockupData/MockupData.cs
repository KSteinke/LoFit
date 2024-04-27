using LoFit_Models.Dtos;

namespace LoFit_Models.MockupData;


public static class MockupData
{
    // Metoda zwracająca listę treningów synchronicznie
    public static IEnumerable<TrainingSetDto> ListTrainings()
    {
        // Tworzenie mockup danych
        var mockupList = new List<TrainingSetDto>
        {
            // Dodawanie przykładowych treningów
            new TrainingSetDto { Id = Guid.NewGuid(), Name = "Morning Yoga" },
            new TrainingSetDto { Id = Guid.NewGuid(), Name = "Evening Pilates" },
            new TrainingSetDto { Id = Guid.NewGuid(), Name = "Afternoon Zumba" }
        };

        return mockupList;
    }

    // Metoda asynchroniczna zwracająca listę treningów
    public static Task<IEnumerable<TrainingSetDto>> MockUpListTrainingsAsync()
    {
        // Zwracanie gotowego mockupu synchronicznie jako zadanie ukończone
        return Task.FromResult(ListTrainings());
    }
}