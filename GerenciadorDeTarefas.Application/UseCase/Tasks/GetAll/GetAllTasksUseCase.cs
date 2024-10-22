using GerenciadorDeTarefas.Communication.Responses;
namespace GerenciadorDeTarefas.Application.UseCase.Tasks.GetAll;

public class GetAllTasksUseCase
{
    public ResponseAllTaskJson Execute()
    {
        return new ResponseAllTaskJson
        {
            Tasks = new List<ResponseShortTaskJson>
        {
            new ResponseShortTaskJson
            {
                Id = 1,
                Name = "NodeJs",
                Priority = Communication.Enums.TaskPriority.Média
            },
            new ResponseShortTaskJson
            {
                Id = 2,
                Name = "C#",
                Priority = Communication.Enums.TaskPriority.Alta
            }

        }
        };
    }    
}
