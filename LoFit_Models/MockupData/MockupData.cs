using LoFit_Models.Dtos;

namespace LoFit_Models.MockupData;


public static class MockupData
{
    // Metoda zwracająca listę treningów synchronicznie
    public static IEnumerable<ListTrainingsDto> ListTrainings()
    {
        // Tworzenie mockup danych
        var mockupList = new List<ListTrainingsDto>
        {
            // Dodawanie przykładowych treningów
            new ListTrainingsDto { Id = Guid.NewGuid(), Name = "Morning Yoga" },
            new ListTrainingsDto { Id = Guid.NewGuid(), Name = "Evening Pilates" },
            new ListTrainingsDto { Id = Guid.NewGuid(), Name = "Afternoon Zumba" }
        };

        return mockupList;
    }

    // Metoda asynchroniczna zwracająca listę treningów
    public static Task<IEnumerable<ListTrainingsDto>> MockUpListTrainingsAsync()
    {
        // Zwracanie gotowego mockupu synchronicznie jako zadanie ukończone
        return Task.FromResult(ListTrainings());
    }
}