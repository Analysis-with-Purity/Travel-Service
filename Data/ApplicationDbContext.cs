using Microsoft.EntityFrameworkCore;
using Travel_Service.Models.Entity;

namespace Travel_Service.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<User> Customers { get; set; }
        public DbSet<TravelPackages> Packages { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        
    }
}
