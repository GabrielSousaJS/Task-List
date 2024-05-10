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
            Description = "No computador, existem v�rias pastas em que est� com muitas diverg�ncias",
            Deadline = new DateTime(year: 2024, month: 5, day: 11),
            Priority = Priority.Medium,
            Status = Status.InProgress,
        };
    }
}
