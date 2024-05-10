using TaskListCommunication.Enums;

namespace TaskListCommunication.Requests;

public class RequestTask
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public Priority Priority { get; set; }
    public Status Status { get; set; }
    public DateTime Deadline { get; set; }
}
