namespace GerenciadorDeTarefas.Communication.Responses;

public class ResponseAllTaskJson
{
    public List<ResponseShortTaskJson> Tasks { get; set; } = new List<ResponseShortTaskJson>();
}
