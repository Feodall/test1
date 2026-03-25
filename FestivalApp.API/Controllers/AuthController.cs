using Microsoft.AspNetCore.Mvc;
using SampleApp.API.Data;
using SampleApp.API.Entities;
using SampleApp.API.Models;

namespace SampleApp.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController(SampleAppContext db) : ControllerBase
{

    // Post api/Auth
    [HttpPost]
    public ActionResult<User> Login([FromQuery] string login, [FromQuery] string password)
    {

        var user = db.Users.Where(u => u.Login == login && u.Password == password).FirstOrDefault();
        if (user == null) return NotFound("Invalid login and password");

        return Ok(user);
    }

    // Post api/Auth
    [HttpPost("loginDto")]
    public ActionResult<User> Login(LoginDto loginDtop)
    {

        var user = db.Users.Where(u => u.Login == loginDtop.Login && u.Password == loginDtop.Password).FirstOrDefault();
        if (user == null) return NotFound("Invalid login and password");

        return Ok(user);
    }

}