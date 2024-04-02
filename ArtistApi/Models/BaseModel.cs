namespace ArtistApi.Models;

public class BaseModel
{
    public long Id { get; set; }
    public DateTime Created { get; set; }
    public DateTime LastModified { get; set; }
}