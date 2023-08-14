using Microsoft.EntityFrameworkCore;

namespace TravelApi.Models
{
    public class TravelApiContext : DbContext
    {
        DbSet<Destination> Destinations { get; set; }
        DbSet<Review> Reviews { get; set; }
        public TravelApiContext(DbContextOptions<TravelApiContext> options) : base(options)
        {
        }
    }
}