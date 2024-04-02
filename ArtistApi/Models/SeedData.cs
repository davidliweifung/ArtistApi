using ArtistApi.Data;
using Microsoft.EntityFrameworkCore;

namespace ArtistApi.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new ArtistApiContext(serviceProvider.GetRequiredService<DbContextOptions<ArtistApiContext>>());

        if (context.Artist.Any())
        {
            return;
        }

        var artist = new Artist()
        {
            Name = "Dave",
            Albums = new()
            {
                new Album()
                {
                    Name = "Album1",
                    Created = DateTime.Now,
                    LastModified = DateTime.Now,
                }
            },
            Created = DateTime.Now,
            LastModified = DateTime.Now
        };

        context.Artist.AddRange(artist);
        context.SaveChanges();
    }
}
