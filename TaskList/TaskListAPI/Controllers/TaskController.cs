using Microsoft.AspNetCore.Mvc;
using TaskListApplication.UseCase.Delete;
using TaskListApplication.UseCase.Task.GetAll;
using TaskListApplication.UseCase.Task.GetById;
using TaskListApplication.UseCase.Task.Register;
using TaskListApplication.UseCase.Task.Update;
using TaskListCommunication.Requests;
using TaskListCommunication.Responses;

namespace TaskListAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TaskController : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(ResponseRegisterTask), StatusCodes.Status201Created)]
    public IActionResult Created([FromBody] RequestTask request)
    {
        var useCase = new RegisterUseCase();

        var response = useCase.Execute(request);

        return Created(string.Empty, response);
    }

    [HttpGet]
    [Route("all")]
    [ProducesResponseType(typeof(ResponseAllTasks), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult AllTasks()
    {
        var useCase = new GetAllUseCase();

        var response = useCase.Execute();

        if (response.Tasks.Any())
        {
            return Ok(response);
        } 
        else
        {
            return NoContent();
        }
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseTask), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseError), StatusCodes.Status404NotFound)]
    public IActionResult GetById([FromRoute] int id)
    {
        var useCase = new GetByIdUseCase();

        var response = useCase.Execute(id);

        return Ok(response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseError), StatusCodes.Status404NotFound)]
    public IActionResult Update([FromRoute] int id, [FromBody] RequestTask request)
    {
        var useCase = new UpdateUseCase();

        useCase.Execute(id, request);

        return NoContent();
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseError), StatusCodes.Status404NotFound)]
    public IActionResult Delete([FromRoute] int id)
    {
        var useCase = new DeleteUseCase();

        useCase.Execute(id);

        return NoContent();
    }
}
