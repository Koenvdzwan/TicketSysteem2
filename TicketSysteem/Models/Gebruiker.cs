using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace TicketSysteem.Models
{
    public class Gebruiker
    {
        public int Id { get; set; }
        [Required]
        public string Voornaam { get; set; }
        public string Tussenvoegsel { get; set; }
        [Required]
        public string Achternaam { get; set; }
        [Required]
        public string EmailAdres { get; set; }
        public string Telefoonnummer { get; set; }

        public string VolledigeNaam()
        {
            return Voornaam + Tussenvoegsel + Achternaam;

        }
    }
}
