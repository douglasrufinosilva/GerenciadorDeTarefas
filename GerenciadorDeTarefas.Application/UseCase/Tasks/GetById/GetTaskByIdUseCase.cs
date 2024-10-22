using GerenciadorDeTarefas.Communication.Responses;

namespace GerenciadorDeTarefas.Application.UseCase.Tasks.GetById;

public class GetTaskByIdUseCase
{
    public ResponseTaskJson Execute(int id)
    {
        return new ResponseTaskJson
        {
            Id = id,
            Name = "NodeJs",
            Description = "Buscar aprimorar conhecimentos usando NodeJs",
            Priority = Communication.Enums.TaskPriority.Média,
            Status = Communication.Enums.TaskStatusEnum.Aguardando,
            EndDate = new DateTime(year: 2025, month: 01, day: 15)
        };
    }
}
