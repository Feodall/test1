using Microsoft.AspNetCore.Mvc;
using SampleApp.API.Data;
using SampleApp.API.Entities;

namespace SampleApp.API.Controllers;

[ApiController]
[Route("api/[controller]")]

public class RegionsControllers(SampleAppContext db) : ControllerBase
{
    [HttpGet]
    public ActionResult <List<Region>> GetResult()
    {
        return Ok(db.Regions.ToList());
    }
    [HttpPost]
    public ActionResult<Region> CreateRegion(Region region)
    {
        db.Regions.Add(region);
        db.SaveChanges();
        return Ok(region);
    }
    
    [HttpPut("{id}")]
    public ActionResult<Region> GetRegion(int id, Region region)
    {
        var currentregion = db.Regions.Find(id);
        if (currentregion == null) return NotFound($"No region with id = {id}");

        currentregion.Name = region.Name;
        
        return Ok(region);    
    
    }

    [HttpGet("find/{id}")]
    public ActionResult<Region> FindRegion(int id)
    {
        var region = db.Regions.Find(id);
        if(region == null) return NotFound($"No region with id = {id}");
        
        return Ok(region);
    }

    [HttpDelete("{id}")]
    public ActionResult<bool> DeleteRegion(int id)
    {
        var region = db.Regions.Find(id);
        if(region == null) return NotFound($"No region with id = {id}");
       
        db.Regions.Remove(region);
        db.SaveChanges();

        return Ok(true);
    }





}