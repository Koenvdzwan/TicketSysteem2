using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace TicketSysteem.Models
{
    public class TicketDbContext : DbContext
    {
        public TicketDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Applicatie>()
                .HasOne(x => x.Beheerder);
            modelBuilder.Entity<Ticket>()
                .HasOne(x => x.Klant);
            modelBuilder.Entity<Ticket>()
                .HasOne(x => x.Status);
        }

        public DbSet<Gebruiker> Gebruikerers { get; set; }
        public DbSet<Medewerker> Medewerkers { get; set; }
        public DbSet<Klant> Klanten { get; set; }
        public DbSet<Applicatie> Applicaties { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Status> Statussen { get; set; }

        }
}
