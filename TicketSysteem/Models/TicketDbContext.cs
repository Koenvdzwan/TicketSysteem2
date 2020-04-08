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

            modelBuilder.Entity<Status>()
                .HasData(
                    new Status() {Id = -1, Volgorde = 100, Naam = "Nieuw"},
                    new Status() {Id = -2, Volgorde = 200, Naam = "In behandeling"},
                    new Status() {Id = -3, Volgorde = 300, Naam = "Afgehandeld"}
                    );
        }

        public DbSet<Gebruiker> Gebruikerers { get; set; }
        public DbSet<Medewerker> Medewerkers { get; set; }
        public DbSet<Klant> Klanten { get; set; }
        public DbSet<Applicatie> Applicaties { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Status> Statussen { get; set; }

        }
}
