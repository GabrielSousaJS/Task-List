using TaskListCommunication.Responses;
using TaskListCommunication.Enums;

namespace TaskListApplication.UseCase.Task.GetById;

public class GetByIdUseCase
{
    public ResponseTask Execute(int id)
    {
        return new ResponseTask
        {
            Id = id,
            Name = "Organizar pastas",
            Description = "No computador, existem várias pastas em que está com muitas divergências",
            Deadline = new DateTime(year: 2024, month: 5, day: 11),
            Priority = Priority.Medium,
            Status = Status.InProgress,
        };
    }
}
