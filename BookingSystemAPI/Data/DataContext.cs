using BookingAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BookingAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options): base(options) 
        { 

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Stylist> Stylists { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Slot> Slots { get; set; }
    }
}
