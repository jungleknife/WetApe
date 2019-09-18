using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAppWetApe.Models;

namespace WebAppWetApe.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Venue> Venues { get; set; }
        public DbSet<EventCategory> EventCategories { get; set; }
        public DbSet<Event> Events { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            builder.Entity<EventAttendee>()
     .HasKey(ea => new { ea.EventId, ea.AttendeeId });

            builder.Entity<EventAttendee>()
                .HasOne(ea => ea.Event)
                .WithMany(a => a.Attendees)
                .HasForeignKey(ea => ea.EventId);

            builder.Entity<EventAttendee>()
                .HasOne(ea => ea.Attendee)
                .WithMany(e => e.BookedEvents)
                .HasForeignKey(bc => bc.AttendeeId);
        }
    }
}
