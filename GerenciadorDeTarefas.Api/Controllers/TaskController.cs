using GerenciadorDeTarefas.Application.UseCase.Tasks.Create;
using GerenciadorDeTarefas.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorDeTarefas.Api.Controllers;
[Route("[controller]")]
[ApiController]
public class TaskController : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(ResponseAllTaskJson), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetAll()
    {
        ResponseAllTaskJson response = new GetAllTaskUseCase().Execute();

        if(response.Tasks.Any())
        {
            return Ok(response);            
        }

        return NoContent();
    }
}
