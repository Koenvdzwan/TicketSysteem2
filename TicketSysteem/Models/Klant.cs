using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSysteem.Models
{
    public class Klant : Gebruiker
    {
        public Ticket Ticket { get; set; }
    }
}
