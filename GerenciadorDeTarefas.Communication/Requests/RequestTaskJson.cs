using GerenciadorDeTarefas.Communication.Enums;

namespace GerenciadorDeTarefas.Communication.Requests;

public class RequestTaskJson
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime EndDate { get; set; }
    public TaskPriority Priority { get; set; }
    public TaskStatusEnum Status { get; set; }
}
