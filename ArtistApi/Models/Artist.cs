namespace ArtistApi.Models;

public class Artist : BaseModel
{
    public string Name { get; set; }
    public List<Album> Albums { get; set; } = new();
}