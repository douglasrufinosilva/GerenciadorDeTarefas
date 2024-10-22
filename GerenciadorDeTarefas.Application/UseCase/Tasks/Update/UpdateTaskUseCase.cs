using GerenciadorDeTarefas.Communication.Requests;

namespace GerenciadorDeTarefas.Application.UseCase.Tasks.Update;

public class UpdateTaskUseCase
{
    public void Execute(int id, RequestTaskJson request)
    {
        new RequestTaskJson
        {
            Name = request.Name,
            Description = request.Description,
            Priority = request.Priority,
            Status = request.Status,
            EndDate = request.EndDate
        };
    }
}
