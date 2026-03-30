namespace SampleApp.API.Entities;

public class Application
{
    public int Id {get; set;}
    
    public int UserId {get; set;}
    public User? User {get; set;} 

    public int CompetenceId {get; set;}
    public Competence? Competence {get; set;}

    public int RegionId {get; set;}
    public Region? Region {get; set;}
    
}