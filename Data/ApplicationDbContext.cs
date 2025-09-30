using Microsoft.EntityFrameworkCore;
using Travel_Service.Models.Entity;

namespace Travel_Service.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<TravelPackage> TravelPackages { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Flight> Flights { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    base.OnModelCreating(modelBuilder);

    // Seed Users
    modelBuilder.Entity<User>().HasData(
        new User { CustomerId = 1, Name = "Purity Ihansek", Email = "purity@example.com", PasswordHash = "hashed123", Country = "Nigeria" },
        new User { CustomerId = 2, Name = "Jane Doe", Email = "jane@example.com", PasswordHash = "hashed456", Country = "France" }
    );

    // Seed Hotels
    modelBuilder.Entity<Hotel>().HasData(
        new Hotel { HotelId = 1, HotelName = "Hilton Dubai", HotelLocation = "Dubai" },
        new Hotel { HotelId = 2, HotelName = "Eiffel View", HotelLocation = "Paris" }
    );

    // Booking → TravelPackage
    modelBuilder.Entity<Booking>()
        .HasOne(b => b.TravelPackage)
        .WithMany()
        .HasForeignKey(b => b.PackageId)
        .OnDelete(DeleteBehavior.Restrict);

    // Booking → User
    modelBuilder.Entity<Booking>()
        .HasOne(b => b.User)
        .WithMany()
        .HasForeignKey(b => b.CustomerId)
        .OnDelete(DeleteBehavior.Restrict);

    // Booking → Room
    modelBuilder.Entity<Booking>()
        .HasOne(b => b.Room)
        .WithMany(r => r.Bookings)
        .HasForeignKey(b => b.RoomId)
        .OnDelete(DeleteBehavior.Restrict);

    // Room → Hotel
    modelBuilder.Entity<Room>()
        .HasOne(r => r.Hotel)
        .WithMany(h => h.Rooms)
        .HasForeignKey(r => r.HotelId)
        .OnDelete(DeleteBehavior.Cascade);

    // ✅ Seed Travel Packages FIRST
    // Seed Travel Packages FIRST
    modelBuilder.Entity<TravelPackage>().HasData(
        new TravelPackage 
        { 
            PackageId = 1, 
            PackageClass = "Luxury", 
            Amount = "2500", 
            Destination = "Dubai", 
            NoOfDays = 5 
        },
        new TravelPackage 
        { 
            PackageId = 2, 
            PackageClass = "Standard", 
            Amount = "1800", 
            Destination = "Paris", 
            NoOfDays = 3 
        }
    );

// Seed Flights AFTER, explicitly linked
    modelBuilder.Entity<Flight>().HasData(
        new Flight 
        { 
            FlightId = 1, 
            Airline = "Emirates", 
            DepartureLocation = "Lagos", 
            ArrivalLocation = "Dubai", 
            Amount = "1200", 
            Class = FlightClass.Economy
            
        },
        new Flight 
        { 
            FlightId = 2, 
            Airline = "Air France", 
            DepartureLocation = "Lagos", 
            ArrivalLocation = "Paris", 
            Amount = "1100", 
            Class = FlightClass.Business
            
        }
    );

}

    }
}
