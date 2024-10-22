using GerenciadorDeTarefas.Communication.Requests;
using GerenciadorDeTarefas.Communication.Responses;

namespace GerenciadorDeTarefas.Application.UseCase.Tasks.Create;

public class CreateTaskUseCase
{
    public ResponseRegisteredTaskJson Execute(RequestTaskJson request)
    {
        RequestTaskJson task = new RequestTaskJson
        {
            Name = request.Name,
            Description = request.Description,
            Priority = request.Priority,
            Status = request.Status,
            EndDate = request.EndDate
        };

        return new ResponseRegisteredTaskJson
        {
            Id = 88,
            Name = request.Name
        };
    }
}
