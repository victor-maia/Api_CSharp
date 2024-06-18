using Microsoft.AspNetCore.Mvc;
using MyFirstCsApi.Communication.Response;
using MyFirstCsApi.Communication.Requests;

namespace MyFirstCsApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    [HttpGet]
    // [Route("{id}/{nickname}")]
    public IActionResult Get([FromHeader]int id, [FromHeader]string nickname)
    {
        var response = new User
        {
            Id = id,
            Name = "Victor",
            Age = 18

        };

        return Ok(response);

    }

    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisteredUserJson), StatusCodes.Status201Created)]

    public IActionResult Create([FromBody] RequestRegisterUserJson request) {

        var response = new ResponseRegisteredUserJson
        {
            Id = request.Id,
            Name = request.Name,
        };

        return Created(string.Empty, response);
    }

    [HttpPut]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [Route("{id}")];
    public IActionResult Update(
        [FromRoute] int id,
        [FromBody]RequestUpdateUserProfileJson request)
    {

        return NoContent();
    }

}
