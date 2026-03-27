using FestivalApp.API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FestivalApp.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    [HttpGet]
    public ActionResult<List<User>> GetUsers()
    {

        return Ok(users);
    }
    
}
