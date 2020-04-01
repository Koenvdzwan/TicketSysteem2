using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSysteem.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public Applicatie Applicatie { get; set; }
        public Klant Klant { get; set; }

        public string Onderwerp { get; set; }

        public string Omschrijving { get; set; }

        public Status Status { get; set; }

    }
}
