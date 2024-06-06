namespace Course.Model;

public class Athlete
{
    public string AthleteId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string PhotoUrl { get; set; } 
    public double Height { get; set; } 
    public double Weight { get; set; } 
    public string Country { get; set; }
    public string Sport { get; set; }
    public string ClubOrTeam { get; set; }
    public string Coach { get; set; }
    public List<string> PersonalRecords { get; set; }
    public List<Game> Games { get; set; } = new List<Game>();

    public Athlete()
    {
        PersonalRecords = new List<string>();
        Games = new List<Game>();
    }
}