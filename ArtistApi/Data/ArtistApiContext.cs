using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ArtistApi;

namespace ArtistApi.Data;

public class ArtistApiContext : DbContext
{
    public ArtistApiContext(DbContextOptions<ArtistApiContext> options)
        : base(options)
    {
    }

    public DbSet<Models.Album> Album { get; set; } = default!;
    public DbSet<Models.Artist>? Artist { get; set; }
    public DbSet<Models.Song>? Song { get; set; }
}
