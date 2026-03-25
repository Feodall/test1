using System.ComponentModel;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using SampleApp.API.Data;
using SampleApp.API.Entities;

namespace SampleApp.API.Controllers;
    [ApiController]    
    [Route("/api[controller]")]
public class ApplicationControllers(SampleAppContext db) : ControllerBase
{


    [HttpGet]
    public ActionResult <List<Application>> GetResult()
    {
        return Ok(db.Applications.ToList());
    }

    [HttpPost]
    public ActionResult<Application> CreateApplication(Application application)
    {
        db.Applications.Add(application);
        db.SaveChanges();
        return application;
    }

    // [HttpPut("{id}")]
    // public ActionResult<Application> GetApplication (int id, Application application)
    // {
    //     var currentApplicatoin = db.Applications.Find(id);
    //     if (currentapplication == null) return NotFound($"No application with id = {id}");

    //     currentApplicatoin.RegionId = application.RegionId;

    //     db.Update(currentApplicatoin);
    //     db.SaveChanges();
        
        
        
    //     return Ok(application);
    // }

    [HttpGet("find/{id}")]
    public ActionResult<Application> FindApplication(int id)
    {
        var application = db.Applications.Find(id);
        if (application ==  null) return NotFound($"No application with id = {id}");
        return Ok(application);
    }

    [HttpDelete("{id}")]
    public ActionResult<bool> DeleteApplication(int id)
    {
        var application = db.Applications.Find(id);
        if (application == null) return NotFound($"No application with id = {id}");

        db.Applications.Remove(application);
        db.SaveChanges();

        return Ok(true);

    }


}