namespace ArtistApi.Models;

public class Album : BaseModel
{
    public string Name { get; set; }
    public int YearReleased { get; set; }
    public List<Song> Songs { get; set; } = new();
}