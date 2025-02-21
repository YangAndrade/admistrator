using Administrator.Application.UseCase.Task.Create;
using Administrator.Application.UseCase.Task.Delete;
using Administrator.Application.UseCase.Task.GetAllTaskById;
using Administrator.Application.UseCase.Task.GetTaskById;
using Administrator.Application.UseCase.Task.Update;
using Admistrator.Communication.Requests;
using Admistrator.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace Administrator.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdministratorController : ControllerBase
    {
        [HttpPost("create-task")]
        [ProducesResponseType(typeof(ResponseCreateJson), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
        public IActionResult Create([FromBody] RequestTaskJson request)
        {
            var response = new CreateUseCase().Execute(request);

            return Created(string.Empty,response);
        }

        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
        public IActionResult Update([FromRoute] int id, [FromBody] RequestTaskJson request)
        {
            var useCase = new UpdateUseCase();
            useCase.Execute(id,request);
            return NoContent();
        }
        [HttpDelete]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
        public IActionResult Delete(int id)
        {
            var useCase = new DeleteUseCase();
            useCase.Execute(id);

            return NoContent();
        }

        [HttpGet("get-all-task")]
        [ProducesResponseType(typeof(ResponseAllTaskJson), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult GetAllTask()
        {
            var response = new GetAllTaskUseCase().Execute();
            if (response.Tasks.Any())
            {
                return Ok(response);
            }
            return NoContent();
        }

        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(ResponseTaskJson), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
        public IActionResult Get(int id)
        {
            var response = new GetTaskByIdUseCase().Execute(id);
            return Ok(response);
        }

    }
}
