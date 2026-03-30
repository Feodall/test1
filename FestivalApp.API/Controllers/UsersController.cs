using Microsoft.AspNetCore.Mvc;
using SampleApp.API.Data;
using SampleApp.API.Entities;

namespace SampleApp.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController(SampleAppContext db) : ControllerBase
{

    [HttpGet]
    public ActionResult<List<User>> GetUsers()
    {
        return Ok(db.Users.ToList());
    }

    // POST api/Users
    [HttpPost]
    public ActionResult<User> CreateUser(User user)
    {
        db.Users.Add(user);
        db.SaveChanges();
        return Ok(user);
    }


    // PUT api/Users/3
    [HttpPut("{id}")]
    public ActionResult<User> GetUsers(int id, User user)
    {

        var currentUser = db.Users.Where(u => u.Id == id).FirstOrDefault();

        if (currentUser == null) return NotFound($"No user with id = {id}");

        currentUser.Education = user.Education;
        currentUser.Email = user.Email;
        currentUser.Name = user.Name;
        currentUser.Surname = user.Surname;
        currentUser.Patronymic = user.Patronymic;

        db.Update(currentUser);
        db.SaveChanges();

        return Ok(currentUser);
    }

    // GET api/Users/3

    [HttpGet("find/{id}")]
    public ActionResult<User> FindUser(int id)
    {

        var user = db.Users.Find(id);
        if (user == null) return NotFound($"No user with id = {id}");


        return Ok(user);
    }

    // DELETE api/Users/3
    [HttpDelete("{id}")]
    public ActionResult<bool> DeleteUser(int id)
    {
        var user = db.Users.Find(id);
        if (user == null) return NotFound($"No user with id = {id}");

        db.Users.Remove(user);
        db.SaveChanges();

        return Ok(true);
    }

}