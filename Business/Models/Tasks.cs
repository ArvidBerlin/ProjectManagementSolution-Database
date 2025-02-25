namespace Business.Models;

public class Tasks // Medveten om att detta namn är plural, stötte för sent på problem med redan existerande namn,
                   // ändrade det till plural för att inte behöva ändra på namnet i databasen (samt namn för TaskAssignment)
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string? Description { get; set; }
}
