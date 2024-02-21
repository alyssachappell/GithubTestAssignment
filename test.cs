using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class ExampleController : ControllerBase
{
    [HttpGet("getdata")]
    public IActionResult GetData(string name)
    {
        // Replace this with your actual logic to fetch data
        var data = new { message = $"Hello, {name}!" };

        return Ok(data);
    }

}
