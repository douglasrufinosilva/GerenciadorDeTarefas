using GerenciadorDeTarefas.Application.UseCase.Tasks.Create;
using GerenciadorDeTarefas.Application.UseCase.Tasks.Delete;
using GerenciadorDeTarefas.Application.UseCase.Tasks.GetAll;
using GerenciadorDeTarefas.Application.UseCase.Tasks.GetById;
using GerenciadorDeTarefas.Application.UseCase.Tasks.Update;
using GerenciadorDeTarefas.Communication.Requests;
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
        ResponseAllTaskJson response = new GetAllTasksUseCase().Execute();

        if(response.Tasks.Any())
        {
            return Ok(response);            
        }

        return NoContent();
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseTaskJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]

    public IActionResult GetById([FromRoute] int id)
    {
        ResponseTaskJson response = new GetTaskByIdUseCase().Execute(id);

        return Ok(response);
    }

    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisteredTaskJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    public IActionResult Create([FromBody] RequestTaskJson request)
    {
        ResponseRegisteredTaskJson response = new CreateTaskUseCase().Execute(request);

        return Created(string.Empty, response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
    public IActionResult Update([FromRoute] int id, [FromBody] RequestTaskJson request)
    {
        var useCase = new UpdateTaskUseCase();
        useCase.Execute(id, request);

        return NoContent();
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
    public IActionResult Delete([FromRoute] int id)
    {
        var useCase = new DeleteTaskUseCase();
        useCase.Execute(id);

        return NoContent();
    }
}
