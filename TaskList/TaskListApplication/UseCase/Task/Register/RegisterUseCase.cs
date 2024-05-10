using TaskListCommunication.Requests;
using TaskListCommunication.Responses;

namespace TaskListApplication.UseCase.Task.Register;

public class RegisterUseCase
{
    public ResponseRegisterTask Execute(RequestTask request)
    {
        return new ResponseRegisterTask
        {
            Id = 2,
            Name = request.Name,
            Description = request.Description,
            Priority = request.Priority,
            Status = request.Status,
            Deadline = request.Deadline,
        };
    }
}
