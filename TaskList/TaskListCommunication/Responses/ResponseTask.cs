using TaskListCommunication.Enums;

namespace TaskListCommunication.Responses;

public class ResponseTask
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public Priority Priority { get; set; }
    public Status Status { get; set; }
    public DateTime Deadline { get; set; }
}
