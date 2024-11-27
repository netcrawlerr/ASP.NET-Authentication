using Api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[Route("api/resources")]
[ApiController]
public class ResourcesController : ControllerBase
{
    [HttpGet]
    [Authorize]
    public async Task<IActionResult> GetResources()
    {
        var resourcesList = new List<Resource>
        {
            new Resource
            {
                Id = 1,
                Name = "Resource 1",
                Description = "This is resource 1",
            },
            new Resource
            {
                Id = 2,
                Name = "Resource 2",
                Description = "This is resource 2",
            },
            new Resource
            {
                Id = 3,
                Name = "Resource 3",
                Description = "This is resource 3",
            },
            new Resource
            {
                Id = 4,
                Name = "Resource 4",
                Description = "This is resource 4",
            },
        };

        return await Task.FromResult(Ok(resourcesList));
    }
}