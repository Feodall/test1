using System.ComponentModel;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using SampleApp.API.Data;
using SampleApp.API.Entities;

namespace SampleApp.API.Controllers;
    [ApiController]    
    [Route("/api[controller]")]
public class CompetenceControllers(SampleAppContext db) : ControllerBase
{


    [HttpGet]
    public ActionResult <List<Competence>> GetResult()
    {
        return Ok(db.Competences.ToList());
    }

    
    [HttpPost]
    public ActionResult<Competence> CreateCompetence(Competence competence)
    {
        db.Competences.Add(competence);
        db.SaveChanges();
        return competence;
    }

    [HttpPut("{id}")]
    public ActionResult<Competence> GetCompetence(int id, Competence competence)
    {
        var currentCompetence = db.Competences.Find(id);
        if (currentCompetence == null) return NotFound($"No competence with id = {id}");

        currentCompetence.Name = competence.Name;
        currentCompetence.Task = competence.Task;

        return Ok(currentCompetence);
    }

    [HttpGet("find/{id}")]
    public ActionResult<Competence>  FindCompetence(int id)
    {
        var competence = db.Competences.Find(id);
        if (competence == null) return NotFound($"No competence with id = {id}");
        return Ok(competence);
    }

    [HttpDelete("{id}")]
    public ActionResult<bool> DeleteCompetence(int id)
    {
        var competence = db.Competences.Find(id);
        if(competence == null) return NotFound($"No comprtrnce with id = {id}");
        
        db.Competences.Remove(competence);
        db.SaveChanges();
        return Ok(true);
    }


}