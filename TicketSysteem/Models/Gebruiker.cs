using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace TicketSysteem.Models
{
    public class Gebruiker
    {
        public int Id { get; set; }
        public string Voornaam { get; set; }
        public string Tussenvoegsel { get; set; }
        public string Achternaam { get; set; }
        public string EmailAdres { get; set; }
        public string Telefoonnummer { get; set; }

        public string VolledigeNaam()
        {
            return Voornaam + Tussenvoegsel + Achternaam;

        }
    }
}
