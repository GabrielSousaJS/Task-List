using TaskListCommunication.Responses;

namespace TaskListApplication.UseCase.Task.GetAll;

public class GetAllUseCase
{
    public ResponseAllTasks Execute()
    {
        return new ResponseAllTasks
        {
            Tasks =
            [
                new ResponseShortTask
                {
                    Id = 1,
                    Name = "Lavar",
                    Deadline = new DateTime(year: 2024, month: 7, day: 11),
                },
                new ResponseShortTask
                {
                    Id = 2,
                    Name = "Limpar",
                    Deadline = new DateTime(year: 2024, month: 7, day: 13),
                },
                new ResponseShortTask
                {
                    Id = 3,
                    Name = "Cuidar",
                    Deadline = new DateTime(year: 2024, month: 7, day: 14),
                }
            ]
        };
    }
}
