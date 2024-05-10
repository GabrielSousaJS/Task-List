using TaskListCommunication.Enums;

namespace TaskListCommunication.Responses;

public class ResponseShortTask
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime Deadline { get; set; }
}
